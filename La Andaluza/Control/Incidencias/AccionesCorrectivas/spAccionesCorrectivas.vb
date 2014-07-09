Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spAccionesCorrectivas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AccionesCorrectivasSelect]",  _
                     "[dbo].[AccionesCorrectivasInsert]",  _
                     "[dbo].[AccionesCorrectivasUpdate]",  _
                     "[dbo].[AccionesCorrectivasDelete]",  _
                     "[dbo].[AccionesCorrectivasSelectDgv]",  _
                     "[dbo].[AccionesCorrectivasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AccionesCorrectivas
       Dim dbo As New DBO_AccionesCorrectivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AccionesCorrectivas
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_AccionesCorrectivas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("AccionesCorrectivasCbo", False)
   End Sub

End Class
