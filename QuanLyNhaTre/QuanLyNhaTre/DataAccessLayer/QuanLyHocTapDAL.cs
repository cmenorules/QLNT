using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyHocTapDAL
    {
        private DataConnection connection = new DataConnection();

        public DataTable LayDanhSachDiemDanh(int maKeHoach)
        {
            return connection.Read("select MaPhieuDiemDanh,TREEM.MaTre, HoTen,DaDiHoc,DaDonVe from CHITIETPHIEUDIEMDANH, TREEM where TREEM.MaTre = CHITIETPHIEUDIEMDANH.MaTre and CHITIETPHIEUDIEMDANH.MaPhieuDiemDanh in (select MAX(MaPhieuDiemDanh) from PHIEUDIEMDANH where MaKeHoach = "+maKeHoach+")");
        }

        public DataTable LayDanhSachHocSinhLop(int maKeHoach)
        {
            return connection.Read("select SoThuTu,MaKeHoach,TREEM.MaTre,HoTen,GioiTinh,DanToc from DANGKYHOC, TREEM where DANGKYHOC.MaTre = TREEM.MaTre and DANGKYHOC.MaKeHoach = "+maKeHoach);
        }

        public DataTable LayHoSoHocSinh(int maHocSinh)
        {
            return connection.Read("select * from HOSOTREEM where MaHoSoTreEm in (select TREEM.MaHoSoTreEm from TREEM where TREEM.MaTre = "+maHocSinh+")");
        }

        public DataTable LayDanhSachChuongTrinhHoc()
        {
            return connection.Read("select * from CHUONGTRINHHOC");
        }

        public DataTable LayDanhSachChuongTrinhHoc(int maKhoi)
        {
            return connection.Read("select * from CHUONGTRINHHOC where MaKhoi=" + maKhoi);
        }

        public DataTable LayDanhSachKhoi()
        {
            return connection.Read("select * from KHOI");
        }

        public DataTable LayDanhSachPhongHoc()
        {
            return connection.Read("select * from PHONGHOC");
        }

        public DataTable LayDanhSachGiaoVien()
        {
            return connection.Read("select MaNhanVien,HoTen,Email from NHANVIEN where MaNhanVien in (select QUYENHAN.MaNhanVien from QUYENHAN where QUYENHAN.MaNhomNguoiDung = 1)");
        }

        public bool ThemPhongHoc(string tenPhong)
        {
            connection.Write("insert into PHONGHOC values('" + tenPhong + "')");
            return true;
        }



        public bool TaoBangDiemDanh(string tenPhong)
        {
            return true;
        }

        public bool ThemChiTietDiemDanh(string tenPhong)
        {
            return true;
        }

        public bool ThemDanhSachHocSinh(string tenPhong)
        {
            return true;
        }

        public bool ThemMotKeHoachGiangDay(string tenPhong)
        {
            return true;
        }

        public bool LuuKetQuaHocTap(string tenPhong)
        {
            return true;
        }

        public bool GhiNhanHanhViLa(string tenPhong)
        {
            return true;
        }

        
    }
}
