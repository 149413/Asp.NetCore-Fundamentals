
--==========================================================================
----------------------------------  Exam P02    -----------------------------
--==========================================================================
Use Library
--==========================================
---Try To Write The Following Queries :  
--==========================================

--1. Write a query that displays Full name of an employee who has more than 
--3 letters in his/her First Name.{1 Point}  

Select Concat(FName , '  ' , LName) As [Full Name] 
from Employee
Where len(FName) > 3

--2. Write a query to display the total number of Programming books 
--available in the library with alias name ‘NO OF PROGRAMMING  
--BOOKS’ {1 Point}  

Select Count(*) As [NO OF PROGRAMMING BOOKS]
from book B , Category Cat
Where B.Cat_Id = Cat.Id And Cat.Cat_name = 'programming ' 
 

--3. Write a query to display the number of books published by  
--(HarperCollins) with the alias name 'NO_OF_BOOKS'. {1 Point} 

Select count(*) As NO_OF_BOOKS
From Book B , Publisher P
Where B.Publisher_Id = P.Id And P.Name = 'HarperCollins'

-- 4. Write a query to display the User SSN and name, date of borrowing and due date of 
--the User whose due date is before July 2022. {1 Point}  

Select * from Users
Select U.SSN , U.User_Name , Borrow_Date , Due_Date 
From Borrowing Borr , Users U 
Where U.SSN = Borr.User_ssn And Due_date < 'July 2022'


--5. Write a query to display book title, author name and display in the 
--following format,  
--' [Book Title] is written by [Author Name]. {2 Points} 


Select Concat(B.Title , ' is written by ' , A.Name) as [Book Title is written by Author Name]
From Book B , Author A  , Book_author Ba
Where B.Id = Ba.Book_Id And A.Id = Ba.Author_Id

--6. Write a query to display the name of users who have letter 'A' in their 
--names. {1 Point}  

Select User_Name
From users
Where User_Name Like '%A%'


--7. Write a query that display user SSN who makes the most borrowing{2  
--Points}  

Select SSN , User_name
From ( Select U.SSN , U.User_name , Row_Number()
		Over (order by  DAteDiff(day ,  Borrow_date , Due_Date) Desc) As RN
		From Users U , Borrowing Bo
		Where U.SSN = Bo.User_ssn 
	  ) As T
Where RN = 1


--8. Write a query that displays the total amount of money that each user paid 
--for borrowing books. {2 Points}  

Select U.SSn , U.User_Name , bo.Amount
From Users U , Borrowing bo
Where U.SSN = bo.User_ssn

--9. write a query that displays the category which has the book that has the 
--minimum amount of money for borrowing. {2 Points}  

Select Cat_Name , Amount
From(
		Select Cat.Cat_Name , bo.Amount , Row_Number() over (order by bo.Amount) as RN
		From Category cat , Book B , Borrowing bo
		Where Cat.Id = B.Cat_Id And B.Id = bo.Book_Id
	) As T
Where RN = 1


--10.write a query that displays the email of an employee if it's not found, 
--display address if it's not found, display date of birthday. {1 Point} 

Select Coalesce(Email , Address ,Convert( Varchar(20), DOB))
from Employee	


--11. Write a query to list the category and number of books in each category 
--with the alias name 'Count Of Books'. {1 Point}  

Select Cat_Name , Count(B.Id) As [Count of Book] 
From Book B, Category Cat
Where Cat.Id = B.Cat_id
Group by Cat_Name

--12. Write a query that display books id which is not found in floor num = 1 
--and shelf-code = A1.{2 Points}  


Select B.Id ,Sh.Code
From Book B , Shelf Sh , Floor F
Where F.Number =  Sh.Floor_num And sh.Code = B.Shelf_code 
And sh.Floor_num != 1 And F.Number != 1 And B.Shelf_code != 'A1' 


--13.Write a query that displays the floor number , Number of Blocks and 
--number of employees working on that floor.{2 Points} 

