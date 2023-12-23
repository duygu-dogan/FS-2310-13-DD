use MoviesDb
go

--select * from Categories

--select 
--	Name as [Film Adı], 
--	IsActive as [Aktif mi?], 
--	CreatedDate as [Oluşturulma Tarihi]
--from Films

select
	Name,
	IsActive,
	CreatedDate
from Films
where IsActive=0i 

