Public Class DBO_ArticulosUnidadesMedidas

   Private m_ArticuloUnidadMedidaID As Int32
   Private m_Descripcion As String
   Private m_Abreviatura As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property ArticuloUnidadMedidaID() As Int32
       Get
           Return m_ArticuloUnidadMedidaID
       End Get
       Set(ByVal value As Int32)
           m_ArticuloUnidadMedidaID = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
           Return m_Descripcion
       End Get
       Set(ByVal value As String)
           m_Descripcion = value
       End Set
   End Property

   Public Property Abreviatura() As String
       Get
           Return m_Abreviatura
       End Get
       Set(ByVal value As String)
           m_Abreviatura = value
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
