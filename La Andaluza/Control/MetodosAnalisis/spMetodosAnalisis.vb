Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMetodosAnalisis
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MetodosAnalisisSelect]",  _
                     "[dbo].[MetodosAnalisisInsert]",  _
                     "[dbo].[MetodosAnalisisUpdate]",  _
                     "[dbo].[MetodosAnalisisDelete]",  _
                     "[dbo].[MetodosAnalisisSelectDgv]",  _
                     "[dbo].[MetodosAnalisisSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal MetodoAnalisisID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_MetodosAnalisis
        Dim dbo As New DBO_MetodosAnalisis
        dbo.searchKey = dbo.item("MetodoAnalisisID")
        dbo.searchKey.value = MetodoAnalisisID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MetodoAnalisisID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_MetodosAnalisis
        dbo.searchKey = dbo.item("MetodoAnalisisID")
        dbo.searchKey.value = MetodoAnalisisID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_MetodosAnalisis(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MetodosAnalisisCbo", False, dtb)
    End Sub

    Public Function devolverMetodosAnalisis(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("MetodosAnalisisCbo", True)
    End Function

End Class
