use POS_Microsell_Lite 
go

create proc sp_addMarca
(
@marca nvarchar (50)
)
As
insert into Marcas 
values
(
@marca
)
Go

create proc sp_Listar_Todos_Marcas
As
Select * from Marcas
order by Marca asc
go

--Create eliminar:
create proc sp_eliminar_Marca
@idmar int
As
Delete from Marcas
where
Id_Marca =@idmar 
Go

--editar:
Create proc sp_Editar_Marca
@idmar int,
@nom_marca varchar (50)
As
Update Marcas set
Marca =@nom_marca
where
Id_Marca=@idmar
go