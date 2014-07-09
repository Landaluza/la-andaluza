Public Class ExcelToSQLClass

    Private m_CodigoQS As String
    Private m_CodigoQS_IsDBNull As Boolean
    Private m_Año As Int32
    Private m_Año_IsDBNull As Boolean
    Private m_Mes As Int32
    Private m_Mes_IsDBNull As Boolean
    Private m_Cajas As Int32
    Private m_Cajas_IsDBNull As Boolean
    Private m_Observaciones As String
    Private m_Observaciones_IsDBNull As Boolean
    Private m_Descripcion As String

    Public Sub New()

    End Sub

    Public Property CodigoQS() As String
        Get
            Return m_CodigoQS
        End Get
        Set(ByVal value As String)
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

    Public Property CodigoQS_IsDBNull() As Boolean
        Get
            Return m_CodigoQS_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_CodigoQS_IsDBNull = value
        End Set
    End Property

    Public Property Año() As Int32
        Get
            Return m_Año
        End Get
        Set(ByVal value As Int32)
            m_Año = value
        End Set
    End Property

    Public Property Año_IsDBNull() As Boolean
        Get
            Return m_Año_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Año_IsDBNull = value
        End Set
    End Property

    Public Property Mes() As Int32
        Get
            Return m_Mes
        End Get
        Set(ByVal value As Int32)
            m_Mes = value
        End Set
    End Property

    Public Property Mes_IsDBNull() As Boolean
        Get
            Return m_Mes_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Mes_IsDBNull = value
        End Set
    End Property

    Public Property Cajas() As Int32
        Get
            Return m_Cajas
        End Get
        Set(ByVal value As Int32)
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

End Class

