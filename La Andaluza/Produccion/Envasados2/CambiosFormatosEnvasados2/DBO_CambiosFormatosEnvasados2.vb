Public Class DBO_CambiosFormatosEnvasados2

   Private m_CambioFormatoEnvasadoId As Int32
    Private m_HoraInicio As TimeSpan
   Private m_HoraInicio_IsDBNull As Boolean
    Private m_HoraFin As TimeSpan
   Private m_HoraFin_IsDBNull As Boolean
   Private m_Observacion As String
   Private m_Observacion_IsDBNull As Boolean
   Private m_PersonalID As Int32
   Private m_PersonalID_IsDBNull As Boolean
   Private m_TipoformatoInicialID As Int32
   Private m_TipoformatoInicialID_IsDBNull As Boolean
   Private m_FormatoEnvasadoAID As Int32
   Private m_FormatoEnvasadoAID_IsDBNull As Boolean
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property CambioFormatoEnvasadoId() As Int32
       Get
           Return m_CambioFormatoEnvasadoId
       End Get
       Set(ByVal value As Int32)
           m_CambioFormatoEnvasadoId = value
       End Set
   End Property

    Public Property HoraInicio() As TimeSpan
        Get
            Return m_HoraInicio
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio = value
        End Set
    End Property

   Public Property HoraInicio_IsDBNull() As Boolean
       Get
           Return m_HoraInicio_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_HoraInicio_IsDBNull = value
       End Set
   End Property

    Public Property HoraFin() As TimeSpan
        Get
            Return m_HoraFin
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFin = value
        End Set
    End Property

   Public Property HoraFin_IsDBNull() As Boolean
       Get
           Return m_HoraFin_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_HoraFin_IsDBNull = value
       End Set
   End Property

   Public Property Observacion() As String
       Get
           Return m_Observacion
       End Get
       Set(ByVal value As String)
           m_Observacion = value
       End Set
   End Property

   Public Property Observacion_IsDBNull() As Boolean
       Get
           Return m_Observacion_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Observacion_IsDBNull = value
       End Set
   End Property

   Public Property PersonalID() As Int32
       Get
           Return m_PersonalID
       End Get
       Set(ByVal value As Int32)
           m_PersonalID = value
       End Set
   End Property

   Public Property PersonalID_IsDBNull() As Boolean
       Get
           Return m_PersonalID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_PersonalID_IsDBNull = value
       End Set
   End Property

   Public Property TipoformatoInicialID() As Int32
       Get
           Return m_TipoformatoInicialID
       End Get
       Set(ByVal value As Int32)
           m_TipoformatoInicialID = value
       End Set
   End Property

   Public Property TipoformatoInicialID_IsDBNull() As Boolean
       Get
           Return m_TipoformatoInicialID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_TipoformatoInicialID_IsDBNull = value
       End Set
   End Property

   Public Property FormatoEnvasadoAID() As Int32
       Get
           Return m_FormatoEnvasadoAID
       End Get
       Set(ByVal value As Int32)
           m_FormatoEnvasadoAID = value
       End Set
   End Property

   Public Property FormatoEnvasadoAID_IsDBNull() As Boolean
       Get
           Return m_FormatoEnvasadoAID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_FormatoEnvasadoAID_IsDBNull = value
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
