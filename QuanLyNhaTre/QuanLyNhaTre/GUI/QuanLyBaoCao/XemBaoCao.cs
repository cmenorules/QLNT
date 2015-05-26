using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTre.DataAccessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QuanLyNhaTre.GUI.QuanLyBaoCao
{
    public partial class XemBaoCao : Form
    {
        public XemBaoCao()
        {
            InitializeComponent();
        }
        ReportDocument cReportOverall = new ReportDocument();

        private void XemBaoCao_Load(object sender, EventArgs e)
        {
            //cReportHealth.Load(@"C:\Users\norules\Desktop\QLNT\trunk\QuanLyNhaTre\QuanLyNhaTre\GUI\QuanLyBaoCao\CrystalReportHealth.rpt");
            //cReportGoodBaby.Load(@"C:\Users\norules\Desktop\QLNT\trunk\QuanLyNhaTre\QuanLyNhaTre\GUI\QuanLyBaoCao\CrystalReportGoodBaby.rpt");
            //cReportOverall.Subreports["CrystalReportHealth"].Load(@"C:\Users\norules\Desktop\QLNT\trunk\QuanLyNhaTre\QuanLyNhaTre\GUI\QuanLyBaoCao\CrystalReportHealth.rpt");
            

            string sql_overall = "select TREEM.HoTen as TenHocSinh,NHANVIEN.HoTen as TenNhanVien, KHOI.TenKhoi + ' ' + PHONGHOC.TenPhong as Lop,HocKy, NamHoc, Thu, Tuan, NgayThangNam, MonChinh, MonCanh, MonPhu, MonTrangMieng from TREEM, NHANVIEN, DINHDUONG, KEHOACHGIANGDAY, KHOI, PHONGHOC, DANGKYHOC, CHUONGTRINHHOC where KEHOACHGIANGDAY.MaKeHoach = DINHDUONG.MaKeHoach and KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and KEHOACHGIANGDAY.MaPhong = PHONGHOC.MaPhong and KEHOACHGIANGDAY.MaKeHoach = DANGKYHOC.MaKeHoach and KEHOACHGIANGDAY.MaNhanVien = NHANVIEN.MaNhanVien and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and	DANGKYHOC.MaTre = TREEM.MaTre and NHANVIEN.MaNhanVien ='" + QuanLyDangNhap.getInstance().LayMaNhanVien() + "' and TREEM.MaTre = '" + BaoCao.MaTre + "'";
            string table_showdd = "ShowDinhDuong";
            string sql_health = "select NgayKham, ChieuCao, CanNang, DaLieu, TaiMuiHong, RangHamMat, HoHap from PHIEUSUCKHOE, DANGKYHOC, TREEM where PHIEUSUCKHOE.MaDangKy = DANGKYHOC.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre = '" + BaoCao.MaTre + "'";
            string table_showsk = "ShowSucKhoe";
            string sql_goodbaby = "select Ngay, PhatTrienTheChat, PhatTrienNhanThuc, PhatTrienNangKhieu, PhatTrienNgonNgu, PhatTrienQuanHe, BeNgoan from PHIEUTONGKET, DANGKYHOC, TREEM where DANGKYHOC.MaDangKy = PHIEUTONGKET.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre = '" + BaoCao.MaTre + "'";
            string table_showtk = "ShowTongKet";
            DataSet data_showdd = new DataSet();
            DataSet data_showsk = new DataSet();
            DataSet data_showtk = new DataSet();

            data_showdd = DataConnection.getInstance().Read(sql_overall, table_showdd);
            data_showsk = DataConnection.getInstance().Read(sql_health, table_showsk);
            data_showtk = DataConnection.getInstance().Read(sql_goodbaby, table_showtk);
            
            cReportOverall.Load(@"C:\Users\norules\Desktop\QLNT\trunk\QuanLyNhaTre\QuanLyNhaTre\GUI\QuanLyBaoCao\CrystalReportOverall.rpt");
            //cReportOverall.DataSourceConnections.Clear();
            cReportOverall.SetDataSource(data_showdd.Tables[0]);
            //cReportOverall.Subreports[0].DataSourceConnections.Clear();
            cReportOverall.Subreports["CrystalReportHealth.rpt"].SetDataSource(data_showsk.Tables[0]);
            cReportOverall.Subreports["CrystalReportGoodBaby.rpt"].SetDataSource(data_showtk.Tables[0]);
            crystalReportViewer1.ReportSource = cReportOverall;
            crystalReportViewer1.Refresh();
            
            

          
        }
    }
}
