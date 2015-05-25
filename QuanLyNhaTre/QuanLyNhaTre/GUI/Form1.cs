﻿using QuanLyNhaTre.QuanLyHocTap;
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

namespace QuanLyNhaTre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PhanQuyen();
            
        }

        private void PhanQuyen()
        {
            foreach (ToolStripMenuItem x in menu_test.Items)
            {
                x.Enabled = QuanLyDangNhap.getInstance().GetRoles().GetUserRight(x.Name);
                foreach (ToolStripDropDownItem y in x.DropDownItems)
                {                    
                    y.Enabled = QuanLyDangNhap.getInstance().GetRoles().GetUserRight(y.Name);
                    foreach (ToolStripDropDownItem z in y.DropDownItems)
                    {
                        z.Enabled = QuanLyDangNhap.getInstance().GetRoles().GetUserRight(z.Name);
                    }
                }
            }
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

        private void quảnLýDinhDưỡngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDinhDuong ql = new QuanLyDinhDuong();
            ql.Show();
        }

        private void ghiNhậnKếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GhiNhanKetQua fm = new GhiNhanKetQua();
            fm.Show();
            
        }

        private void quanLySucKhoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySucKhoe fm = new QuanLySucKhoe();
            fm.Show();
        }

        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien fm = new QuanLyNhanVien();
            fm.Show();
        }

        private void phanCongGiangDayDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhanCongGiangDay fm = new PhanCongGiangDay();
            fm.Show();
        }

        private void quanLyDiemDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDiemDanh fm = new QuanLyDiemDanh();
            fm.Show();
        }        
    }
}
