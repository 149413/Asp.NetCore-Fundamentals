use sd
-- Function : Block of Query
-- DRY:
--Function :One Of database obgect 
-- DB Objects: (Tables , Functions , view, SP, Trigger ,.....)
----------------------------------
-- Types of functions In DB :
----------------------------------
-- 1- Scalar Function :  return just One value
-- 2- Table-valued Function : Return Table

-- NOTE :Func in DB must be return Value (one Value - Table)

-- 1- User Defined Function
-- 2- Build-in function

------------------------------------------------------------------------------


 --===================================
--1. build-in Function
--===================================

-- 1. AggregateFunction (Scalar Fun)
-- 2. Null Function
-- 3. Conversion Fun Function
-- 4. Strings function 
-- 5. Date & Time Functions
-- 6. Format Function

--------------------------------------
-- 1- Aggregate Function (Scalar Fun)
--------------------------------------

-- Aggregate Function : ( Avg - sum - Min- Max - count)

-- count (columName or *)
use ITI
use Route
select count(*)  -- 15
From Instructor


select count(salary)  -- 14  (No contain Value)
From Instructor

-- Sum (ColName )
select sum(salary)  -- 974053.00
From Instructor


select count(Ins_Name)  -- InVAalid
From Instructor

-- Avge (colName)

select avg(salary)
From Instructor
 -- 695,575.2121


 select count(Ins_Name)  -- Invalie
From Instructor


-- Max(col Name)

select max(salary) -- Yassmin
From Instructor

select Max(Ins_Name)
From Instructor

-- Min(col Name)

select min(salary)
From Instructor

select min(salary) -- Adel
From Instructor

------------------------------------------------------------------------------
------------------------------------------------------------------------------
-----------------------
-- 2. Null Function
-----------------------
	-- 1. Isnull Func
	-- 2. Coalesce Func

-- Is Null

Select St_FName 
From student

Select St_Id , IsNull(St_FName  , st_LName) 
From student

Select St_Id , IsNull(St_FName  , isNull(St_LName , 'no Name')) 
From student


select Ins_Id , isNull(Salary ,Ins_Name)  -- Invalid  (The data Type must be copatable with each other)
From Instructor
 
select Ins_Id , isNull(Ins_Name , Salary)  -- Valid 
From Instructor

Select St_Id , IsNull(St_Name  , St_Age) -- Valid
From student

-- 2.2- Coalese()

-- Coalesce(P1 , P2 , P3 , ......... ,Pn) returnValue or Null

Select St_Id , Coalesce(St_FName  , St_LName) 
From student

Select St_Id , Coalesce(St_FName  , St_LName,  St_Address, 'No Name') 
From student

------------------------------------------------------------------------------
 
-------------------------------
-- 3. Conversion Fun Function
-------------------------------

-- Casting : Convert from Any DataType to Another Any dataTpye

-- Convert(dataType ,Target)
Select St_FName + ' '+ St_Age   --  XXXX  Must Be compatable (same Data type)
From Student

Select isNull(St_FName,'No Name') + ' ' + isNull(Convert(Varchar(50), St_Age) , 'No Age')  -- Must Be compatable
From Student


Select Coalesce(St_FName,'No Name') + ' ' + isNull(Convert(Varchar(50), St_Age) , 'No Age')  -- Must Be compatable
From Student

-- Cast(Targert As DataType)

Select isNull(St_FName,'No Name') + ' ' + isNull( Cast(St_Age as varchar(50) ) , 'No Name')  -- Must Be compatable
From Student


-- There is another Diffrent Between Cast And Convert 
--When you Convert From DateTime to Varchar() , Convert() May Take Third parameter int (Foramt of Date)

Select GetDate()  --  2025-05-28 23:16:32.813
 
select Cast(GetDate()  as Varchar(Max));   -- May 28 2025 11:16PM
select convert(Varchar(Max) , GetDate());  -- May 28 2025 11:17PM

select convert(Varchar(Max) , GetDate() , 101); -- 05/28/2025
select convert(Varchar(Max) , GetDate() , 102); -- 2025.05.28
select convert(Varchar(Max) , GetDate() , 103); -- 28/05/2025
select convert(Varchar(Max) , GetDate() , 104); -- 28.05.2025

select convert(Varchar(Max) , GetDate() , 108); -- 23:25:18  (Time)
select convert(Varchar(Max) , GetDate() , 113); -- 28 May 2025 23:25:18:923
select convert(Varchar(Max) , GetDate() , 120); --  2025-05-28 23:25:18

select convert(NVarchar(Max) , GetDate(), 130); --  1 ذو الحجة 1446 11:27:15:760PM
select convert(Nvarchar(Max) , GetDate(), 131); --  1/12/1446 11:27:15:760PM


