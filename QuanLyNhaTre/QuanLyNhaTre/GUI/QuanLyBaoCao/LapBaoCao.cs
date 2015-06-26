
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
           
            bw.WorkerReportsProgress = true;
           
            bw.DoWork += backgroundWorker1_DoWork;
           
            bw.ProgressChanged += backgroundWorker1_ProgressChanged;

            // Xác định tên của giáo viên để load tên các pé của lớp giáo viên phụ trách
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

        bool done = false;
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
                // sql Lấy báo cáo về dinh dưỡng
                string sql_overall = "select TREEM.HoTen as TenHocSinh,NHANVIEN.HoTen as TenNhanVien, KHOI.TenKhoi + ' ' + PHONGHOC.TenPhong as Lop,HocKy, NamHoc, Thu, Tuan, NgayThangNam, MonChinh, MonCanh, MonPhu, MonTrangMieng from TREEM, NHANVIEN, DINHDUONG, KEHOACHGIANGDAY, KHOI, PHONGHOC, DANGKYHOC, CHUONGTRINHHOC where KEHOACHGIANGDAY.MaKeHoach = DINHDUONG.MaKeHoach and KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and KEHOACHGIANGDAY.MaPhong = PHONGHOC.MaPhong and" + " KEHOACHGIANGDAY.MaKeHoach = DANGKYHOC.MaKeHoach and KEHOACHGIANGDAY.MaNhanVien = NHANVIEN.MaNhanVien and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and DANGKYHOC.MaTre = TREEM.MaTre and NHANVIEN.MaNhanVien ='" + QuanLyDangNhap.getInstance().LayMaNhanVien() + "' and TREEM.MaTre = '" + tmp.Rows[i]["MaTre"].ToString() + "' and MONTH(DINHDUONG.NgayThangNam) =" + DateTime.Now.Month;
                // Tên của bảng trong dataset
                string table_showdd = "ShowDinhDuong";
                // sql Lấy báo cáo về sức khỏe
                string sql_health = "select NgayKham, ChieuCao, CanNang, DaLieu, TaiMuiHong, RangHamMat, HoHap from PHIEUSUCKHOE, DANGKYHOC, TREEM where PHIEUSUCKHOE.MaDangKy = DANGKYHOC.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre = '" + tmp.Rows[i]["MaTre"].ToString() + "' and MONTH(PHIEUSUCKHOE.NgayKham)=" + DateTime.Now.Month;
                // Tên của bảng trong dataset
                string table_showsk = "ShowSucKhoe";
                // sql Lấy báo cáo về phiếu bé ngoan
                string sql_goodbaby = "select Ngay, PhatTrienTheChat, PhatTrienNhanThuc, PhatTrienNangKhieu, PhatTrienNgonNgu, PhatTrienQuanHe, BeNgoan from PHIEUTONGKET, DANGKYHOC, TREEM where DANGKYHOC.MaDangKy = PHIEUTONGKET.MaDangKy and DANGKYHOC.MaTre = TREEM.MaTre and TREEM.MaTre = '" + tmp.Rows[i]["MaTre"].ToString() + "' and MONTH(PHIEUTONGKET.Ngay)=" + DateTime.Now.Month;
                // Tên của bảng trong dataset
                string table_showtk = "ShowTongKet";
                
                DataSet data_showdd = new DataSet();
                DataSet data_showsk = new DataSet();
                DataSet data_showtk = new DataSet();

                data_showdd = DataConnection.getInstance().Read(sql_overall, table_showdd);
                data_showsk = DataConnection.getInstance().Read(sql_health, table_showsk);
                data_showtk = DataConnection.getInstance().Read(sql_goodbaby, table_showtk);

                cReportOverall.Load(@"E:\TÀI LIỆU ĐẠI HỌC\HK6\PTTK HTTT\QLNT\trunk\QuanLyNhaTre\QuanLyNhaTre\GUI\QuanLyBaoCao\CrystalReportOverall.rpt");
                //cReportOverall.DataSourceConnections.Clear();
                cReportOverall.SetDataSource(data_showdd.Tables[0]);
                //cReportOverall.Subreports[0].DataSourceConnections.Clear();
                cReportOverall.Subreports["CrystalReportHealth.rpt"].SetDataSource(data_showsk.Tables[0]);
                cReportOverall.Subreports["CrystalReportGoodBaby.rpt"].SetDataSource(data_showtk.Tables[0]);
                //đường dẫn đến file báo cáo của bé đã lập
                string path = tmp.Rows[i]["MaTre"].ToString() + ".pdf";
                cReportOverall.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path);

                //Gửi mail
                //Lấy lấy phiếu điểm danh và tính tổng số ngày điểm danh
                string maNV = QuanLyDangNhap.getInstance().LayMaNhanVien();
                string sql_phieudiemdanh = "select * from PHIEUDIEMDANH,KEHOACHGIANGDAY where PHIEUDIEMDANH.MaKeHoach = KEHOACHGIANGDAY.MaKeHoach and KEHOACHGIANGDAY.MaNhanVien ='" + maNV + "' and MONTH(PHIEUDIEMDANH.NgayThangNam)=" + DateTime.Now.Month;
                DataTable dt_phieudiemdanh = DataConnection.getInstance().Read(sql_phieudiemdanh);
                int soNgayDiemDanh = dt_phieudiemdanh.Rows.Count;
                //Lấy chi tiết phiếu điểm danh và tính số ngày đi học
                string sql_ctphieudiemdanh = "select * from CHITIETPHIEUDIEMDANH,PHIEUDIEMDANH where MaTre ='" + tmp.Rows[i]["MaTre"] + "' and CHITIETPHIEUDIEMDANH.MaPhieuDiemDanh = PHIEUDIEMDANH.MaPhieuDiemDanh and MONTH(PHIEUDIEMDANH.NgayThangNam)=" + DateTime.Now.Month;
                DataTable dt_ctphieudiemdanh = DataConnection.getInstance().Read(sql_ctphieudiemdanh);
                int soNgayDiHoc = 0;
                foreach(DataRow dr in dt_ctphieudiemdanh.Rows)
                {
                    if (dr["DaDiHoc"].ToString()=="true")
                        {
                            soNgayDiHoc++;
                        }
                }
                //thông báo số ngày đi học / số ngày điểm danh
                string show_diemdanh = "Tổng số ngày đi học: " + soNgayDiHoc + "/" + soNgayDiemDanh + "<br>";
                //Lấy các hoạt động lạ hoặc không tốt của pé
                string sql_hoatdong = "select HoatDong,PHIEUHOATDONG.Ngay,PHIEUHOATDONG.DanhGia from PHIEUHOATDONG,TREEM, DANGKYHOC where PHIEUHOATDONG.MaDangKy = DANGKYHOC.MaDangKy and TREEM.MaTre = DANGKYHOC.MaTre and TREEM.MaTre ='" + tmp.Rows[i]["MaTre"] + "'";
                DataTable dt_hoatdong = DataConnection.getInstance().Read(sql_hoatdong);
                string show_hoatdong = "";
                if (dt_hoatdong.Rows.Count != 0)
                {
                    foreach (DataRow dr in dt_hoatdong.Rows)
                    {
                        show_hoatdong += "Ngay: " + dr[1].ToString() + "; Hành động: " + dr[0].ToString() + "; Đánh giá: " + dr[2].ToString() + "<br>";
                    }
                }
                // Lấy email và mật khẩu mail của nhân viên; đưa vào hàm sendMail
                string sql_emailGV = "select MaNhanVien, Email, MatKhau from NHANVIEN where MaNhanVien='" + QuanLyDangNhap.getInstance().LayMaNhanVien() + "'";
                DataTable dt_emailGV = DataConnection.getInstance().Read(sql_emailGV);
                sendMail = new SendMail(dt_emailGV.Rows[0][1].ToString(), dt_emailGV.Rows[0][2].ToString());
                //Lấy email người giám hộ và tên của pé
                string sql_emailNGH = "select HoTen,EmailNguoiGiamHo from TREEM,HOSOTREEM where HOSOTREEM.MaHoSoTreEm = TREEM.MaHoSoTreEm and TREEM.MaTre= '" + tmp.Rows[i]["MaTre"].ToString() + "'";
                DataTable dt_emailNGH = DataConnection.getInstance().Read(sql_emailNGH);
                //Lấy tên nhà trẻ
                string sql_tenTruong = "select TenNhaTre from THONGTINNHATRE";
                DataTable dt_tenTruong = DataConnection.getInstance().Read(sql_tenTruong);
                
                string bodyMail = "Báo cáo tổng quát tháng " + DateTime.Now.Month.ToString() + " của bé " + dt_emailNGH.Rows[0][0].ToString()+"<br>";
                bodyMail += show_diemdanh;
                bodyMail += show_hoatdong;
                string subjectMail = "Trường mẫu giáo " + dt_tenTruong.Rows[0][0].ToString();
                
               
                // backroundwoker báo cáo tiến trình
                bw.ReportProgress((int)((i+1) * 100)  / tmp.Rows.Count);
                try
                {
                    sendMail.Send(dt_emailNGH.Rows[0][1].ToString(), subjectMail, bodyMail, path);
                    done = true;
                }
                catch(Exception exx)
                {
                    done = false;
                    MessageBox.Show("Error");
                    break;
                    
                    
                    //no co thoat dau :D
                    //ok
                    
                }
            }
            if(done)
                MessageBox.Show("Lập báo cáo thành công");
            Thread.Sleep(200);
            Close();
        }

        
    }
}
