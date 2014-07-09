Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spAccionesPreventivas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AccionesPreventivasSelect]",  _
                     "[dbo].[AccionesPreventivasInsert]",  _
                     "[dbo].[AccionesPreventivasUpdate]",  _
                     "[dbo].[AccionesPreventivasDelete]",  _
                     "[dbo].[AccionesPreventivasSelectDgv]",  _
                     "[dbo].[AccionesPreventivasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AccionesPreventivas
       Dim dbo As New DBO_AccionesPreventivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AccionesPreventivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_AccionesPreventivas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("AccionesPreventivasCbo", False)
   End Sub

End Class
