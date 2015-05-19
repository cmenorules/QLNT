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
                setting.NhapThongTinTruong(txtTenTruong.Text, txtDiaChiTruong.Text, txtEmailTruong.Text, Int32.Parse(txtSDTTruong.Text));
                setting.ThietLapTaiKhoanQuanTri(txtTenNQT.Text, txtEmailNQT.Text, txtMatKhauNQT.Text);

                string content = txtDuongDan.Text + "\r\n" + txtDatabaseName.Text.Replace(" ", "");
                File.WriteAllText(@"..\..\Resources/setting.xml", content);

                this.Hide();
                var form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
