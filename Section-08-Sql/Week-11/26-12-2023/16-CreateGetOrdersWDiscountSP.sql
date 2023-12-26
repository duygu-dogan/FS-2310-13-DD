use Northwind
go

drop proc if exists spGetOrdersWDiscount
go

create proc spGetOrdersWDiscount
as 
	select
		od.OrderID as [Siparis No],
		SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) as [Siparis Tutari]
	from OrderDetails od
	group by od.OrderID

go

--Test
exec spGetOrdersWDiscount
go