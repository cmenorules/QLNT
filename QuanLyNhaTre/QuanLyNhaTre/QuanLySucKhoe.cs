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

namespace QuanLyNhaTre
{
    public partial class QuanLySucKhoe : Form
    {
        QuanLySucKhoeDAL _sk = new QuanLySucKhoeDAL();
        public QuanLySucKhoe()
        {
            InitializeComponent();

            this.dgvKQKham.DataSource = _sk.LayDanhSach();
        }

    }
}
