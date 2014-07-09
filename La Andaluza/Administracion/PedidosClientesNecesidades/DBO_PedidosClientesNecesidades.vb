Public Class DBO_PedidosClientesNecesidades
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ClienteID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Ruta As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PedidoClienteNecesidadID","PedidoClienteNecesidadID")
       m_ClienteID= New BasesParaCompatibilidad.DataBussinesParameter("@ClienteID","ClienteID")
       m_Ruta= New BasesParaCompatibilidad.DataBussinesParameter("@Ruta","Ruta")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
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

   Public Property ClienteID() As Int32
       Get
           if m_ClienteID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_ClienteID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_ClienteID.value = value
       End Set
   End Property

   Public Property Ruta() As String
       Get
           if m_Ruta.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Ruta.value,string)
       End Get
       Set(ByVal value As String)
           m_Ruta.value = value
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
       MyBase.atributos.Add(m_ClienteID, m_ClienteID.sqlName)
       MyBase.atributos.Add(m_Ruta, m_Ruta.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
