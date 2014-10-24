Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spAgenciasTransportes
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[AgenciasTransportesSelect]", _
                      "[dbo].[AgenciasTransportesInsert]", _
                      "[dbo].[AgenciasTransportesUpdate]", _
                      "[dbo].[AgenciasTransportesDelete]", _
                      "[dbo].[AgenciasTransportesSelectDgv]", _
                      "[dbo].[AgenciasTransportesSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal AgenciaTransporteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AgenciasTransportes
        Dim dbo As New DBO_AgenciasTransportes
        dbo.searchKey = dbo.item("AgenciaTransporteID")
        dbo.searchKey.value = AgenciaTransporteID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal AgenciaTransporteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AgenciasTransportes
        dbo.searchKey = dbo.item("AgenciaTransporteID")
        dbo.searchKey.value = AgenciaTransporteID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_AgenciasTransportes(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("AgenciasTransportesCbo", False, dtb)
    End Sub

End Class
