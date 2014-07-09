Public Class DBO_CargaNecesidadesJR2Detalles

    Private m_CargaNecesidadesJRDetalleID As Int32
    Private m_CargaNecesidadesJRMaestroID As Int32
    Private m_ArticuloID As Int32
    Private m_Carga As Int32
    Private m_Stock As Int32
    Private m_Observaciones As String
    Private m_Reserva1 As String
    Private m_Reserva2 As String
    Private m_Reserva3 As String
    Private m_FechaModificacion As date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property CargaNecesidadesJRDetalleID() As Int32
        Get
            Return m_CargaNecesidadesJRDetalleID
        End Get
        Set(ByVal value As Int32)
            m_CargaNecesidadesJRDetalleID = value
        End Set
    End Property

    Public Property CargaNecesidadesJRMaestroID() As Int32
        Get
            Return m_CargaNecesidadesJRMaestroID
        End Get
        Set(ByVal value As Int32)
            m_CargaNecesidadesJRMaestroID = value
        End Set
    End Property

    Public Property ArticuloID() As Int32
        Get
            Return m_ArticuloID
        End Get
        Set(ByVal value As Int32)
            m_ArticuloID = value
        End Set
    End Property


    Public Property Carga() As Int32
        Get
            Return m_Carga
        End Get
        Set(ByVal value As Int32)
            m_Carga = value
        End Set
    End Property

   

    Public Property Stock() As Int32
        Get
            Return m_Stock
        End Get
        Set(ByVal value As Int32)
            m_Stock = value
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

    Public Property Reserva1() As String
        Get
            Return m_Reserva1
        End Get
        Set(ByVal value As String)
            m_Reserva1 = value
        End Set
    End Property


    Public Property Reserva2() As String
        Get
            Return m_Reserva2
        End Get
        Set(ByVal value As String)
            m_Reserva2 = value
        End Set
    End Property

    Public Property Reserva3() As String
        Get
            Return m_Reserva3
        End Get
        Set(ByVal value As String)
            m_Reserva3 = value
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
