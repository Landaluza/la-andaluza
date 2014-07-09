Public Class DBO_LineasEnvasado
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_VelocidadMaxima As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@LineaEnvasadoID","LineaEnvasadoID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_VelocidadMaxima= New BasesParaCompatibilidad.DataBussinesParameter("@VelocidadMaxima","VelocidadMaxima")
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

   Public Property Descripcion() As String
       Get
           Return if(isdbnull(m_Descripcion.value), String.empty, m_Descripcion.value)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property VelocidadMaxima() As Int32
       Get
           Return if(isdbnull(m_VelocidadMaxima.value), Nothing, m_VelocidadMaxima.value)
       End Get
       Set(ByVal value As Int32)
           m_VelocidadMaxima.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_VelocidadMaxima, m_VelocidadMaxima.sqlName)
   End Sub
End Class
