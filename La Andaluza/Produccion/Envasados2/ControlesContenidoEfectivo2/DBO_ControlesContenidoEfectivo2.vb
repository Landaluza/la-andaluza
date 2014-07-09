Public Class DBO_ControlesContenidoEfectivo2

    Private m_ControlContenidoEfectivoID As Int32
    Private m_EnvasadoID As Nullable(Of Int32)
    Private m_VerificadorID As Nullable(Of Int32)
    Private m_HoraInicio As TimeSpan
    Private m_HoraFinal As TimeSpan
    Private m_ContenidoNominal As Nullable(Of Int32)
    Private m_Maximo As Nullable(Of Double)
    Private m_Minimo As Nullable(Of Double)
    Private m_T1 As Nullable(Of Double)
    Private m_T2 As Nullable(Of Double)
    Private m_Media As Nullable(Of Double)
    Private m_Desviacion As Nullable(Of Double)
    Private m_Correcto As Boolean
    Private m_Observaciones As String
    Private m_Lote As String
    Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property ControlContenidoEfectivoID() As Int32
        Get
            Return m_ControlContenidoEfectivoID
        End Get
        Set(ByVal value As Int32)
            m_ControlContenidoEfectivoID = value
        End Set
    End Property

    Public Property EnvasadoID() As Nullable(Of Int32)
        Get
            Return m_EnvasadoID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_EnvasadoID = value
        End Set
    End Property

    Public Property VerificadorID() As Nullable(Of Int32)
        Get
            Return m_VerificadorID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_VerificadorID = value
        End Set
    End Property

    Public Property HoraInicio() As TimeSpan
        Get
            Return m_HoraInicio
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio = value
        End Set
    End Property

    Public Property HoraFinal() As TimeSpan
        Get
            Return m_HoraFinal
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFinal = value
        End Set
    End Property

    Public Property ContenidoNominal() As Nullable(Of Int32)
        Get
            Return m_ContenidoNominal
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_ContenidoNominal = value
        End Set
    End Property

    Public Property Maximo() As Nullable(Of Double)
        Get
            Return m_Maximo
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Maximo = value
        End Set
    End Property

    Public Property Minimo() As Nullable(Of Double)
        Get
            Return m_Minimo
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Minimo = value
        End Set
    End Property

    Public Property T1() As Nullable(Of Double)
        Get
            Return m_T1
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_T1 = value
        End Set
    End Property

    Public Property T2() As Nullable(Of Double)
        Get
            Return m_T2
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_T2 = value
        End Set
    End Property

    Public Property Media() As Nullable(Of Double)
        Get
            Return m_Media
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Media = value
        End Set
    End Property

    Public Property Desviacion() As Nullable(Of Double)
        Get
            Return m_Desviacion
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Desviacion = value
        End Set
    End Property

    Public Property Correcto() As Boolean
        Get
            Return m_Correcto
        End Get
        Set(ByVal value As Boolean)
            m_Correcto = value
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

    Public Property Lote() As String
        Get
            Return m_Lote
        End Get
        Set(ByVal value As String)
            m_Lote = value
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
