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
using System.Text.RegularExpressions;

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
            LoadComboBoxKhoi(cbKhoi);
            int maKhoi = Int32.Parse(cbKhoi.SelectedValue.ToString());
            LoadComboBoxLop(maKhoi,cbLop);  
            //LoadTxtMaTre();            
        }
        // ----------------------------------------------------------
        // GHI NHẬN KẾT QUẢ KHÁM
        // ----------------------------------------------------------
        //Tích vào mấy Ô CheckBox Đạt hết
        public void CheckckDat()
        {
            ckDatDaLieu.Checked = true;
            ckDatTaiMuiHong.Checked = true;
            ckDatRangHamMat.Checked = true;
            ckDatHoHap.Checked = true;
        }
        //Lấy danh sách mã khối, tên khối
        public void LoadComboBoxKhoi(ComboBox cb)
        {
            cb.DataSource = _qlSucKhoeBLL.LayDanhSachKhoi();
            cb.ValueMember = "MaKhoi";
            cb.DisplayMember = "TenKhoi";
            //cbKhoi.SelectedIndex = 1;
        }
        // Lấy danh sách mã lớp theo chuẩn TênKhối-MãPhòng
        public int LoadComboBoxLop(int maKhoi, ComboBox cb)
        {
            DataTable dt = _qlSucKhoeBLL.LayDanhSachLop(maKhoi, dtpNgayThucHien.Value.Date.Year);
            if (dt.Rows.Count < 1) return 0;
            cb.DataSource = dt;
            cb.ValueMember = "MaKeHoach";
            cb.DisplayMember = "MaKeHoach";
            return dt.Rows.Count;
            //cbLop.SelectedIndex = 1;

        }
        // Lấy mã trẻ hiện lên 
        public void LoadTxtMaTre(int maKeHoach)
        {
            DataTable dt = _qlSucKhoeBLL.LayDanhSachMaDangKy(maKeHoach);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có học sinh trong lớp này!");
                txtMaTre.Text = "";
                txtHoTen.Text = "";
                txtNgaySinh.Text = "";
                return ;
            }
            txtMaTre.Text = dt.Rows[0]["MaDangKy"].ToString();
            LoadGroupBoxThongTinHocSinh(int.Parse(txtMaTre.Text));
           
        }
        // chon lai khoi thi load lai danh sach lop
        private void cbKhoi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maKhoi = Int32.Parse(cbKhoi.SelectedValue.ToString());
            if (LoadComboBoxLop(maKhoi, cbLop) < 1) return;
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            LoadTxtMaTre(maKeHoach);
        }
        // chon lai lop thi load lai danh sach dang ky
        private void cbLop_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            LoadTxtMaTre(maKeHoach);
        }
        //lấy thông tin học sinh hiện lên textbox họ tên và ngày sinh
        public void LoadGroupBoxThongTinHocSinh(int maDangKy)
        {
            DataTable db = _qlSucKhoeBLL.LayThongTinHocSinh(maDangKy);
            txtHoTen.Text = db.Rows[0]["HoTen"].ToString();
            txtNgaySinh.Text = db.Rows[0]["NgaySinh"].ToString();
        }
        // set mọi thông tin hiển thị khám về trạng thái ban đầu
        public void SetNull()
        {
            nudCanNang.Value = 0;
            nudChieuCao.Value = 0;
            txtGhiChuDaLieu.Text = "";
            txtGhiChuHoHap.Text = "";
            txtGhiChuRangHamMat.Text = "";
            txtGhichuTaiMuiHong.Text = "";
            CheckckDat();
            ckKhongDatDaLieu.Checked = false;
            ckKhongDatHoHap.Checked = false;
            ckKhongDatRangHamMat.Checked = false;
            ckKhongDatTaiMuiHong.Checked = false;
        }
        // load mã trẻ trước đó
        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (txtMaTre.Text == "") return;
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            DataTable dt = _qlSucKhoeBLL.LayDanhSachMaDangKy(maKeHoach);
            int maDangKy = int.Parse(txtMaTre.Text.ToString());
            int maDangKyDauTien = int.Parse(dt.Rows[0]["MaDangKy"].ToString());
            if (maDangKy > maDangKyDauTien)
            {
                txtMaTre.Text = (--maDangKy).ToString();
            }
            LoadGroupBoxThongTinHocSinh(maDangKy);

        }
        //load mã trẻ tiếp theo
        private void btnKeTiep_Click(object sender, EventArgs e)
        {
            if (txtMaTre.Text == "") return;
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            int maDangKy = int.Parse(txtMaTre.Text.ToString());
            DataTable dt = _qlSucKhoeBLL.LayDanhSachMaDangKy(maKeHoach);
            int soLuongdt= dt.Rows.Count;
            int maDangKyCuoiCung= int.Parse(dt.Rows[soLuongdt-1]["MaDangKy"].ToString());
            if (maDangKy < maDangKyCuoiCung)
            {
                txtMaTre.Text = (++maDangKy).ToString();
            }
            LoadGroupBoxThongTinHocSinh(maDangKy);
        }
        // xử lý trường hợp trẻ vắng và load mã đăng ký kế tiếp
        private void btnVang_Click(object sender, EventArgs e)
        {
            if (txtMaTre.Text == "") return;
            int maDangKy = int.Parse(txtMaTre.Text.ToString());
            try
            {
                _qlSucKhoeBLL.ThemPhieuSucKhoeVang(dtpNgayThucHien.Text, maDangKy);
                MessageBox.Show("Đã lưu thông tin vắng");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, vui lòng thử lại");
            }
            // load mã đăng ký kế tiếp
           
            int maKeHoach = int.Parse(cbLop.SelectedValue.ToString());
            
            DataTable dt = _qlSucKhoeBLL.LayDanhSachMaDangKy(maKeHoach);
            int soLuongdt= dt.Rows.Count;
            int maDangKyCuoiCung= int.Parse(dt.Rows[soLuongdt-1]["MaDangKy"].ToString());
            if (maDangKy < maDangKyCuoiCung)
            {
                txtMaTre.Text = (++maDangKy).ToString();
            }
            LoadGroupBoxThongTinHocSinh(maDangKy);
        }
        // xử lý sự kiện không đạt với chả đạt
        // hàm xử lý chung
        public static void XuLyClickCheckBox(CheckBox ck1, CheckBox ck2)
        {
            if (ck1.Checked)
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
                return "Không đạt, " + txtghiChu.Text;
        }
        // Xử lý button Ghi Nhận, lưu phiếu sức khỏe xuống CSDL
        private void btnGhiNhan_Click(object sender, EventArgs e)
        {
            if (txtMaTre.Text == "") return;
            if(nudCanNang.Value==0 || nudChieuCao.Value==0)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu!");
                return;
            }
            int maDangKy = int.Parse(txtMaTre.Text.ToString());
            string daLieu, taiMuiHong, rangHamMat, hoHap;
            daLieu = GetDataKham(ckDatDaLieu, txtGhiChuDaLieu);
            taiMuiHong = GetDataKham(ckDatTaiMuiHong, txtGhichuTaiMuiHong);
            rangHamMat = GetDataKham(ckDatRangHamMat, txtGhiChuRangHamMat);
            hoHap = GetDataKham(ckDatDaLieu, txtGhiChuHoHap);
            try
            {
                _qlSucKhoeBLL.ThemPieuSucKhoe(dtpNgayThucHien.Text, (int)nudChieuCao.Value,
                    (int)nudCanNang.Value, daLieu, taiMuiHong, rangHamMat, hoHap, maDangKy);
                MessageBox.Show("Đã ghi nhận!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, kiểm tra lại!");
            }
        }
        // xử lý button Đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // ----------------------------------------------
        // XEM KẾT QUẢ KHÁM
        //----------------------------------------------
        private void tcXemKetQuaKham_Selected(object sender, TabControlEventArgs e)
        {
            //MessageBox.Show("change!");
            LoadComboBoxNam();
            LoadComboBoxKhoi(cbKhoiXemKetQuaKham);
            cbXemTheo.SelectedIndex = 0;
            lbMaTreXemKetQuaKham.Enabled = false;
            txtMaTreXemKetQuaKham.Enabled = false;
            int maKhoi = Int32.Parse(cbKhoiXemKetQuaKham.SelectedValue.ToString());
            LoadComboBoxLop(maKhoi, cbLopXemKetQuaKham);
            dgvKQKham.DataSource = _qlSucKhoeBLL.LayDanhSachPhieuSucKhoe();
            
        }
        private void cbXemTheo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cbXemTheo.Text =="Lớp")
            {
                lbMaTreXemKetQuaKham.Enabled = false;
                txtMaTreXemKetQuaKham.Enabled = false;
                gbChiTiet.Enabled = true;
            }
            else
            {
                lbMaTreXemKetQuaKham.Enabled = true;
                txtMaTreXemKetQuaKham.Enabled = true;
                gbChiTiet.Enabled = false;
            }
        } 

        public void LoadComboBoxNam()
        {
            cbNam.DataSource = _qlSucKhoeBLL.LayDanhSachNamHoc();
            cbNam.ValueMember = "NamHoc";
            cbNam.DisplayMember = "NamHoc";
            
        }
            
        private void cbKhoiXemKetQuaKham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int maKhoi = Int32.Parse(cbKhoiXemKetQuaKham.SelectedValue.ToString());
            LoadComboBoxLop(maKhoi, cbLopXemKetQuaKham);
        }
        public bool KemTraDuLieuRongTimTheoLop()
        {
            if (cbNam.Text == "" || cbThang.Text == "" || cbKhoi.Text == "" || cbLopXemKetQuaKham.Text == "")
                return false;
            return true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (cbXemTheo.Text == "Lớp")
            {
                if (KemTraDuLieuRongTimTheoLop() == false) return;
                int nam = int.Parse(cbNam.Text.ToString());
                int thang = int.Parse(cbThang.Text.ToString());
                int maKhoi = int.Parse(cbKhoiXemKetQuaKham.SelectedValue.ToString());
                int maLop = int.Parse(cbLopXemKetQuaKham.SelectedValue.ToString());
                DataTable dt =_qlSucKhoeBLL.LayDanhSachPhieuSucKhoe(nam, thang, maKhoi, maLop);
                if(dt.Rows.Count==0)
                {
                    MessageBox.Show("Không có thông tin khám lớp này!");
                    return;
                }
                dgvKQKham.DataSource = dt;
            }
            else
            {
                if (txtMaTreXemKetQuaKham.Text == "") return;
                int maTre = 0;
                 string str = @"^\d{1,7}$";
                 Regex rg = new Regex(str);
                 if(!rg.IsMatch(txtMaTreXemKetQuaKham.Text))
                  {
                    MessageBox.Show("Mã trẻ không hợp lệ!");
                      return;
                  }
                DataTable dt= _qlSucKhoeBLL.LayDanhSachPhieuSucKhoe(maTre);
                 if(dt.Rows.Count==0)
                {
                    MessageBox.Show("Không có thông tin khám của trẻ này!");
                    return;
                }
                dgvKQKham.DataSource = dt;


            }
        }



    }
}
