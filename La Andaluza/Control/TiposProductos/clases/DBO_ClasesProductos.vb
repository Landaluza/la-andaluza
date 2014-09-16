Public Class DBO_ClasesProductos
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
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

   Public Property Nombre() As String
       Get
           if m_Nombre.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Nombre.value,string)
       End Get
       Set(ByVal value As String)
           m_Nombre.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           if m_Observaciones.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Observaciones.value,string)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
