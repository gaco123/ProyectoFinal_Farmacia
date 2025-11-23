USE [farmacia]
GO

CREATE PROC rol_select (@rol INT)
AS
SELECT [id_rol]
       ,[nombre] 
       ,[descripcion]
FROM [dbo].[rol]
WHERE id_rol = @rol
GO