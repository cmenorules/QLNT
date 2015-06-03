using QuanLyNhaTre.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.GUI.QuanLyDanhMuc
{
    public partial class DanhMuc : Form
    {
        private QuanLyDanhMucBLL _connect= new QuanLyDanhMucBLL();
        private DataGridView _dataGridView;
        public DanhMuc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String t = comboBox1.SelectedItem.ToString();
            try
            {
                this.Controls.Remove(_dataGridView);
            }
            catch(Exception ex){

            }
            _dataGridView = new DataGridView();
            _dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            _dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            _dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(_dataGridView.Font, FontStyle.Bold);
            _dataGridView.AutoSize = true;
            _dataGridView.Location = new Point(30, 70);
            DataTable _tbValues;            
            if ("Phòng".Equals(t))
            {
                _tbValues = _connect.LayDanhSachPhong();
                _dataGridView.DataSource = _tbValues;
            }            
            if ("Học Sinh".Equals(t))
            {
                _tbValues = _connect.LayDanhSachTre();
                _dataGridView.DataSource = _tbValues;
            }
            if ("Nhân Viên".Equals(t))
            {
                _tbValues = _connect.LayDanhSachNhanVien();
                _dataGridView.DataSource = _tbValues;
            }
            if ("Khối".Equals(t))
            {
                _tbValues = _connect.LayDanhSachKhoi();
                _dataGridView.DataSource = _tbValues;
            }
            this.Controls.Add(_dataGridView);
                                    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
