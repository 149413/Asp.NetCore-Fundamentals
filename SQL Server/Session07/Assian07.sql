
--====================================================
-------------------- Part 01 ------------------------- 
--====================================================
--Use ITI DB : 
Use ITI

--1. Create an index on column (Hiredate) that allows you to cluster the data in table Department. 
--What will happen? 

Create NonClustered Index Idx_01
On Department(Manager_hiredate) 

Select * from Department
Where Manager_hiredate = '2000-01-01'
-- Result : 
-- When Search By HireDate The Performance will Improve where search By B-tree (or binary search)  Instead of Linear .
-- Instead of Sort And Store by PK Will Soted by Hiredate which point to Each record to the row 


--2. Create an index that allows you to enter unique ages in the student table. What will happen? 

Select * from Student

Create Unique NonClustered Index Indx_02
On Student(St_Age)
-- Result:
-- After Create Unique Index Not No Allowed To Insert Duplicate Value Of Age

INSERT INTO Student (St_Fname , St_Age)
VALUES ('Ali', 20),
	   ('Mariam', 20);  -- Error

-- Cannot insert duplicate key row in object 'dbo.Student' with unique index 'idx_unique_age'.


--3. Try to Create Login Named(RouteStudent) who can access Only student and Course tables from 
--ITI DB then allow him to select and insert data into tables and deny Delete and update


-- [ In The File  Word] 


--====================================================
-------------------- Part 02 ------------------------- 
--====================================================

-- 1● Try to Create Login With Your Name And give yourself access Only to Employee and Floor tables 
--then allow this login to select and insert data into tables and deny Delete and update (Don't Forget To 
--take screenshot to every step)

