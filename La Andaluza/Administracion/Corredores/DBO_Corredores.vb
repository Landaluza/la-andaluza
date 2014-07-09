Public Class DBO_Corredores
    inherits BasesParaCompatibilidad.DataBussines

    Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@CorredorID", "CorredorID")
        m_Nombre = New BasesParaCompatibilidad.DataBussinesParameter("@Nombre", "Nombre")
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

    Public Property Nombre() As String
        Get
            If m_Nombre.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_Nombre.value, String)
        End Get
        Set(ByVal value As String)
            m_Nombre.value = value
        End Set
    End Property

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
    End Sub
End Class
