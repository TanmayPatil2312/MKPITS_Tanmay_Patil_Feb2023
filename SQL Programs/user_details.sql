create table user_details (user_id int primary key, user_name varchar (30) , password varchar(20) , email_id varchar (20), gender varchar (10), city varchar(20), country varchar (15))
insert into user_details values ( 101 , 'yasmin' , 'yasmin123', 'yasmin18@gmail.com','female', 'balarshah','india')
insert into user_details values ( 102 , 'sahil' , 'sahil123', 'sahil21@gmail.com','male', 'nagpur','india')
insert into user_details values ( 103 , 'tanmay' , 'tanmay123', 'tanmay23@gmail.com','male', 'nagpur','india')
insert into user_details values ( 104 , 'jayesh' , 'jayesh123', 'jayesh27@gmail.com','male', 'amravati','india')
insert into user_details values ( 105 , 'anjali' , 'anjali123', 'anjali11@gmail.com','female', 'kalamna','india')
insert into user_details values ( 106 , 'monali' , 'monali123', 'monali20@gmail.com','female', 'nagpur','india')
insert into user_details values (107, 'tanushree' , 'tanushree123', 'tanus15@gmail.com','female','quhi','india')
insert into user_details values (108, 'karishma' , 'karishma123', 'karishma06@gmail.com', 'female','nagpur','india')
insert into user_details values (109 , 'mayuri', 'mayuri123' ,'mayuri09@gmail.com','female','nagpur','india')
insert into user_details values (110,'neha','neha420','neha05@gmail.com','female','nagpur','india')
select * from user_details
--below line display the user name in ascending order i.e alphabetical order a--> z
select user_name from user_details order by user_name
--below line display the user name in descending order i.e z --> a
select user_name from user_details order by user_name desc
select user_id from user_details order by user_id 
select user_id from user_details order by user_id desc
select user_id ,user_name from user_details order by user_id 
select email_id,password from user_details order by email_id desc ,password desc;
select email_id , password from user_details order by email_id desc , password asc;
--invalid query because state column is not in the table 
select user_id , user_name , state from user_details order by state
-- len is use to display the particular column words in a ascending order 
select user_id , user_name from user_details order by LEN(user_name);
--len is also use to display the particukar column words in a descending order 
select user_id , user_name from user_details order by LEN (user_name) desc;
select city from user_details order by LEN(city) desc;
--top keyword is use to show most famous top values from the particular column 
select TOP 5 user_id , user_name from user_details order by user_id ;
--top keyword is use to show most famous top values from the particular column
select top 5 user_id , user_name from user_details order by user_name desc;
---top using top  we can also display the particular column data in percentage wise
select TOP 5 percent user_id , user_name from user_details order by user_id ;
select TOP 20 percent user_id , user_name from user_details order by user_name desc ;
--- distinct it will show non repeatedly record only 
select distinct city from user_details
select distinct user_id from user_details
select distinct user_name from user_details
select distinct email_id from user_details order by email_id desc
-- where in this condition we find the values 
select * from user_details where user_id=110
select * from user_details where user_id>101
select * from user_details where user_name='neha'
select * from user_details where city='nagpur'
select * from user_details where city='kalamna'
--using where keyword we compare two condition and display it 
select * from user_details where user_name = 'tanmay' and city='nagpur';
select * from user_details where user_id = 109 and user_name='mayuri';
-- where using Finding rows that meet two conditions
select * from user_details where user_name ='sahil' and city='nagpur'
select * from user_details where email_id='tanu15@gmail.com' and city='quhi'
select * from user_details
delete from user_details where user_id=107 
insert into user_details values (107, 'tanushree' , 'tanushree123', 'tanushree15@gmail.com','female','quhi','india')
select * from user_details where email_id='tanus15@gmail.com' and city='quhi'
select * from user_details

--Finding rows by using a comparison operator
select * from user_details where city='quhi' and user_name='tanushree'
select * from user_details where country='india' and user_id > 103


