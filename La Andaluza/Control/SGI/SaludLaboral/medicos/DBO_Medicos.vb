Public Class DBO_Medicos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_apellido As BasesParaCompatibilidad.DataBussinesParameter
   Private m_apellido2 As BasesParaCompatibilidad.DataBussinesParameter
   Private m_observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_nombre= New BasesParaCompatibilidad.DataBussinesParameter("@nombre","nombre")
       m_apellido= New BasesParaCompatibilidad.DataBussinesParameter("@apellido","apellido")
       m_apellido2= New BasesParaCompatibilidad.DataBussinesParameter("@apellido2","apellido2")
       m_observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@observaciones","observaciones")
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

   Public Property nombre() As String
       Get
           Return if(isdbnull(m_nombre.value), String.empty, m_nombre.value)
       End Get
       Set(ByVal value As String)
           m_nombre.value = value
       End Set
   End Property

   Public Property apellido() As String
       Get
           Return if(isdbnull(m_apellido.value), String.empty, m_apellido.value)
       End Get
       Set(ByVal value As String)
           m_apellido.value = value
       End Set
   End Property

   Public Property apellido2() As String
       Get
           Return if(isdbnull(m_apellido2.value), String.empty, m_apellido2.value)
       End Get
       Set(ByVal value As String)
           m_apellido2.value = value
       End Set
   End Property

   Public Property observaciones() As String
       Get
           Return if(isdbnull(m_observaciones.value), String.empty, m_observaciones.value)
       End Get
       Set(ByVal value As String)
           m_observaciones.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_nombre, m_nombre.sqlName)
       MyBase.atributos.Add(m_apellido, m_apellido.sqlName)
       MyBase.atributos.Add(m_apellido2, m_apellido2.sqlName)
       MyBase.atributos.Add(m_observaciones, m_observaciones.sqlName)
   End Sub
End Class
