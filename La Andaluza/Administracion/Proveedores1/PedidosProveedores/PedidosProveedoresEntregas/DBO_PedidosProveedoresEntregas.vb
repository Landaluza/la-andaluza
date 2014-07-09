Public Class DBO_PedidosProveedoresEntregas

   Private m_PedidoProveedorEntregaID As Int32
   Private m_PedidoProveedorDetalleID As Int32
    Private m_Fecha As Date
    Private m_Cantidad As Double
    Private m_Observaciones As String
    Private m_Observaciones_IsDBNull As Boolean
    Private m_PedidosProveedoresDetalle_PedidoProveedorDetalleID As Int32

    Public Sub New()

    End Sub

    Public Property PedidoProveedorEntregaID() As Int32
        Get
            Return m_PedidoProveedorEntregaID
        End Get
        Set(ByVal value As Int32)
            m_PedidoProveedorEntregaID = value
        End Set
    End Property

    Public Property PedidoProveedorDetalleID() As Int32
        Get
            Return m_PedidoProveedorDetalleID
        End Get
        Set(ByVal value As Int32)
            m_PedidoProveedorDetalleID = value
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

    Public Property Cantidad() As Double
        Get
            Return m_Cantidad
        End Get
        Set(ByVal value As Double)
            m_Cantidad = value
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

   Public Property PedidosProveedoresDetalle_PedidoProveedorDetalleID() As Int32
       Get
           Return m_PedidosProveedoresDetalle_PedidoProveedorDetalleID
       End Get
       Set(ByVal value As Int32)
           m_PedidosProveedoresDetalle_PedidoProveedorDetalleID = value
       End Set
   End Property

End Class
