using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTre.BusinessLogicLayer;
using QuanLyNhaTre.QuanLyHeThong;


namespace QuanLyNhaTre.QuanLyHocTap
{
    public partial class QuanLyDiemDanh : Form
    {
        private string maPhieuDiemDanh = "";
        BusinessLogicLayer.QuanLyHocTapBLL bll = new BusinessLogicLayer.QuanLyHocTapBLL();
        public QuanLyDiemDanh()
        {
            InitializeComponent();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyDiemDanh_Load(object sender, EventArgs e)
        {
            txt_giaoVien.Text = QuanLyDangNhap.getInstance().LayMaNhanVien();
            cb_maLop.DataSource = bll.LayKeHoachGiangDay(txt_giaoVien.Text, DateTime.Now.Year.ToString());
            cb_maLop.DisplayMember = "Lop";
            cb_maLop.ValueMember = "MaKeHoach";
            btn_taoSoDiemDanh.Enabled = false;
            //dtg_danhSach.DataSource = bll.LayDanhSachLop(cb_maLop.SelectedValue.ToString());
            //string xxx = DateTime.Now.ToShortDateString();
            //string ngayThang = "";
            DataTable phieuDiemDanh = bll.LayPhieuDiemDanh(cb_maLop.SelectedValue.ToString(), DateTime.Now.ToShortDateString());
            if (phieuDiemDanh.Rows.Count>0)
            {
                //lay danh sach diem danh     
                 maPhieuDiemDanh = phieuDiemDanh.Rows[0]["MaPhieuDiemDanh"].ToString();
                 dtg_danhSach.DataSource = bll.LayDanhSachDiemDanh(phieuDiemDanh.Rows[0]["MaPhieuDiemDanh"].ToString());
            }
            else
            {
                btn_taoSoDiemDanh.Enabled = true;
            }
            
        }

        private void btn_taoSoDiemDanh_Click(object sender, EventArgs e)
        {
            int maLop = int.Parse(cb_maLop.SelectedValue.ToString());
            
            DateTimeFormatInfo info = DateTimeFormatInfo.CurrentInfo;
            Calendar cal = info.Calendar;
            int week = cal.GetWeekOfYear(DateTime.Now, info.CalendarWeekRule, info.FirstDayOfWeek);
            maPhieuDiemDanh = bll.TaoSoDiemDanh(maLop, DateTime.Now.DayOfWeek.ToString(), week, DateTime.Now.ToString()).ToString();
            btn_taoSoDiemDanh.Enabled = false;
            dtg_danhSach.DataSource = bll.LayDanhSachDiemDanh(maPhieuDiemDanh);
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow x in dtg_danhSach.Rows)
            {
                bll.LuuThongTinDiemDanh(maPhieuDiemDanh, 
                    x.Cells["MaTre"].Value.ToString(),
                    x.Cells["DaDiHoc"].Value.ToString(), 
                    x.Cells["DaDonVe"].Value.ToString());
            }

            MessageBox.Show("Đã lưu thông tin");
        }

        private void btn_nhacNho_Click(object sender, EventArgs e)
        {
            QuanLyTreEmBLL treEmBLL = new QuanLyTreEmBLL();
            SendSMS sms = new SendSMS();            
            foreach (DataGridViewRow x in dtg_danhSach.Rows)
            {                                                
                    if(x.Cells["DaDiHoc"].Value.ToString().ToLower() == "false")
                    {
                        try
                        {
                            string sdt = treEmBLL.LaySoDienThoai(x.Cells["MaTre"].Value.ToString());
                            //x.Cells["MaTre"]
                            sms.send(sdt, "i kill u!");
                            //c++;
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }

                    }
                    
            }

            MessageBox.Show("Đã Nhắc Nhở!");
        }


    }
}
