create or alter procedure dbo.PresidentGet(
    @PresidentId int = 0,
    @num int = 0, @All bit = 0,
    @Message varchar(100) = '' output, 
    @Code varchar(250) = '',
    @Party varchar(35) = ''
)
as
begin
declare @return int = 0
    select @PresidentId = isnull(@PresidentId, 0), @all = isnull(@all, 0), @num = isnull (@num, 0), @Code = isnull(@Code, 0), @Party = isnull(@Party, '')

    select p.PresidentId, p.PartyId, a.Party, a.Party, p.Num, p.FirstName, p.LastName, p.YearBorn, p.YearDied, p.TermStart, p.TermEnd, p.DateBorn, p.DateDied, p.Code
    from President p 
    join party a
    on a.PartyId = p.PartyId
    where p.PresidentId = @PresidentId
    or @All = 1 
    or p.Num = @num
    or p.Code = @Code 
    or a.Party = @Party
    order by p.Num

    finished:
    return @return
end

go 

exec PresidentGet @Code = '1-George-Washington'
exec PresidentGet @num = 44
exec PresidentGet @PresidentId = 1602
exec PresidentGet @All = 1
exec PresidentGet @PresidentId = 1000
exec PresidentGet @PresidentId = null, @All = null
select Num = count(*), TableDesc = 'Parties' from Party union select Num = count(*), TableDesc = 'Presidents' from President union select Num = count(*), TableDesc = 'Executive Orders' from ExecutiveOrder

