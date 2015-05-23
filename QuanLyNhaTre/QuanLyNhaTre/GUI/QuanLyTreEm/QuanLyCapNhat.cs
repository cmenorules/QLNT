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
    public partial class QuanLyCapNhat : Form
    {
        public QuanLyCapNhat()
        {
            InitializeComponent();
            quanLyTreEmBLL = new BusinessLogicLayer.QuanLyTreEmBLL();
            LoadComboBoxKhoiCu();                        
        }
        BusinessLogicLayer.QuanLyTreEmBLL quanLyTreEmBLL;
        DataTable dsTre;

        private void LoadComboBoxKhoiCu()
        {
            cbKhoiCu.DataSource = quanLyTreEmBLL.LayThongTinKhoi();
            cbKhoiCu.DisplayMember = "TenKhoi";
            cbKhoiCu.ValueMember = "MaKhoi";
        }

        private void LoadComboBoxLopCu()
        {
            cbLopCu.DataSource = quanLyTreEmBLL.LayKeHoachGD(Int32.Parse(cbKhoiCu.SelectedValue.ToString()), Int32.Parse(txtNamHoc.Text));
            cbLopCu.DisplayMember = "MaKeHoach";
            cbLopCu.ValueMember = "MaKeHoach";
        }

        private void LoadComboBoxDS()
        {
            dsTre = quanLyTreEmBLL.LayDanhSachTreEm(Int32.Parse(cbKhoiCu.SelectedValue.ToString()), Int32.Parse(cbLopCu.Text));
            cbDS.DataSource = dsTre;
            cbDS.DisplayMember = "HoTen";
            cbDS.ValueMember = "MaTre";
        }

        private void cbKhoiCu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadComboBoxLopCu();
        }     

        private void cbDS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (DataRow dr in dsTre.Rows)
            {
                if (dr[1].ToString() == cbDS.SelectedText)
                    txtMaTre.Text = dr[0].ToString();
            }
        }

        private void btnLayDS_Click(object sender, EventArgs e)
        {
            LoadComboBoxDS();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
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
            cbKhoi.Text = cbKhoiCu.Text;
            cbLop.Text = cbLopCu.Text;
        }

        int i = 0;
        private void btnThem_Click(object sender, EventArgs e)
        {
            quanLyTreEmBLL.CapNhatThongTinTre(Int32.Parse(txtMaTre.Text), txtHoTen.Text, txtNickName.Text, txtGioiTinh.Text, txtNgaySinh.Text, txtDanToc.Text, txtTonGiao.Text, Int32.Parse(txtUuTien.Text), txtTinhCach.Text, txtThoiQuen.Text);
            quanLyTreEmBLL.CapNhatThongTinHoSo(Int32.Parse(txtMaHoSo.Text), txtTenCha.Text, txtTenMe.Text, txtNguoiGiamHo.Text, txtEmail.Text, Int32.Parse(txtSDT.Text), txtDiaChi.Text);
            lbTinhTrang.Text = "Đã sửa " + ++i + "thông tin trẻ";
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
    }
}
