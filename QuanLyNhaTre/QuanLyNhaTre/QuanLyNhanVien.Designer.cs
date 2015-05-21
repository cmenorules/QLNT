namespace QuanLyNhaTre
{
    partial class QuanLyNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckNu = new System.Windows.Forms.CheckBox();
            this.ckNam = new System.Windows.Forms.CheckBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckQuanTri = new System.Windows.Forms.CheckBox();
            this.ckVanThu = new System.Windows.Forms.CheckBox();
            this.ckYte = new System.Windows.Forms.CheckBox();
            this.ckCapDuong = new System.Windows.Forms.CheckBox();
            this.ckGiaoVien = new System.Windows.Forms.CheckBox();
            this.ckHieuPhoBanTru = new System.Windows.Forms.CheckBox();
            this.ckHieuPhoChuyenMon = new System.Windows.Forms.CheckBox();
            this.ckHieuTruong = new System.Windows.Forms.CheckBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtMaNhanVienPhanQuyen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(513, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtMaNhanVien);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ckNu);
            this.tabPage1.Controls.Add(this.ckNam);
            this.tabPage1.Controls.Add(this.cbChucVu);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnThoat);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtHoten);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(505, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thêm nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(188, 115);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txtMaNhanVien.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã nhân viên";
            // 
            // ckNu
            // 
            this.ckNu.AutoSize = true;
            this.ckNu.Location = new System.Drawing.Point(269, 220);
            this.ckNu.Name = "ckNu";
            this.ckNu.Size = new System.Drawing.Size(40, 17);
            this.ckNu.TabIndex = 15;
            this.ckNu.Text = "Nữ";
            this.ckNu.UseVisualStyleBackColor = true;
            this.ckNu.CheckedChanged += new System.EventHandler(this.ckNu_CheckedChanged);
            // 
            // ckNam
            // 
            this.ckNam.AutoSize = true;
            this.ckNam.Location = new System.Drawing.Point(188, 220);
            this.ckNam.Name = "ckNam";
            this.ckNam.Size = new System.Drawing.Size(48, 17);
            this.ckNam.TabIndex = 15;
            this.ckNam.Text = "Nam";
            this.ckNam.UseVisualStyleBackColor = true;
            this.ckNam.CheckedChanged += new System.EventHandler(this.ckNam_CheckedChanged);
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(188, 193);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(121, 21);
            this.cbChucVu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Thêm Nhân Viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(311, 288);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Đóng";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(200, 288);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chức vụ:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(188, 141);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(165, 20);
            this.txtHoten.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Họ tên nhân viên:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(188, 167);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnDong);
            this.tabPage2.Controls.Add(this.btnCapNhat);
            this.tabPage2.Controls.Add(this.btnTimkiem);
            this.tabPage2.Controls.Add(this.txtMaNhanVienPhanQuyen);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(505, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phân quyền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckQuanTri);
            this.groupBox1.Controls.Add(this.ckVanThu);
            this.groupBox1.Controls.Add(this.ckYte);
            this.groupBox1.Controls.Add(this.ckCapDuong);
            this.groupBox1.Controls.Add(this.ckGiaoVien);
            this.groupBox1.Controls.Add(this.ckHieuPhoBanTru);
            this.groupBox1.Controls.Add(this.ckHieuPhoChuyenMon);
            this.groupBox1.Controls.Add(this.ckHieuTruong);
            this.groupBox1.Location = new System.Drawing.Point(51, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 168);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhiệm vụ";
            // 
            // ckQuanTri
            // 
            this.ckQuanTri.AutoSize = true;
            this.ckQuanTri.Location = new System.Drawing.Point(217, 112);
            this.ckQuanTri.Name = "ckQuanTri";
            this.ckQuanTri.Size = new System.Drawing.Size(108, 17);
            this.ckQuanTri.TabIndex = 0;
            this.ckQuanTri.Text = "Quản trị hệ thống";
            this.ckQuanTri.UseVisualStyleBackColor = true;
            // 
            // ckVanThu
            // 
            this.ckVanThu.AutoSize = true;
            this.ckVanThu.Location = new System.Drawing.Point(217, 89);
            this.ckVanThu.Name = "ckVanThu";
            this.ckVanThu.Size = new System.Drawing.Size(63, 17);
            this.ckVanThu.TabIndex = 0;
            this.ckVanThu.Text = "Văn thư";
            this.ckVanThu.UseVisualStyleBackColor = true;
            // 
            // ckYte
            // 
            this.ckYte.AutoSize = true;
            this.ckYte.Location = new System.Drawing.Point(217, 66);
            this.ckYte.Name = "ckYte";
            this.ckYte.Size = new System.Drawing.Size(95, 17);
            this.ckYte.TabIndex = 0;
            this.ckYte.Text = "Nhân viên y tế";
            this.ckYte.UseVisualStyleBackColor = true;
            // 
            // ckCapDuong
            // 
            this.ckCapDuong.AutoSize = true;
            this.ckCapDuong.Location = new System.Drawing.Point(217, 43);
            this.ckCapDuong.Name = "ckCapDuong";
            this.ckCapDuong.Size = new System.Drawing.Size(129, 17);
            this.ckCapDuong.TabIndex = 0;
            this.ckCapDuong.Text = "Nhân viên cấp dưỡng";
            this.ckCapDuong.UseVisualStyleBackColor = true;
            // 
            // ckGiaoVien
            // 
            this.ckGiaoVien.AutoSize = true;
            this.ckGiaoVien.Location = new System.Drawing.Point(36, 112);
            this.ckGiaoVien.Name = "ckGiaoVien";
            this.ckGiaoVien.Size = new System.Drawing.Size(71, 17);
            this.ckGiaoVien.TabIndex = 0;
            this.ckGiaoVien.Text = "Giáo viên";
            this.ckGiaoVien.UseVisualStyleBackColor = true;
            // 
            // ckHieuPhoBanTru
            // 
            this.ckHieuPhoBanTru.AutoSize = true;
            this.ckHieuPhoBanTru.Location = new System.Drawing.Point(36, 89);
            this.ckHieuPhoBanTru.Name = "ckHieuPhoBanTru";
            this.ckHieuPhoBanTru.Size = new System.Drawing.Size(137, 17);
            this.ckHieuPhoBanTru.TabIndex = 0;
            this.ckHieuPhoBanTru.Text = "Phó hiệu trưởng bán trú";
            this.ckHieuPhoBanTru.UseVisualStyleBackColor = true;
            // 
            // ckHieuPhoChuyenMon
            // 
            this.ckHieuPhoChuyenMon.AutoSize = true;
            this.ckHieuPhoChuyenMon.Location = new System.Drawing.Point(36, 66);
            this.ckHieuPhoChuyenMon.Name = "ckHieuPhoChuyenMon";
            this.ckHieuPhoChuyenMon.Size = new System.Drawing.Size(162, 17);
            this.ckHieuPhoChuyenMon.TabIndex = 0;
            this.ckHieuPhoChuyenMon.Text = "Phó hiệu trưởng chuyên môn";
            this.ckHieuPhoChuyenMon.UseVisualStyleBackColor = true;
            // 
            // ckHieuTruong
            // 
            this.ckHieuTruong.AutoSize = true;
            this.ckHieuTruong.Location = new System.Drawing.Point(36, 43);
            this.ckHieuTruong.Name = "ckHieuTruong";
            this.ckHieuTruong.Size = new System.Drawing.Size(81, 17);
            this.ckHieuTruong.TabIndex = 0;
            this.ckHieuTruong.Text = "Hiệu trưởng";
            this.ckHieuTruong.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(382, 330);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(88, 23);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(288, 330);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(88, 23);
            this.btnCapNhat.TabIndex = 16;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(325, 84);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 16;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtMaNhanVienPhanQuyen
            // 
            this.txtMaNhanVienPhanQuyen.Location = new System.Drawing.Point(152, 84);
            this.txtMaNhanVienPhanQuyen.Name = "txtMaNhanVienPhanQuyen";
            this.txtMaNhanVienPhanQuyen.Size = new System.Drawing.Size(135, 20);
            this.txtMaNhanVienPhanQuyen.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(154, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 37);
            this.label9.TabIndex = 14;
            this.label9.Text = "Phân Quyền";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã nhân viên";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 404);
            this.Controls.Add(this.tabControl1);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckQuanTri;
        private System.Windows.Forms.CheckBox ckVanThu;
        private System.Windows.Forms.CheckBox ckYte;
        private System.Windows.Forms.CheckBox ckCapDuong;
        private System.Windows.Forms.CheckBox ckGiaoVien;
        private System.Windows.Forms.CheckBox ckHieuPhoBanTru;
        private System.Windows.Forms.CheckBox ckHieuPhoChuyenMon;
        private System.Windows.Forms.CheckBox ckHieuTruong;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtMaNhanVienPhanQuyen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckNu;
        private System.Windows.Forms.CheckBox ckNam;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNhanVien;

    }
}