CREATE DATABASE multiShop
--DROP DATABASE multiShop
go
USE multiShop
go
CREATE TABLE Shop 
(
	id int primary key identity,
	name nvarchar(100),
	href nvarchar(100)
)
CREATE TABLE Category
(
	id int primary key identity,
	shop int references shop(id),
	name nvarchar(100), 
	navlink nvarchar(100) 
)	

CREATE TABLE Product
(
	id int primary key identity,
	name nvarchar(300),
	descrip nvarchar(max),
	fulldescrip nvarchar(max),
	buylink nvarchar(300),
	category int references category(id)
)

insert into  Shop values ('Macbook Viet','http://localhost:50295/')

insert into category values (1,N'Sạc','Sac')
insert into category values (1,N'Phụ kiện','Phukien')
insert into category values (1,N'Bàn phím','Banphim')
insert into category values (1,N'Các thứ','Cacthu')

