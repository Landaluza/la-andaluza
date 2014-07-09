Public Class DBO_EnvasadosControlesUlma


   Private m_EnvasadoControlUlmaID As Int32
   Private m_EnvasadoControlID As Nullable(Of Int32)
   Private m_SoldaduraBolsa As Boolean
   Private m_SuciedadBolsa As Boolean
   Private m_CentradoBolsa As Boolean
   Private m_DiseñoBobina As Boolean
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property EnvasadoControlUlmaID() As Int32
       Get
           Return m_EnvasadoControlUlmaID
       End Get
       Set(ByVal value As Int32)
           m_EnvasadoControlUlmaID = value
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

   Public Property SoldaduraBolsa() As Boolean
       Get
           Return m_SoldaduraBolsa
       End Get
       Set(ByVal value As Boolean)
           m_SoldaduraBolsa = value
       End Set
   End Property

   Public Property SuciedadBolsa() As Boolean
       Get
           Return m_SuciedadBolsa
       End Get
       Set(ByVal value As Boolean)
           m_SuciedadBolsa = value
       End Set
   End Property

   Public Property CentradoBolsa() As Boolean
       Get
           Return m_CentradoBolsa
       End Get
       Set(ByVal value As Boolean)
           m_CentradoBolsa = value
       End Set
   End Property

   Public Property DiseñoBobina() As Boolean
       Get
           Return m_DiseñoBobina
       End Get
       Set(ByVal value As Boolean)
           m_DiseñoBobina = value
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
