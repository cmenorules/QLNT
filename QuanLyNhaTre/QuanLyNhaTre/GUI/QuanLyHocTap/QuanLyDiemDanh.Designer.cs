namespace QuanLyNhaTre.QuanLyHocTap
{
    partial class QuanLyDiemDanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_giaoVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dt_ngayLap = new System.Windows.Forms.DateTimePicker();
            this.cb_maLop = new System.Windows.Forms.ComboBox();
            this.btn_taoSoDiemDanh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtg_danhSach = new System.Windows.Forms.DataGridView();
            this.MaTre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaDiHoc = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DaDonVe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giáo viên:";
            // 
            // txt_giaoVien
            // 
            this.txt_giaoVien.Location = new System.Drawing.Point(75, 30);
            this.txt_giaoVien.Name = "txt_giaoVien";
            this.txt_giaoVien.ReadOnly = true;
            this.txt_giaoVien.Size = new System.Drawing.Size(100, 20);
            this.txt_giaoVien.TabIndex = 1;
            this.txt_giaoVien.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(245, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm danh đầu buổi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_dong);
            this.groupBox1.Controls.Add(this.btn_capNhat);
            this.groupBox1.Location = new System.Drawing.Point(664, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(21, 54);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(110, 23);
            this.btn_dong.TabIndex = 5;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Location = new System.Drawing.Point(21, 25);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(110, 23);
            this.btn_capNhat.TabIndex = 4;
            this.btn_capNhat.Text = "Lưu thông tin";
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dt_ngayLap);
            this.groupBox2.Controls.Add(this.cb_maLop);
            this.groupBox2.Controls.Add(this.btn_taoSoDiemDanh);
            this.groupBox2.Controls.Add(this.txt_giaoVien);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(34, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(796, 63);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // dt_ngayLap
            // 
            this.dt_ngayLap.Location = new System.Drawing.Point(392, 27);
            this.dt_ngayLap.Name = "dt_ngayLap";
            this.dt_ngayLap.Size = new System.Drawing.Size(200, 20);
            this.dt_ngayLap.TabIndex = 1;
            // 
            // cb_maLop
            // 
            this.cb_maLop.FormattingEnabled = true;
            this.cb_maLop.Location = new System.Drawing.Point(232, 27);
            this.cb_maLop.Name = "cb_maLop";
            this.cb_maLop.Size = new System.Drawing.Size(116, 21);
            this.cb_maLop.TabIndex = 0;
            // 
            // btn_taoSoDiemDanh
            // 
            this.btn_taoSoDiemDanh.Location = new System.Drawing.Point(630, 25);
            this.btn_taoSoDiemDanh.Name = "btn_taoSoDiemDanh";
            this.btn_taoSoDiemDanh.Size = new System.Drawing.Size(144, 23);
            this.btn_taoSoDiemDanh.TabIndex = 2;
            this.btn_taoSoDiemDanh.Text = "Tạo sổ điểm danh";
            this.btn_taoSoDiemDanh.UseVisualStyleBackColor = true;
            this.btn_taoSoDiemDanh.Click += new System.EventHandler(this.btn_taoSoDiemDanh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách các bé đã đi học:";
            // 
            // dtg_danhSach
            // 
            this.dtg_danhSach.AllowUserToAddRows = false;
            this.dtg_danhSach.AllowUserToDeleteRows = false;
            this.dtg_danhSach.AllowUserToResizeColumns = false;
            this.dtg_danhSach.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtg_danhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_danhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_danhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTre,
            this.HoTen,
            this.DaDiHoc,
            this.DaDonVe});
            this.dtg_danhSach.Location = new System.Drawing.Point(34, 164);
            this.dtg_danhSach.MultiSelect = false;
            this.dtg_danhSach.Name = "dtg_danhSach";
            this.dtg_danhSach.Size = new System.Drawing.Size(574, 335);
            this.dtg_danhSach.TabIndex = 3;
            // 
            // MaTre
            // 
            this.MaTre.DataPropertyName = "MaTre";
            this.MaTre.Frozen = true;
            this.MaTre.HeaderText = "Mã trẻ";
            this.MaTre.Name = "MaTre";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.Frozen = true;
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 230;
            // 
            // DaDiHoc
            // 
            this.DaDiHoc.DataPropertyName = "DaDiHoc";
            this.DaDiHoc.Frozen = true;
            this.DaDiHoc.HeaderText = "Đã đi học";
            this.DaDiHoc.Name = "DaDiHoc";
            this.DaDiHoc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DaDiHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DaDonVe
            // 
            this.DaDonVe.DataPropertyName = "DaDonVe";
            this.DaDonVe.Frozen = true;
            this.DaDonVe.HeaderText = "Đã đón";
            this.DaDonVe.Name = "DaDonVe";
            this.DaDonVe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DaDonVe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // QuanLyDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 511);
            this.Controls.Add(this.dtg_danhSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "QuanLyDiemDanh";
            this.Text = "QuanLyDiemDanh";
            this.Load += new System.EventHandler(this.QuanLyDiemDanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_danhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_giaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_ngayLap;
        private System.Windows.Forms.ComboBox cb_maLop;
        private System.Windows.Forms.DataGridView dtg_danhSach;
        private System.Windows.Forms.Button btn_taoSoDiemDanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTre;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaDiHoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaDonVe;
    }
}