Public Class DBO_Paises
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Pais As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PaisID","PaisID")
       m_Pais= New BasesParaCompatibilidad.DataBussinesParameter("@Pais","Pais")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property PaisID() As Int32
       Get
            Return if(IsDBNull(m_Id.value), Nothing, m_Id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
            m_Id.value = value
       End Set
   End Property

   Public Property Pais() As String
       Get
           Return if(isdbnull(m_Pais.value), String.empty, m_Pais.value)
       End Get
       Set(ByVal value As String)
           m_Pais.value = value
       End Set
   End Property

   Public Property Nombre() As String
       Get
           Return if(isdbnull(m_Nombre.value), String.empty, m_Nombre.value)
       End Get
       Set(ByVal value As String)
           m_Nombre.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Pais, m_Pais.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
   End Sub
End Class
