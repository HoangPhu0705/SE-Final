use TTTH
go
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Lập trình C# căn bản', 5000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Lập trình Java căn bản', 5000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Cấu trúc dữ liệu và giải thuật', 4000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Hệ cơ sở dữ liệu', 4000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Machine Learning', 8000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Lập trình Flutter', 5000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Deep Learning', 5000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'MOS 1', 2000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'MOS 2', 2000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Lập trình Mạng', 3000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Thiết kế website', 3000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Lập trình ứng dụng di động', 3000000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Nhập môn lập trình', 3500000);
INSERT INTO Khoa_hoc (Ten_KH, Hoc_phi) VALUES (N'Trí tuệ nhân tạo', 3000000);
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'2,4,6', '7:00 - 9:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'2,4,6', '9:00 - 11:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'2,4,6', '14:00 - 16:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'2,4,6', '16:00 - 18:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'2,4,6', '18:00 - 20:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'3,5,7', '7:00 - 9:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'3,5,7', '9:00 - 11:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'3,5,7', '14:00 - 16:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'3,5,7', '16:00 - 18:00');
INSERT INTO Ca_hoc (Buoi, GioHoc) VALUES (N'3,5,7', '18:00 - 20:00');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 1');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 2');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 3');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 4');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 5');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 6');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 7');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 8');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 9');
INSERT INTO Phong_hoc (Ten_PH) VALUES (N'Phòng 10');
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Phạm Hoàng Quốc Vũ', '1992/08/03', '0987654321', N'Đồng Nai';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Thị Hương', '1985/02/15', '0912345678', N'Hà Nội';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Trần Văn Long', '1978/05/23', '0965432198', N'Thái Bình';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Văn Nam', '1990/01/10', '0934567890', N'Hải Phòng';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Lê Thị Mai', '1983/08/31', '0976543210', N'Bình Định';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Phạm Đức Anh', '1975/11/27', '0987654321', N'Bắc Giang';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Đỗ Thị Thu', '1982/03/12', '0912345678', N'Phú Thọ';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Văn Tùng', '1988/06/08', '0965432198', N'Hà Nam';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Trần Thị Mai', '1979/02/18', '0934567890', N'Thái Nguyên';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Lê Văn Tâm', '1986/09/20', '0976543210', N'Thừa Thiên Huế';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Phạm Thị Hồng', '1991/12/05', '0987654321', N'Đà Nẵng';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Đỗ Văn Đức', '1977/07/24', '0912345678', N'Hưng Yên';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Thị Trang', '1984/04/17', '0965432198', N'Bắc Ninh';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Trần Văn Đức', '1993/01/01', '0934567890', N'Thanh Hóa';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Lê Thị Thu', '1981/08/14', '0976543210', N'Hải Dương';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Phạm Văn Tú', '1974/11/10', '0987654321', N'Quảng Ninh';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Đỗ Thị Hồng', '1988/03/06', '0912345678', N'Thừa Thiên Huế';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Văn Hùng', '1980/06/02', '0965432198', N'Nghệ An';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Trần Thị Hạnh', '1973/02/12', '0934567890', N'Đắk Lắk';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Lê Văn Đức', '1985/09/24', '0976543210', N'Bình Thuận';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Phạm Thị Tuyết', '1990/12/09', '0987654321', N'Bình Phước';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Thị Hương', '1985/04/01', '0943216789', N'Hà Tĩnh';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Võ Thị Thanh Tâm', '1988/08/15', '0965432198', N'Đà Nẵng';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Thị Hoài Thu', '1992/03/25', '0912345678', N'Hồ Chí Minh';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Bùi Thị Ngọc Ánh', '1987/10/05', '0987654320', N'Bình Dương';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Lê Thị Lan Anh', '1991/05/10', '0918765432', N'Hà Nội';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Thị Thanh Tú', '1989/09/20', '0934567890', N'Thừa Thiên Huế';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Phan Thị Hồng Thắm', '1993/02/28', '0976543210', N'Hải Phòng';
EXEC dbo.GiangVien_CRUD 'INSERT', NULL, N'Nguyễn Thị Thanh Hương', '1990/07/03', '0965432109', N'Đắk Lắk';
INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'LTC#CB', 1, 1, 1, 'GV001', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'LTJavaCB', 2, 1, 2, 'GV002', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'CTDLGT', 3, 1, 3, 'GV003', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'HCSDL', 4, 1, 4, 'GV004', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'ML1', 5, 1, 5, 'GV005', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'Flutter', 6, 1, 6, 'GV006', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'DL1', 7, 1, 7, 'GV007', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'MOS 1', 8, 1, 8, 'GV008', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'MOS 2', 9, 1, 9, 'GV009', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'LTM1', 10, 1, 10, 'GV010', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'Website1', 11, 2, 1, 'GV011', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'UDDD1', 12, 2, 2, 'GV012', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'LTCB1', 13, 2, 3, 'GV013', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'TTTT1', 14, 2, 4, 'GV014', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'LTC#CB2', 1, 2, 5, 'GV015', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'LTJavaCB2', 2, 2, 6, 'GV016', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'CTDLGT2', 3, 2, 7, 'GV017', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'HCSDL2', 4, 2, 8, 'GV018', '2023/05/01', '2023/06/30', 1, 24, 0);

INSERT INTO Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
VALUES (N'ML2', 5, 2, 9, 'GV019', '2023/05/01', '2023/06/30', 1, 24, 0);

insert into Tai_Khoan values('admin', '123', 0)
