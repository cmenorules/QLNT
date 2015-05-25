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

namespace QuanLyNhaTre.GUI.QuanLyBaoCao
{
    public partial class XemBaoCao : Form
    {
        public XemBaoCao()
        {
            InitializeComponent();
        }
        ReportDocument cReport = new ReportDocument();
        private void XemBaoCao_Load(object sender, EventArgs e)
        {
            cReport.Load(@"C:\Users\norules\Desktop\QLNT\trunk\QuanLyNhaTre\QuanLyNhaTre\GUI\QuanLyBaoCao\CrystalReportOverall.rpt");
            string sql_overall = "select TREEM.HoTen as TenHocSinh,NHANVIEN.HoTen as TenNhanVien, KHOI.TenKhoi + ' ' + PHONGHOC.TenPhong as Lop,HocKy, NamHoc, Thu, Tuan, NgayThangNam, MonChinh, MonCanh, MonPhu, MonTrangMieng from TREEM, NHANVIEN, DINHDUONG, KEHOACHGIANGDAY, KHOI, PHONGHOC, DANGKYHOC, CHUONGTRINHHOC where KEHOACHGIANGDAY.MaKeHoach = DINHDUONG.MaKeHoach and KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and KEHOACHGIANGDAY.MaPhong = PHONGHOC.MaPhong and KEHOACHGIANGDAY.MaKeHoach = DANGKYHOC.MaKeHoach and KEHOACHGIANGDAY.MaNhanVien = NHANVIEN.MaNhanVien and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and	DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre = 1";
            string table_showdd = "ShowDinhDuong";
            DataSet data_showdd = new DataSet();
            data_showdd = DataConnection.getInstance().Read(sql_overall, table_showdd);
            cReport.SetDataSource(data_showdd);
            crystalReportViewer1.ReportSource = cReport;
        }
    }
}
