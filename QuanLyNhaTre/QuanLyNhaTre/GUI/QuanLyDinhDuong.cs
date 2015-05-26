using QuanLyNhaTre.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre
{
    public partial class QuanLyDinhDuong : Form
    {
        BusinessLogicLayer.QuanLyDinhDuongBLL qlddBLL;
        public QuanLyDinhDuong()
        {
            InitializeComponent();
            qlddBLL = new BusinessLogicLayer.QuanLyDinhDuongBLL();
            LoadCBKhoi();
        }

        private void LoadCBKhoi()
        {
            cbKhoi.DataSource = qlddBLL.LayDSKhoi();
            cbKhoi.DisplayMember = "TenKhoi";
            cbKhoi.ValueMember = "MaKhoi";
        }

        private void LoadCBLop()
        {
            cbLop.DataSource = qlddBLL.LayDSLop(cbNgay.Value.Year, Int32.Parse(cbKhoi.SelectedValue.ToString()));
            cbLop.DisplayMember = "TenLop";
            cbLop.ValueMember = "MaKeHoach";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int makh = Int32.Parse(cbLop.SelectedValue.ToString());
                string buoi = cbBuoi.Text;
                int _b = 1;
                if (cbBuoi.Text == "Sáng")
                    _b = 0;
                string thu = cbNgay.Value.DayOfWeek.ToString();
                int tuan = Int32.Parse(tbTuan.Text);

                DateTime dt = DateTime.ParseExact(cbNgay.Value.ToShortDateString(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
                string ngayThangNam = dt.ToString("mm/dd/yyyy");

                string monchinh = this.txtMonChinh.Text;
                string moncanh = this.txtMonCanh.Text;
                string monphu = this.txtMonPhu.Text;
                string montrangmieng = this.txtMonTrangMieng.Text;

                qlddBLL.ThemDinhDuong(makh, _b, thu, tuan, ngayThangNam, monchinh, moncanh, monphu, montrangmieng);

            }
            catch (Exception ex)
            {

            }
            MessageBox.Show("Thêm thực đơn thành công!", "Thông báo");
            Reset();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKhoi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadCBLop();
        }

        private void Reset()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);
            this.ActiveControl = txtMonChinh;
        }
    }
}
