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
namespace QuanLyNhaTre.QuanLyHocTap
{

    

    public partial class ThemChuongTrinhHoc : Form
    {
        List<TimetableItem> thoiKhoaBieu = new List<TimetableItem>();
        List<RichTextBox> listRtb = new List<RichTextBox>();
        QuanLyHocTapBLL bll = new QuanLyHocTapBLL();
        public ThemChuongTrinhHoc()
        {
            InitializeComponent();
        }

   

        private void ThemChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            cb_khoi.SelectedIndex = 0;
            for (int i = 1; i <= 52; i++)
            {
                cb_tuan.Items.Add(i);
            }
            cb_tuan.SelectedIndex = 0;

            listRtb.Add(rt_s_t2);
            listRtb.Add(rt_c_t2);
            listRtb.Add(rt_s_t3);
            listRtb.Add(rt_c_t3);
            listRtb.Add(rt_s_t4);
            listRtb.Add(rt_c_t4);
            listRtb.Add(rt_s_t5);
            listRtb.Add(rt_c_t5);
            listRtb.Add(rt_s_t6);            
            listRtb.Add(rt_c_t6);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {            
            bool buoiSang = true;
            foreach (RichTextBox i in listRtb)
            {                
                int buoi = buoiSang ? 1 : 2;
                buoiSang = !buoiSang;
//                 string hoatDong = "";                
//                 foreach(string j in i.Lines)
//                 {
//                     hoatDong += j ;
//                 }
                TimetableItem ttb = new TimetableItem(i.Text, buoi.ToString(), cb_tuan.SelectedItem.ToString());
                thoiKhoaBieu.Add(ttb);
            }
            rt_s_t2.Focus();            
            cb_tuan.SelectedIndex = (cb_tuan.SelectedIndex + 1) % 52;
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (thoiKhoaBieu.Count > 0)
            {                
                string ngay_ap_dung = dt_ngayApDung.Value.Month + "-"+dt_ngayApDung.Value.Day+"-"+dt_ngayApDung.Value.Year;
                bll.SoanChuongTrinhHoc((cb_khoi.SelectedIndex + 1).ToString(), ngay_ap_dung,txt_ghiChu.Text, thoiKhoaBieu);
                MessageBox.Show("Lưu thành công!");
                thoiKhoaBieu.Clear();
                cb_tuan.SelectedIndex = 0;
                foreach (RichTextBox i in listRtb)
                {
                    i.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để thêm");
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            thoiKhoaBieu.Clear();
            cb_tuan.SelectedIndex = 0;
            foreach (RichTextBox i in listRtb)
            {
                i.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
