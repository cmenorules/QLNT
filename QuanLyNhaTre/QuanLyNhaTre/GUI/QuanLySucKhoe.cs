using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTre.DataAccessLayer;

namespace QuanLyNhaTre
{
    public partial class QuanLySucKhoe : Form
    {
        BusinessLogicLayer.QuanLySucKhoeBLL _qlSucKhoeBLL = new BusinessLogicLayer.QuanLySucKhoeBLL();
        public QuanLySucKhoe()
        {
            InitializeComponent();
            // load ngày thực hiện
            dtpNgayThucHien.Text = DateTime.Now.ToShortDateString();
            // Load ckDat_
            CheckckDat();
            LoadComboBoxKhoi();
            //LoadComboBoxLop();  
            //LoadTxtMaTre();            
        }
        //Tích vào mấy Ô CheckBox Đạt hết
        public void CheckckDat()
        {
            ckDatDaLieu.Checked = true;
            ckDatTaiMuiHong.Checked = true;
            ckDatRangHamMat.Checked = true;
            ckDatHoHap.Checked = true;
        }
        //Lấy danh sách mã khối, tên khối
        public void LoadComboBoxKhoi()
        {
            cbKhoi.DataSource = _qlSucKhoeBLL.LayDanhSachKhoi();
            cbKhoi.ValueMember = "MaKhoi";
            cbKhoi.DisplayMember = "TenKhoi";
            //cbKhoi.SelectedIndex = 1;
        }
        // Lấy danh sách mã lớp theo chuẩn TênKhối-MãPhòng
        public void LoadComboBoxLop()
        {
           int maKhoi= Int32.Parse(cbKhoi.SelectedValue.ToString());
           cbLop.DataSource = _qlSucKhoeBLL.LayDanhSachPhong(maKhoi,dtpNgayThucHien.Value.Date.Year);
           cbLop.ValueMember = "MaKeHoach";
           cbLop.DisplayMember = "MaKeHoach";
            //cbLop.SelectedIndex = 1;
            
        }
        // Lấy danh sách tất cả mã trẻ của 1 lớp
        public void LoadTxtMaTre()
        {
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            DataTable dt = _qlSucKhoeBLL.LayDanhSachMaDangKy(maKeHoach);
            txtMaTre.Text = dt.Rows[1]["MaDangKi"].ToString();
            
        }
        // chon lai khoi thi load lai danh sach lop
        private void cbKhoi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadComboBoxLop();
        }
        // chon lai lop thi load lai danh sach dang ky
        private void cbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadTxtMaTre();
        }
        //lấy thông tin học sinh hiện lên textbox họ tên và ngày sinh
        public void LoadGroupBoxThongTinHocSinh(int maDangKy)
        {
            DataTable db =_qlSucKhoeBLL.LayThongTinHocSinh(maDangKy);
            txtHoTen.Text= db.Rows[1]["HoTen"].ToString();
            txtNgaySinh.Text = db.Rows[1]["NgaySinh"].ToString();
        }
        // load mã trẻ trước đó
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if(txtMaTre.Text=="") return; 
            int maDangKi = int.Parse(txtMaTre.Text.ToString());
            if (maDangKi >= 1)
            {
                txtMaTre.Text = (maDangKi++).ToString();
            }
                
        }
        //load mã trẻ tiếp theo
        private void btnKeTiep_Click(object sender, EventArgs e)
        {
            if (txtMaTre.Text == "") return; 
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            int maDangKi = int.Parse(txtMaTre.Text.ToString());
            int soLuongLop = _qlSucKhoeBLL.LaySoLuongDangKyMotLop(maKeHoach);
            if(maDangKi < soLuongLop)
            {
                txtMaTre.Text = (maDangKi--).ToString();
            }
        }
        // lưu xuống theo format vắng và load mã đăng ký kế tiếp
        private void btnVang_Click(object sender, EventArgs e)
        {
            if (txtMaTre.Text == "") return;
            int maDangKi = int.Parse(txtMaTre.Text.ToString());
            try
            {
                _qlSucKhoeBLL.ThemPhieuSucKhoeVang(dtpNgayThucHien.Text, maDangKi);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng thử lại");
            }
            // load mã đăng ký kế tiếp
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            int soLuongLop = _qlSucKhoeBLL.LaySoLuongDangKyMotLop(maKeHoach);
            if (maDangKi < soLuongLop)
            {
                txtMaTre.Text = (maDangKi--).ToString();
            }
        }
        // xử lý sự kiện không đạt với chả đạt
        // hàm xử lý chung
        public static void XuLyClickCheckBox(CheckBox ck1, CheckBox ck2)
        {
            if(ck1.Checked)
            {
                ck2.Checked = false;
            }
            else
            {
                ck2.Checked = true;               
            }
        }
        //Hàm xử lý sự kiện từng cái
        private void ckDatDaLieu_CheckedChanged(object sender, EventArgs e)
        {
            XuLyClickCheckBox(ckDatDaLieu, ckKhongDatDaLieu);

        }

        private void ckKhongDatDaLieu_MouseClick(object sender, MouseEventArgs e)
        {
            XuLyClickCheckBox(ckKhongDatDaLieu, ckDatDaLieu);

        }

        private void ckDatTaiMuiHong_MouseClick(object sender, MouseEventArgs e)
        {
            XuLyClickCheckBox(ckDatDaLieu, ckKhongDatDaLieu);
        }
        private void ckKhongDatTaiMuiHong_CheckedChanged(object sender, EventArgs e)
        {
            XuLyClickCheckBox(ckKhongDatTaiMuiHong, ckDatTaiMuiHong);
        }

        private void ckDatTaiMuiHong_CheckedChanged(object sender, EventArgs e)
        {
            XuLyClickCheckBox(ckDatTaiMuiHong, ckKhongDatTaiMuiHong);
        }

        private void ckDatRangHamMat_CheckedChanged(object sender, EventArgs e)
        {
            XuLyClickCheckBox(ckDatRangHamMat, ckKhongDatRangHamMat);
        }

        private void ckKhongDatRangHamMat_CheckedChanged(object sender, EventArgs e)
        {
            XuLyClickCheckBox(ckKhongDatRangHamMat, ckDatRangHamMat);
        }

        private void ckDatHoHap_CheckedChanged(object sender, EventArgs e)
        {
            XuLyClickCheckBox(ckDatHoHap, ckKhongDatHoHap);
        }

        private void ckKhongDatHoHap_CheckedChanged(object sender, EventArgs e)
        {
            XuLyClickCheckBox(ckKhongDatHoHap, ckDatHoHap);
        }
        //Xử lý dữ liệu mấy cái daLieu, taiMuiHong, rangHamMat, hoHap
        public string GetDataKham(CheckBox ck, TextBox txtghiChu)
        {
            if (ck.Checked)
                return "Đạt";
            else
                return "Không đạt" + txtghiChu;
        }
        // Xử lý button Ghi Nhận, lưu phiếu sức khỏe xuống CSDL
        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (txtMaTre.Text == "") return;
            int maDangKi = int.Parse(txtMaTre.Text.ToString());
            string daLieu, taiMuiHong, rangHamMat, hoHap;
            daLieu= GetDataKham(ckDatDaLieu,txtGhiChuDaLieu);
            taiMuiHong = GetDataKham(ckDatTaiMuiHong,txtGhichuTaiMuiHong);
            rangHamMat = GetDataKham(ckDatRangHamMat,txtGhiChuRangHamMat);
            hoHap = GetDataKham(ckDatDaLieu,txtGhiChuHoHap);
            try
            {
                _qlSucKhoeBLL.ThemPieuSucKhoe(dtpNgayThucHien.Text, (int)nudChieuCao.Value,
                    (int)nudCanNang.Value, daLieu, taiMuiHong, rangHamMat, hoHap, maDangKi);
            }catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, kiểm tra lại!");
            }
        }
        // xử lý button Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
       
    }
}
