--use MoviesDb
--go

--Hangi kategoride kaç film var?
--right join ile koşula uymayan veriler olsa bile gösterilmesini sağlarız
--select 
--	c.Name as [Film],
--	COUNT(f.Id) as [Film Adedi]
--from Films f right join Categories c
--	on f.CategoryId=c.Id
--group by c.Name
--order by [Film Adedi] DESC

--Hangi yönetmenin hangi kategoriden kaç adet filmi var?

--select
--	d.Name as [Yönetmen],
--	c.Name as [Kategori],
--	COUNT(f.Id) as [Adet]
--from Directors d left join Films f
--	on f.DirectorId=d.Id left join Categories c
--		on f.CategoryId=c.Id
--group by d.Name, c.Name

--Hangi filmin oyuncusu yoktur?
--select
--	f.Name as [Film],
--	COUNT(s.Id) as [Oyuncu Adedi]
--from Films f left outer join FilmsStars fs
--	on f.Id=fs.FilmId left outer join Stars s
--		on s.Id=fs.StarId
--group by f.Name
--having COUNT(s.Id)=0

--use Northwind
--go

--Hangi kategoriden hangi tutarda satış yapılmış?

--select
--	c.CategoryName,
--	sum(od.UnitPrice * od.Quantity) as [Tutar] 
--from Categories c join Products p
--	on c.CategoryID=p.CategoryID join OrderDetails od
--		on p.ProductID=od.ProductID
--group by c.CategoryName
--order by [Tutar] DESC

--Hangi üründen kaç adet satılmış? Satışı yapılmamış ürün varsa o da listelensin
--select 
--	p.ProductName as [Ürün],
--	sum(od.Quantity) as [Adet]
--from Products p left outer join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by [Adet] desc

--select
--	p.ProductName as [Ürün]
--	from Products p left join OrderDetails od
--		on p.ProductID=od.ProductID
--group by p.ProductName
--having SUM(od.Quantity) is Null

--En çok ciro yapılan üç ürün hangisidir?

--select top(3)
--	p.ProductName as [Ürün],
--	sum(od.Quantity* od.UnitPrice) as [Ciro]
--from Products p join OrderDetails od
--	on p.ProductID=od.ProductID
--group by p.ProductName
--order by [Ciro] DESC

--Hangi müşteriye ne kadarlık satış yapılmıştır?
--select 
--	c.CompanyName as [Müşteri Adı],
--	SUM(od.UnitPrice*od.Quantity) as [Satış Miktarı]
--from Customers c right join Orders o
--	on c.CustomerID=o.CustomerID right join OrderDetails od
--			on o.OrderID=od.OrderID
--group by c.CompanyName
--order by [Satış Miktarı] DESC

--Hangi bölgede hangi üründen ne kadarlık satış yapılmıştır?
select 
	r.RegionDescription as [Bölge],
	p.ProductName as [Ürün],
	SUM(od.Quantity*od.UnitPrice) as [Satış Miktarı]
from Products p join OrderDetails od
	on p.ProductID=od.ProductID join Orders o
		on od.OrderID=o.OrderID right join Employees e
			on o.EmployeeID=e.EmployeeID join EmployeeTerritories et
				on e.EmployeeID=et.EmployeeID join Territories t
					on et.TerritoryID=t.TerritoryID join Region r
						on t.RegionID=r.RegionID
group by r.RegionDescription, p.ProductName
having SUM(od.Quantity*od.UnitPrice) >= 100000
order by r.RegionDescription, p.ProductName


	