namespace QuanLyNhaTre
{
    partial class QuanLyDinhDuong
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbKhoi = new System.Windows.Forms.ComboBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBuoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonCanh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonTrangMieng = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMonPhu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonChinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTuan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp";
            // 
            // cbKhoi
            // 
            this.cbKhoi.FormattingEnabled = true;
            this.cbKhoi.Location = new System.Drawing.Point(97, 36);
            this.cbKhoi.Name = "cbKhoi";
            this.cbKhoi.Size = new System.Drawing.Size(121, 21);
            this.cbKhoi.TabIndex = 1;
            this.cbKhoi.SelectionChangeCommitted += new System.EventHandler(this.cbKhoi_SelectionChangeCommitted);
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(97, 63);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(121, 21);
            this.cbLop.TabIndex = 2;
            // 
            // cbNgay
            // 
            this.cbNgay.Location = new System.Drawing.Point(97, 10);
            this.cbNgay.Name = "cbNgay";
            this.cbNgay.Size = new System.Drawing.Size(200, 20);
            this.cbNgay.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Buổi";
            // 
            // cbBuoi
            // 
            this.cbBuoi.FormattingEnabled = true;
            this.cbBuoi.Items.AddRange(new object[] {
            "Sáng",
            "Chiều"});
            this.cbBuoi.Location = new System.Drawing.Point(433, 10);
            this.cbBuoi.Name = "cbBuoi";
            this.cbBuoi.Size = new System.Drawing.Size(121, 21);
            this.cbBuoi.TabIndex = 3;
            this.cbBuoi.Text = "Sáng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonCanh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMonTrangMieng);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMonPhu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMonChinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(38, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các món ăn";
            // 
            // txtMonCanh
            // 
            this.txtMonCanh.Location = new System.Drawing.Point(395, 39);
            this.txtMonCanh.Name = "txtMonCanh";
            this.txtMonCanh.Size = new System.Drawing.Size(188, 20);
            this.txtMonCanh.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Món canh";
            // 
            // txtMonTrangMieng
            // 
            this.txtMonTrangMieng.Location = new System.Drawing.Point(395, 65);
            this.txtMonTrangMieng.Name = "txtMonTrangMieng";
            this.txtMonTrangMieng.Size = new System.Drawing.Size(188, 20);
            this.txtMonTrangMieng.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Món tráng miệng";
            // 
            // txtMonPhu
            // 
            this.txtMonPhu.Location = new System.Drawing.Point(71, 65);
            this.txtMonPhu.Name = "txtMonPhu";
            this.txtMonPhu.Size = new System.Drawing.Size(175, 20);
            this.txtMonPhu.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Món phụ";
            // 
            // txtMonChinh
            // 
            this.txtMonChinh.Location = new System.Drawing.Point(71, 39);
            this.txtMonChinh.Name = "txtMonChinh";
            this.txtMonChinh.Size = new System.Drawing.Size(175, 20);
            this.txtMonChinh.TabIndex = 5;
            this.txtMonChinh.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Món chính";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(453, 237);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(552, 237);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(371, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Tuần";
            // 
            // tbTuan
            // 
            this.tbTuan.Location = new System.Drawing.Point(433, 37);
            this.tbTuan.Name = "tbTuan";
            this.tbTuan.Size = new System.Drawing.Size(121, 20);
            this.tbTuan.TabIndex = 4;
            this.tbTuan.Text = "1";
            // 
            // QuanLyDinhDuong
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 277);
            this.Controls.Add(this.tbTuan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbNgay);
            this.Controls.Add(this.cbBuoi);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.cbKhoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyDinhDuong";
            this.Text = "Quản lý dinh dưỡng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKhoi;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.DateTimePicker cbNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBuoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMonCanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonTrangMieng;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonPhu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonChinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTuan;
    }
}