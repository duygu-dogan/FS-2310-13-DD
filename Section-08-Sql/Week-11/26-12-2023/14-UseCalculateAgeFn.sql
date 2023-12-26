use Northwind
go

select 
	e.FirstName + ' ' + e.LastName as [Çalışan],
	dbo.fnCalculateAge(e.BirthDate) as [Yaş]
from Employees e
order by [Yaş] desc 