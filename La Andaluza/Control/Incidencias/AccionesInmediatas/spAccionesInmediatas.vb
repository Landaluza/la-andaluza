Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spAccionesInmediatas
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AccionesInmediatasSelect]",  _
                     "[dbo].[AccionesInmediatasInsert]",  _
                     "[dbo].[AccionesInmediatasUpdate]",  _
                     "[dbo].[AccionesInmediatasDelete]",  _
                     "[dbo].[AccionesInmediatasSelectDgv]",  _
                     "[dbo].[AccionesInmediatasSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_AccionesInmediatas
        Dim dbo As New DBO_AccionesInmediatas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dbo As New DBO_AccionesInmediatas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

   Public Sub cargar_AccionesInmediatas(ByRef cbo As ComboBox)
       cbo.mam_DataSource("AccionesInmediatasCbo", False)
   End Sub

End Class
