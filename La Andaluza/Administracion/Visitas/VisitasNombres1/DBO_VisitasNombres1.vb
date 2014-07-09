Public Class DBO_VisitasNombres1


   Private m_VisitaNombreID As Int32
   Private m_EmpresaID As Nullable(Of Int32)
   Private m_Nombre As String
   Private m_DNI As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32
   Private m_VisitaTipoID As Nullable(Of Int32)


   Public Sub New()

   End Sub


   Public Property VisitaNombreID() As Int32
       Get
           Return m_VisitaNombreID
       End Get
       Set(ByVal value As Int32)
           m_VisitaNombreID = value
       End Set
   End Property

   Public Property EmpresaID() As Nullable(Of Int32)
       Get
           Return m_EmpresaID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_EmpresaID = value
       End Set
   End Property

   Public Property Nombre() As String
       Get
           Return m_Nombre
       End Get
       Set(ByVal value As String)
           m_Nombre = value
       End Set
   End Property

   Public Property DNI() As String
       Get
           Return m_DNI
       End Get
       Set(ByVal value As String)
           m_DNI = value
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

   Public Property VisitaTipoID() As Nullable(Of Int32)
       Get
           Return m_VisitaTipoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_VisitaTipoID = value
       End Set
   End Property


End Class
