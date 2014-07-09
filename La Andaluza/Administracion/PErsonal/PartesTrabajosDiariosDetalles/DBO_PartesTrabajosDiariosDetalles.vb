Public Class DBO_PartesTrabajosDiariosDetalles


   Private m_ParteTrabajoDiarioDetalleID As Int32
   Private m_ParteTrabajoDiarioMaestroID As Nullable(Of Int32)
   Private m_TareasID As Nullable(Of Int32)
    Private m_HoraInicio As TimeSpan
    Private m_HoraFinal As TimeSpan
   Private m_Observaciones As String
   Private m_FechaModificacion As Date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property ParteTrabajoDiarioDetalleID() As Int32
       Get
           Return m_ParteTrabajoDiarioDetalleID
       End Get
       Set(ByVal value As Int32)
           m_ParteTrabajoDiarioDetalleID = value
       End Set
   End Property

   Public Property ParteTrabajoDiarioMaestroID() As Nullable(Of Int32)
       Get
           Return m_ParteTrabajoDiarioMaestroID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ParteTrabajoDiarioMaestroID = value
       End Set
   End Property

   Public Property TareasID() As Nullable(Of Int32)
       Get
           Return m_TareasID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_TareasID = value
       End Set
   End Property

    Public Property HoraInicio() As TimeSpan
        Get
            Return m_HoraInicio
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio = value
        End Set
    End Property

    Public Property HoraFinal() As TimeSpan
        Get
            Return m_HoraFinal
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFinal = value
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
