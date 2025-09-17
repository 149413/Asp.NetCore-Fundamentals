--01 Revision

-- Function : Is A block of Query 

-- 1- Scalar Function : Return Only one Value
-- 2- Table-Valued Function : return table Value

-- 1. Build-In Function
	-- [ Aggregate  - Null - Conversion - String - Date&Time - Format - ........Functions ]
-- 2. Some Of Query 
	-- Group by - Top & Top With Ties - Random Select 

-- **********************************************************************************************

/*
	Demo Content
	1.  02 SubQuery
	2.  03 Ranking Functions
	3.  04 Practise On ranking Functions
	4.  05 Ranking Funaction NTile
	5.  06 Execute Order
	6.  07 Union Family
	7.  08 Select InTo && Insert Based On Select
	8.  09 Drop Vs Delete Vs Truncate
	9.  10 RelationShip Rules
	10. 11 DB Shema

*/

-- **********************************************************************************************
--==================
-- 1- SubQuery : 
--==================
	-- Output Of SubQuery Can Used As Input Of Another Outer Query 
	-- LOW Performance

use ITI

select Avg(St_Age)
from Student

select St_FName , St_LName , St_Age
From Student
where St_Age > 23

select St_FName , St_LName , St_Age
From Student
where St_Age > (Select Avg(St_Age) From Student) -- SubQuery (inner Query)

-- Note: SubQuery (Inner) Will Execute First 

--==================
-- Practises
--==================

--1- Disp Student Who Thier Ages Greater Than Student Avarage
select St_FName , St_LName , St_Age
From Student
where St_Age > Avg(St_Age) -- InValid

-- Be InVlid with Aggragate 
select St_FName , St_LName , St_Age
From Student
Having St_Age > Avg(St_Age) -- InValid
-- Column 'Student.St_Age' is invalid in the HAVING clause 
-- because it is not contained in either an aggregate function or the GROUP BY clause.

--==============================================================================================

-- 2- Disp Student Id  , Student Name And count of Student with Each Student
-- 1  Name | 19
-- 2  Name | 19
-- 3  Name | 19

select count(*) from Student

select St_id , ST_FName , (24) As [Number Of  Student]
From Student 

-- Result
select St_id , ST_FName , (select count(*) from Student) As [Number Of  Student]
From Student 

--================================================================================================

-- 3- Disp Department Name which Own Student By SubQuery Not Join

select St_Id , St_FName , Dept_Id
from student
--1
select Distinct Dept_Id
From student 
where Dept_Id is Not null
--2
select Dept_Name
From Department
where Dept_Id in (10 , 20 , 30 , 40)
----------------------
--Result 
select Dept_Name 
From Department
where Dept_Id in (Select Distinct Dept_Id 
From student
where Dept_ID is Not null)  -- By SubQuery(inner Query)

-- BY Join
Select distinct D.Dept_Name
From Department D , Student S
where D.Dept_Id = S.Dept_ID -- P.K  = F.K

-- Best Practise for This example Is Join

--==========================================================================================================

-- 4- Delete Student Who Take Courses And From 'Mansoura'
-- 1
select St_Id
From Student
Where address = 'Mansoura'
-- 2 
select *
from Stud_Course
where Stu_Id in (8 , 9 , 10)

--res
select * 
From Stud_Course
where Stu_Id in (select St_Id from Student Where address = 'Mansoura')

-- To Del
Delete from Stud_Course
where Stu_Id in (select St_Id from Student Where address = 'Mansoura')
-------------------------------
-- By join
select Sc.* , St_FName , S.address
From Student S , Stud_Course Sc
where Sc.Stu_Id = S.St_Id And S.address = 'Mansoura';

-- To Del
Delete From Stud_Course Sc
From Student S , Stud_Course Sc
where Sc.Stu_Id = S.StId And S.address = 'Mansoura';

--========================================================================================================

-- 4- Disp The Student own secound Greater Salary 
--1-
select Max(Salary)
from Instructor
--2-
select Max(Salary)
From Instructor 
where Salary != 5000   -- Fixed
-- res
select Max(Salary) As [Secound Greater Salary]
From Instructor 
where Salary != (select Max(salary)from Instructor)  -- Dynamic

