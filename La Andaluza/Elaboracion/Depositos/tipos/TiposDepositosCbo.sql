IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TiposDepositosCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[TiposDepositosCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[TiposDepositosCbo]
AS 
BEGIN
SELECT
      Id
     ,Nombre
FROM
     [dbo].[TiposDepositos]
End
