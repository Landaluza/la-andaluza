Public Class DBO_AccionesInmediatas_ControlIncidencias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ControlIncidencias As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_AccionesInmediatas As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_empleado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_ControlIncidencias= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ControlIncidencias","Id_ControlIncidencias")
       m_Id_AccionesInmediatas= New BasesParaCompatibilidad.DataBussinesParameter("@Id_AccionesInmediatas","Id_AccionesInmediatas")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@id_empleado","id_empleado")
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

   Public Property Id_ControlIncidencias() As Int32
       Get
           Return if(isdbnull(m_Id_ControlIncidencias.value), Nothing, m_Id_ControlIncidencias.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_ControlIncidencias.value = value
       End Set
   End Property

   Public Property Id_AccionesInmediatas() As Int32
       Get
           Return if(isdbnull(m_Id_AccionesInmediatas.value), Nothing, m_Id_AccionesInmediatas.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_AccionesInmediatas.value = value
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

   Public Property id_empleado() As Int32
       Get
           Return if(isdbnull(m_id_empleado.value), Nothing, m_id_empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_id_empleado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_ControlIncidencias, m_Id_ControlIncidencias.sqlName)
       MyBase.atributos.Add(m_Id_AccionesInmediatas, m_Id_AccionesInmediatas.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_id_empleado, m_id_empleado.sqlName)
   End Sub
End Class
