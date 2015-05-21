using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class QuanLySucKhoeBLL
    {
        DataAccessLayer.QuanLySucKhoeDAL _qlSucKhoeDal = new DataAccessLayer.QuanLySucKhoeDAL();

        public List<string> LayDanhSachMaKhoi()
        {
            DataTable dtDanhSachKhoi = _qlSucKhoeDal.LayDanhSachMaKhoi();
            List<string> listKhoi = new List<string>();
            for(int i=0; i<dtDanhSachKhoi.Rows.Count;i++)
            {
                listKhoi[i] = dtDanhSachKhoi.Rows[i][0].ToString();
            }
            return listKhoi;
        }
        public List<int> LayDanhSachMaLop(int maKhoi)
        {
            DataTable dtDanhSachLop = _qlSucKhoeDal.LayDanhSachMaLop(maKhoi);
            List<int> listLop = new List<int>();
            for (int i = 0; i < dtDanhSachLop.Rows.Count; i++)
            {
                listLop[i] = int.Parse(dtDanhSachLop.Rows[i][0].ToString());
            }
            return listLop;
        }
        public List<int> LayDanhSachMaDangKy(int maKhoi, int maLop)
        {
            DataTable dtDanhSachTreEm = _qlSucKhoeDal.LayDanhSachMaDangKy(maKhoi,maLop);
            List<int> listTreEm = new List<int>();
            for (int i = 0; i < dtDanhSachTreEm.Rows.Count; i++)
            {
                listTreEm[i] = int.Parse(dtDanhSachTreEm.Rows[i][0].ToString());
            }
            return listTreEm;
        }
        public void ThemPhieuSucKhoeVang(string ngayKham, int maDangKy)
        {
            _qlSucKhoeDal.ThemPhieuSucKhoe(ngayKham, 0, 0, "v", "v", "v", "v", maDangKy);
        }
        public void ThemPieuSucKhoe(string ngayKham, int chieuCao, int canNang,
            string daLieu, string taiMuiHong, string rangHamMat, string hoHap, int maDangKi)
        {
            _qlSucKhoeDal.ThemPhieuSucKhoe(ngayKham, chieuCao, canNang, daLieu, taiMuiHong, rangHamMat, hoHap, maDangKi);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int nam, int thang, int maKhoi)
        {
            return _qlSucKhoeDal.LayDanhSachPhieuSucKhoe(nam, thang, maKhoi);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int nam, int thang, int maKhoi, int maLop)
        {
            return _qlSucKhoeDal.LayDanhSachPhieuSucKhoe(nam, thang, maKhoi, maLop);
        }
        public DataTable LayDanhSachPhieuSucKhoe(int maTre)
        {
            return _qlSucKhoeDal.LayDanhSachPhieuSucKhoe(maTre);
        }
        public void ThayDoiPhieuSucKhoe(int maPhieuKhamSucKhoe, int chieuCao, int canNang,
            string daLieu, string taiMuiHong, string rangHamMat, string hoHap)
        {
            _qlSucKhoeDal.ThaydoiPhieuSucKhoe(maPhieuKhamSucKhoe, chieuCao, canNang, daLieu, taiMuiHong, rangHamMat, hoHap);
        }
        public void XoaPhieuSucKhoe(int maPhieuKhamSucKhoe)
        {
            _qlSucKhoeDal.XoaPhieuSucKhoe(maPhieuKhamSucKhoe);
        }
    }
}
