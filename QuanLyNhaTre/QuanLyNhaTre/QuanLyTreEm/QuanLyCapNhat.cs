using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.QuanLyTreEm
{
    public partial class QuanLyCapNhat : Form
    {
        public QuanLyCapNhat()
        {
            InitializeComponent();
            quanLyTreEmBLL = new BusinessLogicLayer.QuanLyTreEmBLL();
            LoadComboBoxKhoiCu();                        
        }
        BusinessLogicLayer.QuanLyTreEmBLL quanLyTreEmBLL;
        DataTable dsTre;

        private void LoadComboBoxKhoiCu()
        {
            cbKhoiCu.DataSource = quanLyTreEmBLL.LayThongTinKhoi();
            cbKhoiCu.DisplayMember = "TenKhoi";
            cbKhoiCu.ValueMember = "MaKhoi";
        }

        private void LoadComboBoxLopCu()
        {
            cbLopCu.DataSource = quanLyTreEmBLL.LayKeHoachGD(cbKhoiCu.SelectedIndex + 1, Int32.Parse(txtNamHoc.Text));
            cbLopCu.DisplayMember = "MaKeHoach";
            cbLopCu.ValueMember = "MaKeHoach";
        }

        private void LoadComboBoxDS()
        {
            dsTre = quanLyTreEmBLL.LayDanhSachTreEm(cbKhoiCu.SelectedIndex + 1, Int32.Parse(cbLopCu.Text));
            cbDS.DataSource = dsTre;
            cbDS.DisplayMember = "HoTen";
            cbDS.ValueMember = "MaTre";
        }

        private void cbKhoiCu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadComboBoxLopCu();
        }

        private void cbLopCu_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            LoadComboBoxDS(); ;
        }

        private void cbDS_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (DataRow dr in dsTre.Rows)
            {
                if (dr[1].ToString() == cbDS.SelectedText)
                    txtMaTre.Text = dr[0].ToString();
            }
        }

       
    }
}
