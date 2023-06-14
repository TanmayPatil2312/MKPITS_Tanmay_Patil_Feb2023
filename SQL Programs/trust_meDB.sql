create database trust_me

create table Item_Master (Item_Id int primary key identity (1,1),
Item_Name varchar (500) not null ,
Category varchar (500) not null , 
rate int ,
balance_quantity int not null)
select * from Item_Master
insert into Item_Master values('mobile','electronic',200,100)
update Item_Master set Item_Name='pho' where Item_Name='phone'


create table Department_mast (Department_id int primary key identity (1,1), 
Department_name varchar (500) not null)
select * from Department_mast 


create table Vendor_mast(Vendor_id int primary key identity (1,1),
Vendor_Name varchar (500) not null)
select * from Vendor_mast

create table Transactions (Transaction_id int  primary key identity (1,1) , 
item_id int ,transaction_date datetime not null , 
Department_id int , Vendor_Id int , 
Quantity int not null,
constraint c1 foreign key (Department_id) 
references Department_mast (Department_id ) ,
constraint c2 foreign key (Vendor_id) references 
Vendor_mast (Vendor_id),
constraint c3 foreign key (Item_Id) references 
Item_Master  (Item_Id))
select * from Transactions