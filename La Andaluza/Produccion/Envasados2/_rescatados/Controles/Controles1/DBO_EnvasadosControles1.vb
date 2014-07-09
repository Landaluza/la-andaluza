Public Class DBO_EnvasadosControles1

    
    Private m_EnvasadoControl1ID As Int32
    Private m_EnvasadoControlID As Nullable(Of Int32)
    Private m_Roscador1 As Boolean
    Private m_Roscador2 As Boolean
    Private m_Roscador3 As Boolean
    Private m_Roscador4 As Boolean
    Private m_NivelDeLlenado As Boolean
    Private m_Cara As Boolean
    Private m_Contra As Boolean
    Private m_Capsula As Boolean
    Private m_Retrocapsula As Boolean
    Private m_Caja As Boolean
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32
    

    Public Sub New()

    End Sub

    
    Public Property EnvasadoControl1ID() As Int32
        Get
            Return m_EnvasadoControl1ID
        End Get
        Set(ByVal value As Int32)
            m_EnvasadoControl1ID = value
        End Set
    End Property

    Public Property EnvasadoControlID() As Nullable(Of Int32)
        Get
            Return m_EnvasadoControlID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_EnvasadoControlID = value
        End Set
    End Property

    Public Property Roscador1() As Boolean
        Get
            Return m_Roscador1
        End Get
        Set(ByVal value As Boolean)
            m_Roscador1 = value
        End Set
    End Property

    Public Property Roscador2() As Boolean
        Get
            Return m_Roscador2
        End Get
        Set(ByVal value As Boolean)
            m_Roscador2 = value
        End Set
    End Property

    Public Property Roscador3() As Boolean
        Get
            Return m_Roscador3
        End Get
        Set(ByVal value As Boolean)
            m_Roscador3 = value
        End Set
    End Property

    Public Property Roscador4() As Boolean
        Get
            Return m_Roscador4
        End Get
        Set(ByVal value As Boolean)
            m_Roscador4 = value
        End Set
    End Property

    Public Property NivelDeLlenado() As Boolean
        Get
            Return m_NivelDeLlenado
        End Get
        Set(ByVal value As Boolean)
            m_NivelDeLlenado = value
        End Set
    End Property

    Public Property Cara() As Boolean
        Get
            Return m_Cara
        End Get
        Set(ByVal value As Boolean)
            m_Cara = value
        End Set
    End Property

    Public Property Contra() As Boolean
        Get
            Return m_Contra
        End Get
        Set(ByVal value As Boolean)
            m_Contra = value
        End Set
    End Property

    Public Property Capsula() As Boolean
        Get
            Return m_Capsula
        End Get
        Set(ByVal value As Boolean)
            m_Capsula = value
        End Set
    End Property

    Public Property Retrocapsula() As Boolean
        Get
            Return m_Retrocapsula
        End Get
        Set(ByVal value As Boolean)
            m_Retrocapsula = value
        End Set
    End Property

    Public Property Caja() As Boolean
        Get
            Return m_Caja
        End Get
        Set(ByVal value As Boolean)
            m_Caja = value
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
