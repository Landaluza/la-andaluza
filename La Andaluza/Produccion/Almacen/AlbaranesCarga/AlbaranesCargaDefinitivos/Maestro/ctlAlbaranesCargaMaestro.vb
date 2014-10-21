Public Class ctlAlbaranesCargaMaestro
    Dim clsAlb As New clsAlbaranesCargaMaestro

    Public Function GetAlbaranCargaMaestroID() As Integer
        Return clsAlb._AlbaranCargaMaestroID
    End Function

    Public Sub SetAlbaranCargaMaestroID(ByVal ID As Integer)
        clsAlb._AlbaranCargaMaestroID = ID
    End Sub


    Public Sub mostrarTodosAlbaranesCargaMaestro(ByRef dtb As BasesParaCompatibilidad.DataBase, ByRef dts As dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroDataTable)
        Dim tabla As New DataTable
        tabla = clsAlb.Devolver(dtb)
        Dim i As Integer = 0
        dts.Clear()
        Dim reg As dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroRow
        While i < tabla.Rows.Count
            Try
                If Not tabla.Rows(i) Is Nothing Then
                    reg = dts.NewAlbaranesCargaMaestroRow
                    reg.AlbaranCargaMaestroID = If(Convert.IsDBNull(tabla.Rows(i).Item(0)), 0, Convert.ToInt32(tabla.Rows(i).Item(0)))
                    reg.AlbaranCargaProMaestroID = If(Convert.IsDBNull(tabla.Rows(i).Item(1)), 0, Convert.ToInt32(tabla.Rows(i).Item(1)))
                    reg.Fecha = If(Convert.IsDBNull(tabla.Rows(i).Item(2)), DateTime.Now.Date, CDate(tabla.Rows(i).Item(2)))
                    reg.ClienteID = If(Convert.IsDBNull(tabla.Rows(i).Item(3)), 0, Convert.ToInt32(tabla.Rows(i).Item(3)))
                    reg.SerieQSID = If(Convert.IsDBNull(tabla.Rows(i).Item(4)), 0, Convert.ToInt32(tabla.Rows(i).Item(4)))
                    reg.NumeroQS = If(Convert.IsDBNull(tabla.Rows(i).Item(5)), 0, Convert.ToInt32(tabla.Rows(i).Item(5)))
                    reg.AlmacenSalidaQSID = If(Convert.IsDBNull(tabla.Rows(i).Item(6)), 0, Convert.ToInt32(tabla.Rows(i).Item(6)))
                    reg.AgenciaID = If(Convert.IsDBNull(tabla.Rows(i).Item(7)), 0, Convert.ToInt32(tabla.Rows(i).Item(7)))
                    reg.PorteFormaPagoID = If(Convert.IsDBNull(tabla.Rows(i).Item(8)), 0, Convert.ToInt32(tabla.Rows(i).Item(8)))
                    reg.PorteImporte = If(Convert.IsDBNull(tabla.Rows(i).Item(9)), 0, Convert.ToInt32(tabla.Rows(i).Item(9)))
                    reg.Matricula = If(Convert.IsDBNull(tabla.Rows(i).Item(10)), "", Convert.ToString(tabla.Rows(i).Item(10)))
                    reg.Conductor = If(Convert.IsDBNull(tabla.Rows(i).Item(11)), "", Convert.ToString(tabla.Rows(i).Item(11)))
                    reg.ConductorDNI = If(Convert.IsDBNull(tabla.Rows(i).Item(12)), "", Convert.ToString(tabla.Rows(i).Item(12)))
                    reg.ResponsableCargaID = If(Convert.IsDBNull(tabla.Rows(i).Item(13)), 0, Convert.ToInt32(tabla.Rows(i).Item(13)))
                    reg.ResponsableAdministracionID = If(Convert.IsDBNull(tabla.Rows(i).Item(14)), 0, Convert.ToInt32(tabla.Rows(i).Item(14)))
                    reg.HoraLlegada = tabla.Rows(i).Item(15)
                    reg.HoraSalida = tabla.Rows(i).Item(16)
                    reg.Observaciones = If(Convert.IsDBNull(tabla.Rows(i).Item(17)), "", Convert.ToString(tabla.Rows(i).Item(17)))
                    reg.Reserva1 = If(Convert.IsDBNull(tabla.Rows(i).Item(18)), "", Convert.ToString(tabla.Rows(i).Item(18)))
                    reg.Reserva2 = If(Convert.IsDBNull(tabla.Rows(i).Item(19)), "", Convert.ToString(tabla.Rows(i).Item(19)))
                    reg.Reserva3 = If(Convert.IsDBNull(tabla.Rows(i).Item(20)), "", Convert.ToString(tabla.Rows(i).Item(20)))
                    dts.AddAlbaranesCargaMaestroRow(reg)
                    reg = Nothing
                    i = i + 1
                End If
            Catch ex As Exception
                i = i + 1
            End Try
        End While
    End Sub

    Public Sub GuardarAlbaranCargaMaestro(ByRef dtb As BasesParaCompatibilidad.DataBase, _
               ByVal AlbaranCargaProMaestroID As Integer, _
               ByVal Fecha As DateTime, _
               ByVal ClienteID As Integer, _
               ByVal SerieQSID As Integer, _
               ByVal NumeroQS As Integer, _
               ByVal AlmacenSalidaQSID As Integer, _
               ByVal AgenciaID As Integer, _
               ByVal PorteFormaPagoID As Integer, _
               ByVal PorteImporte As Integer, _
               ByVal Matricula As String, _
               ByVal Conductor As String, _
               ByVal ConductorDNI As String, _
               ByVal ResponsableCargaID As Integer, _
               ByVal ResponsableAdministracionID As Integer, _
               ByVal HoraLlegada As DateTime, _
               ByVal HoraSalida As DateTime, _
               ByVal Observaciones As String, _
               ByVal Reserva1 As String, _
               ByVal Reserva2 As String, _
               ByVal Reserva3 As String)
        clsAlb._AlbaranCargaProMaestroID = AlbaranCargaProMaestroID
        clsAlb._Fecha = Fecha
        clsAlb._ClienteID = ClienteID
        clsAlb._SerieQSID = SerieQSID
        clsAlb._NumeroQS = NumeroQS
        clsAlb._AlmacenSalidaQSID = AlmacenSalidaQSID
        clsAlb._AgenciaID = AgenciaID
        clsAlb._PorteFormaPagoID = PorteFormaPagoID
        clsAlb._PorteImporte = PorteImporte
        clsAlb._Matricula = Matricula
        clsAlb._Conductor = Conductor
        clsAlb._ConductorDNI = ConductorDNI
        clsAlb._ResponsableCargaID = ResponsableCargaID
        clsAlb._ResponsableAdministracionID = ResponsableAdministracionID
        clsAlb._HoraLlegada = HoraLlegada
        clsAlb._HoraSalida = HoraSalida
        clsAlb._Observaciones = Observaciones
        clsAlb._Reserva1 = Reserva1
        clsAlb._Reserva2 = Reserva2
        clsAlb._Reserva3 = Reserva3
        If clsAlb._AlbaranCargaMaestroID = 0 Then
            clsAlb.Insertar(dtb)
        Else
            clsAlb.Modificar(dtb)
        End If
    End Sub


    Public Sub EliminarAlbaranCargaMaestro()
        clsAlb.Eliminar()
    End Sub
End Class
