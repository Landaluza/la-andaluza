Public Class DBO_PedidosClientesDetalles2

   Private m_PedidoClienteDatalleID As Int32
   Private m_PedidoclienteMaestroID As Int32
   Private m_ArticuloID As Int32
   Private m_Cantidad As Int32
   Private m_Servido As String
   Private m_Observaciones As String
    Private m_FechaServicio As Nullable(Of Date)
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property PedidoClienteDatalleID() As Int32
       Get
           Return m_PedidoClienteDatalleID
       End Get
       Set(ByVal value As Int32)
           m_PedidoClienteDatalleID = value
       End Set
   End Property

   Public Property PedidoclienteMaestroID() As Int32
       Get
           Return m_PedidoclienteMaestroID
       End Get
       Set(ByVal value As Int32)
           m_PedidoclienteMaestroID = value
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

   Public Property Cantidad() As Int32
       Get
           Return m_Cantidad
       End Get
       Set(ByVal value As Int32)
           m_Cantidad = value
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

    Public Property FechaServicio() As Nullable(Of Date)
        Get
            Return m_FechaServicio
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaServicio = value
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
