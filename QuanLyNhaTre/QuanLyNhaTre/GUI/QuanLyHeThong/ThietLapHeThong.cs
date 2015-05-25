using QuanLyNhaTre.DataAccessLayer;
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

        private void btnBatDau_Click(object sender, EventArgs e)
        {            
            ThietLapHeThongDAL setting = new ThietLapHeThongDAL(txtDuongDan.Text, txtDatabaseName.Text.Replace(" ", ""));
            if (setting.TaoDatabase())
            {
                setting.NhapThongTinTruong(txtTenTruong.Text, txtDiaChiTruong.Text, txtEmailTruong.Text, Int64.Parse(txtSDTTruong.Text));
                setting.ThietLapTaiKhoanQuanTri(txtTenNQT.Text, txtEmailNQT.Text, txtMatKhauNQT.Text);

                string content = txtDuongDan.Text + "\r\n" + txtDatabaseName.Text.Replace(" ", "");
                File.WriteAllText(@"..\..\Resources/setting.xml", content);

                MessageBox.Show("Thiết lập hệ thống thành công. \n Vui lòng đăng nhập để sử dụng hệ thống", "Thông báo");

                this.Hide();
                var fm = new DangNhap();
                fm.Closed += (s, args) => this.Close();
                fm.Show();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
    }
}
