Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMuestrasCantidades
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MuestrasCantidadesSelect]",  _
                     "[dbo].[MuestrasCantidadesInsert]",  _
                     "[dbo].[MuestrasCantidadesUpdate]",  _
                     "[dbo].[MuestrasCantidadesDelete]",  _
                     "[dbo].[MuestrasCantidadesSelectDgv]",  _
                     "[dbo].[MuestrasCantidadesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal CantidadID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_MuestrasCantidades
        Dim dbo As New DBO_MuestrasCantidades
        dbo.searchKey = dbo.item("CantidadID")
        dbo.searchKey.value = CantidadID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal CantidadID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_MuestrasCantidades
        dbo.searchKey = dbo.item("CantidadID")
        dbo.searchKey.value = CantidadID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_MuestrasCantidades(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MuestrasCantidadesCbo", False, dtb)
    End Sub

End Class
