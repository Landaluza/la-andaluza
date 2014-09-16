Public Class DBO_TiposProductos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Abreviatura As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Enologico As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MedidaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_palet_no_conforme As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@TipoProductoID","TipoProductoID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Abreviatura= New BasesParaCompatibilidad.DataBussinesParameter("@Abreviatura","Abreviatura")
       m_Enologico= New BasesParaCompatibilidad.DataBussinesParameter("@Enologico","Enologico")
       m_MedidaID= New BasesParaCompatibilidad.DataBussinesParameter("@MedidaID","MedidaID")
       m_id_palet_no_conforme= New BasesParaCompatibilidad.DataBussinesParameter("@id_palet_no_conforme","id_palet_no_conforme")
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

   Public Property Descripcion() As String
       Get
           Return if(isdbnull(m_Descripcion.value), String.empty, m_Descripcion.value)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property Abreviatura() As String
       Get
           Return if(isdbnull(m_Abreviatura.value), String.empty, m_Abreviatura.value)
       End Get
       Set(ByVal value As String)
           m_Abreviatura.value = value
       End Set
   End Property

   Public Property Enologico() As Boolean
       Get
           Return if(isdbnull(m_Enologico.value), false, m_Enologico.value)
       End Get
       Set(ByVal value As Boolean)
           m_Enologico.value = value
       End Set
   End Property

   Public Property MedidaID() As Int32
       Get
           Return if(isdbnull(m_MedidaID.value), Nothing, m_MedidaID.value)
       End Get
       Set(ByVal value As Int32)
           m_MedidaID.value = value
       End Set
   End Property

   Public Property id_palet_no_conforme() As Int32
       Get
           Return if(isdbnull(m_id_palet_no_conforme.value), Nothing, m_id_palet_no_conforme.value)
       End Get
       Set(ByVal value As Int32)
           m_id_palet_no_conforme.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Abreviatura, m_Abreviatura.sqlName)
       MyBase.atributos.Add(m_Enologico, m_Enologico.sqlName)
       MyBase.atributos.Add(m_MedidaID, m_MedidaID.sqlName)
       MyBase.atributos.Add(m_id_palet_no_conforme, m_id_palet_no_conforme.sqlName)
   End Sub
End Class
