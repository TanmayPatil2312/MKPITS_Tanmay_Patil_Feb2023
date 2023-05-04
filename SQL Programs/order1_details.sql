--orders table created which have the primary key in it.
create table order1(order_no int primary key , order_date varchar(20) , cust_id int)
--product detail table created which have the foreign key in it.
create table productss (order_no int , product_id int , rate int , quantity int , 
constraint p01 foreign key(order_no) references order1 (order_no))

--data entered in the orders table first row
insert into order1 values (001 , '14/02/2023' , 212)

--data entered in the products table first row
insert into productss values ( 001 , 123 , 200 , 2)
insert into productss values ( 001 , 124 , 500 , 1)

----data entered in the orders table second row
insert into order1 values ( 002 , '14/02/2023' , 213)
--data entered in the products table second row
insert into  productss values (002, 123 , 200 , 1)
insert into productss values (002, 125 , 600 ,2)

-- date entered in the orders table third row 
insert into order1 values (003 , '14/02/2023' , 214)

--date entered in the products table third row
insert into productss values (003,125,600,1)
insert into productss values (003,126,1100,1)

--to display the orders table
select * from order1
--to dislay the products table 
select * from productss




