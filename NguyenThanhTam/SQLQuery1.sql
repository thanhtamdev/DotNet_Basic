create database QLSach
go

use QLSach
go

create table Category
(
	CategoryID varchar(20) primary key not null,
	CategoryName nvarchar(200) not null
)
go

create table Products
(
	ProductCode varchar(20) primary key not null,
	Description nvarchar(250) not null,
	UnitPrice int not null,
	OnHandQuantity int not null,
	CategoryID varchar(20) not null,
	foreign key (CategoryID) references dbo.Category(CategoryID)
)
go

insert into Category values('PRO', 'Programming')
go

insert into Category values('DAT', 'Database')
go

insert into Category values('WD', 'Web Design')
go

insert into Category values('GRA', 'Graphic')
go

insert into Category values('CHIL', 'Children')
go

insert into Products values('B01', 'C# Programming', '125000', '123', 'PRO')
go