Public Class DBO_ParametrosTipos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_nombre As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_nombre= New BasesParaCompatibilidad.DataBussinesParameter("@nombre","nombre")
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



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_nombre, m_nombre.sqlName)
   End Sub
End Class
