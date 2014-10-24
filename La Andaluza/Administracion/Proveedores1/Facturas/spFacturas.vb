Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spFacturas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[FacturasSelect]",  _
                     "[dbo].[FacturasInsert]",  _
                     "[dbo].[FacturasUpdate]",  _
                     "[dbo].[FacturasDelete]",  _
                     "[dbo].[FacturasSelectDgv]",  _
                     "[dbo].[FacturasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Facturas
        Dim dbo As New DBO_Facturas
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Facturas
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_Facturas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("FacturasCbo", False, dtb)
    End Sub

End Class
