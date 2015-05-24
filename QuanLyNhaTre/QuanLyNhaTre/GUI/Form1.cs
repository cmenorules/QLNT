using QuanLyNhaTre.QuanLyHocTap;
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
using QuanLyNhaTre.GUI.QuanLyHocTap;

namespace QuanLyNhaTre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void hướngDẫnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dangNhap = new QuanLyHeThong.DangNhap();
            dangNhap.Closed += (s, args) => this.Close();
            dangNhap.Show();
        }
     
        private void NhapHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTreEm.QuanLyNhapHoc qlte = new QuanLyTreEm.QuanLyNhapHoc();            
            qlte.Show();
        }

        private void SuaThongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyTreEm.QuanLyCapNhat qlte = new QuanLyTreEm.QuanLyCapNhat();
            qlte.Show();
        }

        private void điểmDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocTap.QuanLyDiemDanh fm = new QuanLyHocTap.QuanLyDiemDanh();
            fm.ShowDialog();
        }

        private void quảnLýDinhDưỡngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDinhDuong ql = new QuanLyDinhDuong();
            ql.Show();
        }

        private void thêmNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
           

        }

        private void ghiNhậnKếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GhiNhanKetQua fm = new GhiNhanKetQua();
            fm.Show();
            
        }

        private void ghiNhậnHànhViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GhiHanhViLa fm = new GhiHanhViLa();
            fm.ShowDialog();
        }

        
    }
}
