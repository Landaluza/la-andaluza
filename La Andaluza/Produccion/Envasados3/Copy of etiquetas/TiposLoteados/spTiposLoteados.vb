Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposLoteados
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposLoteadosSelect]",  _
                     "[dbo].[TiposLoteadosInsert]",  _
                     "[dbo].[TiposLoteadosUpdate]",  _
                     "[dbo].[TiposLoteadosDelete]",  _
                     "[dbo].[TiposLoteadosSelectDgv]",  _
                     "[dbo].[TiposLoteadosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposLoteados
        Dim dbo As New DBO_TiposLoteados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposLoteados
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_TiposLoteados(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposLoteadosCbo", False, dtb)
    End Sub

End Class
