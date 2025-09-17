-- Part 01 : USE ITI
USE ITI
--1. Display instructors who have salaries less than the average salary of all 
--instructors.

select Ins_Name , Salary
From Instructor 
Where Salary < (select Avg(Salary)from Instructor)

--2. Display the Department name that contains the instructor who receives 
--the minimum salary 

Select * from Department

select Dept_Name From Department 
where Dept_Id = (Select Dept_Id From Instructor 
where Salary = (Select Min(Salary) from Instructor))

-- Another Sol :Best Performance
Select Dept_Name
from Department D , Instructor Ins
Where D.Dept_Id = Ins.Dept_Id  And Ins.Salary = (Select Min(Salary) From Instructor)


--3. Select max two salaries in instructor table.

--1 By Top
Select Top(2) Salary From Instructor Order By Salary Desc

--2 BY Ranking Function
Select Salary
From (Select Salary , Row_Number() Over (Order By Salary Desc) As RN
From Instructor) As T
Where RN <= 2

--3 By SubQuery
Select Max(Salary) As Salary From Instructor
Union 
Select Max(Salary) From Instructor
Where Salary != (Select Max(Salary) From Instructor)

-- Solustions Order By Height Performance
----------------------------------------------------------------------------------------------------

-- Part 02 : USE MyCompany DB
USE MyCompany
--1. Display the data of the department which has the smallest employee 
--ID over all employees' ID. 

--1 By Top
select Top(1)* From Departments
order by MGRSSN

--2 BY SubQuery
Select * 
from Departments
where MGRSSN = (Select Min(MGRSSN) from Departments)

--2.  Try to get the max 2 salaries using subquery.
 
select Max(Salary)
From Employee
Union 
select Max(Salary) From Employee 
where Salary != (select Max(Salary) From Employee)

--------------------------------------------------------------------------------------------

-- Partt 03 : USE ITI DB
USE ITI

--1. Write a query to select the highest two salaries in Each 
--Department for instructors who have salaries. “Using one of 
--Ranking Functions” 

select * from instructor 

select Salary , Dept_Id From 
(select  Salary , Dept_Id , Rank() over (Partition By Dept_Id order by Salary Desc) As R
From Instructor) As T
Where R <= 2


--2.  Write a query to select a random student from each department. 
--“Using one of Ranking Functions” 

select * From
(
Select St_Fname ,St_Address, St_Age ,Dept_Id  , 
Row_Number() over (partition by Dept_Id Order by NewID()) As RN
From Student
Where Dept_Id is Not Null
) As T
where RN = 1 
-----------------------------------------------------------------------------------------------------------------
-- Part 04 : Adventureworks2012 DB
Use Adventureworks2012

--1. Display only Products(Production schema) with a StandardCost below 
--$110.00 (show ProductID, Name only) 

select ProductNumber , Name from Production.Product
where StandardCost = 110.00

--2. Display all Products with a Silver, Black, or Red Color 

select * from Production.Product
where Color in ('Silver' , 'Black' , 'Red')


--3. Display any Product with a Name starting with the letter B 

select * from Production.Product
where Name like 'B%'

--4. Display the Employees HireDate (note no repeated values are allowed)

select Distinct HireDate from HumanResources.Employee
order by HireDate

--5. Display the Product Name and its ListPrice within the values of 100 
--and 120 the list should have the following format "The [product name] 
--is only! [List price]" (the list will be sorted according to its ListPrice 
--value) 

select Name As [Product Name] , ListPrice [List Price]
from Production.Product
where ListPrice between 100 And 120
Order by [List Price]


--6. Display ProductID, Name if its weight is unknown

select ProductNumber ,  Name , Weight from Production.Product
where Weight is null

