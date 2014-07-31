IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoCbo]       @ID int
AS
BEGIN
 select id, Coste from CostesPorConceptoCbo where Id_ConceptosGastosIncidencias = @ID
END
GO

SET NOCOUNT ON

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[CostesPorConcepto]
WHERE
    [Id] = @Id

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoInsert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoInsert]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoInsert]
      @Id_ConceptosGastosIncidencias int
     ,@Coste decimal
     ,@Fecha date
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

INSERT INTO [dbo].[CostesPorConcepto]
     (
      Id_ConceptosGastosIncidencias
     ,Coste
     ,Fecha
     ,UsuarioModificacion
     ,FechaModificacion
     )
VALUES
     (
      @Id_ConceptosGastosIncidencias
     ,@Coste
     ,@Fecha
     ,@UsuarioModificacion
     ,@FechaModificacion
     )

END

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_ConceptosGastosIncidencias
     ,Coste
     ,Fecha
FROM
     [dbo].[CostesPorConcepto]
WHERE
    [Id] = @Id
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[CostesPorConcepto].[Id] Id
     ,[dbo].[ConceptosGastosIncidencias].[Descripcion]
     ,[dbo].[CostesPorConcepto].[Coste]
     ,[dbo].[CostesPorConcepto].[Fecha]
FROM
     [dbo].[CostesPorConcepto]
     INNER JOIN [dbo].[ConceptosGastosIncidencias] ON [dbo].[CostesPorConcepto].[Id_ConceptosGastosIncidencias] = [dbo].[ConceptosGastosIncidencias].[Id]
End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoSelectDgvBy]
      @Id_ConceptosGastosIncidencias int
AS 
BEGIN
SELECT
      [dbo].[CostesPorConcepto].[Id]
     ,[dbo].[CostesPorConcepto].[Coste]
     ,[dbo].[CostesPorConcepto].[Fecha]
FROM
     [dbo].[CostesPorConcepto]
     INNER JOIN [dbo].[ConceptosGastosIncidencias] ON [dbo].[CostesPorConcepto].[Id_ConceptosGastosIncidencias] = [dbo].[ConceptosGastosIncidencias].[Id]
WHERE
     [dbo].[CostesPorConcepto].[Id_ConceptosGastosIncidencias] = @Id_ConceptosGastosIncidencias

End

GO
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CostesPorConceptoUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CostesPorConceptoUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CostesPorConceptoUpdate] 
      @Id_ConceptosGastosIncidencias int
     ,@Coste decimal
     ,@Fecha date
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[CostesPorConcepto]
SET
      [Id_ConceptosGastosIncidencias] = @Id_ConceptosGastosIncidencias
     ,[Coste] = @Coste
     ,[Fecha] = @Fecha
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END

GO
