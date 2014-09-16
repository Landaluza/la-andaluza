IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Depositos_TiposDepositosDelete]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Depositos_TiposDepositosDelete]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Depositos_TiposDepositosDelete] 
      @Id int
AS
BEGIN

SET NOCOUNT ON


DELETE FROM [dbo].[Depositos_TiposDepositos]
WHERE
    [Id] = @Id

END
