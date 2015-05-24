using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLySucKhoeDAL
    {
        DataConnection _connection = DataConnection.getInstance();

        public DataTable LayDanhSachKhoi()
        {
            return _connection.Read("Select * from KHOI");
        }
        public DataTable LayDanhSachLop(int maKhoi, int namHoc)
        {
            return _connection.Read("select KEHOACHGIANGDAY.MaKeHoach, (TenKhoi +' - ' + cast(KEHOACHGIANGDAY.MaKeHoach as varchar(10))) as TenLop from KEHOACHGIANGDAY join CHUONGTRINHHOC on KEHOACHGIANGDAY.MaChuongTrinh= CHUONGTRINHHOC.MaChuongTrinh join KHOI on KHOI.MaKhoi=CHUONGTRINHHOC.MaKhoi where KHOI.MaKhoi=" + maKhoi+" and KEHOACHGIANGDAY.NamHoc="+namHoc);
        }
        public DataTable LayDanhSachMaDangKy(int maKeHoach)
        {
            return _connection.Read("select MaDangKy from DANGKYHOC where MaKeHoach =" + maKeHoach);
        }
        public DataTable LayThongTinTre(int maDangKi)
        {
            return _connection.Read("select HoTen, NgaySinh from TREEM join DANGKYHOC on TREEM.MaTre= DANGKYHOC.Matre where DANGKYHOC.MaDangKy="+maDangKi);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int nam, int thang, int maKhoi)
        {
            return _connection.Read("select* from PHIEUSUCKHOE join DANGKYHOC on PHIEUSUCKHOE.MaDangKy=DANGKYHOC.MaDangKy join KEHOACHGIANGDAY " +
           "on DANGKYHOC.MaKeHoach= KEHOACHGIANGDAY.MaKeHoach join CHUONGTRINHHOC on KEHOACHGIANGDAY.MaChuongTrinh=CHUONGTRINHHOC.MaChuongTrinh " +
           "where CHUONGTRINHHOC.MaKhoi=" + maKhoi+" and year(PHIEUSUCKHOE.NgayKham)="+nam+" and month(PHIEUSSUCKHOE.NgayKham)="+thang);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int nam, int thang, int maKhoi, int maLop)
        {
            string cmd = "select MaPhieuSucKhoe, NgayKham, ChieuCao, CanNang, DaLieu, TaiMuiHong " +
           "from PHIEUSUCKHOE join DANGKYHOC on PHIEUSUCKHOE.MaDangKy=DANGKYHOC.MaDangKy join KEHOACHGIANGDAY " +
           "on DANGKYHOC.MaKeHoach= KEHOACHGIANGDAY.MaKeHoach join CHUONGTRINHHOC on KEHOACHGIANGDAY.MaChuongTrinh=CHUONGTRINHHOC.MaChuongTrinh " +
           "where CHUONGTRINHHOC.MaKhoi=" + maKhoi + " and KEHOACHGIANGDAY.MaKeHoachGiangDay=" + 
           maLop + "and year(PHIEUSUCKHOE.NgayKham)=" + nam + " and month(PHIEUSSUCKHOE.NgayKham)=" + thang;
            return _connection.Read(cmd);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int maTre)
        {
            return _connection.Read("select MaPhieuSucKhoe, NgayKham, ChieuCao, CanNang, DaLieu, TaiMuiHong"+
                " from PHIEUSUCKHOE join DANGKYHOC on PHIEUSUCKHOE.MaDangKy= DANGKYHOC.MaDangKy"+ 
                " join TREEM on DANGKYHOC.MaTre= TREEM.MaTre where TREEM.MaTre=" + maTre);
        }

        public void ThemPhieuSucKhoe(string ngayKham, int chieuCao, int canNang,
            string daLieu, string taiMuiHong, string rangHamMat, string hoHap, int maDangKy)
        {
            string cmd = " Insert into PHIEUSUCKHOE  {0},{1}, {2}, N'{3}', N'{4}', N'{5}',N'{6}'";
            _connection.Write(string.Format(cmd, ngayKham, chieuCao, canNang, daLieu, taiMuiHong, rangHamMat, hoHap, maDangKy));

        }
        public void ThaydoiPhieuSucKhoe(int maPhieuKhamSucKhoe, int chieuCao, int canNang,
            string daLieu, string taiMuiHong, string rangHamMat, string hoHap)
        {
            string cmd = "Update PHIEUSUCKHOE set chieucao= {1}, CanNang={2}, DaLieu= N'{3}', TaiMuiHong= N'{4}', RangHamMat='N{5}', HoHap= N'{6}' where MaPhieuKhamSucKhoe = {0}";
            _connection.Write(string.Format(cmd, maPhieuKhamSucKhoe, chieuCao, canNang, daLieu, taiMuiHong, rangHamMat, hoHap));
        }
        public void XoaPhieuSucKhoe(int maPhieuKhamSucKhoe)
        {
            _connection.Write("Delete from PHIEUSUCKHOE where MaTre= " + maPhieuKhamSucKhoe);
        }
    }
}
