using PhanQuyenMenu;
using QuanLyNhaTre.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre
{
    class QuanLyDangNhap
    {
        public QuanLyDangNhap() { }

        public void LoadRole()
        {
            
            
            role = new RoleMap();

            role.XetQuyen(Int32.Parse(maNhanVien));
        }

        private static QuanLyDangNhap instance;

        private string maNhanVien;
        private string hoTen;
        private RoleMap role;
        public string LayHoTen()
        {
            return hoTen;
        }

        public string LayMaNhanVien()
        {
            return maNhanVien;
        }

        public RoleMap GetRoles()
        {
            return role;
        }

        public void LuuThongTin(string hoTen, string maNhanVien)
        {
            this.hoTen = hoTen;
            this.maNhanVien = maNhanVien;
        }

        public static QuanLyDangNhap getInstance()
        {
            if (instance == null)
                instance = new QuanLyDangNhap();
            return instance;
        }
    }
}
