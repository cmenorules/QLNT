using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLySucKhoeDAL
    {
        DataConnection _connection = new DataConnection();

        public DataTable LayDanhSachPhieuSucKhoe()
        {
            return _connection.Read("select* from PHIEUSUCKHOE");
        }
        public DataTable TimPhieuSucKhoe(int matre)
        {
            return _connection.Read("select* PHIEUSUCKHOE where Matre='"+ matre +"'");
        }
        public DataTable TimPhieuSucKhoe(string khoi, string lop)
        {
            return _connection.Read("select matre, thangtuoi, chieucao, cannang, dalieu,"+
            "taimuihong, from PHIEUSUCKHOE inner join where Matre");
       }
        public void ThemPhieuSucKhoe(string thangtuoi, int chieucao, int cannang,
            string dalieu, string taimuihong, string ranghammat, string hohap)
        {
            string cmd=" Insert into PHIEUSUCKHOE  {0},{1}, {2}, N'{3}', N'{4}', N'{5}',N'{6}'";
            _connection.Write(string.Format(cmd, thangtuoi, chieucao, cannang, dalieu, taimuihong, ranghammat, hohap));

        }
        public void ThaydoiPhieuSucKhoe(int matre, int chieucao, int cannang,
            string dalieu, string taimuihong, string ranghammat, string hohap)
        {
            string cmd = "Update PHIEUSUCKHOE set chieucao= {1}, CanNang={2}, DaLieu= N'{3}', TaiMuiHong= N'{4}', RangHamMat='N{5}', HoHap= N'{6}' where Matre = {0}";
            _connection.Write(string.Format(cmd, matre, chieucao, cannang, dalieu, taimuihong, ranghammat, hohap));
        }
        public void XoaPhieuSucKhoe(int matre)
        {
            _connection.Write("Delete from PHIEUSUCKHOE where Matre= "+ matre);
        }

    }
}
