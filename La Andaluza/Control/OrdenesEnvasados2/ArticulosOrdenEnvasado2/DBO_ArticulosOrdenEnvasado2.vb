Public Class DBO_ArticulosOrdenEnvasado2

    Private m_ArticuloOrdenEnvasadoID As Int32
    Private m_LineaID As Int32
    Private m_ArticuloEnvasadoID As Int32
    Private m_Cajas As String
    Private m_Cajas_IsDBNull As Boolean
    Private m_Observaciones As String
    Private m_Observaciones_IsDBNull As Boolean
    Private m_OrdenEnvasadoID As Int32
    Private m_OrdenEnvasadoID_IsDBNull As Boolean
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property ArticuloOrdenEnvasadoID() As Int32
        Get
            Return m_ArticuloOrdenEnvasadoID
        End Get
        Set(ByVal value As Int32)
            m_ArticuloOrdenEnvasadoID = value
        End Set
    End Property

    Public Property LineaID() As Int32
        Get
            Return m_LineaID
        End Get
        Set(ByVal value As Int32)
            m_LineaID = value
        End Set
    End Property

    Public Property ArticuloEnvasadoID() As Int32
        Get
            Return m_ArticuloEnvasadoID
        End Get
        Set(ByVal value As Int32)
            m_ArticuloEnvasadoID = value
        End Set
    End Property

    Public Property Cajas() As String
        Get
            Return m_Cajas
        End Get
        Set(ByVal value As String)
            m_Cajas = value
        End Set
    End Property

    Public Property Cajas_IsDBNull() As Boolean
        Get
            Return m_Cajas_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Cajas_IsDBNull = value
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

    Public Property Observaciones_IsDBNull() As Boolean
        Get
            Return m_Observaciones_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Observaciones_IsDBNull = value
        End Set
    End Property

    Public Property OrdenEnvasadoID() As Int32
        Get
            Return m_OrdenEnvasadoID
        End Get
        Set(ByVal value As Int32)
            m_OrdenEnvasadoID = value
        End Set
    End Property

    Public Property OrdenEnvasadoID_IsDBNull() As Boolean
        Get
            Return m_OrdenEnvasadoID_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_OrdenEnvasadoID_IsDBNull = value
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
