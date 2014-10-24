

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

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Articulos_AlmacenNoConforme
        Dim dbo As New DBO_Articulos_AlmacenNoConforme
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Articulos_AlmacenNoConforme
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        If dtb.Transaccion Is Nothing Then
            dtb.EmpezarTransaccion()
        End If
        Try
            If MyBase.DeleteProcedure(dbo, dtb) Then
                dtb.TerminarTransaccion()
                Return True
            Else
                dtb.CancelarTransaccion()
                Return False
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
            Return False
        End Try
    End Function

End Class
