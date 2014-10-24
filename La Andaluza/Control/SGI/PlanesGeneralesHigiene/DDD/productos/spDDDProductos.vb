Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spDDDProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[DDDProductosSelect]",  _
                     "[dbo].[DDDProductosInsert]",  _
                     "[dbo].[DDDProductosUpdate]",  _
                     "[dbo].[DDDProductosDelete]",  _
                     "[dbo].[DDDProductosSelectDgv]",  _
                     "[dbo].[DDDProductosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal DDDProductoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_DDDProductos
        Dim dbo As New DBO_DDDProductos
        dbo.searchKey = dbo.item("DDDProductoID")
        dbo.searchKey.value = DDDProductoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal DDDProductoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_DDDProductos
        dbo.searchKey = dbo.item("DDDProductoID")
        dbo.searchKey.value = DDDProductoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_DDDProductos(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("[DDDProductosCbo]", False, dtb)
    End Sub

End Class
