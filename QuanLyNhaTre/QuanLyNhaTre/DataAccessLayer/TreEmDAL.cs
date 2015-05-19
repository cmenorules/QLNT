using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class TreEmDAL
    {
        private DataConnection dt_con = DataConnection.getInstance();
        public bool  ThemTreEm(string maPhuHuynh, string hoTen, string tenThanMat, string gioiTinh, string ngaySinh,
            string danToc, string tonGiao, string doiTuongUuTien, string tinhCach, string thoiQuen, string maHoSoTreEm)
        {
            dt_con.Write("insert into TREEM values ('',maPhuHuynh, hoTen, tenThanMat, gioiTinh, ngaySinh,danToc, tonGiao, doiTuongUuTien, tinhCach, thoiQuen, maHoSoTreEm)");
            return true;
        }
        public bool ThemHoSoTreEm(string hoTenCha, string hoTenMe, string hoTenNguoiGiamHo, string emailNguoiGiamHo, string soDienThoaiNguoiGiamHo,string DiaChi)
        {
            dt_con.Write("insert into HOSOTREEM values('',hoTenCha, hoTenMe, hoTenNguoiGiamHo, emailNguoiGiamHo, soDienThoaiNguoiGiamHo,DiaChi)");
            return true;
        }
        

    }
}
