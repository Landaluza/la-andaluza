
Public Class spComunicaciones
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ComunicacionesSelect]", _
                      "[dbo].[ComunicacionesInsert]", _
                      "[dbo].[ComunicacionesUpdate]", _
                      "[dbo].[ComunicacionesDelete]", _
                      "[dbo].[ComunicacionesSelectDgv]", _
                      "[dbo].[ComunicacionesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Comunicaciones
        Dim dbo As New DBO_Comunicaciones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Comunicaciones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
