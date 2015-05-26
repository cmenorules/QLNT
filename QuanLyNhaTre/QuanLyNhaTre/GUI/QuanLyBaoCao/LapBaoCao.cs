
using CrystalDecisions.CrystalReports.Engine;
using MailTest;
using QuanLyNhaTre.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.GUI.QuanLyBaoCao
{
    public partial class LapBaoCao : Form
    {
        public LapBaoCao()
        {
            InitializeComponent();
        }
        ReportDocument cReportOverall = new ReportDocument();
        DataTable tmp;
        BackgroundWorker bw;
        SendMail sendMail;
        private void LapBaoCao_Load(object sender, EventArgs e)
        {
            
            bw = new BackgroundWorker();
           // bw.RunWorkerAsync();
            //Shown += new EventHandler(LapBaoCao_Shown);
            // To report progress from the background worker we need to set this property
            bw.WorkerReportsProgress = true;
            // This event will be raised on the worker thread when the worker starts
            bw.DoWork += backgroundWorker1_DoWork;
            // This event will be raised when we call ReportProgress
            bw.ProgressChanged += backgroundWorker1_ProgressChanged;
            
            
            string sql_tmp = "select TREEM.MaTre, TREEM.HoTen as TenHocSinh,NHANVIEN.HoTen as TenNhanVien, KHOI.TenKhoi + ' ' + PHONGHOC.TenPhong as Lop,HocKy, NamHoc, Thu, Tuan, NgayThangNam, MonChinh, MonCanh, MonPhu, MonTrangMieng from TREEM, NHANVIEN, DINHDUONG, KEHOACHGIANGDAY, KHOI, PHONGHOC, DANGKYHOC, CHUONGTRINHHOC where KEHOACHGIANGDAY.MaKeHoach = DINHDUONG.MaKeHoach and KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and KEHOACHGIANGDAY.MaPhong = PHONGHOC.MaPhong and KEHOACHGIANGDAY.MaKeHoach = DANGKYHOC.MaKeHoach and KEHOACHGIANGDAY.MaNhanVien = NHANVIEN.MaNhanVien and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and	DANGKYHOC.MaTre = TREEM.MaTre and NHANVIEN.MaNhanVien ='" + QuanLyDangNhap.getInstance().LayMaNhanVien() + "'";
            tmp = new DataTable();
            tmp = DataConnection.getInstance().Read(sql_tmp);
            progressBar_LapBaoCao.Maximum = 100;
            progressBar_LapBaoCao.Minimum = 0;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bw.RunWorkerAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar_LapBaoCao.Value = (e.ProgressPercentage);
            label_PhanTram.Text = (e.ProgressPercentage).ToString()+"%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Lập báo cáo thành công");
        }

        private void LapBaoCao_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < tmp.Rows.Count; i++)
            {
               

                string sql_overall = "select TREEM.HoTen as TenHocSinh,NHANVIEN.HoTen as TenNhanVien, KHOI.TenKhoi + ' ' + PHONGHOC.TenPhong as Lop,HocKy, NamHoc, Thu, Tuan, NgayThangNam, MonChinh, MonCanh, MonPhu, MonTrangMieng from TREEM, NHANVIEN, DINHDUONG, KEHOACHGIANGDAY, KHOI, PHONGHOC, DANGKYHOC, CHUONGTRINHHOC where KEHOACHGIANGDAY.MaKeHoach = DINHDUONG.MaKeHoach and KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and KEHOACHGIANGDAY.MaPhong = PHONGHOC.MaPhong and KEHOACHGIANGDAY.MaKeHoach = DANGKYHOC.MaKeHoach and KEHOACHGIANGDAY.MaNhanVien = NHANVIEN.MaNhanVien and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and	DANGKYHOC.MaTre = TREEM.MaTre and NHANVIEN.MaNhanVien ='" + QuanLyDangNhap.getInstance().LayMaNhanVien() + "' and TREEM.MaTre = '" + tmp.Rows[i]["MaTre"].ToString() + "'";
                string table_showdd = "ShowDinhDuong";
                string sql_health = "select NgayKham, ChieuCao, CanNang, DaLieu, TaiMuiHong, RangHamMat, HoHap from PHIEUSUCKHOE, DANGKYHOC, TREEM where PHIEUSUCKHOE.MaDangKy = DANGKYHOC.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre = '" + tmp.Rows[i]["MaTre"].ToString() + "'";
                string table_showsk = "ShowSucKhoe";
                string sql_goodbaby = "select Ngay, PhatTrienTheChat, PhatTrienNhanThuc, PhatTrienNangKhieu, PhatTrienNgonNgu, PhatTrienQuanHe, BeNgoan from PHIEUTONGKET, DANGKYHOC, TREEM where DANGKYHOC.MaDangKy = PHIEUTONGKET.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre = '" + tmp.Rows[i]["MaTre"].ToString() + "'";
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

                string path = tmp.Rows[i]["MaTre"].ToString() + ".pdf";
                cReportOverall.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);

                //Gửi mail
                string sql_emailGV = "select MaNhanVien, Email, MatKhau from NHANVIEN where MaNhanVien='" + QuanLyDangNhap.getInstance().LayMaNhanVien() + "'";
                DataTable dt_emailGV = DataConnection.getInstance().Read(sql_emailGV);
                sendMail = new SendMail(dt_emailGV.Rows[0][1].ToString(), dt_emailGV.Rows[0][2].ToString());

                string sql_emailNGH = "select HoTen,EmailNguoiGiamHo from TREEM,HOSOTREEM where HOSOTREEM.MaHoSoTreEm = TREEM.MaHoSoTreEm and TREEM.MaTre= '" + tmp.Rows[i]["MaTre"].ToString() + "'";
                DataTable dt_emailNGH = DataConnection.getInstance().Read(sql_emailNGH);
                
                string sql_tenTruong = "select TenNhaTre form ThongTinNhaTre";
                DataTable dt_tenTruong = DataConnection.getInstance().Read(sql_tenTruong);

                string bodyMail = "Báo cáo tổng quát tháng " + DateTime.Now.Month.ToString() + " của bé " + dt_emailNGH.Rows[0][0].ToString();
                string subjectMail = "Trường mẫu giáo " + dt_tenTruong.Rows[0][0].ToString();

                sendMail.Send(dt_emailNGH.Rows[0][1].ToString(),subjectMail,bodyMail,path);
                // backroundwoker
                bw.ReportProgress((int)((i+1) * 100)  / tmp.Rows.Count);
                
            }
            MessageBox.Show("Lập báo cáo thành công");
            Thread.Sleep(200);
            Close();
        }

        
    }
}
