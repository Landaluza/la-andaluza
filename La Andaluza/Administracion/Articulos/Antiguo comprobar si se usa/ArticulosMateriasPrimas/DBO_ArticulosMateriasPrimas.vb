Public Class DBO_ArticulosMateriasPrimas

   Private m_MateriaPrimaID As Int32
   Private m_ArticuloID As Nullable(Of Int32)
   Private m_MateriaPrimaTipoID As Nullable(Of Int32)
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property MateriaPrimaID() As Int32
       Get
           Return m_MateriaPrimaID
       End Get
       Set(ByVal value As Int32)
           m_MateriaPrimaID = value
       End Set
   End Property

   Public Property ArticuloID() As Nullable(Of Int32)
       Get
           Return m_ArticuloID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ArticuloID = value
       End Set
   End Property

   Public Property MateriaPrimaTipoID() As Nullable(Of Int32)
       Get
           Return m_MateriaPrimaTipoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_MateriaPrimaTipoID = value
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
