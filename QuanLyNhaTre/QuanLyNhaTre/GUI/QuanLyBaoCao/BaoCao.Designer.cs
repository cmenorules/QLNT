namespace QuanLyNhaTre.GUI.QuanLyBaoCao
{
    partial class BaoCao
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
            this.label_TenGiaoVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_ChuNhiemLop = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.label_NgayLapBaoCao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.cBox_TenBe = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên giáo viên: ";
            // 
            // label_TenGiaoVien
            // 
            this.label_TenGiaoVien.AutoSize = true;
            this.label_TenGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenGiaoVien.Location = new System.Drawing.Point(124, 30);
            this.label_TenGiaoVien.Name = "label_TenGiaoVien";
            this.label_TenGiaoVien.Size = new System.Drawing.Size(94, 17);
            this.label_TenGiaoVien.TabIndex = 0;
            this.label_TenGiaoVien.Text = "Tên giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chủ nhiệm lớp: ";
            // 
            // label_ChuNhiemLop
            // 
            this.label_ChuNhiemLop.AutoSize = true;
            this.label_ChuNhiemLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ChuNhiemLop.Location = new System.Drawing.Point(130, 64);
            this.label_ChuNhiemLop.Name = "label_ChuNhiemLop";
            this.label_ChuNhiemLop.Size = new System.Drawing.Size(98, 17);
            this.label_ChuNhiemLop.TabIndex = 0;
            this.label_ChuNhiemLop.Text = "Chủ nhiệm lớp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_TenGiaoVien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label_ChuNhiemLop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_XacNhan);
            this.groupBox2.Controls.Add(this.label_NgayLapBaoCao);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 139);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lập báo cáo";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(133, 108);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(63, 25);
            this.btn_XacNhan.TabIndex = 2;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // label_NgayLapBaoCao
            // 
            this.label_NgayLapBaoCao.AutoSize = true;
            this.label_NgayLapBaoCao.Location = new System.Drawing.Point(137, 80);
            this.label_NgayLapBaoCao.Name = "label_NgayLapBaoCao";
            this.label_NgayLapBaoCao.Size = new System.Drawing.Size(65, 13);
            this.label_NgayLapBaoCao.TabIndex = 1;
            this.label_NgayLapBaoCao.Text = "24/05/2015";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày lập báo cáo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Việc lập báo cáo và gửi qua email cho \r\nphụ huynh sẽ hoàn toàn tự động,  để\r\nthực" +
    "  hiện  điều  này  vui  lòng   chọn  \r\n\"Xác nhận\" ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.btn_Xem);
            this.groupBox3.Controls.Add(this.cBox_TenBe);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(220, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 139);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xem báo cáo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn ngày xem báo cáo:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Location = new System.Drawing.Point(139, 106);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(63, 25);
            this.btn_Xem.TabIndex = 2;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // cBox_TenBe
            // 
            this.cBox_TenBe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_TenBe.FormattingEnabled = true;
            this.cBox_TenBe.Location = new System.Drawing.Point(80, 80);
            this.cBox_TenBe.Name = "cBox_TenBe";
            this.cBox_TenBe.Size = new System.Drawing.Size(122, 21);
            this.cBox_TenBe.TabIndex = 1;
            this.cBox_TenBe.SelectedIndexChanged += new System.EventHandler(this.cBox_TenBe_SelectedIndexChanged);
            this.cBox_TenBe.SelectionChangeCommitted += new System.EventHandler(this.cBox_TenBe_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên học sinh:";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(365, 22);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(64, 23);
            this.btn_Dong.TabIndex = 3;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(364, 51);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(64, 23);
            this.btn_Refresh.TabIndex = 4;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 270);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaoCao";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.BaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TenGiaoVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_ChuNhiemLop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_NgayLapBaoCao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cBox_TenBe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}