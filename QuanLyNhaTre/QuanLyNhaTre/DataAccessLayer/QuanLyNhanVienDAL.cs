using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyNhanVienDAL
    {
        private DataConnection _connection = new DataConnection();
        
        public void ThemNV(string hoten, string email)
        {
            _connection.Write("Insert into NhanVien(Hoten, Email) value ("+"'"+hoten+"','"+email+"')");
        }
        public DataTable LayDanhSachQuyen(int maNV)
        {
            return _connection.Read("Select * from QuyenHan where MaNV="+maNV);

        }
        public void ThayDoiQuyenHan(int maNV)
        {

        }
        public void ThemQuyenHan(int maNV)
        {

        }
    }
}
