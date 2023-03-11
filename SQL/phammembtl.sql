create database QLDTSV
use QLDTSV
go

create table SinhVien (
	sMaSV nvarchar(20) not null,
	sTenSV nvarchar(20),
	sGioiTinh nvarchar(20),
	sNgaysinh date,
	sEmail nvarchar(50),
	sChucvu nvarchar(50),
	sMaN nvarchar(20),
	primary key (sMaSV),
	);
alter table SinhVien add constraint FK_SV_N foreign key (sMaN) references Nhom(sMaN);
create table Nhom(
	sMaN nvarchar(20) primary key,
alter table SinhVien add sLopHC nvarchar(50)

);

create table GiangVien(
	sMaGV nvarchar(20) not null primary key,
	sTenGV nvarchar(20),
	sGioiTinh nvarchar(20),
	c
	sEmail nvarchar(20),
	sChucvu nvarchar(20),
	sNgaysinh date,

alter table GiangVien add cmt nvarchar(50)

select * from GiangVien

alter table Detai add constraint FK_gv_dt foreign key (sMaGV) references Detai(sMaGV);

create table Detai (
	sMaDT nvarchar(20) not null primary key,
	sTenDT nvarchar(50) ,
	sMaLV nvarchar (20),
	sNamTH int,
	sMaN nvarchar (20),
	sMaGV nvarchar(20), 

	sDiem float,
	foreign key (sMaGV) references GiangVien(sMaGV),
	
		
)
 alter table Detai add constraint FK_dt_N foreign key (sMaN) references Nhom(sMaN);
 alter table Detai add constraint FK_dt_lv foreign key (sMaLV) references Linhvuc(sMaLV);

 create table dangnhap(
	userr nvarchar(50),
	mk  nvarchar(50)
 )
create table Linhvuc(
	sMaLV nvarchar(20) primary key,
	sTenLV nvarchar(50)
	
)
drop table Linhvuc

select * from  Linhvuc
create proc select_detai
as 
begin
 select sMaDT,sTenDT,Linhvuc.sTenLV,GiangVien.sTenGV,sNamTH,sMaN,sDiem
	from (Detai
	INNER JOIN GiangVien ON GiangVien.sMaGV = Detai.sMaGV)
	inner join Linhvuc   on Detai.sMaLV = Linhvuc.sMaLV
	end

exec select_detai

alter table Detai add sNamTH  nvarchar (30)

create proc themDT
@MaDT nvarchar(50),
@TenDT NVARCHAR(50),
@MaLV NVARCHAR(50),
@MaGV NVARCHAR(50),
@Namth NVARCHAR(50),
@MaN NVARCHAR(10),
@Diem int
AS
	BEGIN		
			INSERT INTO Detai
			VALUES (@MaDT, @TenDT, @MaLV, @MaGV, @Namth, @MaN, @Diem)
			PRINT N'NHẬP THÀNH CÔNG'
		END

drop proc themDT

exec themLichday 

alter proc THEM_GIANGVIEN
@Magv nvarchar(50),
@Tengv NVARCHAR(50),
@gt NVARCHAR(50),
@email NVARCHAR(50),
@chucvu NVARCHAR(10),
@Ngaysinh date,
@Sdt nvarchar(50),
@cmt nvarchar(20
)
AS
	BEGIN		
			INSERT INTO GiangVien
			VALUES (@Magv,@Tengv,@gt,@email,@chucvu,@Ngaysinh,@Sdt,@cmt)
			PRINT N'NHẬP THÀNH CÔNG'
		END

create proc Themgiangvien
@Magv nvarchar(50),
@Tengv NVARCHAR(50),
@gt NVARCHAR(50),
@sdt NVARCHAR(50),
@email NVARCHAR(50),
@chucvu NVARCHAR(10),
@Ngaysinh date

AS
	BEGIN		
			INSERT INTO GiangVien
			VALUES (@Magv,@Tengv,@gt,@sdt,@email,@chucvu,@Ngaysinh)
			PRINT N'NHẬP THÀNH CÔNG'
		END

		select * from GiangVien

CREATE proc UPDATE_DT
@Madt nvarchar(50),
@Tendt NVARCHAR(50),
@Malv NVARCHAR(50),
@Man NVARCHAR(50),
@Magv NVARCHAR(50),
@Diem float,
@NamTH nvarchar(30)
AS
	BEGIN	
UPDATE Detai
	SET sNamTH	    = @NamTH, 
		sTenDT		= @Tendt ,
		sMaLV		= @Malv ,
		sMaN		= @Man ,
		sMaGV		= @Magv ,
		sMaDT		= @Madt ,
		sDiem		= @Diem 
	WHERE
		sMaDT = @Madt
	end

CREATE proc UPDATE_SV
@Masv nvarchar(50),
@Tensv NVARCHAR(50),
@Gt NVARCHAR(50),
@Man NVARCHAR(50),
@Email NVARCHAR(50),
@Lophc NVARCHAR(50),
@sdt nvarchar(30)
AS
	BEGIN	
UPDATE SinhVien
	SET sMaSV	    = @Masv, 
		sTenSV		= @Tensv ,
		sGioiTinh		= @Gt ,
		sEmail		= @Email ,
		sMaN		= @Man ,
		sSDT		= @sdt ,
		sLopHC		= @Lophc 
	WHERE
		sMaSV = @Masv
	end


create proc themLichday
@Madt nvarchar(50),
@Tendt NVARCHAR(50),
@Malv NVARCHAR(50),
@Man NVARCHAR(50),
@Magv NVARCHAR(50),
@Diem float,
@NamTH nvarchar(30)
AS
	BEGIN		
			INSERT INTO Detai
			VALUES (@Madt,@Tendt,@Malv,@Man,@Magv,@Diem,@NamTH)
			PRINT N'NHẬP THÀNH CÔNG'
		END
alter proc pr_detai
as
begin 
	select sMaDT,sTenDT,sMaLV,sMaN,GiangVien.sTenGV,sNamTH,sDiem
	from Detai,GiangVien
	where GiangVien.sMaGV = Detai.sMaGV
	end

select * from SinhVien

create proc pr_nhomchuaTH
as
begin 
		select 

end 
ALTER TABLE Nhom
DROP COLUMN iSoSV
alter table Nhom add iSoSV nvarchar(50);

 update Nhom
 set iSoSV  = (select COUNT(sMaSV) from SinhVien where Nhom.sMaN =  SinhVien.sMaN )
 from SinhVien
 
 alter proc Nhomchuadt
 as
 begin
 select sMaN from Nhom
 where iSoSV = 0 
 except
 select sMaN from Detai
 END
 
 
WHERE sMaN NOT IN (SELECT sMaN FROM Nhom) and sDiem is null
 end

 exec Nhomchuadt;
 select * from Nhom
 select * from Detai

 alter table GiangVien drop column sDiachi

 alter table SinhVien drop column sDiachi

 
 create proc themsv
@Masv nvarchar(50),
@Tensv NVARCHAR(50),
@Gt NVARCHAR(50),
@Email NVARCHAR(50),
@Man NVARCHAR(50),

@sdt nvarchar(30),
@lophc nvarchar(50)
AS
	BEGIN		
			INSERT INTO SinhVien
			VALUES (@Masv,@Tensv,@Gt,@Email,@Man,@sdt,@lophc)
			PRINT N'NHẬP THÀNH CÔNG'
		END

drop proc themsv
select * from SinhVien
 select * from GIANGVIEN
 where DATEDIFF(YEAR,sNgaysinh,GETDATE()) > 20

 select * 
 from Detai
 where sDiem > 50 and sDiem <70
 

alter proc baocaosinhvien
 as
 begin
	select sMaSV,sTenSV,SinhVien.sGioiTinh,SinhVien.sEmail,SinhVien.sSDT,sLopHC,sMaN
	from SinhVien
 end

create proc baocaogiangvien
as
 begin
	select GiangVien.sMaGV,sTenGV,sGioiTinh,sSDT,sEmail,sChucvu,sNgaysinh
	from GiangVien
	end

	
	select * from Detai

alter proc giangvienquanlymax
as
begin 
	select GiangVien.sMaGV,sTenGV,sMaN,sTenDT,sNamTH
	from Detai,GiangVien


	end


	




