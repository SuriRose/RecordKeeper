--AS Great job! 100%
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

insert president(PartyId, Num, FirstName, LastName, dateBorn, DateDied, TermStart, TermEnd)
      select (select p.partyId from party p where p.Party = 'None, Federalist'), 1, 'George', 'Washington', '1732-02-22', '1799-12-14', 1789, 1797
union select (select p.partyId from party p where p.Party = 'Federalist'), 2, 'John', 'Adams','1735-10-30', '1826-07-04', 1797, 1801
union select (select p.partyId from party p where p.Party = 'Democratic-Republican'), 3, 'Thomas', 'Jefferson','1743-04-13', '1826-07-04', 1801, 1809
union select (select p.partyId from party p where p.Party = 'Democratic-Republican'), 4, 'James', 'Madison', '1751-03-16', '1836-06-28', 1809, 1817
union select (select p.partyId from party p where p.Party = 'Democratic-Republican'), 5, 'James', 'Monroe',  '1758-04-28', '1831-07-04', 1817, 1825
union select (select p.partyId from party p where p.Party = 'Democratic-Republican'),6, 'John Quincy', 'Adams',  '1767-07-11', '1848-02-23', 1825, 1829
union select (select p.partyId from party p where p.Party = 'Democrat'),7, 'Andrew', 'Jackson',  '1767-03-15', '1845-06-08', 1829, 1837
union select(select p.partyId from party p where p.Party = 'Democrat'), 8, 'Martin', 'van Buren', '1782-12-05', '1862-07-24', 1837, 1841
union select(select p.partyId from party p where p.Party = 'Whig'), 9, 'William H.', 'Harrison', '1773-02-09', '1841-04-04', 1841, 1841
union select (select p.partyId from party p where p.Party = 'Whig'),10, 'John', 'Tyler', '1790-03-29', '1862-01-18', 1841, 1845
union select (select p.partyId from party p where p.Party = 'Democrat'),11, 'James K.', 'Polk', '1795-11-02', '1841-06-15', 1845, 1849
union select(select p.partyId from party p where p.Party = 'Whig'), 12, 'Zachary', 'Taylor', '1784-11-24', '1850-07-09', 1849, 1850
union select (select p.partyId from party p where p.Party =  'Whig'),13, 'Millard', 'Fillmore','1800-01-07', '1874-03-08', 1850, 1853
union select (select p.partyId from party p where p.Party = 'Democrat'),14, 'Franklin', 'Pierce', '1804-11-23', '1869-10-08', 1853, 1857
union select (select p.partyId from party p where p.Party = 'Democrat'),15, 'James', 'Buchanan',  '1791-04-23', '1868-06-01', 1857, 1861
union select (select p.partyId from party p where p.Party = 'Republican'),16, 'Abraham', 'Lincoln', '1809-02-12', '1865-04-15', 1861, 1865
union select (select p.partyId from party p where p.Party = 'National Union'),17, 'Andrew', 'Johnson', '1808-12-29', '1875-07-31', 1865, 1869
union select (select p.partyId from party p where p.Party = 'Republican'),18, 'Ulysses S.', 'Grant', '1822-04-27', '1885-07-23', 1869, 1877
union select (select p.partyId from party p where p.Party = 'Republican'),19, 'Rutherford', 'Hayes',  '1822-10-04', '1893-01-17', 1877, 1881
union select (select p.partyId from party p where p.Party = 'Republican'),20, 'James', 'Garfield', '1831-11-19', '1881-09-19', 1881, 1881
union select (select p.partyId from party p where p.Party = 'Republican'),21, 'Chester', 'Arthur','1829-10-05', '1886-11-18', 1881, 1885
union select (select p.partyId from party p where p.Party = 'Democrat'),22, 'Grover', 'Cleveland', '1837-03-18', '1908-06-24', 1885, 1889
union select (select p.partyId from party p where p.Party = 'Republican'),23, 'Benjamin', 'Harrison','1833-08-20', '1901-03-13', 1889, 1893
union select (select p.partyId from party p where p.Party = 'Democrat'),24, 'Grover', 'Cleveland', '1837-03-18', '1908-06-24', 1893, 1897
union select (select p.partyId from party p where p.Party = 'Republican'),25, 'William', 'McKinley', '1843-01-29', '1901-09-14', 1897, 1901
union select (select p.partyId from party p where p.Party = 'Republican'),26, 'Theodore', 'Roosevelt', '1858-10-27', '1919-01-06', 1901, 1909
union select (select p.partyId from party p where p.Party = 'Republican'),27, 'William', 'Taft','1857-09-15', '1930-03-08', 1909, 1913
union select (select p.partyId from party p where p.Party = 'Democrat'),28, 'Woodrow', 'Wilson', '1856-12-28', '1924-02-03', 1913, 1921
union select (select p.partyId from party p where p.Party = 'Republican'),29, 'Warren', 'Harding', '1865-11-02', '1923-08-02', 1921, 1923
union select (select p.partyId from party p where p.Party = 'Republican'),30, 'Calvin', 'Coolidge', '1872-07-04', '1933-01-05', 1923, 1929
union select (select p.partyId from party p where p.Party = 'Republican'),31, 'Herbert C.', 'Hoover', '1874-08-10', '1964-10-20', 1929, 1933
union select (select p.partyId from party p where p.Party = 'Democrat'),32, 'Franklin Delano', 'Roosevelt', '1882-01-30', '1945-04-12', 1933, 1945
union select (select p.partyId from party p where p.Party = 'Democrat'),33, 'Harry S', 'Truman','1884-05-08', '1972-12-26', 1945, 1953
union select (select p.partyId from party p where p.Party = 'Republican'),34, 'Dwight David', 'Eisenhower', '1890-10-14', '1969-03-28', 1953, 1961
union select (select p.partyId from party p where p.Party = 'Democrat'),35, 'John Fitzgerald', 'Kennedy','1917-05-29', '1963-11-22', 1961, 1963
union select (select p.partyId from party p where p.Party = 'Democrat'),36, 'Lyndon Baines', 'Johnson', '1908-08-27', '1973-01-22', 1963, 1969
union select (select p.partyId from party p where p.Party = 'Republican'),37, 'Richard Milhous', 'Nixon',  '1913-01-09', '1994-04-22', 1969, 1974
union select (select p.partyId from party p where p.Party = 'Republican'),38, 'Gerald R.', 'Ford', '1913-07-14', '2006-12-26', 1974, 1977
union select (select p.partyId from party p where p.Party = 'Democrat'),39, 'James Earl', 'Carter', '1924-10-01', null, 1977, 1981
union select (select p.partyId from party p where p.Party = 'Republican'),40, 'Ronald Wilson', 'Reagan', '1911-02-06', '2004-06-05', 1981, 1989
union select (select p.partyId from party p where p.Party = 'Republican'),41, 'George H. W.', 'Bush','1924-06-12', '2018-11-30', 1989, 1993
union select (select p.partyId from party p where p.Party = 'Democrat'),42, 'William Jefferson', 'Clinton', '1946-08-19', null, 1993, 2001
union select (select p.partyId from party p where p.Party = 'Republican'),43, 'George W.', 'Bush','1946-07-06', null, 2001, 2009
union select (select p.partyId from party p where p.Party = 'Democrat'),44, 'Barack', 'Obama','1961-08-04', null, 2009, 2017
union select (select p.partyId from party p where p.Party = 'Republican'),45, 'Donald', 'Trump', '1946-11-06', null, 2017, 2020
union select (select p.partyId from party p where p.Party = 'Federalist'),46, 'Joe', 'Biden', '1942-11-08', null, 2021, null

