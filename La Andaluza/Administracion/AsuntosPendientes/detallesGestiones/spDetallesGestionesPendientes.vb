
Public Class spDetallesGestionesPendientes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[DetallesGestionesPendientesSelect]", _
                      "[dbo].[DetallesGestionesPendientesInsert]", _
                      "[dbo].[DetallesGestionesPendientesUpdate]", _
                      "[dbo].[DetallesGestionesPendientesDelete]", _
                      "[dbo].[DetallesGestionesPendientesSelectDgv]", _
                      "[dbo].[DetallesGestionesPendientesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal DetalleGestionPendienteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_DetallesGestionesPendientes
        Dim dbo As New DBO_DetallesGestionesPendientes
        dbo.searchKey = dbo.item("DetalleGestionPendienteID")
        dbo.searchKey.value = DetalleGestionPendienteID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal DetalleGestionPendienteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_DetallesGestionesPendientes
        dbo.searchKey = dbo.item("DetalleGestionPendienteID")
        dbo.searchKey.value = DetalleGestionPendienteID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

End Class
