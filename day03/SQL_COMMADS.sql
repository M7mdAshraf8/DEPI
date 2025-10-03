--Prb1
insert into Student
values(20,'Mohamed','Ashraf','Sharkia',22,30,null)
--Prb2
insert into Instructor (Ins_Id,Ins_Name,Ins_Degree,Salary,Dept_Id)
values(16,'Moaaz',null,4000,30)
--Prb3
update Instructor 
set Salary=Salary+(Salary*0.2)
--Prb4
select *
from Employee
--Prb5
select Fname,Lname,Salary,Dno
from Employee
--Prb6
select Pname,Plocation,Dnum
from Project
--Prb7
select Fname+' '+Lname as Full_Name,Salary*12*0.10 as ANNUAL_COMM
from Employee
--Prb8
select SSN,Fname+' '+Lname as Full_Name
from Employee
where Salary>1000
--Prb9
select SSN,Fname+' '+Lname as Full_Name
from Employee
where Salary*12>10000
--Prb9.1
select Fname,Salary
from Employee
where Sex='F'
--Prb10
select Dname,Dnum
from Departments
where MGRSSN=968574
--Prb11
select Pnumber,Pname,Plocation
from Project
where Dnum=10
/************************************************/
--Prb1
select count(*)
from Student
where St_Age is not null
--Prb2
select distinct Ins_Name
from Instructor
--Prb3
select I.Ins_Name Instructor_Name , D.Dept_Name Department_Name
from Instructor I left join Department D 
on I.Dept_Id=D.Dept_Id
--Prb4  
select S.St_Fname+ ' ' +S.St_Lname Full_Name,C.Crs_Name Course_Name
from Student S join Stud_Course SC 
on S.St_Id=SC.St_Id
join Course C 
on SC.Crs_Id=C.Crs_Id
where SC.Grade is not null
--Prb5
select T.Top_Name,count(*) Num_of_Courses
from Topic T join Course C 
on T.Top_Id=C.Top_Id
group by t.Top_Name
--Prb6
select STD.St_Fname Stud_Name,SPR.St_Fname Super_Name,SPR.St_Address Super_Address,SPR.St_Age Super_Age
from Student STD join Student SPR 
on STD.St_super=SPR.St_Id
/**********************************************************
--Display results of the following two statements and explain what is the meaning of @@AnyExpression
---select @@VERSION  -> returns the SQL Server version currently running
---select @@SERVERNAME -> returns the name of the SQL Server instance
---@@AnyExpression -> It refers to any predefined system variable that starts with @@ and is used to access advanced information inside SQL Server/