--res2 (By top)
Select top(1) Salary
From (select Top(2) Salary from Instructor
Order By Salary Desc) as T
Order by salary

-- Third Greater Salary
Select top(1) Salary
From (select Top(3) Salary from Instructor
Order By Salary Desc) as T
Order by salary

-- Note: Use Must Give alias Name to SubQuery (Inner) with Top


--***************************************************************************************************************
--***************************************************************************************************************
--=========================
-- 2. Ranking Functions 
--=========================
-- Rank ترتيب 

Use Sd 

select * from Emplyee
-- 1- Row_Number()
select SSN , FName , DNum , age , salary , ROW_NUMBER() over(order by salary desc) as [Row_Number]
from Emplyee

-- 2- Dense_Rank()
select SSN , FName , DNum , age , salary , 
ROW_NUMBER() over(order by salary desc) as [Row_Number] ,
DENSE_Rank() over(order by salary desc) as Dense_Rank
from Emplyee

-- 3- Rank()
select SSN , FName , DNum , age , salary , 
ROW_NUMBER() over(order by salary desc) as [Row_Number] ,
DENSE_Rank() over(order by salary desc) as [Dense_Rank] ,
Rank() over(order by salary desc) as Rank
from Emplyee

--***************************************************************************************************************
--***************************************************************************************************************


-- 3. Practise 1 : Disp The First Two Emplyee in an Age

-- Using Top
select top(2) SSN , FName , DNum , age , salary  from Emplyee
order by age desc

-- Using Ranking
select SSN , FName , DNum , age , salary , ROW_NUMBER() over(order by age desc) as RN
from Emplyee 
where RN <= 2	 -- Syntax Error: As RN Not Seen By compiler [Will Be discussed With Execute order]

select *
From ( select SSN , FName , DNum , age , salary , ROW_NUMBER() over(order by age desc) as RN 
from Emplyee ) As T
where RN <= 2



-- Practise 2 : Disp The Three Emplyee in an Age

-- Using Top()
select top(1) *
From (select top(5) SSN , FName , DNum , age , salary 
from  Emplyee order by age) 
order by age desc          -- Sentax Error : You must Set Aliase Name for your subquery As The Following Script 

-- Note:You must Set Aliase Name for your subquery 

select top(1) *
From (select top(3) SSN , FName , DNum , age , salary 
from  Emplyee 
where age is Not null
order by age) as T
order by age desc 

-- Using Ranking
select *
From (select SSN , FName , DNum , age , salary , ROW_NUMBER() over (order by age) as RN
from Emplyee
where age is not null ) as sub
where RN <= 3

-- Note The difference between Row_Numbe() && Dense_Rank()

select *
From (select SSN , FName , DNum , age , salary , Dense_Rank() over (order by age) as DR
from Emplyee
where age is not null ) as sub
where DR <= 3


select top(6) SSN , FName , DNum ,salary , age, 
ROW_NUMBER() over(order by age  ) as [Row_Number] ,
DENSE_Rank() over(order by age  ) as [Dense_Rank] ,
Rank() over(order by age  ) as Rank
from Emplyee
where age is not null

----------------------------------------------------------------------------
--==============================
-- Ranking with Partitioning 
--==============================

Select  did , Min(age) as Age
from Emplyee 
group by did

select SSN , FName , DNum , age , salary ,did , row_Number() over(partition by did order by age) asRN
from Emplyee
where age is not null
 
select * 
From(select SSN , FName , DNum , age , salary ,did ,
row_Number() over(partition by did order by age) as RN
from Emplyee
where age is not null) as [Table]
where RN = 1

select * 
From(select SSN , FName , DNum , age , salary ,did , 
--row_Number() over(partition by did order by age) as RN ,
Dense_Rank() over(partition by did order by age) as DR
from Emplyee
where age is not null) as [Table]
where DR = 1 


select * 
From(select SSN , FName , DNum , age , salary ,did , 
Rank() over(partition by did order by age) as R
from Emplyee
where age is not null) as [Table]
where R = 1

