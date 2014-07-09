Public Class DBO_EnvasadosControles


   Private m_EnvasadoControlID As Int32
   Private m_ResponsableID As Nullable(Of Int32)
   Private m_FormatoEnvasadoID As Nullable(Of Int32)
    Private m_Hora As TimeSpan
   Private m_LoteadoEnvase As Boolean
   Private m_LoteadoCaja As Boolean
   Private m_EtiquetaPalet As Boolean
   Private m_Mosaico As Boolean
   Private m_Paletizado As Boolean
   Private m_TodoCorrecto As Boolean
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property EnvasadoControlID() As Int32
       Get
           Return m_EnvasadoControlID
       End Get
       Set(ByVal value As Int32)
           m_EnvasadoControlID = value
       End Set
   End Property

   Public Property ResponsableID() As Nullable(Of Int32)
       Get
           Return m_ResponsableID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ResponsableID = value
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

    Public Property Hora() As TimeSpan
        Get
            Return m_Hora
        End Get
        Set(ByVal value As TimeSpan)
            m_Hora = value
        End Set
    End Property

   Public Property LoteadoEnvase() As Boolean
       Get
           Return m_LoteadoEnvase
       End Get
       Set(ByVal value As Boolean)
           m_LoteadoEnvase = value
       End Set
   End Property

   Public Property LoteadoCaja() As Boolean
       Get
           Return m_LoteadoCaja
       End Get
       Set(ByVal value As Boolean)
           m_LoteadoCaja = value
       End Set
   End Property

   Public Property EtiquetaPalet() As Boolean
       Get
           Return m_EtiquetaPalet
       End Get
       Set(ByVal value As Boolean)
           m_EtiquetaPalet = value
       End Set
   End Property

   Public Property Mosaico() As Boolean
       Get
           Return m_Mosaico
       End Get
       Set(ByVal value As Boolean)
           m_Mosaico = value
       End Set
   End Property

   Public Property Paletizado() As Boolean
       Get
           Return m_Paletizado
       End Get
       Set(ByVal value As Boolean)
           m_Paletizado = value
       End Set
   End Property

   Public Property TodoCorrecto() As Boolean
       Get
           Return m_TodoCorrecto
       End Get
       Set(ByVal value As Boolean)
           m_TodoCorrecto = value
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
