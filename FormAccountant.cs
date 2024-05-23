using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using SD = System.Data;


namespace Qualification
{
    public partial class FormAccountant : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
        public FormAccountant()
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
        private void FormAccountant_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet5.Стипендия". При необходимости она может быть перемещена или удалена.
            this.стипендияTableAdapter1.Fill(this.qualificationDataSet5.Стипендия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet3.Табель_студентов". При необходимости она может быть перемещена или удалена.
            this.табель_студентовTableAdapter1.Fill(this.qualificationDataSet3.Табель_студентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet1.Табель_студентов". При необходимости она может быть перемещена или удалена.
            // this.табель_студентовTableAdapter.Fill(this.qualificationDataSet1.Табель_студентов);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "qualificationDataSet.Стипендия". При необходимости она может быть перемещена или удалена.

        }

        private void calculateScholarship_Click(object sender, EventArgs e) //подсчет академической стипендии
        {
            string selectedId = dataGridViewStudentReportCard.Rows[dataGridViewStudentReportCard.CurrentRow.Index].Cells[0].Value.ToString();
            StudentsReportCard src = new StudentsReportCard(selectedId);

            sumScolarship.Text = src.calculate().ToString();
        }

        private void calculateAndSaveButton_Click(object sender, EventArgs e) //подсчет суммы всех стипендий
        {

            var row = dataGridViewGrants.Rows[dataGridViewGrants.CurrentRow.Index];
            string FIO = row.Cells[0].Value.ToString();
            double sumAcadScol = Convert.ToDouble(row.Cells[1].Value);
            bool isSocScol = Convert.ToBoolean(row.Cells[2].Value);
            double sumDopScol = Convert.ToDouble(row.Cells[3].Value);


            ScolarshipReportCard csrc = new ScolarshipReportCard(FIO, sumAcadScol, isSocScol, sumDopScol);
            row.Cells[4].Value = csrc.calculate();
            //csrc.Save();

        }

        private void saveButton_Click(object sender, EventArgs e) //обновление таблицы в БД
        {
            
            for (int i = 0; i < dataGridViewGrants.Rows.Count - 1; i++)
            {
                SqlCommand sqlCommand = new SqlCommand("Update Стипендия set Сумма_академической_стипендии = @Сумма_академической_стипендии, Социальная_стипендия = @Социальная_стипендия, Сумма_дополнительной_стипендии = @Сумма_дополнительной_стипендии, Сумма_всех_стипендий = @Сумма_всех_стипендий where ФИО = @ФИО", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ФИО", dataGridViewGrants.Rows[i].Cells[0].Value);
                sqlCommand.Parameters.AddWithValue("@Сумма_академической_стипендии", dataGridViewGrants.Rows[i].Cells[1].Value);
                sqlCommand.Parameters.AddWithValue("@Социальная_стипендия", dataGridViewGrants.Rows[i].Cells[2].Value);
                sqlCommand.Parameters.AddWithValue("@Сумма_дополнительной_стипендии", dataGridViewGrants.Rows[i].Cells[3].Value);
                sqlCommand.Parameters.AddWithValue("@Сумма_всех_стипендий", dataGridViewGrants.Rows[i].Cells[4].Value);

                openConnection();
                sqlCommand.ExecuteNonQuery();
                closeConnection();
            }
            
            MessageBox.Show("Сохранение прошло успешно");
        }
    }
}
