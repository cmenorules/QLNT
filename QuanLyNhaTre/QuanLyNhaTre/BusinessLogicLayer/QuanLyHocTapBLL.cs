using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaTre.DataAccessLayer;

namespace QuanLyNhaTre.BusinessLogicLayer
{

    class QuanLyHocTapBLL
    {
        private QuanLyHocTapDAL dal = new QuanLyHocTapDAL();
        //thêm một chương trình học
        public void SoanChuongTrinhHoc(string khoi, string ngayApDung, string ghiChu,List<TimetableItem> items)
        {
            int id = dal.TaoChuongTrinhHocMoi(khoi, ngayApDung, ghiChu);
            foreach (TimetableItem i in items)
            {
                dal.ThemThoiKhoaBieu(id.ToString(), i.hoatDong, i.buoi, i.tuan);
            }
        }
        //thêm một kế hoạch giảng dạy vào hệ thống
        public void PhanCongGiangDay(int namhoc, int hocki, int magv, int maphong, int machuongtrinh)
        {
            dal.ThemMotKeHoachGiangDay(namhoc,hocki,magv,maphong,machuongtrinh);
        }
        //Tạo sổ điểm danh
        public int TaoSoDiemDanh(int maKeHoach, string thu, int tuan, string ngayThang)
        {
            int maPhieu = dal.TaoBangDiemDanh(maKeHoach.ToString(), thu, tuan, ngayThang);
            DataTable danhsach = dal.LayDanhSachHocSinhLop(maKeHoach);
            foreach (DataRow i in danhsach.Rows)
            {
                dal.ThemChiTietDiemDanh(maPhieu, int.Parse(i["MaTre"].ToString()));
            }
            return maPhieu;
        }
        //điểm danh sách học sinh đã đi học
        public void DiemDanhDiHoc(string maPhieu, string maTre)
        {
            dal.CapNhatChiTietDiemDanh(maPhieu, maTre, 1, 0);
        }
        //diểm danh các học sinh chưa đi học
        public void DiemDanhDiVe(string maPhieu, string maTre)
        {
            dal.CapNhatChiTietDiemDanh(maPhieu, maTre, 1, 1);
        }
        //nhắc nhở đi học
        public void NhacNhoDiHoc(int maKeHoach)
        {
            DataTable danhsach = dal.LayDanhSachDiemDanh(maKeHoach);
            foreach (DataRow i in danhsach.Rows)
            {
                if (i["DaDiHoc"].ToString() != "1")
                {
                    //gửi tin nhắn 
                }
            }
        }
        //nhắc nhở tan học
        public void NhacNhoTanHoc(int maKeHoach)
        {
            DataTable danhsach = dal.LayDanhSachDiemDanh(maKeHoach);
            foreach (DataRow i in danhsach.Rows)
            {
                if (i["DaDonVe"].ToString() != "1")
                {
                    //gửi tin nhắn 
                }
            }
        }
        //Ghi nhận kết quả học tập
        public void GhiNhanKetQuaHocTap(int maKeHoach, string thechat, string nhanthuc, string nangkhieu, string ngonngu, string quanhe, string bengoan)
        {

        }
        //Ghi nhận hành vi lạ
        public void GhiNhanHanhViLa(string maDangKi, string hoatDong, string ngayThang, string danhGia)
        {
            dal.GhiNhanHanhViLa(maDangKi, hoatDong, ngayThang, danhGia);
        }
        //Lấy danh sách phòng học
        public DataTable LayDanhSachPhongHoc()
        {
            return dal.LayDanhSachPhongHoc();
        }
        //lấy danh sách chương trình học
        public DataTable LayDanhSachChuongTrinhHoc(int khoi)
        {
            return dal.LayDanhSachChuongTrinhHoc(khoi);
        }
        //lấy danh sách giáo vien trong he thogno
        public DataTable LayDanhSachGiaoVien()
        {
            return dal.LayDanhSachGiaoVien();
        }
        
    }
}
