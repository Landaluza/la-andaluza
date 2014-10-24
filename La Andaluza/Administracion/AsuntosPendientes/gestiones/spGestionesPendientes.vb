
Public Class spGestionesPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[GestionesPendientesSelect]", _
                      "[dbo].[GestionesPendientesInsert]", _
                      "[dbo].[GestionesPendientesUpdate]", _
                      "[dbo].[GestionesPendientesDelete]", _
                      "[dbo].[GestionesPendientesSelectDgv]", _
                      "[dbo].[GestionesPendientesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal GestionPendienteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_GestionesPendientes
        Dim dbo As New DBO_GestionesPendientes
        dbo.searchKey = dbo.item("GestionPendienteID")
        dbo.searchKey.value = GestionPendienteID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal GestionPendienteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_GestionesPendientes
        dbo.searchKey = dbo.item("GestionPendienteID")
        dbo.searchKey.value = GestionPendienteID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
