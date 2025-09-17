
--Two Types From DB Object 

--	1. User-Defined Functions 
		-- 1. Scalar Function		: Return One Value
		-- 2. Table-Valued Function : Return Table Value 
			-- 2.1. Inline Function				  (Only One select - Select Based on select)
			-- 2.2. Multi-Statement Table Valued  (More than One select - Select Based On select)

--	2. View 
	-- 1. standard view
	-- 2. Partition View
---------------------------------------------------------------------------------------

-- Functions : DB Object
--			 :  Block Of Query

-- 2. User Defined Function

--Types Of Functions
-- 1. Scalar Function		: Return Just Only One Value
-- 2. Table-Valued Function	: Return Table
	-- 2.1. Inline Table-Valued Functions			:(Return Table Value)		
	-- 2.2. Multistatement Table-Valued Functions	:(Return Table Value)

--Note Functions :  In DB Must Return Value
--	   Functions :  May Take Parameter Or Not

-- Any Functions Consist Of 2:
-- 1. Segnature    (FuncName - Parameters - Return Type)
-- 2. Body (Code)  [ Select Statement - Insert Based On select ]

Use ITI	

-- UDF:
-- 1. Salar Functions : Return Just Only One Value
-- EX01:
-- Create Function That Take Student Id And Return Student Full name 

go
Create Function GetStudentNameById(@St_Id int)
Returns Varchar(50)
begin
	declare @St_Name varchar(50)
	select @St_Name =  St_Fname +  ' ' + St_Lname
	From Student
	where St_Id = @St_Id

	return @St_Name
end
go

select GetStudentNameById(10)  -- InValid
-- 'GetStudentNameById' is not a recognized built-in function name.

-- Note : To Call your UDF Function must Call 
--	      Function By it's SchemaName
select dbo.GetStudentNameById(5)  -- Khalid Moahmed  
Print  dbo.GetStudentNameById(5) --  Khalid Moahmed 
select dbo.GetStudentNameById('10') -- Fady Ali  
select dbo.GetStudentNameById(50) -- NULL
select dbo.GetStudentNameById('Ali') -- Conversion failed when converting the varchar value 'Ali' to data type int.

------------------------------------------------------- 

-- Ex02: Create Fun That Take Deptment Name And Return Name of its Manger

Create Or Alter Function GetDeptManegerByDeptName(@deptName Varchar(50))
Returns Varchar(50)
Begin
	declare @MangName Varchar(50)
	Select @MangName = Ins.Ins_Name 
	From Department D  join Instructor Ins
	On D.Dept_Manager = Ins.Ins_Id And D.Dept_Name = @deptName
	
	return @MangName
End

Print dbo.GetDeptManegerByDeptName('Java') -- Yasmin
Select dbo.GetDeptManegerByDeptName('SD') -- Ahmed
Select dbo.GetDeptManegerByDeptName('Hr') -- NULL

--------------------------------------------------------------------
-- UDF: 2. Table-Valued Functions
--Retun Table Value

-- 2.1. InLine Table-Valued Function
-- Return Table [One Select]

-- Ex 01:
-- Create Funtion That Take Deptment Id And Return All Instructor That
-- Work in this Department

--
Select Ins_Id , Ins_Name , Dept_Id
From Instructor
Where Dept_Id = 10

--Structure Body
go
Create Function FunctionName(Variable DataType)
Returns Table
As Return(
 
	-- U Code
)
go



Create Or Alter Function GetInstructorDataBYDeptId(@did int)
Returns Table 
AS Return(

	Select Ins_Id , Ins_Name , Dept_Id
	From Instructor
	Where Dept_Id =  @did
)

select GetInstructorDataBYDeptId(10) -- InValid
-- 'GetInstructorDataBYDeptId' is not a recognized built-in function name.

select * From GetInstructorDataBYDeptId(10) -- As A Table
select * From GetInstructorDataBYDeptId(20) 
select * From GetInstructorDataBYDeptId(80) -- Empty Table

---------------------------------------------------------------------

-- 2.2. MultiStatement Table-Valued Function 
-- [ Return Table With Logic (if , While , declare var , ...etc)]
-- Ex 02: 
-- Create Function that Take Format [first , Last or Full] And 
-- Return St_Id , St_Name


Create Or Alter Function GetStudentNameBasedOnFormat(@Format Varchar(50))
Returns @t Table (StdId int , StdName Varchar(50))
AS
Begin

		-- Logic (if , While , declare var , ...etc)
	return 
End 

Create Or Alter Function GetStudentNameBasedOnFormat(@Format Varchar(50))
Returns @t Table (StdId int , StdName Varchar(50))
AS
Begin
	if @Format = 'first'
		Insert InTo @T
		select St_Id , St_FName
		From Student
	else if @Format = 'last'
		Insert InTo @T
		select St_Id , St_LName
		From Student 
	else if @Format = 'full'
		insert InTo @T
		select St_Id , St_FName + ' ' + St_Lname
		From Student

	return
End

Select GetStudentNameBasedOnFormat('first') -- InValid
Select * From GetStudentNameBasedOnFormat('first') 
Select * From GetStudentNameBasedOnFormat('last') 
Select * From GetStudentNameBasedOnFormat('full') 


-- Note : U Can Remove The Function code and retrieve it By
--  Stored-Procedure KeyWord [Sp_HelpText] + 'DB ObjectName'

SP_HelpText 'GetDeptManegerByDeptName'
SP_HelpText 'GetInstructorDataBYDeptId'
SP_HelpText 'GetStudentNameBasedOnFormat'

-- ======================================================================================================
-- ======================================================================================================
-- View : DB Object 
--		: Block Of Query 
--Saved Query As A vertual Table 

