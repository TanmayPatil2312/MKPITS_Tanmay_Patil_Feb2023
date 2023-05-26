create database Fendahl

----1 table below ----

create table TableProductGSTDetails(Product_Gst_ID int primary key , Gst_Details_Name varchar (500),
CGST decimal(18,0), SGST decimal (18,0),IGST decimal (18,0))
select * from TableProductGSTDetails

insert into TableProductGSTDetails values (601,'AC and Fridge',14,14,14)
insert into TableProductGSTDetails values (602,'Computers',9,9,9)
insert into TableProductGSTDetails values (603,'Printers',9,9,9)
insert into TableProductGSTDetails values (604,'Mobiles',6,6,6)

---2 table given below ---
create table TableProductCategory(Product_Category_ID int primary key , Product_Type_Name varchar (500),
Product_Gst_ID int ,
constraint p1 foreign key (Product_Gst_ID) references TableProductGSTDetails(Product_GST_ID))

insert into TableProductCategory values (1001,'Computers',602)
insert into TableProductCategory values (1002,'Mobile',604)
insert into TableProductCategory values (1003,'Printers',603)
insert into TableProductCategory values (1004,'AC and Fridge',601)
select * from TableProductCategory

---3 table given below ---
create table TableProduct(ProductID int primary key, Product_Name varchar (500),Product_Category_ID int , 
ProductPrice decimal(18,0),
constraint c1 foreign key (Product_Category_ID) references TableProductCategory(Product_Category_ID))

insert into TableProduct values (210,'Apple',1002,40000)
insert into TableProduct values (211,'Lenovo',1002,25000)
insert into TableProduct values (212,'Samsung',1003,50000)
insert into TableProduct values (213,'IFB',1004,20000)
insert into TableProduct values (214,'LG',1004,30000)
insert into TableProduct values (215,'Sony',1001,60000)

select * from TableProduct

----4 table data should not enter until khan sir give the instruction ----
create table TableInvoiceDetails(Invoice_Details_ID int primary key ,Customer_Name varchar (500) , 
Customer_Contact varchar (20), Product_Category_ID int, Product_ID int , Residential_Type_ID int , 
Invoice_Date datetime , Quantity decimal(18,0), Price decimal (18,0), CGST decimal (18,0),
SGST decimal (18,0), IGST decimal (18,0), CGST_Value decimal (18,0),SGST_Value decimal (18,0),
IGST_Value decimal (18,0),Total_Amount decimal (18,0),
constraint b1 foreign key (Product_Category_ID) references TableProductCategory(Product_Category_ID),
constraint b2 foreign key (Product_ID) references TableProduct(ProductID))
select * from TableInvoiceDetails