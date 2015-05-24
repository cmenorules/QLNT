namespace QuanLyNhaTre.GUI.QuanLyBaoCao
{
    partial class XuLyLapBaoCao
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_PhanTram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoàn thành";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(450, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // label_PhanTram
            // 
            this.label_PhanTram.AutoSize = true;
            this.label_PhanTram.Location = new System.Drawing.Point(432, 38);
            this.label_PhanTram.Name = "label_PhanTram";
            this.label_PhanTram.Size = new System.Drawing.Size(21, 13);
            this.label_PhanTram.TabIndex = 0;
            this.label_PhanTram.Text = "0%";
            this.label_PhanTram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // XuLyLapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 58);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_PhanTram);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "XuLyLapBaoCao";
            this.Text = "Lập báo cáo";
            this.Load += new System.EventHandler(this.XuLyLapBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_PhanTram;
    }
}