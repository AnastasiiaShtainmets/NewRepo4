using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SD = System.Data;

namespace Qualification
{
    public partial class FormSecretarySchedule : Form
    {
        public FormSecretarySchedule()
        {
            InitializeComponent();
        }
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        

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


        private void backButton_Click(object sender, EventArgs e)
        {
            FormSecretary form = new FormSecretary();
            this.Hide();
            form.Show();
        }

        private void chandingTheScheduleButton_Click(object sender, EventArgs e)
        {           
            string Group = groupTextBox.Text.ToString();
            string Discipline = disciplineTextBox.Text.ToString();
            string Day;
            string Couple = coupleTextBox.Text.ToString(); //пара
            if (Couple == "" || Group == "" || Couple == "")
            {
                MessageBox.Show("Вы указали не все данные");

            }  else {

                if (MondayRadioButton.Checked)
                {
                    Day = "Понедельник";
                }
                else if (TuesdayRadioButton.Checked)
                {
                    Day = "Вторник";
                }
                else if (WednesdayRadioButton.Checked)
                {
                    Day = "Среда";
                }
                else if (ThursdayRadioButton.Checked)
                {
                    Day = "Четверг";
                }
                else
                {
                    Day = "Пятница";
                }
                openConnection();
                SqlTransaction transaction = sqlConnection.BeginTransaction();

                SqlCommand command = sqlConnection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = $"Update {Day} Set [{Couple}] = '{Discipline}' where Номер_группы = '{Group}'"; //изменение расписания
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Изменения успешно внесены");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка!\nПовторите попытку");
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }


        }

        private void FormSecretarySchedule_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet47.Пятница". При необходимости она может быть перемещена или удалена.
            this.пятницаTableAdapter2.Fill(this.qualificationDataSet47.Пятница);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet46.Четверг". При необходимости она может быть перемещена или удалена.
            this.четвергTableAdapter2.Fill(this.qualificationDataSet46.Четверг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet45.Среда". При необходимости она может быть перемещена или удалена.
            this.средаTableAdapter2.Fill(this.qualificationDataSet45.Среда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet44.Вторник". При необходимости она может быть перемещена или удалена.
            this.вторникTableAdapter2.Fill(this.qualificationDataSet44.Вторник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet43.Понедельник". При необходимости она может быть перемещена или удалена.
            this.понедельникTableAdapter2.Fill(this.qualificationDataSet43.Понедельник);

        }
    }
}
