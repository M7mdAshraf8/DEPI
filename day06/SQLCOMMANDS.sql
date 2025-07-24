--Prob1
create function GetMonthNameFromDate(@date date)
returns varchar(20)
as
begin
declare @monthname varchar(20)
select @monthname=datename(month, @date)
return @monthname
end
select dbo.GetMonthNameFromDate('2025-07-17')
--Prob2
create function GetNumbersBetween(@start int,@end int)
returns @output table 
(
number int
)
as
begin
declare @i int
set @i = @start + 1
while @i < @end
begin
    insert into @output
    values (@i)
    set @i = @i + 1
end
return
end
select * from GetNumbersBetween(2, 9)
--Prob3
create function GetStudentDeptInfo(@studno int)
returns table
as
return
(
    select s.st_fname+' '+s.st_lname fullname,d.dept_name
    from student s join department d 
	on s.dept_id = d.dept_id
    where s.st_id = @studno
)
select * from GetStudentDeptInfo(7)
--Prob4
create function CheckStudentNameStatus(@studid int)
returns varchar(max)
begin
declare @fname varchar(max)
declare @lname varchar(max)
declare @message varchar(max)

select @fname=st_fname,@lname=st_lname
from student
where st_id=@studid
if @fname is null and @lname is null
    set @message='first name & last name are null'
else if @fname is null
    set @message='first name is null'
else if @lname is null
    set @message='last name is null'
else
    set @message='first name & last name are not null'
return @message
end
select dbo.CheckStudentNameStatus(3)
select dbo.CheckStudentNameStatus(1111)
--Prob5
create function GetManagerHireInfo(@format int)
returns @output table 
(
dept_name varchar(max),
mgr_name varchar(max),
hiring_date_formatted varchar(max)
)
as
begin
insert into @output
select 
    d.Dept_Name,
    i.Ins_Name,
    case @format
        when 1 then convert(varchar, d.Manager_hiredate, 101)  -- mm/dd/yyyy
        when 2 then convert(varchar, d.Manager_hiredate, 103)  -- dd/mm/yyyy
        when 3 then datename(month, d.Manager_hiredate) + ' ' + cast(year(d.Manager_hiredate) as varchar) --monthname year
        else convert(varchar, d.Manager_hiredate, 120)         -- def: yyyy-mm-dd hh:mm:ss
    end
from Department d join Instructor i
on  d.Dept_Manager = i.Ins_Id 
return
end
select * from GetManagerHireInfo(1)
select * from GetManagerHireInfo(2)
select * from GetManagerHireInfo(3)
select * from GetManagerHireInfo(99)
--Prob5 in MyCompany
create function GetManagerHireInfoInMyCompany(@format int)
returns @output table 
(
dept_name varchar(max),
mgr_name varchar(max),
hiring_date_formatted varchar(max)
)
as
begin
insert into @output
select 
    d.Dname,
    e.Fname,
    case @format
        when 1 then convert(varchar, d.[MGRStart Date], 101)  -- mm/dd/yyyy
        when 2 then convert(varchar, d.[MGRStart Date], 103)  -- dd/mm/yyyy
        when 3 then datename(month, d.[MGRStart Date]) + ' ' + cast(year(d.[MGRStart Date]) as varchar) --monthname year
        else convert(varchar, d.[MGRStart Date], 120)         -- def: yyyy-mm-dd hh:mm:ss
    end
from Employee e join Departments d 
on e.Dno = d.Dnum
return
end
select * from GetManagerHireInfoInMyCompany(1)
select * from GetManagerHireInfoInMyCompany(2)
select * from GetManagerHireInfoInMyCompany(3)
select * from GetManagerHireInfoInMyCompany(99)
--Prob6
create function GetStudentNames(@pattern varchar(50))
returns @t table 
(
studName varchar(max)
)
as 
begin
	if lower(@pattern) = 'first name'
	insert into @t
	select isnull(St_fname, 'no first name')
	from Student
	else if lower(@pattern) = 'last name'
	insert into @t
	select isnull(St_lname, 'no last name')
	from Student
	else if lower(@pattern) = 'full name'
	insert into @t
	select isnull(St_fname, '') + ' ' + isnull(St_lname, '')
	from Student
	return
end
select * from GetStudentNames('first name')
select * from GetStudentNames('last name')
select * from GetStudentNames('full name')
--Prob7
create function GetEmployeesByProject(@projno int)
returns table
as
return
(
    select e.SSN,e.Fname,w.Pno
    from employee e join Works_for w 
	on e.SSN = w.ESSn
    where  w.Pno=@projno
)
select * from GetEmployeesByProject(600)

