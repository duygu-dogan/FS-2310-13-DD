use Northwind
go

drop function if exists dbo.fnCalculateAge
go

create function fnCalculateAge (@birthDay date)
	returns int
begin
	declare @result int
	declare @today date
	set @today = GETDATE()
	set @result = DATEDIFF(year, @birthDay, @today)
	return @result
end
go

select dbo.fnCalculateAge('1994-2-16')
go

