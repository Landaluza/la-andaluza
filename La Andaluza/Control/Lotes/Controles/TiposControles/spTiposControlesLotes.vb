Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposControlesLotes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposControlesLotesSelect]",  _
                     "[dbo].[TiposControlesLotesInsert]",  _
                     "[dbo].[TiposControlesLotesUpdate]",  _
                     "[dbo].[TiposControlesLotesDelete]",  _
                     "[dbo].[TiposControlesLotesSelectDgv]",  _
                     "[dbo].[TiposControlesLotesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposControlesLotes
        Dim dbo As New DBO_TiposControlesLotes
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposControlesLotes
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_TiposControlesLotes(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposControlesLotesCbo", False, dtb)
    End Sub

End Class
