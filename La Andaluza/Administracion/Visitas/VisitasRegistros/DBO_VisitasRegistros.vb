Public Class DBO_VisitasRegistros


   Private m_VisitaRegistroID As Int32
   Private m_VisitaTipoID As Nullable(Of Int32)
   Private m_VisitaNombreID As Nullable(Of Int32)
   Private m_VisitaMotivoID As Nullable(Of Int32)
   Private m_EmpresaID As Nullable(Of Int32)
   Private m_PersonaResponsableVisitaID As Nullable(Of Int32)
    Private m_Fecha As Date
    Private m_HoraEntrada As TimeSpan
    Private m_HoraSalida As TimeSpan
   Private m_EmpresaNombre As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property VisitaRegistroID() As Int32
       Get
           Return m_VisitaRegistroID
       End Get
       Set(ByVal value As Int32)
           m_VisitaRegistroID = value
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

   Public Property VisitaNombreID() As Nullable(Of Int32)
       Get
           Return m_VisitaNombreID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_VisitaNombreID = value
       End Set
   End Property

   Public Property VisitaMotivoID() As Nullable(Of Int32)
       Get
           Return m_VisitaMotivoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_VisitaMotivoID = value
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

   Public Property PersonaResponsableVisitaID() As Nullable(Of Int32)
       Get
           Return m_PersonaResponsableVisitaID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_PersonaResponsableVisitaID = value
       End Set
   End Property

    Public Property Fecha() As Date
        Get
            Return m_Fecha
        End Get
        Set(ByVal value As Date)
            m_Fecha = value
        End Set
    End Property

    Public Property HoraEntrada() As TimeSpan
        Get
            Return m_HoraEntrada
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraEntrada = value
        End Set
    End Property

    Public Property HoraSalida() As TimeSpan
        Get
            Return m_HoraSalida
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraSalida = value
        End Set
    End Property

   Public Property EmpresaNombre() As String
       Get
           Return m_EmpresaNombre
       End Get
       Set(ByVal value As String)
           m_EmpresaNombre = value
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
