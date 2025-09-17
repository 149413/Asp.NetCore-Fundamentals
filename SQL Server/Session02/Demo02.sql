-- 01 Revision 

-- 1. Variables 
-- global Variable @@
-- Local Variable @
--------------------------------------
-- 2. Datatypes 
--------------------------------------
-- 3. Sql Category

-- 1. DDL: Data Defination language
-- 2. DML: Data Manipulate Languge
-- 3. DQL: Data Query Language
-- 4. DCL: Data Control Language
-- 5. TCL: Transaction Control Language
-----------------------------------------
-- DDL: Structure (Create - Alter - Drop)

-- Create : Used To create Database or Any DB Object (Table - Functions - views - SP - Trigger - ...........)
-- Alter : Used To Update Database or Any DB Object (Table - Functions - views - SP - Trigger - ...........)
-- Drop : Used To Remove Database or Any DB Object (Table - Functions - views - SP - Trigger - ...........)

-- DDL Using SQL
-- DDL Using Wizard

------------------------------------------
Use Route
Use SD
-- 2. DML: Data Manipulate Language - Data
--		(Insert - Update - Delete)

-- 1. Insert : Insert Row or More Into Any Table

-- 1.1. Simple Insert : Insert Just Only One Row

 
select * from NewStudentData03

Insert Into NewStudentData03 
Values(7 , 'Ali' , 'Ramadan' , 18 , null , null)

Insert Into NewStudentData03 
Values(7 , 'Maha' , Null , 20 , null , null)
  
Insert Into NewStudentData03(St_Id , St_FName, St_Age)
Values(9 , 'Salma' , 22)

-- Note : To Skip Value of Column the Value must be one of The Following
--1. has Identity Value
--2. Has Default Value
--3. Allow Null Value

-- 1.2. Row constructor Insert : Insert More Than Row
Insert Into NewStudentData03 Values
(10 , 'Mariam' , 'Mohamed' , 18 , null , null) ,
(11 , 'Maha' , 'Ahmed' , 30 , null , null)


Insert Into NewStudentData03(St_Id , St_FName, St_Age)
Values
(12 , 'Salma' , 22),
(13 , 'Omar' , 23)

---------------------------------------------------------------
-- Update 
Update NewStudentData03
set St_Age += 1

Update NewStudentData03
set St_Id = 8
where St_FName = 'Maha' and St_age = 20
 
--------------------------------------------------------------
-- Delete
Delete From NewStudentData03
where St_FName = 'Maha'

----------------------------------------------------------------------
Use SD
-- DQL: Data Query Language : Display (Select)

select * from emp

select eName , age , eAddress , city from emp

select eid, eName,sal from emp

select  eName + '  From  ' + city as [Personnal decription] from emp 

-------------------------------------
-- Select + Where

select * from emp
	where eAddress is  NULL or sal is not Null
	
select * from Emplyee
where age between 23 and 30

select * from Emplyee
where age Not between 23 and 30

select * from Emplyee
where age <> 40   -- <> Like !=

select * from Emplyee
where Fname <> 'B'

select * from Emplyee
where Address = 'cairo' or Address = 'Alex'

select * from Emplyee
where Address in ('cairo' , 'Alex') and age is not Null

select * from Emplyee
where Address Not in ('cairo' , 'Alex')

select * from emp
	where sal = Null  -- InValid (Logic)

select * from emp
	where sal is not Null -- Valid

-- = Values	
-- Note: NULL is Not aValue 
----------------------------------
-- Select + Like 

 -----------------  Wild card  -----------------------------
 
--  _   => represent One char
--  %   => represent Zero or More char
-- []   => Match Any Single Character Whithin the Rage 
-- [^]  => Match Any Single Character Not Whithin the Rage 
 -------------------
/*
 like9+
	'a%'
	'%a'
	'a%a'
	'a%h'
	'_a%'
	'%a_'
	'ahm%'
	'[ahm]%'
	'[^ahm]%'
	'[a-h]%'
	'[^ a-h]'
	'[234]%'
	'%[%]'
	'%[_]%'
	'[_]%[_]'
*/
insert into Emplyee(SSN , FName) values(101 ,'%Asem') , ( 102  , 'Ahmed_Ali') ,(103 ,'_kareem')
select * from Emplyee

select * from Emplyee
where FName like '[ahm]%'

select * from Emplyee
where FName like '[^ahm]%'

select * from Emplyee
where FName like '[a-h]%'

select * from Emplyee
where FName like '[^ a-h]%'

select * from Emplyee
where FName like '[%]%'

select * from Emplyee
where FName like '[_]%'

select * from Emplyee
where FName like '%[_]%'

----------------------------------------------------------------
-- Select + Distinct
-- Distinct : Dispay Data Without Any Duplication

select distinct FName , Age , Address from Emplyee

select distinct FName , Age , Address from Emplyee
where Address is Not Null

