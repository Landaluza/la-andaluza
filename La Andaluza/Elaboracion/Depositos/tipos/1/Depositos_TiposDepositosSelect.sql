IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosSelect]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosSelect]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosSelect]
      @Id int
AS 
BEGIN
SELECT
      Id
     ,Id_Deposito
     ,Id_TipoDeposito
FROM
     [dbo].[Depositos_TiposDepositos]
WHERE
    [Id] = @Id
End