Select F.Number , count(Num_Blocks) [Num of Blooks] , count(E.id) As [Number of Employee]
From Employee E , Floor F
Where F.Number = E.Floor_no
Group by F.Number

--14.Display Book Title and User Name to designate Borrowing that occurred 
--within the period ‘3/1/2022’ and ‘10/1/2022’.{2 Points}  

Select B.Id , U.User_name 
From Book B , Borrowing Bo, Users U
Where b.Id = Bo.Book_Id And U.SSn = Bo.User_ssn
And Borrow_Date Between '3/1/2022' And '10/1/2022'

--15.Display Employee Full Name and Name Of his/her Supervisor as  
--Supervisor Name.{2 Points}  

Select Concat(Emp.FName ,'  ' , Emp.LName) As [FullName] , Supr.FName
From Employee Emp , Employee Supr
Where Emp.Super_Id = Supr.id

--16.Select Employee name and his/her salary but if there is no salary display  
--Employee bonus. {2 Points}  

Select FName , IsNull(Salary, Bouns) As Salary
from Employee 

--17.Display max and min salary for Employees {2 Points}  

Select Max(Salary) As MaxValue, Min(Salary) MinValue
From Employee


--18.Write a function that take Number and display if it is even or odd {2 Points}  

Create Or Alter Function CheckNumber (@Num int)
Returns Varchar(20)
begin
	Declare @Msg Varchar(20)
	If @num % 2 = 0
		Set @Msg = 'The Number is Even'
	Else
		Set @Msg = 'The number Is Odd'

	return @Msg
End

Select dbo.CheckNumber(-3)

--19.write a function that take category name and display Title of books in that 
--category {2 Points}  

Create Or Alter Function GetBookTitleOfCategory (@Catg Varchar(20))
Returns Table
As Return
(
	Select B.Title
	From Book B, Category Cat
	Where Cat.Id = B.Cat_Id And Cat_Name = @Catg
)
 Select * from GetBookTitleOfCategory ('programming ')


--20. write a function that takes the phone of the user and displays Book Title , 
--user-name,  amount of money and due-date. {2 Points}  


Create Or Alter Function GetDataOfuserBorrowingBook (@User_Phone Varchar(30))
Returns Table
As Return 
(
	Select B.Title , U.User_name ,  bo.Amount , Due_Date
	From Book B, Borrowing bo , Users U 
	Where B.id = bo.Book_Id And U.SSN = bo.User_ssn 
	And U.SSN = (Select User_SSn From User_Phones Where Phone_Num = @User_Phone)
)

Select * from GetDataOfuserBorrowingBook ('0265511122')

--21.Write a function that take user name and check if it's duplicated  
--return Message in the following format ([User Name] is Repeated 
--[Count] times) if it's not duplicated display msg with this format [user 
--name] is not duplicated,if it's not Found Return [User Name] is Not  
--Found {2 Points} 

Create Or alter Function CheckFoundedOfUseName (@User_Name Varchar(20))
Returns Varchar (100)
Begin
	Declare @Msg Varchar (100)
	Declare @countRepeat int

	Select @countRepeat = count(*)
	from Users 
	Where User_name = @User_Name
	
	if @countRepeat > 1
		Select @Msg = concat(@User_Name ,' is Repeated ' , @countRepeat , ' Times.')
	Else if @countRepeat = 1
		Select @Msg = concat(@User_Name ,' is Not Dplicated.')
 	Else
		select @Msg = concat(@User_Name ,' is Not Found.')
 
	Return @Msg
End

--Test
Select dbo.CheckFoundedOfUseName ('Salma Osama') -- Salma Osama is Repeated 4 Times.
Select dbo.CheckFoundedOfUseName ('Rawan Walid') -- Rawan Walid is Not Dplicated.
Select dbo.CheckFoundedOfUseName ('Lino Sam')    -- Lino Sam is Not Found.



--22.Create a scalar function that takes date and Format to return Date With  
--That Format. {2 Points}  