-- Select Min Salay

select * 
From(select SSN , FName , DNum , age , salary ,did ,
row_Number() over(partition by did order by age) as RN
from Emplyee
where age is not null) as [Table]
where RN = 1

select * 
From(select SSN , FName , DNum , age , salary ,did , 
Rank() over(partition by did order by salary) as R
from Emplyee
where age is not null) as [Table]
where R = 1

-- Select Third Min Salary
select * 
From(select SSN , FName , DNum , age , salary ,did ,
row_Number() over(partition by did order by age) as RN
from Emplyee
where age is not null) as [Table]
where RN = 3

select * 
From(select SSN , FName , DNum , age , salary ,did , 
Rank() over(partition by did order by salary) as R
from Emplyee
where age is not null) as [Table]
where R = 3

--***************************************************************************************************************
--***************************************************************************************************************


-- 4. NTile(Num of groups) : Used to divide the Table into some groups based on column

select SSN , FName , DNum , age , salary ,did , NTile(3) over(order by salary desc) as NT
from Emplyee
-- 24 / 3 ==> 8
select SSN , FName , DNum , age , salary ,did , NTile(5) over(order by salary desc) as NT
from Emplyee
-- 24 / 5 => 25 / 5 ==> 5 5 5 5 4
-- 16 / 3 ==> 18 => 6 6 4

--***************************************************************************************************************
--***************************************************************************************************************


-- 5. Execution order 
--1- From
--2- Join - On 
--3- Where
--4- Group by 
--5- Having 
--6- [Select]
--7- Distinct
--8- Order by
--9- Top
--10- Top with Ties

Select FName + ' ' + LName as FullName
From Emplyee
where FullName = 'Ahmed khalid'  -- Invalid


Select FName + ' ' + LName as FullName
From Emplyee
order by FullName  -- Valid

--***************************************************************************************************************
--***************************************************************************************************************

-- 6. Union Family
	--1- Union
	--2- Union All
	--3- Intersect
	--4- Except
Use ITI
-- Union : To Get Values From Two Sets Without Duplication
select St_FName from Student
Union
select Ins_Name From Instructor

-- Union All : To Get Values From Two Sets With Duplication
select St_FName from Student
Union All
select Ins_Name From Instructor

-- Intersect : To Get Shared Values Between Two Sets
select St_FName from Student
Intersect
select Ins_Name From Instructor

-- Except : To Get Values In First Set And Not Exists in Another Set
select St_FName from Student
Except
select Ins_Name From Instructor

-- Note: To Execute Union Family There Is must Be Compatable Between Two sets As
--1- Equal Number Of Columns
--2- Matching DataTypes Between Each Column

select St_FName , St_Age from Student
Union
select Ins_Name From Instructor -- InValid
-- All queries combined using a UNION, INTERSECT or EXCEPT operator 
-- must have an equal number of expressions in their target lists.

select St_FName , St_Age from Student
Union
select Salary , Ins_Name From Instructor  -- InValid
-- Conversion failed when converting the nvarchar value 'Ali' to data type int.

select St_FName , St_Age from Student
Union
select Ins_Name , Salary From Instructor  -- Valid

--***************************************************************************************************************
--***************************************************************************************************************

-- 7. Select Into &&  Insert Based On Select 
-- DDL (Create - Alter - Drop - Select Into - Insert Based On Select - ............. )

--1- Select Into : Use To Copy Tables
--				 : Structure With Data

Select * Into NewStudentData01
From Student

select St_FName , St_LName , St_Age Into NewStudentData02
From Student

-- Copy Table : Structure Without Data
Select * Into NewStudentData03
From Student
where 1 = 3

Select St_FName , St_LName , St_Age Into NewStudentData04
From Student
where 1 = 4


-- 2- Insert based On Select  : Copy Data Without Structure
Insert Into NewStudentData03
select * From Student

Insert Into NewStudentData04	
select * From Student  -- InValide
-- Column name or number of supplied values does not match table definition.

Insert Into NewStudentData04
select St_FName , St_LName , St_Age From Student 


