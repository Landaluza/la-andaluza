Public Class DBO_PedidosProveedoresDetalles

    Private m_PedidoProveedorDetalleID As Int32
    Private m_PedidoProveedorMaestroID As Int32
    Private m_ArticuloID As Int32
    Private m_Cantidad As Double
    Private m_FechaServicio As Date
    Private m_Observaciones As String
    Private m_Observaciones_IsDBNull As Boolean
    Private m_EstadoID As Int32
    Private m_PedidosProveedoresMaestro_PedidoProveedorMaestroID As Int32
    Private m_MedidaProductoID As Int32
    Private m_MedidaProductoID_IsDBNull As Boolean

    Public Sub New()

    End Sub

    Public Property PedidoProveedorDetalleID() As Int32
        Get
            Return m_PedidoProveedorDetalleID
        End Get
        Set(ByVal value As Int32)
            m_PedidoProveedorDetalleID = value
        End Set
    End Property

    Public Property PedidoProveedorMaestroID() As Int32
        Get
            Return m_PedidoProveedorMaestroID
        End Get
        Set(ByVal value As Int32)
            m_PedidoProveedorMaestroID = value
        End Set
    End Property

    Public Property ArticuloID() As Int32
        Get
            Return m_ArticuloID
        End Get
        Set(ByVal value As Int32)
            m_ArticuloID = value
        End Set
    End Property

    Public Property Cantidad() As Double
        Get
            Return m_Cantidad
        End Get
        Set(ByVal value As Double)
            m_Cantidad = value
        End Set
    End Property

    Public Property FechaServicio() As Date
        Get
            Return m_FechaServicio
        End Get
        Set(ByVal value As Date)
            m_FechaServicio = value
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

    Public Property Observaciones_IsDBNull() As Boolean
        Get
            Return m_Observaciones_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Observaciones_IsDBNull = value
        End Set
    End Property

    Public Property EstadoID() As Int32
        Get
            Return m_EstadoID
        End Get
        Set(ByVal value As Int32)
            m_EstadoID = value
        End Set
    End Property

    Public Property PedidosProveedoresMaestro_PedidoProveedorMaestroID() As Int32
        Get
            Return m_PedidosProveedoresMaestro_PedidoProveedorMaestroID
        End Get
        Set(ByVal value As Int32)
            m_PedidosProveedoresMaestro_PedidoProveedorMaestroID = value
        End Set
    End Property

   Public Property MedidaProductoID() As Int32
       Get
           Return m_MedidaProductoID
       End Get
       Set(ByVal value As Int32)
           m_MedidaProductoID = value
       End Set
   End Property

   Public Property MedidaProductoID_IsDBNull() As Boolean
       Get
           Return m_MedidaProductoID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_MedidaProductoID_IsDBNull = value
       End Set
   End Property
End Class
