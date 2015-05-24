using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyHocTapDAL
    {
        private DataConnection connection = DataConnection.getInstance();

        //Lấy danh sách điểm danh
        public DataTable LayDanhSachDiemDanh(int maKeHoach)
        {
            return connection.Read("select MaPhieuDiemDanh,TREEM.MaTre, HoTen,DaDiHoc,DaDonVe from CHITIETPHIEUDIEMDANH, TREEM where TREEM.MaTre = CHITIETPHIEUDIEMDANH.MaTre and CHITIETPHIEUDIEMDANH.MaPhieuDiemDanh in (select MAX(MaPhieuDiemDanh) from PHIEUDIEMDANH where MaKeHoach = " + maKeHoach + ")");
        }

        //lay ho so hoc sinh
        public DataTable XemThongTinHocSinh(string maTre)
        {
           return connection.Read("select * from TREEM where MaTre = " + maTre);
        }

        //lấy phiểu điểm danh
        public DataTable LayPhieuDiemDanh(string maKeHoach, string ngayThang)
        {
            return connection.Read("select * from PHIEUDIEMDANH where PHIEUDIEMDANH.NgayThangNam = '"+ngayThang+"' and MaKeHoach =" + maKeHoach);
        }

        //Lấy danh sách học sinh theo lớp
        public DataTable LayDanhSachHocSinhLop(int maKeHoach)
        {
            return connection.Read("select SoThuTu,MaKeHoach,TREEM.MaTre,HoTen,GioiTinh,DanToc from DANGKYHOC, TREEM where DANGKYHOC.MaTre = TREEM.MaTre and DANGKYHOC.MaKeHoach = "+maKeHoach);
        }

        //Xem hồ sơ học sinh
        public DataTable LayHoSoHocSinh(int maHocSinh)
        {
            return connection.Read("select * from HOSOTREEM where MaHoSoTreEm in (select TREEM.MaHoSoTreEm from TREEM where TREEM.MaTre = "+maHocSinh+")");
        }

        //Lấy các chương trình học
        public DataTable LayDanhSachChuongTrinhHoc()
        {
            return connection.Read("select * from CHUONGTRINHHOC");
        }

        //tạo một chương trình học
        public int TaoChuongTrinhHocMoi(string khoi, string ngayApdung, string ghiChu)
        {
            connection.Write("insert into CHUONGTRINHHOC values('"+ngayApdung+"',"+khoi+",'"+ghiChu+"')");
            return int.Parse(connection.Read("SELECT IDENT_CURRENT('CHUONGTRINHHOC') as ID").Rows[0]["ID"].ToString());
        }

        //them thời khóa biểu vào chương trình học
        public bool ThemThoiKhoaBieu(string maChuongTrinh, string hoatDong, string buoi, string tuan)
        {
            connection.Write("insert into THOIKHOABIEU values("+maChuongTrinh+",N'"+hoatDong+"',"+buoi+","+tuan+")");
            return true;
        }

        //lấy danh sách chương trình học theo khối
        public DataTable LayDanhSachChuongTrinhHoc(int maKhoi)
        {
            return connection.Read("select * from CHUONGTRINHHOC where MaKhoi=" + maKhoi);
        }

        //lấy danh sách khối
        public DataTable LayDanhSachKhoi()
        {
            return connection.Read("select * from KHOI");
        }

        //Lấy danh sách phòng học
        public DataTable LayDanhSachPhongHoc()
        {
            return connection.Read("select * from PHONGHOC");
        }

        //Lấy danh sách các giáo viên
        public DataTable LayDanhSachGiaoVien()
        {
            return connection.Read("select MaNhanVien,HoTen,Email from NHANVIEN where MaNhanVien in (select QUYENHAN.MaNhanVien from QUYENHAN where QUYENHAN.MaNhomNguoiDung = 8)");
        }

        //Thêm phòng học vào hệ thống
        public bool ThemPhongHoc(string tenPhong)
        {
            connection.Write("insert into PHONGHOC values('" + tenPhong + "')");
            return true;
        }

        //Tạo bảng điểm danh
        public int TaoBangDiemDanh(string MaKeHoach, string thu, int tuan, string ngayThang)
        {

            connection.Write("insert into PHIEUDIEMDANH values("+MaKeHoach+",'"+thu+"',"+tuan+",'"+ngayThang+"')");
            return int.Parse(connection.Read("SELECT IDENT_CURRENT('PHIEUDIEMDANH') as ID").Rows[0]["ID"].ToString());
        }

        //Thêm các chi tiết điểm danh
        public bool ThemChiTietDiemDanh(int maPhieu,int maHocsinh)
        {
            connection.Write("insert into CHITIETPHIEUDIEMDANH values("+maPhieu+","+maHocsinh+",0,0)");
            return true;
        }

        //cập nhật các chi tiết điểm danh
        public void CapNhatChiTietDiemDanh(string maPhieu, string maTre, string diHoc, string DaDon)
        {
            connection.Write("update CHITIETPHIEUDIEMDANH set  DaDiHoc = '"+diHoc+"', DaDonVe = '"+DaDon+"' where MaPhieuDiemDanh = "+maPhieu+" and MaTre = "+maTre);
        }

        //tạo mới một kế hoạch giảng dạy
        public bool ThemMotKeHoachGiangDay(int namHoc, int hocki,int magv,int maPhong,int maChuongTrinh)
        {
            string sql = "insert into KEHOACHGIANGDAY values({0},{1},{2},{3},{4})";
            connection.Write(string.Format(sql,namHoc,hocki,magv,maPhong,maChuongTrinh));
            return true;
        }

        //lưu kết quả học tập
        public bool LuuKetQuaHocTap(int maKeHoach, string ngay, string thechat, string nhanthuc, string nangkhieu, string ngonngu, string quanhe, string bengoan)
        {
            string sql = "insert into PHIEUTONGKET(MaDangKy,Ngay,PhatTrienTheChat,PhatTrienNhanThuc,PhatTrienNangKhieu,PhatTrienNgonNgu,PhatTrienQuanHe, BeNgoan) values({0},'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}')";
            connection.Write(string.Format(sql, maKeHoach, ngay,thechat, nhanthuc, nangkhieu, ngonngu, quanhe, bengoan));
            return true;
        }

        //ghi nhận các hành vi lạ
        public bool GhiNhanHanhViLa(string maDangKi,string hoatDong, string ngayThang, string danhGia)
        {
            string sql = "insert into PHIEUHOATDONG values({0},{1}',{2}',{3}')";
            connection.Write(string.Format(sql, maDangKi, hoatDong, ngayThang, danhGia));
            return true;
        }
        //láy các kế hoạch haingr dạy
        public DataTable LayKeHoachGiangDay(string namHoc)
        {
            string sql = "select MaKeHoach, NamHoc, HocKy, NHANVIEN.HoTen, PHONGHOC.TenPhong, KHOI.TenKhoi,CHUONGTRINHHOC.MaChuongTrinh from KEHOACHGIANGDAY, NHANVIEN, PHONGHOC, KHOI, CHUONGTRINHHOC where KEHOACHGIANGDAY.MaNhanVien = NHANVIEN.MaNhanVien and KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and KEHOACHGIANGDAY.MaPhong = PHONGHOC.MaPhong  and KEHOACHGIANGDAY.NamHoc = " + namHoc;
            return connection.Read(sql);
        }

        //xóa kế hoạch giảng dạy
        public bool XoaKeHoachGiangDay(string maKeHoach)
        {
            connection.Write("delete from KEHOACHGIANGDAY where MaKeHoach = " + maKeHoach);
            return true;
        }

        //lay danh sach lop
        public DataTable LayKeHoachGiangDay(string maGv, string namHoc)
        {
            return connection.Read("select MaKeHoach,MaNhanVien, (TenKhoi +'-'+ TenPhong) as Lop from KEHOACHGIANGDAY, PHONGHOC, KHOI where KEHOACHGIANGDAY.MaPhong = PHONGHOC.MaPhong and KHOI.MaKhoi = KEHOACHGIANGDAY.MaPhong and NamHoc =" + namHoc + " and MaNhanVien = " + maGv);
        }

        //lay danh sach điểm danh
        public DataTable LayDanhSachDiemDanh(string maPhieuDiemDanh)
        {
            return connection.Read("select TREEM.MaTre, TREEM.HoTen, CHITIETPHIEUDIEMDANH.DaDiHoc, CHITIETPHIEUDIEMDANH.DaDonVe from TREEM, PHIEUDIEMDANH, CHITIETPHIEUDIEMDANH where CHITIETPHIEUDIEMDANH.MaPhieuDiemDanh = PHIEUDIEMDANH.MaPhieuDiemDanh and TREEM.MaTre = CHITIETPHIEUDIEMDANH.MaTre and PHIEUDIEMDANH.MaPhieuDiemDanh = " + maPhieuDiemDanh);
        }
        
    }
}
