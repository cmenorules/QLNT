using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace QuanLyNhaTre.BusinessLogicLayer
{
    class QuanLyNhanVienBLL
    {
        DataAccessLayer.QuanLyNhanVienDAL _qlNhanVienDal = new DataAccessLayer.QuanLyNhanVienDAL();
        // Lấy danh sách Chuc vu-còn gọi là Nhom Nguoi Dung
        public List<string> LayDanhSachNhomNguoiDung()
        {
            List<string> listNhomNguoiDung= new List<string>();
            DataTable dtNhomNguoiDung = _qlNhanVienDal.LayDanhSachNhomNguoiDung();
            int i=0;
            while (i < dtNhomNguoiDung.Rows.Count)
            {
                listNhomNguoiDung.Add(dtNhomNguoiDung.Rows[i][0].ToString());
                i++;
            }
            return listNhomNguoiDung;
        }
        // Thêm một nhân viên, mật khẩu mặc định là user
        public void ThemNhanVien(string hoTen, string email, string matKhau)
        {
            _qlNhanVienDal.ThemNhanVien(hoTen, email, matKhau);
        }
        // quy dinh
        // 1- Hiệu trưởng, 2-Phó hiệu trưởng chuyên môn
        // 3- Phó hiệu trưởng bán trú, 4- Giáo viên
        // 5- Nhân viên cấp dưỡng, 6- Nhân viên y tế
        // 7- Văn thư, 8- Quản trị hệ thống

        // Lấy danh sách các chức vụ của nhân viên theo mã nhân viên
        public List<int> LayDanhSachQuyen(int maNV)
        {
            List<int> listDanhSachQuyen= new List<int>();
            DataTable dtDanhSachQuyen= _qlNhanVienDal.LayDanhSachMaNhomNguoiDung(maNV);
            for(int i=0;i<dtDanhSachQuyen.Rows.Count;i++)
            {
                listDanhSachQuyen.Add(int.Parse(dtDanhSachQuyen.Rows[i][0].ToString()));
            }
            return listDanhSachQuyen;
        }
        // Thêm quyền hạn cho nhân viên
        public void ThemQuyenHan(int maNV, int maNhomNguoiDung)
        {
            _qlNhanVienDal.ThemQuyenHan(maNV, maNhomNguoiDung);
        }
        // Lấy mã nhân viên cuối cùng trong bảng dữ liệu
        public int LayMaNhanVienCuoiBang()
        {
            int n = _qlNhanVienDal.LayMaNhanVien().Rows.Count;
            return int.Parse(_qlNhanVienDal.LayMaNhanVien().Rows[n-1][0].ToString());
        }
        public int SoLuongNhanVien()
        {
            return _qlNhanVienDal.LayMaNhanVien().Rows.Count;
        }
        // Cập nhật quyền han/chức vụ cua nhân viên
        public void CapNhatQuyenHan(int maNV, List<int> dsMaNhomNguoiDung)
        {
            _qlNhanVienDal.XoaQuyenHan(maNV);
            foreach (int maNhomNguoiDung in dsMaNhomNguoiDung)
            {
                _qlNhanVienDal.ThemQuyenHan(maNV, maNhomNguoiDung);
            }
        }
    }
}
