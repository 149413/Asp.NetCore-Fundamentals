
-- Part 01:

--1. Create a stored procedure to show the number of students per department.[use ITI DB] 
Use ITI



Create Or alter Proc SP_StudenNumInDepartment
As
	select Dept_Id,count(*) As StudentsNumber
	from Student 
	where Dept_Id is Not Null
	Group By Dept_Id

 SP_StudenNumInDepartment

--2. Create a stored procedure that will check for the Number of employees in 
--the project 100 if they are more than 3 print message to the user “'The number 
--of employees in the project 100 is 3 or more'” if they are less display a message 
--to the user “'The following employees work for the project 100'” in addition to 
--the first name and last name of each one. [MyCompany DB] 
Use MyCompany

Create or alter Proc SP_CheckNumStudentsInProject
With Encryption
As
	Declare @Num int
	Select @Num = count(*)
	From Employee E, Works_for W
	where E.SSN = W.ESSn And W.Pno = 100 

	if(@Num > 3)
		Print 'The number of employees in the project 100 is 3 or more'
	else
		Print 'The following employees work for the project 100'
		Select E.Fname , E.Lname
		From Employee E, Works_for W
		where E.SSN = W.ESSn And W.Pno = 100 

	
 Exec SP_CheckNumStudentsInProject 

--3. Create a stored procedure that will be used in case an old employee has 
--left the project and a new one becomes his replacement. The procedure should 
--take 3 parameters (old Emp. number, new Emp. number and the project 
--number) and it will be used to update works_on table. [MyCompany DB]

Create Or Alter Proc HireNewMngForProject(@OldEmp int, @NewEmp int , @PNum int)
With Encryption
As
	Update W
	set W.ESSn = @NewEmp
	From Works_for W
	where W.ESSn = @OldEmp And W.Pno = @PNum
	 

Exec HireNewMngForProject 968574 , 102672 , 700

-- =======================================================================================
-- =======================================================================================

-- Part 02 :

--1. Create a stored procedure that calculates the sum of a given range of numbers 

Create Or Alter Proc SumArray (@Begin int, @End int,@Icre int , @Sum int output)
As
	set @Sum = 0 
	While(@Begin <= @End )
	Begin
		set @Sum += @Begin
		set @Begin += @Icre
	End


Declare @Sum int
Exec SumArray 1 ,10 , 2, @sum Output
select @Sum

--2. Create a stored procedure that calculates the area of a circle given its 
--Radius 

Create or Alter Proc CircleArea @Radiue int , @CircleArea Float output
As
	Declare @pi Float = 3.14
	set @CircleArea = 4 * @pi * @Radiue*@Radiue

Declare @CArea Float
Exec CircleArea 7 , @CArea output
Select @CArea

