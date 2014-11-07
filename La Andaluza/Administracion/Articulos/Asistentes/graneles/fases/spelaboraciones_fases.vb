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

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_elaboraciones_fases
        Dim dbo As New DBO_elaboraciones_fases
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_elaboraciones_fases
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_elaboraciones_fases(ByRef cbo As ComboBox, ByVal idGranel As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("elaboraciones_fasesCbo @id")
        dtb.AñadirParametroConsulta("@id", idGranel)
        cbo.mam_DataSource(dtb.Consultar(), False)
    End Sub

    Public Function insertar(ByRef dbo As BasesParaCompatibilidad.DataBussines, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return Me.InsertProcedure(dbo, dtb)
    End Function

    Public Function modificar(ByRef dbo As BasesParaCompatibilidad.DataBussines, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return Me.UpdateProcedure(dbo, dtb)
    End Function
End Class
