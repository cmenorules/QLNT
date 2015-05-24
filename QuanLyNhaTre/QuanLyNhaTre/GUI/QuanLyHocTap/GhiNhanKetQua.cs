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
using QuanLyNhaTre.GUI.QuanLyHocTap;

namespace QuanLyNhaTre.QuanLyHocTap
{

    public partial class GhiNhanKetQua : Form
    {
        
        QuanLyHocTapBLL bll = new QuanLyHocTapBLL();
        string maLop = "";
        int tongSoHocSinh = 0;
        Dictionary<string, NhanXet> nhanXet = new Dictionary<string, NhanXet>();
        public GhiNhanKetQua()
        {
            InitializeComponent();
        }
        private void GhiNhanKetQua_Load(object sender, EventArgs e)
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
            foreach (DataRow i in danhsach.Rows)
            {
                nhanXet.Add(i["MaTre"].ToString(), new NhanXet());
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //cb_maHocSinh.SelectedValue.ToString();
            //bll.GhiNhanKetQuaHocTap(int.Parse(maLop), rt_theChat.Text, rt_nhanThuc.Text, rt_nangKhieu.Text, rt_ngonNgu.Text, rt_quanHe.Text, rt_beNgoan.Text);
            int ma_lop = int.Parse(maLop);
            string ngay_hien_tai = DateTime.Now.ToString();
            foreach (KeyValuePair<string, NhanXet> i in nhanXet)
            {
                bll.GhiNhanKetQuaHocTap(ma_lop,ngay_hien_tai, i.Value.phatTrienTheChat, i.Value.phatTrienNhanThuc, i.Value.phatTrienNangKhieu, i.Value.phatTrienNgonNgu, i.Value.phatTrienQuanHe, i.Value.phatTrienQuanHe);
            }
            MessageBox.Show("Đã lưu");
            //cb_maHocSinh.SelectedIndex = (cb_maHocSinh.SelectedIndex + 1) % tongSoHocSinh;            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            
            nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienNangKhieu = rt_nangKhieu.Text;
            nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienNgonNgu = rt_ngonNgu.Text;
            nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienNhanThuc = rt_nhanThuc.Text;
            nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienQuanHe = rt_quanHe.Text;
            nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienTheChat = rt_theChat.Text;
            nhanXet[cb_maHocSinh.SelectedValue.ToString()].beNgoan = rt_beNgoan.Text;
            cb_maHocSinh.SelectedIndex = (cb_maHocSinh.SelectedIndex + 1) % tongSoHocSinh;   
        }

        private void cb_maHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanXet.Count == 0) return;            
            rt_nangKhieu.Text=nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienNangKhieu;
            rt_ngonNgu.Text = nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienNgonNgu;
            rt_nhanThuc.Text = nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienNhanThuc;
            rt_quanHe.Text = nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienQuanHe;
            rt_theChat.Text=nhanXet[cb_maHocSinh.SelectedValue.ToString()].phatTrienTheChat;
            rt_beNgoan.Text=nhanXet[cb_maHocSinh.SelectedValue.ToString()].beNgoan;
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
