Public Class DBO_ParadaOrdenadas2

   Private m_ParadaOrdenadaID As Int32
    Private m_HoraInicio As TimeSpan
   Private m_HoraInicio_IsDBNull As Boolean
    Private m_HoraFinal As TimeSpan
   Private m_HoraFinal_IsDBNull As Boolean
   Private m_Observacion As String
   Private m_Observacion_IsDBNull As Boolean
   Private m_ParadaOrdenadaMotivoID As Int32
   Private m_ParadaOrdenadaMotivoID_IsDBNull As Boolean
   Private m_PersonalID As Int32
   Private m_PersonalID_IsDBNull As Boolean
   Private m_FormatoEnvasadoID As Int32
   Private m_FormatoEnvasadoID_IsDBNull As Boolean
   Private m_FechaModificacion As Date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property ParadaOrdenadaID() As Int32
       Get
           Return m_ParadaOrdenadaID
       End Get
       Set(ByVal value As Int32)
           m_ParadaOrdenadaID = value
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

    Public Property HoraFinal() As TimeSpan
        Get
            Return m_HoraFinal
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFinal = value
        End Set
    End Property

   Public Property HoraFinal_IsDBNull() As Boolean
       Get
           Return m_HoraFinal_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_HoraFinal_IsDBNull = value
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

   Public Property ParadaOrdenadaMotivoID() As Int32
       Get
           Return m_ParadaOrdenadaMotivoID
       End Get
       Set(ByVal value As Int32)
           m_ParadaOrdenadaMotivoID = value
       End Set
   End Property

   Public Property ParadaOrdenadaMotivoID_IsDBNull() As Boolean
       Get
           Return m_ParadaOrdenadaMotivoID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_ParadaOrdenadaMotivoID_IsDBNull = value
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

   Public Property FormatoEnvasadoID() As Int32
       Get
           Return m_FormatoEnvasadoID
       End Get
       Set(ByVal value As Int32)
           m_FormatoEnvasadoID = value
       End Set
   End Property

   Public Property FormatoEnvasadoID_IsDBNull() As Boolean
       Get
           Return m_FormatoEnvasadoID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_FormatoEnvasadoID_IsDBNull = value
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
