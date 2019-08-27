use master;
go

if exists (select 1 from sys.sysdatabases where name = 'Nrp') begin
  alter database [nrp] set  single_user with rollback immediate
  drop database Nrp;
end
go

create database Nrp;
go

use Nrp;
go

create schema Ojk;
go

create table Ojk.[Status] (
  Id int identity (1,1) primary key,
  Nazwa varchar(255) unique
)
go

insert Ojk.[Status] values ('Roboczy')
go

create table Ojk.Klient (
  Id int identity (1,1) primary key,
  Nazwa varchar(255) unique,
  Opis varchar(max) null
)
go

create table Ojk.Wersja
(
	Id int identity(1,1) primary key,
	KlientId int not null,
	StatusId int not null, -- could be: default 1
	DataModyfikacji datetime2(0) not null, -- could be: default sysdatetime()
	PracownikId nvarchar(30) not null -- could be: default suser_name()
)
go

alter table [Ojk].[Wersja]  with check add  constraint [FK_Wersja_Klient] foreign key([KlientId])
references [Ojk].[Klient] ([Id])
go

alter table [Ojk].[Wersja]  with check add  constraint [FK_Wersja_Status] foreign key([StatusId])
references [Ojk].[Status] ([Id])
GO


-- Creating procedures
create procedure Ojk.ModyfikujStatus
(
	@klientId int,
	@statusId nvarchar(50)
)
as
update Ojk.Wersja
   set StatusId = @statusId, DataModyfikacji = sysdatetime(), PracownikId=suser_sname()
 where KlientId = @klientId and StatusId= 1
return @@ROWCOUNT
go

