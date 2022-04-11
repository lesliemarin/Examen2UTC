    CREATE PROCEDURE [dbo].[ClienteObtener]
        @IdCliente INT

    AS
    BEGIN 
        SET NOCOUNT ON

        SELECT 
     IdCliente ,
    Identificacion ,
    IdTipoIdentificacion ,
    Nombre,
    PrimerApellido,
    SegundoApellido ,
    FechaNacimiento,
    Nacionalidad ,
    FechaDefuncion,
    Genero ,
    NombreApellidosPadre ,
    NombreApellidosMadre,
    Pasaporte,
    CuentaIBAN ,
    CorreoNotifica
        FROM
            dbo.Cliente
        WHERE
            (@IdCliente IS NULL OR IdCliente=@IdCliente)
          

    END
