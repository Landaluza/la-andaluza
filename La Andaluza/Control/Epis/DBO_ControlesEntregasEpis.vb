Public Class DBO_ControlesEntregasEpis

   Private m_ControlEntregaEpiID As Int32
    Private m_FechaEntrega As Date
   Private m_EpiID As Int32
   Private m_EmpleadoID As Int32
   Private m_Observaciones As String
   Private m_Observaciones_IsDBNull As Boolean
   Private m_EntregaAnteriores As Boolean
   Private m_FechaModificacion As Date
   Private m_FechaModificacion_IsDBNull As Boolean
   Private m_UsuarioModificacion As Int32
   Private m_UsuarioModificacion_IsDBNull As Boolean

   Public Sub New()

   End Sub

   Public Property ControlEntregaEpiID() As Int32
       Get
           Return m_ControlEntregaEpiID
       End Get
       Set(ByVal value As Int32)
           m_ControlEntregaEpiID = value
       End Set
   End Property

    Public Property FechaEntrega() As Date
        Get
            Return m_FechaEntrega
        End Get
        Set(ByVal value As Date)
            m_FechaEntrega = value
        End Set
    End Property

   Public Property EpiID() As Int32
       Get
           Return m_EpiID
       End Get
       Set(ByVal value As Int32)
           m_EpiID = value
       End Set
   End Property

   Public Property EmpleadoID() As Int32
       Get
           Return m_EmpleadoID
       End Get
       Set(ByVal value As Int32)
           m_EmpleadoID = value
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

   Public Property EntregaAnteriores() As Boolean
       Get
           Return m_EntregaAnteriores
       End Get
       Set(ByVal value As Boolean)
           m_EntregaAnteriores = value
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
