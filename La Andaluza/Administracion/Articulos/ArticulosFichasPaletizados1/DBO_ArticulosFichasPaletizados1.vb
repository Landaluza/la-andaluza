Public Class DBO_ArticulosFichasPaletizados1

   Private m_ArticuloFichaPaletizadoID As Int32
   Private m_ArticuloID As Nullable(Of Int32)
   Private m_Descripcion As String
   Private m_Ruta As String
    Private m_FechaVigente As Nullable(Of Date)
    Private m_FechaObsoleta As Nullable(Of Date)
   Private m_Vigente As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property ArticuloFichaPaletizadoID() As Int32
       Get
           Return m_ArticuloFichaPaletizadoID
       End Get
       Set(ByVal value As Int32)
           m_ArticuloFichaPaletizadoID = value
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

   Public Property Descripcion() As String
       Get
           Return m_Descripcion
       End Get
       Set(ByVal value As String)
           m_Descripcion = value
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

    Public Property FechaVigente() As Nullable(Of Date)
        Get
            Return m_FechaVigente
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaVigente = value
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

   Public Property Vigente() As String
       Get
           Return m_Vigente
       End Get
       Set(ByVal value As String)
           m_Vigente = value
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
