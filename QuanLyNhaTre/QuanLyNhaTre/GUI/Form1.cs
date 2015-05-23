﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        
    }
}