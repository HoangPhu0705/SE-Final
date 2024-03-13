use master 
if exists (select * from sysdatabases where name = 'TTTH')
	drop database TTTH

create database TTTH
use TTTH


CREATE TABLE Tai_Khoan
(
	TaiKhoan varchar(20),
	pass varchar(30),
	loai int --1: Giang vien; 2: Hoc vien
	primary key(TaiKhoan)
)


CREATE TABLE Hoc_vien
(
	Ma_HV varchar(20),
	Ten_HV NVARCHAR(50) NOT NULL,
	Nam_sinh DATE NOT NULL,
	Dia_chi NVARCHAR(50) NOT NULL,
	sdt VARCHAR(10) NOT NULL,
	CONSTRAINT pk_maHV PRIMARY KEY (Ma_HV),
);
CREATE TABLE Phong_hoc
(
  Ma_PH INT NOT NULL IDENTITY (1,1),
  Ten_PH NVARCHAR(20) NOT NULL,
  CONSTRAINT pk_maPH PRIMARY KEY (Ma_PH)
);



CREATE TABLE Ca_hoc
(
	  Ma_ca INT NOT NULL IDENTITY (1,1),
	  Buoi nvarchar(50) NOT NULL,
	  GioHoc nvarchar(50) NOT NULL,	
	  CONSTRAINT pk_MaCa PRIMARY KEY (Ma_ca)
);
CREATE TABLE Giang_vien
(
	Ma_GV varchar(20) NOT NULL,
	Ten_GV NVARCHAR(50) NOT NULL,
	Nam_sinh DATE NOT NULL,
	sdt VARCHAR(10) NOT NULL,
	Que_quan NVARCHAR(25) NOT NULL,
	CONSTRAINT pk_MaGV PRIMARY KEY (Ma_GV),
);

CREATE TABLE Khoa_hoc
(
	Ma_KH INT  NOT NULL IDENTITY (1,1),
	Ten_KH NVARCHAR(50) NOT NULL,
	Hoc_phi INT NOT NULL,
	CONSTRAINT pk_Ma_KH PRIMARY KEY (Ma_KH)
)

CREATE TABLE Lop_hoc
(
	Ma_LH INT NOT NULL IDENTITY (1,1),
	Ten_LH NVARCHAR(50) NOT NULL,
	Ma_KH INT NOT NULL,
	Ma_PH INT NOT NULL,
	Ma_ca INT NOT NULL,
	Ma_GV varchar(20)	NOT NULL,
	Ngay_bat_dau DATE NOT NULL,
	Ngay_ket_thuc DATE NOT NULL,
	Dang_mo BIT,
	So_buoi INT NOT NULL,
	Soluong INT NOT NULL,

	CONSTRAINT pk_MaLH PRIMARY KEY (Ma_LH),
	FOREIGN KEY (Ma_PH) REFERENCES Phong_hoc(Ma_PH),
	FOREIGN KEY (Ma_ca) REFERENCES Ca_hoc(Ma_ca),
	FOREIGN KEY (Ma_GV) REFERENCES Giang_vien(Ma_GV),
	FOREIGN KEY (Ma_KH) REFERENCES Khoa_hoc(Ma_KH)
);

CREATE TABLE Hoa_don
(
	Ma_hd INT NOT NULL IDENTITY (1,1),
	Nguoi_dong_tien NVARCHAR(50),
	Ngay_lap DATE DEFAULT getdate(),
	Tong_tien INT NOT NULL,
	CONSTRAINT pk_MaHD PRIMARY KEY (Ma_hd)
);

CREATE TABLE Chi_tietHD
(
	Ma_hd INT NOT NULL,
	Ma_KH INT  NOT NULL,
	CONSTRAINT pk_CTHD PRIMARY KEY (Ma_hd, Ma_KH),
	FOREIGN KEY (Ma_hd) REFERENCES Hoa_don(Ma_hd),
	FOREIGN KEY (Ma_KH) REFERENCES Khoa_hoc(Ma_KH),
)


CREATE TABLE chi_tiet
(
	Ngay_Dang_Ky DATE NOT NULL,
	Ma_HV varchar(20) NOT NULL,
	Ma_LH INT NOT NULL,
	PRIMARY KEY (Ma_HV, Ma_LH),
	FOREIGN KEY (Ma_HV) REFERENCES Hoc_vien(Ma_HV),
	FOREIGN KEY (Ma_LH) REFERENCES Lop_hoc(Ma_LH)
);
go


--Trigger tu add vao taikhoan sau khi insert Hoc vien

