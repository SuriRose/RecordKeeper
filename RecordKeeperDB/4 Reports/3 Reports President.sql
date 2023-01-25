--AS Good job! 100%
    --3) reports and Tasks
	--a) list all executive orders sorted by page number, display the official executive order format
	select e.Reference
	from ExecutiveOrder e
	order by e.PageNum
	--b) same as a but include the presidents name
	select e.Reference, p.FirstName, p.LastName 
	from ExecutiveOrder e
	join president p 
	on p.PresidentId = e.PresidentId
	order by e.PageNum
	--c) same as b but include the party name
	select e.Reference, p.FirstName, p.LastName, a.Party 
	from ExecutiveOrder e
	join president p 
	on p.PresidentId = e.PresidentId
	join party a  
	on a.partyId = p.partyId
	order by e.PageNum
	--d) show number of executive orders per presidents, include zero if none for president, sort by highest number of orders
	select NumOfExecutiveOrders = count(e.OrderNo), p.LastName
	from president p 
	left join executiveorder e 
	on p.PresidentId = e.PresidentId
	group by p.num , p.LastName
	order by count(p.Num) desc
	--e) show number of executive orders per party, include zero if none for party
	select NumOfExecutiveOrders = count(e.OrderNo), a.Party
	from president p 
	left join  executiveorder e  
	on p.PresidentId = e.PresidentId
	join party a 
	on a.PartyId = p.partyId
	group by p.Num, a.Party
	--f) delete a party that has one or more executive orders
	--select * 
	--select * 
	delete e 
	from executiveorder e 
	join president p 
	on p.PresidentId = e.PresidentId
	join party a  
	on a.PartyId = p.PartyId
	where a.party = 'Democrat'
	--select * 
	delete p 
	from president p 
	join party a  
	on a.PartyId = p.PartyId
	where a.party = 'Democrat'

	--select *
	delete a  
	from party a 
	where a.Party = 'Democrat'
	--g) for a particular party with exec orders update all to not upheld
	update e 
	set e.UpheldByCourt = 0 
	from ExecutiveOrder e 
	join president p 
	on p.PresidentId = e.PresidentId
	join party a
	on a.PartyId = p.PartyId
	where a.party = 'Democrat'

