Public Class DBO_empleados_envasados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_envasado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_linea As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_envasado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_envasado","Id_envasado")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
       m_Id_linea= New BasesParaCompatibilidad.DataBussinesParameter("@Id_linea","Id_linea")
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

   Public Property Id_envasado() As Int32
       Get
           Return if(isdbnull(m_Id_envasado.value), Nothing, m_Id_envasado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_envasado.value = value
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

   Public Property Id_linea() As Int32
       Get
           Return if(isdbnull(m_Id_linea.value), Nothing, m_Id_linea.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_linea.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_envasado, m_Id_envasado.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
       MyBase.atributos.Add(m_Id_linea, m_Id_linea.sqlName)
   End Sub
End Class
