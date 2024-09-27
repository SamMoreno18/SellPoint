use POS_Microsell_Lite 
go

--1:
create proc sp_registrar_Proveedor(
@idproveedor char (6),
@nombre varchar (50),
@direccion varchar (150),
@telefono char (15),
@rubro varchar (50),
@ruc char (20),
@correo varchar (150),
@contacto varchar (50),
@fotologo varchar (180)
)
As
insert into Proveedor values (
@idproveedor,
@nombre ,
@direccion ,
@telefono ,
@rubro ,
@ruc ,
@correo,
@contacto,
@fotologo,
'Activo'
)
Go

--inser:
create proc sp_Modificar_Proveedor(
@idproveedor char (6),
@nombre varchar (50),
@direccion varchar (150),
@telefono char (15),
@rubro varchar (50),
@ruc char (20),
@correo varchar (150),
@contacto varchar (50),
@fotologo varchar (180)
)
As
update Proveedor set 
[NOMBRE]=@nombre ,
[DIRECCION]=@direccion ,
[TELEFONO]=@telefono ,
[RUBRO]=@rubro ,
[RUC]=@ruc ,
[CORREO]=@correo ,
[CONTACTO]=@contacto ,
[FOTO_LOGO]=@fotologo
Where
[IDPROVEE]=@idproveedor 
Go


--listar_Todos_Pr
Create procedure sp_Listar_Todos_Proveedores
as
select * from Proveedor
order by NOMBRE Asc
go


create procedure sp_buscar_proveedor_porvalor (
@valor varchar (50)
)
as
select * from Proveedor
where
idprovee=@valor or
RUC=@valor or
NOMBRE like '%' + @valor or
NOMBRE like @valor + '%'
order by NOMBRE Asc
go



