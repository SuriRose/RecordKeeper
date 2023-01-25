create or alter procedure dbo.PresidentUpdate(
    @PresidentId int output,
    @PartyId int output,
    @Num int output,
    @FirstName varchar(100) ,
    @LastName varchar (100),
    @DateBorn date,
    @DateDied datetime2 = null,
    @TermStart int,
    @TermEnd int,
    @Code varchar(250) = '' output,
    @Message varchar (1000) = ' ' output
)
as
begin
    declare @return int  = 0
    select @PresidentId = isnull(@PresidentId,0), @TermEnd = nullif(@TermEnd,0), @Num = isnull(@num, 0), @Code = isnull(@Code, '') 

    if @PresidentId = 0
    begin
       
if @Num = 0
begin 
if(@Num <> (select num from president p where p.PresidentId = @PresidentId))
begin 
select @return = 1, @Message = 'You cannot change president''s number'
goto finished
end
select @Num = max(p.Num) +1 from president p
end 
        insert President(PartyId, Num, FirstName, LastName, DateBorn, DateDied, TermStart, TermEnd)
        values(@PartyId, @Num, @FirstName, @LastName, @DateBorn, @DateDied, @TermStart, @TermEnd)

        select @PresidentId = scope_identity()
    end
    else
    begin
        update p
        set
            PartyId = @PartyId, 
            Num = @Num, 
            FirstName = @FirstName, 
            LastName = @LastName, 
            DateBorn = @DateBorn, 
            DateDied = @DateDied, 
            TermStart = @TermStart, 
            TermEnd = @TermEnd 
        from President p
        where p.PresidentId = @PresidentId
    end
    --?select @Code = p.Code from president p where p.PresidentId = @PresidentId 
    finished:

    return @return
end