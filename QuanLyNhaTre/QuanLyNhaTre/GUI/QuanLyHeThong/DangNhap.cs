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


        private static DangNhap Instance = new DangNhap();

        private DangNhapDAL dangNhapDAL;
        private string email;
        private string matKhau;
        private int maNhanVien;
        private string hoTen;

        public string LayEmail()
        {
            return email;
        }

        public int LayMaNhanVien()
        {
            return maNhanVien;
        }

        public string LayHoTen()
        {
            return hoTen;
        }

        public static DangNhap getInstance()
        {
            return Instance;
        }

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
            hoTen = db.Rows[0].Field<string>("HoTen");            
        }
    }
}
