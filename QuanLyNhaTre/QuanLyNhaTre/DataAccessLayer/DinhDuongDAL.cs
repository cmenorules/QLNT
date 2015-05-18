using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class DinhDuongDAL
    {
        private DataConnection dt_con = new DataConnection();
        public bool ThemDinhDuong(string makehoach, string buoi, string thu, string tuan, string ngayThangNam, string monChinh, string monCanh, string monPhu, string monTrangMieng) {
            dt_con.Write("insert into DINHDUONG values('',makehoach, buoi, thu, tuan, ngayThangNam, monChinh, monCanh, monPhu, monTrangMieng)");
            return true;
        }
    }
}
