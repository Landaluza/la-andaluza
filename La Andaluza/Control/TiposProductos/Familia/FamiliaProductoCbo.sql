IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FamiliaProductoCbo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[FamiliaProductoCbo]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[FamiliaProductoCbo]
AS 
BEGIN
SELECT
      Id
     ,Nombre
FROM
     [dbo].[FamiliaProducto]
End
