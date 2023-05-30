create database electronic_products_invoice
--- Table 1 ----
create table Product (BrandID int primary key identity , BrandName varchar (500))
insert into Product values ('Acer')
insert into Product values ('HP')
insert into Product values ('Lenovo')
insert into Product values ('Asus')
insert into Product values ('Dell')
insert into Product values ('Infinix')

select * from Product
---- Table 2 ------
create table ProductDetails (BrandID int primary key identity , ProductName varchar (100) , AvailableQty int , TotalQty int , Price decimal,
constraint pd1 foreign key (BrandID) references Product (BrandID))

insert into ProductDetails values ()
select * from ProductDetails

-----------

----------------------------------------TABLE COMPUTER--------------------------------
CREATE TABLE Computer(ProductID INT PRIMARY KEY IDENTITY, NAME VARCHAR(100),AVAILABLE_QTY INT,SELL_QTY INT,
PRICE_PER_UNIT DECIMAL,CGST int,SGST int)

INSERT INTO Computer VALUES('HP',52,2,45000,8,9)
INSERT INTO Computer VALUES('LENOVO',42,1,50000,6,6)
INSERT INTO Computer VALUES('DELL',62,2,48000,9,9)
INSERT INTO Computer VALUES('ASUS',32,2,55000,7,7)
INSERT INTO Computer VALUES('ACER',20,2,65000,5,5)
select * from Computer

----------------------------------------CUSTOMER----------------------------------
CREATE TABLE Customer(ProductID INT PRIMARY KEY IDENTITY,FIRST_NAME VARCHAR(30),LAST_NAME VARCHAR(30),GENDER VARCHAR(10),
MOBILE_NO VARCHAR(20),PAID_AMOUNT DECIMAL) 


SELECT * FROM CUSTOMER


