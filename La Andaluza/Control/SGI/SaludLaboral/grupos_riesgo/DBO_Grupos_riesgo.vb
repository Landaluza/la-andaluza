Public Class DBO_Grupos_riesgo
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_descripcion As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_nombre= New BasesParaCompatibilidad.DataBussinesParameter("@nombre","nombre")
       m_descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@descripcion","descripcion")
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

   Public Property descripcion() As String
       Get
           Return if(isdbnull(m_descripcion.value), String.empty, m_descripcion.value)
       End Get
       Set(ByVal value As String)
           m_descripcion.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_nombre, m_nombre.sqlName)
       MyBase.atributos.Add(m_descripcion, m_descripcion.sqlName)
   End Sub
End Class
