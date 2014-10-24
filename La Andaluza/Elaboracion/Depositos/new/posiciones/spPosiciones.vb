Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spPosiciones
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PosicionesSelect]",  _
                     "[dbo].[PosicionesInsert]",  _
                     "[dbo].[PosicionesUpdate]",  _
                     "[dbo].[PosicionesDelete]",  _
                     "[dbo].[PosicionesSelectDgv]",  _
                     "[dbo].[PosicionesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal PosicionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Posiciones
        Dim dbo As New DBO_Posiciones
        dbo.searchKey = dbo.item("PosicionID")
        dbo.searchKey.value = PosicionID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PosicionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Posiciones
        dbo.searchKey = dbo.item("PosicionID")
        dbo.searchKey.value = PosicionID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_Posiciones(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PosicionesCbo", False, dtb)
    End Sub

End Class
