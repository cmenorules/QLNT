using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyDanhMucDAL
    {
        DataConnection _connect = DataConnection.getInstance();
        public DataTable DanhSachNhanVien()
        {
            return _connect.Read("select MaNhanVien[Mã Nhân Viên], HoTen[Họ Tên],Email[Email] from NHANVIEN");
        }
        public DataTable DanhSachTreEm()
        {
            return _connect.Read("select MaTre[Mã Trẻ], HoTen[Họ Tên], TenThanMat[Tên Thân Mật],GioiTinh[Giới Tính],NgaySinh[Ngày Sinh],DanToc[Dân Tộc], TonGiao[Tôn Giáo] from TREEM");
        }
        public DataTable DanhSachPhong()
        {
            return _connect.Read("select MaPhong[Mã Phòng], TenPhong[Tên Phòng] from PHONGHOC");
        }
        public DataTable DanhSachKhoi()
        {
            return _connect.Read("select MaKhoi[Mã Khối], TenKhoi[Tên Khối] from KHOI");
        }        
    }
}
