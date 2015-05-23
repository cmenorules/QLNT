using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class DangNhapDAL
    {
        DataConnection dtCon = DataConnection.getInstance();
        private string dataSource;
        private string initialCatalog;

        public DangNhapDAL()
        {
            string[] setting = File.ReadAllLines(@"..\..\Resources/setting.xml");
            dataSource = setting[0];
            initialCatalog = setting[1];
            dtCon.SetupConnection(dataSource, initialCatalog);       
        }

        public bool KiemTraDangNhap(string email, string matKhau)
        {
            string sql_query = "select * from NHANVIEN where NHANVIEN.Email = '" + email + "' and NHANVIEN.MatKhau = '" + matKhau + "'";
            DataTable dataTable = dtCon.Read(sql_query);
            if (dataTable.Rows.Count == 0)
                return false;
            else
                return true;
        }

        public DataTable LayThongTinDangNhap(string email, string matKhau)
        {
            return dtCon.Read("select * from NHANVIEN where Email = '" + email + "' and  MatKhau = '" + matKhau + "'");
        }
    }
}
