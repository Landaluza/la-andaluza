Public Class spEtiquetasPalets
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[EtiquetasPaletSelect]", _
                        String.Empty, _
                        String.Empty, _
                        String.Empty, _
                        "[dbo].[PaletsProducidosSelectDgv]", _
                        "[dbo].[PaletsProducidos6SelectByFormatoEnvasadoID]")
    End Sub

    'Public Overloads Function Select_Record_pruebas(ByVal articulo As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase ) As DBO_EtiquetasPalets
    '    Dim dbo As New DBO_EtiquetasPalets

    '    Try
    '        dtb.Conectar 
    '        Dim connection As SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
    '        Dim selectCommand As New SqlClient.SqlCommand("EtiquetasPaletSelectPruebas", connection)
    '        selectCommand.CommandType = CommandType.StoredProcedure
    '        
    '        selectCommand.Parameters.AddWithValue("@articulo", articulo)

    '        Dim reader As SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
    '        If reader.Read Then
    '            Dim cont As Integer = 1

    '            While cont <= dbo.count
    '                dbo.item(cont).value = reader(dbo.item(cont).sqlName)
    '                cont += 1
    '            End While
    '        Else
    '            dbo = Nothing
    '        End If
    '        reader.Close()

    '    Catch ex As Exception
    '        dbo = Nothing
    '    Finally
    '        dtb.Desconectar 
    '    End Try

    '    Return dbo
    'End Function

    Public Overloads Function Select_Record(ByVal PaletProducidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_EtiquetasPalets
        Dim dbo As New DBO_EtiquetasPalets
        dbo.searchKey = dbo.item("PaletProducidoID")
        dbo.searchKey.value = PaletProducidoID
        MyBase.Select_proc(dbo, "[dbo].[EtiquetasPaletSelect]", dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PaletProducidoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Throw New Exception("Las etiquetas no se pueden borrar")
    End Function


End Class
