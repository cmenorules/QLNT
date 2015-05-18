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

        public DataTable LayDanhSachDiemDanh(int maKeHoach)
        {
            return connection.Read("select MaPhieuDiemDanh,TREEM.MaTre, HoTen,DaDiHoc,DaDonVe from CHITIETPHIEUDIEMDANH, TREEM where TREEM.MaTre = CHITIETPHIEUDIEMDANH.MaTre and CHITIETPHIEUDIEMDANH.MaPhieuDiemDanh in (select MAX(MaPhieuDiemDanh) from PHIEUDIEMDANH where MaKeHoach = "+maKeHoach+")");
        }

        public DataTable LayDanhSachHocSinhLop(int maKeHoach)
        {
            return connection.Read("select SoThuTu,MaKeHoach,TREEM.MaTre,HoTen,GioiTinh,DanToc from DANGKYHOC, TREEM where DANGKYHOC.MaTre = TREEM.MaTre and DANGKYHOC.MaKeHoach = "+maKeHoach);
        }

        public DataTable LayHoSoHocSinh(int maHocSinh)
        {
            return connection.Read("select * from HOSOTREEM where MaHoSoTreEm in (select TREEM.MaHoSoTreEm from TREEM where TREEM.MaTre = "+maHocSinh+")");
        }

        public DataTable LayDanhSachChuongTrinhHoc()
        {
            return connection.Read("select * from CHUONGTRINHHOC");
        }

        public DataTable LayDanhSachChuongTrinhHoc(int maKhoi)
        {
            return connection.Read("select * from CHUONGTRINHHOC where MaKhoi=" + maKhoi);
        }

        public DataTable LayDanhSachKhoi()
        {
            return connection.Read("select * from KHOI");
        }

        public DataTable LayDanhSachPhongHoc()
        {
            return connection.Read("select * from PHONGHOC");
        }

        public DataTable LayDanhSachGiaoVien()
        {
            return connection.Read("select MaNhanVien,HoTen,Email from NHANVIEN where MaNhanVien in (select QUYENHAN.MaNhanVien from QUYENHAN where QUYENHAN.MaNhomNguoiDung = 1)");
        }

        public bool ThemPhongHoc(string tenPhong)
        {
            connection.Write("insert into PHONGHOC values('" + tenPhong + "')");
            return true;
        }



        public int TaoBangDiemDanh(string MaKeHoach, string thu, int tuan, string ngayThang)
        {
            connection.Write("insert into PHIEUDIEMDANH values("+MaKeHoach+",'"+thu+"',"+tuan+",'"+ngayThang+"')");
            return int.Parse(connection.Read("SELECT IDENT_CURRENT('PHONGHOC') as ID").Rows[0]["ID"].ToString());
        }

        public bool ThemChiTietDiemDanh(int maPhieu,int maHocsinh)
        {
            connection.Write("insert into CHITIETPHIEUDIEMDANH values("+maPhieu+","+maHocsinh+",1,0)");
            return true;
        }

        public bool ThemMotKeHoachGiangDay(int namHoc, int hocki,int magv,int maPhong,int maChuongTrinh)
        {
            string sql = "insert into KEHOACHGIANGDAY values({0},{1},{2},{3},{4})";
            connection.Write(string.Format(sql,namHoc,hocki,magv,maPhong,maChuongTrinh));
            return true;
        }

        public bool LuuKetQuaHocTap(int maKeHoach, string thechat,string nhanthuc, string nangkhieu, string ngonngu,string quanhe, string bengoan)
        {
            string sql = "insert into PHIEUTONGKET values({0},'{1}','{2}','{3}','{4}','{5}','{6}')";
            connection.Write(string.Format(sql, maKeHoach, thechat, nhanthuc, nangkhieu, ngonngu, quanhe, bengoan));
            return true;
        }

        public bool GhiNhanHanhViLa(string maKeHoach,string hoatDong, string ngayThang, string danhGia)
        {
            string sql = "insert into PHIEUHOATDONG values({0},'{1}','{2}','{3}')";
            connection.Write(string.Format(sql, maKeHoach, hoatDong, ngayThang, danhGia));
            return true;
        }

        
    }
}
