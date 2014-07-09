Public Class DBO_ListaParametros
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_UnidadMedidaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_parametroTipo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_usoEnvasado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ParametroID","ParametroID")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_UnidadMedidaID= New BasesParaCompatibilidad.DataBussinesParameter("@UnidadMedidaID","UnidadMedidaID")
       m_id_parametroTipo= New BasesParaCompatibilidad.DataBussinesParameter("@id_parametroTipo","id_parametroTipo")
       m_usoEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@usoEnvasado","usoEnvasado")
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

   Public Property Nombre() As String
       Get
           Return if(isdbnull(m_Nombre.value), String.empty, m_Nombre.value)
       End Get
       Set(ByVal value As String)
           m_Nombre.value = value
       End Set
   End Property

   Public Property UnidadMedidaID() As Int32
       Get
           Return if(isdbnull(m_UnidadMedidaID.value), Nothing, m_UnidadMedidaID.value)
       End Get
       Set(ByVal value As Int32)
           m_UnidadMedidaID.value = value
       End Set
   End Property

   Public Property id_parametroTipo() As Int32
       Get
           Return if(isdbnull(m_id_parametroTipo.value), Nothing, m_id_parametroTipo.value)
       End Get
       Set(ByVal value As Int32)
           m_id_parametroTipo.value = value
       End Set
   End Property

   Public Property usoEnvasado() As Boolean
       Get
           Return if(isdbnull(m_usoEnvasado.value), false, m_usoEnvasado.value)
       End Get
       Set(ByVal value As Boolean)
           m_usoEnvasado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
       MyBase.atributos.Add(m_UnidadMedidaID, m_UnidadMedidaID.sqlName)
       MyBase.atributos.Add(m_id_parametroTipo, m_id_parametroTipo.sqlName)
       MyBase.atributos.Add(m_usoEnvasado, m_usoEnvasado.sqlName)
   End Sub
End Class
