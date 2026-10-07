using System.Data.SqlClient;

namespace QuanLySieuThi
{
    public class Database
    {
        private string connectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLySieuThi;Integrated Security=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}