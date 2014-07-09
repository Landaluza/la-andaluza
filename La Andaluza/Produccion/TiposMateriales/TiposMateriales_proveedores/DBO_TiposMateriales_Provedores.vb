Public Class DBO_TiposMateriales_Provedores
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_TiposMateriales As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_proveedor As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_id_TiposMateriales= New BasesParaCompatibilidad.DataBussinesParameter("@id_TiposMateriales","id_TiposMateriales")
       m_id_proveedor= New BasesParaCompatibilidad.DataBussinesParameter("@id_proveedor","id_proveedor")
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

   Public Property id_TiposMateriales() As Int32
       Get
           Return if(isdbnull(m_id_TiposMateriales.value), Nothing, m_id_TiposMateriales.value)
       End Get
       Set(ByVal value As Int32)
           m_id_TiposMateriales.value = value
       End Set
   End Property

   Public Property id_proveedor() As Int32
       Get
           Return if(isdbnull(m_id_proveedor.value), Nothing, m_id_proveedor.value)
       End Get
       Set(ByVal value As Int32)
           m_id_proveedor.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_id_TiposMateriales, m_id_TiposMateriales.sqlName)
       MyBase.atributos.Add(m_id_proveedor, m_id_proveedor.sqlName)
   End Sub
End Class
