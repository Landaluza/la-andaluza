
Public Class spPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PendientesSelect]", _
                      "[dbo].[PendientesInsert]", _
                      "[dbo].[PendientesUpdate]", _
                      "[dbo].[PendientesDelete]", _
                      "[dbo].[PendientesSelectDgv]", _
                      "[dbo].[PendientesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal PendienteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Pendientes
        Dim dbo As New DBO_Pendientes
        dbo.searchKey = dbo.item("PendienteID")
        dbo.searchKey.value = PendienteID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PendienteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Pendientes
        dbo.searchKey = dbo.item("PendienteID")
        dbo.searchKey.value = PendienteID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
