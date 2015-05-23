using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class DangNhapBLL
    {
        public DangNhapBLL()
        {
            dn = new DataAccessLayer.DangNhapDAL();
        }

        DataAccessLayer.DangNhapDAL dn;

        public DataTable LayThongTinDangNhap(string email, string matKhau)
        {
            return dn.LayThongTinDangNhap(email, matKhau);
        }
    }
}
