 -- Revision

 -- Function  : DB Object
-- Types Of Functions
-- 1. Saclar Function		: Just Only One Value
-- 2. Table_Valued Function : Return Table
	-- 2.1.  InLine Table_Valued Function : Return Table
	-- Body Contain Single Query [Select Statement]
	-- 2.2. MultiStatement Table_Valued FunctionReturn Table
	-- Contain Logic(if , While , declcar Var , ... , etc)
 -- Note: 
 --- 1. Functoin In DB Must return Value
 --- 2. Function In DB May Take Parameters or Not

 -- UDF: 
 --  Any function Consist of 2 :
 --1. Segniture [Name ,Parameter , Return Types]
 --2. Body =>Code [Select Statement - Insert Based On select]
 


 -- 2. View
 -- Saved Query As virtual Table
 -- Select Statemnt
 -- Benfits :
 --1. Simplify Query
 --2. Hiding MetaData
 --3. Abstact Logic Query

-- Types Of View
--1. Standard View
--2. Partationed View
--3. Indexed View

-- View + DML Commands
-- SP_HelpText : disply Text (Query) Which Create The DB Object(View ,....)
-- So U Need When U Create The DB Object To Encrypt It

-- With Check Option

----------------------------------------------------------------------------
-- Stored Procedure : DB Objects

-- Benfits Of SP;
--1. Improve Performance
--2. Strong Security [Hiding MetaData]
--3. Reduce Server Network Traffic
--4. Handle Business Rules
--5. Handle Errors
--6. Accept Input And OutPut Parametrs

Use ITI
-- Ex 01: Create Sp TakeStudent Id And Display Student Data
Drop Proc StuData
Create Or Alter Procedure Sp_GetStuDataById (@SId int)
As
	select * From Student
	where St_Id = @SId
 
 -- Calling Way
 Sp_GetStuDataById 10
 Execute Sp_GetStuDataById 10
 Exec Sp_GetStuDataById 10

-- Note : If The paramater of Stored Procedure is Varaible
--		U Must Call It By Execute KeyWord
declare @Id int = 5
Sp_GetStuDataById @Id -- InValid

declare @Id int = 5
Exec Sp_GetStuDataById @Id  -- Valid

---------------------------------- 
-- SP With Encryption
---------------------------------- 
Sp_HelpText 'Sp_GetStuDataById'

Create Or Alter Procedure Sp_GetStuDataById (@SId int)
With Encryption
As
	select * From Student
	where St_Id = @SId

Sp_HelpText 'Sp_GetStuDataById'
-- The text for object 'Sp_GetStuDataById' is encrypted.


-------------------------------------
-- SP With Schema :- Strong Security
-------------------------------------
Create Schema HR

Alter Schema HR
Transfer Sp_GetStuDataById

Sp_GetStuDataById 1			-- Error
HR.Sp_GetStuDataById 1		-- Valid
Exec HR.Sp_GetStuDataById 1 -- Valid

------------------------------------------------------------
--Ex 02 : 
-- Take Dept Id And Return Instructors Work in it.
Create Or Alter Proc SP_GetInstructorInDept# @DeptId int
with Encryption
As
	Select * from Instructor
	where Dept_Id = @DeptId


 SP_GetInstructorInDept# 10;	
  SP_GetInstructorInDept# '10';	
   SP_GetInstructorInDept# 'Ali'; -- Invalid	



declare @Did int = 20
Exec SP_GetInstructorInDept# @Did;	

---------------------------------------------------
-- SP With Try-Catch : Error Handling
---------------------------------------------------
-- Ex 03 : 
-- Given Topc Id And Delete This Topic

