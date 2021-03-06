﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.DataAccessLayer
{
    class ThietLapHeThongDAL
    {
        DataConnection dtCon = DataConnection.getInstance();
        string dataSource;
        string initialCatalog;

        public ThietLapHeThongDAL(string path, string databaseName)
        {            
            dataSource = path;
            initialCatalog = databaseName;
        }        

        public int TaoDatabase()
        {
            if (!dtCon.SetupConnection(dataSource))
                return 1;//sai đường dẫn
            string sqlCheck = "select name from master.dbo.sysdatabases where ('[' + name + ']' = '" + initialCatalog + "' OR name = '" + initialCatalog + "')";
            if (dtCon.Read(sqlCheck).Rows.Count == 0)
            {
                string sqlCreateDatabase = "create database " + initialCatalog;
                if (!dtCon.Write(sqlCreateDatabase))
                    return 2;//tên database không hợp lệ
                dtCon.Write("use " + initialCatalog);
                //dung cho no vo resource trong project nua c
                 //cho vo thu mục bin luôn
                //file nào?
                //file setting nữa
                string[] sql_query = File.ReadAllLines(@"SQLQuery.txt");
                foreach (string sql in sql_query)
                    if (!dtCon.Write(sql))
                        return 3;//sai cú pháp
                return 0;//hoàn tất
            }
            return 4;//tên database đã tồn tại
        }

        public void NhapThongTinTruong(string ten, string diaChi, string email, long sdt)
        {
            string sql_query = "insert into THONGTINNHATRE values (N'" + ten + "', N'" + diaChi + "', '" + email + "', " + sdt + ")";
            dtCon.Write(sql_query);

            #region thong tin khoi
            sql_query = "insert into KHOI values (N'Mầm')";
            dtCon.Write(sql_query);
            sql_query = "insert into KHOI values (N'Chồi')";
            dtCon.Write(sql_query);
            sql_query = "insert into KHOI values (N'Lá')";
            dtCon.Write(sql_query);
            #endregion

            #region thong tin phong hoc
            for (int i = 1; i < 10; i++)
                dtCon.Write("insert into PHONGHOC values ('" + i + "')");
            #endregion

            #region thong tin nhom nguoi dung
            dtCon.Write("insert into NHOMNGUOIDUNG values (1,N'Hiệu trưởng')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (2,N'Hiệu phó chuyên môn')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (3,N'Hiệu phó bán trú')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (4,N'Kế toán')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (5,N'Văn thư')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (6,N'Nhân viên cấp dưỡng')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (7,N'Nhân viên y tế')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (8,N'Giáo viên')");
            dtCon.Write("insert into NHOMNGUOIDUNG values (9,N'Admin')");
            #endregion

            #region thong tin chuc nang
            dtCon.Write("insert into CHUCNANG values ('heThongToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('phanQuyenToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('dangXuatToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('nghiepVuToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('quanLyTreEmToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('NhapHocToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('SuaThongTinToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('quanLyNhanVienToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('quanLyHocTapStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('quanLyDiemDanhToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('phanCongGiangDayToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('ghiNhanKetQuaHocTapToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('quanLySucKhoeToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('quanLyDinhDuongToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('danhMucToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('danhSachPhongHocToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('danhSachLopToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('danhSachKhoiToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('danhSachNhanVienToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('danhSachHocSinhToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('danhSachThoiKhoaBieuToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('baoCaoToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('troGiupToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('huongDanSuDungToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('aboutToolStripMenuItem')");
            dtCon.Write("insert into CHUCNANG values ('ghi_hanhVi')");
            dtCon.Write("insert into CHUCNANG values ('them_chuongTrinh')");
            #endregion
        }

        public void ThietLapTaiKhoanQuanTri(string ten, string email, string matKhau)
        {
            dtCon.Write("insert into NHANVIEN values (N'" + ten + "', '" + email + "', '" + matKhau + "')");
            for (int i = 1; i < 28; i++)
            {
                dtCon.Write("insert into NHOMCHUCNANG values(9, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(1, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(2, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(3, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(4, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(5, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(6, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(7, " + i + ")");
                dtCon.Write("insert into NHOMCHUCNANG values(8, " + i + ")");
            }
            dtCon.Write("insert into QUYENHAN values (9, 1)");
        }
    }
}
