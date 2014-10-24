Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spNaves
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[NavesSelect]",  _
                     "[dbo].[NavesInsert]",  _
                     "[dbo].[NavesUpdate]",  _
                     "[dbo].[NavesDelete]",  _
                     "[dbo].[NavesSelectDgv]",  _
                     "[dbo].[NavesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal NaveID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Naves
        Dim dbo As New DBO_Naves
        dbo.searchKey = dbo.item("NaveID")
        dbo.searchKey.value = NaveID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal NaveID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Naves
        dbo.searchKey = dbo.item("NaveID")
        dbo.searchKey.value = NaveID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Naves(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("NavesCbo", False, dtb)
    End Sub

End Class