--3. Create a stored procedure that determines the maximum, minimum, and 
--average of a given set of numbers ( Note : set of numbers as Numbers = '5, 10, 
--15, 20, 25')

Create Or Alter Procedure ArrayNum (@Array Varchar(80) , @Max int output, @Min int output , @Avg float output)
As
	Declare @Nums Table (Number int)

	Insert into @Nums(Number)
	select Try_Cast(Value As int)
	From String_Split(@Array , ',')
	Where Try_Cast(Value As int) is not Null

	Select @Max = Max(Number) , @Min = Min(Number) , @Avg = Avg(Number)
	From @Nums


Declare @Max int, @Min int , @Avg Float
Exec ArrayNum '5,10,20,25,15' ,@Max output ,@Min output ,@Avg output
Select @Max As Max, @Min As Min, @Avg As Avrage


-- =======================================================================================
-- =======================================================================================

-- Part 03 :

Use ITI 

--1• Create a trigger to prevent anyone from inserting a new record in the 
--Department table ( Display a message for user to tell him that he 
--can’t insert a new record in that table ) 

Create Or  Alter Trigger Tri_AuditOnDepartment
On Department
With Encryption 
Instead of Insert
As
	Select 'U can’t insert a new record in that table'

Insert into Department(Dept_Id ,Dept_Name ,Dept_Location)
Values (100 , 'BS' , 'Mansoura')

--2• Create a table named “StudentAudit”. Its Columns are
--(Server User Name , Date, Note). 
--ServerUserName  -  Date  - Note 
--2.1. Create a trigger on student table after insert to add Row in StudentAudit 
--table  
--• The Name of User Has Inserted the New Student   
--• Date 
--• Note that will be like ([username] Insert New Row with Key = 
--[Student Id] in table [table name] 

Create Table StudentAudit
(
	SUserName VarChar(20),
	_Date date,
	Note Varchar(100)
)

Create Or Alter Trigger Tri_OnStudent
On Student
After Insert
As
	Declare @SId int 
	Select @SId = St_Id from Inserted
	Insert into StudentAudit
	Values(SUSER_NAME() , Getdate() , CONCAT(SUSER_NAME() , ' Insert New Row with Key = ' , @SId , ' In Student Table.'))


Insert into Student(St_Id , St_Fname , St_Address)
Values(80, 'Noha' , 'Cairo')

select * from StudentAudit


--2.2. Create a trigger on student table instead of delete to add Row in 
--StudentAudit table  
--○  The Name of User Has Deleted the New Student 
--○ Date 
--○ Note that will be like “try to delete Row with id = [Student Id]” 

Create Or Alter Trigger Tri_OnStudentV02
on Student
Instead of Delete
As

	Declare @SId int 
	Select @SId = St_Id from Deleted
	Insert into StudentAudit
	Values(SUSER_NAME() , Getdate() , CONCAT('Try to delete Row with id = ' , @SId ))


Delete from Student 
where St_Id  = 70


-- =======================================================================================
-- =======================================================================================

-- Part 04 :


-- 1• Use MyCompany DB
-- Create a trigger that prevents the insertion Process for 
--Employee table in March. 
Use MyCompany

Select * from Employee	

Create Or Alter Trigger Tri_AuditOnEmpolyee
On Employee
Instead of Insert
AS
	If(DateName(MONTH , Getdate()) != 'March')
		Insert into Employee
		Select * from Inserted

	Else
		Select 'U Can Not Insert In March Try Another Month'


--• Create an Audit table with the following structure  
--ProjectNo - UserName  - ModifiedDate - Budget_Old - Budget_New  
--	 p2   -		Dbo     -	2008-01-31 -	95000   -	200000 

--This table will be used to audit the update trials on the Budget 
--column (Project table, IKEA_Company DB) 

--If a user updated the budget column then the project number, 
--username that made that update,  the date of the modification 
--and the value of the old and the new budget will be inserted 
--into the Audit table 

--(Note: This process will take place only if the user updated the 
--budget column)

Use IKEA_Company   

--********** [ Sorry , Not Own IKEA_Company DB To Test ] *******************
Create Table AuditProject 
(
	ProjectNo Int,
	UserName Varchar(20),
	ModifiedDate Date,
	Budget_Old Int,
	Budget_New int
)

Create or Alter Trigger Tri_UpdateBudget
On Project
After Update
As
	Declare @Old int , @New int
	Select @Old_Bud = Budget From Deleted
	Select @New_Bud = Budget From Inserted

	Declare @PNo int
	Select @PNo = PNum From Project

	if(@Old != @New)
		 Insert Into AuditProject
		 Values(@PNo , SUSER_NAME() , Getdate() ,@Old , @New)



Update Poject
set Budget = 200000
where Budget = 95000

-- =======================================================================================
-- =======================================================================================

-- Part 05:
Use MyCompany
--Create a trigger to prevent anyone from Modifying or 
--Delete or Insert in the Employee table ( Display a 
--message for user to tell him that he can’t take any 
--action with this Table).

Create or Alter trigger Tri_NoAuditOnEmployee
On Employee
Instead of Insert , Update , Delete
With Encryption
As	 
	Select ' U Can’t take any action with Employee Table'


