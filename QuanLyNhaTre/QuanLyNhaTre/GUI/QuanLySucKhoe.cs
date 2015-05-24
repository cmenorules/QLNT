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
            //load ngày thực hiện
        }
        public void LoadKhoi()
        {

        }
        public void LoadLop(int khoi)
        {

        }
        public void LoadAllMaTre(int maKeHoach, int lop)
        {

        }
        public void LoadThongTinHocSinh(int MaTre)
        {

        }
        
        
    }
}
