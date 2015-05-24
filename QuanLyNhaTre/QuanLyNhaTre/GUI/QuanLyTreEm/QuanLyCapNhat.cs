using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.QuanLyTreEm
{
    public partial class QuanLyCapNhat : Form
    {
        public QuanLyCapNhat()
        {
            InitializeComponent();
            quanLyTreEmBLL = new BusinessLogicLayer.QuanLyTreEmBLL();
            txtNamHoc.Text = DateTime.Now.Year.ToString();
            LoadComboBoxKhoiCu();
        }
        BusinessLogicLayer.QuanLyTreEmBLL quanLyTreEmBLL;
        DataTable dsTre;

        private void LoadComboBoxKhoiCu()
        {

            cbKhoiCu.DataSource = quanLyTreEmBLL.LayThongTinKhoi();
            cbKhoiCu.DisplayMember = "TenKhoi";
            cbKhoiCu.ValueMember = "MaKhoi";
            cbKhoiCu.SelectedValue = 1;

        }

        private void btnLayDS_Click(object sender, EventArgs e)
        {
            dsTre = quanLyTreEmBLL.LayDanhSachTreEm(Int32.Parse(cbKhoiCu.SelectedValue.ToString()), Int32.Parse(cbLopCu.SelectedValue.ToString()));
            cbDS.DataSource = dsTre;
            cbDS.DisplayMember = "HoTen";
            cbDS.ValueMember = "MaTre";           
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = quanLyTreEmBLL.LayThongTinTreEm(Int32.Parse(txtMaTre.Text));
                txtHoTen.Text = dt.Rows[0].Field<string>("HoTen");
                txtNgaySinh.Text = dt.Rows[0].Field<DateTime>("NgaySinh").ToString().Remove(10);
                txtGioiTinh.Text = dt.Rows[0].Field<string>("GioiTinh");
                txtDanToc.Text = dt.Rows[0].Field<string>("DanToc");
                txtTonGiao.Text = dt.Rows[0].Field<string>("TonGiao");
                txtTinhCach.Text = dt.Rows[0].Field<string>("TinhCach");
                txtThoiQuen.Text = dt.Rows[0].Field<string>("ThoiQuen");
                txtUuTien.Text = dt.Rows[0].Field<int>("DoiTuongUuTien").ToString();
                txtNickName.Text = dt.Rows[0].Field<string>("TenThanMat");

                DataTable dt1 = quanLyTreEmBLL.LayThongTinHoSoTreEm(dt.Rows[0].Field<int>("MaHoSoTreEm"));
                txtMaHoSo.Text = dt1.Rows[0].Field<int>("MaHoSoTreEm").ToString();
                txtTenCha.Text = dt1.Rows[0].Field<string>("HoTenCha");
                txtTenMe.Text = dt1.Rows[0].Field<string>("HoTenMe");
                txtNguoiGiamHo.Text = dt1.Rows[0].Field<string>("HoTenNguoiGiamHo");
                txtEmail.Text = dt1.Rows[0].Field<string>("EmailNguoiGiamHo");
                txtSDT.Text = dt1.Rows[0].Field<string>("SoDienThoaiNguoiGiamHo");
                txtDiaChi.Text = dt1.Rows[0].Field<string>("DiaChi");

                cbKhoi.DataSource = quanLyTreEmBLL.LayThongTinKhoi();
                cbKhoi.DisplayMember = "TenKhoi";
                cbKhoi.ValueMember = "MaKhoi";
                cbKhoi.SelectedValue = cbKhoiCu.SelectedValue;
                cbLop.DataSource = quanLyTreEmBLL.LayKeHoachGD(Int32.Parse(cbKhoiCu.SelectedValue.ToString()), Int32.Parse(txtNamHoc.Text));
                cbLop.DisplayMember = "TenLop";
                cbLop.ValueMember = "MaKeHoach";
                cbLop.SelectedValue = cbLopCu.SelectedValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để tiếp tục!", "Thông báo");
            }
        }
        int i = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    DateTime dt = DateTime.ParseExact(txtNgaySinh.Text.ToString(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
                    string s = dt.ToString("mm/dd/yyyy");
                    quanLyTreEmBLL.CapNhatThongTinTre(Int32.Parse(txtMaTre.Text), txtHoTen.Text, txtNickName.Text, txtGioiTinh.Text, s, txtDanToc.Text, txtTonGiao.Text, Int32.Parse(txtUuTien.Text), txtTinhCach.Text, txtThoiQuen.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui lòng nhập ngày tháng theo định dạng: ngày - tháng - năm \n(ngày & tháng có 2 chữ số)!", "Thông báo");
                }
                try
                {
                    quanLyTreEmBLL.CapNhatThongTinHoSo(Int32.Parse(txtMaHoSo.Text), txtTenCha.Text, txtTenMe.Text, txtNguoiGiamHo.Text, txtEmail.Text, Int32.Parse(txtSDT.Text), txtDiaChi.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vui nhập chữ số cho số điện thoại!", "Thông báo");
                }
                quanLyTreEmBLL.CapNhatDangKyHoc(Int32.Parse(cbLop.SelectedValue.ToString()), Int32.Parse(txtMaTre.Text));
                Reset();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để tiếp tục!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Reset();
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
        }

        private void cbDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDS.SelectedValue.ToString() != "System.Data.DataRowView")
                txtMaTre.Text = cbDS.SelectedValue.ToString();
        }


        private void cbKhoiCu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbLopCu.DataSource = quanLyTreEmBLL.LayKeHoachGD(Int32.Parse(cbKhoiCu.SelectedValue.ToString()), Int32.Parse(txtNamHoc.Text));
            cbLopCu.DisplayMember = "TenLop";
            cbLopCu.ValueMember = "MaKeHoach";
        }

        private void cbKhoi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbLop.DataSource = quanLyTreEmBLL.LayKeHoachGD(Int32.Parse(cbKhoiCu.SelectedValue.ToString()), Int32.Parse(txtNamHoc.Text));
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaKeHoach";
        }


    }
}