---------------------------------------------------
-- Select + Order By
-- Order By : Sorting Data by [ Ascending - Descending]
--     Default  is [ Ascending ]

select * from Emplyee

Select SSN , FName , DNum , Salary
from Emplyee
order by 1

Select SSN , FName , DNum , Salary
from Emplyee
order by 3 desc

Select SSN , FName , DNum , Salary
from Emplyee
order by 4

Select SSN , FName , DNum , Salary
from Emplyee
order by 5     --- XXXXXXXX Error The Num Order outside


Select SSN , FName , did , age
from Emplyee
order by did , salary  ---  Order By age:  When There is Equal Values By did 

Select SSN , FName , did , age
from Emplyee
order by 3 desc,4 desc

select SSN , FName , LName , age , Address 
from Emplyee
order by 5  -- Out of Range

-------------------------------------------------------
--  Join : To Join or Relate Two Tables
------------------------------------------------------
 
 -- 1- Cross join
	---- cartisian Join
-- 2- inner join
	--- Equi join
-- 3 Outer join 
	--- Left Outer join
	--- Right Outer join
	--- Full Outer join
-- 4- Self Join
	--- (Unary Relatinship)
select * from Emplyee  
select * From Department
 
--- 1. Cross join
-- OLD - ANSI
select FName , DName
   from Emplyee , Department
   Where DNum is Not Null
-- NEW - MS
select FName , DName
  from Emplyee cross join Department
  Where DName is Not Null

--- 2. Inner join
select *from Emplyee
select  * From Department

 -- Dispaly The student that have depart
select FName , DName
  from Emplyee , Department
  where Emplyee.DNum = Department.DNum     /*	PK = Fk    	*/

select FName , Dname
	from Emplyee S , Department D
	where S.DNum = D.DNum

select FName , DName
	from Emplyee S inner join Department D
	ON S.DNum = D.DNum

 -- Dispaly The student that have Not depart
 select Fname , DName
 from Emplyee E inner join Department D
 on E.DNum = D.DNum and D.DName is null	

--- 3. Outer Join
select * from Emplyee
select * From Department

select Fname , DName
	from Emplyee E Left Outer Join Department D
	On E.DNum = D.DNum

	select FName , DName  
	From Emplyee E RIGHT Outer Join Department D
	On  E.DNum = D.DNum

select FName, DName
	from Emplyee E Full Outer Join Department D
	On E.DNum = D.DNum

--- 4. Self Join
select X.FName as EName , Y.FName as SupName  -- Note: This Query Only Implement in Desk Not DataBase   
	From Emplyee X , Emplyee Y
	where Y.SSN = X.Supid    /*	Emplyee-X[Child] Primary Key ---->  SuperEmplyee-Y[Parent] Forein Key	*/

	select X.FName as EName , Y.FName as SupName   
	From Emplyee X inner join Emplyee Y
	On Y.SSN = X.Supid  

	select X.FName as EName , Y.FName as SupName
	From Emplyee X Left outer join Emplyee Y
	On Y.SSN = X.Supid  

	select X.FName as EName , Y.FName as SupName
	From Emplyee X right outer join Emplyee Y
	On Y.SSN = X.Supid  

--------------  Join Multiple Tables
select * from Emplyee
select * From Department
select * from Project
select FName,SSN , DName,PName
	from Emplyee E , Department d , project P
	where E.DNum = D.DNum and
		  D.DNum = P.Dnum

select SSN , FName , DName , PName
	From Emplyee E inner join Department D
	On E.DNum = D.DNum
	inner join Project P
	On D.DNum = P.Dnum

select SSN , FName as EName, PName , City
	from Emplyee E Inner join Department D
	On D.MrgSSN = E.SSN
	inner join Project P
	On P.Dnum = D.DNum 

--------------------  join + DML ( Insert - Update - Delete)
-- Update 
select * from Emplyee
select * from Department
select * from Project
 
 Update Emplyee
	set salary += 100
	from Emplyee E , Work  W , Project P
		where E.SSN = w.SSN and W.PNumber = P.PNum and City = 'Cairo';

select * from Emplyee

-- Delete 

select * from Emplyee;

delete from Emplyee
From Emplyee E, Department D  , Project P
where E.DNum = d.DNum And D.DNum = P.Dnum and P.PName = 'dose')

--By SuBQuery
delete from Emplyee
where  Fname = (select Fname
				from Emplyee E, Department D  , Project P
				where E.DNum = d.DNum And D.DNum = P.Dnum and P.PName = 'dose')

select * from Emplyee;  

---- Insert     -- Insert Based On Select
Use Route

Insert into Student
Select St_FName , St_LName , St_Age , address ,S.Dept_Id
From Student S ,Department D 
where S.Dept_Id = D.Dept_Id And D.Dept_Id = 40

Select * from Student




