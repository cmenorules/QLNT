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
        private DataConnection connection = new DataConnection();

        //Lấy danh sách điểm danh
        public DataTable LayDanhSachDiemDanh(int maKeHoach)
        {
            return connection.Read("select MaPhieuDiemDanh,TREEM.MaTre, HoTen,DaDiHoc,DaDonVe from CHITIETPHIEUDIEMDANH, TREEM where TREEM.MaTre = CHITIETPHIEUDIEMDANH.MaTre and CHITIETPHIEUDIEMDANH.MaPhieuDiemDanh in (select MAX(MaPhieuDiemDanh) from PHIEUDIEMDANH where MaKeHoach = " + maKeHoach + ")");
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
            return int.Parse(connection.Read("SELECT IDENT_CURRENT('PHONGHOC') as ID").Rows[0]["ID"].ToString());
        }

        //them thời khóa biểu vào chương trình học
        public bool ThemThoiKhoaBieu(string maChuongTrinh, string hoatDong, string buoi, string tuan)
        {
            connection.Write("insert into THOIKHOABIEU values("+maChuongTrinh+",'"+hoatDong+"','"+buoi+"',"+tuan+")");
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
            return connection.Read("select MaNhanVien,HoTen,Email from NHANVIEN where MaNhanVien in (select QUYENHAN.MaNhanVien from QUYENHAN where QUYENHAN.MaNhomNguoiDung = 1)");
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
            return int.Parse(connection.Read("SELECT IDENT_CURRENT('PHONGHOC') as ID").Rows[0]["ID"].ToString());
        }

        //Thêm các chi tiết điểm danh
        public bool ThemChiTietDiemDanh(int maPhieu,int maHocsinh)
        {
            connection.Write("insert into CHITIETPHIEUDIEMDANH values("+maPhieu+","+maHocsinh+",0,0)");
            return true;
        }

        //cập nhật các chi tiết điểm danh
        public void CapNhatChiTietDiemDanh(string maPhieu, string maTre, int diHoc, int DaDon)
        {
            connection.Write("update CHITIETPHIEUDIEMDANH set  DaDiHoc = "+diHoc+", DaDonVe = "+DaDon+" where MaPhieuDiemDanh = "+maPhieu+" and MaTre = "+maTre);
        }

        //tạo mới một kế hoạch giảng dạy
        public bool ThemMotKeHoachGiangDay(int namHoc, int hocki,int magv,int maPhong,int maChuongTrinh)
        {
            string sql = "insert into KEHOACHGIANGDAY values({0},{1},{2},{3},{4})";
            connection.Write(string.Format(sql,namHoc,hocki,magv,maPhong,maChuongTrinh));
            return true;
        }

        //lưu kết quả học tập
        public bool LuuKetQuaHocTap(int maKeHoach, string thechat,string nhanthuc, string nangkhieu, string ngonngu,string quanhe, string bengoan)
        {
            string sql = "insert into PHIEUTONGKET values({0},'{1}','{2}','{3}','{4}','{5}','{6}')";
            connection.Write(string.Format(sql, maKeHoach, thechat, nhanthuc, nangkhieu, ngonngu, quanhe, bengoan));
            return true;
        }

        //ghi nhận các hành vi lạ
        public bool GhiNhanHanhViLa(string maDangKi,string hoatDong, string ngayThang, string danhGia)
        {
            string sql = "insert into PHIEUHOATDONG values({0},'{1}','{2}','{3}')";
            connection.Write(string.Format(sql, maDangKi, hoatDong, ngayThang, danhGia));
            return true;
        }
        
    }
}
