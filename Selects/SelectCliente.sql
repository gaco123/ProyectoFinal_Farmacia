USE [farmacia]
GO

CREATE PROC cliente_select (@cliente INT)
AS
SELECT [id_cliente]
       ,[nombre] 
       ,[ape_paterno]
       ,[ape_materno]
       ,[telefono]
       ,[direccion]
FROM [dbo].[cliente]
WHERE id_cliente = @cliente
GO