use RecordKeeperDB
go
drop table if exists medalist
go
create table dbo.Medalist(
	MedalistId int not null identity primary key,
	OlympicYear int not null 
        constraint ck_medalist_olympicYear_must_be_greater_or_equal_than_1896 check (OlympicYear > = 1896),
	Season varchar (50)not null  constraint ck_Medalist_season_cannot_be_blank check(Season <> ''),
	OlympicLocation varchar (100)not null  constraint ck_Medalist_olympiclocation_cannot_be_blank check(OlympicLocation <> ''), 
	Sport varchar (100)not null  constraint ck_medalist_sport_cannot_be_blank check(sport <> ''),
	SportSubcategory varchar (100)not null  constraint ck_Medalist_sportsubcategory_cannot_be_blank check(SportSubcategory <> ''),
	Medal varchar (6)not null  constraint ck_Medalist_medal_cannot_be_blank check(medal <> ''),
	FirstName varchar (50)not null  constraint ck_Medalist_firstname_cannot_be_blank check(FirstName <> ''),
	LastName varchar (50)not null  constraint ck_Medalist_lastname_cannot_be_blank check(LastName <> ''),
	Country varchar (50)not null  constraint ck_Medalist_country_cannot_be_blank check(Country<> ''),
	YearBorn int constraint ck_Medalist_yearborn_cannot_be_less_than_zero check(YearBorn > 0),
         constraint ck_medalist_YearBorn_must_be_before_olympicyear check(YearBorn < OlympicYear),
         constraint ck_medalist_sport_boxing_must_be_between_18_and_40 check (not(sport = 'Boxing' and OlympicYear - YearBorn not between 18 and 40)),
		 --constraint ck_medalist_sport_gymnastics_must_be_16_and_up check(not(sport = 'Gymnastics' and OlympicYear - YearBorn <16)),
         constraint u_medalist_olympicYear_and_medal_must_be_unique unique (medal,OlympicYear,sport,SportSubcategory)
)
go

alter table medalist  add AgeOfMedalist as olympicyear -  yearborn persisted
alter table medalist 
add summary as concat(medal, ' - ', substring(FirstName, 1, 1),'.', substring(LastName, 1, 1), '.: ',OlympicYear ) 
alter table medalist  add  GoldOrNot as 
(case medal when 'gold' then 1
else 0
end)
