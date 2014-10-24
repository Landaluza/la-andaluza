Public Class ctlAlbaranesCargaDetalles
    Private clsAlb As New clsAlbaranesCargaDetalles


    Public Sub SetAlbaranCargaDetalleID(ByVal ID As Integer)
        clsAlb._AlbaranCargaDetalleID = ID
    End Sub



    Public Sub mostrarTodosAlbaranesCargaDetalles(ByRef dtb As BasesParaCompatibilidad.DataBase, ByRef dts As dtsAlbaranesCargaDetalles.AlbaranesCargaDetallesDataTable)
        Dim tabla As New DataTable
        tabla = clsAlb.Devolver(dtb)
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsAlbaranesCargaDetalles.AlbaranesCargaDetallesRow
        While i < tabla.Rows.Count
            reg = dts.NewAlbaranesCargaDetallesRow
            reg.AlbaranCargaDetalleID = tabla.Rows(i).Item(0)
            reg.AlbaranCargaMaestroID = tabla.Rows(i).Item(1)
            reg.Scc = tabla.Rows(i).Item(2)
            reg.CodigoQS = tabla.Rows(i).Item(3)
            reg.AticuloDescripcion = tabla.Rows(i).Item(4)
            reg.Cajas = tabla.Rows(i).Item(5)
            reg.UnidadMedida = tabla.Rows(i).Item(6)
            reg.Lote = tabla.Rows(i).Item(7)
            reg.TipoPalet = tabla.Rows(i).Item(8)
            reg.Observaciones = tabla.Rows(i).Item(9)
            reg.Reserva1 = tabla.Rows(i).Item(10)
            reg.Reserva2 = tabla.Rows(i).Item(11)
            reg.Reserva3 = tabla.Rows(i).Item(12)
            dts.AddAlbaranesCargaDetallesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub GuardarAlbaranCargaDetalle(ByRef dtb As BasesParaCompatibilidad.DataBase, _
               ByVal AlbaranCargaMaestroID As Integer, _
               ByVal Scc As Integer, _
               ByVal CodigoQS As Integer, _
               ByVal AticuloDescripcion As String, _
               ByVal Cajas As Integer, _
               ByVal UnidadMedida As String, _
               ByVal Lote As String, _
               ByVal TipoPalet As String, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String)
        clsAlb._AlbaranCargaMaestroID = AlbaranCargaMaestroID
        clsAlb._Scc = Scc
        clsAlb._CodigoQS = CodigoQS
        clsAlb._AticuloDescripcion = AticuloDescripcion
        clsAlb._Cajas = Cajas
        clsAlb._UnidadMedida = UnidadMedida
        clsAlb._Lote = Lote
        clsAlb._TipoPalet = TipoPalet
        clsAlb._Observaciones = Observaciones
        clsAlb._Reserva1 = Reserva1
        clsAlb._Reserva2 = Reserva2
        clsAlb._Reserva3 = Reserva3
        If clsAlb._AlbaranCargaDetalleID = 0 Then
            clsAlb.Insertar(dtb)
        Else
            clsAlb.Modificar(dtb)
        End If
    End Sub

    Public Function EliminarAlbaranCargaDetalle(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return clsAlb.Eliminar(dtb)
    End Function
End Class
