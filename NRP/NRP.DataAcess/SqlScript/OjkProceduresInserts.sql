set nocount on;
use Nrp;
go

create table Ojk.Pytania(
id int identity,
pytanie varchar(20),
trescPytania varchar(100)
)
go


insert into Ojk.Pytania (pytanie, trescPytania)
values ('P_01_01','Pytanie 1'),
('P_01_02','Pytanie 2'),
('P_01_03','Pytanie 3'),
('P_01_04','Pytanie 4'),
('P_02_05','Pytanie 5'),
('P_02_06','Pytanie 6'),
('P_02_07','Pytanie 7')
go


create table Ojk.OdpowiedziPunkty(
id int identity,
pytanie varchar(20),
odpowiedz varchar(10),
punkty int
)
go

insert into Ojk.OdpowiedziPunkty (pytanie, odpowiedz, punkty)
values ('P_01_01','Odp 1',1),
('P_01_02','Odp 1',2),
('P_01_03','Odp 1',3),
('P_01_04','Odp 1',1),
('P_02_05','Odp 1',2),
('P_02_06','Odp 1',3),
('P_02_07','Odp 1',1),
('P_01_01','Odp 2',0),
('P_01_02','Odp 2',-1),
('P_01_03','Odp 2',0),
('P_01_04','Odp 2',-1),
('P_02_05','Odp 2',1),
('P_02_06','Odp 2',0),
('P_02_07','Odp 2',-1),
('P_01_01','Odp 3',3),
('P_01_02','Odp 3',1),
('P_01_03','Odp 3',2),
('P_01_04','Odp 3',0),
('P_02_07','Odp 3',5),
('P_02_07','Odp 4',-2)
go

create table Ojk.WersjaPola (
id int identity,
idWersji int,
pytanie varchar(20),
odpowiedz varchar(10)
)
go

ALTER TABLE Ojk.WersjaPola  WITH CHECK ADD  CONSTRAINT [FK_Status_Pola] FOREIGN KEY(idWersji)
REFERENCES [Ojk].[status] ([Id])
GO

ALTER TABLE Ojk.WersjaPola CHECK CONSTRAINT [FK_Status_Pola]
GO


create procedure Ojk.sp_WersjaWynik(
@idWersji int
)
as
declare @wynik int

select @wynik = sum(op.punkty)
from
	ojk.Status w
	left join
	ojk.WersjaPola wp
	on w.Id = wp.idWersji 
	left join
	ojk.OdpowiedziPunkty op
	on wp.pytanie = op.pytanie and wp.odpowiedz = op.odpowiedz 
where
	w.Id = @idWersji

return @wynik
go


create function Ojk.fn_WersjaWynik(
@idWersji int
)
returns int
as
begin
declare @wynik int
select @wynik = sum(op.punkty)
from
	ojk.Status w
	left join
	ojk.WersjaPola wp
	on w.Id = wp.idWersji 
	left join
	ojk.OdpowiedziPunkty op
	on wp.pytanie = op.pytanie and wp.odpowiedz = op.odpowiedz 
where
	w.Id = @idWersji

return @wynik
end
go

insert into ojk.WersjaPola (idWersji, pytanie, odpowiedz)
values (1,'P_01_01','Odp 1'),
(1,'P_01_02','Odp 2'),
(1,'P_01_03','Odp 1'),
(1,'P_01_04','Odp 1'),
(1,'P_02_05','Odp 2'),
(1,'P_02_06','Odp 2'),
(1,'P_02_07','Odp 7')
go

--select sum(op.punkty)
--from
--	ojk.Status w
--	left join
--	ojk.WersjaPola wp
--	on w.Id = wp.idWersji 
--	left join
--	ojk.OdpowiedziPunkty op
--	on wp.pytanie = op.pytanie and wp.odpowiedz = op.odpowiedz 
--where
--	w.Id = 1



create procedure Ojk.sp_DodajPole(
@idwersj int,
@pytanie varchar(20),
@odpowiedz varchar(10)
)
as
begin try
	begin tran j1
	declare @wynik int
	insert into Ojk.WersjaPola (idWersji, pytanie, odpowiedz)
	values (@idwersj, @odpowiedz, @pytanie)
	set @wynik = SCOPE_IDENTITY() 
	return @wynik 
	commit tran j1
end try
begin catch
	rollback tran j1
	return -1
end catch
go

create procedure Ojk.sp_UsunPola(
@idwersj int
)
as
delete from Ojk.WersjaPola where idWersji = @idwersj
go

create view Ojk.v_Form_Odpowiedzi as
select op.id idOdpowiedzi, p.trescPytania, op.odpowiedz
  from Ojk.Pytania p
  join Ojk.OdpowiedziPunkty op 
    on p.pytanie = op.pytanie
go

select * 
  from Ojk.v_Form_Odpowiedzi