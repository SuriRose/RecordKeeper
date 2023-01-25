declare @PartyId int , @PresidentId int = 0, @numval int 
--delete president where num > 46
select top 1 @PartyID = PartyId from party order by PartyId

exec PresidentUpdate
@PresidentId = @PresidentId output,
@PartyId = @PartyId output,
@Num = @numval output,
@Firstname = 'Max',
@LastName = 'Sax',
@DateBorn = '05/07/1980',
@DateDied = null,
@TermStart = 2024,
@TermEnd = null

select @numval
select * from president p  order by p.num desc --where p.PresidentId = @PresidentId