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
        private DataConnection _connection = DataConnection.getInstance();
        
        public void ThemNhanVien(string hoten, string email)
        {
            _connection.Write("Insert into NhanVien(Hoten, Email) values ("+"'"+hoten+"','"+email+"')");
        }
        public void XoaNhanVien(int maNV)
        {
            _connection.Write("Delete from NhanVien where MaNhanVien=" + maNV);
        }
        public DataTable LayDanhSachQuyen(int maNV)
        {
            return _connection.Read("Select * from QuyenHan where MaNhanVien="+maNV);
        }
        public void ThemQuyenHan(int maNV, int MaNhomNguoiDung)
        {
            _connection.Write("Insert into QuyenHan * values (" + maNV + "," + MaNhomNguoiDung + ")");
        }
        public void ThayDoiQuyenHan(int maNV, int MaNhomNguoiDung)
        {
            _connection.Write("Update QuyenHan set MaNhomNguoiDung= " + MaNhomNguoiDung+" where NhanVien= "+ maNV);
        }
        public void XoaQuyenHan(int maNV, int MaNhomNguoiDung)
        {
            _connection.Write("Delete from QuyenHan where MaNhanVien="+maNV+", MaNhomNguoiDung="+ MaNhomNguoiDung);
        }
       
    }
}
