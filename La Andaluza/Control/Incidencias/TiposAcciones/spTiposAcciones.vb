Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposAcciones
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposAccionesSelect]",  _
                     "[dbo].[TiposAccionesInsert]",  _
                     "[dbo].[TiposAccionesUpdate]",  _
                     "[dbo].[TiposAccionesDelete]",  _
                     "[dbo].[TiposAccionesSelectDgv]",  _
                     "[dbo].[TiposAccionesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposAcciones
        Dim dbo As New DBO_TiposAcciones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposAcciones
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposAcciones(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposAccionesCbo", False, dtb)
    End Sub

End Class
