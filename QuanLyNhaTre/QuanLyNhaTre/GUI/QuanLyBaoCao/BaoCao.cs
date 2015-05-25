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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            LapBaoCao lbc = new LapBaoCao();
            lbc.ShowDialog();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            XemBaoCao xbc = new XemBaoCao();
            xbc.Show();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            cBox_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBox_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cBox_Thang.SelectedIndex = 0;
            cBox_Nam.SelectedIndex = 0;

            label_TenGiaoVien.Text = QuanLyDangNhap.getInstance().LayHoTen();
        }

     

 
    }
}
