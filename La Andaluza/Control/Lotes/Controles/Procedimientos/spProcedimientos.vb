Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spProcedimientos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProcedimientosSelect]",  _
                     "[dbo].[ProcedimientosInsert]",  _
                     "[dbo].[ProcedimientosUpdate]",  _
                     "[dbo].[ProcedimientosDelete]",  _
                     "[dbo].[ProcedimientosSelectDgv]",  _
                     "[dbo].[ProcedimientosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Procedimientos
        Dim dbo As New DBO_Procedimientos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Procedimientos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Procedimientos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ProcedimientosCbo", False, dtb)
    End Sub

End Class
