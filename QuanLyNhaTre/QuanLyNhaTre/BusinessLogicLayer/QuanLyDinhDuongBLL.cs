using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class QuanLyDinhDuongBLL
    {
        QuanLyNhaTre.DataAccessLayer.QuanLyDinhDuongDAL _qldd = new DataAccessLayer.QuanLyDinhDuongDAL();
        public void ThemDinhDuong(int makehoach, int buoi, string thu, int tuan, string ngayThangNam, string monChinh, string monCanh, string monPhu, string monTrangMieng)
        {
            _qldd.ThemDinhDuong(makehoach, buoi, thu, tuan, ngayThangNam, monChinh, monCanh, monPhu, monTrangMieng);
        }
    }
}
