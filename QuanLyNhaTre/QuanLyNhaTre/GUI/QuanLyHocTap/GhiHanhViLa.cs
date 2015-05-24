using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTre.BusinessLogicLayer;

namespace QuanLyNhaTre.GUI.QuanLyHocTap
{
    public partial class GhiHanhViLa : Form
    {
        string maLop = "";
        int tongSoHocSinh = 0;
        bool done = false;
        QuanLyHocTapBLL bll = new QuanLyHocTapBLL();
        public GhiHanhViLa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GhiHanhViLa_Load(object sender, EventArgs e)
        {
            this.txt_maGiaoVien.Text = QuanLyDangNhap.getInstance().LayMaNhanVien();
            DataTable dt = bll.LayKeHoachGiangDay(txt_maGiaoVien.Text, DateTime.Now.Year.ToString());
            txt_maLop.Text = dt.Rows[0]["Lop"].ToString();
            maLop = dt.Rows[0]["MaKeHoach"].ToString();
            DataTable danhsach = bll.LayDanhSachLop(maLop);//lay danh sach hoc sinh thuoc 1 lop
            cb_maHocSinh.DataSource = danhsach;
            tongSoHocSinh = danhsach.Rows.Count;
            cb_maHocSinh.DisplayMember = "HoTen";
            cb_maHocSinh.ValueMember = "MaTre";
            lb_giaoVien.Text = "Giáo viên: " + QuanLyDangNhap.getInstance().LayHoTen();            
            done = true;
            cb_maHocSinh.SelectedIndex = 1;
            cb_maHocSinh.SelectedIndex = 0;
        }

        private void cb_maHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!done) return;   
            DataTable thong_tin = bll.XemThongTin(cb_maHocSinh.SelectedValue.ToString());
            //thong_tin.Rows[0][""].ToString();
            lb_ten.Text = thong_tin.Rows[0]["HoTen"].ToString();
            lb_tonGiao.Text = thong_tin.Rows[0]["TonGiao"].ToString();
            lb_ngaySinh.Text = thong_tin.Rows[0]["NgaySinh"].ToString();
            lb_danToc.Text = thong_tin.Rows[0]["DanToc"].ToString();
            lb_gioiTinh.Text = thong_tin.Rows[0]["GioiTinh"].ToString();
            lb_doiTuong.Text = thong_tin.Rows[0]["DoiTuongUuTien"].ToString();     
        }
    }
}
