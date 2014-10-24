Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTipos_contratos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[Tipos_contratosSelect]", _
                      "[dbo].[Tipos_contratosInsert]", _
                      "[dbo].[Tipos_contratosUpdate]", _
                      "[dbo].[Tipos_contratosDelete]", _
                      "[dbo].[Tipos_contratosSelectDgv]", _
                      "[dbo].[Tipos_contratosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Tipos_contratos
        Dim dbo As New DBO_Tipos_contratos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Tipos_contratos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_Tipos_contratos(comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("Tipos_ContratosCbo", False, dtb)
    End Sub

End Class
