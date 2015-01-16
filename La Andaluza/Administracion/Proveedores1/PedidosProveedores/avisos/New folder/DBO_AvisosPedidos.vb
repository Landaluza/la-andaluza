Public Class DBO_AvisosPedidos
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_proveedor As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_articulo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Leido As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Cabecera As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Detalle As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_proveedor= New BasesParaCompatibilidad.DataBussinesParameter("@Id_proveedor","Id_proveedor")
       m_Id_articulo= New BasesParaCompatibilidad.DataBussinesParameter("@Id_articulo","Id_articulo")
       m_Leido= New BasesParaCompatibilidad.DataBussinesParameter("@Leido","Leido")
       m_Cabecera= New BasesParaCompatibilidad.DataBussinesParameter("@Cabecera","Cabecera")
       m_Detalle= New BasesParaCompatibilidad.DataBussinesParameter("@Detalle","Detalle")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
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

   Public Property Id_proveedor() As Integer
       Get
           if m_Id_proveedor.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_proveedor.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_proveedor.value = value
       End Set
   End Property

   Public Property Id_articulo() As Integer
       Get
           if m_Id_articulo.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_articulo.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_articulo.value = value
       End Set
   End Property

   Public Property Leido() As Boolean
       Get
           if m_Leido.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Leido.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Leido.value = value
       End Set
   End Property

   Public Property Cabecera() As String
       Get
           if m_Cabecera.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Cabecera.value,string)
       End Get
       Set(ByVal value As String)
           m_Cabecera.value = value
       End Set
   End Property

   Public Property Detalle() As String
       Get
           if m_Detalle.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Detalle.value,string)
       End Get
       Set(ByVal value As String)
           m_Detalle.value = value
       End Set
   End Property

   Public Property Fecha() As DateTime
       Get
           if m_Fecha.value is convert.dbnull then
             Return nothing 
           End if
           Return m_Fecha.value
       End Get
       Set(ByVal value As DateTime)
           m_Fecha.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_proveedor, m_Id_proveedor.sqlName)
       MyBase.atributos.Add(m_Id_articulo, m_Id_articulo.sqlName)
       MyBase.atributos.Add(m_Leido, m_Leido.sqlName)
       MyBase.atributos.Add(m_Cabecera, m_Cabecera.sqlName)
       MyBase.atributos.Add(m_Detalle, m_Detalle.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
   End Sub
End Class
