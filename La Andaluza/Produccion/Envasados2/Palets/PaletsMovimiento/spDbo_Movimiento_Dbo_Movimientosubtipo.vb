

Public Class spDbo_Movimiento_Dbo_Movimientosubtipo

    Public Shared Function List(ByVal Tipo As Integer) As System.Collections.Generic.List(Of Dbo_Movimiento_Dbo_Movimientosubtipo)
        Dim dbo_movimiento_dbo_movimientosubtipoList As New System.Collections.Generic.List(Of Dbo_Movimiento_Dbo_Movimientosubtipo)
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim selectStatement As String _
            = "SELECT ID, Descripcion " _
            & "FROM dbo.PaletsMovimientoSubTipo " _
            & "WHERE Tipo = " & Tipo & " " _
            & "ORDER BY Descripcion "
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectStatement, connection)
        Try
            
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            Dim dbo_movimiento_dbo_movimientosubtipo As Dbo_Movimiento_Dbo_Movimientosubtipo
            Do While reader.Read
                dbo_movimiento_dbo_movimientosubtipo = New Dbo_Movimiento_Dbo_Movimientosubtipo
                dbo_movimiento_dbo_movimientosubtipo.ID = reader("ID").ToString
                dbo_movimiento_dbo_movimientosubtipo.Descripcion = reader("Descripcion").ToString
                dbo_movimiento_dbo_movimientosubtipoList.Add(dbo_movimiento_dbo_movimientosubtipo)
            Loop
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            connection.Close()
        End Try
        Return dbo_movimiento_dbo_movimientosubtipoList
    End Function

End Class

