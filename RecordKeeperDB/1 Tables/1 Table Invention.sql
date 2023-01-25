use RecordKeeperDB
go
drop table if exists Invention
go
create table dbo.Invention(
	InventionId int not null identity primary key,
	InventionName varchar (200),
	InventionDesc varchar (max),
	YearInvented int,
	InventorFirstName varchar (100),
	InventorLastName varchar (100),
	Country varchar (50),
	YearBorn int,
	YearDied int 
	)
go




