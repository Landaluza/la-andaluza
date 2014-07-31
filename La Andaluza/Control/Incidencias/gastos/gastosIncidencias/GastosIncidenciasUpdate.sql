IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GastosIncidenciasUpdate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GastosIncidenciasUpdate]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GastosIncidenciasUpdate] 
      @Cantidad decimal
     ,@Id_concepto int
     ,@Id_costeConcepto int
     ,@Id_proveedor int
     ,@Id_empleado int
     ,@Id_cliente int
     ,@Id int
     ,@UsuarioModificacion int
     ,@FechaModificacion datetime
AS
BEGIN

SET NOCOUNT ON

UPDATE [dbo].[GastosIncidencias]
SET
      [Cantidad] = @Cantidad
     ,[Id_concepto] = @Id_concepto
     ,[Id_costeConcepto] = @Id_costeConcepto
     ,[Id_proveedor] = @Id_proveedor
     ,[Id_empleado] = @Id_empleado
     ,[Id_cliente] = @Id_cliente
     ,UsuarioModificacion = @UsuarioModificacion
     ,Fechamodificacion = @FechaModificacion
WHERE
    [Id] = @Id

END
