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

   Public Overloads Function Select_Record(ByVal PosicionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Posiciones
       Dim dbo As New DBO_Posiciones
       dbo.searchKey = dbo.item("PosicionID")
       dbo.searchKey.value = PosicionID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PosicionID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Posiciones
       dbo.searchKey = dbo.item("PosicionID")
       dbo.searchKey.value = PosicionID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

   Public Sub cargar_Posiciones(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PosicionesCbo", False)
   End Sub

End Class
