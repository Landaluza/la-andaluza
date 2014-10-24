Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPiernas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PiernasSelect]",  _
                     "[dbo].[PiernasInsert]",  _
                     "[dbo].[PiernasUpdate]",  _
                     "[dbo].[PiernasDelete]",  _
                     "[dbo].[PiernasSelectDgv]",  _
                     "[dbo].[PiernasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal PiernaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Piernas
        Dim dbo As New DBO_Piernas
        dbo.searchKey = dbo.item("PiernaID")
        dbo.searchKey.value = PiernaID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PiernaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Piernas
        dbo.searchKey = dbo.item("PiernaID")
        dbo.searchKey.value = PiernaID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Piernas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PiernasCbo", False, dtb)
    End Sub

    Public Sub cargar_PiernasPorNave(ByRef cbo As ComboBox, ByVal nave As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PiernasCboPorNave " & nave, False, dtb)
    End Sub
End Class
