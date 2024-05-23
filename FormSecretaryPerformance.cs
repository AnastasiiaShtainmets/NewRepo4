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
using SD = System.Data;


namespace Qualification
{
    public partial class FormSecretaryPerformance : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public FormSecretaryPerformance()
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

        private void FormSecretaryPerformance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet32.Табель_студентов". При необходимости она может быть перемещена или удалена.
            //this.табель_студентовTableAdapter.Fill(this.qualificationDataSet32.Табель_студентов);
            reloadStudentTabelTable();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {

                SqlCommand sqlCommand = new SqlCommand("Update Табель_студентов set Номер_карточки = @Номер_карточки, ФИО = @ФИО, Студент_1курса_1семестра = @Студент_1курса_1семестра, Количество_отлично = @Количество_отлично, Количество_хорошо = @Количество_хорошо, Количество_удовлетворительно = @Количество_удовлетворительно, Наличие_задолженностей = @Наличие_задолженностей where id = @id", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Номер_карточки", dataGridView1.Rows[i].Cells[0].Value);
                sqlCommand.Parameters.AddWithValue("@id", dataGridView1.Rows[i].Cells[1].Value);
                sqlCommand.Parameters.AddWithValue("@ФИО", dataGridView1.Rows[i].Cells[2].Value);
                sqlCommand.Parameters.AddWithValue("@Студент_1курса_1семестра", dataGridView1.Rows[i].Cells[3].Value);
                sqlCommand.Parameters.AddWithValue("@Количество_отлично", dataGridView1.Rows[i].Cells[4].Value);
                sqlCommand.Parameters.AddWithValue("@Количество_хорошо", dataGridView1.Rows[i].Cells[5].Value);
                sqlCommand.Parameters.AddWithValue("@Количество_удовлетворительно", dataGridView1.Rows[i].Cells[6].Value);
                sqlCommand.Parameters.AddWithValue("@Наличие_задолженностей", dataGridView1.Rows[i].Cells[7].Value);


                openConnection();
                sqlCommand.ExecuteNonQuery();
                closeConnection();

                

            }
            reloadStudentTabelTable();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            FormSecretary form = new FormSecretary();
            this.Hide();
            form.Show();
        }
        private void reloadStudentTabelTable()
        {
            DataTable table = new DataTable();

            string commandString = $"select Номер_карточки, id, ФИО, Студент_1курса_1семестра, Количество_отлично, Количество_хорошо, Количество_удовлетворительно, Наличие_задолженностей from Табель_студентов";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}
