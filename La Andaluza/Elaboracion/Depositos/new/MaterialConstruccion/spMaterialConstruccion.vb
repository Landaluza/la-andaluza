Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMaterialConstruccion
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MaterialConstruccionSelect]",  _
                     "[dbo].[MaterialConstruccionInsert]",  _
                     "[dbo].[MaterialConstruccionUpdate]",  _
                     "[dbo].[MaterialConstruccionDelete]",  _
                     "[dbo].[MaterialConstruccionSelectDgv]",  _
                     "[dbo].[MaterialConstruccionSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal MaterialConstruccionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_MaterialConstruccion
        Dim dbo As New DBO_MaterialConstruccion
        dbo.searchKey = dbo.item("MaterialConstruccionID")
        dbo.searchKey.value = MaterialConstruccionID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MaterialConstruccionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_MaterialConstruccion
        dbo.searchKey = dbo.item("MaterialConstruccionID")
        dbo.searchKey.value = MaterialConstruccionID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_MaterialConstruccion(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MaterialConstruccionCbo", False, dtb)
    End Sub

End Class
