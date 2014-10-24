Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spTiposControlesLotesPlantilla
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposControlesLotesPlantillaSelect]",  _
                     "[dbo].[TiposControlesLotesPlantillaInsert]",  _
                     "[dbo].[TiposControlesLotesPlantillaUpdate]",  _
                     "[dbo].[TiposControlesLotesPlantillaDelete]",  _
                     "[dbo].[TiposControlesLotesPlantillaSelectDgv]",  _
                     "[dbo].[TiposControlesLotesPlantillaSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposControlesLotesPlantilla
        Dim dbo As New DBO_TiposControlesLotesPlantilla
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposControlesLotesPlantilla
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_TiposControlesLotesPlantilla(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposControlesLotesPlantillaCbo", False, dtb)
    End Sub

End Class
