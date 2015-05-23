using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyDinhDuongDAL
    {
        private DataConnection dt_con = DataConnection.getInstance();
        public bool ThemDinhDuong(int makehoach, int buoi, string thu, int tuan, string ngayThangNam, string monChinh, string monCanh, string monPhu, string monTrangMieng)
        {            
            dt_con.Write("insert into DINHDUONG values(makehach ,N'"+ buoi + "',N'" +  thu + "',N'" +  tuan + "',N'" +  ngayThangNam + "',N'" +  monChinh + "',N'" +  monCanh + "',N'" +  monPhu + "',N'" +  monTrangMieng+ "')");
            return true;
        }
    }
}
