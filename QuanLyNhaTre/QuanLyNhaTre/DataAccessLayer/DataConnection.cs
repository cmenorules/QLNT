using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class DataConnection
    {
        const string strConnection = @"Data Source=TRANMINHLUAN\SQLEXPRESS;Initial Catalog=ABC;Integrated Security=True";
        SqlConnection _con;
        public DataConnection()
        {
            //moi may co mot duong dan rieng
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
            SqlConnection sql_con = OpenConnnection();
            SqlCommand sql_cmd = new SqlCommand(sql_query, sql_con);
            sql_cmd.ExecuteNonQuery();
            sql_cmd.Dispose();
        }
    }
}
