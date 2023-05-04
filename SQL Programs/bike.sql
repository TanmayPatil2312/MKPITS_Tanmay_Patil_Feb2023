-- creating table of stores 
create table stores (store_id int primary key , store_name varchar (20) ,phone varchar (20), email varchar (20),
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

--creating table of stocks  
create table 

-- adding the records in stores table
insert into stores values (01, 'ather', '0712-223344', 'atherstore@gmail.com', 'dharampeth','nagpur','maharashtra',440001)
insert into stores values (02, 'ola', '0712-223355', 'olastore@gmail.com', 'sadar','nagpur','maharashtra',440002)
select * from stores,category

--adding the records in category table
insert into category values (01, 'petrol vehicle')
insert into category values (02, 'electric vehicle')

--adding the records in brands table
insert into brands values (01, 'ather scooters')
insert into brands values (02, 'ola scooters')

--adding the records in products table 
insert into products values(01, 'ather', 01, 01, 2023 , 156000)
insert into products values(02, 'ola', 02, 02, 2023 , 146000)
select * from stores ,category , brands , products

--