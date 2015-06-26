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
        BusinessLogicLayer.QuanLyHocTapBLL bll = new BusinessLogicLayer.QuanLyHocTapBLL();
        public BaoCao()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            LapBaoCao lbc = new LapBaoCao();
            lbc.ShowDialog();
        }
        XemBaoCao xbc = new XemBaoCao();
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            xbc = new XemBaoCao();
            xbc.month = dateTimePicker1.Value.Month.ToString();
            xbc.Show();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
            cBox_TenBe.ResetText();
        }
        static int matre;
        private void BaoCao_Load(object sender, EventArgs e)
        {

            xbc.month = "1";
            label_NgayLapBaoCao.Text = DateTime.Now.Date.ToString();
            try
            {
                label_TenGiaoVien.Text = QuanLyDangNhap.getInstance().LayHoTen();
                label_ChuNhiemLop.Text = bll.LayKeHoachGiangDay(QuanLyDangNhap.getInstance().LayMaNhanVien(), DateTime.Now.Year.ToString()).Rows[0]["Lop"].ToString();

                DataTable dt_dshs_theolop = new DataTable();
                string maKh = bll.LayKeHoachGiangDay(QuanLyDangNhap.getInstance().LayMaNhanVien(), dateTimePicker1.Value.Year.ToString()).Rows[0]["MaKeHoach"].ToString();
                dt_dshs_theolop = bll.LayDanhSachLop(maKh);

                cBox_TenBe.DataSource = dt_dshs_theolop;
                cBox_TenBe.SelectedIndex = 1;
                cBox_TenBe.SelectedIndex--;
                cBox_TenBe.DisplayMember = "HoTen";
                cBox_TenBe.ValueMember = "MaTre";
                matre = Int32.Parse(cBox_TenBe.SelectedValue.ToString());
               
            }
            catch
            {
                MessageBox.Show("Chưa có dữ liệu !!!");
                cBox_TenBe.Enabled = false;
                btn_XacNhan.Enabled = false;
                btn_Xem.Enabled = false;
            }

        }

        private void cBox_TenBe_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        public static int MaTre
        {
            get { return matre; }

        }

        private void cBox_TenBe_SelectionChangeCommitted(object sender, EventArgs e)
        {
            matre = Int32.Parse(cBox_TenBe.SelectedValue.ToString());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            xbc.month = dateTimePicker1.Value.Month.ToString();
        }

 
    }
}