--***************************************************************************************************************
--***************************************************************************************************************

-- 8. Drop  Vs Delete Vs Truncate

-- Drop     : (DDL) Used to delete DataBase Or Any DB Object (Table - Functions - views - SP - Trigger)

-- Delete   : (DML) Used To delete One Or More Of Rows  - Not Log in LDF  - Low Performance (Delete By Loop)

-- Truncate : (DDL) used To Delete Table And Re-Create It -   Log in LDF  - heigh Performance (Delete All Data one Time)

-- Remember
-- MDF: Mean DataBase File ----> Keep info About Database (DabaseName - TablesName - Who Create it -  Creation Date - Metadata)
-- LDF: Log DataBase  File ----> Store All Transactions Or operations Done On Tables or Any Object Like (Insert - Update - Delete  - .....)


select * from NewStudentData04

Drop Table NewStudentData04		 -- Delete structure & Data
Delete from NewStudentData04	 -- Delete Data Row by Row (loop)
Truncate Table NewStudentData04  -- Delete Data (at One Time)

---***************************************************************************************************************
--***************************************************************************************************************

-- 9. Relationship Rules
		-- 1- Delete Rule
		-- 2- Update Rule 

-- 1- Delete Rule
	-- 1- Delete  
	-- Error 1
	-- The DELETE statement conflicted with the REFERENCE constraint "FK_Department_Instructor". 
	-- The conflict occurred in database "ITI", table "dbo.Department", column 'Ins_Id'.

	-- Error 2
	-- The DELETE statement conflicted with the REFERENCE constraint "FK_Course_Instructor_Instructor". 
	-- conflict occurred in database "ITI", table "dbo.Course_Instructor", column 'Ins_Id'.

		Delete from Instructor
		where Ins_Id = 5

	-- 2- Set Null
		update Department
		set Ins_Id = null  -- Set Null
		where Ins_Id = 5

	-- 3- Update 
	Update Course_Instructor
	set Ins_Id = 6
	where Ins_Id = 5
	

	Create Table Emplyee
	(
		Emp_Id int primary Key Identity(1,1) ,
		Emp_Name varchar(30),
		DNum int references Department(Dept_Id) on Delete Cascade
		-- DNum int references Department(Dept_Id) on Delete Set Null
		-- DNum int references Department(Dept_Id) on Delete Set Default

		-- DNum int references Department(Dept_Id) on Delete Cascade
		-- DNum int references Department(Dept_Id) on Delete Set Null
		-- DNum int references Department(Dept_Id) on Delete Set Default

	)
	-- Note : You Can handel The Relation rules (Delete & Update) 
	--		  by Wizard ----> Stand up on your Relation in DataBase Diagram
	--		  Write click Window (Inser Update & delete)																				



-- 2- Update Rule 

 -- The Same Delete Rule

select * from Instructor
select * from Course_Instructor
select * from Department
----------------------------------------------------------------------
-- 10. Schema:

-- Server		-> DataBase
-- DataBase		-> Schema
-- Schema		-> DB Object [Tables - Functions - Views - SP - Trigger - ......]

-- Dbo [Default DB Schema]

-- Schema Solve Three challanges.

-- 1. U Can't Create More Than One DB Object With the Same Name 
	-- [ Tables - Functions - Views - SP - Trigger - .....]

-- 2. There Is No Logical Meaning (Logical Name) [Under HR - Under Sales - Under CompanyApple ......]

-- 3. DCL (Data Control Language ) Permission

Use ITI 

Create Schema HR

create Table Student(Id Int)  -- Erorr : There is already an object named 'Student' in the DB ITI.

create Table HR.Student(Id Int)

-- Transfar Table Student From HR To Sales
Create Schema Sales

Alter Schema Sales
transfer Student  -- Default dbo.Student

Alter Schema dbo
transfer Sales.Student 

-- Drop Schema 
Drop Schema HR  -- InValid
-- Cannot drop schema 'HR' because it is being referenced by object 'Student'.

Alter Schema Sales
transfer HR.Student 

Drop Schema HR
