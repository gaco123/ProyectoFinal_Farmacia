USE [farmacia]
GO

CREATE PROC categoria_select (@categoria INT)
AS
SELECT [id_categoria]
       ,[nombre]
       ,[descripcion]
FROM [dbo].[categoria]
WHERE id_categoria = @categoria
GO