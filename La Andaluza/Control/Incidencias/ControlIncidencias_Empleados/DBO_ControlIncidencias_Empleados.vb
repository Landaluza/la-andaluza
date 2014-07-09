Public Class DBO_ControlIncidencias_Empleados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_control_incidencias As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_control_incidencias= New BasesParaCompatibilidad.DataBussinesParameter("@Id_control_incidencias","Id_control_incidencias")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
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

   Public Property Id_control_incidencias() As Int32
       Get
           Return if(isdbnull(m_Id_control_incidencias.value), Nothing, m_Id_control_incidencias.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_control_incidencias.value = value
       End Set
   End Property

   Public Property Id_empleado() As Int32
       Get
           Return if(isdbnull(m_Id_empleado.value), Nothing, m_Id_empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_empleado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_control_incidencias, m_Id_control_incidencias.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
   End Sub
End Class
