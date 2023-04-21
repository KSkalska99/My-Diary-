//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace My_diary.DbConnection
//{
//    internal class DBConnection
//    {
//        private DBConnection() { }
//        public string Server { get; set; }
//        public string DatabaseName { get; set; }
//        public string Login { get; set; }
//        public string Password { get; set; }

  
//        private MySqlConnection Connection { get; set; }
//        private static DBConnection _instance = null;
//        public static DBConnection Instance()
//        {
//            if(_instance == null)
//                _instance = new DBConnection();
//            return _instance;
//        }
//        public bool IsConnect()
//        {
//            if(Connection == null)
//            {
//                if (String.IsNullOrEmpty(DatabaseName))
//                    return false;
//                string connectionString = string.Format("Server={0}; database={1}; UID={2}; password={3}", Server, DatabaseName, Login, Password);
//                Connection = new MySqlConnection(connectionString);
//                Connection.Open();
//            }
//            return true;
//        }
//        public void Close(){
//            Connection.Close();
//        }



//    }
//}
