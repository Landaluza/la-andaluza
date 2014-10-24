Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spAlturas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AlturasSelect]",  _
                     "[dbo].[AlturasInsert]",  _
                     "[dbo].[AlturasUpdate]",  _
                     "[dbo].[AlturasDelete]",  _
                     "[dbo].[AlturasSelectDgv]",  _
                     "[dbo].[AlturasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal AlturaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Alturas
        Dim dbo As New DBO_Alturas
        dbo.searchKey = dbo.item("AlturaID")
        dbo.searchKey.value = AlturaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal AlturaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Alturas
        dbo.searchKey = dbo.item("AlturaID")
        dbo.searchKey.value = AlturaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Alturas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("AlturasCbo", False, dtb)
    End Sub

End Class
