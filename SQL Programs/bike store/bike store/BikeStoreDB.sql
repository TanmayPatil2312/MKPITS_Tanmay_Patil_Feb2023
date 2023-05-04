-- creating table of stores 
create table stores (store_id int primary key , store_name varchar (20) ,phone int, email varchar (20),
street varchar (20) , city varchar (20) , state varchar (20) , zip_code int )

--creating table of category 
create table category (category_id int primary key , category_name varchar (20))

--creating table of brands 
create table brands (brand_id int primary key , brand_name varchar (20))

--creating table of products
create table products (product_id int primary key ,product_name varchar(20) , brand_id int,
category_id int ,model_year int , list_price int , 
constraint s1 foreign key (brand_id) references brands (brand_id) ,
constraint s2 foreign key (category_id) references category (category_id))

-- adding the records in tables 
insert into stores values (01, 'ather', 0712-223344, 'atherstore@gmail.com', 'dharampeth','nagpur','maharashtra',440001)
insert into stores values (02, 'ola', 0712-223355, 'olastore@gmail.com', 'sadar','nagpur','maharashtra',440002)
select * from stores