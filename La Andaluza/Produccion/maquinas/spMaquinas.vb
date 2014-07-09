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

   Public Overloads Function Select_Record(ByVal MaquinaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Maquinas
       Dim dbo As New DBO_Maquinas
       dbo.searchKey = dbo.item("MaquinaID")
       dbo.searchKey.value = MaquinaID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal MaquinaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Maquinas
       dbo.searchKey = dbo.item("MaquinaID")
       dbo.searchKey.value = MaquinaID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Public Sub cargar_Maquinas(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("MaquinasCbo", False)
    End Sub

    Public Sub cargar_MaquinasporLinea(ByRef cbo As ComboBox, ByVal linea As Integer)
        cbo.mam_DataSource("_Incidencias2SelectMaquinasPorLinea " & linea, False)
    End Sub
End Class
