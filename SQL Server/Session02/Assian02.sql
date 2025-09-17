
 -- Part 01 : Use MyCompany DB
 Use MyCompany
-- 1. Display the employee First name, last name, Salary and 
--Department number. 

select Fname, Lname , Salary , Dno From Employee

--2. Display all the projects names, locations and the department which 
--is responsible for it. 

select PName , PNumber , Plocation , DNum from Project

--3. Display the employees Id, name who earns more than 1000 LE 
--monthly. 
select SSN , Fname from Employee
where Salary > 1000

--4. Display each department id, name which is managed by a manager 
--with id equals 968574. 

select Dnum , Dname From Departments
where MGRSSN = 968574

--5. Display the ids, names and locations of  the projects which are 
--controlled with department 10. 
 
select PName , PNumber ,  Pro.Plocation
From Departments dept , Project Pro
where dept.Dnum = pro.Dnum and Dept.Dnum = 10;

-- Or 

select PName , PNumber , Plocation , DNum from Project
Where Dnum = 10
-- ==================================================================================
--  Part 02 : Use ITI DB
Use ITI 

--1. Get all instructors Names without repetition. 

select Distinct Ins_Name from Instructor

--2. Display instructor Name and Department Name Note: display all the 
--instructors if they are attached to a department or not. 

select Ins_Name , Dept_Name
from Instructor Ins left outer join Department dept
On dept.Dept_Id = Ins.Dept_Id

--3. Display student full name and the name of the course he is taking for 
--only courses which have a grade. 

select s.St_Fname + ' ' + S.St_Lname as [Full Name] , C.Crs_Name
From Student S , Course C , Stud_Course Sc 
where  S.St_Id = Sc.St_Id and C.Crs_Id = Sc.Crs_Id and Grade is not null

--4. Select Student first name and the data of his supervisor.  

Select * from Student

select Stu.St_Fname, Supr.*
From Student Stu , Student supr
where Supr.St_Id = Stu.St_super -- PK = FK

--5. Display student with the following Format.
	--  Student ID -Student Full Name - Department name

select S.St_Id As [Student Id], s.St_Fname + ' ' + S.St_Lname as [Full Name] , D.Dept_Name As [Department Name]
From Student S , Department D
where D.Dept_Id = S.Dept_Id

-- ==============================================================================================
-- Part 03 : Use MyCompany DB
Use MyCompany

--1. Display the Department id, name and id and the name of its manager. 

select D.Dnum , D.Dname , E.SSN , E.Fname
from Departments D , Employee E
where E.SSN = D.MGRSSN

--2. Display the name of the departments and the name of the projects 
--under its control. 
select D.Dname , P.Pname
From Departments D, Project P
where D.Dnum = P.Dnum
 
--3. Display the Id, name, and location of the projects in Cairo or Alex 
--city.

select Pnumber , Pname , Plocation , City
from Project
where City in ('Cairo', 'Alex')

 --4. Display the Projects full data of the projects with a name starting with 
--"a" letter. 

Select * from Project
where Pname like 'a%'

--5. display all the employees in department 30 whose salary from 1000 to 
--2000 LE monthly 

select * from Employee 
where Dno = 30  And Salary between 1000 and 2000

--6. Retrieve the names of all employees in department 10 who work more 
--than or equal 10 hours per week on the "AL Rabwah" project. 

select E.Fname
From Works_for W , Employee E , Project P
where E.SSN = W.ESSn and P.Pnumber = W.Pno 
	And E.Dno = 10 and  Hours >= 10 and Pname = 'AL Rabwah' 


--7. Find the names of the employees who were directly supervised by 
--Kamel Mohamed 

select Emp.Fname + '  ' + Emp.Lname as [Emplyee Name]
From Employee Emp , Employee Supr
where Supr.SSN = Emp.Superssn And Supr.Fname = 'Kamel' and Supr.Lname = 'Mohamed' 

--8. Display All Data of the managers 

select E.*
From Employee E , Departments D
where E.SSN = D.MGRSSN

--9. Retrieve the names of all employees and the names of the projects 
--they are working on, sorted by the project name.

select E.Fname , P.Pname
From Employee E , Works_for W , Project P
where E.SSN = W.ESSn and P.Pnumber = W.Pno
Order by 2

-- ==================================================================================
-- Part 04 : Use MyCompany DB
Use MyCompany

--1. Try to update all salaries of employees who work in Project ‘Al 
--Rabwah’ by 30%  

Update E
set E.Salary += Salary * .30
From Employee E ,Works_for W , Project P
Where E.SSN = W.ESSn And P.Pnumber = W.Pno and P.Pname = 'Al Rabwah'

--2. In the department table insert a new department called 
--"DEPT IT”, with id 100, employee with SSN = 112233 as a 
--manager for this department. The start date for this manager 
--is '1-11-2006'. 

insert Into Departments Values
('DEPT IT' , 100 , 112233 , '11/1/2006')

--3. Do what is required if you know that: Mrs. noha Mohamed 
--(SSN=968574) moved to be the manager of the new 
--department (id = 100), and they give you (your SSN =102672) 
--her position (Dept. 20 manager) 

-- Temp Test
select *  From Employee
where FName = 'noha' And LName = 'Mohamed'

select * from Departments
where MGRSSN = (select SSN From Employee where FName = 'noha' And LName = 'Mohamed')

--a. First try to update her record in the department table.

Update Departments
set MGRSSN = 968574 
where Dnum = 100

--b. Update your record to be department 20 manager.

Insert Into Employee Values
('Mohamed' , 'El Sayed' , 102672 , 23/1/2004 ,'El Giza St El Mesala ', 'M', Null ,Null , 20)
select * From Employee

Update Departments
set MGRSSN = 102672 
where Dnum = 20