insert president(partyId, Num, FirstName, LastName, dateBorn, DateDied, TermStart, TermEnd)
      select (select p.partyId from party p where p.Party = 'None, Federalist'), 47, 'George', 'Washington', '1732-02-22', '1799-12-14', 1789, 1797
union select (select p.PartyId from party p  where p.party = 'Democrat'),48, 'John', 'Adams', '1735-10-30', '1826-07-04', 1797, 1801
union select (select p.PartyId from party p  where p.party = 'Federalist'), 49, 'Thomas', 'Jefferson',  '1743-04-13', '1826-07-04', 1801, 1809
union select (select p.PartyId from party p  where p.party = 'Whig'), 50, 'James', 'Madison',  '1751-03-16', '1836-06-28', 1809, 1817
union select (select p.PartyId from party p  where p.party = 'None, Federalist'), 51, 'James', 'Monroe', '1758-04-28', '1831-07-04', 1817, 1825
union select (select p.PartyId from party p  where p.party = 'National Union'), 52, 'John Quincy', 'Adams',  '1767-07-11', '1848-02-23', 1825, 1829
union select (select p.PartyId from party p  where p.Party = 'Democratic-Republican'), 53, 'Andrew', 'Jackson', '1767-03-15', '1845-06-08', 1829, 1837

insert ExecutiveOrder(PresidentId, OrderNo,	PageNum, YearIssued, OrderName,	UpheldByCourt)
	select (select p.presidentId from president p  where p.num = 1),  6102,   5	, 1993, 'Forbidding the hoarding of gold coin, gold bullion, and gold certificates within the continental United States', 1
union select (select p.presidentId from president p  where p.num = 2), 9567,  9617, 1945,	'Amending Executive Order No. 9095, as Amended by Executive Order No. 9193, To Define Further the Functions and Duties of the Alien Property Custodian With Respect to Property of Germany and Japan and Nationals Thereof', 1
union select (select p.presidentId from president p  where p.num = 3), 9568, 6917, 1945,	'Providing for the Release of Scientific Information', 1
union select (select p.presidentId from president p  where p.num = 4), 9569, 7235, 1945,	'Inspection by the Office of Price Administration of Corporation Statistical Transcript Cards Prepared From Income and Declared Value Excess Profits Tax Returns', 1 
union select (select p.presidentId from president p  where p.num = 5), 1034, 3139, 1952,	'Directing the Secretary of Commerce To Take Possession of and Operate the Plants and Facilities of Certain Steel Companies', 1
union select (select p.presidentId from president p  where p.num = 6), 1228,  10135	, 1981,	'Termination of the Wage and Price Regulatory Program', 1 
union select (select p.presidentId from president p  where p.num = 7), 1375,  5323	, 2017,	'Designating the World Organisation for Animal Health as a Public International Organization Entitled to Enjoy Certain Privileges, Exemptions, and Immunities', 1 
