Public Class DBO_AguaPotableConsumos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Periodo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Litros As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_factura As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ConsumoID","ConsumoID")
       m_Periodo= New BasesParaCompatibilidad.DataBussinesParameter("@Periodo","Periodo")
       m_Litros= New BasesParaCompatibilidad.DataBussinesParameter("@Litros","Litros")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_id_factura= New BasesParaCompatibilidad.DataBussinesParameter("@id_factura","id_factura")
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

   Public Property Periodo() As String
       Get
           Return if(isdbnull(m_Periodo.value), String.empty, m_Periodo.value)
       End Get
       Set(ByVal value As String)
           m_Periodo.value = value
       End Set
   End Property

   Public Property Litros() As Int32
       Get
           Return if(isdbnull(m_Litros.value), Nothing, m_Litros.value)
       End Get
       Set(ByVal value As Int32)
           m_Litros.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           Return if(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property

   Public Property id_factura() As Int32
       Get
           Return if(isdbnull(m_id_factura.value), Nothing, m_id_factura.value)
       End Get
       Set(ByVal value As Int32)
           m_id_factura.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Periodo, m_Periodo.sqlName)
       MyBase.atributos.Add(m_Litros, m_Litros.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_id_factura, m_id_factura.sqlName)
   End Sub
End Class
