create database mvc_connection

create table ItemTable (Id int not null primary key identity , 
Name Nvarchar(50) null,
Category Nvarchar(50) null,
Price decimal null)

select * from ItemTable