Create Or Alter Proc SP_DeleteTopic @TopId int
As
	Begin Try
	-- Code
		Delete From Topic
		where Top_Id = @TopId
	End Try 
	Begin Catch
	-- Code : Will Be Executed When Query In Try Block is Failed
		Print 'U Can Not delte This Ya Handasa'
	End Catch


 SP_DeleteTopic 1


 ---------------------------------
 -- Insert based In Execute
 ---------------------------------

 -- Ex 04 :
 -- Create New Table (StudentWithAddress) And Insert Into Student in SP StudentInAddress 'Cario'

 Create Or Alter Proc SP_StudentInAddress @Address varchar(20)
 With Encryption
 As
	Select St_Id , St_Fname , St_Address
	From Student
	where St_Address = @address


SP_StudentInAddress 'Cairo'


Create Table StudentWithAddress
(
	St_Id int Primary Key,
	St_Name Varchar(20) ,
	St_Address Varchar(20)
)


Insert Into StudentWithAddress
Exec SP_StudentInAddress 'Cairo'


select * from StudentWithAddress
-------------------------------------------
-- InPut Output Parameter
-------------------------------------------

-- Passing Parameter 
------------------------------
Create or alter Proc SP_SubtractData @X int = 4 , @Y int = 1
With Encryption 
As
	Select @X - @Y

-- Passing Ways
	SP_SubtractData 2 , 3			-- Passing By Order
	SP_SubtractData @X = 3 , @Y = 2 -- Passing By Name
	SP_SubtractData 2				-- Default Value
	SP_SubtractData @Y = 12			-- Default Value
	SP_SubtractData					-- Default Value



-- OutPut Parameter :Return Value From stored Procedure
-------------------------------------------------------
Create or Alter Proc SP_GetStudentNameAndAgeByID @Id int , @Age int output, @Name Varchar(20) output
With Encryption
As
	Select @Name = St_FName , @Age = St_Age
	From student
	where St_Id = @Id


Declare @age int , @Name int 
declare @id int = 1

Exec SP_GetStudentNameAndAgeByID @id , @age , @Name

select @Age as Age, @Name As Name;  -- (NULL - NULL) InValid Logic


Declare @age int , @Name Varchar(30)
declare @id int = 1

Exec SP_GetStudentNameAndAgeByID @id , @age output, @Name output

select @Age as Age, @Name As Name; -- (22 - Ahmed) [Valid]

---------------------------------------------------------
-- Input Output Parameter : A Parameter Can Be Used Input And Output In the same time 

Create or Alter Proc SP_GetStudentNameAndAgeByIDV02 @Var int output, @Name Varchar(20) output
With Encryption
As
	Select @Name = St_FName , @Var = St_Age
	From student
	where St_Id = @Var

-- Note : Where (Execute) First And Then (Select)

Declare @Var1 int = 1,@Var2 Varchar(20) 

Exec SP_GetStudentNameAndAgeByIDV02 @Var1 output, @Var2 output

Select @Var1 As Age, @Var2 As Name

---------------------------------------
-- Functions Vs View Vs SP
---------------------------------------

------------------| -------------------------------------------------------------------------------------------
--				  |		Functions						View						SP
------------------|---------------------------------------------------------------------------------------------
--	 Usability && |		Yes 							Yes							Yes		
--   Performance  |																				
------------------|---------------------------------------------------------------------------------------------
--	 Body		  |		Select Statement				Only Select Statement		Any Thing									
--                |		Insert Based On Select																		
------------------|--------------------------------------------------------------------------------------------
--	 Parameter	  |		Optional✅ 			Not Take					May Or Not Take Parameter									
--                |										  										
------------------|--------------------------------------------------------------------------------------------
--	Return Value  |		Must ruturn Value				Not Return Thing			May Return Or Not										
--                |		(One Or Table Value)			(Just Only Diplay Value)	(Like Programming Function)														
------------------|---------------------------------------------------------------------------------------------
--	Return Value  |		Can Not Full Variable			Can Not						Yes ,  					
--  Inside Varible|																	By (InPut OutPut Parameter)				
------------------|--------------------------------------------------------------------------------------------
--Encryption Table|		Can Not							Yes ,By(With Encruption)	Yes ,By(With Encruption)								
-- && MetaData	  |		Can Not							Yes , Naming Columns 		Yes , Naming Columns 									
------------------|--------------------------------------------------------------------------------------------

