IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosSelectDgvBy]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgvBy]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgvBy]
      @Id_Deposito int
AS 
BEGIN
SELECT
      [dbo].[Depositos_TiposDepositos].[Id]
     ,[dbo].[TiposDepositos].[Id] AS Id_TipoDeposito
FROM
     [dbo].[Depositos_TiposDepositos]
     INNER JOIN [dbo].[Depositos] ON [dbo].[Depositos_TiposDepositos].[Id_Deposito] = [dbo].[Depositos].[DepositoID]
     INNER JOIN [dbo].[TiposDepositos] ON [dbo].[Depositos_TiposDepositos].[Id_TipoDeposito] = [dbo].[TiposDepositos].[Id]
WHERE
     [dbo].[Depositos_TiposDepositos].[Id_Deposito] = @Id_Deposito

End
