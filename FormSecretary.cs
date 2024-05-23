using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SD = System.Data;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Qualification
{
    public partial class FormSecretary : Form
    {

        int newStudents;

        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public FormSecretary()
        {
            InitializeComponent();
        }

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

        private void FormSecretary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet48.Справки". При необходимости она может быть перемещена или удалена.
            this.справкиTableAdapter3.Fill(this.qualificationDataSet48.Справки);
            reloadStudentTable();

            



        }

        private void scheduleSecretaryButton_Click(object sender, EventArgs e)
        {
            FormSecretarySchedule form = new FormSecretarySchedule();
            this.Hide();
            form.Show();
        }

        private void performanceButton_Click(object sender, EventArgs e)
        {
            FormSecretaryPerformance form = new FormSecretaryPerformance();
            this.Hide();
            form.Show();
        }

        public static string CreateMD5(string input)
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
        private void passwordButton_Click(object sender, EventArgs e)
        {
            string Password = passwordTextBox.Text.ToString();
            Password = CreateMD5(Password);
            passwordTextBox.Text = Password.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int oldStudents = dataGridView1.Rows.Count - newStudents-1;


            for (int i = 0; i < oldStudents; i++)
            {

                SqlCommand sqlCommand = new SqlCommand("Update Студенты set Логин = @Логин, Пароль = @Пароль, Группа = @Группа, Номер_карточки = @Номер_карточки, Номер_счета = @Номер_счета where ФИО = @ФИО", sqlConnection);
               
                sqlCommand.Parameters.AddWithValue("@Логин", dataGridView1.Rows[i].Cells[0].Value);
                sqlCommand.Parameters.AddWithValue("@Пароль", dataGridView1.Rows[i].Cells[1].Value);
                sqlCommand.Parameters.AddWithValue("@ФИО", dataGridView1.Rows[i].Cells[2].Value);
                sqlCommand.Parameters.AddWithValue("@Группа", dataGridView1.Rows[i].Cells[3].Value);
                sqlCommand.Parameters.AddWithValue("@Номер_карточки", dataGridView1.Rows[i].Cells[4].Value);
                sqlCommand.Parameters.AddWithValue("@Номер_счета", dataGridView1.Rows[i].Cells[5].Value);

                openConnection();
                sqlCommand.ExecuteNonQuery();
                closeConnection();


            }
            for (int i = oldStudents; i < dataGridView1.Rows.Count-1; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("Insert Студенты values (@Логин, @Пароль, @ФИО, @Группа, @Номер_карточки, @Номер_счета, 1)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Логин", dataGridView1.Rows[i].Cells[0].Value);
                sqlCommand.Parameters.AddWithValue("@Пароль", dataGridView1.Rows[i].Cells[1].Value);
                sqlCommand.Parameters.AddWithValue("@ФИО", dataGridView1.Rows[i].Cells[2].Value);
                sqlCommand.Parameters.AddWithValue("@Группа", dataGridView1.Rows[i].Cells[3].Value);
                sqlCommand.Parameters.AddWithValue("@Номер_карточки", dataGridView1.Rows[i].Cells[4].Value);
                sqlCommand.Parameters.AddWithValue("@Номер_счета", dataGridView1.Rows[i].Cells[5].Value);

                openConnection();
                sqlCommand.ExecuteNonQuery();
                closeConnection();

                sqlCommand = new SqlCommand($"Insert Табель_студентов values (@Номер_карточки,{oldStudents+i}, @ФИО, 0, 0, 0, 0, 0, 2,1)", sqlConnection); 

                sqlCommand.Parameters.AddWithValue("@Номер_карточки", dataGridView1.Rows[i].Cells[5].Value);
                sqlCommand.Parameters.AddWithValue("@ФИО", dataGridView1.Rows[i].Cells[2].Value);

                openConnection();
                sqlCommand.ExecuteNonQuery();
                closeConnection();

                sqlCommand = new SqlCommand($"Insert Стипендия values (@Номер_счета,{oldStudents + i}, @ФИО, 0, 0, 0, 0, 2)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Номер_счета", dataGridView1.Rows[i].Cells[4].Value);
                sqlCommand.Parameters.AddWithValue("@ФИО", dataGridView1.Rows[i].Cells[2].Value);

                openConnection();
                sqlCommand.ExecuteNonQuery();
                closeConnection();
            }
            newStudents = 0;

            reloadStudentTable();
            MessageBox.Show("Сохранение прошло успешно");
        }

        

        private void reloadStudentTable()
        {
            DataTable table = new DataTable();

            string commandString = $"select Логин, Пароль, ФИО, Группа, Номер_карточки, Номер_счета from Студенты";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            newStudents += 1;
        }
    }
}
