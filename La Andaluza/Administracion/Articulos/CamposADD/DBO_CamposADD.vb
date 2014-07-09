Public Class DBO_CamposADD

   Private m_ID As Int32
   Private m_ArticuloTipoID As Nullable(Of Int32)
   Private m_SolicitanteID As Nullable(Of Int32)
   Private m_Descripcion As String
   Private m_Utilizacion As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property ID() As Int32
       Get
           Return m_ID
       End Get
       Set(ByVal value As Int32)
           m_ID = value
       End Set
   End Property

   Public Property ArticuloTipoID() As Nullable(Of Int32)
       Get
           Return m_ArticuloTipoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ArticuloTipoID = value
       End Set
   End Property

   Public Property SolicitanteID() As Nullable(Of Int32)
       Get
           Return m_SolicitanteID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_SolicitanteID = value
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

   Public Property Utilizacion() As String
       Get
           Return m_Utilizacion
       End Get
       Set(ByVal value As String)
           m_Utilizacion = value
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
