create database QuanLyNhaTre

create table KEHOACHGIANGDAY
(
MaKeHoach int not null identity primary key,
NamHoc datetime not null,
HocKy int not null,
MaNhanVien int not null,
MaPhong int not null,
MaChuongTrinh int not null
)

create table PHONGHOC
(
MaPhong int not null identity primary key,
TenPhong char(5)
)

create table CHUONGTRINHHOC
(
MaChuongTrinh int not null identity primary key,
NgayApDung datetime,
MaKhoi int,
GhiChu char(50)
)


create table DINHDUONG
(
MaDinhDuong int not null identity primary key,
MaKeHoach int not null,
Buoi char(7),
Thu char(10),
Tuan int,
NgayThangNam datetime,
MonChinh char(30),
MonCanh char(30),
MonPhu char(30),
MonTrangMieng char(30)
)


create table PHIEUDIEMDANH
(
MaPhieuDiemDanh int not null identity primary key,
MaKeHoach int not null,
Thu char(10),
Tuan int,
NgayThangNam datetime
)


create table CHITIETPHIEUDIEMDANH
(
MaPhieuDiemDanh int not null,
MaTre int not null,
DaDiHoc bit not null,
DaDonVe bit not null
)


create table KHOI
(
MaKhoi int not null identity primary key,
TenKhoi char(5)
)

create table THOIKHOABIEU
(
MaThoiKhoaBieu int not null identity primary key,
MaChuongTrinh int,
HoatDong char(50),
Buoi char(7),
Tuan int
)


create table QUYDINH
(
MaQuyDinh int not null identity primary key,
NoiDung char(50)
)

create table THONGTINNHATRE
(
TenNhaTre char(50),
Email char(50),
DiaChi char(50),
SoDienThoai int
)

create table NHANVIEN
(
MaNhanVien int not null identity primary key,
HoTen char(50),
Email char(50),
MatKhau char(20)
)

create table QUYENHAN
(
MaNhomNguoiDung int not null,
MaNhanVien int not null
)


create table NHOMNGUOIDUNG
(
MaNhomNguoiDung int not null identity primary key,
TenNhomNguoiDung char(20)
)

create table NHOMCHUCNANG
(
MaNhomNguoiDung int not null,
MaChucNang int not null
)



create table CHUCNANG
(
MaChucNang int not null identity primary key,
TenChucNang char(30)
)

create table DANGKYHOC
(
MaDangKy int not null identity primary key,
MaKeHoach int,
MaTre int,
SoThuTu int,
)



create table TREEM
(
MaTre int not null identity primary key,
HoTen char(50),
TenThanMat char(20),
GioiTinh char(3),
NgaySinh datetime,
DanToc char(10),
TonGiao char(10),
DoiTuongUuTien int,
TinhCach char(20),
ThoiQuen char(20),
MaHoSoTreEm int
)


create table HOSOTREEM
(
MaHoSoTreEm int not null identity primary key,
HoTenCha char(50),
HoTenMe char(50),
HoTenNguoiGiamHo char(50),
EmailNguoiGiamHo char(50),
SoDienThoaiNguoiGiamHo int,
DiaChi char(50)
)

create table PHIEUSUCKHOE
(
MaPhieuSucKhoe int not null identity primary key,
ThangTuoi int,
ChieuCao int,
CanNang int,
DaLieu char(20),
TaiMuiHong char(20),
RangHamMat char(20),
HoHap char(20),
MaDangKy int
)


create table PHIEUHOATDONG
(
MaPhieuHoatDong int not null identity primary key,
HoatDong char(30),
Ngay datetime,
DanhGia char(30),
MaDangKy int
)


create table PHIEUTONGKET
(
MaPhieuTongKet int not null identity primary key,
PhatTrienTheChat char(30),
PhatTrienNhanThuc char(30),
PhatTrienNangKhieu char(30),
PhatTrienNgonNgu char(30),
PhatTrienQuanHe char(30),
BeNgoan char(10),
MaDangKy int
)

alter table PHIEUTONGKET
add constraint fk_PHIEUTONGKET foreign key (MaDangKy) references DANGKYHOC(MaDangKy)

alter table KEHOACHGIANGDAY
add constraint fk_KEHOACHGIANGDAY1 foreign key (MaNhanVien)
references NHANVIEN (MaNhanVien)

alter table KEHOACHGIANGDAY
add constraint fk_KEHOACHGIANGDAY2 foreign key (MaPhong)
references PHONGHOC (MaPhong)

alter table KEHOACHGIANGDAY
add constraint fk_KEHOACHGIANGDAY3 foreign key (MaChuongTrinh)
references CHUONGTRINHHOC (MaChuongTrinh)

alter table CHUONGTRINHHOC
add constraint fk_CHUONGTRINHHOC foreign key (MaKhoi) references KHOI(MaKhoi)

alter table DINHDUONG
add constraint fk_DINHDUONG foreign key (MaKeHoach) references KEHOACHGIANGDAY (MaKeHoach)

alter table PHIEUDIEMDANH
add constraint fk_PHIEUDIEMDANH foreign key (MaKeHoach) references KEHOACHGIANGDAY(MaKeHoach)

alter table CHITIETPHIEUDIEMDANH
add constraint fk_CHITIETPHIEUDIEMDANH foreign key (MaPhieuDiemDanh) references PHIEUDIEMDANH (MaPhieuDiemDanh)

alter table CHITIETPHIEUDIEMDANH
add constraint pk primary key (MaPhieuDiemDanh, MaTre)

alter table THOIKHOABIEU
add constraint fk_THOIKHOABIEU foreign key (MaChuongTrinh) references CHUONGTRINHHOC(MaChuongTrinh)

alter table QUYENHAN
add constraint pk_QUYENHAN primary key (MaNhomNguoiDung, MaNhanVien)

alter table QUYENHAN
add constraint fk_QUYENHAN1 foreign key (MaNhomNguoiDung) references NHOMNGUOIDUNG(MaNhomNguoiDung)

alter table QUYENHAN
add constraint fk_QUYENHAN2 foreign key (MaNhanVien) references NHANVIEN(MaNhanVien)

alter table NHOMCHUCNANG
add constraint pk_NHOMCHUCNANG primary key (MaNhomNguoiDung, MaChucNang)

alter table NHOMCHUCNANG
add constraint fk_NHOMCHUCNANG1 foreign key (MaNhomNguoiDung) references NHOMNGUOIDUNG(MaNhomNguoiDung)

alter table NHOMCHUCNANG
add constraint fk_NHOMCHUCNANG2 foreign key (MaChucNang) references CHUCNANG(MaChucNang)

alter table DANGKYHOC
add constraint fk_DANGKYHOC foreign key (MaKeHoach) references KEHOACHGIANGDAY(MaKeHoach)

alter table TREEM
add constraint fk_TREEM foreign key (MaHoSoTreEm) references HOSOTREEM(MaHoSoTreEm)

alter table PHIEUSUCKHOE
add constraint fk_PHIEUSUCKHOE foreign key (MaDangKy) references DANGKYHOC(MaDangKy)

alter table PHIEUHOATDONG
add constraint fk_PHIEUHOATDONG foreign key (MaDangKy) references DANGKYHOC(MaDangKy)

