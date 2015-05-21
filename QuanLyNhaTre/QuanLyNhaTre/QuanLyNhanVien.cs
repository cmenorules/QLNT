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
            foreach(string nhomNguoiDung in _qlNhanVienBLL.LayDanhSachNhomNguoiDung())
            {
                cbChucVu.Items.Add(nhomNguoiDung);
            }
        }
        //kiểm tra dữ liệu từ bàn phím
        public bool CheckInput()
        {
            if (txtHoten.Text == "" || txtEmail.Text == "")
                return false;
            return true;
        }
        //xử lý sự kiện click button Thêm nhân viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                try
                {
                    _qlNhanVienBLL.ThemNhanVien(txtHoten.Text, txtEmail.Text, "user");
                    _qlNhanVienBLL.ThemQuyenHan(int.Parse(txtMaNhanVien.Text), cbChucVu.SelectedIndex);
                    MessageBox.Show("Them Thanh Cong!");
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
        }
        // xử lý sự kiện click button Đóng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckNam_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNu.Checked) ckNu.Checked = false;
        }

        private void ckNu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNam.Checked) ckNu.Checked = false;
        }
        //------------------
        //tab Phan Quyen
        //-----------------

        List<CheckBox> listCheckBox= new List<CheckBox>();

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
        //xử lý sự kiện click button đóng
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void indexOfCheckBox(CheckBox ck)
        {
            
        }
        // xử lý sự kiệu click button cập nhật quyền nhân viên
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //List<int> listQuyen = new List<int>();
            //foreach (CheckBox item in listCheckBox)
            //{
            //    if (item.Checked == true)
            //    {

            //    }
            //}
        }

        

    }
}
