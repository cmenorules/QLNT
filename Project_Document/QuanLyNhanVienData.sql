use QuanLyNhaTre

--CHUCNANG
insert into CHUCNANG(TenChucNang) values (N'Thêm nhân viên');--1
insert into CHUCNANG(TenChucNang) values (N'Phân công nhân viên');--2
insert into CHUCNANG(TenChucNang) values (N'Tiếp nhận hồ sơ');--3
insert into CHUCNANG(TenChucNang) values (N'Xếp lớp');--4
insert into CHUCNANG(TenChucNang) values (N'Lấy sổ khám');--5
insert into CHUCNANG(TenChucNang) values (N'Ghi nhận kết quả khám');--6
insert into CHUCNANG(TenChucNang) values (N'Gửi báo cáo');--7
insert into CHUCNANG(TenChucNang) values (N'Lập báo cáo');--8
insert into CHUCNANG(TenChucNang) values (N'Xem báo cáo');--9
insert into CHUCNANG(TenChucNang) values (N'Quản lý Điểm danh');--10
insert into CHUCNANG(TenChucNang) values (N'Ghi nhận kết quả học tập');--11
insert into CHUCNANG(TenChucNang) values (N'Phân công giảng dạy');--12
insert into CHUCNANG(TenChucNang) values (N'Thêm thời khoá biểu');--13
insert into CHUCNANG(TenChucNang) values (N'Thêm phòng học');--14
insert into CHUCNANG(TenChucNang) values (N'Ghi nhận hành vi lạ');--15
insert into CHUCNANG(TenChucNang) values (N'Ghi nhận chế độ dinh dưỡng');--16
insert into CHUCNANG(TenChucNang) values (N'Quản lý quy định');--17

--NHOMNGUOIDUNG
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Hiệu trưởng');--1
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Phó hiệu trưởng chuyên môn');--2
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Phó hiệu trưởng bán trú');--3
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Giáo viên');--4
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Nhân viên cấp dưỡng');--5
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Nhân viên y tế');--6
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Văn thư');--7
insert into NHOMNGUOIDUNG(TenNhomNguoiDung) values (N'Quản trị hệ thống');--8
--NHOMCHUCNANG
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (1,17);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (2,1);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (2,2);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (2,12);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (2,13);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (3,3);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (5,3);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (5,4);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (6,16);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (7,5);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (7,6);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (8,7);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (8,8);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (8,9);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (8,10);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (8,11);
insert into NHOMCHUCNANG(MaNhomNguoiDung,MaChucNang) values (8,15);
--NHANVIEN
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Nguyễn Thành Tâm','tamnt@gmail.com','user' )--1
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Nguyễn Văn Tú','tunv@gmail.com','user' )--2
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Huỳnh Thị Mỹ Ngọc','ngochtm@gmail.com','user' )--3
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Trần Thị Tố Uyên','uyenttt@gmail.com','user' )--4
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Lê Thị Liễu','lieult@gmail.com','user' )--5
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Huỳnh Yến Phượng','phuonghy@gmail.com','user' )--6
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Nguyễn Minh Nhật','nhatnm@gmail.com','user' )--7
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Huỳnh Yến Nhi','nhihy@gmail.com','user' )--8
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Huỳnh Phong','phongh@gmail.com','user' )--9
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Võ văn Tài','taivv@gmail.com','user' )--10
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Huỳnh Đăng Khoa','khoahd@gmail.com','user' )--11
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Nguyễn Bảo Lộc','locbn@gmail.com','user' )--12
insert into NHANVIEN(HoTen,Email,MatKhau) values (N'Trần Đình Tú','tutd@gmail.com','user' )--13
--QUYENHAN
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (1,1);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (2,2);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (3,3);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (4,4);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (5,5);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (5,6);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (6,7);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (6,8);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (7,9);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (7,10);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (8,11);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (8,12);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (8,13);
insert into QUYENHAN(MaNhomNguoiDung, MaNhanVien) values (4,1);




