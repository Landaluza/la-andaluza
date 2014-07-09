Public Class DBO_ControlesPresionLlenadora2

    Private m_ControlPresionLlenadora1ID As Int32
    Private m_EnvasadoID As Int32
    Private m_VerificadorID As Nullable(Of Int32)
    Private m_Hora As TimeSpan
    Private m_Presion As Nullable(Of Double)
    Private m_Correcto As Boolean
    Private m_Observaciones As String
    Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property ControlPresionLlenadora1ID() As Int32
        Get
            Return m_ControlPresionLlenadora1ID
        End Get
        Set(ByVal value As Int32)
            m_ControlPresionLlenadora1ID = value
        End Set
    End Property

    Public Property EnvasadoID() As Int32
        Get
            Return m_EnvasadoID
        End Get
        Set(ByVal value As Int32)
            m_EnvasadoID = value
        End Set
    End Property

    Public Property VerificadorID() As Nullable(Of Int32)
        Get
            Return m_VerificadorID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_VerificadorID = value
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

    Public Property Presion() As Nullable(Of Double)
        Get
            Return m_Presion
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Presion = value
        End Set
    End Property

    Public Property Correcto() As Boolean
        Get
            Return m_Correcto
        End Get
        Set(ByVal value As Boolean)
            m_Correcto = value
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

End Class
