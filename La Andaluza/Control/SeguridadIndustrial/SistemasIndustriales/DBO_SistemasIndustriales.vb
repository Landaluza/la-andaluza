Public Class DBO_SistemasIndustriales

   Private m_SistemaIndustrialID As Int32
   Private m_Descripcion As String
    Private m_FechaInstalacion As Date
   Private m_FechaInstalacion_IsDBNull As Boolean
    Private m_FechaRegistroIndustria As Date
   Private m_FechaRegistroIndustria_IsDBNull As Boolean
   Private m_ReferenciaExpedienteIndustria As String
   Private m_ReferenciaExpedienteIndustria_IsDBNull As Boolean
   Private m_ReferenciaRegistroIndustria As String
   Private m_ReferenciaRegistroIndustria_IsDBNull As Boolean
    Private m_FechaPresentacionIndustria As Date
   Private m_FechaPresentacionIndustria_IsDBNull As Boolean
   Private m_AutorProyecto As String
   Private m_AutorProyecto_IsDBNull As Boolean
   Private m_Observaciones As String
   Private m_Observaciones_IsDBNull As Boolean
   Private m_FechaModificacion As date
   Private m_FechaModificacion_IsDBNull As Boolean
   Private m_UsuarioModificacion As Int32
   Private m_UsuarioModificacion_IsDBNull As Boolean

   Public Sub New()

   End Sub

   Public Property SistemaIndustrialID() As Int32
       Get
           Return m_SistemaIndustrialID
       End Get
       Set(ByVal value As Int32)
           m_SistemaIndustrialID = value
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

    Public Property FechaInstalacion() As Date
        Get
            Return m_FechaInstalacion
        End Get
        Set(ByVal value As Date)
            m_FechaInstalacion = value
        End Set
    End Property

   Public Property FechaInstalacion_IsDBNull() As Boolean
       Get
           Return m_FechaInstalacion_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_FechaInstalacion_IsDBNull = value
       End Set
   End Property

    Public Property FechaRegistroIndustria() As Date
        Get
            Return m_FechaRegistroIndustria
        End Get
        Set(ByVal value As Date)
            m_FechaRegistroIndustria = value
        End Set
    End Property

   Public Property FechaRegistroIndustria_IsDBNull() As Boolean
       Get
           Return m_FechaRegistroIndustria_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_FechaRegistroIndustria_IsDBNull = value
       End Set
   End Property

   Public Property ReferenciaExpedienteIndustria() As String
       Get
           Return m_ReferenciaExpedienteIndustria
       End Get
       Set(ByVal value As String)
           m_ReferenciaExpedienteIndustria = value
       End Set
   End Property

   Public Property ReferenciaExpedienteIndustria_IsDBNull() As Boolean
       Get
           Return m_ReferenciaExpedienteIndustria_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_ReferenciaExpedienteIndustria_IsDBNull = value
       End Set
   End Property

   Public Property ReferenciaRegistroIndustria() As String
       Get
           Return m_ReferenciaRegistroIndustria
       End Get
       Set(ByVal value As String)
           m_ReferenciaRegistroIndustria = value
       End Set
   End Property

   Public Property ReferenciaRegistroIndustria_IsDBNull() As Boolean
       Get
           Return m_ReferenciaRegistroIndustria_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_ReferenciaRegistroIndustria_IsDBNull = value
       End Set
   End Property

    Public Property FechaPresentacionIndustria() As Date
        Get
            Return m_FechaPresentacionIndustria
        End Get
        Set(ByVal value As Date)
            m_FechaPresentacionIndustria = value
        End Set
    End Property

   Public Property FechaPresentacionIndustria_IsDBNull() As Boolean
       Get
           Return m_FechaPresentacionIndustria_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_FechaPresentacionIndustria_IsDBNull = value
       End Set
   End Property

   Public Property AutorProyecto() As String
       Get
           Return m_AutorProyecto
       End Get
       Set(ByVal value As String)
           m_AutorProyecto = value
       End Set
   End Property

   Public Property AutorProyecto_IsDBNull() As Boolean
       Get
           Return m_AutorProyecto_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_AutorProyecto_IsDBNull = value
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
