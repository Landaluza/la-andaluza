Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spDepartamentos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[DepartamentosSelect]", _
                      "[dbo].[DepartamentosInsert]", _
                      "[dbo].[DepartamentosUpdate]", _
                      "[dbo].[DepartamentosDelete]", _
                      "[dbo].[DepartamentosSelectDgv]", _
                      "[dbo].[DepartamentosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Departamentos
        Dim dbo As New DBO_Departamentos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Departamentos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_Departamentos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("DepartamentosCbo", False, dtb)
    End Sub

End Class
