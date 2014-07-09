Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spUnidadesMedidas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[UnidadesMedidasSelect]",  _
                     "[dbo].[UnidadesMedidasInsert]",  _
                     "[dbo].[UnidadesMedidasUpdate]",  _
                     "[dbo].[UnidadesMedidasDelete]",  _
                     "[dbo].[UnidadesMedidasSelectDgv]",  _
                     "[dbo].[UnidadesMedidasSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal UnidadMedidaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_UnidadesMedidas
       Dim dbo As New DBO_UnidadesMedidas
       dbo.searchKey = dbo.item("UnidadMedidaID")
       dbo.searchKey.value = UnidadMedidaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal UnidadMedidaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_UnidadesMedidas
       dbo.searchKey = dbo.item("UnidadMedidaID")
       dbo.searchKey.value = UnidadMedidaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_UnidadesMedidas(ByRef comboBox As ComboBox)
        combobox.mam_DataSource("[UnidadesMedidasCbo]", False)
    End Sub

End Class