CREATE TRIGGER tr_GiangVien_Update
ON Giang_vien
AFTER UPDATE
AS
BEGIN
    IF UPDATE(sdt)
    BEGIN
        UPDATE Tai_Khoan
        SET pass = i.sdt
        FROM inserted i
        WHERE Tai_Khoan.loai = 1 AND Tai_Khoan.TaiKhoan = i.Ma_GV
    END
END

go
CREATE TRIGGER tr_HocVien_Update
ON Hoc_vien
AFTER UPDATE
AS
BEGIN
    IF UPDATE(sdt)
    BEGIN
        UPDATE Tai_Khoan
        SET pass = i.sdt
        FROM inserted i
        WHERE Tai_Khoan.loai = 2 AND Tai_Khoan.TaiKhoan = i.Ma_HV
    END
END
go

CREATE TRIGGER trg_Hocvien_Delete
ON Hoc_vien
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM chi_tiet
    WHERE Ma_HV IN (SELECT Ma_HV FROM DELETED);

    DELETE FROM Hoc_vien
    WHERE Ma_HV IN (SELECT Ma_HV FROM DELETED);
END



go 
CREATE TRIGGER trg_InsertTaiKhoanForNewStudent
ON Hoc_vien
AFTER INSERT
AS
BEGIN
    INSERT INTO Tai_Khoan (TaiKhoan, pass, loai)
    SELECT inserted.Ma_HV, inserted.sdt, 2
    FROM inserted
    LEFT JOIN Tai_Khoan ON inserted.Ma_HV = Tai_Khoan.TaiKhoan
    WHERE Tai_Khoan.TaiKhoan IS NULL;	
END;
go

go 
CREATE TRIGGER trg_InsertTaiKhoanForNewTeacher
ON Giang_vien
AFTER INSERT
AS
BEGIN
    INSERT INTO Tai_Khoan (TaiKhoan, pass, loai)
    SELECT inserted.Ma_GV, inserted.sdt, 1
    FROM inserted
    LEFT JOIN Tai_Khoan ON inserted.Ma_GV = Tai_Khoan.TaiKhoan
    WHERE Tai_Khoan.TaiKhoan IS NULL;
END;

go
CREATE TRIGGER tr_chi_tiet_insert
ON chi_tiet
AFTER INSERT
AS
BEGIN
  UPDATE Lop_hoc
  SET Soluong = Soluong + 1
  FROM Lop_hoc lh
  INNER JOIN inserted i ON lh.Ma_LH = i.Ma_LH;
END


go
--EXEC dbo.GiangVien_CRUD 'INSERT', NULL, 'Phu', '2003-07-05', '123', 'HCM'

CREATE TRIGGER trg_DeleteTaiKhoan
ON Giang_vien
AFTER DELETE
AS
BEGIN
    DELETE FROM Tai_Khoan
    WHERE TaiKhoan IN (SELECT Ma_GV FROM deleted)
END


go
CREATE TRIGGER trg_DeleteTaiKhoan_HV
ON Hoc_vien
AFTER DELETE
AS
BEGIN
    DELETE FROM Tai_Khoan
    WHERE TaiKhoan IN (SELECT Ma_HV FROM deleted)
END

go
CREATE TRIGGER tr_delete_Giang_vien
ON Giang_vien
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Lop_Hoc
    WHERE Ma_GV IN (SELECT Ma_GV FROM DELETED);

    DELETE FROM Giang_vien
    WHERE Ma_GV IN (SELECT Ma_GV FROM DELETED);
END

go

CREATE TRIGGER tr_Change_Soluong 
ON chi_tiet 
AFTER DELETE
AS
BEGIN
    UPDATE Lop_hoc
    SET Soluong = Soluong - 1
    FROM Lop_hoc l
    JOIN deleted d ON l.Ma_LH = d.Ma_LH;
END
go
CREATE TRIGGER tr_delete_KhoaHoc
ON Khoa_hoc
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Lop_Hoc
    WHERE Ma_KH IN (SELECT Ma_KH FROM DELETED);

    DELETE FROM Khoa_hoc
    WHERE Ma_KH IN (SELECT Ma_KH FROM DELETED);
END


----PROCEDURE
go
create function dbo.auto_mHV()
returns varchar(5)
as
begin
	declare @ID varchar(5)
	if (select count(Ma_HV) from Hoc_vien) = 0
		set @ID = '000'
	else
		select @ID = max(right(Ma_HV, 3)) from Hoc_vien
		select @ID = case
			when @ID >= 0 and @ID < 9 then 'HV00' + convert(char, convert(int, @ID) + 1)
			when @ID >= 9 and @ID < 99 then 'HV0' + convert(char, convert(int, @ID) + 1)
			when @ID >= 99 then 'HV' + convert(char, convert(int, @ID) + 1)
		END
	return @ID
