Public Class ctlCompuestoPor
    Dim clsCom As New clsCompuestoPor

    Public Function GetLoteFinal() As Integer
        Return clsCom._LoteFinal
    End Function

    Public Sub SetLoteFinal(ByVal ID As Integer)
        clsCom._LoteFinal = ID
    End Sub

    Public Function GetLotePartida() As Integer
        Return clsCom._LotePartida
    End Function

    Public Sub SetLotePartida(ByVal ID As Integer)
        clsCom._LotePartida = ID
    End Sub

    Public Function GetCantidad() As Double
        Return clsCom._Cantidad
    End Function

    Public Sub SetCantidad(ByVal Cantidad As Double)
        clsCom._Cantidad = Cantidad
    End Sub

    Public Function GuardarCompuestoPor(ByVal LoteFinal As Integer, _
                                   ByVal LotePartida As Integer, _
                                   ByVal MovimientoID As Integer, _
                                   ByVal Cantidad As Double) As Integer

        clsCom._LoteFinal = LoteFinal
        clsCom._LotePartida = LotePartida
        clsCom._MovimientoID = MovimientoID
        clsCom._Cantidad = Cantidad
        Return clsCom.Insertar()
    End Function

    Public Function RevertirMovimiento() As Boolean
        Return clsCom.RevertirMovimiento()
    End Function

    Public Function DevolverCompuestosPorMovimiento(ByVal MovID As Integer) As DataTable
        clsCom._MovimientoID = MovID
        Return clsCom.DevolverPorMovimiento()
    End Function

 
End Class
