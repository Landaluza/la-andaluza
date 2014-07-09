Public Class DBO_Envasados3

    Private m_EnvasadoID As Int32
    Private m_Fecha As Date
    Private m_Observaciones As String
    Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32


    Public Sub New()
    End Sub


    Public Property EnvasadoID() As Int32
        Get
            Return m_EnvasadoID
        End Get
        Set(ByVal value As Int32)
            m_EnvasadoID = value
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

    Public Property Observaciones As String
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


#Region "Campos Adicionales"
    Private m_LineaID As Integer

    Public Property LineaID As Integer
        Get
            Return m_LineaID
        End Get
        Set(ByVal value As Integer)
            m_LineaID = value
        End Set
    End Property
#End Region

End Class
