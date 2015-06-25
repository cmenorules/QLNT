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

        public bool SetupConnection(string path)
        {
            try
            {
                strConnection = @"Data Source=" + path + ";Integrated Security=True";
                _con = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
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
        public DataSet Read(string sql_query, string table_name)
        {
            SqlConnection sql_con = OpenConnnection();
            DataSet data_set = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql_query, sql_con);
            adapter.Fill(data_set, table_name);
            adapter.Dispose();
            return data_set;
        }
        public bool Write(string sql_query)
        {      
            try
            {
                SqlConnection sql_con = OpenConnnection();
                SqlCommand sql_cmd = new SqlCommand(sql_query, sql_con);
                sql_cmd.ExecuteNonQuery();
                sql_cmd.Dispose();

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"data.txt", true))
                {
                    file.WriteLine(sql_query);
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
