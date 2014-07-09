Public Class DBO_ParametroEspecificacionLegal
    inherits BasesParaCompatibilidad.DataBussines

    Private m_IdLegislacion As BasesParaCompatibilidad.DataBussinesParameter
    Private m_IdParametro As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Maximo As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Minimo As BasesParaCompatibilidad.DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_IdParametro = New BasesParaCompatibilidad.DataBussinesParameter("@Id_parametro", "Id_parametro")
        m_IdLegislacion = New BasesParaCompatibilidad.DataBussinesParameter("@Id_legislacion", "Id_legislacion")


        m_Minimo = Nothing
        m_Maximo = Nothing
        añadirParametros()
    End Sub

    Public Property IdParametro() As Int32
        Get
            Return if(Convert.IsDBNull(m_IdParametro.value), Nothing, m_IdParametro.value)
        End Get
        Set(ByVal value As Int32)
            m_IdParametro.value = value
        End Set
    End Property

    Public Property IdLegislacion() As Int32
        Get
            Return if(Convert.IsDBNull(m_IdLegislacion.value), Nothing, m_IdLegislacion.value)
        End Get
        Set(ByVal value As Int32)

            m_IdLegislacion.value = value
        End Set
    End Property

    Public Property Minimo() As Nullable(Of Double)
        Get
            Return m_Minimo.value
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Minimo = New BasesParaCompatibilidad.DataBussinesParameter("@Minimo", "Minimo")
            m_Minimo.value = value
            añadirParametros()
        End Set
    End Property

    Public Property Maximo() As Nullable(Of Double)
        Get
            Return m_Maximo.value
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Maximo = New BasesParaCompatibilidad.DataBussinesParameter("@Maximo", "Maximo")
            m_Maximo.value = value
            añadirParametros()
        End Set
    End Property

    Public ReadOnly Property isMaximoNull() As Boolean
        Get
            Return Convert.IsDBNull(m_Maximo.value)
        End Get
    End Property

    Public ReadOnly Property isMinimonull() As Boolean
        Get
            Return Convert.IsDBNull(m_Minimo.value)
        End Get
    End Property

    Private Sub añadirParametros()
        MyBase.atributos.Clear()
        MyBase.atributos.Add(m_IdLegislacion, m_IdLegislacion.sqlName)
        MyBase.atributos.Add(m_IdParametro, m_IdParametro.sqlName)
        If Not m_Maximo Is Nothing Then MyBase.atributos.Add(m_Maximo, m_Maximo.sqlName)
        If Not m_Minimo Is Nothing Then MyBase.atributos.Add(m_Minimo, m_Minimo.sqlName)
    End Sub

End Class
