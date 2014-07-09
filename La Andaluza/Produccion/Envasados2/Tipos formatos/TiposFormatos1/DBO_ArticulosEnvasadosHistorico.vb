Public Class DBO_ArticulosEnvasadosHistorico

    
    Private m_TipoFormatoID As Int32
    Private m_CodigoQS As Int32
    Private m_Descripcion As String
    Private m_Separadores As Int32
    Private m_CajasPalet As Int32
    Private m_Genericas As String
    Private m_Particulares As String
    Private m_TipoProductoID As Nullable(Of Int32)
    Private m_TipoCajaID As Int32
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32
    

    Public Sub New()

    End Sub

    
    Public Property TipoFormatoID() As Int32
        Get
            Return m_TipoFormatoID
        End Get
        Set(ByVal value As Int32)
            m_TipoFormatoID = value
        End Set
    End Property

    Public Property CodigoQS() As Int32
        Get
            Return m_CodigoQS
        End Get
        Set(ByVal value As Int32)
            m_CodigoQS = value
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

    Public Property Separadores() As Int32
        Get
            Return m_Separadores
        End Get
        Set(ByVal value As Int32)
            m_Separadores = value
        End Set
    End Property

    Public Property CajasPalet() As Int32
        Get
            Return m_CajasPalet
        End Get
        Set(ByVal value As Int32)
            m_CajasPalet = value
        End Set
    End Property

    Public Property Genericas() As String
        Get
            Return m_Genericas
        End Get
        Set(ByVal value As String)
            m_Genericas = value
        End Set
    End Property

    Public Property Particulares() As String
        Get
            Return m_Particulares
        End Get
        Set(ByVal value As String)
            m_Particulares = value
        End Set
    End Property

    Public Property TipoProductoID() As Nullable(Of Int32)
        Get
            Return m_TipoProductoID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_TipoProductoID = value
        End Set
    End Property

    Public Property TipoCajaID() As Int32
        Get
            Return m_TipoCajaID
        End Get
        Set(ByVal value As Int32)
            m_TipoCajaID = value
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
