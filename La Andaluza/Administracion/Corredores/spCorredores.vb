Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spCorredores
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[CorredoresSelect]", _
                      "[dbo].[CorredoresInsert]", _
                      "[dbo].[CorredoresUpdate]", _
                      "[dbo].[CorredoresDelete]", _
                      "[dbo].[CorredoresSelectDgv]", _
                      "[dbo].[CorredoresSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal CorredorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Corredores
        Dim dbo As New DBO_Corredores
        dbo.searchKey = dbo.item("CorredorID")
        dbo.searchKey.value = CorredorID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal CorredorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Corredores
        dbo.searchKey = dbo.item("CorredorID")
        dbo.searchKey.value = CorredorID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Corredores(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("CorredoresCbo", False, dtb)
    End Sub

End Class
