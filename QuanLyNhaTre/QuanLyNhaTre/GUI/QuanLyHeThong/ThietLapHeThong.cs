using QuanLyNhaTre.DataAccessLayer;
using QuanLyNhaTre.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.QuanLyHeThong
{
    public partial class ThietLapHeThong : Form
    {
        public ThietLapHeThong()
        {
            InitializeComponent();
        }

        KiemTraNhapLieu kt = KiemTraNhapLieu.getInstance();

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap())
            {
                ThietLapHeThongDAL setting = new ThietLapHeThongDAL(txtDuongDan.Text, txtDatabaseName.Text.Replace(" ", ""));
                switch (setting.TaoDatabase())
                {
                    case 0://thành công
                        {
                            setting.NhapThongTinTruong(txtTenTruong.Text, txtDiaChiTruong.Text, txtEmailTruong.Text, Int64.Parse(txtSDTTruong.Text));
                            setting.ThietLapTaiKhoanQuanTri(txtTenNQT.Text, txtEmailNQT.Text, txtMatKhauNQT.Text);

                            string content = txtDuongDan.Text + "\r\n" + txtDatabaseName.Text.Replace(" ", "");
                            File.WriteAllText(@"setting.xml", content);

                            MessageBox.Show("Thiết lập hệ thống thành công. \n Vui lòng đăng nhập để sử dụng hệ thống", "Thông báo");

                            this.Hide();
                            var fm = new DangNhap();
                            fm.Closed += (s, args) => this.Close();
                            fm.Show();
                        }
                        break;
                    case 1://sai thông tin
                        MessageBox.Show("Sai đường dẫn thiết lập!", "Thông báo");
                        break;
                    case 2://tên database không hợp lệ
                        MessageBox.Show("Tên database không hợp lệ!", "Thông báo");
                        break;
                    case 3://sai cú pháp sqlquery
                        MessageBox.Show("Sai cú pháp! Kiểm tra file SQLQuery!", "Thông báo");
                        break;
                    case 4://trùng tên database
                        MessageBox.Show("Tên database này đã tồn tại. Vui lòng nhập lại tên khác", "Thông báo");
                        break;
                }
            }
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool KiemTraDuLieuNhap()
        {
            if (!kt.KiemTraDuLieuRong(this))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin để tiếp tục!", "Thông báo");
                return false;
            }
            if (!kt.KiemTraEmailHopLe(txtEmailNQT.Text) || !kt.KiemTraEmailHopLe(txtEmailTruong.Text))
            {
                MessageBox.Show("Email không hợp lệ!", "Thông báo");
                return false;
            }
            if (txtMatKhauNQT.Text != txtNhapLaiMatKhau.Text)
            {
                MessageBox.Show("Nhập mật khẩu không trùng khớp!", "Thông báo");
                return false;
            }
            return true;
        }

        private void txtSDTTruong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -2))
            {
                e.Handled = true;
            }
        }
    }
}
