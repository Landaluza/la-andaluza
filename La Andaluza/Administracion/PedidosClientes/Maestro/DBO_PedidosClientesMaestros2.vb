Public Class DBO_PedidosClientesMaestros2


    Private m_PedidoClienteMaestroID As Int32
    Private m_ClienteID As Int32
    Private m_Numero As Int32
    Private m_FechaEmision As Date
    Private m_FechaServicio As Nullable(Of Date)
    Private m_Servido As String
    Private m_Observaciones As String
    Private m_NumeroPedidoCliente As Nullable(Of Int32)
    'Private m_PedidoClienteLugarEntregaID As Nullable(Of Int32)
    Private m_PedidoClienteLugarEntregaID As Int32
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property PedidoClienteMaestroID() As Int32
        Get
            Return m_PedidoClienteMaestroID
        End Get
        Set(ByVal value As Int32)
            m_PedidoClienteMaestroID = value
        End Set
    End Property

    Public Property ClienteID() As Int32
        Get
            Return m_ClienteID
        End Get
        Set(ByVal value As Int32)
            m_ClienteID = value
        End Set
    End Property

    Public Property Numero() As Int32
        Get
            Return m_Numero
        End Get
        Set(ByVal value As Int32)
            m_Numero = value
        End Set
    End Property

    Public Property FechaEmision() As Date
        Get
            Return m_FechaEmision
        End Get
        Set(ByVal value As Date)
            m_FechaEmision = value
        End Set
    End Property

    Public Property FechaServicio() As Nullable(Of Date)
        Get
            Return m_FechaServicio
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaServicio = value
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

    Public Property Observaciones() As String
        Get
            Return m_Observaciones
        End Get
        Set(ByVal value As String)
            m_Observaciones = value
        End Set
    End Property

    Public Property NumeroPedidoCliente() As Nullable(Of Int32)
        Get
            Return m_NumeroPedidoCliente
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_NumeroPedidoCliente = value
        End Set
    End Property

    'Public Property PedidoClienteLugarEntregaID() As Nullable(Of Int32)
    '    Get
    '        Return m_PedidoClienteLugarEntregaID
    '    End Get
    '    Set(ByVal value As Nullable(Of Int32))
    '        m_PedidoClienteLugarEntregaID = value
    '    End Set
    'End Property


    Public Property PedidoClienteLugarEntregaID() As Int32
        Get
            Return m_PedidoClienteLugarEntregaID
        End Get
        Set(ByVal value As Int32)
            m_PedidoClienteLugarEntregaID = value
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
