using System.Data.SqlClient;

namespace pizzaDeliveryApp.Models
{
    public class DataBase
    {
        public SqlConnection connection;

        public DataBase()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "Verd1cT@kov";
            builder.InitialCatalog = "PizzaDelivery";

            connection = new SqlConnection(builder.ConnectionString);
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
                return false;
            }
        }

        public bool CloseConnection()
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