namespace QuanLyNhaTre.GUI.QuanLyBaoCao
{
    partial class LapBaoCao
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
            this.progressBar_LapBaoCao = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label_PhanTram = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBar_LapBaoCao
            // 
            this.progressBar_LapBaoCao.Location = new System.Drawing.Point(13, 13);
            this.progressBar_LapBaoCao.Name = "progressBar_LapBaoCao";
            this.progressBar_LapBaoCao.Size = new System.Drawing.Size(367, 23);
            this.progressBar_LapBaoCao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoàn thành";
            // 
            // label_PhanTram
            // 
            this.label_PhanTram.AutoSize = true;
            this.label_PhanTram.Location = new System.Drawing.Point(203, 39);
            this.label_PhanTram.Name = "label_PhanTram";
            this.label_PhanTram.Size = new System.Drawing.Size(21, 13);
            this.label_PhanTram.TabIndex = 1;
            this.label_PhanTram.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hoàn thành";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // LapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 62);
            this.ControlBox = false;
            this.Controls.Add(this.label_PhanTram);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar_LapBaoCao);
            this.Name = "LapBaoCao";
            this.Text = "Đang xử lý...";
            this.Load += new System.EventHandler(this.LapBaoCao_Load);
            this.Shown += new System.EventHandler(this.LapBaoCao_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_LapBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_PhanTram;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}