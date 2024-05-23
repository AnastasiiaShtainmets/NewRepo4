using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using SD = System.Data;

namespace Qualification
{
    public partial class FormRegerence : Form
    {
        private string id;
        public FormRegerence(string _id) //получение id студента
        {
            id = _id;
            InitializeComponent();
        }
        

        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

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
        

        private void certOfStudyButton_Click(object sender, EventArgs e) //справка об обучении
        {                     
            openConnection();
            SqlTransaction transaction = sqlConnection.BeginTransaction();

            SqlCommand command = sqlConnection.CreateCommand();
            command.Transaction = transaction;

            string Quantity = quantityTextBox.Text.ToString();

            if (Quantity == "")
            { 
                MessageBox.Show("Вы не указали количество необходимых справок"); 
            }
            else
            {
                try
                {
                    command.CommandText = $"INSERT Справки VALUES (1,0,NULL,NULL, {Quantity}, {id}, 1)"; //внесение справки в БД
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Справка оформлена");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так! \nПовторите попытку");
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }
            closeConnection();
          }
            

        private void certOfScholarshipButton_Click(object sender, EventArgs e) //справка об обучении
        {           
                openConnection();
                SqlTransaction transaction = sqlConnection.BeginTransaction();

                SqlCommand command = sqlConnection.CreateCommand();
                command.Transaction = transaction;

                string Quantity = quantityTextBox.Text.ToString();
                DateTime From = fromDateTimePicker.Value;
                DateTime Until = untilDateTimePicker.Value;

            if (Quantity == "")
            {
                MessageBox.Show("Вы не указали количество необходимых справок");
            }
            else if (From == Until)
            {
                MessageBox.Show("Вы неверно указали период");

            } else
            {
                try
                {
                    command.CommandText = $"INSERT Справки VALUES (0,1,'{From}','{Until}',{Quantity}, {id}, 1)"; //сохранение справки
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Справка оформлена");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так! \nПовторите попытку");
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }
            closeConnection();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent(id);
            this.Hide();
            form.Show();
        }

        
    }
}
