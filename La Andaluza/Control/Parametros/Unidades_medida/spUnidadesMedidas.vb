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

    Public Overloads Function Select_Record(ByVal UnidadMedidaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_UnidadesMedidas
        Dim dbo As New DBO_UnidadesMedidas
        dbo.searchKey = dbo.item("UnidadMedidaID")
        dbo.searchKey.value = UnidadMedidaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal UnidadMedidaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_UnidadesMedidas
        dbo.searchKey = dbo.item("UnidadMedidaID")
        dbo.searchKey.value = UnidadMedidaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_UnidadesMedidas(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("[UnidadesMedidasCbo]", False, dtb)
    End Sub

End Class
