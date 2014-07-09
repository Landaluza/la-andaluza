Public Class clsCargaNecesidadesJRMaestro

#Region "Atributos"
    Private CargaNecesidadesJRMaestroID As Integer
    Private Fecha As DateTime
    Private Hora As DateTime
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
#End Region

#Region "Propiedades"
    Public Property _CargaNecesidadesJRMaestroID() As Integer
        Get
            Return CargaNecesidadesJRMaestroID
        End Get

        Set(ByVal value As Integer)
            CargaNecesidadesJRMaestroID = value
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

    Public Property _Hora() As DateTime
        Get
            Return Hora
        End Get

        Set(ByVal value As DateTime)
            Hora = value
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

    Public Function Devolver() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("CargaNecesidadesJRMaestro.CargaNecesidadesJRMaestroID,CargaNecesidadesJRMaestro.Fecha,CargaNecesidadesJRMaestro.Hora,CargaNecesidadesJRMaestro.Observaciones,CargaNecesidadesJRMaestro.Reserva1,CargaNecesidadesJRMaestro.Reserva2,CargaNecesidadesJRMaestro.Reserva3", "CargaNecesidadesJRMaestro")
    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("CargaNecesidadesJRMaestro", _
                                 "Fecha='" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                                 "Hora='" & BasesParaCompatibilidad.Calendar.ArmarFecha(Hora) & "'," & _
                                 "Observaciones='" & Observaciones & "'," & _
                                 "Reserva1='" & Reserva1 & "'," & _
                                 "Reserva2='" & Reserva2 & "'," & _
                                 "Reserva3='" & Reserva3 & "'", _
                                 "CargaNecesidadesJRMaestroID=" & Convert.ToString(CargaNecesidadesJRMaestroID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                       "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                       "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Hora) & "'," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'", _
                       "CargaNecesidadesJRMaestro")
            CargaNecesidadesJRMaestroID = BasesParaCompatibilidad.BD.ConsultaVer("max(CargaNecesidadesJRMaestroID)", "CargaNecesidadesJRMaestro").Rows(0).Item(0)
            Return CargaNecesidadesJRMaestroID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaEliminar("CargaNecesidadesJRMaestro", "CargaNecesidadesJRMaestroID = " & Convert.ToString(CargaNecesidadesJRMaestroID)) = 0 Then
                MessageBox.Show("no se puede eliminar CargaNecesidadesJRMaestro, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
