Public Class DBO_PartesTrabajosDiariosMaestros


   Private m_ParteTrabajoDiarioMaestroID As Int32
   Private m_EmpleadoID As Nullable(Of Int32)
    Private m_Fecha As Date
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property ParteTrabajoDiarioMaestroID() As Int32
       Get
           Return m_ParteTrabajoDiarioMaestroID
       End Get
       Set(ByVal value As Int32)
           m_ParteTrabajoDiarioMaestroID = value
       End Set
   End Property

   Public Property EmpleadoID() As Nullable(Of Int32)
       Get
           Return m_EmpleadoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_EmpleadoID = value
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
