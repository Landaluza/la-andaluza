Public Class DBO_Proveedores_ProveedoresTipos

   Private m_Proveedor_ProveedorTipoID As Int32
   Private m_ProveedorID As Nullable(Of Int32)
   Private m_ProveedorTipoID As Nullable(Of Int32)
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property Proveedor_ProveedorTipoID() As Int32
       Get
           Return m_Proveedor_ProveedorTipoID
       End Get
       Set(ByVal value As Int32)
           m_Proveedor_ProveedorTipoID = value
       End Set
   End Property

   Public Property ProveedorID() As Nullable(Of Int32)
       Get
           Return m_ProveedorID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ProveedorID = value
       End Set
   End Property

   Public Property ProveedorTipoID() As Nullable(Of Int32)
       Get
           Return m_ProveedorTipoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ProveedorTipoID = value
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
