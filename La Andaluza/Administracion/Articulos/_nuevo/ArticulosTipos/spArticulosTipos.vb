Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spArticulosTipos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ArticulosTiposSelect]", _
                      "[dbo].[ArticulosTiposInsert]", _
                      "[dbo].[ArticulosTiposUpdate]", _
                      "[dbo].[ArticulosTiposDelete]", _
                      "[dbo].[ArticulosTiposSelectDgv]", _
                      "[dbo].[ArticulosTiposSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal ArticuloTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_ArticulosTipos
        Dim dbo As New DBO_ArticulosTipos
        dbo.searchKey = dbo.item("ArticuloTipoID")
        dbo.searchKey.value = ArticuloTipoID
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ArticuloTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dbo As New DBO_ArticulosTipos
        dbo.searchKey = dbo.item("ArticuloTipoID")
        dbo.searchKey.value = ArticuloTipoID
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

   Public Sub cargar_ArticulosTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ArticulosTiposCbo", False)
   End Sub

End Class
