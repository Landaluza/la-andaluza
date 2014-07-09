Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spelaboraciones_fases
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[elaboraciones_fasesSelect]", _
                      "[dbo].[elaboraciones_fasesInsert]", _
                      "[dbo].[elaboraciones_fasesUpdate]", _
                      "[dbo].[elaboraciones_fasesDelete]", _
                      "[dbo].[elaboraciones_fasesSelectDgv]", _
                      "[dbo].[elaboraciones_fasesSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_elaboraciones_fases
       Dim dbo As New DBO_elaboraciones_fases
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_elaboraciones_fases
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Public Sub cargar_elaboraciones_fases(ByRef cbo As ComboBox, ByVal idGranel As Integer)
        cbo.mam_DataSource("elaboraciones_fasesCbo " & idGranel, False)
    End Sub

    Public Function insertar(ByRef dbo As BasesParaCompatibilidad.DataBussines) As Boolean
        Return Me.InsertProcedure(dbo)
    End Function

    Public Function modificar(ByRef dbo As BasesParaCompatibilidad.DataBussines) As Boolean
        Return Me.UpdateProcedure(dbo)
    End Function
End Class
