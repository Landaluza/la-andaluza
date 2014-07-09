Public Class DBO_PaletsMovimientoSubTipo

   Private m_ID As Int32
   Private m_Tipo As Int32
   Private m_Tipo_IsDBNull As Boolean
   Private m_Descripcion As String
   Private m_Descripcion_IsDBNull As Boolean
   Private m_FechaModificacion As date
   Private m_FechaModificacion_IsDBNull As Boolean
   Private m_UsuarioModificacion As Int32
   Private m_UsuarioModificacion_IsDBNull As Boolean

   Public Sub New()

   End Sub

   Public Property ID() As Int32
       Get
           Return m_ID
       End Get
       Set(ByVal value As Int32)
           m_ID = value
       End Set
   End Property

   Public Property Tipo() As Int32
       Get
           Return m_Tipo
       End Get
       Set(ByVal value As Int32)
           m_Tipo = value
       End Set
   End Property

   Public Property Tipo_IsDBNull() As Boolean
       Get
           Return m_Tipo_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Tipo_IsDBNull = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
           Return m_Descripcion
       End Get
       Set(ByVal value As String)
           m_Descripcion = value
       End Set
   End Property

   Public Property Descripcion_IsDBNull() As Boolean
       Get
           Return m_Descripcion_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Descripcion_IsDBNull = value
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

   Public Property FechaModificacion_IsDBNull() As Boolean
       Get
           Return m_FechaModificacion_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_FechaModificacion_IsDBNull = value
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

   Public Property UsuarioModificacion_IsDBNull() As Boolean
       Get
           Return m_UsuarioModificacion_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_UsuarioModificacion_IsDBNull = value
       End Set
   End Property

End Class
