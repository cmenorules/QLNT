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
    public partial class QuanLyNhanVien : Form
    {
        BusinessLogicLayer.QuanLyNhanVienBLL _qlNhanVienBLL = new BusinessLogicLayer.QuanLyNhanVienBLL();
        public QuanLyNhanVien()
        {
            InitializeComponent();
            LoadMaNhanVien();
            LoadChucVu();
            KhoiTaolistCheckBox();
        }
        //---------------------------
        //Tab Them Nhan Vien
        //--------------------------
        // Lấy mã nhân viên sẽ thêm
        public void LoadMaNhanVien()
        {
            txtMaNhanVien.Text = (_qlNhanVienBLL.LayMaNhanVienCuoiBang() + 1).ToString();
        }
        //Lấy danh sách tất cả chức vụ trong tổ chức
        public void LoadChucVu()
        {
            cbChucVu.DataSource= _qlNhanVienBLL.LayDanhSachNhomNguoiDung();
            cbChucVu.DisplayMember = "TenNhomNguoiDung";
            cbChucVu.ValueMember = "MaNhomNguoiDung";
            cbChucVu.SelectedIndex = 3;
        }
        //kiểm tra dữ liệu từ bàn phím
        public bool CheckInput()
        {
            if (txtHoten.Text == "" || txtEmail.Text == "")
                return false;
            return true;
        }
        public void SetInputtoNull()
        {
            txtHoten.Text = "";
            txtEmail.Text = "";
            cbChucVu.Text = "";
            ckNam.Checked = false;
            lbNu.Enabled = true;
        }
        //xử lý sự kiện click button Thêm nhân viên
        private void btnThem_Click(object sender, EventArgs e)
        {         
            if (CheckInput())
            {
                try
                {
                    _qlNhanVienBLL.ThemNhanVien(txtHoten.Text, txtEmail.Text, "user");
                    _qlNhanVienBLL.ThemQuyenHan(int.Parse(txtMaNhanVien.Text), cbChucVu.SelectedIndex+1);
                    MessageBox.Show("Thêm thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Thông tin không đầy đủ!");
            }
            LoadMaNhanVien();
            SetInputtoNull();
        }
        // xử lý sự kiện click button Đóng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNam.Checked == true)
            {
                lbNu.Visible = false;
            }
            else
            {
                lbNu.Visible = true;
            }
            
        }
        //------------------
        //tab Phan Quyen
        //-----------------

        List<CheckBox> listCheckBox;

        //Gán mỗi checkbox 1 số thứ tự
        public void CheckInputPhanQuyen()
        {
            if (int.Parse(txtMaNhanVienPhanQuyen.Text) > _qlNhanVienBLL.SoLuongNhanVien())
            {
                MessageBox.Show("Không tồn tại mã nhân viên này");
                txtMaNhanVienPhanQuyen.Text = "";
            }
        }
        public void KhoiTaolistCheckBox()
        {
            listCheckBox = new List<CheckBox>();
            listCheckBox.Add(ckHieuTruong);
            listCheckBox.Add(ckHieuPhoChuyenMon);
            listCheckBox.Add(ckHieuPhoBanTru);
            listCheckBox.Add(ckGiaoVien);
            listCheckBox.Add(ckCapDuong);
            listCheckBox.Add(ckYte);
            listCheckBox.Add(ckVanThu);
            listCheckBox.Add(ckQuanTri);
        }
      
        // public xóa toàn bộ checkbox
        public void XoaToanBoCheckBox()
        {
            foreach ( CheckBox item in listCheckBox)
            {
                item.Checked = false;
            }
        }
        // xu lý sự kiện button tìm kiếm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            List<int> listQuyen = _qlNhanVienBLL.LayDanhSachQuyen(int.Parse(txtMaNhanVienPhanQuyen.Text));
            XoaToanBoCheckBox();
            CheckInputPhanQuyen();
            foreach(int item in listQuyen)
            {
                listCheckBox[item].Checked = true;
            }
        }
        public int indexOfCheckBox(CheckBox ck)
        {

            switch (ck.Name)
            {
                case "ckHieuTruong": return 1;
                case "ckHieuPhoChuyenMon": return 2;
                case "ckHieuPhoBanTru": return 3;
                case "ckGiaoVien": return 4;
                case "ckCapDuong": return 5;
                case "ckYte": return 6;
                case "ckVanThu": return 7;
                case "ckQuanTri": return 8;
                default: return 0;
            }


        }
        // xử lý sự kiệu click button cập nhật quyền nhân viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            List<int> listQuyen = new List<int>();
            foreach (CheckBox item in listCheckBox)
            {
                if (item.Checked == true)
                {
                    listQuyen.Add(indexOfCheckBox(item));
                }
            }
            try
            {
                MessageBox.Show("Cập nhật thành công!");
                _qlNhanVienBLL.CapNhatQuyenHan(int.Parse(txtMaNhanVienPhanQuyen.Text), listQuyen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống, hãy thử lại!");
            }
        }

        //xử lý sự kiện click button đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
