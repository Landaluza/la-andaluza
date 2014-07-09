Public Class DBO_ArticulosGraneles

   Private m_GranelID As Int32
   Private m_ArticuloID As Nullable(Of Int32)
   Private m_GranelTipoID As Nullable(Of Int32)
   Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32
    Private m_TipoProductoID As Int32
    Private m_densidad As Double
    Private m_unidadID As Int32
    Private m_cantidad_elaborar_defecto As Double

    Public Sub New()

    End Sub

    Public Property GranelID() As Int32
        Get
            Return m_GranelID
        End Get
        Set(ByVal value As Int32)
            m_GranelID = value
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

    Public Property Cantidad_elaborar_defecto As Double
        Get
            Return m_cantidad_elaborar_defecto
        End Get
        Set(value As Double)
            m_cantidad_elaborar_defecto = value
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

   Public Property GranelTipoID() As Nullable(Of Int32)
       Get
           Return m_GranelTipoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_GranelTipoID = value
       End Set
    End Property

    Public Property TipoProductoID() As Int32
        Get
            Return m_TipoProductoID
        End Get
        Set(ByVal value As Int32)
            m_TipoProductoID = value
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
