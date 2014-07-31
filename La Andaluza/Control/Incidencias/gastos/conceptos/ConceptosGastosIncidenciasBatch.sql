IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasCbo]
AS 
BEGIN
SELECT
      
     Id,Descripcion
FROM
     [dbo].[ConceptosGastosIncidencias]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[ConceptosGastosIncidencias]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasInsert]
      @Descripcion varchar(50)
     ,@Id_tiposConceptos int
     ,@Id_medidaProducto int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[ConceptosGastosIncidencias]
     (
      Descripcion
     ,Id_tiposConceptos
     ,Id_medidaProducto
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Descripcion
     ,@Id_tiposConceptos
     ,@Id_medidaProducto
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Descripcion
     ,Id_tiposConceptos
     ,Id_medidaProducto
FROM
     [dbo].[ConceptosGastosIncidencias]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[ConceptosGastosIncidencias].[Id] Id
     ,[dbo].[ConceptosGastosIncidencias].[Descripcion]
     ,[dbo].[TiposConceptos].[Descripcion]
     ,[dbo].[MedidasProductos].[Descripcion]
FROM
     [dbo].[ConceptosGastosIncidencias]
     INNER JOIN [dbo].[TiposConceptos] ON [dbo].[ConceptosGastosIncidencias].[Id_tiposConceptos] = [dbo].[TiposConceptos].[Id]
     INNER JOIN [dbo].[MedidasProductos] ON [dbo].[ConceptosGastosIncidencias].[Id_medidaProducto] = [dbo].[MedidasProductos].[MedidaID]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConceptosGastosIncidenciasUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[ConceptosGastosIncidenciasUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ConceptosGastosIncidenciasUpdate] 
      @Descripcion varchar(50)
     ,@Id_tiposConceptos int
     ,@Id_medidaProducto int
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[ConceptosGastosIncidencias]
SET
      [Descripcion] = @Descripcion
     ,[Id_tiposConceptos] = @Id_tiposConceptos
     ,[Id_medidaProducto] = @Id_medidaProducto
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
