/*
	Stored Procedure
	Server üzerinde çalıştırılan kod parçalarıdır. Functionlara göre daha güvenli ve hızlı çalışırlar.
	Bu yüzden de daha çok tercih edilirler.
*/
use Northwind
go

drop procedure if exists spSample
go

create procedure spSample
as 
	select * from  Products p
	where p.CategoryID=1
	order by p.UnitPrice desc
go
execute spSample
go