Create Or alter Function GetDateWithFormat (@Date Date , @Format Varchar(20))
Returns Varchar(30)
begin
	Declare @res Varchar(30)
	Select @res = Format( @Date , @Format)

	return @res
End

Select dbo.GetDateWithFormat(GetDate() , 'ddd MM yyy')

--23.Create a stored procedure to show the number of books per Category.{2 Points}  

create Or Alter Proc SP_GetNumberOfBooks 
As
	Select Cat_Name ,count(B.Id) As [Num of Books]
	From Book B , Category Cat
	where Cat.Id = B.Cat_Id
	Group by Cat_Name

SP_GetNumberOfBooks

--24.Create a stored procedure that will be used in case there is an old manager 
--who has left the floor and a new one becomes his replacement. The 
--procedure should take 3 parameters (old Emp.id, new Emp.id and the 
--floor number) and it will be used to update the floor table. {3 Points}  

create Or Alter Proc SP_AuditMangOfFloor @OldEmp int , @NewEmp int , @FNum int  
As
	Update Floor
	set MG_Id = @NewEmp
	Where MG_ID = @OldEmp and Number = @Fnum



--25.Create a view AlexAndCairoEmp that displays Employee data for users 
--who live in Alex or Cairo. {2 Points}  

Create Or Alter View V_GetStudDataInAlex_Cairo
As
	select * 
	from Employee
	Where Address in ('Alex' , 'Cairo')

select * From V_GetStudDataInAlex_Cairo

--26.create a view "V2" That displays number of books per shelf {2 Points} 

Create or Alter View V2
As
	Select Shelf_code ,Count(*) [Num of Books]
	From Book
	Group by Shelf_Code


select * from V2
Order By [Num of Books] Desc

--27.create a view "V3" That display  the shelf code that have maximum 
--number of  books using the previous view "V2" {2 Points}  

Create Or Alter view V3
As 
	Select Top(1) Shelf_code
	 From V2
	 Order By [Num of Books] Desc

Select * from V3

--28.Create a table named ‘ReturnedBooks’ With the Following Structure :  
--User SSN   - Book Id   - Due Date    Return Date   - fees  
  
-- then create A trigger that instead of inserting the data of returned book  
-- checks if the return date is the due date  or not if not so the user must pay 
-- a fee and it will be 20% of the amount that was paid before. {3 Points} 

Create Table ReturnedBooks
(
	User_SSN Int ,
	Book_Id Int ,
	Due_Date Date ,
	Return_Date Date ,
	Fees  int 
	Primary Key(User_SSN, Book_Id)
)


Create Or Alter Trigger Tri_CheckDue_Time
On ReturnedBooks
instead of insert
As
 
	Declare @Amount int
	Select @Amount = Amount From Borrowing
	Where User_ssn = (Select User_SSN From inserted) And Book_id = (Select Book_id From inserted)
 
	Declare @Rtn_Date Date , @Due_date Date
	Select @Rtn_Date = Return_Date , @Due_date = Due_Date 
	From inserted


		insert into ReturnedBooks
		Select * from inserted

	if @Rtn_Date > @Due_date
	begin
		Update ReturnedBooks
			set Fees += @Amount * .20
			where Due_Date = @Due_date And Return_Date = @Rtn_Date

	End
-- Test
--1
Insert into ReturnedBooks Values
(5	, 1 , '2022-03-24' , '2022-03-24' , NULL)

--2
Insert into ReturnedBooks Values
(5 , 21 , '2023-08-02' , '2023-08-04', NULL)

--3
Insert into ReturnedBooks Values
(9 , 4 , '2022-03-29' , '2022-03-27', NULL)


Select * from ReturnedBooks
 


-- 29.In the Floor table insert new Floor With Number of blocks 2 , employee 
--with SSN = 20 as a manager for this Floor,The start date for this manager 
--is Now. Do what is required if you know that : Mr.Omar Amr(SSN=5) 
--moved to be the manager of the new Floor (id = 7), and they give Mr. Ali  
--Mohamed(his SSN =12) His position . {3 Points} 

