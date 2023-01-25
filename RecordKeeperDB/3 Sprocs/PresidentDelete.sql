create or alter procedure dbo.PresidentDelete(
    @PresidentId int,
    @Message varchar(1000) = '' output
    )
as 
begin 
declare @return int = 0

return @return

--delete president where PresidentId = @PresidentId
delete p from president p  where PresidentId = @PresidentId
end
go