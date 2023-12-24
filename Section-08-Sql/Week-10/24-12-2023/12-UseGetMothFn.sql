--declare @birthDay date
--set @birthDay='1994-02-16'

--select dbo.GetMonthName(@birthday)

use Northwind
go

select 
	o.OrderDate,
	dbo.GetMonthName(o.OrderDate) as [Ay]
from Orders o