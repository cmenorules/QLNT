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
        
        public void ThemNhanVien(string hoTen, string email)
        {
            _connection.Write("Insert into NhanVien(Hoten, Email) values ("+"'"+hoTen+"','"+email+"')");
        }
        public void XoaNhanVien(int maNV)
        {
            _connection.Write("Delete from NHANVIEN where MaNhanVien=" + maNV);
        }
        public DataTable LayDanhSachMaNhomNguoiDung(int maNV)
        {
            return _connection.Read("Select MaNhomNguoiDung from QUYENHAN where MaNhanVien="+maNV);
        }
        public void ThemQuyenHan(int maNV, int maNhomNguoiDung)
        {
            _connection.Write("Insert into QUYENHAN * values (" + maNV + "," + maNhomNguoiDung + ")");
        }
        public void ThayDoiQuyenHan(int maNV, int maNhomNguoiDung)
        {
            _connection.Write("Update QUYENHAN set MaNhomNguoiDung= " + maNhomNguoiDung+" where NhanVien= "+ maNV);
        }
        public void XoaQuyenHan(int maNV, int maNhomNguoiDung)
        {
            _connection.Write("Delete from QUYENHAN where MaNhanVien="+maNV+" and MaNhomNguoiDung="+ maNhomNguoiDung);
        }
        public void XoaQuyenHan(int maNV)
        {
            _connection.Write("Delete from QUYENHAN where MaNhanVien=" + maNV);
        }
        public DataTable LayDanhSachNhomNguoiDung()
        {
            return _connection.Read("Select TenNhomNguoiDung from NHOMNGUOIDUNG");
        }
        
       
    }
}
