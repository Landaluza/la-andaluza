Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spRecuentoMaterialesAuxiliares
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[RecuentoMaterialesAuxiliaresSelect]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresInsert]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresUpdate]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresDelete]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresSelectDgv]",  _
                     "[dbo].[RecuentoMaterialesAuxiliaresSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_RecuentoMaterialesAuxiliares
        Dim dbo As New DBO_RecuentoMaterialesAuxiliares
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_RecuentoMaterialesAuxiliares
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_RecuentoMaterialesAuxiliares(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("RecuentoMaterialesAuxiliaresCbo", False, dtb)
    End Sub

End Class
