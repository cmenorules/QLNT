using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyDinhDuongDAL
    {
        private DataConnection dt_con = DataConnection.getInstance();
        public bool ThemDinhDuong(int makehoach, int buoi, string thu, int tuan, string ngayThangNam, string monChinh, string monCanh, string monPhu, string monTrangMieng)
        {
            try
            {
                dt_con.Write("insert into DINHDUONG values(" + makehoach + "," + buoi + ",N'" + thu + "'," + tuan + ",N'" + ngayThangNam + "',N'" + monChinh + "',N'" + monCanh + "',N'" + monPhu + "',N'" + monTrangMieng + "')");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro! Không Thể Thêm Dinh Dưỡng");
                return false;
            }
        }

        public DataTable LayDSKhoi()
        {
            return dt_con.Read("select * from KHOI");
        }

        public DataTable LayDSLop(int namHoc, int khoi)
        {
            string sqlQuery = "select KEHOACHGIANGDAY.MaKeHoach, (TenKhoi +' - ' + cast(MaKeHoach as varchar(10))) as TenLop from KEHOACHGIANGDAY, CHUONGTRINHHOC, KHOI where KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and KEHOACHGIANGDAY.NamHoc = '" + namHoc + "' and CHUONGTRINHHOC.MaKhoi =" + khoi;
            return dt_con.Read(sqlQuery);
        }
    }
}
