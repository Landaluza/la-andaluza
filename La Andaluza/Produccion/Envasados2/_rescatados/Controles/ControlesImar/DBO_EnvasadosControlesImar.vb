Public Class DBO_EnvasadosControlesImar


   Private m_EnvasadoControlImarID As Int32
   Private m_EnvasadoControlID As Nullable(Of Int32)
   Private m_Peso1 As Boolean
   Private m_Peso2 As Boolean
   Private m_Peso3 As Boolean
   Private m_Peso4 As Boolean
   Private m_Peso5 As Boolean
   Private m_Peso6 As Boolean
   Private m_SuciedadExterior As Boolean
   Private m_MaterialExtraños As Boolean
   Private m_FormaDelSobre As Boolean
   Private m_BordesAbiertos As Boolean
   Private m_BordesManchados As Boolean
   Private m_SeparacionMonodosis As Boolean
   Private m_AbreFaciles As Boolean
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property EnvasadoControlImarID() As Int32
       Get
           Return m_EnvasadoControlImarID
       End Get
       Set(ByVal value As Int32)
           m_EnvasadoControlImarID = value
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

   Public Property Peso1() As Boolean
       Get
           Return m_Peso1
       End Get
       Set(ByVal value As Boolean)
           m_Peso1 = value
       End Set
   End Property

   Public Property Peso2() As Boolean
       Get
           Return m_Peso2
       End Get
       Set(ByVal value As Boolean)
           m_Peso2 = value
       End Set
   End Property

   Public Property Peso3() As Boolean
       Get
           Return m_Peso3
       End Get
       Set(ByVal value As Boolean)
           m_Peso3 = value
       End Set
   End Property

   Public Property Peso4() As Boolean
       Get
           Return m_Peso4
       End Get
       Set(ByVal value As Boolean)
           m_Peso4 = value
       End Set
   End Property

   Public Property Peso5() As Boolean
       Get
           Return m_Peso5
       End Get
       Set(ByVal value As Boolean)
           m_Peso5 = value
       End Set
   End Property

   Public Property Peso6() As Boolean
       Get
           Return m_Peso6
       End Get
       Set(ByVal value As Boolean)
           m_Peso6 = value
       End Set
   End Property

   Public Property SuciedadExterior() As Boolean
       Get
           Return m_SuciedadExterior
       End Get
       Set(ByVal value As Boolean)
           m_SuciedadExterior = value
       End Set
   End Property

   Public Property MaterialExtraños() As Boolean
       Get
           Return m_MaterialExtraños
       End Get
       Set(ByVal value As Boolean)
           m_MaterialExtraños = value
       End Set
   End Property

   Public Property FormaDelSobre() As Boolean
       Get
           Return m_FormaDelSobre
       End Get
       Set(ByVal value As Boolean)
           m_FormaDelSobre = value
       End Set
   End Property

   Public Property BordesAbiertos() As Boolean
       Get
           Return m_BordesAbiertos
       End Get
       Set(ByVal value As Boolean)
           m_BordesAbiertos = value
       End Set
   End Property

   Public Property BordesManchados() As Boolean
       Get
           Return m_BordesManchados
       End Get
       Set(ByVal value As Boolean)
           m_BordesManchados = value
       End Set
   End Property

   Public Property SeparacionMonodosis() As Boolean
       Get
           Return m_SeparacionMonodosis
       End Get
       Set(ByVal value As Boolean)
           m_SeparacionMonodosis = value
       End Set
   End Property

   Public Property AbreFaciles() As Boolean
       Get
           Return m_AbreFaciles
       End Get
       Set(ByVal value As Boolean)
           m_AbreFaciles = value
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
