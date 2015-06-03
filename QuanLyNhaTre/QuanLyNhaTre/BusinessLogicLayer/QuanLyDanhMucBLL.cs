using QuanLyNhaTre.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class QuanLyDanhMucBLL
    {
        QuanLyDanhMucDAL _connect = new QuanLyDanhMucDAL();
        public DataTable LayDanhSachNhanVien()
        {
            return _connect.DanhSachNhanVien();
        }
        public DataTable LayDanhSachTre()
        {
            return _connect.DanhSachTreEm();
        }
        public DataTable LayDanhSachKhoi()
        {
            return _connect.DanhSachKhoi();
        }
        public DataTable LayDanhSachPhong()
        {
            return _connect.DanhSachPhong();
        }

    }
}
