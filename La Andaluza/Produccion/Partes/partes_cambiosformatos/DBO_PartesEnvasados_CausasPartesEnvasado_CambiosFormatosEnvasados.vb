Public Class DBO_PartesEnvasados_CausasPartesEnvasado_CambiosFormatosEnvasados
inherits BasesParaCompatibilidad.DataBussines

    Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Id_CambioFormato As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Id_ParteEnvasado_causaParteEnvasado As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Id_Maquina As BasesParaCompatibilidad.DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id", "Id")
        m_Id_CambioFormato = New BasesParaCompatibilidad.DataBussinesParameter("@Id_CambioFormato", "Id_CambioFormatoEnvasado")
        m_Id_ParteEnvasado_causaParteEnvasado = New BasesParaCompatibilidad.DataBussinesParameter("@Id_ParteEnvasado_causaParteEnvasado", "Id_ParteEnvasado_causaParteEnvasado")
        m_Id_Maquina = New BasesParaCompatibilidad.DataBussinesParameter("@Id_Maquina", "Id_Maquina")
        MyBase.primaryKey = m_Id
        añadirParametros()
    End Sub

    Public Property ID() As Int32
        Get
            If m_id.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_id.value, int32)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property Id_CambioFormato() As Int32
        Get
            If m_Id_CambioFormato.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_Id_CambioFormato.value, int32)
        End Get
        Set(ByVal value As Int32)
            m_Id_CambioFormato.value = value
        End Set
    End Property

    Public Property Id_Maquina() As Int32
        Get
            If m_Id_Maquina.value Is Convert.DBNull Then
                Return 0
            End If
            Return CType(m_Id_Maquina.value, Int32)
        End Get
        Set(ByVal value As Int32)
            m_Id_Maquina.value = value
        End Set
    End Property

    Public Property Id_ParteEnvasado_causaParteEnvasado() As Int32
        Get
            If m_Id_ParteEnvasado_causaParteEnvasado.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_Id_ParteEnvasado_causaParteEnvasado.value, int32)
        End Get
        Set(ByVal value As Int32)
            m_Id_ParteEnvasado_causaParteEnvasado.value = value
        End Set
    End Property

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_Id_CambioFormato, m_Id_CambioFormato.sqlName)
        MyBase.atributos.Add(m_Id_ParteEnvasado_causaParteEnvasado, m_Id_ParteEnvasado_causaParteEnvasado.sqlName)
        MyBase.atributos.Add(m_Id_Maquina, m_Id_Maquina.sqlName)
    End Sub
End Class
