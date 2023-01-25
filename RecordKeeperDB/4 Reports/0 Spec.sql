/*
ExecutiveOrder
    pk
    party varchar(50)
    YearStarted int 
    color varchar(50)

president
    pk
    PartyId fk
    Num int
    FirstName varchar(100)
    LastName varchar(100)
    Party varchar(100)
    DateBorn date
    DateDied date
    YearBorn date
    YearDied date
    TermStart int
    TermEnd int

ExecutiveOrder
    pk
    PresidentId fk
    OrderNo int
    VolumeNum char(10)
    PageNum int
    YearIssued int
    OrderName varchar(300)
    Reference varchar(300)
    UpheldByCourt varchar(10)
    AuditDate date

*/