Public Class DBO_TurnosTrabajo

   Private m_TurnoTrabajoID As Int32
   Private m_Ano As DateTime
   Private m_Semana As Int32
   Private m_Observaciones As String
   Private m_RutaFichero As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property TurnoTrabajoID() As Int32
       Get
           Return m_TurnoTrabajoID
       End Get
       Set(ByVal value As Int32)
           m_TurnoTrabajoID = value
       End Set
   End Property

    Public Property Ano() As Date
        Get
            Return m_Ano
        End Get
        Set(ByVal value As Date)
            m_Ano = value
        End Set
    End Property

   Public Property Semana() As Int32
       Get
           Return m_Semana
       End Get
       Set(ByVal value As Int32)
           m_Semana = value
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

   Public Property RutaFichero() As String
       Get
           Return m_RutaFichero
       End Get
       Set(ByVal value As String)
           m_RutaFichero = value
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
