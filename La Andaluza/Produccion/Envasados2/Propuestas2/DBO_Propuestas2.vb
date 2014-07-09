Public Class DBO_Propuestas2

    Private m_PropuestaID As Int32
    Private m_Descripcion As String
    Private m_Descripcion_IsDBNull As Boolean
    Private m_PropuestaTipoMejoraID As Int32
    Private m_PropuestaTipoMejoraID_IsDBNull As Boolean
    Private m_PropuestaUrgenciaID As Int32
    Private m_PropuestaUrgenciaID_IsDBNull As Boolean
    Private m_PersonalID As Int32
    Private m_PersonalID_IsDBNull As Boolean
    Private m_FormatoEnvasadoID As Int32
    Private m_FormatoEnvasadoID_IsDBNull As Boolean
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32

    Private Shared datos As DBO_Propuestas2

    Private Sub New()
    End Sub

    Public Shared Function Instance() As DBO_Propuestas2
        If datos Is Nothing Then
            datos = New DBO_Propuestas2()
        End If
        Return datos
    End Function

    Public Sub Limpiar()
        m_PropuestaID = 0
        m_Descripcion = ""
        m_PropuestaTipoMejoraID = 0
        m_PropuestaUrgenciaID = 0
        m_PersonalID = 0
        m_FormatoEnvasadoID = 0
        m_FechaModificacion = Nothing
        m_UsuarioModificacion = 0
    End Sub

   Public Property PropuestaID() As Int32
       Get
           Return m_PropuestaID
       End Get
       Set(ByVal value As Int32)
           m_PropuestaID = value
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

   Public Property PropuestaTipoMejoraID() As Int32
       Get
           Return m_PropuestaTipoMejoraID
       End Get
       Set(ByVal value As Int32)
           m_PropuestaTipoMejoraID = value
       End Set
   End Property

   Public Property PropuestaTipoMejoraID_IsDBNull() As Boolean
       Get
           Return m_PropuestaTipoMejoraID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_PropuestaTipoMejoraID_IsDBNull = value
       End Set
   End Property

   Public Property PropuestaUrgenciaID() As Int32
       Get
           Return m_PropuestaUrgenciaID
       End Get
       Set(ByVal value As Int32)
           m_PropuestaUrgenciaID = value
       End Set
   End Property

   Public Property PropuestaUrgenciaID_IsDBNull() As Boolean
       Get
           Return m_PropuestaUrgenciaID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_PropuestaUrgenciaID_IsDBNull = value
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
