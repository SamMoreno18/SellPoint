use POS_Microsell_Lite 
go

-- Relacionando las Tablas:

ALTER TABLE [dbo].[Cliente] ADD 
	CONSTRAINT [FK_Cli_Dis] FOREIGN KEY 
	(
		[Id_Dis]
	) REFERENCES [dbo].[Distrito] (
		[Id_Dis]
	)
GO

ALTER TABLE [dbo].[Usuarios] ADD 
	CONSTRAINT [FK_Usu_Dis] FOREIGN KEY 
	(
		[Id_Dis]
	) REFERENCES [dbo].[Distrito] (
		[Id_Dis]
	)
GO




ALTER TABLE [dbo].[Productos] ADD 
	CONSTRAINT [FK_Prod_Cat] FOREIGN KEY 
	(
		[Id_Cat]
	) REFERENCES [dbo].[Categorias] (
		[Id_Cat]
	),
	CONSTRAINT [FK_Prod_Mark] FOREIGN KEY 
	(
		[id_Marca]
	) REFERENCES [dbo].[Marcas] (
		[id_Marca]
	),
	
	CONSTRAINT [FK_provd] FOREIGN KEY 
	(
		[IDPROVEE]
	) REFERENCES [dbo].[PROVEEDOR] (
		[IDPROVEE]
	)
GO

ALTER TABLE [dbo].[KardexProducto] ADD 
	CONSTRAINT [FK_Kar_Prod] FOREIGN KEY 
	(
		[Id_Pro]
	) REFERENCES [dbo].[Productos] (
		[Id_Pro]
	)
GO

ALTER TABLE [dbo].[KardexProducto] ADD 
	CONSTRAINT [FK_Kar_Provee] FOREIGN KEY 
	(
		[IDPROVEE]
	) REFERENCES [dbo].[Proveedor] (
		[IDPROVEE]
	)
GO


ALTER TABLE [dbo].[Detalle_Kardex] ADD 
	CONSTRAINT [FK_Kar_det] FOREIGN KEY 
	(
		[Id_krdx]
	) REFERENCES [dbo].[KardexProducto] (
		[Id_krdx]
	)
GO



ALTER TABLE [dbo].[Pedido] ADD 
	CONSTRAINT [FK_Ped_cli] FOREIGN KEY 
	(
		[Id_Cliente]
	) REFERENCES [dbo].[Cliente] (
		[Id_Cliente]
	),
	CONSTRAINT [FK_Ped_usu] FOREIGN KEY 
	(
		[id_Usu]
	) REFERENCES [dbo].[Usuarios] (
		[id_Usu]
	)
GO

ALTER TABLE [dbo].[Detalle_Pedido] ADD 
	CONSTRAINT [FK_det_ped] FOREIGN KEY 
	(
		[id_Ped]
	) REFERENCES [dbo].[Pedido] (
		[id_Ped]
	),
	CONSTRAINT [FK_det_Prd] FOREIGN KEY 
	(
		[Id_Pro]
	) REFERENCES [dbo].[Productos] (
		[Id_Pro]
	)
GO

ALTER TABLE [dbo].[Documento] ADD 
	CONSTRAINT [FK_doc_ped] FOREIGN KEY 
	(
		[id_Ped]
	) REFERENCES [dbo].[Pedido] (
		[id_Ped]
	),	
	CONSTRAINT [FK_doc_tip] FOREIGN KEY 
	(
		[Id_Tipo]
	) REFERENCES [dbo].[Tipo_Doc] (
		[Id_Tipo]
	)
GO

ALTER TABLE [dbo].[Credito] ADD 
	CONSTRAINT [FK_cre_doc] FOREIGN KEY 
	(
		[Id_Doc]
	) REFERENCES [dbo].[Documento] (
		[Id_Doc]
	)
GO

ALTER TABLE [dbo].[Detalle_Credito] ADD 
	CONSTRAINT [FK_cre_det] FOREIGN KEY 
	(
		[IdNotaCred]
	) REFERENCES [dbo].[Credito] (
		[IdNotaCred]
	),
	CONSTRAINT [FK_cred_usudet] FOREIGN KEY 
	(
		[id_Usu]
	) REFERENCES [dbo].[Usuarios] (
		[id_Usu]
	)

GO



ALTER TABLE [dbo].[DocumentoCompras] ADD 
	CONSTRAINT [FK_com_prov] FOREIGN KEY 
	(
		[IDPROVEE]
	) REFERENCES [dbo].[Proveedor] (
		[IDPROVEE]
	),
	CONSTRAINT [FK_com_usu] FOREIGN KEY 
	(
		[id_Usu]
	) REFERENCES [dbo].[Usuarios] (
		[id_Usu]
	)

GO


ALTER TABLE [dbo].[Detalle_DocumCompra] ADD 
	CONSTRAINT [FK_detcom] FOREIGN KEY 
	(
		[Id_DocComp]
	) REFERENCES [dbo].[DocumentoCompras] (
		[Id_DocComp]
	),
	CONSTRAINT [FK_detcom_prod] FOREIGN KEY 
	(
		[Id_Pro]
	) REFERENCES [dbo].[Productos] (
		[Id_Pro]
	)

GO

ALTER TABLE [dbo].[Menu_xUsu] ADD 
	CONSTRAINT [FK_mnuusu] FOREIGN KEY 
	(
		[Id_usu]
	) REFERENCES [dbo].[Usuarios] (
		[Id_usu]
	)
GO

ALTER TABLE [dbo].[Detalle_Temporal] ADD 
	CONSTRAINT [FK_tem_Det] FOREIGN KEY 
	(
		[codTem]
	) REFERENCES [dbo].[Temporal] (
		[codTem]
	)
GO

--Desde aqui:

ALTER TABLE [dbo].[Caja] ADD 
	
	CONSTRAINT [FK_caja_usu] FOREIGN KEY 
	(
		[id_Usu]
	) REFERENCES [dbo].[Usuarios] (
		[id_Usu]
	)

GO


ALTER TABLE [dbo].[Menu_xUsu] ADD 
	
	CONSTRAINT [FK_mnu_usu] FOREIGN KEY 
	(
		[id_Usu]
	) REFERENCES [dbo].[Usuarios] (
		[id_Usu]
	)

GO


ALTER TABLE [dbo].[ValeCompra] ADD 
	
	CONSTRAINT [FK_val_cli] FOREIGN KEY 
	(
		[Id_Cliente]
	) REFERENCES [dbo].[Cliente] (
		[Id_Cliente]
	)

GO



ALTER TABLE [dbo].[Cierre_Caja] ADD 
	
	CONSTRAINT [FK_cirre_usu] FOREIGN KEY 
	(
		[id_Usu]
	) REFERENCES [dbo].[Usuarios] (
		[id_Usu]
	)

GO


ALTER TABLE [dbo].[Usuarios] ADD 
	
	CONSTRAINT [FK_rol_usu] FOREIGN KEY 
	(
		[Id_Rol]
	) REFERENCES [dbo].[Roles] (
		[Id_Rol]
	)

GO