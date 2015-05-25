using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class PhanQuyenDAL
    {
        public PhanQuyenDAL()
        {
            dtCon = DataConnection.getInstance();
        }

        DataConnection dtCon;

        public DataTable LayDSQuyen()
        {
            return dtCon.Read("select TenChucNang from CHUCNANG");
        }

        public DataTable LayDSQuyen(int maNhanVien)
        {
            return dtCon.Read("select TenChucNang from CHUCNANG, NHOMCHUCNANG, NHOMNGUOIDUNG, QUYENHAN, NHANVIEN" +
                        " where CHUCNANG.MaChucNang = NHOMCHUCNANG.MaChucNang" +
                        " and NHOMCHUCNANG.MaNhomNguoiDung = NHOMNGUOIDUNG.MaNhomNguoiDung" +
                        " and NHOMNGUOIDUNG.MaNhomNguoiDung = QUYENHAN.MaNhomNguoiDung" +
                        " and QUYENHAN.MaNhanVien = NHANVIEN.MaNhanVien" +
                        " and NHANVIEN.MaNhanVien = " + maNhanVien);
        }
    }
}
