Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spcargos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[cargosSelect]", _
                      "[dbo].[cargosInsert]", _
                      "[dbo].[cargosUpdate]", _
                      "[dbo].[cargosDelete]", _
                      "[dbo].[cargosSelectDgv]", _
                      "[dbo].[cargosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_cargos
        Dim dbo As New DBO_cargos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_cargos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_cargos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("cargosCbo", False, dtb)
    End Sub

End Class
