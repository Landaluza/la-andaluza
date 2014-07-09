Public Class DBO_Tipos_contratos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_nombre= New BasesParaCompatibilidad.DataBussinesParameter("@nombre","nombre")
       m_observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@observaciones","observaciones")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return If(IsDBNull(m_Id.value), 0, Convert.ToInt32(m_Id.value))
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property nombre() As String
       Get
            Return If(IsDBNull(m_nombre.value), String.Empty, Convert.ToString(m_nombre.value))
       End Get
       Set(ByVal value As String)
           m_nombre.value = value
       End Set
   End Property

   Public Property observaciones() As String
       Get
            Return If(IsDBNull(m_observaciones.value), String.Empty, Convert.ToString(m_observaciones.value))
       End Get
       Set(ByVal value As String)
           m_observaciones.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_nombre, m_nombre.sqlName)
       MyBase.atributos.Add(m_observaciones, m_observaciones.sqlName)
   End Sub
End Class
