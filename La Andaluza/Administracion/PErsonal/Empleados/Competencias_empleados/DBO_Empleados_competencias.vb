Public Class DBO_Empleados_competencias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_personalCompetencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_activo As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@id_empleado","id_empleado")
       m_id_personalCompetencia= New BasesParaCompatibilidad.DataBussinesParameter("@id_personalCompetencia","id_personalCompetencia")
       m_activo= New BasesParaCompatibilidad.DataBussinesParameter("@activo","activo")
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

   Public Property id_empleado() As Int32
       Get
           Return if(isdbnull(m_id_empleado.value), Nothing, m_id_empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_id_empleado.value = value
       End Set
   End Property

   Public Property id_personalCompetencia() As Int32
       Get
           Return if(isdbnull(m_id_personalCompetencia.value), Nothing, m_id_personalCompetencia.value)
       End Get
       Set(ByVal value As Int32)
           m_id_personalCompetencia.value = value
       End Set
   End Property

   Public Property activo() As Boolean
       Get
           Return if(isdbnull(m_activo.value), false, m_activo.value)
       End Get
       Set(ByVal value As Boolean)
           m_activo.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_id_empleado, m_id_empleado.sqlName)
       MyBase.atributos.Add(m_id_personalCompetencia, m_id_personalCompetencia.sqlName)
       MyBase.atributos.Add(m_activo, m_activo.sqlName)
   End Sub
End Class
