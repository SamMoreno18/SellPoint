USE MASTER
GO

CREATE DATABASE POS_Microsell_Lite
GO

--vamos a modificar

USE POS_Microsell_Lite
GO

CREATE TABLE [dbo].[Distrito] (
	[Id_Dis] [int] IDENTITY(1,1) NOT NULL,	
	[Distrito] [nvarchar] (50) NULL,
	[Estado_Dis] varchar (12) NULL,
	primary key (Id_Dis)
	)
GO

-- Rol (Funciones o Cargo)
CREATE TABLE [dbo].[Roles] (
	[Id_Rol] [int] NOT NULL,
	[Rol] [nvarchar] (50) NULL,
	primary key (Id_Rol)
)
GO


CREATE TABLE [Cliente] (
	[Id_Cliente] [CHAR](10) NOT NULL,		
	[Razon_Social_Nombres] [nvarchar] (250) NULL ,
	[DNI][Char](18) not null,
	[Direccion] [nvarchar] (150) NULL ,
	[Telefono][char] (10),
	[E_Mail] [nvarchar](150),
	[Id_Dis] [int] NOT NULL ,
	[Fcha_Ncmnto_Anivsrio][Datetime] null,
	[Contacto] [varchar] (50),
	[Limit_Credit][Real],
	[Estado_Cli] varchar (12) NULL,
primary key (Id_Cliente)
)
GO

CREATE TABLE Proveedor
(
	IDPROVEE CHAR (6) NOT NULL,
	NOMBRE VARCHAR (50) NOT NULL,
	DIRECCION VARCHAR (150) NULL,
	TELEFONO NCHAR (15) NULL,
	RUBRO VARCHAR (50) NULL,
	RUC NCHAR (20) NOT NULL,
	CORREO VARCHAR (150) NULL,	
	CONTACTO VARCHAR (50) NULL,	
	FOTO_LOGO VARCHAR (180) NULL,
	ESTADO_PROVDR varchar (12),
	primary key (IDPROVEE)
	)
GO


CREATE  TABLE Usuarios
(
    [Id_Usu] [Int]  NOT NULL,	
	[Nombres] [nvarchar] (50) NOT NULL ,
	[Apellidos] [nvarchar] (50) NOT NULL ,
	[Id_Dis] [int] not null,
	[Usuario] [nvarchar] (8)  NOT NULL ,
	[Contraseña] [nvarchar] (10)  NOT NULL ,
	[Ubicacion_Foto] [nvarchar] (200) NULL,
	[Fecha_Ncmiento][Datetime]Not Null,
	[Id_Rol] [int] NOT NULL,
	[Correo][varchar] (150),
	[Estado_Usu] varchar (12) ,
	primary key (Id_Usu)
) 
GO

----===============================================================
---- DEFINICION DEL PRODUCTO
----===============================================================

CREATE TABLE [dbo].[Categorias] (
	[Id_Cat] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [nvarchar] (50) NOT NULL,
	primary key (Id_Cat)
) 
GO


CREATE TABLE [dbo].[Marcas] (
	[Id_Marca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar] (50)NOT NULL,
	primary key (Id_Marca)
) 
GO

CREATE TABLE [dbo].[Productos] (
	[Id_Pro] [Char] (20) NOT NULL,	
	[IDPROVEE] [CHAR] (6) NOT NULL,
	[Descripcion_Larga] [Nvarchar](150) NOT NuLL,
	Frank Real Null,
	[Pre_CompraS] [real] NOT NULL,
	[Pre_Compra$] [real] NOT NULL,
	[Stock_Actual] [real] NOT NULL,
	[Id_Cat] [int] NOT NULL,	
	[Id_Marca] [int] NOT NULL,
	[Foto] [varchar] (180) NULL ,
	[Pre_vntaxMenor] [Real] NOt Null,
	[Pre_vntaxMayor] [Real] Not Null,
	[Pre_Vntadolar] [Real] Not Null,
	UndMedida char (6) not null,
	PesoUnit real,
	UtilidadUnit real,
	TipoProdcto varchar (12),
	Valor_porCant real,
	[Estado_Pro] [varchar] (15) NULL,
	primary key (Id_Pro)
	) 
GO

Create Table KardexProducto (
Id_krdx Char (11) Not null,
[Id_Pro] [Char] (20) NOT NULL,
IDPROVEE CHAR (6) NOT NULL,
FechaCre date,
EstadoKrdx varchar (12),
primary key (Id_krdx)
) 
GO


Create Table Detalle_Kardex (
[Id_krdx] Char (11) Not null,
[Item] int not null,
[Fecha_Krdx] Datetime not Null,
[Doc_Soporte] Nchar (20) Null,
[Det_Operacion] varchar (180) Null,
--entradas
Cantidad_In Real ,
Precio_In Real,
Total_In Real,
--Salidas
Cantidad_Out Real,
Precio_Out Real,
Total_Out   Real,
--Saldos
Cantidad_Saldo Real,
Promedio Real,
Costo_Total_Saldo Real,
primary key (Id_krdx)
) 
GO

CREATE TABLE [dbo].[Tipo_Doc] (
	[Id_Tipo] [int] NOT NULL,	
	[Documento] [nvarchar] (50) NULL,
	[Serie] [nvarchar] (3) NULL,
	[Numero] nvarchar(7) NULL,	
	[Estado_TiDoc] varchar (12) NULL,
	primary key (Id_Tipo)
) 
GO

--==============  VENTAS ===============

