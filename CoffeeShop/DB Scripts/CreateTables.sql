use master
go

create database CoffeeShopDB
go

create table Users
(
ID int identity (1,1) not null,

FirstName varchar(50) not null,
LastName varchar(50) not null,
Email varchar(50) null,
PhoneNumber varchar(50) null,
[Password] varchar (50) null

primary key (ID)
)

go