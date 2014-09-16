IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[Depositos_TiposDepositos].[Id] Id
     ,[dbo].[Depositos].[DepositoID]
     ,[dbo].[TiposDepositos].[Id]
FROM
     [dbo].[Depositos_TiposDepositos]
     INNER JOIN [dbo].[Depositos] ON [dbo].[Depositos_TiposDepositos].[Id_Deposito] = [dbo].[Depositos].[DepositoID]
     INNER JOIN [dbo].[TiposDepositos] ON [dbo].[Depositos_TiposDepositos].[Id_TipoDeposito] = [dbo].[TiposDepositos].[Id]
End
