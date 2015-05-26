using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class QuanLyDinhDuongBLL
    {
        QuanLyNhaTre.DataAccessLayer.QuanLyDinhDuongDAL qlddDAL = new DataAccessLayer.QuanLyDinhDuongDAL();
        public void ThemDinhDuong(int makehoach, int buoi, string thu, int tuan, string ngayThangNam, string monChinh, string monCanh, string monPhu, string monTrangMieng)
        {
            try
            {
                qlddDAL.ThemDinhDuong(makehoach, buoi, thu, tuan, ngayThangNam, monChinh, monCanh, monPhu, monTrangMieng);
            }
            catch (Exception e)
            {
            }
        }

        public DataTable LayDSKhoi()
        {
            return qlddDAL.LayDSKhoi();
        }

        public DataTable LayDSLop(int namHoc, int maKhoi)
        {
            return qlddDAL.LayDSLop(namHoc, maKhoi);
        }
    }
}