CREATE TABLE [dbo].[Pedido] (
	[id_Ped] [char](11) NOT NULL,	
	[Id_Cliente] [CHAR](10) NOT NULL,	
	[Fecha_Ped] [Date] NULL,
	[SubTotal] [real] NULL,		
	IgvPed real,
	[TotalPed] [real] NULL,
	[id_Usu] [int] NOT NULL ,	
	TotalGancia real,	
	[Estado_Ped] varchar (12) NULl,
	primary key (id_Ped)
) 
GO

CREATE TABLE [dbo].[Detalle_Pedido] (
	[id_Ped] [char](11) NOT NULL,	
	[Id_Pro] [Char](20) NOT NULL,
	[Precio] [real] NULL,
	[Cantidad] [real] NULL,
	[Importe] [real] NULL,
	[Tipo_Prod] varchar (20),
	[Und_Medida] varchar (10),
	[Utilidad_Unit] Real,
	TotalUtilidad real
) ON [PRIMARY]
GO


CREATE TABLE Documento (
	[id_Doc] [char](11) NOT NULL,	
	[id_Ped] [char](11) NOT NULL,	
	[Id_Tipo] [int] NOT NULL,	
	[Fecha_Emi] [Datetime] NULL ,
	[ImporteDoc][Real]not null,
	[TipoPago][varchar] (50),
	[Nro_Operacion][nchar](20),
	[Id_Usu]Int Not Null,
	[IgvDoc][Real],
	[TotalLetra]nvarchar (280),
	TotalGanancia real,
	[Estado_Doc] [varchar] (13) NULL	,
	primary key (id_Doc)
) 
GO


create table [dbo].[Caja]
(
	[Idcaja][int] IDENTITY(1,1) not null,
	Fecha_Caja datetime,
	Tipo_Caja varchar (50),
	Concepto nvarchar (190),
	De_Para varchar (180),
	Nro_Doc char (20),
	ImporteCaja real,
	Id_Usu int,
	TotalUti Real,
	TipoPago varchar (13),
	GeneradoPor Varchar (15),
	EstadoCaja varchar (13),
	primary key (Idcaja)
) 
go


Create Table [dbo].[Cierre_Caja]
(
[Id_cierre] char (10) Not Null,
[Fecha_Cierre] [Datetime] Not Null,
[Apertura_Caja][Real] Not Null,
[Total_Ingreso] real,
[TotalEgreso] Real,
[Id_Usu][Int],
[TodoDeposito] real,
[Gananciadeldia] real,
[TotalEntregado] real,
[SaldoSiguiente] real,
[TotalFactura] real,
[TotalBoleta] real,
[TotalNotaVenta] real,
[TotalCreditoCobrado] real,
[TotalCreditoEmitido] real,
Estado_cierre varchar (13),
primary key (Id_cierre)
)
Go


create table Credito
(
	IdNotaCred char (11) not null,
	Id_Doc char(11) not null,
	Fecha_Credito Datetime not null,
	Nom_Cliente varchar (50),
	Total_Cre Real,
	Saldo_Pdnte real,
	Fecha_Vncimnto date,
	Estado_Cred varchar (13) not null,
	primary key (IdNotaCred)
) 
go


create table Detalle_Credito
(
	Id_DetCred int identity (1,1) not null,
	IdNotaCred char (11) not null,
	A_cuenta real not null,
	Saldo_Actual real,
	Fecha_Pago datetime,
	TipoPago varchar (50),
	Nro_Opera_Coment nvarchar (180),
	Id_Usu int not null,
	primary key (Id_DetCred)
	) 
go


---Compras =========
CREATE TABLE DocumentoCompras(
	[Id_DocComp] [char](11) NOT NULL,
	NroFac_Fisico char (20) not null,
	IDPROVEE Char (6) NOT NULL,
	[SubTotal_ingre] [real] NULL,
	[Fecha_Ingre] [Datetime] NULL,
	[Total_Ingre] [real] not NULL,
	[id_Usu] [int] NOT NULL ,
	[ModalidadPago] [varchar] (50) NOT NULL ,
	[TiempoEspera][int]null,
	[Fecha_Vencimiento] [Datetime] Null,
	[Estado_Ingre] [varchar] (20) NULL,
	[Recibiconforme] [bit] NULL,
	[Datos_Adicional] [nvarchar](150) null,
	TipoDoc_Compra varchar (12) not null,
	primary key (Id_DocComp)
	)
Go

CREATE TABLE [dbo].[Detalle_DocumCompra] (
	[Id_DocComp] [char](11) NOT NULL,	
	[Id_Pro] [Char](20) NOT NULL,
	[PrecioUnit] [real] NULL,
	[Cantidad] [real] NULL,
	[Importe] [real] NULl
) ON [PRIMARY]
GO


Create Table Menu_xUsu
(
Id_menuxusu int identity (1,1) not null,
Nombre_menu varchar (50) not null,
Id_usu int not null,
primary key (Id_menuxusu)
) 
go

--Para las Impresiones de los comprobantes:
Create Table Temporal (
CodTem Nchar (12) not null,
FechaEmi varchar (20),
cliente varchar (150),
Ruc varchar (50),
Direccion varchar (150),
SubTtal varchar (50),
IgvT varchar (50),
TotalT varchar (50),
SonT varchar (200),
Vendedor varchar (120),
primary key (CodTem)
)
Go


Create Table Detalle_Temporal (
codTem Nchar (12) not null,
CodPro char (11) null,
cantidad nchar (20) null,
Producto varchar (60)null,
Pre_Unt Varchar (50) null,
ImporteT Varchar (50) null

)
Go

--Vales y Canjes:
Create table ValeCompra (
[IdVale] char (11) not null,
[Id_Cliente] char (10) not null,
NroDoc char (11) not null,
[ImporteVale] real,
DetalleVale varchar (220) not null,
EstadoVale varchar (12) not null,
primary key (IdVale)
)
Go















