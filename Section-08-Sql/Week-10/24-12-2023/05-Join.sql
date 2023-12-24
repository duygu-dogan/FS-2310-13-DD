--Tüm filmleri kategori adlarıyla listele
--use MoviesDb
--go

--Default inner join

--select 
--	f.Id as [ID],
--	f.Name as [Film],
--	c.Name as [Kategori]
--from Films f join Categories c on f.CategoryId=c.Id

--use Northwind
--go

--select
--	p.ProductID as [ID],
--	p.ProductName as [Product],
--	p.UnitPrice as [Price],
--	c.CategoryName as [Kategori] 
--from Products p join Categories c 
--	on p.CategoryID=c.CategoryID

--select 
--	p.ProductID as [ID],
--	p.ProductName as [Product],
--	p.UnitPrice as [Price],
--	c.CategoryName as [Kategori],
--	s.CompanyName as [Supplier]
--from Products p join Categories c	
--	on p.CategoryID=c.CategoryID join Suppliers s
--		on p.SupplierID=s.SupplierID

--select 
--	p.ProductID as [ID],
--	p.ProductName as [Product],
--	p.UnitPrice as [Price],
--	c.CategoryName as [Kategori],
--	s.CompanyName as [Supplier]
--from Products p join Categories c	
--	on p.CategoryID=c.CategoryID join Suppliers s
--		on p.SupplierID=s.SupplierID
--where c.CategoryName='Condiments'

--USA'den tedarik edilen ürünleri listeleyin (Ürün adı ve Tedarik Ülkesi kolonları dönsün)

--select 
--	p.ProductName as [Ürün Adı],
--	s.Country as [Ülke]
--from Products p join Suppliers s
--	on p.SupplierID=s.SupplierID
--where s.Country='USA'

--select top(5)
--	p.ProductName as [Product],
--	sum(od.UnitPrice*od.Quantity) as [total]
--from Products p join Suppliers s
--	on p.SupplierID=s.SupplierID join OrderDetails od
--		on p.ProductID=od.ProductID
--where s.Country='USA'
--group by p.ProductName
--order by [Total] DESC

--Hangi çalışan,bugüne kadar kaç adet sipariş almış
select 
	e.FirstName,
	COUNT(*) as [total]
from Employees e join Orders o
	on e.EmployeeID=o.EmployeeID
group by e.FirstName
order by [total] DESC