create or alter procedure dbo.PresidentSearch(
    @SearchCriteria varchar(1000),
    @Message varchar(1000) = '' output
)
as begin
    declare @return int = 0

    select * from president p where p.lastname like '%' + @SearchCriteria + '%'
    or p.firstname like '%' + @SearchCriteria + '%'

    return @return
    end 
  --  exec PresidentSearch @SearchCriteria = 'wash'
    