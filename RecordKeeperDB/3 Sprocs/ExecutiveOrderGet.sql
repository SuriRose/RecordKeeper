create or alter procedure dbo.ExecutiveOrderGet(@PresidentId int)
as
begin
select e.ExecutiveOrderId, e.PresidentId, e.ordername, e.OrderNo, e.YearIssued, e.UpheldByCourt, e.AuditDate
from ExecutiveOrder e 
where e.PresidentId = @PresidentId
order by e.reference
end
go
select * from ExecutiveOrder
exec ExecutiveOrderGet @PresidentId = 1022