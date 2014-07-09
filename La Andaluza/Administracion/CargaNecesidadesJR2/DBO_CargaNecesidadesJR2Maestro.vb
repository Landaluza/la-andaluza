Public Class DBO_CargaNecesidadesJR2Maestro

    Private m_CargaNecesidadesJRMaestroID As Int32
    Private m_Fecha As Date
    Private m_Hora As TimeSpan
    Private m_Observaciones As String
    Private m_Reserva1 As String
    Private m_Reserva2 As String
    Private m_Reserva3 As String
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32
    Private m_Servido As String

    Public Sub New()

    End Sub

    Public Property CargaNecesidadesJRMaestroID() As Int32
        Get
            Return m_CargaNecesidadesJRMaestroID
        End Get
        Set(ByVal value As Int32)
            m_CargaNecesidadesJRMaestroID = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return m_Fecha
        End Get
        Set(ByVal value As Date)
            m_Fecha = value
        End Set
    End Property

    Public Property Hora() As TimeSpan
        Get
            Return m_Hora
        End Get
        Set(ByVal value As TimeSpan)
            m_Hora = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return m_Observaciones
        End Get
        Set(ByVal value As String)
            m_Observaciones = value
        End Set
    End Property


    Public Property Reserva1() As String
        Get
            Return m_Reserva1
        End Get
        Set(ByVal value As String)
            m_Reserva1 = value
        End Set
    End Property


    Public Property Reserva2() As String
        Get
            Return m_Reserva2
        End Get
        Set(ByVal value As String)
            m_Reserva2 = value
        End Set
    End Property

    Public Property Reserva3() As String
        Get
            Return m_Reserva3
        End Get
        Set(ByVal value As String)
            m_Reserva3 = value
        End Set
    End Property

    Public Property FechaModificacion() As Date
        Get
            Return m_FechaModificacion
        End Get
        Set(ByVal value As Date)
            m_FechaModificacion = value
        End Set
    End Property

    Public Property UsuarioModificacion() As Int32
        Get
            Return m_UsuarioModificacion
        End Get
        Set(ByVal value As Int32)
            m_UsuarioModificacion = value
        End Set
    End Property

    Public Property Servido() As String
        Get
            Return m_Servido
        End Get
        Set(ByVal value As String)
            m_Servido = value
        End Set
    End Property

End Class
