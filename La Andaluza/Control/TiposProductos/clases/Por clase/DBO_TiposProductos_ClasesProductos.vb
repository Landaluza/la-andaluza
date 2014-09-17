Public Class DBO_TiposProductos_ClasesProductos
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoProducto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ClaseProducto As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_TipoProducto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoProducto","Id_TipoProducto")
       m_Id_ClaseProducto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ClaseProducto","Id_ClaseProducto")
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

   Public Property Id_TipoProducto() As Integer
       Get
           if m_Id_TipoProducto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_TipoProducto.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_TipoProducto.value = value
       End Set
   End Property

   Public Property Id_ClaseProducto() As Integer
       Get
           if m_Id_ClaseProducto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_ClaseProducto.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_ClaseProducto.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_TipoProducto, m_Id_TipoProducto.sqlName)
       MyBase.atributos.Add(m_Id_ClaseProducto, m_Id_ClaseProducto.sqlName)
   End Sub
End Class
