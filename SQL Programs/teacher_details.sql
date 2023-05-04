--teacher table created having primary key in it 
create table teacher(teacher_id int  primary key , teacher_age int)
--- subject table created having foreign key in it 
create table subject (teacher_id int , subject varchar(20) , 
constraint t1 foreign key(teacher_id) references teacher (teacher_id))
--data entered in teacher table 
insert into teacher values (01, 30)
--data entered in subject table 
insert into subject values ( 1 , 'chemistry')
insert into subject values (1 , 'biology')

--data entered in teacher table 
insert into teacher values (2, 26)
--data entered in subject table 
insert into subject values (2, 'english')
insert into subject values (2, 'maths')

--data entered in teacher table 
insert into teacher values (3, 25)
--data entered in subject table 
insert into subject values ( 3 ,'computer')

select * from teacher
select * from subject 