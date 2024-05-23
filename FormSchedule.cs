using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Qualification
{
    public partial class FormSchedule : Form
    {
        private string id;
        private string NumGroup;
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public FormSchedule(string _id)
        {
            id = _id;

            DataTable table = new DataTable();

            string commandString = $"select Группа from Студенты where id = '{id}'"; //определение группы студента
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);

            NumGroup = table.Rows[0].ItemArray[0].ToString();

            InitializeComponent();
        }
        

        private void FormSchedule_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reloadScheduleTableFor("Понедельник");
            dataGridView2.DataSource = reloadScheduleTableFor("Вторник");
            dataGridView3.DataSource = reloadScheduleTableFor("Среда");
            dataGridView4.DataSource = reloadScheduleTableFor("Четверг");
            dataGridView5.DataSource = reloadScheduleTableFor("Пятница");

        }

        

        private void backButton_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent(id);
            this.Hide();
            form.Show();
        }

        private DataTable reloadScheduleTableFor(string day)
        {
            DataTable table = new DataTable();

            string commandString = $"select [1], [2], [3], [4], [5], [6] from {day} where Номер_группы = '{NumGroup}'"; //заполнение расписания
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);
            return table;
        }
                        
    }
}
