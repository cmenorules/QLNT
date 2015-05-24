using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class DataConnection
    {
        private static DataConnection instance = new DataConnection();
        string strConnection;
        SqlConnection _con;

        private DataConnection() { }

        public static DataConnection getInstance()
        {
            return instance; 
        }

        public void SetupConnection(string path, string databaseName)
        {
            strConnection = @"Data Source=" + path + "; Initial Catalog =" + databaseName + ";Integrated Security=True";
            _con = new SqlConnection(strConnection);
        }

        public void SetupConnection(string path)
        {
            strConnection = @"Data Source=" + path + ";Integrated Security=True";
            _con = new SqlConnection(strConnection);
        }

        private SqlConnection OpenConnnection()
        {
            if (_con.State != System.Data.ConnectionState.Open)
            {
                _con.Open();
            }
            return _con;
        }
        //ghi xuống database
        public DataTable Read(string sql_query)
        {
            //mo ket noi
            SqlConnection sql_con = OpenConnnection();
            DataTable data_table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_query, sql_con);
            adapter.Fill(data_table);
            adapter.Dispose();
            return data_table;
        }
        public void Write(string sql_query)
        {            
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"..\..\Resources/data.txt", true))
            {
                file.WriteLine(sql_query);
            }

            SqlConnection sql_con = OpenConnnection();
            SqlCommand sql_cmd = new SqlCommand(sql_query, sql_con);            
            sql_cmd.ExecuteNonQuery();
            sql_cmd.Dispose(); 
        }
    }
}
