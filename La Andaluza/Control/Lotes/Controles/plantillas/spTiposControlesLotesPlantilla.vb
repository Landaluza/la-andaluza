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

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_TiposControlesLotesPlantilla
       Dim dbo As New DBO_TiposControlesLotesPlantilla
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_TiposControlesLotesPlantilla
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_TiposControlesLotesPlantilla(ByRef cbo As ComboBox)
       cbo.mam_DataSource("TiposControlesLotesPlantillaCbo", False)
   End Sub

End Class
