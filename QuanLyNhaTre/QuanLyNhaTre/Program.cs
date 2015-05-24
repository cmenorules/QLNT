using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
//            DataAccessLayer.DangNhapDAL d = new DataAccessLayer.DangNhapDAL();
            //Application.Run(new QuanLyNhaTre.QuanLyNhanVien());
           //Application.Run(new QuanLyNhaTre.QuanLyTreEm.QuanLyNhapHoc());
            //Application.Run(new QuanLyNhaTre.QuanLyHocTap.QuanLyDiemDanh());
            //Application.Run(new QuanLyNhaTre.QuanLyHocTap.PhanCongGiangDay());
            //Application.Run(new QuanLyNhaTre.QuanLyHocTap.ThemChuongTrinhHoc());
            if (File.Exists(@"..\..\Resources/setting.xml"))
                Application.Run(new QuanLyHeThong.DangNhap());
            else
                Application.Run(new QuanLyHeThong.ThietLapHeThong());
        }
    }
}
