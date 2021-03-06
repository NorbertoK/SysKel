USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[NombreCompletoDelCliente]    Script Date: 11/29/2015 13:14:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[NombreCompletoDelProveedor] 
(
	@idProveedor int
)
RETURNS varchar(300)
AS
BEGIN
	DECLARE @Result varchar(300)

	SELECT @Result = RazonSocial +  CASE
                                        WHEN isnull(NombreFantasia,'') = '' THEN ''
                                        ELSE ' ('+NombreFantasia+')'
                                    END
    FROM dbo.Proveedores
    WHERE idProveedor = @idProveedor

	RETURN @Result

END
