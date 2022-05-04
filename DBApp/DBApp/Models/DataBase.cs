using System.Data.SqlClient;
using System;

namespace DBApp.Models
{
    public class DataBase
    {
        public SqlConnection connection;

        public DataBase()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";
                builder.UserID = "sa";
                builder.Password = "Verd1cT@kov";
                builder.InitialCatalog = "ПИ-2-20_Нафиков_ТуристическоеАгентсво";

                Console.WriteLine("Connecting database...");
                connection = new SqlConnection(builder.ConnectionString);

                Console.WriteLine("Sucess!");

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }

            catch (SqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        break;
                    case 1045:
                        break;
                }

                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }


    }
}