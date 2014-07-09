Public Class DBO_TiposBotellas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CodigoQS As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Capacidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_tipoEnvase As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_medidaProducto As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@TipoBotellaID","TipoBotellaID")
       m_CodigoQS= New BasesParaCompatibilidad.DataBussinesParameter("@CodigoQS","CodigoQS")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Capacidad= New BasesParaCompatibilidad.DataBussinesParameter("@Capacidad","Capacidad")
       m_id_tipoEnvase= New BasesParaCompatibilidad.DataBussinesParameter("@id_tipoEnvase","id_tipoEnvase")
       m_id_medidaProducto= New BasesParaCompatibilidad.DataBussinesParameter("@id_medidaProducto","id_medidaProducto")
       MyBase.primaryKey = m_Id
       a�adirParametros()
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

   Public Property CodigoQS() As Int32
       Get
           if m_CodigoQS.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CodigoQS.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_CodigoQS.value = value
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

   Public Property Capacidad() As String
       Get
           if m_Capacidad.value is convert.dbnull then
             Return 0
           End if
            Return CType(m_Capacidad.value, Double).ToString
       End Get
       Set(ByVal value As String)
           m_Capacidad.value = value
       End Set
   End Property

   Public Property id_tipoEnvase() As Int32
       Get
           if m_id_tipoEnvase.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_tipoEnvase.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_tipoEnvase.value = value
       End Set
   End Property

   Public Property id_medidaProducto() As Int32
       Get
           if m_id_medidaProducto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_medidaProducto.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_medidaProducto.value = value
       End Set
   End Property

   Private Sub a�adirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Capacidad, m_Capacidad.sqlName)
       MyBase.atributos.Add(m_id_tipoEnvase, m_id_tipoEnvase.sqlName)
       MyBase.atributos.Add(m_id_medidaProducto, m_id_medidaProducto.sqlName)
   End Sub
End Class
