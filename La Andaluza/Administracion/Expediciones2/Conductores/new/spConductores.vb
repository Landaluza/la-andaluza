Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spConductores
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[ConductoresSelect]", _
                      "[dbo].[ConductoresInsert]", _
                      "[dbo].[ConductoresUpdate]", _
                      "[dbo].[ConductoresDelete]", _
                      "[dbo].[ConductoresSelectDgv]", _
                      "[dbo].[ConductoresSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal ConductorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Conductores
        Dim dbo As New DBO_Conductores
        dbo.searchKey = dbo.item("ConductorID")
        dbo.searchKey.value = ConductorID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ConductorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Conductores
        dbo.searchKey = dbo.item("ConductorID")
        dbo.searchKey.value = ConductorID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Conductores(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ConductoresCbo", False, dtb)
    End Sub

End Class
