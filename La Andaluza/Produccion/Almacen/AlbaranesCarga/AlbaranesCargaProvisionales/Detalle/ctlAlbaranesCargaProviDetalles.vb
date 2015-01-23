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

        dtb.PrepararConsulta("insert into AlbaranesCargaProviDetalles([AlbaranCargaProviMaestroID],[SCC] ,[CodigoQS] ,[AticuloDescripcion] ,[Cajas] ,[UnidadMedidaID] ,[Lote],[TipoPaletID] ,[Observaciones] ,[Reserva1] ,[Reserva2] ,[Reserva3], LoteAlternativo) values(" & _
                              " @al , @scc , @cod , @desc , @caj , @uni , @lot , @tlot , @obs , @re1 , @re2 , @re3 , @lotalt )")
        dtb.AñadirParametroConsulta("@al", AlbaranCargaProviMaestroID)
        dtb.AñadirParametroConsulta("@scc", SCC)
        dtb.AñadirParametroConsulta("@cod", CodigoQS)
        dtb.AñadirParametroConsulta("@desc", AticuloDescripcion)
        dtb.AñadirParametroConsulta("@caj", Cajas)
        dtb.AñadirParametroConsulta("@uni", UnidadMedidaID)
        dtb.AñadirParametroConsulta("@lot", Lote)
        dtb.AñadirParametroConsulta("@tlot", TipoPaletID)
        dtb.AñadirParametroConsulta("@obs", Observaciones)
        dtb.AñadirParametroConsulta("@re1", Reserva1)
        dtb.AñadirParametroConsulta("@re2", Reserva2)
        dtb.AñadirParametroConsulta("@re3", Reserva3)
        dtb.AñadirParametroConsulta("@lotalt", LoteAlternativo)
     



        If dtb.Execute Then
            'If dtb.ConsultaAlteraciones("insert into AlbaranesCargaProviDetalles([AlbaranCargaProviMaestroID],[SCC] ,[CodigoQS] ,[AticuloDescripcion] ,[Cajas] ,[UnidadMedidaID] ,[Lote],[TipoPaletID] ,[Observaciones] ,[Reserva1] ,[Reserva2] ,[Reserva3], LoteAlternativo) values(" & _
            '               "" & Convert.ToString(AlbaranCargaProviMaestroID) & "," & _
            '               "" & Convert.ToString(SCC) & "," & _
            '               "" & Convert.ToString(CodigoQS) & "," & _
            '               "'" & AticuloDescripcion & "'," & _
            '               "" & Convert.ToString(Cajas) & "," & _
            '               "" & Convert.ToString(UnidadMedidaID) & "," & _
            '               "'" & Lote & "'," & _
            '               "" & Convert.ToString(TipoPaletID) & "," & _
            '               "'" & Observaciones & "'," & _
            '               "'" & Reserva1 & "'," & _
            '               "'" & Reserva2 & "'," & _
            '               "'" & Reserva3 & "'," & _
            '               "'" & LoteAlternativo & "')") Then

            dtb.PrepararConsulta("select max(AlbaranCargaProviDetalleID) from AlbaranesCargaProviDetalles")
            AlbaranCargaProviDetalleID = dtb.Consultar().Rows(0).Item(0)
            Return AlbaranCargaProviDetalleID
        Else
            Return 0
        End If


    End Function

End Class
