using System.Data.SqlClient;

namespace WindowsFormsApp1.DAL
{
    public class DBConnect
    {
        protected string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClinicDB;Integrated Security=True";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}