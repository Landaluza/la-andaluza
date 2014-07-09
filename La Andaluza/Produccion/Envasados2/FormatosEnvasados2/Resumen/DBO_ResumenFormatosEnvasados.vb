Public Class DBO_ResumenFormatosEnvasados

    Private m_FormatoEnvasadoID As Integer
    Private m_MediasEnvasado_MinutosPorPalet As Integer
    Private m_MediasEnvasado_Velocidad As Integer
    Private m_MediasEnvasado_Efectividad As Integer

    Private m_TotalesIncidencias_CalidadNumero As Integer
    Private m_TotalesIncidencias_CalidadMinutos As Integer
    Private m_TotalesIncidencias_MaquinaNumero As Integer
    Private m_TotalesIncidencias_MaquinaMinutos As Integer
    Private m_TotalesIncidencias_OtrosNumero As Integer
    Private m_TotalesIncidencias_OtrosMinutos As Integer
    Private m_TotalesIncidencias_RecuperablesNumero As Integer
    Private m_TotalesIncidencias_RecuperablesMinutos As Integer
    Private m_TotalesIncidencias_IntrinsicasNumero As Integer
    Private m_TotalesIncidencias_IntrinsicasMinutos As Integer
    Private m_TotalesIncidencias_TotalMinutos As Integer

    Private m_TiemposTotales_HoraInicio As Date
    Private m_TiemposTotales_HoraFin As Date
    Private m_TiemposTotales_Asignado As Integer
    Private m_TiemposTotales_IncidenciasEvitables As Integer
    Private m_TiemposTotales_IncidenciasnoEvitables As Integer
    Private m_TiemposTotales_TotalIncidencias As Integer
    Private m_TiemposTotales_TiempoNoJustificado As Integer

    Private m_TotalesEnvasados_TotalPalets As Integer
    Private m_TotalesEnvasados_CajasSueltas As Integer
    Private m_TotalesEnvasados_Cajas As Integer
    Private m_TotalesEnvasados_Botellas As Integer
    Private m_TotalesEnvasados_Litros As Integer
    Private m_TotalesEnvasados_CajasCompletando As Integer

    Private Shared datos As DBO_ResumenFormatosEnvasados

    Public Sub New()
    End Sub


    Public Property TotalesIncidencias_CalidadNumero() As Integer
        Get
            Return m_TotalesIncidencias_CalidadNumero
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_CalidadNumero = value
        End Set
    End Property

    Public Property TotalesIncidencias_CalidadMinutos() As Integer
        Get
            Return m_TotalesIncidencias_CalidadMinutos
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_CalidadMinutos = value
        End Set
    End Property

    Public Property TotalesIncidencias_MaquinaNumero() As Integer
        Get
            Return m_TotalesIncidencias_MaquinaNumero
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_MaquinaNumero = value
        End Set
    End Property

    Public Property TotalesIncidencias_MaquinaMinutos() As Integer
        Get
            Return m_TotalesIncidencias_MaquinaMinutos
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_MaquinaMinutos = value
        End Set
    End Property

    Public Property TotalesIncidencias_OtrosNumero() As Integer
        Get
            Return m_TotalesIncidencias_OtrosNumero
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_OtrosNumero = value
        End Set
    End Property

    Public Property TotalesIncidencias_OtrosMinutos() As Integer
        Get
            Return m_TotalesIncidencias_OtrosMinutos
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_OtrosMinutos = value
        End Set
    End Property

    Public Property TotalesIncidencias_RecuperablesNumero() As Integer
        Get
            Return m_TotalesIncidencias_RecuperablesNumero
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_RecuperablesNumero = value
        End Set
    End Property

    Public Property TotalesIncidencias_RecuperablesMinutos() As Integer
        Get
            Return m_TotalesIncidencias_RecuperablesMinutos
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_RecuperablesMinutos = value
        End Set
    End Property

    Public Property TotalesIncidencias_IntrinsicasNumero() As Integer
        Get
            Return m_TotalesIncidencias_IntrinsicasNumero
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_IntrinsicasNumero = value
        End Set
    End Property

    Public Property TotalesIncidencias_IntrinsicasMinutos() As Integer
        Get
            Return m_TotalesIncidencias_IntrinsicasMinutos
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_IntrinsicasMinutos = value
        End Set
    End Property

    Public Property TotalesIncidencias_TotalMinutos() As Integer
        Get
            Return m_TotalesIncidencias_TotalMinutos
        End Get
        Set(ByVal value As Integer)
            m_TotalesIncidencias_TotalMinutos = value
        End Set
    End Property


    Public Property FormatoEnvasadoID() As Integer
        Get
            Return m_FormatoEnvasadoID
        End Get
        Set(ByVal value As Integer)
            m_FormatoEnvasadoID = value
        End Set
    End Property

    Public Property MediasEnvasado_MinutosPorPalet() As Integer
        Get
            Return m_MediasEnvasado_MinutosPorPalet
        End Get
        Set(ByVal value As Integer)
            m_MediasEnvasado_MinutosPorPalet = value
        End Set
    End Property

    Public Property MediasEnvasado_Velocidad() As Integer
        Get
            Return m_MediasEnvasado_Velocidad
        End Get
        Set(ByVal value As Integer)
            m_MediasEnvasado_Velocidad = value
        End Set
    End Property

    Public Property MediasEnvasado_Efectividad() As Integer
        Get
            Return m_MediasEnvasado_Efectividad
        End Get
        Set(ByVal value As Integer)
            m_MediasEnvasado_Efectividad = value
        End Set
    End Property


    Public Property TiemposTotales_HoraInicio() As Date
        Get
            Return m_TiemposTotales_HoraInicio
        End Get
        Set(ByVal value As Date)
            m_TiemposTotales_HoraInicio = value
        End Set
    End Property

    Public Property TiemposTotales_HoraFin() As Date
        Get
            Return m_TiemposTotales_HoraFin
        End Get
        Set(ByVal value As Date)
            m_TiemposTotales_HoraFin = value
        End Set
    End Property

    Public Property TiemposTotales_Asignado() As Integer
        Get
            Return m_TiemposTotales_Asignado
        End Get
        Set(ByVal value As Integer)
            m_TiemposTotales_Asignado = value
        End Set
    End Property

    Public Property TiemposTotales_IncidenciasEvitables() As Integer
        Get
            Return m_TiemposTotales_IncidenciasEvitables
        End Get
        Set(ByVal value As Integer)
            m_TiemposTotales_IncidenciasEvitables = value
        End Set
    End Property

    Public Property TiemposTotales_IncidenciasnoEvitables() As Integer
        Get
            Return m_TiemposTotales_IncidenciasnoEvitables
        End Get
        Set(ByVal value As Integer)
            m_TiemposTotales_IncidenciasnoEvitables = value
        End Set
    End Property

    Public Property TiemposTotales_TotalIncidencias() As Integer
        Get
            Return m_TiemposTotales_TotalIncidencias
        End Get
        Set(ByVal value As Integer)
            m_TiemposTotales_TotalIncidencias = value
        End Set
    End Property

    Public Property TiemposTotales_TiempoNoJustificado() As Integer
        Get
            Return m_TiemposTotales_TiempoNoJustificado
        End Get
        Set(ByVal value As Integer)
            m_TiemposTotales_TiempoNoJustificado = value
        End Set
    End Property


    Public Property TotalesEnvasados_TotalPalets() As Integer
        Get
            Return m_TotalesEnvasados_TotalPalets
        End Get
        Set(ByVal value As Integer)
            m_TotalesEnvasados_TotalPalets = value
        End Set
    End Property

    Public Property TotalesEnvasados_CajasSueltas() As Integer
        Get
            Return m_TotalesEnvasados_CajasSueltas
        End Get
        Set(ByVal value As Integer)
            m_TotalesEnvasados_CajasSueltas = value
        End Set
    End Property

    Public Property TotalesEnvasados_Cajas() As Integer
        Get
            Return m_TotalesEnvasados_Cajas
        End Get
        Set(ByVal value As Integer)
            m_TotalesEnvasados_Cajas = value
        End Set
    End Property

    Public Property TotalesEnvasados_Botellas() As Integer
        Get
            Return m_TotalesEnvasados_Botellas
        End Get
        Set(ByVal value As Integer)
            m_TotalesEnvasados_Botellas = value
        End Set
    End Property

    Public Property TotalesEnvasados_Litros() As Integer
        Get
            Return m_TotalesEnvasados_Litros
        End Get
        Set(ByVal value As Integer)
            m_TotalesEnvasados_Litros = value
        End Set
    End Property

    Public Property TotalesEnvasados_CajasCompletando() As Integer
        Get
            Return m_TotalesEnvasados_CajasCompletando
        End Get
        Set(ByVal value As Integer)
            m_TotalesEnvasados_CajasCompletando = value
        End Set
    End Property

End Class
