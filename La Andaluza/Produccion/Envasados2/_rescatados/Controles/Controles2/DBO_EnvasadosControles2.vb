Public Class DBO_EnvasadosControles2


   Private m_EnvasadoControl2ID As Int32
   Private m_EnvasadoControlID As Nullable(Of Int32)
   Private m_Boquilla1 As Boolean
   Private m_Boquilla2 As Boolean
   Private m_Boquilla3 As Boolean
   Private m_Boquilla4 As Boolean
   Private m_Boquilla5 As Boolean
   Private m_Boquilla6 As Boolean
   Private m_Etiquetado As Boolean
   Private m_Taponado As Boolean
   Private m_Bote As Boolean
   Private m_Etiqueta As Boolean
   Private m_Tapon As Boolean
   Private m_Retractil As Boolean
   Private m_Caja As Boolean
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property EnvasadoControl2ID() As Int32
       Get
           Return m_EnvasadoControl2ID
       End Get
       Set(ByVal value As Int32)
           m_EnvasadoControl2ID = value
       End Set
   End Property

   Public Property EnvasadoControlID() As Nullable(Of Int32)
       Get
           Return m_EnvasadoControlID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_EnvasadoControlID = value
       End Set
   End Property

   Public Property Boquilla1() As Boolean
       Get
           Return m_Boquilla1
       End Get
       Set(ByVal value As Boolean)
           m_Boquilla1 = value
       End Set
   End Property

   Public Property Boquilla2() As Boolean
       Get
           Return m_Boquilla2
       End Get
       Set(ByVal value As Boolean)
           m_Boquilla2 = value
       End Set
   End Property

   Public Property Boquilla3() As Boolean
       Get
           Return m_Boquilla3
       End Get
       Set(ByVal value As Boolean)
           m_Boquilla3 = value
       End Set
   End Property

   Public Property Boquilla4() As Boolean
       Get
           Return m_Boquilla4
       End Get
       Set(ByVal value As Boolean)
           m_Boquilla4 = value
       End Set
   End Property

   Public Property Boquilla5() As Boolean
       Get
           Return m_Boquilla5
       End Get
       Set(ByVal value As Boolean)
           m_Boquilla5 = value
       End Set
   End Property

   Public Property Boquilla6() As Boolean
       Get
           Return m_Boquilla6
       End Get
       Set(ByVal value As Boolean)
           m_Boquilla6 = value
       End Set
   End Property

   Public Property Etiquetado() As Boolean
       Get
           Return m_Etiquetado
       End Get
       Set(ByVal value As Boolean)
           m_Etiquetado = value
       End Set
   End Property

   Public Property Taponado() As Boolean
       Get
           Return m_Taponado
       End Get
       Set(ByVal value As Boolean)
           m_Taponado = value
       End Set
   End Property

   Public Property Bote() As Boolean
       Get
           Return m_Bote
       End Get
       Set(ByVal value As Boolean)
           m_Bote = value
       End Set
   End Property

   Public Property Etiqueta() As Boolean
       Get
           Return m_Etiqueta
       End Get
       Set(ByVal value As Boolean)
           m_Etiqueta = value
       End Set
   End Property

   Public Property Tapon() As Boolean
       Get
           Return m_Tapon
       End Get
       Set(ByVal value As Boolean)
           m_Tapon = value
       End Set
   End Property

   Public Property Retractil() As Boolean
       Get
           Return m_Retractil
       End Get
       Set(ByVal value As Boolean)
           m_Retractil = value
       End Set
   End Property

   Public Property Caja() As Boolean
       Get
           Return m_Caja
       End Get
       Set(ByVal value As Boolean)
           m_Caja = value
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
