IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Nombre
     ,Observaciones
FROM
     [dbo].[TiposDepositos]
WHERE
    [Id] = @Id
End
