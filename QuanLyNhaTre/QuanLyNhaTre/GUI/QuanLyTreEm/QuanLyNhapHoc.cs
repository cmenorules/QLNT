using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.QuanLyTreEm
{
    public partial class QuanLyNhapHoc : Form
    {
        public QuanLyNhapHoc()
        {
            InitializeComponent();
            quanLyTreEmBLL = new BusinessLogicLayer.QuanLyTreEmBLL();
            txtNamHoc.Text = DateTime.Now.Year.ToString();
            LoadComboBoxKhoi();
        }

        BusinessLogicLayer.QuanLyTreEmBLL quanLyTreEmBLL;
        int soTreDaThem = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            quanLyTreEmBLL.ThemHoSoTreEm(txtTenCha.Text, txtTenMe.Text, txtNguoiGiamHo.Text, txtEmail.Text, Int32.Parse(txtSDT.Text), txtDiaChi.Text);
            quanLyTreEmBLL.ThemTreEm(txtHoTen.Text, txtNickName.Text, cbGioiTinh.Text, txtNgaySinh.Text, txtDanToc.Text, cbTonGiao.Text, Int32.Parse(cbUuTien.Text), txtTinhCach.Text, txtThoiQuen.Text);
            soTreDaThem++;
            lbTinhTrang.Text = "Đã thêm " + soTreDaThem + " trẻ";
            quanLyTreEmBLL.DangKyHoc(Int32.Parse(cbLop.SelectedValue.ToString()));
            Reset();
            txtDanToc.Text = "Kinh";
            txtNamHoc.Text = DateTime.Now.Year.ToString();
        }

        private void Reset()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            this.ActiveControl = txtHoTen;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadComboBoxKhoi()
        {
            cbKhoi.DataSource = quanLyTreEmBLL.LayThongTinKhoi();
            cbKhoi.DisplayMember = "TenKhoi";
            cbKhoi.ValueMember = "MaKhoi";
            cbLop.Enabled = true;
        }

        private void LoadComboBoxLop()
        {
            cbLop.DataSource = quanLyTreEmBLL.LayKeHoachGD(Int32.Parse(cbKhoi.SelectedValue.ToString()), Int32.Parse(txtNamHoc.Text));
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaKeHoach";
        }

        private void cbKhoi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadComboBoxLop();
        }

     
    }
}
