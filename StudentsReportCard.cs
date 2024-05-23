using System;
using SD = System.Data;
using System.Data.SqlClient;
using System.Data;

namespace Qualification
{
    public class StudentsReportCard
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-I18GSI5; Initial Catalog=Qualification; Integrated Security=True");
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        public string FIO;
        public bool isFirstSem;
        public int numberOfFive;
        public int numberOfFour;
        public int numberOfThree;
        public bool isDebts;



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


        public StudentsReportCard(string fio) //вывод данных о студенте
        {
            openConnection();
            string commandString = $"select ФИО, Студент_1курса_1семестра, Количество_отлично, Количество_хорошо, Количество_удовлетворительно, Наличие_задолженностей from Табель_студентов where ФИО='{fio}'"; 

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            DataTable table = new DataTable();

            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(table);

               FIO = table.Rows[0].ItemArray[0].ToString();
               isFirstSem = Convert.ToBoolean(table.Rows[0].ItemArray[1]);
               numberOfFive = Convert.ToInt32(table.Rows[0].ItemArray[2]);
               numberOfFour = Convert.ToInt32(table.Rows[0].ItemArray[3]);
               numberOfThree = Convert.ToInt32(table.Rows[0].ItemArray[4]);
               isDebts = Convert.ToBoolean(table.Rows[0].ItemArray[5]);
           

        }

        public double calculate() //определение суммы академической стипендии
        {
            if(isDebts || (numberOfThree > 0))
            {
                return 0;
            }
            if (isFirstSem)
            {
                return 7341.43;
            }

            if(numberOfFive == 0)
            {
                return 5849.32;
            } else if (numberOfFour > numberOfFive)
            {
                return 8321.96;
            } else if (numberOfFour < numberOfFive)
            {
                return 10532.45;
            }
            else
            {
                return 12477.45;
            }
            
        }

    }
}
