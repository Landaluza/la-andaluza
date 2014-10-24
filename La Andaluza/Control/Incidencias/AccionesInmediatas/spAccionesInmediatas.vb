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

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_AccionesInmediatas
        Dim dbo As New DBO_AccionesInmediatas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_AccionesInmediatas
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_AccionesInmediatas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("AccionesInmediatasCbo", False, dtb)
    End Sub

End Class
