Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spArticulosEtiquetasTipos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosEtiquetasTiposSelect]", _
                      "[dbo].[ArticulosEtiquetasTiposInsert]", _
                      "[dbo].[ArticulosEtiquetasTiposUpdate]", _
                      "[dbo].[ArticulosEtiquetasTiposDelete]", _
                      "[dbo].[ArticulosEtiquetasTiposSelectDgv]", _
                      "[dbo].[ArticulosEtiquetasTiposSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal ArticuloEtiquetaTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ArticulosEtiquetasTipos
       Dim dbo As New DBO_ArticulosEtiquetasTipos
       dbo.searchKey = dbo.item("ArticuloEtiquetaTipoID")
       dbo.searchKey.value = ArticuloEtiquetaTipoID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ArticuloEtiquetaTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_ArticulosEtiquetasTipos
       dbo.searchKey = dbo.item("ArticuloEtiquetaTipoID")
       dbo.searchKey.value = ArticuloEtiquetaTipoID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_ArticulosEtiquetasTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ArticulosEtiquetasTiposCbo", False)
   End Sub

End Class
