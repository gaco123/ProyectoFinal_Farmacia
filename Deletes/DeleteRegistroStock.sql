USE [farmacia]
GO

CREATE PROC registrostock_delete
    (@registro INT)
AS
BEGIN
    DELETE [dbo].[registro_stock]
    WHERE 
        [id_registro] = @registro
END
GO