using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.DataAccessLayer
{
    class QuanLyTreEmDAL
    {
        public QuanLyTreEmDAL()
        {
            dt_con = DataConnection.getInstance();
        }
        private DataConnection dt_con;
        private int maHoSoTreEm;
        private int maTreEm;

        public bool ThemTreEm(string hoTen, string tenThanMat, string gioiTinh, string ngaySinh,
            string danToc, string tonGiao, int doiTuongUuTien, string tinhCach, string thoiQuen)
        {
            maTreEm = TaoMaTreEm() + 1;
            dt_con.Write("insert into TREEM values ('" + maTreEm + "',N'" + hoTen + "',N'" + tenThanMat + "',N'" + gioiTinh + "','" + ngaySinh + "',N'" + danToc + "',N'" + tonGiao + "',N'" + doiTuongUuTien + "',N'" + tinhCach + "',N'" + thoiQuen + "','" + maHoSoTreEm + "')");
            return true;
        }
        public void ThemHoSoTreEm(string hoTenCha, string hoTenMe, string hoTenNguoiGiamHo, string emailNguoiGiamHo, int soDienThoaiNguoiGiamHo, string DiaChi)
        {
            maHoSoTreEm = TaoMaHoSo() + 1;
            dt_con.Write("insert into HOSOTREEM values('" + maHoSoTreEm + "',N'" + hoTenCha + "',N'" + hoTenMe + "',N'" + hoTenNguoiGiamHo + "','" + emailNguoiGiamHo + "','" + soDienThoaiNguoiGiamHo + "',N'" + DiaChi + "')");
        }      

        public DataTable LayKeHoachGiangDay(int khoi, int namHoc)
        {
            string sqlQuery = "select MakeHoach from KEHOACHGIANGDAY, CHUONGTRINHHOC, KHOI where KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and KEHOACHGIANGDAY.NamHoc = '" + namHoc + "'";
            return dt_con.Read(sqlQuery);            
        }

        public void DangKyHoc(int khoi, int namHoc)
        {
            dt_con.Write("insert into DANGKYHOC values ('" + LayKeHoachGiangDay(khoi, namHoc) + "','" + maTreEm + "','"+ TaoSoThuTu() + 1 + "')");
        }

        private int TaoSoThuTu()
        {
            return dt_con.Read("select * from DANGKYHOC").Rows.Count;    
        }

        private int TaoMaHoSo()
        {
            return dt_con.Read("select * from HOSOTREEM").Rows.Count;             
        }

        private int TaoMaTreEm()
        {
            return dt_con.Read("select * from TREEM").Rows.Count;
        }

        public DataTable LayThongTinKhoi()
        {
            return dt_con.Read("select * from KHOI");
        }


        public DataTable LayDanhSachTre(int khoi, int lop)
        {
            DataTable dt = dt_con.Read("select TREEM.MaTre, TREEM.HoTen from TREEM, DANGKYHOC, KEHOACHGIANGDAY, CHUONGTRINHHOC" +
            "where CHUONGTRINHHOC.MaKhoi =" + khoi + "and KEHOACHGIANGDAY.MaKeHoach = " + lop);
            return dt;
        }
    }
}