-- Note : SP Not Actually Return Value But We Do That By OUTPUT Variable 
--		: SP Can Not Return Table  ??!! (Search About that)

---------------------------------------- 
-- Trigger : SPecial Type Of SP
----------------------------------------
-- Types Of SP:
-- 1. Build-in SP
-- 2. User-Defined SP
-- 3. Trigger
			-- 1. Can't Call It
			-- 2. Not Take Parameter 

-- Trigger Will Fire When An Even Occure

-- 1. Server Level
-- 2. DB Level
-- 3. Table Or View Level

-- Trigger Execute After Or Instead Of The Actions
-- Actions (Only)
-- 1. Insert
-- 2. Update 
-- 3. Delete
 

Create Or Alter Trigger Tri_Welcom
On student
After Insert 
As
	Select 'Welcom In ITI Ya Handasa :)'


Insert Into Student(St_Id , St_Fname ,St_Address,Dept_Id)
Values(40 ,'Ali' ,'Cairo' , 30)



Create Or  alter Trigger Tri_UpdateData
On Student
with Encryption
After Update
As
	Select  SUSER_NAME() , GetDate() As UpdateOn


Update Student
set St_Fname = 'Omar'
where St_Id = 40




Create Or  alter Trigger Tri_UpdateData
On Student
with Encryption
Instead Of Delete
As
	Select 'U Can Not Delete This Ya Handasa'


Delete from Student
where St_Id = 1




Create Or  alter Trigger Tri_UpdateDatav
On Student
with Encryption
For Delete
As
RollBack Transaction
	Select 'U Can Not Delete This Ya Handasa :('

Delete from Student
where St_Id = 50




 -- Prevent Insert, update , Delete From Table Department
 go
 Create or alter Trigger Tri_DisableDMLOnDepartment
On Department
with Encryption
Instead of Insert , Update , Delete
 
 As
	Select 'U Can Not Any DMLCommands On Department Table :('
	
go

Update Department
set Dept_Name = 'HR'
Where Dept_Id = 70

select * from Department
--------------------------------------
-- Enable && DisAble Trigger
--------------------------------------

-- 1. Way
Alter Table Department
DisAble Trigger Tri_DisableDMLOnDepartment

Alter Table Department
Enable Trigger Tri_DisableDMLOnDepartment


-- 2. Way
Disable Trigger Tri_DisableDMLOnDepartment
On Department

Enable Trigger Tri_DisableDMLOnDepartment
On Department

-----------------------------------------------
-- The Most Iportant Point On Trigger
-----------------------------------------------
-- When Fire The Trig ger The Two Table Will Be Created In ReturnTime 
-- Inserted Table
-- Deleted table

-- Inserted: Inserted Table Will Be Contain The Inserted Row
-- Deleted : Deleted  Table Will Be Contain The deleted  Row
-- Updated : Inserted Table Will Be Contain The Inserted Row
--		   : Ddeleted Table Will Be Contain The  deleted Row


Create Or Alter Trigger AuditCourse
On Course
With Encryption
After Update
As
	Select * from  Inserted
	Select * from  Deleted

	Update Course
	set Crs_Duration = 30
	where Crs_Id= 100


Create Or alter Trigger DisableDeleteOnTopics
On Topic
with Encryption 
instead Of Delete
As
	Select CONCAT(
			'U Can Not DeleteTopic With ID = ' ,
			(select Top_Id From deleted) , ' With Topic Name : ' ,
			(select Top_Name from Deleted) )


Delete From Topic
Where Top_Id = 1  
--U Can Not DeleteTopic With ID = 1 With Topic Name :Programming


Create Or Alter Trigger DisabletelteOnCourse 
on Course
With Encryption
Instead of Delete
As	
	If(DateName(WEEKDAY ,GetDate()) != 'Thursday')
		delete from Course
		where Crs_Id in (Select Crs_Id from Deleted)
	else
		Select 'U Can Not Delete Course On TuesDay'


Delete From Course
where Crs_Id = 100


