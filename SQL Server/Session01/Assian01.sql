
Create database  Sales
use Sales


Create Table Sales_Office
(
	Sal_Num int Primary key identity(1,1),
	Sal_Loc varchar(30),
)


Alter table Sales_Office
Add foreign Key (Emp_Id) references Emplyee(Emp_Id) 



Create Table Emplyee
(
	Emp_Id int primary key identity(1,1),
	Emp_Name varchar(30),
	SalNum int references Sales_Office(Sal_Num)
)
 


Create Table Property
(
	Pro_Id int primary key ,
	Pro_Add varchar(30),
	Pro_City varchar(30),
	Pro_State varchar(30),
	Code int,
	SalNum int references Sales_Office(Sal_Num)

)

create Table [Owner]
(
		Id int primary key ,
		Name varchar(30)
)


Create table Prop_Owner
(
	Own_Id int references Owner(ID) ,
	Prop_Id int references  Property(Pro_Id),
	Precent varchar(30)
)