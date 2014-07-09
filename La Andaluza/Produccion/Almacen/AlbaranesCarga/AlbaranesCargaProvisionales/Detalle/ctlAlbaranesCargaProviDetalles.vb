Public Class ctlAlbaranesCargaProviDetalles
    Dim clsAlbDet As New clsAlbaranesCargaProviDetalles

    Public Function GetAlbaranCargaProviDetalleID() As Integer
        Return clsAlbDet._AlbaranCargaProviDetalleID
    End Function

    Public Sub SetAlbaranCargaProviDetalleID(ByVal ID As Integer)
        clsAlbDet._AlbaranCargaProviDetalleID = ID
    End Sub

    Public Function devolverAlbaranesCargaProviDetalles() As DataTable
        Return clsAlbDet.Devolver()
    End Function

    Public Function SelectPaletsByAlbaranPro(ByVal AlbaranID As Integer) As DataTable
        Return clsAlbDet.SelectPaletsByAlbaranPro(AlbaranID)
    End Function


    Public Sub mostrarTodosAlbaranesCargaProviDetalles(ByRef dts As dtsAlbaranesCargaProviDetalles.AlbaranesCargaProviDetallesDataTable)
        Dim tabla As New DataTable
        tabla = clsAlbDet.Devolver()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsAlbaranesCargaProviDetalles.AlbaranesCargaProviDetallesRow
        While i < tabla.Rows.Count
            reg = dts.NewAlbaranesCargaProviDetallesRow
            reg.AlbaranCargaProviDetalleID = (tabla.Rows(i).Item(0))
            reg.AlbaranCargaProviMaestroID = (tabla.Rows(i).Item(1))
            reg.SCC = (tabla.Rows(i).Item(2))
            reg.CodigoQS = (tabla.Rows(i).Item(3))
            reg.AticuloDescripcion = tabla.Rows(i).Item(4)
            reg.Cajas = tabla.Rows(i).Item(5)
            reg.UnidadMedidaID = (tabla.Rows(i).Item(6))
            reg.Lote = tabla.Rows(i).Item(7)
            reg.TipoPaletID = (tabla.Rows(i).Item(8))
            reg.Observaciones = tabla.Rows(i).Item(9)
            reg.Reserva1 = tabla.Rows(i).Item(10)
            reg.Reserva2 = tabla.Rows(i).Item(11)
            reg.Reserva3 = tabla.Rows(i).Item(12)
            dts.AddAlbaranesCargaProviDetallesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Function GuardarAlbaranCargaProviDetalle( _
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

        clsAlbDet._AlbaranCargaProviMaestroID = AlbaranCargaProviMaestroID
        clsAlbDet._SCC = SCC
        clsAlbDet._CodigoQS = CodigoQS
        clsAlbDet._AticuloDescripcion = AticuloDescripcion
        clsAlbDet._Cajas = Cajas
        clsAlbDet._UnidadMedidaID = UnidadMedidaID
        If Lote.Contains(",") Then
            Dim axu As String() = Lote.Replace("Multilote:", "").Split(",")
            Lote = axu(1)
        End If
        clsAlbDet._Lote = Lote
        clsAlbDet._TipoPaletID = TipoPaletID
        clsAlbDet._Observaciones = Observaciones
        clsAlbDet._Reserva1 = Reserva1
        clsAlbDet._Reserva2 = Reserva2
        clsAlbDet._Reserva3 = Reserva3
        clsAlbDet._LoteAlternativo = LoteAlternativo
        If clsAlbDet._AlbaranCargaProviDetalleID = 0 Then
            Return clsAlbDet.Insertar()
        Else
            Return clsAlbDet.Modificar()
        End If
    End Function

    Public Sub EliminarAlbaranCargaProviDetalle()
        clsAlbDet.Eliminar()
    End Sub
End Class
