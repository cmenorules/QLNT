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
    public partial class QuanLyDinhDuong : Form
    {        
        BusinessLogicLayer.QuanLyDinhDuongBLL _qldd;
        public QuanLyDinhDuong()
        {
            InitializeComponent();
            _qldd = new BusinessLogicLayer.QuanLyDinhDuongBLL();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyDinhDuong_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
            try
            {
                int makh = Int32.Parse(cbLop.Text);                
                string buoi = cbBuoi.Text;
                int _b=1;
                if ("sang".Equals(buoi))
                    _b = 0;
                string thu ="";
                int tuan = Int32.Parse(tbTuan.Text);
                string ngaythangnam = cbNgay.Value.ToString();
                string monchinh = this.txtMonChinh.Text;
                string moncanh = this.txtMonCanh.Text;
                string monphu = this.txtMonPhu.Text;
                string montrangmieng = this.txtMonTrangMieng.Text;                
                _qldd.ThemDinhDuong(makh, _b, thu, tuan, ngaythangnam, monchinh, moncanh, monphu, montrangmieng);

            }
            catch (Exception ex) { 
                
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
