Public Class DBO_ArticulosIngredientes

   Private m_IngredienteID As Int32
   Private m_ArticuloID As Nullable(Of Int32)
   Private m_IngredienteTipoID As Nullable(Of Int32)
   Private m_Descripcion As String
   Private m_CertificadoOGM As String
   Private m_Observaciones As String
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32
    Private m_tipoProductoid As Integer
    Private m_densidad As Double
    Private m_unidadID As Int32


    Public Sub New()

    End Sub

    Public Property IngredienteID() As Int32
        Get
            Return m_IngredienteID
        End Get
        Set(ByVal value As Int32)
            m_IngredienteID = value
        End Set
    End Property

    Public Property Densidad As Double
        Get
            Return m_densidad
        End Get
        Set(value As Double)
            m_densidad = value
        End Set
    End Property

    Public Property UnidadID() As Int32
        Get
            Return m_unidadID
        End Get
        Set(ByVal value As Int32)
            m_unidadID = value
        End Set
    End Property

    Public Property TipoProductoID() As Int32
        Get
            Return m_tipoProductoid
        End Get
        Set(ByVal value As Int32)
            m_tipoProductoid = value
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

   Public Property IngredienteTipoID() As Nullable(Of Int32)
       Get
           Return m_IngredienteTipoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_IngredienteTipoID = value
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

   Public Property CertificadoOGM() As String
       Get
           Return m_CertificadoOGM
       End Get
       Set(ByVal value As String)
           m_CertificadoOGM = value
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
