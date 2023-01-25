--AS Good job! 100%
use RecordkeeperDB
go 
drop table if exists ExecutiveOrder
drop table if exists president
drop table if exists party
go
create table dbo.party(
		PartyId int not null identity primary key,
		Party varchar(50) not null
			constraint u_party_party unique
			constraint ck_Party_Party_cannot_be_blank check(party <> ''),
		YearStarted int not null
			constraint ck_party_year_started_must_be_greater_than_zero Check(YearStarted > 0),
		Color varchar(20) not null
			constraint ck_Party_Color_cannot_be_blank check(Color <> '')
		)
create table dbo.president(
		PresidentId int not null identity (1000,1) primary key,
		PartyId int not null constraint f_Party_President foreign key references party(partyId),
		Num int not null constraint u_President_Num unique
            constraint ck_President_Num_over_zero check(num > 0), 
		FirstName varchar(100) not null 
            constraint ck_President_FirstName_cannot_be_blank check(FirstName <> ''), 
		LastName varchar(100) not null 
            constraint ck_President_LastName_cannot_be_blank check(lastName <> ''), 
		DateBorn date not null,
            constraint ck_President_DateBorn_cannot_be_less_than_zero check(year(DateBorn )> 0),
		DateDied date ,
             constraint ck_President_DateDied_cannot_be_less_than_zero check(year(DateDied)> 0),
		YearBorn as datepart(year,DateBorn),
		YearDied as datepart(year,DateDied),
		TermStart int not null,
            constraint ck_president_termstart_cannot_be_before_1789 check(TermStart >= 1789),
		TermEnd int ,
            constraint ck_President_TermStart_must_be_before_TermEnd check(TermStart <= TermEnd),
            constraint ck_President_must_be_at_least_35_years_old check(TermStart - year(DateBorn) >= 35)
      )
go
alter table president add AgeAtDeath as year(DateDied) - year(dateBorn)
alter table president add YearsServed  as  termend - TermStart persisted
alter table president add termsServed  as  
case 
	when termend - termstart < 4 then 0
	when termend - termstart = 4 then 1
	when termend - termstart = 8 then 2
	when termend - termstart = 12 then 3
end
go 
	alter table President drop column if exists Code 
	go
	alter table President add Code as replace(concat(Num, '-' ,FirstName, '-', LastName), ' ', '-') persisted 
	go 
create table dbo.ExecutiveOrder(
	ExecutiveOrderId int not null identity primary key,
	PresidentId int not null 
		constraint f_President_ExecutiveOrder foreign key references president(presidentId),
	OrderNo int not null constraint u_ExecutiveOrder_OrderNum unique,
		constraint ExecutiveOrder_OrderNo_must_be_greater_than_zero check(OrderNo > 0),
	PageNum int not null
		constraint ExecutiveOrder_PageNum_must_be_greater_than_zero check(PageNum > 0),
	YearIssued int not null
		constraint ExecutiveOrder_YearIssued_must_be_greater_than_zero check(YearIssued > 0),
		constraint ExecutiveOrder_YearIssued_cannot_be_in_the_future check (YearIssued < year(getdate())),
	OrderName varchar(300) not null
		constraint ck_ExecutiveOrder_OrderName_cannot_be_blank check(OrderName <> ''),
	--Reference as concat('Exec. Order No.', ' ', OrderNo, ' ', '3 C.F.R.', ' ' ,PageNum, ' ', YearIssued, '. ', OrderName, '.' ) Persisted,
	UpheldByCourt bit not null,
	AuditDate date default getdate() not null
)
go