create database drivenitDB

create table ItemMaster (ItemID int primary key identity (1,1) not null , ItemDescr varchar(100) null , BalQty int null ,CreatedOn datetime)

create table Transactions (TransID int primary key identity not null ,
ItemID int constraint c1 foreign key (ItemID) references ItemMaster(ItemID),
TransType char (1) not null , 
TransQty int , 
TransDate datetime)

insert into Transactions values (3,'I',12,'20/08/2022')

select * from ItemMaster
select * from Transactions
