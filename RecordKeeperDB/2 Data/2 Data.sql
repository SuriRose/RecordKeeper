use RecordKeeperDB
go
delete ExecutiveOrder
delete president
delete party
go
insert Party(Party, YearStarted, Color)
	select 'Republican', 1854, 'Red' 
	union select  'Democrat', 1828, 'Blue'
	union select 'Federalist',  1791, 'Orange'
	union select 'Whig',  1833, 'Yellow' 
	union select  'None, Federalist', 1789, 'White'
	union select  'National Union', 1864, 'Green'
	union select  'Democratic-Republican', 1792, 'purple'

insert president(partyId, Num, FirstName, LastName, Party, dateBorn, DateDied, TermStart, TermEnd)
      select (select p.partyId from party p where p.Party = 'None, Federalist'), 1, 'George', 'Washington', 'None, Federalist', '1732-02-22', '1799-12-14', 1789, 1797
      union select (select p.PartyId from party p  where p.party = 'Democrat'),2, 'John', 'Adams', 'Federalist', '1735-10-30', '1826-07-04', 1797, 1801
union select (select p.PartyId from party p  where p.party = 'Federalist'), 3, 'Thomas', 'Jefferson', 'Democratic-Republican', '1743-04-13', '1826-07-04', 1801, 1809
union select (select p.PartyId from party p  where p.party = 'Whig'), 4, 'James', 'Madison', 'Democratic-Republican', '1751-03-16', '1836-06-28', 1809, 1817
union select (select p.PartyId from party p  where p.party = 'None, Federalist'), 5, 'James', 'Monroe', 'Democratic-Republican', '1758-04-28', '1831-07-04', 1817, 1825
union select (select p.PartyId from party p  where p.party = 'National Union'), 6, 'John Quincy', 'Adams', 'Democratic-Republican', '1767-07-11', '1848-02-23', 1825, 1829
union select (select p.PartyId from party p  where p.Party = 'Democratic-Republican'), 7, 'Andrew', 'Jackson', 'Democrat', '1767-03-15', '1845-06-08', 1829, 1837

insert ExecutiveOrder(PresidentId, OrderNo,	VolumeNum,	PageNum,	YearIssued,	OrderName,	Reference,	UpheldByCourt,	AuditDate)
	select (select p.presidentId from president p  where p.num = 1),  6102,  '3 C.F.R.' , 5	, 1993, 'Forbidding the hoarding of gold coin, gold bullion, and gold certificates within the continental United States',	'Exec. Order No. 6102 3 C.F.R. 5 1993' 'Forbidding the hoarding of gold coin, gold bullion, and gold certificates within the continental United States',	 'TRUE'	,'2022-01-16'
union select	(select p.presidentId from president p  where p.num = 2), 9567,  '3 C.F.R.', 9617	, 1945,	'Amending Executive Order No. 9095, as Amended by Executive Order No. 9193, To Define Further the Functions and Duties of the Alien Property Custodian With Respect to Property of Germany and Japan and Nationals Thereof', 'Exec. Order No. 9567 3 C.F.R. 9617 1945' ,'TRUE',	'2022-01-16'
union select	(select p.presidentId from president p  where p.num = 3), 9568,  '3 C.F.R.', 6917	, 1945,	'Providing for the Release of Scientific Information', 'Exec. Order No. 9568 3 C.F.R. 6917 1945 Providing for the Release of Scientific Information', 'TRUE',	'2022-01-16'
union select	(select p.presidentId from president p  where p.num = 4), 9569,  '3 C.F.R.',	7235	, 1945,	'Inspection by the Office of Price Administration of Corporation Statistical Transcript Cards Prepared From Income and Declared Value Excess Profits Tax Returns','Exec. Order No. 9569 3 C.F.R. 7235 1945 Inspection by the Office of Price Administration of Corporation Statistical Transcript Cards Prepared From Income and Declared Value Excess Profits Tax Returns', 'TRUE', '2022-01-16'
union select	(select p.presidentId from president p  where p.num = 5), 1034,  '3 C.F.R.'	, 3139	, 1952,	'Directing the Secretary of Commerce To Take Possession of and Operate the Plants and Facilities of Certain Steel Companies', 'Exec. Order No. 10340 3 C.F.R. 3139 1952  Directing the Secretary of Commerce To Take Possession of and Operate the Plants and Facilities of Certain Steel Companies', 'TRUE', '2022-01-16'
union select	(select p.presidentId from president p  where p.num = 6), 1228,  '3 C.F.R.'	, 10135	, 1981,	'Termination of the Wage and Price Regulatory Program', 'Exec. Order No. 12288 3 C.F.R. 10135 1981 Termination of the Wage and Price Regulatory Program', 'TRUE', '2022-01-16'
union select	(select p.presidentId from president p  where p.num = 7), 1375,  '3 C.F.R.'	, 5323	, 2017,	'Designating the World Organisation for Animal Health as a Public International Organization Entitled to Enjoy Certain Privileges, Exemptions, and Immunities' ,'Exec. Order No. 13759 3 C.F.R. 5323 2017 Designating the World Organisation for Animal Health as a Public International Organization Entitled to Enjoy Certain Privileges, Exemptions, and Immunities', 'TRUE', '2022-01-16'



