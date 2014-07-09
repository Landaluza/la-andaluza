Public Class DBO_EnvasadosProductosAnaliticas2

    Private m_EnvasadoProductoAnaliticaID As Int32
    Private m_EnvasadoProductoID As Nullable(Of Int32)
    Private m_ParametroID As Nullable(Of Int32)
    Private m_AnalistaID As Nullable(Of Int32)
    Private m_Valor As Nullable(Of Double)
    Private m_Hora As TimeSpan
    Private m_Observaciones As String
    Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property EnvasadoProductoAnaliticaID() As Int32
        Get
            Return m_EnvasadoProductoAnaliticaID
        End Get
        Set(ByVal value As Int32)
            m_EnvasadoProductoAnaliticaID = value
        End Set
    End Property

    Public Property EnvasadoProductoID() As Nullable(Of Int32)
        Get
            Return m_EnvasadoProductoID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_EnvasadoProductoID = value
        End Set
    End Property

    Public Property ParametroID() As Nullable(Of Int32)
        Get
            Return m_ParametroID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_ParametroID = value
        End Set
    End Property

    Public Property AnalistaID() As Nullable(Of Int32)
        Get
            Return m_AnalistaID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_AnalistaID = value
        End Set
    End Property

    Public Property Valor() As Nullable(Of Double)
        Get
            Return m_Valor
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Valor = value
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
