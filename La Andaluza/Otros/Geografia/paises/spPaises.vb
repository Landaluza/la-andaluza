Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPaises
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PaisesSelect]", "[dbo].[PaisesInsert]", "[dbo].[PaisesUpdate]", "[dbo].[PaisesDelete]", "[dbo].[PaisesSelectDgv]", "[dbo].[PaisesSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal PaisID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Paises
       Dim dbo As New DBO_Paises
       dbo.searchKey = dbo.item("PaisID")
       dbo.searchKey.value = PaisID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PaisID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Paises
       dbo.searchKey = dbo.item("PaisID")
       dbo.searchKey.value = PaisID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ComboBox(ByRef cbo As ComboBox)
        cbo.mam_DataSource("PaisesCbo", False)
   End Sub

End Class
