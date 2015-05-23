using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre
{
    class Program
    {
        private static void Main()
        {
            if(File.Exists(@"..\..\Resources/setting.xml"))
                Application.Run(new QuanLyHeThong.DangNhap());
            else
                Application.Run(new QuanLyHeThong.ThietLapHeThong());
        }
    }
}
