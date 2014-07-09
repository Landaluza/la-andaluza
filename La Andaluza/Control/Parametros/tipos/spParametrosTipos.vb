Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spParametrosTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ParametrosTiposSelect]",  _
                     "[dbo].[ParametrosTiposInsert]",  _
                     "[dbo].[ParametrosTiposUpdate]",  _
                     "[dbo].[ParametrosTiposDelete]",  _
                     "[dbo].[ParametrosTiposSelectDgv]",  _
                     "[dbo].[ParametrosTiposSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ParametrosTipos
       Dim dbo As New DBO_ParametrosTipos
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ParametrosTipos
       dbo.searchKey = dbo.item("id")
       dbo.searchKey.value = id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_ParametrosTipos(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("[ParametrosTiposCbo]", False)
    End Sub

End Class
