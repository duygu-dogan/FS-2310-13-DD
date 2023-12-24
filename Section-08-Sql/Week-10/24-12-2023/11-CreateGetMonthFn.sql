create function GetMonthName(@date date)
	returns nvarchar(10)
begin
	declare @monthNumber smallint
	set @monthNumber=MONTH(@date)
	declare @result nvarchar(10)
	set @result = (
		case @monthNumber
			when 1 then 'Ocak'
			when 2 then 'Şubat'
			when 3 then 'Mart'
			when 4 then 'Nisan'
			when 5 then 'Mayıs'
			when 6 then 'Haziran'
			when 7 then 'Temmuz'
			when 8 then 'Ağustos'
			when 9 then 'Eylül'
			when 10 then 'Ekim'
			when 11 then 'Kasım'
			when 12 then 'Aralık'
			else 'Hata'
		end)
	return @result
end
