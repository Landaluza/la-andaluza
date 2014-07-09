Public Class ctlCargaNecesidadesJRMaestro
    Dim clsCar As New clsCargaNecesidadesJRMaestro

    Public Function GetCargaNecesidadesJRMaestroID() As Integer
        Return clsCar._CargaNecesidadesJRMaestroID
    End Function

    Public Sub SetCargaNecesidadesJRMaestroID(ByVal ID As Integer)
        clsCar._CargaNecesidadesJRMaestroID = ID
    End Sub

    Public Function devolverCargaNecesidadesJRMaestro() As DataTable
        Return clsCar.Devolver()
    End Function


    Public Sub mostrarTodosCargaNecesidadesJRMaestro(ByRef dts As dtsCargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroDataTable)
        Dim tabla As New DataTable
        tabla = clsCar.Devolver()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsCargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroRow
        While i < tabla.Rows.Count
            reg = dts.NewCargaNecesidadesJRMaestroRow
            reg.MaestroID = tabla.Rows(i).Item(0)
            reg.Fecha = tabla.Rows(i).Item(1)
            reg.Hora = tabla.Rows(i).Item(2)
            reg.Observaciones = tabla.Rows(i).Item(3)
           
            dts.AddCargaNecesidadesJRMaestroRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub GuardarCargaNecesidadesJRMaestro( _
               ByVal Fecha As DateTime, _
               ByVal Hora As DateTime, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String)
        clsCar._Fecha = Fecha
        clsCar._Hora = Hora
        clsCar._Observaciones = Observaciones
        clsCar._Reserva1 = Reserva1
        clsCar._Reserva2 = Reserva2
        clsCar._Reserva3 = Reserva3
        If clsCar._CargaNecesidadesJRMaestroID = 0 Then
            clsCar.Insertar()
        Else
            clsCar.Modificar()
        End If
    End Sub

    Public Sub EliminarCargaNecesidadesJRMaestro()
        clsCar.Eliminar()
    End Sub
End Class
