using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SD = System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Qualification
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private string id;
       



        public void openConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == SD.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

      

        private void enterButton_Click(object sender, EventArgs e)
        {
            
            string Login = loginTextBox.Text.ToString();
            string Password = passwordTextBox.Text.ToString();
            string NameTable;

            if (Login == "" || Password == "") //проверка логина и пароля на наличие символов
            {
                MessageBox.Show("Вы не заполнили необходимые поля!");
            }

            if (employeeRadioButton.Checked) //присвоение имени таблице
            {
                NameTable = "Секретарь";
                if (!Check(Login, Password, NameTable)){
                    NameTable = "Бухгалтер";
                }
            }
            else
            {
                NameTable = "Студенты";
            }

            openConnection();

            
              if (Check(Login, Password, NameTable))
            {
                if (id == "1")
                {
                    FormSecretary form = new FormSecretary();
                    this.Hide();
                    form.Show();
                }
                else if (id == "2")
                {
                    FormAccountant form = new FormAccountant();
                    this.Hide();
                    form.Show();
                }
                else
                {
                    FormStudent form = new FormStudent(id);
                    this.Hide();
                    form.Show();

                }

            } else
            {
               
                MessageBox.Show("Данного пользователя нет в базе!\nПроверьте, пожалуйста свои данные.");
            }
             
            closeConnection();


        }
        private Boolean Check(string login, string password, string nameTable) //проверка
        {
            DataTable table = new DataTable();
            string Login = login;
            string Password = password;
            string NameTable = nameTable;


            Password = CreateMD5(Password);

            string commandString = $"select id, Логин, Пароль from {NameTable} where Логин='{Login}' and Пароль='{Password}'";


            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                id = table.Rows[0].ItemArray[0].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string CreateMD5(string input) //шифрование пароля
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void deleteTextButton_Click(object sender, EventArgs e) //очистка полей
        {
            FormSecretary form = new FormSecretary();
            this.Hide();
            form.Show();
            loginTextBox.Text = " ";
            passwordTextBox.Text = "";
        }

    }
}
