Public Class ctlAlbaranesCargaProviDetalles
    Public Function GuardarAlbaranCargaProviDetalle(ByRef dtb As BasesParaCompatibilidad.DataBase, _
               ByVal AlbaranCargaProviMaestroID As Integer, _
               ByVal SCC As Integer, _
               ByVal CodigoQS As Integer, _
               ByVal AticuloDescripcion As String, _
               ByVal Cajas As Integer, _
               ByVal UnidadMedidaID As Integer, _
               ByVal Lote As String, _
               ByVal TipoPaletID As Integer, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String,
               ByVal LoteAlternativo As String) As Integer

        Dim AlbaranCargaProviDetalleID As Integer

        If Lote.Contains(",") Then
            Dim axu As String() = Lote.Replace("Multilote:", "").Split(",")
            Lote = axu(1)
        End If

        Try
            If BasesParaCompatibilidad.BD.ConsultaInsertarConcampos( _
                "([AlbaranCargaProviMaestroID],[SCC] ,[CodigoQS] ,[AticuloDescripcion] ,[Cajas] ,[UnidadMedidaID] ,[Lote],[TipoPaletID] ,[Observaciones] ,[Reserva1] ,[Reserva2] ,[Reserva3], LoteAlternativo, FechaModificacion, UsuarioModificacion)", _
                       "" & Convert.ToString(AlbaranCargaProviMaestroID) & "," & _
                       "" & Convert.ToString(SCC) & "," & _
                       "" & Convert.ToString(CodigoQS) & "," & _
                       "'" & AticuloDescripcion & "'," & _
                       "" & Convert.ToString(Cajas) & "," & _
                       "" & Convert.ToString(UnidadMedidaID) & "," & _
                       "'" & Lote & "'," & _
                       "" & Convert.ToString(TipoPaletID) & "," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'," & _
                       "'" & LoteAlternativo & "'", _
                       "AlbaranesCargaProviDetalles") = 1 Then

                dtb.PrepararConsulta("select max(AlbaranCargaProviDetalleID) from AlbaranesCargaProviDetalles")
                AlbaranCargaProviDetalleID = dtb.Consultar().Rows(0).Item(0)
                Return AlbaranCargaProviDetalleID
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function

End Class
