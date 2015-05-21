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
            LoadComboBoxKhoi();
            LoadComboBoxLop();
            LoadComboBoxDS();
        }
        BusinessLogicLayer.QuanLyTreEmBLL quanLyTreEmBLL;

        private void LoadComboBoxKhoi()
        {
            cbKhoiCu.DataSource = quanLyTreEmBLL.LayThongTinKhoi();
            cbKhoiCu.DisplayMember = "TenKhoi";
            cbKhoiCu.ValueMember = "MaKhoi";
        }

        private void LoadComboBoxLop()
        {
            cbLopCu.DataSource = quanLyTreEmBLL.LayKeHoachGD(cbKhoi.SelectedIndex, Int32.Parse(txtNamHoc.Text));
            cbLopCu.DisplayMember = "MaKeHoach";
            cbLopCu.ValueMember = "MaKeHoach";
        }

        private void LoadComboBoxDS()
        {
            cbDS.DataSource = quanLyTreEmBLL.LayDanhSachTreEm(cbKhoiCu.SelectedIndex, cbLopCu.SelectedIndex);
            cbDS.DisplayMember = "HoTen";
            cbDS.ValueMember = "MaTre";
        }

    
    }
}