go
Insert into Floor Values(7,2,20, GetDate())

Update Floor
	set Mg_ID = 5
	Where number = 7 And MG_ID = 20

Update Floor
	set Mg_ID = 12
	Where MG_ID = 5

Select * from Floor

go
-- 30.Create view name (v_2006_check)  that will display Manager id, Floor 
-- Number where he/she works , Number of Blocks and the Hiring Date 
-- which must be from the first of March and the end of May 2022.this view 
-- will be used to insert data so make sure that the coming new data must 
-- match the condition then try to insert this 2 rows and  

-- Mention What will happen {3 Point}  
-- Employee Id  - Floor Number  - Number of Blocks   -  Hiring Date  
--		6	    -		4		-		2			 -	  7-8-2023  
--		4	    -		7		-		1			 -    4-8-2022 
 
 Create Or Alter View v_2006_check
 As
	Select MG_ID , Number , Num_Blocks , Hiring_Date
	From Floor
	Where Month(Hiring_Date) between 3 And   5 And Year(Hiring_Date) = 2022 With Check Option



Insert into v_2006_check Values(6 , 40 , 2 ,  '7-8-2023') -- InValid
-- The attempted insert or update failed because the target view either specifies WITH CHECK OPTION
Insert into v_2006_check Values(4 ,70, 1 , '4-8-2022 ') -- Valide

Select * from v_2006_check

-- 31.Create a trigger to prevent anyone from Modifying or Delete or Insert in 
-- the Employee table ( Display a message for user to tell him that he can’t 
-- take any action with this Table) {3 Point}  

Create Or alter Trigger Tri_NotAuditTable
On Employee
Instead of Insert , Update , Delete
As
	Select 'You Can’t  take Any Action With Employee Table.' As [Warnning Massage]

-- Test
Delete from Employee 
Where id = 1

Update Employee 
Set FName = 'Ali'
Where FName = 'Amr'


--32.Testing Referential Integrity , Mention What Will Happen When:  

--===========================================================
-- A. Add a new User Phone Number with User_SSN = 50 in  
-- User_Phones Table {1 Point}  
--============================================================
 
Insert into User_Phones Values(50 , '01062621230')

-- There is confflect With FOREIGN KEY constraint "FK_User_phones_User".
-- As User SSN not Exist


--=====================================================================
-- B. Modify the employee id 20 in the employee table to 21 {1 Point}  
--=====================================================================

Update Employee
	set id = 21
	where id = 20

-- WithOut Trigger : Cannot update identity column 'Id'.
-- With Trigger	   : You Can’t  take Any Action With Employee Table. 


--===============================================
-- C. Delete the employee with id 1 {1 Point}  
--===============================================

Delete From Employee
where id = 1

-- Warnning Massage : You Can’t  take Any Action With Employee Table.


--==============================================
-- D. Delete the employee with id 12 {1 Point}  
--==============================================

Select * from Employee

Delete From Employee
where id = 12

-- WithOut Trigger : The DELETE statement conflicted with the REFERENCE constraint "FK_Borrowing_Employee". 
--					The conflict occurred in database "Library", table "dbo.Borrowing", column 'Emp_id'.

-- With Trigger	   : You Can’t  take Any Action With Employee Table. 


--=============================================================================
-- E. Create an index on column (Salary) that allows you to cluster the 
-- data in table Employee. {1 Point} 
--=============================================================================

Create NonClustered Index Idx_01
on Employee(Salary)


-- 33.Try to Create Login With Your Name And give yourself access Only to 
-- Employee and Floor tables then allow this login to select and insert data 
-- into tables and deny Delete and update (Don't Forget To take screenshot 
-- to every step) {5 Points} 
 
Create Schema HR

Alter Schema HR
Transfer Employee

Alter Schema HR
Transfer Floor

Select * from Employee

use Library
Select * from HR.Employee


-- Look File Word