END
go


go
create function dbo.auto_mGV()
returns varchar(5)
as
begin
	declare @ID varchar(5)
	if (select count(Ma_GV) from Giang_vien) = 0
		set @ID = '000'
	else
		select @ID = max(right(Ma_GV, 3)) from Giang_vien
		select @ID = case
			when @ID >= 0 and @ID < 9 then 'GV00' + convert(char, convert(int, @ID) + 1)
			when @ID >= 9 and @ID < 99 then 'GV0' + convert(char, convert(int, @ID) + 1)
			when @ID >= 99 then 'HV' + convert(char, convert(int, @ID) + 1)
		END
	return @ID
END
go





go
CREATE PROCEDURE dbo.HocVien_CRUD
	@StatementType VARCHAR(10),
	@Ma_HV VARCHAR(20) = NULL,
	@Ten_HV NVARCHAR(50) = NULL,
	@Nam_sinh DATE = NULL,
	@Dia_chi NVARCHAR(50) = NULL,
	@sdt VARCHAR(10) = NULL
	AS
	BEGIN
		SET NOCOUNT ON;
		IF (@StatementType = 'SELECT')
		BEGIN
			SELECT *
			FROM dbo.Hoc_vien
			WHERE Ma_HV = @Ma_HV
		END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Hoc_vien (Ma_HV, Ten_HV, Nam_sinh, Dia_chi, sdt)
		VALUES (dbo.auto_mHV(), @Ten_HV, @Nam_sinh, @Dia_chi, @sdt)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
	UPDATE dbo.Hoc_vien
		SET Ten_HV = @Ten_HV,
		Nam_sinh = @Nam_sinh,
		Dia_chi = @Dia_chi,
		sdt = @sdt
		WHERE Ma_HV = @Ma_HV
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Hoc_vien
		WHERE Ma_HV = @Ma_HV
	END
END


--CRUD Phonghoc
go
CREATE PROCEDURE dbo.PhongHoc_CRUD
	@StatementType VARCHAR(10),
	@Ma_PH INT = NULL,
	@Ten_PH NVARCHAR(20) = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Phong_hoc
		WHERE Ma_PH = @Ma_PH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Phong_hoc (Ten_PH)
		VALUES (@Ten_PH)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Phong_hoc
		SET Ten_PH = @Ten_PH
		WHERE Ma_PH = @Ma_PH
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Phong_hoc
		WHERE Ma_PH = @Ma_PH
	END
END

go
CREATE PROCEDURE dbo.CaHoc_CRUD
	@StatementType VARCHAR(10),
	@Ma_ca INT = NULL,
	@Buoi VARCHAR = NULL,
	@GioHoc VARCHAR = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Ca_hoc
		WHERE Ma_ca = @Ma_ca
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Ca_hoc (Buoi, GioHoc)
		VALUES (@Buoi, @GioHoc)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Ca_hoc
		SET Buoi = @Buoi,
		GioHoc = @GioHoc
		WHERE Ma_ca = @Ma_ca
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Ca_hoc
		WHERE Ma_ca = @Ma_ca
	END
END

go
CREATE PROCEDURE dbo.GiangVien_CRUD
	@StatementType VARCHAR(10),
	@Ma_GV VARCHAR(20) = NULL,
	@Ten_GV NVARCHAR(50) = NULL,
	@Nam_sinh DATE = NULL,
	@sdt VARCHAR(10) = NULL,
	@Que_quan NVARCHAR(25) = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Giang_vien
		WHERE Ma_GV = @Ma_GV
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Giang_vien (Ma_GV, Ten_GV, Nam_sinh, sdt, Que_quan)
		VALUES (dbo.auto_mGV(), @Ten_GV, @Nam_sinh, @sdt, @Que_quan)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Giang_vien
		SET Ten_GV = @Ten_GV,
		Nam_sinh = @Nam_sinh,
		sdt = @sdt,
		Que_quan = @Que_quan
		WHERE Ma_GV = @Ma_GV
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Giang_vien
		WHERE Ma_GV = @Ma_GV
	END
END


