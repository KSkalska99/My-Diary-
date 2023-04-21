using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace My_diary.DbConnection
{
    internal class DbCon
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
        public SqlConnection? Connection { get; private set; }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
