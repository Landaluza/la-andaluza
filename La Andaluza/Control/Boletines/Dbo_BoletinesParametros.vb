Public Class Dbo_BoletinesParametros

    
    Private m_IdBoletin As Int32
    Private m_IdParametro As Int32
    Private m_FechaModificacion As Nullable(Of Date)
    Private m_UsuarioModificacion As Nullable(Of Int32)
    

    Public Sub New()
    End Sub

    
    Public Property IdBoletin() As Int32
        Get
            Return m_IdBoletin
        End Get
        Set(ByVal value As Int32)
            m_IdBoletin = value
        End Set
    End Property

    Public Property IdParametro() As Nullable(Of Int32)
        Get
            Return m_IdParametro
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_IdParametro = value
        End Set
    End Property

    Public Property FechaModificacion() As Nullable(Of Date)
        Get
            Return m_FechaModificacion
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaModificacion = value
        End Set
    End Property

    Public Property UsuarioModificacion() As Nullable(Of Int32)
        Get
            Return m_UsuarioModificacion
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_UsuarioModificacion = value
        End Set
    End Property

    
End Class

