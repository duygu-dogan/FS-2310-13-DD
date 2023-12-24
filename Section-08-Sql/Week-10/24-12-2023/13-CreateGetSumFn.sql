--Kendisine gönderilecek iki adet sayıyı toplayıp sonucu döndüren function
drop function if exists dbo.GetSum
go

create function GetSum (@num1 int, @num2 int)
	returns int
begin
	declare @sum int
	set @sum=@num1+@num2
	return @sum
end

--select dbo.GetSum(8, 5) as [Total]



