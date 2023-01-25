create or alter procedure dbo.PartyUpdate(
        @PartyId int = 0 output,
		@Party varchar(50) ,
		@YearStarted int,
		@Color varchar(20),
        @PresidentCount int = 0,
        @Message varchar(1000) = '' output
)
as 
begin

declare @return int = 0

select @PartyId = isnull(@PartyId, 0)

if @PartyId = 0
begin
insert party(Party, YearStarted, Color)
values(@Party, @YearStarted, @Color)

select @PartyId = scope_identity()
end 
else
begin 
update Party
set Party = @Party,
YearStarted = @YearStarted,
Color = @Color
where PartyId = @PartyId
end 
return @return
end 
go

