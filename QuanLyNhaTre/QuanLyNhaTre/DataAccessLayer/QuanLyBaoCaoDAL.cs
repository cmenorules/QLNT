using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyBaoCaoDAL
    {
        DataConnection data_connection = DataConnection.getInstance();

        public DataTable LayNgayDiHoc(int maHocSinh)
        {
            return data_connection.Read("select HoTen,CHITIETPHIEUDIEMDANH.MaTre,Thu,Tuan,NgayThangNam,DaDiHoc,DaDonVe from PHIEUDIEMDANH,CHITIETPHIEUDIEMDANH,TREEM where PHIEUDIEMDANH.MaPhieuDiemDAnh = CHITIETPHIEUDIEMDANH.MaPhieuDiemDanh and CHITIETPHIEUDIEMDANH.MaTre = TREEM.MaTre and CHITIETPHIEUDIEMDANH.MaTre =" + maHocSinh);
        }

        public DataTable LayCheDoDinhDuong()
        {
            return data_connection.Read("select * from DINHDUONG");
        }

        public DataTable LayPhieuSucKhoe(int maHocSinh)
        {
            return data_connection.Read("select HoTen,GioiTinh,ThangTuoi,ChieuCao,CanNang,DaLieu,TaiMuiHong,RangHamMat,HoHap,DANGKYHOC.MaDangKy from  PHIEUSUCKHOE,DANGKYHOC,TREEM where PHIEUSUCKHOE.MaDangKy = DANGKYHOC.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre=" + maHocSinh);
        }

        public DataTable LayHoatDongHangNgay(int maHocSinh)
        {
            return data_connection.Read("select HoTen,TREEM.MaTre,HoatDong,Ngay,DanhGiafrom PHIEUHOATDONG,DANGKYHOC,TREEM where PHIEUHOATDONG.MaDangKy = DANGKYHOC.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and  TREEM.MaTre = " + maHocSinh);
        }

        public DataTable LayPhieuHocTap(int maHocSinh)
        {
            return data_connection.Read(" select HoTen,PhatTrienTheChat,PhatTrienNhanThuc,PhatTrienNangKhieu,PhatTrienNgonNgu,PhatTrienQuanHe, BeNgoan from PHIEUTONGKET,DANGKYHOC,TREEM where PHIEUTONGKET.MaDangKy = DANGKYHOC.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre =" + maHocSinh);
        }
        public DataTable LayHoSoHocSinh(int maHocSinh)
        {
            return data_connection.Read("select * from HOSOTREEM where MaHoSoTreEm in (select TREEM.MaHoSoTreEm from TREEM where TREEM.MaTre = " + maHocSinh + ")");
        }
    }
}
