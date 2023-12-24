use Northwind
go

--select * 
--from Products

--select *
--from Products
--where ProductID=8



--select *
--from Products
--where CategoryID=1 and UnitsInStock>=50 and SupplierID=16

--select * 
--from Products
--where CategoryID=1 or CategoryID=2

--select *
--from Products
--where UnitPrice>=50 and UnitPrice<=60

--Skaler işlemler

--select COUNT(*) as [Beverages Kategorisindeki ürün sayısı]
--from Products
--where CategoryID=1

--select min(UnitPrice) as [min ürün fiyatı]
--from Products
--select max(UnitPrice) as [min ürün fiyatı]
--from Products

--select *, od.UnitPrice * od.Quantity as [total]
--from OrderDetails OD

--select sum(od.UnitPrice * od.Quantity) as [Ciro]
--from OrderDetails OD

--select avg(od.UnitPrice * od.Quantity) [Ortalama Satış]
--from OrderDetails OD

--select 
--	E.TitleOfCourtesy + ' ' + E.FirstName + ' ' + E.LastName as [Employee], 
--	E.City, 
--	E.Country
--from Employees E

--select UPPER(E.LastName) + ' ' + E.FirstName as [Name]
--from Employees E
--select Lower(E.LastName) + ' ' + E.FirstName as [Name]
--from Employees E

--Çalışanlarımıza ad.soyad şeklinde mail adresi verilecek. Gerekli kodu yazın, geriye ad, soyad ve mail adresi dönsün.
--Örn: ad.soyad@bright.com

--select 
--	E.FirstName as [Ad], 
--	E.LastName as [Soyad],
--	LOWER(E.FirstName + '.' + E.LastName + '@bright.com') as [Mail]
--from Employees E

--select LEN(E.FirstName) as [İsim Uzunluğu]  
--from Employees E

--select P.ProductName as [Name], 
--	lower(replace(REPLACE(p.ProductName, ' ', '-'), '''', '-')) as [Url]
--from Products P

--select 
--	O.EmployeeID as [Çalışan],
--	COUNT(*) as [Satış Adedi]
--from Orders O
--group by O.EmployeeID

--select 
--	OD.OrderID,
--	SUM(OD.UnitPrice*OD.Quantity) as [Order Total]
--from OrderDetails OD
--group by OD.OrderID

select 
	o.EmployeeID,
	o.CustomerID,
	COUNT(*) as [Quantity]
from Orders o
group by o.EmployeeID, o.CustomerID

