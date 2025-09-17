 
 
create database officetest
use officetest

create table Offices
(
 OfficeNumber int primary key identity(1,1) ,
      -- Char(50)   'alex' 
     --Varchar(50)  support asci code --> allows alphabetical, numerical, and special characters 
	 --NVarchar(50)  supports Unicode -->  allows alphabetical, numerical, and special characters 
 Location varchar(20)  default 'cairo' ,
 MangerId int unique  
 
)

create table Employee
(
 EmployeeId int primary key identity(1,1) ,
 EmployeeName NVarchar(20) not null ,
 OfficeNumber int References Offices (OfficeNumber) ,

)
alter table employee
alter column OfficeNumber int not null

alter table offices
add foreign key (MangerId) references Employee (EmployeeId)


create Table Property
(
 PropertyId int primary key ,
 Address Varchar(20) ,
 City Varchar(20) ,
 Code bigint not null ,
 OfficeNumber int references Offices (OfficeNumber)
)

create table Owner
(
  OwnerId int primary key ,
  Name Varchar(20)
)

create table Property_Owner
(
  Owner_Id int references Owner (OwnerId) ,
  Property_Id int references Property (PropertyId) ,
  primary key (Owner_Id ,Property_Id )

)

alter table offices
drop constraint[UQ__Offices__47729C840D681B87]

alter table offices
add unique (MangerId)