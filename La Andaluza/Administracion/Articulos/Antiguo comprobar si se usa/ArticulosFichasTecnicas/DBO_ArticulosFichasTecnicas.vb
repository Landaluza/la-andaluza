Public Class DBO_ArticulosFichasTecnicas

   Private m_ArticuloFichaTecnicaID As Int32
   Private m_ArticuloID As Int32
   Private m_ProveedorID As Int32
   Private m_AprobadorID As Int32
   Private m_EstadoID As Int32
   Private m_Version As Int32
    Private m_FechaAprobacion As Date
    Private m_FechaObsoleta As Nullable(Of Date)
   Private m_Ruta As String
   Private m_CambiosAnterior As String
   Private m_PropuestasCambios As String
   Private m_MotivoPasoObsoleta As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property ArticuloFichaTecnicaID() As Int32
       Get
           Return m_ArticuloFichaTecnicaID
       End Get
       Set(ByVal value As Int32)
           m_ArticuloFichaTecnicaID = value
       End Set
   End Property

   Public Property ArticuloID() As Int32
       Get
           Return m_ArticuloID
       End Get
       Set(ByVal value As Int32)
           m_ArticuloID = value
       End Set
   End Property

   Public Property ProveedorID() As Int32
       Get
           Return m_ProveedorID
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID = value
       End Set
   End Property

   Public Property AprobadorID() As Int32
       Get
           Return m_AprobadorID
       End Get
       Set(ByVal value As Int32)
           m_AprobadorID = value
       End Set
   End Property

   Public Property EstadoID() As Int32
       Get
           Return m_EstadoID
       End Get
       Set(ByVal value As Int32)
           m_EstadoID = value
       End Set
   End Property

   Public Property Version() As Int32
       Get
           Return m_Version
       End Get
       Set(ByVal value As Int32)
           m_Version = value
       End Set
   End Property

    Public Property FechaAprobacion() As Date
        Get
            Return m_FechaAprobacion
        End Get
        Set(ByVal value As Date)
            m_FechaAprobacion = value
        End Set
    End Property

    Public Property FechaObsoleta() As Nullable(Of Date)
        Get
            Return m_FechaObsoleta
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaObsoleta = value
        End Set
    End Property

   Public Property Ruta() As String
       Get
           Return m_Ruta
       End Get
       Set(ByVal value As String)
           m_Ruta = value
       End Set
   End Property

   Public Property CambiosAnterior() As String
       Get
           Return m_CambiosAnterior
       End Get
       Set(ByVal value As String)
           m_CambiosAnterior = value
       End Set
   End Property

   Public Property PropuestasCambios() As String
       Get
           Return m_PropuestasCambios
       End Get
       Set(ByVal value As String)
           m_PropuestasCambios = value
       End Set
   End Property

   Public Property MotivoPasoObsoleta() As String
       Get
           Return m_MotivoPasoObsoleta
       End Get
       Set(ByVal value As String)
           m_MotivoPasoObsoleta = value
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
