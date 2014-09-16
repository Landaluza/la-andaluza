IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosSelectDgv]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosSelectDgv]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosSelectDgv]
AS 
BEGIN
SELECT
      [dbo].[TiposDepositos].[Id] Id
     ,[dbo].[TiposDepositos].[Nombre]
     ,[dbo].[TiposDepositos].[Observaciones]
FROM
     [dbo].[TiposDepositos]
End
