using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTre.BusinessLogicLayer;
namespace QuanLyNhaTre.QuanLyHocTap
{
    public partial class PhanCongGiangDay : Form
    {
        QuanLyHocTapBLL bll = new QuanLyHocTapBLL();
        public PhanCongGiangDay()
        {
            InitializeComponent();
        }

        private void PhanCongGiangDay_Load(object sender, EventArgs e)
        {
            txt_namHoc.Text = DateTime.Now.Year.ToString();
            dtg_danhSach.DataSource = bll.LayDanhSachKeHoachGiangDay(DateTime.Now.Year.ToString());
            cb_khoi.SelectedIndex = 0;
            cb_phongHoc.DataSource = bll.LayDanhSachPhongHoc();
            cb_phongHoc.DisplayMember = "TenPhong";
            cb_phongHoc.ValueMember = "MaPhong";
            if (cb_phongHoc.Items.Count > 0)
            {
                cb_phongHoc.SelectedIndex = 0;
            }
            else
            {
                cb_phongHoc.Text = "Không có phòng học";
            }

            cb_giaoVien.DataSource = bll.LayDanhSachGiaoVien();            
            cb_giaoVien.DisplayMember = "HoTen";
            cb_giaoVien.ValueMember = "MaNhanVien";

            //this.cb_namHoc.Items
            cb_hocKi.SelectedIndex = 0;


        }

        private void cb_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_chuongTrinhHoc.DataSource = bll.LayDanhSachChuongTrinhHoc(cb_khoi.SelectedIndex + 1);
            cb_chuongTrinhHoc.DisplayMember = "NgayApDung";
            cb_chuongTrinhHoc.ValueMember = "MaChuongTrinh";
        }

        private void cb_giaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_maGiaoVien.Text = ((DataRowView)(cb_giaoVien.SelectedItem))["MaNhanVien"].ToString();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_phanCong_Click(object sender, EventArgs e)
        {
              int nam = int.Parse(this.txt_namHoc.Text);
              int hocKi =   int.Parse(cb_hocKi.SelectedItem.ToString());
              int maGv =   int.Parse(txt_maGiaoVien.Text);
              int cth = int.Parse(cb_chuongTrinhHoc.SelectedValue.ToString());
              int maPhong = int.Parse(cb_phongHoc.SelectedValue.ToString());
              try
              {
                  bll.PhanCongGiangDay(nam, hocKi, maGv, maPhong, cth);
                  MessageBox.Show("Done!");
              }
              catch(Exception _e)
              {
                  MessageBox.Show("Nhân viên này đã được phân công!");
              }
              
              
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dtg_danhSach.SelectedRows.Count > 0)
            {
                bll.XoaKeHoachGiangDay(dtg_danhSach.SelectedRows[0].Cells[0].Value.ToString());
                this.dtg_danhSach.Rows.Remove(dtg_danhSach.SelectedRows[0]);
                MessageBox.Show("Xong!");   
            }
            else
            {
                MessageBox.Show("Bạn phải chọn một hàng");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtg_danhSach.DataSource = bll.LayDanhSachKeHoachGiangDay(DateTime.Now.Year.ToString());
        }
    }
}
