Public Class DBO_TiposCajas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CodigoQS As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Capacidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoBotellaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_MovimentoEncajado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FabricacionPropia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_tipoEnvase As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@TipoCajaID","TipoCajaID")
       m_CodigoQS= New BasesParaCompatibilidad.DataBussinesParameter("@CodigoQS","CodigoQS")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Capacidad= New BasesParaCompatibilidad.DataBussinesParameter("@Capacidad","Capacidad")
       m_TipoBotellaID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoBotellaID","TipoBotellaID")
       m_id_MovimentoEncajado= New BasesParaCompatibilidad.DataBussinesParameter("@id_MovimentoEncajado","id_MovimentoEncajado")
       m_FabricacionPropia= New BasesParaCompatibilidad.DataBussinesParameter("@FabricacionPropia","FabricacionPropia")
       m_id_tipoEnvase= New BasesParaCompatibilidad.DataBussinesParameter("@id_tipoEnvase","id_tipoEnvase")
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

   Public Property Capacidad() As Int32
       Get
           if m_Capacidad.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Capacidad.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Capacidad.value = value
       End Set
   End Property

   Public Property TipoBotellaID() As Int32
       Get
           if m_TipoBotellaID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_TipoBotellaID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_TipoBotellaID.value = value
       End Set
   End Property

   Public Property id_MovimentoEncajado() As Int32
       Get
           if m_id_MovimentoEncajado.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_MovimentoEncajado.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_MovimentoEncajado.value = value
       End Set
   End Property

   Public Property FabricacionPropia() As Boolean
       Get
           if m_FabricacionPropia.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_FabricacionPropia.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_FabricacionPropia.value = value
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

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Capacidad, m_Capacidad.sqlName)
       MyBase.atributos.Add(m_TipoBotellaID, m_TipoBotellaID.sqlName)
       MyBase.atributos.Add(m_id_MovimentoEncajado, m_id_MovimentoEncajado.sqlName)
       MyBase.atributos.Add(m_FabricacionPropia, m_FabricacionPropia.sqlName)
       MyBase.atributos.Add(m_id_tipoEnvase, m_id_tipoEnvase.sqlName)
   End Sub
End Class
