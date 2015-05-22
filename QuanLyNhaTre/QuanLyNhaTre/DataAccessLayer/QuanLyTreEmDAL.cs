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
            string sqlQuery = "select MakeHoach from KEHOACHGIANGDAY, CHUONGTRINHHOC, KHOI where KEHOACHGIANGDAY.MaChuongTrinh = CHUONGTRINHHOC.MaChuongTrinh and CHUONGTRINHHOC.MaKhoi = KHOI.MaKhoi and KEHOACHGIANGDAY.NamHoc = '" + namHoc + "' and CHUONGTRINHHOC.MaKhoi =" + khoi;
            return dt_con.Read(sqlQuery);            
        }

        public void DangKyHoc(int lop, int khoi, int namHoc)
        {
            dt_con.Write("insert into DANGKYHOC values ('" + lop + "','" + maTreEm + "','"+ TaoSoThuTu() + "')");
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
            " where CHUONGTRINHHOC.MaKhoi =" + khoi + " and KEHOACHGIANGDAY.MaKeHoach = " + lop + 
            " and CHUONGTRINHHOC.MaChuongTrinh = KEHOACHGIANGDAY.MaChuongTrinh and DANGKYHOC.MaKeHoach = KEHOACHGIANGDAY.MaKeHoach and TREEM.MaTre = DANGKYHOC.MaTre");
            return dt;
        }

        public DataTable LayThongTinTre(int maTre)
        {
            return dt_con.Read("select * from TREEM where MaTre = " + maTre);
        }

        public DataTable LayThongTinHoSoTre(int maHoSo)
        {
            return dt_con.Read("select * from HOSOTREEM where MaHoSoTreEm = " + maHoSo);
        }

        public void CapNhatThongTinTre(int maTre, string hoTen, string tenThanMat, string gioiTinh, string ngaySinh,
            string danToc, string tonGiao, int doiTuongUuTien, string tinhCach, string thoiQuen)
        {
            dt_con.Write("update TREEM set HoTen = '" + hoTen + "'," + "TenThanMat = '" + tenThanMat + "'," + "GioiTinh = '" + gioiTinh + "'," + "NgaySinh = '" + ngaySinh +
            "'," + "DanToc = '" + danToc + "'," + "TonGiao = '" + tonGiao + "'," + "DoiTuongUuTien = '" + doiTuongUuTien + "'," + "TinhCach = '" + tinhCach + "'," +
            "ThoiQuen = '" + thoiQuen + "' where MaTre = " + maTre);
        }

        public void CapNhatThongTinHoSo(int maHoSo, string hoTenCha, string hoTenMe, string hoTenNguoiGiamHo, string emailNguoiGiamHo, int soDienThoaiNguoiGiamHo, string DiaChi)
        {
            dt_con.Write("update HOSOTREEM set HoTenCha = '" + hoTenCha + "'," + "HoTenMe = '" + hoTenMe + "'," + "HoTenNguoiGiamHo = '" + hoTenNguoiGiamHo + "'," + "EmailNguoiGiamHo = '" + emailNguoiGiamHo
                 + "'," + "SoDienThoaiNguoiGiamHo = '" + soDienThoaiNguoiGiamHo + "'," + "DiaChi = '" + DiaChi + "' where MaHoSoTreEm =" + maHoSo);
        }
    }
}
