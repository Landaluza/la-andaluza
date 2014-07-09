Public Class DBO_ArticulosDocumentos

   Private m_ArticuloDocumentoID As Int32
    Private m_ArticuloID As Integer
   Private m_Descripcion As String
    Private m_Fecha As Date
   Private m_Fuente As String
   Private m_Ruta As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property ArticuloDocumentoID() As Int32
       Get
           Return m_ArticuloDocumentoID
       End Get
       Set(ByVal value As Int32)
           m_ArticuloDocumentoID = value
       End Set
   End Property

    Public Property ArticuloID() As Integer
        Get
            Return m_ArticuloID
        End Get
        Set(ByVal value As Integer)
            m_ArticuloID = value
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

    Public Property Fecha() As Date
        Get
            Return m_Fecha
        End Get
        Set(ByVal value As Date)
            m_Fecha = value
        End Set
    End Property

   Public Property Fuente() As String
       Get
           Return m_Fuente
       End Get
       Set(ByVal value As String)
           m_Fuente = value
       End Set
   End Property

   Public Property Ruta() As String
       Get
           Return m_Ruta
       End Get
       Set(ByVal value As String)
           m_Ruta = value
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
