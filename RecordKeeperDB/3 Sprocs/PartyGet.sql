create or alter procedure dbo.PartyGet(
    @PartyId int = 0,
    @Party varchar(35) = '',
    @All bit = 0,
    @IncludeBlank bit = 0,
    @Message varchar(100) = '' output

)
as
begin  
select @PartyId = isnull(@PartyId,0), @All = isnull(@All,0), @IncludeBlank = isnull(@IncludeBlank,0), @Party = isnull(@Party, '')

    select p.PartyId, p.Party, p.Color, p.YearStarted, PresidentCount = count(r.PresidentId)
    from  party p 
    left join president r 
    on r.PartyId = p.PartyId
    where p.PartyId = @PartyId
    or @All = 1
    or P.Party = @Party
    group by p.PartyId, p.Party, p.Color, p.YearStarted
    union select 0, ' ', ' ', 0 , 0 where @IncludeBlank = 1
    order by  p.Party, p.Color, p.YearStarted
end  

go

exec PartyGet
exec PartyGet @all = 1
exec PartyGet @all = 1, @IncludeBlank = 1
exec PartyGet @PartyId = 22 