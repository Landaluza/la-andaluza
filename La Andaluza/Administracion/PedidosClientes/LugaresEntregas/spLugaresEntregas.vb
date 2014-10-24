Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spLugaresEntregas
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[LugaresEntregasSelect]", _
                      "[dbo].[LugaresEntregasInsert]", _
                      "[dbo].[LugaresEntregasUpdate]", _
                      "[dbo].[LugaresEntregasDelete]", _
                      "[dbo].[LugaresEntregasSelectDgv]", _
                      "[dbo].[LugaresEntregasSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal LugarEntregaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_LugaresEntregas
        Dim dbo As New DBO_LugaresEntregas
        dbo.searchKey = dbo.item("LugarEntregaID")
        dbo.searchKey.value = LugarEntregaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal LugarEntregaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_LugaresEntregas
        dbo.searchKey = dbo.item("LugarEntregaID")
        dbo.searchKey.value = LugarEntregaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_LugaresEntregas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("LugaresEntregasCbo", False, dtb)
    End Sub

End Class
