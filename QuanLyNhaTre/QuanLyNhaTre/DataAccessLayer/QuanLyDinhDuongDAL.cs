using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyDinhDuongDAL
    {
        private DataConnection dt_con = DataConnection.getInstance();
        public bool ThemDinhDuong(int makehoach, int buoi, string thu, int tuan, string ngayThangNam, string monChinh, string monCanh, string monPhu, string monTrangMieng)
        {
            try
            {                
                dt_con.Write("insert into DINHDUONG values(" + makehoach + "," + buoi + ",N'" + thu + "'," + tuan + ",N'" + ngayThangNam + "',N'" + monChinh + "',N'" + monCanh + "',N'" + monPhu + "',N'" + monTrangMieng + "')");
                MessageBox.Show("đã thêm thành công");
                return true;
            }catch(Exception e)
                {
                MessageBox.Show("Erro! Không Thể Thêm Dinh Dưỡng");
                return false;
                }
        }
    }
}
