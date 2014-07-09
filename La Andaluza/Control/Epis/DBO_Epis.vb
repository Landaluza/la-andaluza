Public Class DBO_Epis

   Private m_EpiID As Int32
   Private m_Descripcion As String
   Private m_Marca As String
   Private m_Marca_IsDBNull As Boolean
   Private m_Modelo As String
   Private m_Modelo_IsDBNull As Boolean
   Private m_EpiTipoID As Int32
   Private m_EpiTipoID_IsDBNull As Boolean
   Private m_RiesgoQuimico As Boolean
   Private m_RiesgoMecanico As Boolean
   Private m_RiesgoMicrobiologico As Boolean
   Private m_RiesgoFrio As Boolean
   Private m_RiesgoTermico As Boolean
   Private m_Usos As String
   Private m_Usos_IsDBNull As Boolean
   Private m_Advertencias As String
   Private m_Advertencias_IsDBNull As Boolean
   Private m_Observaciones As String
   Private m_Observaciones_IsDBNull As Boolean
   Private m_aMecanico As String
   Private m_aMecanico_IsDBNull As Boolean
   Private m_bMecanico As String
   Private m_bMecanico_IsDBNull As Boolean
   Private m_cMecanico As String
   Private m_cMecanico_IsDBNull As Boolean
   Private m_dMecanico As String
   Private m_dMecanico_IsDBNull As Boolean
   Private m_aQuimico As String
   Private m_aQuimico_IsDBNull As Boolean
   Private m_aMicrobiologico As String
   Private m_aMicrobiologico_IsDBNull As Boolean
   Private m_aFrio As String
   Private m_aFrio_IsDBNull As Boolean
   Private m_bFrio As String
   Private m_bFrio_IsDBNull As Boolean
   Private m_cFrio As String
   Private m_cFrio_IsDBNull As Boolean
   Private m_FechaModificacion As Date
   Private m_FechaModificacion_IsDBNull As Boolean
   Private m_UsuarioModificacion As Int32
   Private m_UsuarioModificacion_IsDBNull As Boolean

   Public Sub New()

   End Sub

   Public Property EpiID() As Int32
       Get
           Return m_EpiID
       End Get
       Set(ByVal value As Int32)
           m_EpiID = value
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

   Public Property Marca() As String
       Get
           Return m_Marca
       End Get
       Set(ByVal value As String)
           m_Marca = value
       End Set
   End Property

   Public Property Marca_IsDBNull() As Boolean
       Get
           Return m_Marca_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Marca_IsDBNull = value
       End Set
   End Property

   Public Property Modelo() As String
       Get
           Return m_Modelo
       End Get
       Set(ByVal value As String)
           m_Modelo = value
       End Set
   End Property

   Public Property Modelo_IsDBNull() As Boolean
       Get
           Return m_Modelo_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Modelo_IsDBNull = value
       End Set
   End Property

   Public Property EpiTipoID() As Int32
       Get
           Return m_EpiTipoID
       End Get
       Set(ByVal value As Int32)
           m_EpiTipoID = value
       End Set
   End Property

   Public Property EpiTipoID_IsDBNull() As Boolean
       Get
           Return m_EpiTipoID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_EpiTipoID_IsDBNull = value
       End Set
   End Property

   Public Property RiesgoQuimico() As Boolean
       Get
           Return m_RiesgoQuimico
       End Get
       Set(ByVal value As Boolean)
           m_RiesgoQuimico = value
       End Set
   End Property

   Public Property RiesgoMecanico() As Boolean
       Get
           Return m_RiesgoMecanico
       End Get
       Set(ByVal value As Boolean)
           m_RiesgoMecanico = value
       End Set
   End Property

   Public Property RiesgoMicrobiologico() As Boolean
       Get
           Return m_RiesgoMicrobiologico
       End Get
       Set(ByVal value As Boolean)
           m_RiesgoMicrobiologico = value
       End Set
   End Property

   Public Property RiesgoFrio() As Boolean
       Get
           Return m_RiesgoFrio
       End Get
       Set(ByVal value As Boolean)
           m_RiesgoFrio = value
       End Set
   End Property

   Public Property RiesgoTermico() As Boolean
       Get
           Return m_RiesgoTermico
       End Get
       Set(ByVal value As Boolean)
           m_RiesgoTermico = value
       End Set
   End Property

   Public Property Usos() As String
       Get
           Return m_Usos
       End Get
       Set(ByVal value As String)
           m_Usos = value
       End Set
   End Property

   Public Property Usos_IsDBNull() As Boolean
       Get
           Return m_Usos_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Usos_IsDBNull = value
       End Set
   End Property

   Public Property Advertencias() As String
       Get
           Return m_Advertencias
       End Get
       Set(ByVal value As String)
           m_Advertencias = value
       End Set
   End Property

   Public Property Advertencias_IsDBNull() As Boolean
       Get
           Return m_Advertencias_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Advertencias_IsDBNull = value
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

   Public Property aMecanico() As String
       Get
           Return m_aMecanico
       End Get
       Set(ByVal value As String)
           m_aMecanico = value
       End Set
   End Property

   Public Property aMecanico_IsDBNull() As Boolean
       Get
           Return m_aMecanico_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_aMecanico_IsDBNull = value
       End Set
   End Property

   Public Property bMecanico() As String
       Get
           Return m_bMecanico
       End Get
       Set(ByVal value As String)
           m_bMecanico = value
       End Set
   End Property

   Public Property bMecanico_IsDBNull() As Boolean
       Get
           Return m_bMecanico_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_bMecanico_IsDBNull = value
       End Set
   End Property

   Public Property cMecanico() As String
       Get
           Return m_cMecanico
       End Get
       Set(ByVal value As String)
           m_cMecanico = value
       End Set
   End Property

   Public Property cMecanico_IsDBNull() As Boolean
       Get
           Return m_cMecanico_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_cMecanico_IsDBNull = value
       End Set
   End Property

   Public Property dMecanico() As String
       Get
           Return m_dMecanico
       End Get
       Set(ByVal value As String)
           m_dMecanico = value
       End Set
   End Property

   Public Property dMecanico_IsDBNull() As Boolean
       Get
           Return m_dMecanico_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_dMecanico_IsDBNull = value
       End Set
   End Property

   Public Property aQuimico() As String
       Get
           Return m_aQuimico
       End Get
       Set(ByVal value As String)
           m_aQuimico = value
       End Set
   End Property

   Public Property aQuimico_IsDBNull() As Boolean
       Get
           Return m_aQuimico_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_aQuimico_IsDBNull = value
       End Set
   End Property

   Public Property aMicrobiologico() As String
       Get
           Return m_aMicrobiologico
       End Get
       Set(ByVal value As String)
           m_aMicrobiologico = value
       End Set
   End Property

   Public Property aMicrobiologico_IsDBNull() As Boolean
       Get
           Return m_aMicrobiologico_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_aMicrobiologico_IsDBNull = value
       End Set
   End Property

   Public Property aFrio() As String
       Get
           Return m_aFrio
       End Get
       Set(ByVal value As String)
           m_aFrio = value
       End Set
   End Property

   Public Property aFrio_IsDBNull() As Boolean
       Get
           Return m_aFrio_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_aFrio_IsDBNull = value
       End Set
   End Property

   Public Property bFrio() As String
       Get
           Return m_bFrio
       End Get
       Set(ByVal value As String)
           m_bFrio = value
       End Set
   End Property

   Public Property bFrio_IsDBNull() As Boolean
       Get
           Return m_bFrio_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_bFrio_IsDBNull = value
       End Set
   End Property

   Public Property cFrio() As String
       Get
           Return m_cFrio
       End Get
       Set(ByVal value As String)
           m_cFrio = value
       End Set
   End Property

   Public Property cFrio_IsDBNull() As Boolean
       Get
           Return m_cFrio_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_cFrio_IsDBNull = value
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
