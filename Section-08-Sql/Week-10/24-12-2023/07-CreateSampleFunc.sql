--Functions
/*
	- Geriye de�er d�nd�rebilen yap�lard�r.
	- Sorgular�n i�inde kullan�labilirler.
	- Geriye bir DE�ER ya da TABLO d�nd�rebilirler.
	- Parametre alabilirler.
	- Bir fonksiyon tablo �zerinde INSERT, UPDATE, DELETE gibi i�lemleri YAPAMAZ. Ama INSERT, UPDATE, DELETE sorgusu i�inde de fonk. kullan�labilir.
*/
--De�i�ken ismi mutlaka @ i�areti ile ba�lar
create function fnSample(@txt nvarchar(max)) 
	returns nvarchar(max)
begin
	return upper(@txt)
end



