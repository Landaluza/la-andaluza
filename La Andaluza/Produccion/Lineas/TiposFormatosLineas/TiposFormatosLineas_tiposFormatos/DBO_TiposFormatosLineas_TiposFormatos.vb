Public Class DBO_TiposFormatosLineas_TiposFormatos
inherits BasesParaCompatibilidad.DataBussines

    Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
    Private m_TipoFormatoLineaID As BasesParaCompatibilidad.DataBussinesParameter
    Private m_TipoFormatoID As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Velocidad As BasesParaCompatibilidad.DataBussinesParameter
    Private m_PersonalRecomendado As BasesParaCompatibilidad.DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id", "Id")
        m_TipoFormatoLineaID = New BasesParaCompatibilidad.DataBussinesParameter("@TipoFormatoLineaID", "TipoFormatoLineaID")
        m_TipoFormatoID = New BasesParaCompatibilidad.DataBussinesParameter("@TipoFormatoID", "TipoFormatoID")
        m_Velocidad = New BasesParaCompatibilidad.DataBussinesParameter("@Velocidad", "Velocidad")
        m_PersonalRecomendado = New BasesParaCompatibilidad.DataBussinesParameter("@PersonalRecomendado", "PersonalRecomendado")
        MyBase.primaryKey = m_Id
        añadirParametros()
    End Sub

    
    Public Property ID() As Int32
        Get
            Return if(isdbnull(m_id.value), Nothing, m_id.value)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property TipoFormatoLineaID() As Int32
        Get
            Return if(isdbnull(m_TipoFormatoLineaID.value), Nothing, m_TipoFormatoLineaID.value)
        End Get
        Set(ByVal value As Int32)
            m_TipoFormatoLineaID.value = value
        End Set
    End Property

    Public Property TipoFormatoID() As Int32
        Get
            Return if(isdbnull(m_TipoFormatoID.value), Nothing, m_TipoFormatoID.value)
        End Get
        Set(ByVal value As Int32)
            m_TipoFormatoID.value = value
        End Set
    End Property

    Public Property Velocidad() As Int32
        Get
            Return if(isdbnull(m_Velocidad.value), Nothing, m_Velocidad.value)
        End Get
        Set(ByVal value As Int32)
            m_Velocidad.value = value
        End Set
    End Property

    Public Property PersonalRecomendado() As Int32
        Get
            Return if(IsDBNull(m_PersonalRecomendado.value), Nothing, m_PersonalRecomendado.value)
        End Get
        Set(ByVal value As Int32)
            m_PersonalRecomendado.value = value
        End Set
    End Property
    

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_TipoFormatoLineaID, m_TipoFormatoLineaID.sqlName)
        MyBase.atributos.Add(m_TipoFormatoID, m_TipoFormatoID.sqlName)
        MyBase.atributos.Add(m_Velocidad, m_Velocidad.sqlName)
        MyBase.atributos.Add(m_PersonalRecomendado, m_PersonalRecomendado.sqlName)
    End Sub
End Class
