using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace quanlynhasach.HeThongLuuTru
{
    class DataAccess
    {
        protected static String _connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=QLNS.mdb";
        static OleDbConnection connection;
        public static void OpenConnection()
        {
            try
            {
                connection = new OleDbConnection(_connectionString);
                connection.Open();
            }
            catch
            {

            }

        }
        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        public static DataTable ExcuQuery(string sql)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public static void ExcuNonQuery(string sql)
        {
            OpenConnection();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
