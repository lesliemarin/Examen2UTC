﻿CREATE TABLE dbo.TipoCliente (
IdTipoCliente  INT  NOT NULL IDENTITY(1,1) CONSTRAINT [PK_TipoCliente] PRIMARY KEY CLUSTERED (IdTipoCliente ASC),
NombreTipoCliente VARCHAR (50) NULL
)

WITH (DATA_COMPRESSION = PAGE)
GO