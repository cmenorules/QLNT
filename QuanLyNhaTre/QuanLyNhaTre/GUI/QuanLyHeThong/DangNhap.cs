using QuanLyNhaTre.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.QuanLyHeThong
{
    public partial class DangNhap : Form
    {
        public DangNhap() 
        {
            InitializeComponent();
            dangNhapDAL = new DangNhapDAL();
        }        

        private DangNhapDAL dangNhapDAL;
        private string email;
        private string matKhau;    

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            matKhau = txtMatKhau.Text;
            if (email.Contains("'--") || email == "" || matKhau == "")
                MessageBox.Show("Email hoặc mật khẩu không đúng. Vui lòng nhập lại!", "Cảnh báo");
            else
            {
                if (dangNhapDAL.KiemTraDangNhap(txtEmail.Text, txtMatKhau.Text))
                {
                    this.Hide();
                    var form1 = new Form1();
                    form1.Closed += (s, args) => this.Close();
                    form1.Show();
                    LayThongTinDangNhap();
                }
                else
                    MessageBox.Show("Email hoặc mật khẩu không đúng. Vui lòng nhập lại!", "Cảnh báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void LayThongTinDangNhap()
        {
            DataTable db = dangNhapDAL.LayThongTinDangNhap(txtEmail.Text, txtMatKhau.Text);
            QuanLyDangNhap.getInstance().LuuThongTin(db.Rows[0].Field<string>("HoTen"), db.Rows[0].Field<int>("MaNhanVien").ToString());            
        }
    }
}
