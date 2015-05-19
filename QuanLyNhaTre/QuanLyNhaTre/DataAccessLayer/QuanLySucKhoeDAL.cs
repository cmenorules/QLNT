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

        public DataTable LayDanhSachMaTreEm(int lop)
        {
            return _connection.Read("select TREEM.MaTre from TREEM join DANGKIHOC on TREEM.MaTre=DANGKIHOC.MaTre where DANGKIHOC.MaKeHoach=" + lop);
        }

        public DataTable LayDanhSachLop(int khoi)
        {
            return _connection.Read("select KEHOACHGIANGDAY.MaKeHoach from KEHOACHGIANGDAY join CHUONGTRINH on KEHOACHGIANGDAY.MaKhoi=CHUONGTRINHHOC.MaKhoi where CHUONGTRINHHOC.MaKhoi=" + khoi);
        }

        public DataTable LayDanhSachPhieuSucKhoe()
        {
            return _connection.Read("select* from PHIEUSUCKHOE");
        }

        public void ThemPhieuSucKhoe(string thangtuoi, int chieucao, int cannang,
            string dalieu, string taimuihong, string ranghammat, string hohap)
        {
            string cmd = " Insert into PHIEUSUCKHOE  {0},{1}, {2}, N'{3}', N'{4}', N'{5}',N'{6}'";
            _connection.Write(string.Format(cmd, thangtuoi, chieucao, cannang, dalieu, taimuihong, ranghammat, hohap));

        }
        public void ThaydoiPhieuSucKhoe(int matre, int chieucao, int cannang,
            string dalieu, string taimuihong, string ranghammat, string hohap)
        {
            string cmd = "Update PHIEUSUCKHOE set chieucao= {1}, CanNang={2}, DaLieu= N'{3}', TaiMuiHong= N'{4}', RangHamMat='N{5}', HoHap= N'{6}' where Matre = {0}";
            _connection.Write(string.Format(cmd, matre, chieucao, cannang, dalieu, taimuihong, ranghammat, hohap));
        }
        public void XoaPhieuSucKhoe(int matre)
        {
            _connection.Write("Delete from PHIEUSUCKHOE where Matre= " + matre);
        }
        public DataTable TimPhieuSucKhoe(int matre)
        {
            return _connection.Read("select* PHIEUSUCKHOE where Matre='" + matre + "'");
        }
        public DataTable TimPhieuSucKhoe(int khoi, int lop)
        {
            string cmd = "select MaPhieuSucKhoe, ThangTuoi, ChieuCao, CanNang, DaLieu, TaiMuiHong " +
            "from PHIEUSUCKHOE join DANGKYHOC on PHIEUSUCKHOE.MaDangKy=DANGKYHOC.MaDangKy join KEHOACHGIANGDAY " +
            "on DANGKYHOC.MaKeHoach= KEHOACHGIANGDAY.MaKeHoach join CHUONGTRINHHOC on KEHOACHGIANGDAY.MaChuongTrinh=CHUONGTRINHHOC.MaChuongTrinh " +
            "join KHOI on CHUONGTRINHHOC.MaKhoi=" + khoi + ")";
            return _connection.Read(cmd);
        }
        //public DataTable TimPhieuSucKhoe(int thang, int nam, int khoi, int lop)
        //{

        //}      
        public void XepTang(int MaPhieuSucKhoe)
        {

        }
    }
}
