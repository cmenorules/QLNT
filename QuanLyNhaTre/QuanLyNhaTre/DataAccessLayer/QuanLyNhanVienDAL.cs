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

        public QuanLyNhanVienDAL()
        {
            
            //cai nay lam de test, khoi cho setup tren form
            _connection.SetupConnection("THAOHO\\INSTANCE1","QuanLyNhaTre");
        }

        public QuanLyNhanVienDAL(DataConnection _connection)
        {
            // TODO: Complete member initialization
        }
        public DataTable LayMaNhanVien()
        {
            return _connection.Read("Select MaNhanVien from NHANVIEN");
        }
        //them nhan vien
        public void ThemNhanVien(string hoTen, string email, string matKhau)
        {
            _connection.Write("Insert into NhanVien(HoTen, Email, MatKhau) values (N'"+hoTen+"',N'"+email+"','"+matKhau+"')");
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
            _connection.Write("Insert into QUYENHAN (MaNhanVien, MaNhomNguoiDung)values (" + maNV + "," + maNhomNguoiDung + ")");
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
