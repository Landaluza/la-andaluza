Public Class DBO_ProveedoresMailsPedidos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Mail As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Cargo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Proveedores_ProveedorID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorMailPedidoID","ProveedorMailPedidoID")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_Mail= New BasesParaCompatibilidad.DataBussinesParameter("@Mail","Mail")
       m_Cargo= New BasesParaCompatibilidad.DataBussinesParameter("@Cargo","Cargo")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_Proveedores_ProveedorID= New BasesParaCompatibilidad.DataBussinesParameter("@Proveedores_ProveedorID","Proveedores_ProveedorID")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Int32
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,int32)
       End Get
       Set(ByVal value As Int32)
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

   Public Property Mail() As String
       Get
           if m_Mail.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Mail.value,string)
       End Get
       Set(ByVal value As String)
           m_Mail.value = value
       End Set
   End Property

   Public Property Cargo() As String
       Get
           if m_Cargo.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Cargo.value,string)
       End Get
       Set(ByVal value As String)
           m_Cargo.value = value
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

   Public Property Proveedores_ProveedorID() As Int32
       Get
           if m_Proveedores_ProveedorID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Proveedores_ProveedorID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Proveedores_ProveedorID.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
       MyBase.atributos.Add(m_Mail, m_Mail.sqlName)
       MyBase.atributos.Add(m_Cargo, m_Cargo.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_Proveedores_ProveedorID, m_Proveedores_ProveedorID.sqlName)
   End Sub
End Class
