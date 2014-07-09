Public Class DBO_Proveedores_Articulos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProveedorID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ArticuloID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProveedorPrincipal As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProveedorUnico As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CantidadPedidoHabitual As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CantidadPedidoMinima As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PlazoEntrega As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PeriodosServicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorArticuloID","ProveedorArticuloID")
       m_ProveedorID= New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorID","ProveedorID")
       m_ArticuloID= New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloID","ArticuloID")
       m_ProveedorPrincipal= New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorPrincipal","ProveedorPrincipal")
       m_ProveedorUnico= New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorUnico","ProveedorUnico")
       m_CantidadPedidoHabitual= New BasesParaCompatibilidad.DataBussinesParameter("@CantidadPedidoHabitual","CantidadPedidoHabitual")
       m_CantidadPedidoMinima= New BasesParaCompatibilidad.DataBussinesParameter("@CantidadPedidoMinima","CantidadPedidoMinima")
       m_PlazoEntrega= New BasesParaCompatibilidad.DataBussinesParameter("@PlazoEntrega","PlazoEntrega")
       m_PeriodosServicio= New BasesParaCompatibilidad.DataBussinesParameter("@PeriodosServicio","PeriodosServicio")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
           Return if(isdbnull(m_id.value), Nothing, m_id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property ProveedorID() As Int32
       Get
           Return if(isdbnull(m_ProveedorID.value), Nothing, m_ProveedorID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID.value = value
       End Set
   End Property

   Public Property ArticuloID() As Int32
       Get
           Return if(isdbnull(m_ArticuloID.value), Nothing, m_ArticuloID.value)
       End Get
       Set(ByVal value As Int32)
           m_ArticuloID.value = value
       End Set
   End Property

   Public Property ProveedorPrincipal() As Boolean
       Get
           Return if(isdbnull(m_ProveedorPrincipal.value), false, m_ProveedorPrincipal.value)
       End Get
       Set(ByVal value As Boolean)
           m_ProveedorPrincipal.value = value
       End Set
   End Property

   Public Property ProveedorUnico() As Boolean
       Get
           Return if(isdbnull(m_ProveedorUnico.value), false, m_ProveedorUnico.value)
       End Get
       Set(ByVal value As Boolean)
           m_ProveedorUnico.value = value
       End Set
   End Property

   Public Property CantidadPedidoHabitual() As Int32
       Get
           Return if(isdbnull(m_CantidadPedidoHabitual.value), Nothing, m_CantidadPedidoHabitual.value)
       End Get
       Set(ByVal value As Int32)
           m_CantidadPedidoHabitual.value = value
       End Set
   End Property

   Public Property CantidadPedidoMinima() As Int32
       Get
           Return if(isdbnull(m_CantidadPedidoMinima.value), Nothing, m_CantidadPedidoMinima.value)
       End Get
       Set(ByVal value As Int32)
           m_CantidadPedidoMinima.value = value
       End Set
   End Property

   Public Property PlazoEntrega() As Int32
       Get
           Return if(isdbnull(m_PlazoEntrega.value), Nothing, m_PlazoEntrega.value)
       End Get
       Set(ByVal value As Int32)
           m_PlazoEntrega.value = value
       End Set
   End Property

   Public Property PeriodosServicio() As Int32
       Get
           Return if(isdbnull(m_PeriodosServicio.value), Nothing, m_PeriodosServicio.value)
       End Get
       Set(ByVal value As Int32)
           m_PeriodosServicio.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           Return if(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ProveedorID, m_ProveedorID.sqlName)
       MyBase.atributos.Add(m_ArticuloID, m_ArticuloID.sqlName)
       MyBase.atributos.Add(m_ProveedorPrincipal, m_ProveedorPrincipal.sqlName)
       MyBase.atributos.Add(m_ProveedorUnico, m_ProveedorUnico.sqlName)
       MyBase.atributos.Add(m_CantidadPedidoHabitual, m_CantidadPedidoHabitual.sqlName)
       MyBase.atributos.Add(m_CantidadPedidoMinima, m_CantidadPedidoMinima.sqlName)
       MyBase.atributos.Add(m_PlazoEntrega, m_PlazoEntrega.sqlName)
       MyBase.atributos.Add(m_PeriodosServicio, m_PeriodosServicio.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
