Public Class DBO_Articulos_ArticulosCertificadosTipos

   Private m_Articulo_ArticuloCertificadoTipoID As Int32
   Private m_ArticuloID As Nullable(Of Int32)
   Private m_ArticuloCertificadoTipoID As Nullable(Of Int32)
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property Articulo_ArticuloCertificadoTipoID() As Int32
       Get
           Return m_Articulo_ArticuloCertificadoTipoID
       End Get
       Set(ByVal value As Int32)
           m_Articulo_ArticuloCertificadoTipoID = value
       End Set
   End Property

   Public Property ArticuloID() As Nullable(Of Int32)
       Get
           Return m_ArticuloID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ArticuloID = value
       End Set
   End Property

   Public Property ArticuloCertificadoTipoID() As Nullable(Of Int32)
       Get
           Return m_ArticuloCertificadoTipoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ArticuloCertificadoTipoID = value
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
