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

        public void NhapThongTinTruong(string ten, string diaChi, string email, long sdt)
        {
            string sql_query = "insert into THONGTINNHATRE values (N'" + ten + "', N'" + diaChi + "', '" + email + "', " + sdt + ")";
            dtCon.Write(sql_query);

            #region thong tin khoi
            sql_query = "insert into KHOI values (N'M?m')";
            dtCon.Write(sql_query);
            sql_query = "insert into KHOI values (N'Ch?i')";
            dtCon.Write(sql_query);
            sql_query = "insert into KHOI values (N'Lá')";
            dtCon.Write(sql_query);
            #endregion

            #region thong tin phong hoc
            for (int i = 1; i < 10; i++)
                dtCon.Write("insert into PHONGHOC values ('" + i + "')");
            #endregion

            #region thong tin nhom nguoi dung
            dtCon.Write("insert into NHOMNGUOIDUNG values (1,N'Hiệu trưởng')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (2,N'Hiệu phó chuyên môn')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (3,N'Hiệu phó bán trú')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (4,N'Kế toán')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (5,N'Văn thư')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (6,N'Nhân viên cấp dưỡng')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (7,N'Nhân viên y tế')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (8,N'Giáo viên')");
            #endregion
        }

        public void ThietLapTaiKhoanQuanTri(string ten, string email, string matKhau)
        {
            string sql_query = "insert into NHANVIEN values (N'" + ten + "', '" + email + "', '" + matKhau + "')";
            dtCon.Write(sql_query);
        }
    }
}
