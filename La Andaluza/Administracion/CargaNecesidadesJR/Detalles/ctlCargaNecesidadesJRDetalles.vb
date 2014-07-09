Public Class ctlCargaNecesidadesJRDetalles
    Dim clsCar As New clsCargaNecesidadesJRDetalles

    Public Function GetCargaNecesidadesJRDetalleID() As Integer
        Return clsCar._CargaNecesidadesJRDetalleID
    End Function

    Public Sub SetCargaNecesidadesJRDetalleID(ByVal ID As Integer)
        clsCar._CargaNecesidadesJRDetalleID = ID
    End Sub

    Public Function devolverCargaNecesidadesJRDetalles() As DataTable
        Return clsCar.Devolver()
    End Function

    Public Sub mostrarTodosCargaNecesidadesJRDetalles(ByRef dts As dtsCargaNecesidadesJRDetalles.CargaNecesidadesJRDetallesDataTable)
        Dim tabla As New DataTable
        tabla = clsCar.Devolver()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsCargaNecesidadesJRDetalles.CargaNecesidadesJRDetallesRow
        While i < tabla.Rows.Count
            reg = dts.NewCargaNecesidadesJRDetallesRow
            reg.CargaNecesidadesJRDetalleID = tabla.Rows(i).Item(0)
            reg.CargaNecesidadesJRMaestroID = tabla.Rows(i).Item(1)
            reg.ArticuloID = tabla.Rows(i).Item(2)
            reg.Carga = tabla.Rows(i).Item(3)
            reg.Stock = tabla.Rows(i).Item(4)
            reg.Observaciones = tabla.Rows(i).Item(5)
            reg.Reserva1 = tabla.Rows(i).Item(6)
            reg.Reserva2 = tabla.Rows(i).Item(7)
            reg.Reserva3 = tabla.Rows(i).Item(8)
            dts.AddCargaNecesidadesJRDetallesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub GuardarCargaNecesidadesJRDetalle( _
               ByVal CargaNecesidadesJRMaestroID As Integer, _
               ByVal ArticuloID As Integer, _
               ByVal Carga As Integer, _
               ByVal Stock As Integer, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String)
        clsCar._CargaNecesidadesJRMaestroID = CargaNecesidadesJRMaestroID
        clsCar._ArticuloID = ArticuloID
        clsCar._Carga = Carga
        clsCar._Stock = Stock
        clsCar._Observaciones = Observaciones
        clsCar._Reserva1 = Reserva1
        clsCar._Reserva2 = Reserva2
        clsCar._Reserva3 = Reserva3
        If clsCar._CargaNecesidadesJRDetalleID = 0 Then
            clsCar.Insertar()
        Else
            clsCar.Modificar()
        End If
    End Sub

    Public Sub EliminarCargaNecesidadesJRDetalle()
        clsCar.Eliminar()
    End Sub
End Class
