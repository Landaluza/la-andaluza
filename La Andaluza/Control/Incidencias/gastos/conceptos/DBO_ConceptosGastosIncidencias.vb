Public Class DBO_ConceptosGastosIncidencias
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_tiposConceptos As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_medidaProducto As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Id_tiposConceptos= New BasesParaCompatibilidad.DataBussinesParameter("@Id_tiposConceptos","Id_tiposConceptos")
       m_Id_medidaProducto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_medidaProducto","Id_medidaProducto")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Integer
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,integer)
       End Get
       Set(ByVal value As Integer)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
           if m_Descripcion.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Descripcion.value,string)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property Id_tiposConceptos() As Integer
       Get
           if m_Id_tiposConceptos.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_tiposConceptos.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_tiposConceptos.value = value
       End Set
   End Property

   Public Property Id_medidaProducto() As Integer
       Get
           if m_Id_medidaProducto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_medidaProducto.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_medidaProducto.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Id_tiposConceptos, m_Id_tiposConceptos.sqlName)
       MyBase.atributos.Add(m_Id_medidaProducto, m_Id_medidaProducto.sqlName)
   End Sub
End Class
