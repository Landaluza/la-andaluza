Public Class DBO_VelocidadEnvasados2

   Private m_VelocidadEnvasadoID As Int32
    Private m_HoraInicio As Nullable(Of TimeSpan)
   Private m_Velocidad As Nullable(Of Int32)
   Private m_Observacion As String
   Private m_PersonalID As Nullable(Of Int32)
   Private m_FormatoEnvasadoID As Nullable(Of Int32)
   Private m_FechaModificacion As Date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property VelocidadEnvasadoID() As Int32
       Get
           Return m_VelocidadEnvasadoID
       End Get
       Set(ByVal value As Int32)
           m_VelocidadEnvasadoID = value
       End Set
   End Property

    Public Property HoraInicio() As Nullable(Of TimeSpan)
        Get
            Return m_HoraInicio
        End Get
        Set(ByVal value As Nullable(Of TimeSpan))
            m_HoraInicio = value
        End Set
    End Property

   Public Property Velocidad() As Nullable(Of Int32)
       Get
           Return m_Velocidad
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_Velocidad = value
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

   Public Property PersonalID() As Nullable(Of Int32)
       Get
           Return m_PersonalID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_PersonalID = value
       End Set
   End Property

   Public Property FormatoEnvasadoID() As Nullable(Of Int32)
       Get
           Return m_FormatoEnvasadoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_FormatoEnvasadoID = value
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