-- 1. Simplify Query (Usable)
-- 2. Hidden MetaDara[columns - table] (Security)
-- 3. Abstract Logic Of the Query

-- UDF View 
------------------------------
-- 1. Standard View
------------------------------
-- V 01
Create View StuDataCairoView
As
select St_Id  , St_Fname , St_Address
From Student
where St_Address = 'Cairo'

select * from StuDataCairoView

select St_Id , St_Fname
From StuDataCairoView
where St_Fname like 'M%'

---------------------------------------------
-- V 02
Create View StuDataAlexView
As
select St_Id  , St_Fname , St_Address
From Student
where St_Address = 'Alex'

select * from StuDataCairoView
Order By St_Fname

------------------------------------------------
-- V 03
Create or Alter View StudentInDepartmentView
As
Select S.St_Id , S.St_Fname , D.Dept_Id, D.Dept_Name
From Student S , Department D
where D.Dept_Id = S.Dept_Id

select * from StudentInDepartmentView

select * from StudentInDepartmentView
where Dept_Id =10

-----------------------------------------------
-- View With Encryption
-----------------------------------------------
-- 1. To Securate Data We Encrypt View As Following :
SP_HelpText 'StudentInDepartmentView'

Create or Alter View StudentInDepartmentView
With Encryption
As
Select S.St_Id , S.St_Fname , D.Dept_Id, D.Dept_Name
From Student S , Department D
where D.Dept_Id = S.Dept_Id

SP_HelpText 'StudentInDepartmentView'
-- The text for object 'StudentInDepartmentView' is encrypted.

-------------------------------------------------------------------------------------

-- 2. To Secure Meta Data We Give The Columns An alias Name
select * from StudentInDepartmentView

Create or Alter View StudentInDepartmentView (StudentID, Student_Name , DepartmentID , DepartmentName)
With Encryption
As
Select S.St_Id , S.St_Fname , D.Dept_Id, D.Dept_Name
From Student S , Department D
where D.Dept_Id = S.Dept_Id 


select * from StudentInDepartmentView

select * from StudentInDepartmentView
where DepartmentID =10

select * from StudentInDepartmentView
Order by Student_Name

----------------------------------------------------------------------------------


-- U Can Merge Two views OR create  View From SubView

Create Or Alter View StuDataCairoView
As
select St_Id  , St_Fname , St_Address , Dept_Id 
From Student
where St_Address = 'Cairo'  


Create Or Alter View StudentDataView (StudentID, Student_Name , StudentAddress , DepartmentName)
With Encryption
As
select SC.St_Id  , SC.St_Fname , SC.St_Address , D.Dept_Name
From Department D  , StuDataCairoView SC
Where D.Dept_Id = Sc.Dept_Id 

select* from StudentDataView

----------------------------------------
-- 2. Partition View
----------------------------------------
-- More Than One View Meged By Union

Create or Alter View StdCairoAlexView
As
select St_Id  , St_Fname , St_Address
From Student
where St_Address = 'Cairo'

Union All

select St_Id  , St_Fname , St_Address
From Student
where St_Address = 'Alex';


select * from StdCairoAlexView
-----------------------------------------------------
Create or Alter View StdCairoAlexView
As
Select * from StuDataCairoView
Union All
Select * From StuDataAlexView

-----------------------------------------
-- View With DML
-----------------------------------------
-- View => Virtual Table
-- View + DML (Insert - Update - Delete)

select * from StuDataAlexView
Select * from Student
-- Insert
Insert Into StuDataAlexView Values(30 , 'Hossam' , 'Alex') -- Valide
Insert Into StuDataAlexView Values(30 , 'Hossam' , 'Mansoura') -- Valid : Inserted in Table But Not View

Create view StdAge
As
Select St_FName ,St_Age 
From Student

Select * from StdAge
Insert Into StdAge Values('Ali' , 20) -- InValide
-- Cannot insert the value NULL into column 'St_Id', 
-- table 'ITI.dbo.Student'; column does not allow nulls. INSERT fails.

select * from StudentInDepartmentView
select * from Student 
select *from Department

Insert Into StudentInDepartmentView Values(50 , 'Mariam' , 90 ,'HR')  -- InValid
-- Can Not Update More Than one Tables In The Same time

Insert Into StudentInDepartmentView (St_Id , St_FName) Values(50 , 'Mariam')  -- Valid
Insert Into StudentInDepartmentView(Dept_Id , Dept_Name) Values(90 ,'HR')  -- Valid

select * from StuDataAlexView

-- Update
Update StuDataAlexView
set St_Fname = 'Omar'
where St_Id  = 30

-- Delete 
Delete from StuDataAlexView
Where St_Id = 30

-- Note :U Must Insert update Or Delete On Only One Value At Each Time

---------------------------------------
-- View + With Check Option
--------------------------------------
select * from StuDataCairoView

Insert Into StuDataCairoView Values(60 , 'Ola' , 'Cairo') -- Valid
Insert Into StuDataCairoView Values(70 , 'Ola' , 'Alex') -- Valid

-- To Constrain That Use [With Check Option]

Create Or alter View StuDataCairoView
As
	select St_Id  , St_Fname , St_Address
	From Student
	where St_Address = 'Cairo' With check Option

Insert Into StuDataCairoView Values(80 , 'Ola' , 'Cairo') -- Valid
Insert Into StuDataCairoView Values(110 , 'Ola' , 'Alex') -- InValid
-- resulting from the operation did not qualify under the CHECK OPTION constraint.

Update StuDataCairoView
set St_Address = 'Alex'
where St_Id  = 2  -- InValid