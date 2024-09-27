use POS_Microsell_Lite
go


--insert:
Create procedure sp_registrar_categoria (

@nombre varchar (50)
)
as
insert into Categorias values (
@nombre 
)
go

Create procedure sp_modificar_categoria (
@idcat int,
@nombre varchar (50)
)
as
update Categorias set
Categoria =@nombre 
where
Id_Cat =@idcat
go


--conuslta:
create procedure sp_listar_todas_Categorias
as
Select * from Categorias 
order by Categoria asc
go
