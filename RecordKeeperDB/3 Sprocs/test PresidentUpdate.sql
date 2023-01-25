
declare @i int, @m varchar(1000), @PartyId int, @PresidentId int, @LastName varchar(100), @Num int, @TermStart int, @TermEnd int

select top 1 
    @PresidentId = p.PresidentId, @PartyId = p.PartyId,
    @LastName = reverse(p.LastName), @num = p.Num, @TermStart = p.TermStart, @TermEnd = p.TermEnd
from President p
where p.FirstName <> 'Max'
order by p.PresidentId desc

select @Num = @Num + 100

select * from President p where p.PresidentId = @PresidentId

exec @i = PresidentUpdate
@PresidentId = @PresidentId,
@PartyId = @PartyId, 
@Num = @Num, 
@FirstName = 'Max', 
@LastName = @LastName, 
@DateBorn = '01/01/1968', 
@DateDied = null, 
@TermStart = @TermStart, 
@TermEnd = @TermEnd,
@Message = @m output

select @i, @m 

select * from President p where p.PresidentId = @PresidentId