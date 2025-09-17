
-- Part 01  :  Use ITI DB
Use ITI
-- 1. Retrieve a number of students who have a value in` their age.

Select Count(*)
from Student
where ST_Age is Not Null

-- 2. Display number of courses for each topic name
select * from topic 
select * from Course 


Select T.Top_Name  , count(C.Crs_Id) as [Num Of Course]
from Course C inner join Topic T
on C.top_Id = T.Top_Id
group by T.Top_Name

-- 3. Display student with the following Format (use isNull function)

Select St_Id As [Student ID] , IsNull(St_FName ,'No First_Name') + ' ' + ISNull(St_LName , ' ') as [Student Full Name] , Dep_Name as [Department Name]
From Student S , Department D
where S.Dept_Id = D.Dept_Id

-- 4. Select instructor name and his salary but if there is no salary display
    -- value ‘0000’ . “use one of Null Function”
Select Ins_Name ,coalesce(Salary ,000) 
from Instructor

-- 5. Select Supervisor first name and the count of students who
	-- supervises on them

select Supr.St_FName as Super_Name  , count(Supr.St_Id) as [Number of Student]
from Student Stud Inner join Student Supr
on Supr.St_Id = Stud.St_super  -- PK = FK
group by Supr.ST_FName


-- 6. Display max and min salary for instructors

select Max(salary) , min(salary)
from Instructor

-- 7. Select Average Salary for instructors
select Avg(salary)
from Instructor


---------------------------------------------------------
-- Part 02 : Use MyCompany DB
USE  MyCompany
-- 1.  For each department, retrieve the department name and the
	-- maximum, minimum and average salary of its employees.

ٍSelect D.Dname  , Max(E.salary) As MaxValue , min(E.salary) As MinValue, Avg(E.Salary) As AvgValue
From Departments D inner join Employee E
on D.Dnum = E.Dno
group by D.DName


---------------------------------------------------------------