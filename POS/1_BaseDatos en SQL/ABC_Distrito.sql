use POS_Microsell_Lite 
go

--1
create proc sp_addDistrito
(
@distrito nvarchar (50)
)
As
insert into Distrito 
values
(
@distrito ,
'Activo'
)
Go

create proc sp_Listar_Todos_Distritos
As
Select * from Distrito 
order by Distrito asc
go

--Create eliminar:
create proc sp_eliminar_distrito
@idDis int
As
Delete from Distrito 
where
Id_Dis =@idDis 
Go

--editar:
Create proc sp_Editar_Distrito
@idDis int,
@nomdis varchar (50)
As
Update Distrito set
Distrito =@nomdis 
where
Id_Dis =@idDis 
go