Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposAcciones
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposAccionesSelect]",  _
                     "[dbo].[TiposAccionesInsert]",  _
                     "[dbo].[TiposAccionesUpdate]",  _
                     "[dbo].[TiposAccionesDelete]",  _
                     "[dbo].[TiposAccionesSelectDgv]",  _
                     "[dbo].[TiposAccionesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposAcciones
       Dim dbo As New DBO_TiposAcciones
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TiposAcciones
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_TiposAcciones(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposAccionesCbo", False)
   End Sub

End Class
