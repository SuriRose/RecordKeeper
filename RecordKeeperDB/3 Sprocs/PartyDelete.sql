create or alter procedure dbo.PartyDelete(
@PartyId int = 0,
@Party varchar(35) = '' output,
@Message varchar(1000) = '' output
)
as 
begin 

declare @return int = 0

select @PartyId = isnull(@PartyId, 0), @Party = isnull(@Party, '')

delete party
where PartyId = @PartyId
or party = @Party

return @return
end
go
exec PartyDelete
@PartyId = @PartyId
select * from party p where p.PartyId = @PartyId