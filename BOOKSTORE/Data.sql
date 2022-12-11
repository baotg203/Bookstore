use BOOKSTORE
go
insert into DAUSACH
values(N'Nobita du hành biển phương Nam',1)
insert into DAUSACH
values(N'Nobita và cuộc phiêu lưu ở thành phố dây cốt',1)
insert into DAUSACH
values(N'Chú khủng long của Nobita',1)
insert into DAUSACH
values(N'Dragon ball vol 1',1)
insert into DAUSACH
values(N'Dragon ball vol 2',1)
insert into DAUSACH
values(N'Dragon ball vol 3',1)
insert into DAUSACH
values(N'5 centimet trên giây',2)
insert into DAUSACH
values(N'Sông',2)
insert into DAUSACH
values(N'Ông già và biển cả',2)
insert into DAUSACH
values(N'Đời thừa',2)
insert into DAUSACH
values(N'Your name',2)
insert into DAUSACH
values(N'Lập trình và cuộc sống',3)
insert into DAUSACH
values(N'Lập trình C++ nâng cao',3)
insert into DAUSACH
values(N'Cấu trúc đữ liệu và giải thuật',3)
insert into DAUSACH
values(N'Nhập môn cơ sở dữ liệu',3)
insert into DAUSACH
values(N'Nhập môn mạng máy tính',3)
insert into DAUSACH
values(N'Kinh tế học',4)
insert into DAUSACH
values(N'Bong bóng kinh tế',4)
insert into DAUSACH
values(N'Doanh nghiệp của thế kỉ 21',4)
insert into DAUSACH
values(N'Cách nền kinh tế vận hành',4)

go
insert into CT_TACGIA
values(1,N'Fujiko Fujio')
insert into CT_TACGIA
values(2,N'Fujiko Fujio')
insert into CT_TACGIA
values(3,N'Fujiko Fujio')
insert into CT_TACGIA
values(4,N'Toriyama Akira')
insert into CT_TACGIA
values(5,N'Toriyama Akira')
insert into CT_TACGIA
values(6,N'Toriyama Akira')
insert into CT_TACGIA
values(7,N'Shinkai Makoto')
insert into CT_TACGIA
values(8,N'Nguyễn Ngọc Tư')
insert into CT_TACGIA
values(9,N'Ernest Hemingway')
insert into CT_TACGIA
values(10,N'Nam Cao')
insert into CT_TACGIA
values(11,N'Shinkai Makoto')
insert into CT_TACGIA
values(12,N'Jeff Atwood')
insert into CT_TACGIA
values(13,N'Nguyễn Văn Thư')
insert into CT_TACGIA
values(14,N'Nguyễn Đõ Thái Nguyên')
insert into CT_TACGIA
values(15,N'Andy Oppel')
insert into CT_TACGIA
values(16,N'Jonh Ross')
insert into CT_TACGIA
values(17,N'DK')
insert into CT_TACGIA
values(18,N'Michael Lewis')
insert into CT_TACGIA
values(19,N'Robert T.Kiyosaki')
insert into CT_TACGIA
values(20,N'Roger E. A. Farmer')

go
insert into SACH
values(1, N'NXB Kim Đồng', 2020, 890, 20000, 1)
insert into SACH
values(2, N'NXB Kim Đồng', 2020, 1100, 20000, 1)
insert into SACH
values(3, N'NXB Kim Đồng', 2020, 800, 20000, 1)
insert into SACH
values(4, N'NXB Kim Đồng', 2018, 1000, 18000, 1)
insert into SACH
values(5, N'NXB Kim Đồng', 2018, 800, 18000, 1)
insert into SACH
values(6, N'NXB Kim Đồng', 2018, 800, 18000, 1)
insert into SACH
values(7, N'NXB Hà Nội', 2021, 200, 60000, 1)
insert into SACH
values(8, N'NXB Trẻ', 2019, 300, 50000, 0)
insert into SACH
values(9, N'NXB Lao Động', 2018, 100, 55000, 1)
insert into SACH
values(10, N'NXB Phụ Nữ Việt Nam', 2022, 100, 53000, 0)
insert into SACH
values(11, N'NXB Kim Đồng', 2020, 200, 53000, 1)
insert into SACH
values(12, N'NXB Chính trị quốc gia Sự thật', 2018, 100, 200000, 1)
insert into SACH
values(13, N'NXB Đông A', 2018, 100, 105000, 1)
insert into SACH
values(14, N'NXB Tổng hợp thành phố Hồ Chí Minh', 2022, 50, 55000, 0)
insert into SACH
values(15, N'NXB Đông A', 2022, 100, 65000, 1)
insert into SACH
values(16, N'NXB Nhã Nam', 2022, 100, 65000, 1)
insert into SACH
values(17, N'NXB Trẻ', 2022, 100, 300000, 1)
insert into SACH
values(18, N'NXB Đông A', 2022, 100, 80000, 0)
insert into SACH
values(19, N'NXB Đông A', 2022, 100, 77000, 1)
insert into SACH
values(20, N'NXB Đông A', 2022, 100, 90000, 0)

