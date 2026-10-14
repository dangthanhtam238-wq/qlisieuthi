using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public class Database
    {
        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLySieuThi;User ID=sa;Password=123456";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}