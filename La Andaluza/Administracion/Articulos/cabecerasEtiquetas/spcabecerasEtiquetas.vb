Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spcabecerasEtiquetas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[cabecerasEtiquetasSelect]", _
                      "[dbo].[cabecerasEtiquetasInsert]", _
                      "[dbo].[cabecerasEtiquetasUpdate]", _
                      "[dbo].[cabecerasEtiquetasDelete]", _
                      "[dbo].[cabecerasEtiquetasSelectDgv]", _
                      "[dbo].[cabecerasEtiquetasSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_cabecerasEtiquetas
       Dim dbo As New DBO_cabecerasEtiquetas
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_cabecerasEtiquetas
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_cabecerasEtiquetas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("cabecerasEtiquetasCbo", False)
   End Sub

End Class
