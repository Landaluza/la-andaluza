Public Class DBO_Empleados_LineasEnvasado
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_Empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_LineaEnvasado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_Empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_Empleado","Id_Empleado")
       m_Id_LineaEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_LineaEnvasado","Id_LineaEnvasado")
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

   Public Property Id_Empleado() As Int32
       Get
           Return if(isdbnull(m_Id_Empleado.value), Nothing, m_Id_Empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_Empleado.value = value
       End Set
   End Property

   Public Property Id_LineaEnvasado() As Int32
       Get
           Return if(isdbnull(m_Id_LineaEnvasado.value), Nothing, m_Id_LineaEnvasado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_LineaEnvasado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_Empleado, m_Id_Empleado.sqlName)
       MyBase.atributos.Add(m_Id_LineaEnvasado, m_Id_LineaEnvasado.sqlName)
   End Sub
End Class
