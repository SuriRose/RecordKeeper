use RecordKeeperDB
go
drop table if exists WorldRecord
go
create table dbo.WorldRecord(
	WorldRecordId int not null identity primary key,
	Category varchar (100) not null constraint ck_worldrecord_Category_cannot_be_blank  check(category <> ''),
	RecordName varchar(200) not null ,
	constraint ck_worldrecord_recordname_cannot_be_blank  check(RecordName <> ''),
	--constraint u_worldrecord_recordname unique,

	RecordDesc varchar (max)not null constraint ck_worldrecord_recorddesc_cannot_be_blank  check(RecordDesc <> ''),
	FullName varchar (100)not null constraint ck_worldrecord_fullnamecannot_be_blank  check(FullName <> ''),
	Amount decimal not null constraint ck_worldrecord_Amount_must_be_greater_than_zero check(Amount > 0), 
	UnitOfMeasure varchar (100)not null constraint ck_worldrecord_unitofmeasure_cannot_be_blank  check(UnitOfMeasure <> ''),
	YearAchieved int not null constraint ck_worldrecord_yearachieved_must_be_greater_than_1200 check(YearAchieved>=1200),
	RecordBreakerAddress varchar(500) not null default  '',
	Country varchar (50)not null constraint ck_worldrecord_country_cannot_be_blank  check(Country <> ''),
	DateInserted datetime not null default getdate()
	--constraint ck_worldrecord_USA_must_be_1776_or_later check(Country='USA' and YearAchieved < 1776),
	--constraint u_worldrecord_amount_unitofmeasure unique(Amount, UnitOfMeasure)
	)
go
alter table Worldrecord drop constraint if exists u_worldrecord_code
alter table Worldrecord drop column if exists code
alter table Worldrecord 
add code as concat(left(replace(recordname, ' ', ''),20),yearAchieved)persisted
   constraint u_worldrecord_code unique     


