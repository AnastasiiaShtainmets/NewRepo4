using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualification
{
    public partial class FormStudent : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        private string id;
        public FormStudent(string _id)
        {
            id = _id;
            InitializeComponent();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

            reloadScolarshipTable();
            reloadReportCardTable();

            

        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            FormSchedule form = new FormSchedule(id);
            this.Hide();
            form.Show();
        }

        private void referenceButton_Click(object sender, EventArgs e)
        {
            FormRegerence form = new FormRegerence(id);
            this.Hide();
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormStudent form = new FormStudent(id);
            this.Hide();
            form.Show();
        }

        private void reloadScolarshipTable()
        {
            DataTable table = new DataTable();

            string commandString = $"select Сумма_академической_стипендии, Социальная_стипендия, Сумма_дополнительной_стипендии, Сумма_всех_стипендий from Стипендия where id = '{id}'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void reloadReportCardTable()
        {
            DataTable table = new DataTable();

            string commandString = $"select Количество_отлично, Количество_хорошо, Количество_удовлетворительно, Наличие_задолженностей from Табель_студентов where id = '{id}'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);
            dataGridView3.DataSource = table;
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сумма социальной стипендии = 4500 руб.");
        }
    }
}
