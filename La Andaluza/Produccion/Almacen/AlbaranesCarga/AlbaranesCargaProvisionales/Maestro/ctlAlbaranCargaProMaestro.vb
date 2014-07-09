Public Class ctlAlbaranCargaProMaestro
    Dim clsAlb As New clsAlbaranCargaProMaestro

    Public Function GetAlbaranCargaProMaestroID() As Integer
        Return clsAlb._AlbaranCargaProMaestroID
    End Function

    Public Sub SetAlbaranCargaProMaestroID(ByVal ID As Integer)
        clsAlb._AlbaranCargaProMaestroID = ID
    End Sub

    Public Function devolverAlbaranCargaProMaestro() As DataTable
        Return clsAlb.Devolver()
    End Function


    Public Sub mostrarTodosAlbaranCargaProMaestro(ByRef dts As dtsAlbaranCargaProMaestro.AlbaranCargaProMaestroDataTable)
        Dim tabla As New DataTable
        tabla = clsAlb.Devolver()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsAlbaranCargaProMaestro.AlbaranCargaProMaestroRow
        While i < tabla.Rows.Count
            reg = dts.NewAlbaranCargaProMaestroRow
            reg.AlbaranCargaProMaestroID = tabla.Rows(i).Item(0)
            reg.Numero = tabla.Rows(i).Item(1)
            reg.Fecha = tabla.Rows(i).Item(2)
            reg.ResponsableCargaID = tabla.Rows(i).Item(3)
            reg.Observaciones = tabla.Rows(i).Item(4)
            reg.Reserva1 = tabla.Rows(i).Item(5)
            reg.Reserva2 = tabla.Rows(i).Item(6)
            reg.Reserva3 = tabla.Rows(i).Item(7)
            dts.AddAlbaranCargaProMaestroRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub GuardarAlbaranCargaProMaestro( _
               ByVal Numero As Integer, _
               ByVal Fecha As DateTime, _
               ByVal ResponsableCargaID As Integer, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String)
        clsAlb._Numero = Numero
        clsAlb._Fecha = Fecha
        clsAlb._ResponsableCargaID = ResponsableCargaID
        clsAlb._Observaciones = Observaciones
        clsAlb._Reserva1 = Reserva1
        clsAlb._Reserva2 = Reserva2
        clsAlb._Reserva3 = Reserva3        
        If clsAlb._AlbaranCargaProMaestroID = 0 Then
            clsAlb.Insertar()
        Else
            clsAlb.Modificar()
        End If
    End Sub

    Private Function GuardarAlbaranCargaProMaestro( _
               ByVal Numero As Integer, _
               ByVal Fecha As DateTime, _
               ByVal ResponsableCargaID As Integer, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String, _
               ByVal codigoPedido As Integer, _
               ByVal ordenCarga As Integer) As Integer

        clsAlb._Numero = Numero
        clsAlb._Fecha = Fecha
        clsAlb._ResponsableCargaID = ResponsableCargaID
        clsAlb._Observaciones = Observaciones
        clsAlb._Reserva1 = Reserva1
        clsAlb._Reserva2 = Reserva2
        clsAlb._Reserva3 = Reserva3
        clsAlb._CodigoPedidoMaestro = codigoPedido
        clsAlb._OrdenCarga = ordenCarga

        If clsAlb._AlbaranCargaProMaestroID = 0 Then
            Return clsAlb.Insertar(True)
        Else : Return 0
        End If
    End Function

    Public Function GuardarAlbaranCargaProMaestroParaPedido( _
              ByVal Numero As Integer, _
              ByVal Fecha As DateTime, _
              ByVal ResponsableCargaID As Integer, _
              ByVal Observaciones As String, _
              ByVal Reserva1 As String, _
              ByVal Reserva2 As String, _
              ByVal Reserva3 As String, _
              ByVal codigoPedido As Integer) As Integer

        Return GuardarAlbaranCargaProMaestro(Numero, _
               Fecha, _
               ResponsableCargaID, _
               Observaciones, _
               Reserva1, _
               Reserva2, _
               Reserva3, _
               codigoPedido, Nothing)
    End Function

    Public Function GuardarAlbaranCargaProMaestroParaOrdenCarga( _
              ByVal Numero As Integer, _
              ByVal Fecha As DateTime, _
              ByVal ResponsableCargaID As Integer, _
              ByVal Observaciones As String, _
              ByVal Reserva1 As String, _
              ByVal Reserva2 As String, _
              ByVal Reserva3 As String, _
              ByVal ordenCarga As Integer) As Integer

        Return GuardarAlbaranCargaProMaestro(Numero, _
               Fecha, _
               ResponsableCargaID, _
               Observaciones, _
               Reserva1, _
               Reserva2, _
               Reserva3, _
               Nothing, ordenCarga)
    End Function

    Public Sub EliminarAlbaranCargaProMaestro()
        clsAlb.Eliminar()
    End Sub
End Class
