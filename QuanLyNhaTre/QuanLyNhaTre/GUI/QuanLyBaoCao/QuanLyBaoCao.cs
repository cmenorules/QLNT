using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhaTre.GUI.QuanLyBaoCao
{
    public partial class QuanLyBaoCao : Form
    {

        BusinessLogicLayer.QuanLyHocTapBLL bll = new BusinessLogicLayer.QuanLyHocTapBLL();
        public QuanLyBaoCao()
        {
            InitializeComponent();
        }

        private void QuanLyBaoCao_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 1;
            label_TenGiaoVien.Text = QuanLyDangNhap.getInstance().LayMaNhanVien();
            label_ChuNhiemLop.Text = bll.LayKeHoachGiangDay(label_TenGiaoVien.Text, DateTime.Now.Year.ToString()).Rows[0]["Lop"].ToString();
            label_NamHoc.Text = DateTime.Now.Year.ToString() + "-" + int.Parse(DateTime.Now.Year.ToString()) + 1;
            label_NgayLapBaoCao.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {

        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

     
   
     
    
      
       
  
      
    }
}
