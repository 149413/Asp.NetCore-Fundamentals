
-- Revision
	-- 1. Stored Procedure :DB Object
	-- 2. Trigger :(Special SP) 
		--Types of Trigger :
			--1. Server Level
			--2. DB Level
			--3. Table & View Level 
		-- Actions (Insert j-Update - Delete)
		-- After		-----> Actions
		-- Instead Of	-----> Actions

-- -- Execution Query Cycle :
   -- Any Query Take Three Stips To Implemnt

-- 1. Parsing Sentax (Check Syntax Of Query)
-- 2. Atomize Metadata (Chec MetaData)
-- 3. Query Tree (Execution Orderd Query)
-- 4. Execution Plan (Query) [Execute The Query on Sql server]


-- Note: Some DB Object (Function - Veiw - SP) Encapsolate The First Three Steps
--	   : From Execution Query Cycle Which Improve The Performance where Implemnt tat Only One Time

-----------------------------------------------------------------------------------------------------------

-- Types of DB

-- 1. DDL  (Create - alter - Drop)			 -- Done
-- 2. DML  (Select - Insert Based On Select) -- Done 
-- 3. DQL  (InSet - Update - Delete )		 -- Done

-- 4. TCL : Transaction Control Language
-- 5. DCL : Data Control Language


-- TCL : (Begin - commit - RollBack)

---- 1. Implicit   Transaction (Single DM L=>  Insert - Update - Delete)
Use Route
Insert into Student(St_Id ,St_Fname , St_Age ) Values(102222,'Ahmed' , 20)

--- 2. Exeplicity Transaction (Set Of Implicit Transaction)

Create Table Parent
(
	ParentId int primary Key
)

Create Table Child
( 
	ChildId int Primary Key ,
	ParentId int


) 

Alter table Child Add 
Foreign Key (ParentId)  references Parent(ParentId)

Insert into Child Values(1 , 1)
Insert into Child Values(2 , 13) -- Error
Insert into Child Values(3 , 3)

-- Control Transaction 
go
Begin Transaction 
--- Exeplicity Transaction (Set Of Implicit Transaction)
Commit | Rollback Tran
go

-- Commit Transaction
Begin Transaction
Insert into Child Values(1 , 1)
Insert into Child Values(2 , 13) -- Error
Insert into Child Values(3 , 3)
Commit Tran
-- Rollback Transaction
Begin Transaction
Insert into Child Values(1 , 1)
Insert into Child Values(2 , 13) -- Error
Insert into Child Values(3 , 3)
Rollback Tran

-- TCL + Try Catch

Begin Try
Begin Transaction
	Insert into Child Values(1 , 1)
	Insert into Child Values(2 , 3) -- Error
	Insert into Child Values(3 , 3)
Commit Transaction
End Try
Begin Catch
	RollBack Tran
End Catch



Select *from Child

Delete from child

---------------------------------------------------
-- Index : Use To Improve Performance Search Like 
--		Binary Search Inatead of Linear search
---------------------------------------------------

-- Index : 
-- B-Tree
-- Clustered Index : ==> By PK
-- NonClusterd Index ==> By Non-PK

-- By Def Dsfualt : PK

Use ITI

Create Clustered Index Idx01
On Student(St_FName)

-- Cannot create more than one clustered index on table 'Student'.
-- Drop the existing clustered index 'PK_Student' before creating another.

Create NonClustered Index Idx01
On Student(St_FName)

Select * From Student -- Cluster Index Scan

Select * from Student
where St_Id = 1		  -- Cluster Index Seek

select * from student
where St_FName = 'Ahmed' -- NonCluster Index

Create Table Test
(
	X int,
	Y int,
	Z int 
)

Insert into Test Values (1,2,3)
Insert into Test Values (1,2,3)
Insert into Test Values (1,2,3)

Select * from Test -- Table Scan (Liner Search)

-- Note : 1. table Can Have More Than One NonClustered Index
--			But Has Only One Clustered Index

--		: 2. U Must Have A knowlage About Most Column Search By it 
--		To Minimize Clustered Index ------> Minimize Memory Space Also

--		: 3. We Use SQL Sever Profiler To Trace The Most Column Search By It.



