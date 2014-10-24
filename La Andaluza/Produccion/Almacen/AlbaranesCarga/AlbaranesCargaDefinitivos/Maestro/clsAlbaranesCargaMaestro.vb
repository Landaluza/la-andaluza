public class clsAlbaranesCargaMaestro

#Region "Atributos"
    Private AlbaranCargaMaestroID As Integer
    Private AlbaranCargaProMaestroID As Integer
    Private Fecha As DateTime
    Private ClienteID As Integer
    Private SerieQSID As Integer
    Private NumeroQS As Integer
    Private AlmacenSalidaQSID As Integer
    Private AgenciaID As Integer
    Private PorteFormaPagoID As Integer
    Private PorteImporte As Integer
    Private Matricula As String
    Private Conductor As String
    Private ConductorDNI As String
    Private ResponsableCargaID As Integer
    Private ResponsableAdministracionID As Integer
    Private HoraLlegada As DateTime
    Private HoraSalida As DateTime
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
#End Region

#Region "Propiedades"
    Public Property _AlbaranCargaMaestroID() As Integer
        Get
            Return AlbaranCargaMaestroID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaMaestroID = value
        End Set
    End Property

    Public Property _AlbaranCargaProMaestroID() As Integer
        Get
            Return AlbaranCargaProMaestroID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaProMaestroID = value
        End Set
    End Property

    Public Property _Fecha() As DateTime
        Get
            Return Fecha
        End Get

        Set(ByVal value As DateTime)
            Fecha = value
        End Set
    End Property

    Public Property _ClienteID() As Integer
        Get
            Return ClienteID
        End Get

        Set(ByVal value As Integer)
            ClienteID = value
        End Set
    End Property

    Public Property _SerieQSID() As Integer
        Get
            Return SerieQSID
        End Get

        Set(ByVal value As Integer)
            SerieQSID = value
        End Set
    End Property

    Public Property _NumeroQS() As Integer
        Get
            Return NumeroQS
        End Get

        Set(ByVal value As Integer)
            NumeroQS = value
        End Set
    End Property

    Public Property _AlmacenSalidaQSID() As Integer
        Get
            Return AlmacenSalidaQSID
        End Get

        Set(ByVal value As Integer)
            AlmacenSalidaQSID = value
        End Set
    End Property

    Public Property _AgenciaID() As Integer
        Get
            Return AgenciaID
        End Get

        Set(ByVal value As Integer)
            AgenciaID = value
        End Set
    End Property

    Public Property _PorteFormaPagoID() As Integer
        Get
            Return PorteFormaPagoID
        End Get

        Set(ByVal value As Integer)
            PorteFormaPagoID = value
        End Set
    End Property

    Public Property _PorteImporte() As Integer
        Get
            Return PorteImporte
        End Get

        Set(ByVal value As Integer)
            PorteImporte = value
        End Set
    End Property

    Public Property _Matricula() As String
        Get
            Return Matricula
        End Get

        Set(ByVal value As String)
            Matricula = value
        End Set
    End Property

    Public Property _Conductor() As String
        Get
            Return Conductor
        End Get

        Set(ByVal value As String)
            Conductor = value
        End Set
    End Property

    Public Property _ConductorDNI() As String
        Get
            Return ConductorDNI
        End Get

        Set(ByVal value As String)
            ConductorDNI = value
        End Set
    End Property

    Public Property _ResponsableCargaID() As Integer
        Get
            Return ResponsableCargaID
        End Get

        Set(ByVal value As Integer)
            ResponsableCargaID = value
        End Set
    End Property

    Public Property _ResponsableAdministracionID() As Integer
        Get
            Return ResponsableAdministracionID
        End Get

        Set(ByVal value As Integer)
            ResponsableAdministracionID = value
        End Set
    End Property

    Public Property _HoraLlegada() As DateTime
        Get
            Return HoraLlegada
        End Get

        Set(ByVal value As DateTime)
            HoraLlegada = value
        End Set
    End Property

    Public Property _HoraSalida() As DateTime
        Get
            Return HoraSalida
        End Get

        Set(ByVal value As DateTime)
            HoraSalida = value
        End Set
    End Property

    Public Property _Observaciones() As String
        Get
            Return Observaciones
        End Get

        Set(ByVal value As String)
            Observaciones = value
        End Set
    End Property

    Public Property _Reserva1() As String
        Get
            Return Reserva1
        End Get

        Set(ByVal value As String)
            Reserva1 = value
        End Set
    End Property

    Public Property _Reserva2() As String
        Get
            Return Reserva2
        End Get

        Set(ByVal value As String)
            Reserva2 = value
        End Set
    End Property

    Public Property _Reserva3() As String
        Get
            Return Reserva3
        End Get

        Set(ByVal value As String)
            Reserva3 = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Devolver(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select AlbaranesCargaMaestro.AlbaranCargaMaestroID,AlbaranesCargaMaestro.AlbaranCargaProMaestroID,AlbaranesCargaMaestro.Fecha,AlbaranesCargaMaestro.ClienteID,AlbaranesCargaMaestro.SerieQSID,AlbaranesCargaMaestro.NumeroQS,AlbaranesCargaMaestro.AlmacenSalidaQSID,AlbaranesCargaMaestro.AgenciaID,AlbaranesCargaMaestro.PorteFormaPagoID,AlbaranesCargaMaestro.PorteImporte,AlbaranesCargaMaestro.Matricula,AlbaranesCargaMaestro.Conductor,AlbaranesCargaMaestro.ConductorDNI,AlbaranesCargaMaestro.ResponsableCargaID,AlbaranesCargaMaestro.ResponsableAdministracionID,AlbaranesCargaMaestro.HoraLlegada,AlbaranesCargaMaestro.HoraSalida,AlbaranesCargaMaestro.Observaciones,AlbaranesCargaMaestro.Reserva1,AlbaranesCargaMaestro.Reserva2,AlbaranesCargaMaestro.Reserva3 from AlbaranesCargaMaestro")
        Return dtb.Consultar
    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            If Not dtb.ConsultaAlteraciones("update AlbaranesCargaMaestro set " & _
                        "AlbaranCargaProMaestroID=" & Convert.ToString(AlbaranCargaProMaestroID) & "," & _
                        "Fecha='" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                        "ClienteID=" & Convert.ToString(ClienteID) & "," & _
                        "SerieQSID=" & Convert.ToString(SerieQSID) & "," & _
                        "NumeroQS=" & Convert.ToString(NumeroQS) & "," & _
                        "AlmacenSalidaQSID=" & Convert.ToString(AlmacenSalidaQSID) & "," & _
                        "AgenciaID=" & Convert.ToString(AgenciaID) & "," & _
                        "PorteFormaPagoID=" & Convert.ToString(PorteFormaPagoID) & "," & _
                        "PorteImporte=" & Convert.ToString(PorteImporte) & "," & _
                        "Matricula='" & Matricula & "'," & _
                        "Conductor='" & Conductor & "'," & _
                        "ConductorDNI='" & ConductorDNI & "'," & _
                        "ResponsableCargaID=" & Convert.ToString(ResponsableCargaID) & "," & _
                        "ResponsableAdministracionID=" & Convert.ToString(ResponsableAdministracionID) & "," & _
                        "HoraLlegada='" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraLlegada) & "'," & _
                        "HoraSalida='" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraSalida) & "'," & _
                        "Observaciones='" & Observaciones & "'," & _
                        "Reserva1='" & Reserva1 & "'," & _
                        "Reserva2='" & Reserva2 & "'," & _
                        "Reserva3='" & Reserva3 & "'" & _
                        " where AlbaranCargaMaestroID=" & Convert.ToString(AlbaranCargaMaestroID)) Then

                Return 0
            End If

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            If Not dtb.ConsultaAlteraciones("insert into AlbaranesCargaMaestro values(" & _
                        "" & Convert.ToString(AlbaranCargaProMaestroID) & "," & _
                        "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                        "" & Convert.ToString(ClienteID) & "," & _
                        "" & Convert.ToString(SerieQSID) & "," & _
                        "" & Convert.ToString(NumeroQS) & "," & _
                        "" & Convert.ToString(AlmacenSalidaQSID) & "," & _
                        "" & Convert.ToString(AgenciaID) & "," & _
                        "" & Convert.ToString(PorteFormaPagoID) & "," & _
                        "" & Convert.ToString(PorteImporte) & "," & _
                        "'" & Matricula & "'," & _
                        "'" & Conductor & "'," & _
                        "'" & ConductorDNI & "'," & _
                        "" & Convert.ToString(ResponsableCargaID) & "," & _
                        "" & Convert.ToString(ResponsableAdministracionID) & "," & _
                        "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraLlegada) & "'," & _
                        "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(HoraSalida) & "'," & _
                        "'" & Observaciones & "'," & _
                        "'" & Reserva1 & "'," & _
                        "'" & Reserva2 & "'," & _
                        "'" & Reserva3 & "','" & _
                        BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)) + "'," + BasesParaCompatibilidad.Config.User.ToString + ")") Then

                Return 0
            End If

            dtb.PrepararConsulta("select max(AlbaranCargaMaestroID) from AlbaranesCargaMaestro")
            AlbaranCargaMaestroID = dtb.Consultar().Rows(0).Item(0)
            Return AlbaranCargaMaestroID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.PrepararConsulta("delete from AlbaranesCargaMaestro where AlbaranCargaMaestroID = @id")
            dtb.AñadirParametroConsulta("@id", Convert.ToString(AlbaranCargaMaestroID))
            If dtb.Consultar(True) Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar AlbaranCargaMaestro, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Return 0
            End If
            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("AlbaranesCargaMaestro", "AlbaranCargaMaestroID = " & Convert.ToString(AlbaranCargaMaestroID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar AlbaranCargaMaestro, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
end class
