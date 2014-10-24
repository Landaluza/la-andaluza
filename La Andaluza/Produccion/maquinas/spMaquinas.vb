Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spMaquinas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[MaquinasSelect]",  _
                     "[dbo].[MaquinasInsert]",  _
                     "[dbo].[MaquinasUpdate]",  _
                     "[dbo].[MaquinasDelete]",  _
                     "[dbo].[MaquinasSelectDgv]",  _
                     "[dbo].[MaquinasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal MaquinaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Maquinas
        Dim dbo As New DBO_Maquinas
        dbo.searchKey = dbo.item("MaquinaID")
        dbo.searchKey.value = MaquinaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MaquinaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Maquinas
        dbo.searchKey = dbo.item("MaquinaID")
        dbo.searchKey.value = MaquinaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_Maquinas(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("MaquinasCbo", False, dtb)
    End Sub

    Public Sub cargar_MaquinasporLinea(ByRef cbo As ComboBox, ByVal linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("_Incidencias2SelectMaquinasPorLinea " & linea, False, dtb)
    End Sub
End Class
