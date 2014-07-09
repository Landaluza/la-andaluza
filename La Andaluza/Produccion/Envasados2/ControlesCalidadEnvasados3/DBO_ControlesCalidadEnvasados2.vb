Public Class DBO_ControlesCalidadEnvasados2


   Private m_ControlCalidadEnvasados2ID As Int32
   Private m_Botella As Boolean
   Private m_Etiqueta As Boolean
   Private m_LoteadoEtiqueta As Boolean
   Private m_Caja As Boolean
   Private m_LoteadoCaja As Boolean
   Private m_Palet As Boolean
   Private m_Muestra As Boolean
   Private m_Observaciones As String
   Private m_Nuevo As String
   Private m_OtroNuevo As String
   Private m_SegundoNuevo As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property ControlCalidadEnvasados2ID() As Int32
       Get
           Return m_ControlCalidadEnvasados2ID
       End Get
       Set(ByVal value As Int32)
           m_ControlCalidadEnvasados2ID = value
       End Set
   End Property

   Public Property Botella() As Boolean
       Get
           Return m_Botella
       End Get
       Set(ByVal value As Boolean)
           m_Botella = value
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

   Public Property LoteadoEtiqueta() As Boolean
       Get
           Return m_LoteadoEtiqueta
       End Get
       Set(ByVal value As Boolean)
           m_LoteadoEtiqueta = value
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

   Public Property LoteadoCaja() As Boolean
       Get
           Return m_LoteadoCaja
       End Get
       Set(ByVal value As Boolean)
           m_LoteadoCaja = value
       End Set
   End Property

   Public Property Palet() As Boolean
       Get
           Return m_Palet
       End Get
       Set(ByVal value As Boolean)
           m_Palet = value
       End Set
   End Property

   Public Property Muestra() As Boolean
       Get
           Return m_Muestra
       End Get
       Set(ByVal value As Boolean)
           m_Muestra = value
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

   Public Property Nuevo() As String
       Get
           Return m_Nuevo
       End Get
       Set(ByVal value As String)
           m_Nuevo = value
       End Set
   End Property

   Public Property OtroNuevo() As String
       Get
           Return m_OtroNuevo
       End Get
       Set(ByVal value As String)
           m_OtroNuevo = value
       End Set
   End Property

   Public Property SegundoNuevo() As String
       Get
           Return m_SegundoNuevo
       End Get
       Set(ByVal value As String)
           m_SegundoNuevo = value
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
