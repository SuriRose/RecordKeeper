use RecordKeeperDB
go
drop table if exists states
go
create table dbo.states(
	StateId int not null identity primary key,
	StateName varchar(25) not null unique,
	StateCode char(2) not null default '' unique,
	PopValue int not null,
	RepublicanVotes int not null,
	DemocratVotes int not null,
	Admitted datetime2 not null
)
go

insert states(StateName, StateCode, PopValue, RepublicanVotes, DemocratVotes, Admitted)
select	 'Alabama','AL',4849377,9,0,'December 14, 1819'
union select	'Alaska','AK',737732,3,0,'January 3, 1959'
union select	'Arizona','AZ',6731484,11,0,'February 14, 1912'
union select	'Arkansas','AR',2994079,6,0,'June 15, 1836'
union select	'California','CA',38802500,0,55,'September 9, 1850'
union select	'Colorado','CO',5355856,0,9,'August 1, 1876'
union select	'Connecticut','CT',3596677,0,7,'January 9, 1788'
union select	'Delaware','DE',935614,0,3,'December 7, 1787'
union select	'Florida','FL',19893297,29,0,'March 3, 1845'
union select	'Georgia','GA',10097343,16,0,'January 2, 1788'
union select	'Hawaii','HI',1419561,0,4,'August 21, 1959'
union select	'Idaho','ID',1634464,4,0,'July 3, 1890'
union select	'Illinois','IL',12880580,0,20,'December 3, 1818'
union select	'Indiana','IN',6596855,11,0,'December 11, 1816'
union select	'Iowa','IA',3107126,6,0,'December 28, 1846'
union select	'Kansas','KS',2904021,6,0,'January 29, 1861'
union select	'Kentucky','KY',4413457,8,0,'June 1, 1792'
union select	'Louisiana','LA',4649676,8,0,'April 30, 1812'
union select	'Maine','ME',1330089,1,3,'March 15, 1820'
union select	'Maryland','MD',5976407,0,10,'April 28, 1788'
union select	'Massachusetts','MA',6745408,0,11,'February 6, 1788'
union select	'Michigan','MI',9909877,16,0,'January 26, 1837'
union select	'Minnesota','MN',5457173,0,10,'May 11, 1858'
union select	'Mississippi','MS',2984926,10,0,'December 10, 1817'
union select	'Missouri','MO',6063589,6,0,'August 10, 1821'
union select	'Montana','MT',1023579,3,0,'November 8, 1889'
union select	'Nebraska','NE',1881503,5,0,'March 1, 1867'
union select	'Nevada','NV',2839099,0,6,'October 31, 1864'
union select	'New Hampshire','NH',1326813,0,4,'June 21, 1788'
union select	'New Jersey','NJ',8938175,0,14,'December 18, 1787'
union select	'New Mexico','NM',2085572,0,5,'January 6, 1912'
union select	'New York','NY',19746227,0,29,'July 26, 1788'
union select	'North Carolina','NC',9943964,15,0,'November 21, 1789'
union select	'North Dakota','ND',739482,3,0,'November 2, 1889'
union select	'Ohio','OH',11594163,18,0,'March 1, 1803'
union select	'Oklahoma','OK',3878051,7,0,'November 16, 1907'
union select	'Oregon','OR',3970239,0,7,'February 14, 1859'
union select	'Pennsylvania','PA',12787209,20,0,'December 12, 1787'
union select	'Rhode Island','RI',1055173,0,4,'May 29, 1790'
union select	'South Carolina','SC',4832482,9,0,'May 23, 1788'
union select	'South Dakota','SD',853175,3,0,'November 2, 1889'
union select	'Tennessee','TN',6549352,11,0,'June 1, 1796'
union select	'Texas','TX',26956958,38,0,'December 29, 1845'
union select	'Utah','UT',2942902,6,0,'January 4, 1896'
union select	'Vermont','VT',626011,0,3,'March 4, 1791'
union select	'Virginia','VA',8326289,0,13,'June 25, 1788'
union select	'Washington','WA',7061530,0,12,'November 11, 1889'
union select	'West Virginia','WV',1850326,5,0,'June 20, 1863'
union select	'Wisconsin','WI',5757564,10,0,'May 29, 1848'
union select	'Wyoming','WY',584153,3,0,'July 10, 1890'
order by 1
