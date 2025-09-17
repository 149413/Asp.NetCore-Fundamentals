
-- Part 01 : Use ITI DB
Use ITI

--1. Create a scalar function that takes a date and returns the Month name 
--of that date. 

Create Or alter Function _Month(@Date date)
Returns Varchar(50)
begin
 	return DateName(Month , @Date)
End

Select dbo._Month(GetDate())
Select dbo._Month('8/16/2025')

--2. Create a multi-statements table-valued function that takes 2 integers 
--and returns the values between them. 

Create Or alter Function GetNumBetween(@Begin int , @End int)
Returns @T Table (Num int)
As
begin
	 Declare @i int = @begin
	 while @i != @End + 1
	 begin
			Insert Into @t
			select @i
			set @i += 1
	end
	return
End

select * from GetNumBetween(-5,15)

--3-. Create a table-valued function that takes Student No and returns 
--Department Name with Student full name. 

Create Function GetStuDate(@St_Id int)
Returns Table
As Return(
	select D.Dept_Name ,  S.St_Fname + ' ' + S.St_Lname As FullName
	From Student S , Department D
	where S.Dept_Id = D.Dept_Id And S.St_Id = @St_Id 
)

select * from GetStuDate(10)

--4.Create a scalar function that takes Student ID and returns a message to 
--user 
--a. If first name and Last name are null, then display 'First name & last 
--name are null.' 
--a. If First name is null, then display 'first name is null' 
--a. If Last name is null, then display 'last name is null.' 
--a. Else display 'First name & last name are not null' 
go
Create Or Alter Function GetStudentData(@St_Id int)
Returns Varchar(50)
begin
	Declare @FName Varchar(50)
	declare @LName Varchar(50)
	Select @FName = St_Fname , @LName = St_LName
	From Student 
	Where St_Id = @ST_Id

	declare @Massage Varchar(50)
	
	If @FName is Null And @LName is null
		set @Massage = 'First name & last name are null.'
	else If @FName is Null
		set @Massage = 'first name is Null.'
	else If @LName is null
		set @Massage = 'last name is null.'
	else
		set @Massage =  'First name & last name are Not null.'

	return @Massage
End
go

--6. Create function that takes project number and display all employees 
--in this project (Use MyCompany DB)
Use MyCompany


select 


Create or Alter Function GetEmplyeeDataInProject(@PNum int)
Returns Table
As Return(
	select E.SSN , E.Fname , E.Address , E.Salary , P.Pnumber , W.Pno
	From Employee E , Project P , Works_for W
	Where E.SSN = W.ESSn And W.Pno = @PNum And P.Pnumber = @PNum
)

--===================================================================================
--===================================================================================
-- Part 02 : Use ITI DB: 

--Note : # means number and for example d2 means department which has id or 
--number 2

Use ITI 
--1. Create a view that displays the student's full name, course name if the 
--student has a grade more than 50. 
Drop view GetStdFullName
Create or Alter view GetStdFullNameView
As
select St_Fname + ' ' + St_Lname As fullName , c.Crs_Name 
From Student S ,  Course C , Stud_Course SC
where S.St_Id = SC.St_Id And C.Crs_Id = Sc.Crs_Id
And Sc.Grade > 50

select * From GetStdFullNameView

--2. Create an Encrypted view that displays manager names and the topics 
--they teach. 

Create Or alter View GetTopicManagerView
As
select I.Ins_Name , T.Top_Name
From Instructor I , Course C , Ins_Course IC , Topic T
where I.Ins_Id = IC.Ins_Id And C.Crs_Id = IC.Crs_Id And T.Top_Id = C.Top_Id 

select *from GetTopicManagerView

--3. Create a view that will display Instructor Name, Department Name for the 
--‘SD’ or ‘Java’ Department “use Schema binding” and describe what is the 
--meaning of Schema Binding 
create Or alter View GetInsNameInDeptView
With SchemaBinding
As
select I.Ins_Name As InsctorName , D.Dept_Name As DepartmentName
from dbo.Instructor I , dbo.Department D
Where I.Dept_Id = D.Dept_Id

select * from GetInsNameInDeptView
where DepartmentName in ('SD' , 'Java')

 --SCHEMABINDING in SQL Server – In Brief  ??

--SCHEMABINDING is an option used when creating views or scalar functions to bind them 
--to the structure (schema) of the underlying tables or views they reference.

-- 1. It prevents changes to the underlying tables (like dropping or altering columns) 
--as long as the view/function exists.

-- 2. Requires fully qualified table names (e.g., dbo.TableName).
-- Note : U Must  Mention Sechma Of Each Instructor



--4. Create a view “V1” that displays student data for students who live in 
--Alex or Cairo. 
--Note: Prevent the users to run the following query 
--Update V1 set st_address=’tanta’ 
--Where st_address=’alex’;

Create Or alter View V_GetStdInCairoOrAlex
As
select *
From Student
where St_Address in ('Cairo' , 'Alex') With Check Option

select * from V_GetStdInCairoOrAlex


-- use IKEA_Company_DB:
----------------------------------------------------------------------
-- Can Not Restore IKEA_Company_DB  As I Version 2019 ???????????????
---------------------------------------------------------------------

use IKEA_Company_DB

--1. Create view named “v_count “ that will display the project name and the 
--Number of jobs in it 
Create View V_count 
As
select PNum , JobNum
From project 


--2. Delete the view “v_count” 

Drop V_count


--3. Create view that will display the emp# and emp last name who works on 
--deptNumber is ‘d2’ 

Create View V_Employee
As
	Select ESSN ,  Emp_LName
	From Employee
	Where Dept_Num = 2

--4. Create view named “v_dept” that will display the department# and 
--department name 
Create view v_dept
As
	Select Dept_Num ,Dept_Name
	From Employee

--5. Create view name “v_2006_check” that will display employee Number, 
--the project Number where he works and the date of joining the project which

Create View v_2006_check
as
	Select E.ESSN , P.PNum ,W.Hiring_Date
	From Employee E , Project P , Work_for W
	where E.ESSN = W.ESSn And P.PNum = W.PNum


