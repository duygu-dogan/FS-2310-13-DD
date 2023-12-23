/*
	Daha önceden FilmDb adıyla oluşturduğumuz veri tabanını MoviesDb adıyla Sql sorguları yazarak oluşturunuz.
*/

use master
go

drop database if exists MoviesDb
go

create database MoviesDb
go

use MoviesDb
go

create table Categories(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Description nvarchar(100),
	IsActive bit default 1 not null,
	CreatedDate datetime default getdate() not null
)
go

insert into Categories(Name) values
	('Macera'),
	('Komedi'),
	('Duygusal')
go

create table Directors(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	Gender bit not null,
	Age smallint,
	IsActive bit default 1 not null,
	CreatedDate datetime default getdate() not null
)
go
insert into Directors(Name, Gender) values
	('Ferzan', 1), ('Kemal', 0), ('Suzan', 1), ('Kadir', 0), ('Duygu', 1), ('Baransel',0)

create table Films(
	Id int primary key identity(1,1),
	Name nvarchar(50) not null,
	CategoryId int foreign key references Categories(Id),
	DirectorId int foreign key references Directors(Id),
	IsActive bit default 1 not null,
	CreatedDate datetime default getdate() not null
)
go
insert into Films(Name, CategoryId, DirectorId) values
	('Özgürlüğe Kaçış', 1, 1),
	('Ölümlü Dünya', 1, 1),
	('Sevgi Yolu', 1, 1),
	('Big Bang Theory', 1, 2),
	('La Casa de Papel', 1, 2),
	('Hababam Sınıfı', 2, 2),
	('Zindan Adası', 2, 3),
	('Melekler Şehri', 2, 3),
	('Prestij', 2, 3),
	('Kaybedenler Kulübü', 2, 3),
	('Leon', 2, 3),
	('Hızlı ve öfkeli', 2, 4),
	('Görevimiz Tehlike', 2, 4),
	('Esaretin Bedeli', 2, 5),
	('Yüzüklerin Efendisi', 1, 5),
	('Inception', 1, 6),
	('Bilmiyorum', 1, 6)
go

create table Stars(
	Id int primary key identity(1,1),
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Gender bit not null,
	Age smallint not null,
	IsActive bit default 1 not null,
	CreatedDate datetime default getdate() not null
)
go

insert into Stars(FirstName, LastName, Gender, Age) values
	('Ali','Can', 0, 32),
	('Sezen','Kültablası', 1, 35),
	('Kumru','Camdanbakan', 1, 24),
	('Ayşe','Günükurtaran', 1, 32),
	('Halil','Yürekyakan', 0, 45)
go

create table FilmsStars (
	StarId int foreign key references Stars(Id),
	FilmId int foreign key references Films(Id),
	constraint [PK_FilmsStars] primary key clustered (StarId, FilmId) on [primary]
)
go

insert into FilmsStars(StarId, FilmId) values
	(1,1),(1,4),(1,7),(1,12),(1,11),
	(2,1),(2,6),(2,7),(2,8),
	(3,9),
	(4,2),(4,3),(4,4),
	(5,9),(5,10)
go



