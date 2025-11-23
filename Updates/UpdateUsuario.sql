USE [farmacia]
GO

CREATE PROC usuario_update
    (@usuario INT, @rol INT, @username VARCHAR(100), @contrasena VARCHAR(50), @nombre VARCHAR(100), @ape_paterno VARCHAR(100)
    , @ape_materno VARCHAR(100), @telefono VARCHAR(9), @email VARCHAR(100))
AS
BEGIN
    UPDATE [dbo].[usuario]
    SET 
        [rol] = @rol,
        [username] = @username,
        [contrasena] = @contrasena,
        [nombre] = @nombre,
        [ape_paterno] = @ape_paterno,
        [ape_materno] = @ape_materno,
        [telefono] = @telefono,
        [email] = @email
    WHERE 
        [id_usuario] = @usuario
END
GO