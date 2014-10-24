Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMuestrasMedidas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MuestrasMedidasSelect]",  _
                     "[dbo].[MuestrasMedidasInsert]",  _
                     "[dbo].[MuestrasMedidasUpdate]",  _
                     "[dbo].[MuestrasMedidasDelete]",  _
                     "[dbo].[MuestrasMedidasSelectDgv]",  _
                     "[dbo].[MuestrasMedidasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal MedidaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_MuestrasMedidas
        Dim dbo As New DBO_MuestrasMedidas
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MedidaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_MuestrasMedidas
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_MuestrasMedidas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MuestrasMedidasCbo", False, dtb)
    End Sub

End Class
