USE [farmacia]
GO

CREATE PROC proveedor_select (@proveedor INT)
AS
SELECT [id_proveedor]
       ,[nombre] 
       ,[descripcion]
       ,[telefono]
       ,[direccion]
FROM [dbo].[proveedor]
WHERE id_proveedor = @proveedor
GO