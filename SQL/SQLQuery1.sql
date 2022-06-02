CREATE DATABASE Student;
USE Student;

create table student
(id int,
rollno int,
FirstName varchar(20),LastName varchar(20),Gender varchar(10));

Select * from student;

insert into student values(1,'101','Vikash',' Verma','Male');
insert into student values(2,'102','Rohit','Kumar','Male');
insert into student values(3,'103','Viyan','Soni','Male');
insert into student values(4,'104','Anjali','Soni','FeMale');
insert into student values(5,'105','Shivani','Verma','FeMale');
insert into student values(6,'106','Raj','Kumar','male');

create table employe (id int,name varchar(200),departmentid int)

insert into employe values(1,'Vikash',1)
insert into employe values(2,'Rohit',2)
insert into employe values(3,'Rahul',1)
insert into employe values(4,'Rahul',3)
 
 Select * from employe
 Select * from student;
 --outer join
 select * from employe emp FULL OUTER JOIN student stu on emp.departmentid=stu.id;
 select * from employe emp LEFT OUTER JOIN department dep on emp.departmentid=dep.id;


create table students(id int ,rollno int,firstname varchar(100),lastname varchar(100),gender varchar(20),classid int)

create table studentclass(id int,classname varchar(100))

select * from students
select * from studentclass

insert into studentclass values(1,'V');
insert into studentclass values(2,'VI')
insert into studentclass values(3,'VII')

insert into students values(1,101,'Vikash','Verma','Male',1)
insert into students values(2,102,'Rohit','Kumar','Male',1)
insert into students values(3,103,'Amit','Soni','Male',1)
insert into students values(4,104,'Rakesh','Sharma','Male',1)
insert into students values(5,105,'Anjali','Sharma','Female',1)


select rollno,CONCAT(firstname,' ',lastname) as FullName,gender,sc.classname from students s
inner join studentclass sc on sc.id=s.classid

/*
create function <function-name>(<parameters>) returns data-type as
begin
//body
end
*/
create function GetFullName(@ID int)
returns varchar(200)  AS 
Begin
 return (select CONCAT(firstname,' ',lastname) as FullName from students where id=@ID);
End

select * from students
select dbo.GetFullName(2) ;



