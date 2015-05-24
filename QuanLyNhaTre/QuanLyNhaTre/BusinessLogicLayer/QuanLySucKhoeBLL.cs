using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class QuanLySucKhoeBLL
    {
        DataAccessLayer.QuanLySucKhoeDAL _qlSucKhoeDal = new DataAccessLayer.QuanLySucKhoeDAL();

        //Lấy danh sách mã khối, tên khối
        public DataTable LayDanhSachKhoi()
        {
            return _qlSucKhoeDal.LayDanhSachKhoi();
            
        }
        public DataTable LayDanhSachPhong(int maKhoi, int namHoc)
        {
           return _qlSucKhoeDal.LayDanhSachLop(maKhoi,namHoc);
            
        }
        public DataTable LayDanhSachMaDangKy(int maKeHoach)
        {
            return _qlSucKhoeDal.LayDanhSachMaDangKy(maKeHoach);
        }
        public int LaySoLuongDangKyMotLop(int maKeHoach)
        {
            return int.Parse(_qlSucKhoeDal.LaySoLuongDangKyMotLop(maKeHoach).Rows[0]["MaDangKy"].ToString());
        }
        public DataTable LayThongTinHocSinh(int maDangKi)
        {
            return LayThongTinHocSinh(maDangKi);
        }
        public void ThemPhieuSucKhoeVang(string ngayKham, int maDangKy)
        {
            _qlSucKhoeDal.ThemPhieuSucKhoe(ngayKham, 0, 0, "v", "v", "v", "v", maDangKy);
        }
        public void ThemPieuSucKhoe(string ngayKham, int chieuCao, int canNang,
            string daLieu, string taiMuiHong, string rangHamMat, string hoHap, int maDangKi)
        {
            _qlSucKhoeDal.ThemPhieuSucKhoe(ngayKham, chieuCao, canNang, daLieu, taiMuiHong, rangHamMat, hoHap, maDangKi);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int nam, int thang, int maKhoi)
        {
            return _qlSucKhoeDal.LayDanhSachPhieuSucKhoe(nam, thang, maKhoi);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int nam, int thang, int maKhoi, int maLop)
        {
            return _qlSucKhoeDal.LayDanhSachPhieuSucKhoe(nam, thang, maKhoi, maLop);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int maTre)
        {
            return _qlSucKhoeDal.LayDanhSachPhieuSucKhoe(maTre);
        }
        public void ThayDoiPhieuSucKhoe(int maPhieuKhamSucKhoe, int chieuCao, int canNang,
            string daLieu, string taiMuiHong, string rangHamMat, string hoHap)
        {
            _qlSucKhoeDal.ThaydoiPhieuSucKhoe(maPhieuKhamSucKhoe, chieuCao, canNang, daLieu, taiMuiHong, rangHamMat, hoHap);
        }
        public void XoaPhieuSucKhoe(int maPhieuKhamSucKhoe)
        {
            _qlSucKhoeDal.XoaPhieuSucKhoe(maPhieuKhamSucKhoe);
        }
    }
}
