Public Class DBO_Noticias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Titulo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Texto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Titulo= New BasesParaCompatibilidad.DataBussinesParameter("@Titulo","Titulo")
       m_Texto= New BasesParaCompatibilidad.DataBussinesParameter("@Texto","Texto")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return if(Convert.IsDBNull(m_id.value), Nothing, m_id.value)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return if(Convert.IsDBNull(m_Titulo.value), String.empty, m_Titulo.value)
        End Get
        Set(ByVal value As String)
            m_Titulo.value = value
        End Set
    End Property

    Public Property Texto() As String
        Get
            Return if(Convert.IsDBNull(m_Texto.value), String.empty, m_Texto.value)
        End Get
        Set(ByVal value As String)
            m_Texto.value = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return If(Convert.IsDBNull(m_Fecha.value), DateTime.Now.Date, m_Fecha.value)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Titulo, m_Titulo.sqlName)
       MyBase.atributos.Add(m_Texto, m_Texto.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
   End Sub
End Class
