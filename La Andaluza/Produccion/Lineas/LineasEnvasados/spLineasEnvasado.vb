Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spLineasEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[LineasEnvasadoSelect]",  _
                     "[dbo].[LineasEnvasadoInsert]",  _
                     "[dbo].[LineasEnvasadoUpdate]",  _
                     "[dbo].[LineasEnvasadoDelete]",  _
                     "[dbo].[LineasEnvasadoSelectDgv]",  _
                     "[dbo].[LineasEnvasadoSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal LineaEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_LineasEnvasado
        Dim dbo As New DBO_LineasEnvasado
        dbo.searchKey = dbo.item("LineaEnvasadoID")
        dbo.searchKey.value = LineaEnvasadoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal LineaEnvasadoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_LineasEnvasado
        dbo.searchKey = dbo.item("LineaEnvasadoID")
        dbo.searchKey.value = LineaEnvasadoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_LineasEnvasado(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("LineasEnvasadoCbo", False, dtb)
    End Sub

    Public Function devolver_LineasEnvasado(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("LineasEnvasadoCbo", True)
    End Function
End Class
