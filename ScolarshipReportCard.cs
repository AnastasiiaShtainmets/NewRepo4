using System.Data.SqlClient;
using SD = System.Data;

namespace Qualification
{
    public class ScolarshipReportCard
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public string FIO;
        public double sumAcadScol;
        public bool isSocScol;
        public double sumDopScol;
        public double sumScol = 0;



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
        public ScolarshipReportCard(string _FIO, double _sumAcadScol, bool _isSocScol, double _sumDopScol)
        {

            FIO = _FIO;
            sumAcadScol = _sumAcadScol;
            isSocScol = _isSocScol;
            sumDopScol = _sumDopScol;
           
        }


        public double calculate() // подсчет стипендии
        {
            double sum = sumAcadScol + sumDopScol;
            if (isSocScol)
            {
                sum += 4500;
            }
            sumScol = sum;
            return sum;
        }

    }
}