go
CREATE PROCEDURE dbo.LopHoc_CRUD
	@StatementType VARCHAR(10),
	@Ma_LH INT = NULL,
	@Ten_LH NVARCHAR(50) = NULL,
	@Ma_KH INT = NULL,
	@Ma_PH INT = NULL,
	@Ma_ca INT = NULL,
	@Ma_GV VARCHAR(20) = NULL,
	@Ngay_bat_dau DATE = NULL,
	@Ngay_ket_thuc DATE = NULL,
	@Dang_mo BIT = NULL,
	@So_buoi INT = NULL,
	@Soluong INT = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Lop_hoc
		WHERE Ma_LH = @Ma_LH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Lop_hoc (Ten_LH, Ma_KH, Ma_PH, Ma_ca, Ma_GV, Ngay_bat_dau, Ngay_ket_thuc, Dang_mo, So_buoi, Soluong)
		VALUES (@Ten_LH,@Ma_KH, @Ma_PH, @Ma_ca, @Ma_GV, @Ngay_bat_dau, @Ngay_ket_thuc, @Dang_mo,@So_buoi, @Soluong)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Lop_hoc
		SET Ten_LH = @Ten_LH,
		Ma_KH = @Ma_KH,
		Ma_PH = @Ma_PH,
		Ma_ca = @Ma_ca,
		Ma_GV = @Ma_GV,
		Ngay_bat_dau = @Ngay_bat_dau,
		Ngay_ket_thuc = @Ngay_ket_thuc,
		Dang_mo = @Dang_mo,
		So_buoi = @So_buoi,
		Soluong = @Soluong
		WHERE Ma_KH = @Ma_KH
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Lop_hoc
		WHERE Ma_LH = @Ma_LH
	END
END


go
CREATE PROCEDURE dbo.HoaDon_CRUD
	@StatementType VARCHAR(10),
	@Ma_hd INT = NULL,
	@Nguoi_dong_tien NVARCHAR(50) = NULL,
	@Ngay_lap DATE = NULL,
	@Tong_tien INT = NULL
AS
BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Hoa_don
		WHERE Ma_hd = @Ma_hd
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Hoa_don (Nguoi_dong_tien, Ngay_lap, Tong_tien)
		VALUES (@Nguoi_dong_tien, COALESCE(@Ngay_lap, GETDATE()), @Tong_tien)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.Hoa_don
		SET Nguoi_dong_tien = @Nguoi_dong_tien,
			Ngay_lap = COALESCE(@Ngay_lap, Ngay_lap),
			Tong_tien = @Tong_tien
		WHERE Ma_hd = @Ma_hd
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Hoa_don
		WHERE Ma_hd = @Ma_hd
	END
END

go
CREATE PROCEDURE dbo.Chitiet_hd_CRUD
	@StatementType VARCHAR(10),
	@Ma_hd INT,
	@Ma_KH INT
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.Chi_tietHD
		WHERE Ma_hd = @Ma_hd AND Ma_KH = @Ma_KH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.Chi_tietHD (Ma_hd, Ma_KH)
		VALUES (@Ma_hd, @Ma_KH)
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.Chi_tietHD
		WHERE Ma_hd = @Ma_hd AND Ma_KH = @Ma_KH
	END
END


go
CREATE PROCEDURE dbo.ChiTiet_CRUD
	@StatementType VARCHAR(10),
	@Ngay_Dang_Ky DATE = NULL,
	@Ma_HV varchar(20) = NULL,
	@Ma_LH INT = NULL
	AS
	BEGIN
	SET NOCOUNT ON;
	IF (@StatementType = 'SELECT')
	BEGIN
		SELECT *
		FROM dbo.chi_tiet
		WHERE Ma_HV = @Ma_HV AND Ma_LH = @Ma_LH
	END
	ELSE IF (@StatementType = 'INSERT')
	BEGIN
		INSERT INTO dbo.chi_tiet (Ngay_Dang_Ky, Ma_HV, Ma_LH)
		VALUES (@Ngay_Dang_Ky, @Ma_HV, @Ma_LH)
	END
	ELSE IF (@StatementType = 'UPDATE')
	BEGIN
		UPDATE dbo.chi_tiet
		SET Ngay_Dang_Ky = @Ngay_Dang_Ky
		WHERE Ma_HV = @Ma_HV AND Ma_LH = @Ma_LH
	END
	ELSE IF (@StatementType = 'DELETE')
	BEGIN
		DELETE FROM dbo.chi_tiet
		WHERE Ma_HV = @Ma_HV AND Ma_LH = @Ma_LH
	END
END
go

--exec dbo.HocVien_CRUD 'INSERT', NULL, 'Phu', '2003/5/7', 'HCM', '1234567'

