create database shopping_website

create table Products (prodid numeric(18,0) primary key identity , prodname varchar(50) , proddescription varchar (50) , catid numeric (18,0), prodprice numeric (18,0),qty numeric(18,0), prodimage varchar (50))

insert into Products values('Kurti','Kurti with Beautiful LATKANS','321',2,'p1.jpg',10)
insert into Products values('Long Kurti','kurta Kurtis',364,2,'p2.jpg',10)
insert into Products values('Paijami','Kids Cotton Paijami',500,4,'p3.jpg',20)
insert into Products values('Grey Tshirts','Poly Blend Grey Tshirts',150,3,'p4.jpg',15)
insert into Products values('Hawaii Slipper','Phonolite ladies casual wear',250,2,'p5.jpg',5)
insert into Products values('Mixer','ZunVolt 500W Mixer Grinder',2550,6,'p6.jpg',10)
insert into Products values('Top With shorts','boys fancy  Top ',400,4,'p7.jpg',10)
insert into Products values('Printed Tshirts','CASUAL PRINTED TSHIRT',540,5,'p8.jpg',20)

select * from Products
drop table Products

create table Products(ProductId int primary key identity,ProductName varchar(500),ProductDesc varchar(500),ProductPrice int ,CategoryId int,
ImageName varchar(500),Quantity int)
insert into Products values('Kurti','Kurti with Beautiful LATKANS','321',2,'p1.jpg',10)
insert into Products values('Long Kurti','kurta Kurtis',364,2,'p2.jpg',10)
insert into Products values('Paijami','Kids Cotton Paijami',500,4,'p3.jpg',20)
insert into Products values('Grey Tshirts','Poly Blend Grey Tshirts',150,3,'p4.jpg',15)
insert into Products values('Hawaii Slipper','Phonolite ladies casual wear',250,2,'p5.jpg',5)
insert into Products values('Mixer','ZunVolt 500W Mixer Grinder',2550,6,'p6.jpg',10)
insert into Products values('Top With shorts','boys fancy  Top ',400,4,'p7.jpg',10)
insert into Products values('Printed Tshirts','CASUAL PRINTED TSHIRT',540,5,'p8.jpg',20)
select * from Products