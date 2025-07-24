--Prob1
create proc SP_GetNumOfStudInEachDept
with encryption
as 
	select dept_id Dept_ID,count(St_Id) NumOfStud
	from Student
	where dept_id is not null
	group by dept_id

execute SP_GetNumOfStudInEachDept
--prob2
create or alter proc SP_CheckEmpInP1
as
    declare @empcount int

    select @empcount = count(*) 
    from works_for 
    where pno = 100

    if @empcount >= 3
       select 'The number of employees in the project p1 is 3 or more'   as Result_Check
    else
    begin
        select 'The following employees work for the project p1'		 as Result_Check

        select e.fname, e.lname
        from employee e 
        join works_for w on e.ssn = w.essn
        where w.pno = 100
    end

exec SP_CheckEmpInP1
--Prob3
create or alter procedure SP_ReplaceProjEmp @old_emp_no int,@new_emp_no int,@project_no int
as
    update works_for
    set essn = @new_emp_no
    where essn = @old_emp_no and pno = @project_no

exec SP_ReplaceProjEmp 112233, 521634, 100