go
insert into PHIEUNHAPSACH
values('2022/12/09', 8000000)
insert into PHIEUNHAPSACH
values('2022/12/10', 10000000)
insert into PHIEUNHAPSACH
values('2022/12/11', 21500000)
insert into PHIEUNHAPSACH
values('2022/12/12', 20000000)

go
insert into CT_PHIEUNHAPSACH
values(1, 1, 400, 20000, 8000000)
insert into CT_PHIEUNHAPSACH
values(2, 2, 300, 20000, 6000000)
insert into CT_PHIEUNHAPSACH
values(2, 3, 200, 20000, 4000000)
insert into CT_PHIEUNHAPSACH
values(3, 17, 60, 300000, 18000000)
insert into CT_PHIEUNHAPSACH
values(3, 8, 70, 50000, 3500000)
insert into CT_PHIEUNHAPSACH
values(4, 12, 100, 200000, 20000000)

go
insert into KHACHHANG
values(N'Nguyễn Văn A', N'100 Thoại Ngọc Hầu', '01111111111', 'anv@gmail.com', 200000)
insert into KHACHHANG
values(N'Nguyễn Thị B', N'219 Lý Thái Tổ', '0933333333', 'bnt@gmail.com', 1000000)
insert into KHACHHANG
values(N'Lý Thị C', N'123 Nguyễn Trường Tộ', '0911223344', 'clt@gmail.com', 0)

go
insert into HOADON
values(1, '2022/12/09', 100000, 80000, 20000)
insert into HOADON
values(2, '2022/12/09', 200000, 200000, 0)
insert into HOADON
values(1, '2022/11/01', 300000, 200000, 100000)
insert into HOADON
values(3, '2022/12/04', 90000, 90000, 0)
insert into HOADON
values(2, '2022/11/04', 20000, 20000, 0)
insert into HOADON
values(1, '2021/12/12', 80000, 60000, 20000)
insert into HOADON
values(3, '2021/11/11', 90000, 90000, 0)

go
insert into CT_HOADON
values(1, 1, 3, 20000, 60000)
insert into CT_HOADON
values(1, 2, 2, 20000, 40000)
insert into CT_HOADON
values(2, 12, 1, 200000, 200000)
insert into CT_HOADON
values(3, 7, 1, 60000, 60000)
insert into CT_HOADON
values(3, 8, 1, 50000, 50000)
insert into CT_HOADON
values(3, 20, 1, 90000, 90000)
insert into CT_HOADON
values(4, 8, 1, 50000, 50000)
insert into CT_HOADON
values(4, 2, 1, 20000, 20000)
insert into CT_HOADON
values(4, 3, 1, 20000, 20000)
insert into CT_HOADON
values(5, 1, 1, 20000, 20000)
insert into CT_HOADON
values(6, 18, 1, 80000, 80000)
insert into CT_HOADON
values(7, 20, 1, 90000, 90000)

go
insert into PHIEUTHUTIEN
values(1, '2022/12/09', 80000)
insert into PHIEUTHUTIEN
values(2, '2022/12/09', 200000)
insert into PHIEUTHUTIEN
values(1, '2022/11/01', 100000)
insert into PHIEUTHUTIEN
values(3, '2022/12/04', 90000)
insert into PHIEUTHUTIEN
values(2, '2022/11/04', 20000)
insert into PHIEUTHUTIEN
values(1, '2022/11/04', 100000)
insert into PHIEUTHUTIEN
values(2, '2021/12/12', 50000)
insert into PHIEUTHUTIEN
values(1, '2021/12/12', 60000)
insert into PHIEUTHUTIEN
values(3, '2021/11/11', 90000)

go
insert into BAOCAOTON
values(10, 2022, 1, 100, 50, 150)
insert into BAOCAOTON
values(10, 2022, 2, 90, 40, 130)
insert into BAOCAOTON
values(10, 2022, 12, 100, 90, 190)
insert into BAOCAOTON
values(11, 2022, 3, 100, 100, 200)
insert into BAOCAOTON
values(11, 2022, 4, 0, 10, 10)
insert into BAOCAOTON
values(11, 2022, 20, 10, 2, 12)
insert into BAOCAOTON
values(11, 2022, 10, 90, 10, 100)

go
insert into BAOCAOCONGNO
values(10, 2022, 1, 100000, 20000, 120000)
insert into BAOCAOCONGNO
values(10, 2022, 2, 90000, 10000, 100000)
insert into BAOCAOCONGNO
values(11, 2022, 1, 120000, 80000, 200000)
insert into BAOCAOCONGNO
values(11, 2022, 2, 100000, 900000, 1000000)

go
insert into THAMSO
values(0, 100, 100, 1000, 5000000, 10000)

go
insert into NGUOIDUNG
values('Staff1', 123, 2)
insert into NGUOIDUNG
values('Seller1', 123, 3)
