--Functions
/*
	- Geriye deßer dîndÅrebilen yapçlardçr.
	- Sorgularçn iáinde kullançlabilirler.
	- Geriye bir DE¶ER ya da TABLO dîndÅrebilirler.
	- Parametre alabilirler.
	- Bir fonksiyon tablo Åzerinde INSERT, UPDATE, DELETE gibi iülemleri YAPAMAZ. Ama INSERT, UPDATE, DELETE sorgusu iáinde de fonk. kullançlabilir.
*/
--Deßiüken ismi mutlaka @ iüareti ile baülar
create function fnSample(@txt nvarchar(10)) returns nvarchar(10)
begin 