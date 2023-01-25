
use RecordKeeperDB
go 
drop table if exists ExecutiveOrder
drop table if exists President
drop table if exists Party
go 
create table dbo.party(
		PartyId int not null identity primary key,
		Party varchar(50) not null,
		YearStarted int not null
			constraint ck_party_year_started_must_be_bigger_than_zero Check(YearStarted > 0),
		Color varchar(20) not null
		)
		go 
create table dbo.president(
		PresidentId int not null identity (1000,1) primary key,
		partyId int not null constraint f_Party_president foreign key references party(partyId),
		Num int not null constraint u_president_num unique, 
		FirstName varchar(100) not null, 
		LastName varchar(100) not null, 
        Party varchar(50) not null,
		DateBorn date not null,
		DateDied datetime2,
		YearBorn as datepart(year,DateBorn),
		YearDied as datepart(year,DateDied),
		TermStart int not null,
		TermEnd int)
		go 
		alter table President drop column if exists Code 
		alter table President add Code as replace(concat(Num, '-' ,FirstName, '-', LastName), '', '-') persisted 
		go 
create table dbo.ExecutiveOrder(
	ExecutiveOrderId int not null identity primary key,
	PresidentId int not null constraint f_President_ExecutiveOrder foreign key references president(presidentId),
	OrderNo int not null constraint u_Order_num__unique unique,
		constraint ExecutiveOrder_OrderNo_must_be_greater_than_zero check(OrderNo > 0),
	VolumeNum char(10) not null,
		constraint ck_executive_order_VolumeNum_must_be_the_same check(VolumeNum = '3 C.F.R.'),
	PageNum int not null
		constraint ExecutiveOrder_PageNum_must_be_greater_than_zero check(PageNum > 0),
	YearIssued int not null
		constraint ExecutiveOrder_YearIssued_must_be_greater_than_zero check(YearIssued > 0),
	OrderName varchar(300),
	Reference varchar(300),
	UpheldByCourt varchar(10)
		constraint ck_executive_order_upheld_must_be_upheld_or_struck_down Check(UpheldByCourt in ('True', 'False')),
	AuditDate date,
		constraint ck_executive_order_AuditDate_must_be_greater_than_Year_Issued check(year(AuditDate) > YearIssued)  
)
go

