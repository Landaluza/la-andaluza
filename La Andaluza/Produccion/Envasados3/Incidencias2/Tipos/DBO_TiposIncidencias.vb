Public Class DBO_TiposIncidencias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MaquinaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ClaseIncidenciaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CategoriaIncidenciaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Duracion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_IncidenciaCalidadGeneral As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@TipoIncidenciaID","TipoIncidenciaID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_MaquinaID= New BasesParaCompatibilidad.DataBussinesParameter("@MaquinaID","MaquinaID")
       m_ClaseIncidenciaID= New BasesParaCompatibilidad.DataBussinesParameter("@ClaseIncidenciaID","ClaseIncidenciaID")
       m_CategoriaIncidenciaID= New BasesParaCompatibilidad.DataBussinesParameter("@CategoriaIncidenciaID","CategoriaIncidenciaID")
       m_Duracion= New BasesParaCompatibilidad.DataBussinesParameter("@Duracion","Duracion")
       m_Id_IncidenciaCalidadGeneral= New BasesParaCompatibilidad.DataBussinesParameter("@Id_IncidenciaCalidadGeneral","Id_IncidenciaCalidadGeneral")
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

   Public Property MaquinaID() As Int32
       Get
           Return if(isdbnull(m_MaquinaID.value), Nothing, m_MaquinaID.value)
       End Get
       Set(ByVal value As Int32)
           m_MaquinaID.value = value
       End Set
   End Property

   Public Property ClaseIncidenciaID() As Int32
       Get
           Return if(isdbnull(m_ClaseIncidenciaID.value), Nothing, m_ClaseIncidenciaID.value)
       End Get
       Set(ByVal value As Int32)
           m_ClaseIncidenciaID.value = value
       End Set
   End Property

   Public Property CategoriaIncidenciaID() As Int32
       Get
           Return if(isdbnull(m_CategoriaIncidenciaID.value), Nothing, m_CategoriaIncidenciaID.value)
       End Get
       Set(ByVal value As Int32)
           m_CategoriaIncidenciaID.value = value
       End Set
   End Property

   Public Property Duracion() As Int32
       Get
           Return if(isdbnull(m_Duracion.value), Nothing, m_Duracion.value)
       End Get
       Set(ByVal value As Int32)
           m_Duracion.value = value
       End Set
   End Property

   Public Property Id_IncidenciaCalidadGeneral() As Int32
       Get
           Return if(isdbnull(m_Id_IncidenciaCalidadGeneral.value), Nothing, m_Id_IncidenciaCalidadGeneral.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_IncidenciaCalidadGeneral.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_MaquinaID, m_MaquinaID.sqlName)
       MyBase.atributos.Add(m_ClaseIncidenciaID, m_ClaseIncidenciaID.sqlName)
       MyBase.atributos.Add(m_CategoriaIncidenciaID, m_CategoriaIncidenciaID.sqlName)
       MyBase.atributos.Add(m_Duracion, m_Duracion.sqlName)
       MyBase.atributos.Add(m_Id_IncidenciaCalidadGeneral, m_Id_IncidenciaCalidadGeneral.sqlName)
   End Sub
End Class
