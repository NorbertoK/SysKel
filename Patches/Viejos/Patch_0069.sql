USE datos
GO
sp_rename 'dbo.Pagos' ,'Compras' 
Go
sp_rename 'dbo.DetallesPagos' ,'DetallesCompras'
GO