Public Class DBO_ClasesIncidencias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_procesoCalidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_categoriaIncidencia As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ClaseIncidenciaID","ClaseIncidenciaID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_id_procesoCalidad= New BasesParaCompatibilidad.DataBussinesParameter("@id_procesoCalidad","id_procesoCalidad")
       m_id_categoriaIncidencia= New BasesParaCompatibilidad.DataBussinesParameter("@id_categoriaIncidencia","id_categoriaIncidencia")
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

   Public Property id_procesoCalidad() As Int32
       Get
           Return if(isdbnull(m_id_procesoCalidad.value), Nothing, m_id_procesoCalidad.value)
       End Get
       Set(ByVal value As Int32)
           m_id_procesoCalidad.value = value
       End Set
   End Property

   Public Property id_categoriaIncidencia() As Int32
       Get
           Return if(isdbnull(m_id_categoriaIncidencia.value), Nothing, m_id_categoriaIncidencia.value)
       End Get
       Set(ByVal value As Int32)
           m_id_categoriaIncidencia.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_id_procesoCalidad, m_id_procesoCalidad.sqlName)
       MyBase.atributos.Add(m_id_categoriaIncidencia, m_id_categoriaIncidencia.sqlName)
   End Sub
End Class
