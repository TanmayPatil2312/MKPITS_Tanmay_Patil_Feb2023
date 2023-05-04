create table student (stud_rollno int primary key, stud_name varchar (20) , stud_age int , stud_insta_id varchar(20))
insert into student values( 11 , 'Ram', 10 , 'ramu_swagger')
insert into student values( 12 , 'Sham', 15 , 'Shaamu_blogger')
insert into student values( 13 , 'Dolly', 16 , 'dolly--eyecatcher')
insert into student values( 14 , 'Sam', 17 , 'sammy_shooter')
insert into student values( 15 , 'Dham', 18 , 'dammy_singer')
insert into student values( 16 , 'Mamu', 20 , 'mamuu_chailover')
--below commands is for showing the single single column in output
select stud_name from student
select stud_rollno from student
select stud_age from student
select stud_insta_id from student
--below commands is for showing the column in ascending order 
select stud_rollno from student order by stud_rollno
select stud_name from student order by stud_name
select stud_age from student order by stud_age
select stud_insta_id from student order by stud_insta_id
--select * from  student order by stud_name
-- below commands is for showing the particular column in descending order 
select stud_rollno from student order by stud_rollno desc 
select stud_name from student order by stud_name desc
select stud_age from student order by stud_age desc
select stud_insta_id from student order by stud_insta_id desc
-- query to find records whose name is sam
select * from student where stud_name='sam'
--query to find records whose name is ram
select * from student where stud_name='ram'
--query to find records whose rollno is 15
select * from student where stud_rollno=15
--query to find records whose age is 20
select * from student where stud_age=20
--query to find records whose insta id is mamu_chailover
select * from student where stud_insta_id='mamuu_chailover'
select * from student


