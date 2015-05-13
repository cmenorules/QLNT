using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre
{
    public partial class Login : Form
    {
        private LoginCtrl _loginctrl;
        public Login()
        {
            InitializeComponent();
            _loginctrl = new LoginCtrl();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_loginctrl.UserPassExam(txtUser.Text, txtpassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Sai tên hoặc mật khẩu!", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
