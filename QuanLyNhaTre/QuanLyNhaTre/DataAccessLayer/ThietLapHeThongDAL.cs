using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.DataAccessLayer
{
    class ThietLapHeThongDAL
    {
        DataConnection dtCon = DataConnection.getInstance();
        string dataSource;
        string initialCatalog;

        public ThietLapHeThongDAL(string path, string databaseName)
        {
            dtCon.SetupConnection(path);
            dataSource = path;
            initialCatalog = databaseName;
        }

        public bool TaoDatabase()
        {
            string sqlCheck = "select name from master.dbo.sysdatabases where ('[' + name + ']' = '" + initialCatalog + "' OR name = '" + initialCatalog + "')";
            if (dtCon.Read(sqlCheck).Rows.Count == 0)
            {
                string sqlCreateDatabase = "create database " + initialCatalog;
                dtCon.Write(sqlCreateDatabase);
                dtCon.Write("use " + initialCatalog);
                string[] sql_query = File.ReadAllLines(@"..\..\Resources/SQLQuery.txt");
                foreach (string sql in sql_query)
                    dtCon.Write(sql);
                return true;
            }
            MessageBox.Show("Tên database này đã tồn tại. Vui lòng nhập lại tên khác", "Thông báo");
            return false;
        }

        public void NhapThongTinTruong(string ten, string diaChi, string email, int sdt)
        {
            string sql_query = "insert into THONGTINNHATRE values ('" + ten + "', '" + diaChi + "', '" + email + "', " + sdt + ")";
            dtCon.Write(sql_query);

            sql_query = "insert into KHOI values ('Mầm')";
            dtCon.Write(sql_query);
            sql_query = "insert into KHOI values ('Chồi')";
            dtCon.Write(sql_query);
            sql_query = "insert into KHOI values ('Lá')";
            dtCon.Write(sql_query);
        }

        public void ThietLapTaiKhoanQuanTri(string ten, string email, string matKhau)
        {
            string sql_query = "insert into NHANVIEN values ('" + ten + "', '" + email + "', '" + matKhau + "')";
            dtCon.Write(sql_query);
        }
    }
}
