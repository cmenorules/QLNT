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

        private static QuanLyDangNhap instance;

        private string maNhanVien;
        private string hoTen;

        public string LayHoTen()
        {
            return hoTen;
        }

        public string LayMaNhanVien()
        {
            return maNhanVien;
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
