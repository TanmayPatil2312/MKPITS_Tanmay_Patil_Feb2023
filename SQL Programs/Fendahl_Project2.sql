create database fendahlProject2

----1 table TableNation ----
create table TableNation(NationID int primary key , NationName varchar(500))

insert into TableNation values (1 , 'India'),(2,'United Nation'),(3,'Nepal'),(4,'Sri Lanka')
select * from TableNation
select NationName from TableNation  ---this the query for class in which we write or in form nation name is listed this is the query 


-----2 table  TableState ---
create table TableState (StateID int primary key , NationID int , StateName varchar(500),
constraint t1 foreign key  (NationID) references  TableNation (NationID))

insert into TableState values (101,1,'Andhra Pradesh'),(102,1,'Punjab'),(103,2,'California'),(104,2,'Florida'),(105,3,'Koshi'),(106,3,'Bagmati'),(107,4,'Colombo'),(108,4,'Ratnapura')
select * from TableState

select s.StateName from TableState s inner join TableNation n on s.NationID=n.NationID where NationName='Nepal'
---3 table TableCity----
create table TableCity (CityID int primary key , StateID int , CityName varchar (500) , 
constraint t2 foreign key (StateID) references TableState (StateID))
insert into TableCity values (1001,101,'Vishakhapatnam'),
(1002,101,'Vijayawada'),
(1003,101,'Guntur'),
(1004,102,'Amritsar'),
(1005,102,'Jalandhar'),
(1006,102,'Chandigarh'),
(1007,103,'Los Angeles'),
(1008,103,'San Jose'),
(1009,103,'San Diego'),
(1010,104,'Jacksonville'),
(1011,104,'Miami'),
(1012,104,'Tampa'),
(1013, 105,'Damak'),
(1014,105,'Dharan'),
(1015,105,'Biratnagar'),
(1016,106,'Banepa'),
(1017,106,'Bharatpur'),
(1018,106,'Hetauda'),
(1019,107,'Grandpass'),
(1020,107,'Borella'),
(1021,107,'Pettah'),
(1022,108,'Balangoda'),
(1023,108,'Kolanna')

select s.CityName from TableCity s inner join TableState n on s.StateID=n.StateID where StateName='Andhra Pradesh'
--dont refer this below query this is written for only understanding in different method explained by khan sir --
--select c.CityID cCityName from TableCity c inner join TableState s on c.StateID=s.StateID where s.StateName='Miami'--

select * from TableCity

-----4 table  TableCourseRegDetails ----
create table TableCourseRegDetail (CourseRegID int primary key , CategoryID int , FullName varchar (1500) , GenderID int )
insert into TableCourseRegDetail values (4,1,'MK',1),
(5,2,'MK2',2),
(6,1,'Ravi',1),
(7,1,'Anand',1),
(8,1,'Gaurav',1),
(9,1,'Pranjali',2),
(10,1,'MK3',1),
(11,1,'MK4',1),
(12,1,'MK5',1),
(13,1,'MK6',1),
(14,2,'Dhananjay',1),
(15,1,'M Khan',1),
(16,2,'Ananya',2)
select * from TableCourseRegDetail

----5 Table TableRegAddress -----
create table TableRegAddress (RegAddressID int primary key , CourseRegID int , NationID int , StateID int , CityID int ,
constraint t3 foreign key (CourseRegID) references TableCourseRegDetail (CourseRegID),
constraint t4 foreign key (NationID) references TableNation (NationID),
constraint t5 foreign key (StateID) references TableState (StateID),
constraint t6 foreign key (CityID) references TableCity (CityID))

insert into TableRegAddress values (1,4,4,102,1003)
insert into TableRegAddress values(2,5,4,104,1009),
(3,6,4,102,1003),
(4,7,4,104,1012),
(5,8,2,104,1009),
(6,9,2,104,1009),
(7,10,2,103,1009),
(8,11,2,103,1007),
(9,12,1,102,1006),
(10,13,1,101,1001),
(11,14,4,107,1021),
(12,15,2,104,1012),
(13,16,1,101,1002)
select * from TableRegAddress


---- 6 table TableFeeDeatil ----
create table TableFeeDetail (FeeID int primary key identity , CourseRegID int , TotalAmount decimal , MinPer decimal, PaidAmount decimal , BalAmount decimal , PaidDate datetime ,
constraint t7 foreign key (CourseRegID) references TableCourseRegDetail (CourseRegID))

insert into TableFeeDetail values (4,1000,0,500,500,'2023-04-10'),
(5,3000,0,20,2980,'2023-04-04'),
(6,1000,0,200,800,'2023-04-10'),
(7,1000,0,500,500,'2023-04-10'),
(8,1000,0,500,500,'2023-04-10'),
(9,1000,0,500,500,'2023-04-10'),
(10,1000,0,500,500,'2023-04-10'),
(11,1000,0,500,500,'2023-04-10'),
(12,1000,0,600,400,'2023-04-10'),
(13,1000,500,600,400,'2023-04-10'),
(14,3000,2400,2400,600,'2023-04-10'),
(15,1000,500,500,500,'2023-04-10'),
(16,3000,2400,2500,500,'2023-04-10')
select * from TableFeeDetail