------------------------------------------------------------------------------

 ------------------------
-- 4. Strings function 
------------------------
-- Some Strings Functions
	-- 1. Concat
	-- 2. Upper & Lower
	-- 3. len()
	-- 4. SubString()
	-- 5. DateName()


-- 1. Concate()   =  (Coales() + Convert())

-- convert any Parameter to Varchar() Even Null (Empty String) Then 
-- Concat them
 
Select St_FName + ' '+ ST_LName + St_Age   --  XXXX  Must Be compatable
From Student

Select isNull(St_FName , ' ')  + ' '+ isNull(St_LName , ' ') +' ' + isNull(Convert(Varchar(50) ,St_Age) ,' ')  
From Student

Select Concat(St_FName , ' ', ST_LName ,  ' ' , St_Age)  -- Concat() = Convert() + IsNull()
From Student

-- 2. Upper & Lower
Select Upper(St_FName)
From student


Select Upper('Ahmed')
From student

Select Lower(St_FName)
From student

Select Lower('Ahmed Ali')
 
--3. Le()
Select St_FName , len(St_FName) As [Lenght of Student]
From student

Select len('Ahmed Ali') -- 9


-- 4. Sunstring(()
Select subString('Ahmed Ali' , 2 , 5); -- hmed 

Select ASCII('A'); -- 65
Select ASCII('a'); -- 97

-- 5. DateName() : Display part Of date

Select DATENAME(Year , Getdate())	-- 2025
Select DATENAME(Month , Getdate())  -- June
Select DATENAME(WEEK , Getdate())   -- 26
Select DATENAME(WEEKDAY , Getdate()) --Thursday
Select DATENAME(HOUR , Getdate())	-- 16
Select DATENAME(MINUTE , Getdate()) 

------------------------------------------------------------------------------

-----------------------------
-- 5.Date & Time Functions
-----------------------------

Select sysDateTime();	 -- 2025-05-28 23:40:46.8464402
Select sysUTCDateTime(); -- 2025-05-28 20:40:46.8464402

Select GetDate(); -- 2025-05-28 23:40:46.843

Select DateName(day ,'5/28/2025');		-- 28
Select DateName(weekday ,'5/28/2025');  -- Wednesday

Select day('5/28/2025');	-- 28
Select month('5/28/2025');  -- 5
Select year('5/28/2025');	-- 2025

Select EOMonth('5/28/2025') As [End of Month];  -- 2025-05-31   

Select ISDate('5/28/2025');    -- 1
Select ISDate('28/25/2025');   -- 0



--------------------------------------------------------------------------------------
----------------------
-- 6. Format Function
----------------------
Use MyCompany

Select salary
from Employee

Select Format (salary ,'###,###')
from Employee

-- Setting Temp Format
Select Format (123456 ,'###,###') -- 123,456
Select Format (123456789 ,'###, ### , ###') -- 123, 456,  789
Select Format (123456789 ,'###|### ?###') -- 123|456 ?789

Select Format (GetDate() ,'d') -- 5/29/2025
Select Format (GetDate() ,'dd') -- 29
Select Format (GetDate() ,'ddd') -- Thu
Select Format (GetDate() ,'dddd') -- Thursday

Select Format (GetDate() ,'dddd MM') -- Thursday 05
Select Format (GetDate() ,'ddd MMM') -- Thu May
Select Format (GetDate() ,'ddd MMMM') -- Thu May

Select Format (GetDate() ,'ddd MMM  yy') -- Thu May  25
Select Format (GetDate() ,'ddd MMM  yyyyy') -- Thu May  02025
Select Format (GetDate() ,'dd  MMM  yyyy') -- 29  May  2025
Select Format (GetDate() ,'ddd MM  yyyy') -- Thu 05  2025

Select Format (GetDate() ,'d' , 'en')  -- 5/29/2025
Select Format (GetDate() ,'d' , 'ar')  -- 02/12/46
Select Format (GetDate() ,'dd' , 'ar') -- 02
Select Format (GetDate() ,'dd' , 'en') -- 29
Select Format (GetDate() ,'ddd' , 'en') -- Thu
Select Format (GetDate() ,'dd  MMM  yyyy' , 'en') -- 29  May  2025 (In English)
Select Format (GetDate() ,'ddd MM  yyyy ', 'ar') -- الخميس 12  1446 
Select Format (GetDate() ,'ddd MM  yyyy ', 'fr') -- jeu. 05  2025 

Select Format (GetDate() ,'ddd MM  yyyy hh:mm:tt')			-- Thu 05  2025 12:34:AM
Select Format (GetDate() ,'ddd MM  yyyy  hh:mm:tt', 'en')	-- Thu 05  2025  12:34:AM
Select Format (GetDate() ,'ddd MM  yyyy  hh:mm:tt', 'ar')	-- الخميس 12  1446  12:34:ص
Select Format (GetDate() ,'ddd MM  yyyy  hh:mm:tt', 'fr')	-- jeu. 05  2025  12:34:

--==================================================================================================

--=====================================
-- 2. Some Of Query
--=====================================

-- 1. Group By
-- 2. Top WithTies
-- 3. Random Select

Use ITI

 -- 1. Group By : Split Table to Groups / subtables

 Select Dept_Id, Min(salary)
 from Instructor
 group by Dept_Id

 Select Dept_Id, Min(salary)
 from Instructor
 where salary is Not Null
 group by Dept_Id


Select Dept_Id, Min(salary)
 from Instructor
 where salary is Not Null
 group by Ins_Id;  --- InValide



 Select Dept_Id, Min(salary)
 from Instructor
 where salary is Not Null
 group by * ;  -- Syntax Error



 Select Dept_Id, count(*)
 from Instructor   -- Syntax Error

 -- NOTE : You can not Select Any column with  Aggregate function 
--		As it already generate group , So
--		if U Need To Select any column with The Aggregate function 
--		U Must gruop by with this column (With Each colum)

Select Dept_Id, count(*)
 from Instructor
 group by Dept_Id

Select Dept_Id , count(*)
from Student
where dept_Id is Not null
group by Dept_Id



Select Dept_Id, count(*)
from Instructor
where Count(*) >= 2
group by Dep_Id     -- InValide

-- Having : work With Groups ---> to Set Condition or filter groups
-- where :  Work With Rows   ---> to Set Condition or filter rows
 
Select Dept_Id, count(*)
 from Instructor
 group by Dept_Id
 Having Count(*) >= 2

-- NOTE: U Can Use (Having) With Only Agregate Func witout (group by)

  Select Avg(Salary)
from Instructor
where avg(Salary) > 50000   -- InValide : Can Not Use Where with Aggregate Or Groups


Select Avg(Salary)
from Instructor
having avg(Salary) > 50000
 

 Select Avg(Salary)
from Instructor
having avg(Salary) > 100000


Select Dept_Id , count(*)
from Student 
Where Dept_Id is not null
group by Dept_id

-- Aggregate With Join

Select D.Dept_Name , S.Dept_Id , count(*)
from Student S , Department D
Where S.Dept_Id is not null And D.Dept_Id = S.Dept_Id
group by S.Dept_id , D.Dept_Name


Select D.Dept_Name , S.Dept_Id , count(*)
from Student S , Department D
Where S.Dept_Id is not null And D.Dept_Id = S.Dept_Id  -- P.K = F.K
group by S.Dept_id , D.Dept_Name
having count(*) >= 3

-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------

-- 2.1 Top :used to get Number of record from beginning from Any Table

select Top(5) *
from student 


select Top(5) St_Id , St_Fname , St_Age 
from student 



select Top(5) St_Id , St_Fname , St_Age 
from student 
order by St_Id Desc

 
select Top(5)St_Id , St_Fname , St_Age 
from student 
where ST_Age is not Null
order by St_Age


---------------------------------------------------------------------------------------


-- 2.2 Top WithTies  : if The last  Value is Rapeated , Take it  (Sort Table And Then Top)

select Top(5)St_Id , St_Fname , St_Age 
from student 
where ST_Age is not Null
order by St_Age

select Top(5) with ties St_Id , St_Fname , St_Age 
from student 
where ST_Age is not Null
order by St_Age


select Top(5) with ties St_Id , St_Fname , St_Age 
from student 
where ST_Age is not Null  -- Syntax Erro

-- Note: Top With Ties Must Run With (Order By)

-------------------------------------------------------------------------------
-- 3. Random Select

-- NEWID() --> Generate GUID
-- GUID --> Global Universal ID
-- 32 Digits - character -- 8-4-4-4-12

Select NEWID();  -- BF3DE94E-E151-40BC-9CFB-DE08F44A8110
Select NEWID();  -- D7D83F40-6BED-4CEB-9768-443DF57A28C5
Select NEWID();  -- 846C11E7-D899-4234-BF68-D1C6F0339E9C
Select NEWID();  -- 45F2C6AD-008F-4CF9-B051-C8CAEEC25D8D 


select Top(10)St_Id , St_Fname , St_Age , NEWID() As GUID
from student  

select Top(10)St_Id , St_Fname , St_Age 
from student 
order by NEWID()


select Top(3)St_Id , St_Fname , St_Age 
from student 
order by NEWID()


--------------------------------------------------------------------