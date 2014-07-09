

Public Class spArticulos_AlmacenNoConforme
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[Articulos_AlmacenNoConformeSelect]",  _
                     "[dbo].[Articulos_AlmacenNoConformeInsert]",  _
                     "[dbo].[Articulos_AlmacenNoConformeUpdate]",  _
                     "[dbo].[Articulos_AlmacenNoConformeDelete]",  _
                     "[dbo].[Articulos_AlmacenNoConformeSelectDgv]",  _
                     "[dbo].[Articulos_AlmacenNoConformeSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Articulos_AlmacenNoConforme
       Dim dbo As New DBO_Articulos_AlmacenNoConforme
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_Articulos_AlmacenNoConforme
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
        If trans Is Nothing Then
            BasesParaCompatibilidad.BD.EmpezarTransaccion()
            trans = BasesParaCompatibilidad.BD.transaction
        End If
        Try
            If MyBase.DeleteProcedure(dbo, trans) Then
                BasesParaCompatibilidad.BD.TerminarTransaccion()
                Return True
            Else
                BasesParaCompatibilidad.BD.CancelarTransaccion()
                Return False
            End If
        Catch ex As Exception
            BasesParaCompatibilidad.BD.CancelarTransaccion()
            Return False
        End Try
   End Function

End Class
