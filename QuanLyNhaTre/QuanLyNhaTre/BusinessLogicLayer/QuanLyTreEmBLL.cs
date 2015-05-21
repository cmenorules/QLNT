using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class QuanLyTreEmBLL
    {
        public QuanLyTreEmBLL()
        {
            quanLyTreEmDAL = new DataAccessLayer.QuanLyTreEmDAL();
        }

        DataAccessLayer.QuanLyTreEmDAL quanLyTreEmDAL;        

        public void ThemHoSoTreEm(string hoTenCha, string hoTenMe, string hoTenNguoiGiamHo, string emailNguoiGiamHo, int soDienThoaiNguoiGiamHo, string DiaChi)
        {            
            quanLyTreEmDAL.ThemHoSoTreEm(hoTenCha, hoTenMe, hoTenNguoiGiamHo, emailNguoiGiamHo, soDienThoaiNguoiGiamHo, DiaChi);
            
        }

        public void ThemTreEm(string hoTen, string tenThanMat, string gioiTinh, string ngaySinh,
            string danToc, string tonGiao, int doiTuongUuTien, string tinhCach, string thoiQuen)
        {
            quanLyTreEmDAL.ThemTreEm(hoTen, tenThanMat, gioiTinh, ngaySinh, danToc, tonGiao, doiTuongUuTien, tinhCach, thoiQuen);
        }

        public void DangKyHoc(int khoi, int namHoc)
        {
            quanLyTreEmDAL.DangKyHoc(khoi, namHoc);
        }

        public DataTable LayThongTinKhoi()
        {
            return quanLyTreEmDAL.LayThongTinKhoi();
        }

        public DataTable LayDanhSachTreEm(int khoi, int lop)
        {
            return quanLyTreEmDAL.LayDanhSachTre(khoi, lop);
        }

        public DataTable LayKeHoachGD(int khoi, int namHoc)
        {
            return quanLyTreEmDAL.LayKeHoachGiangDay(khoi, namHoc);
        }
    }
}
