Public Class DBO_Facturas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_numero As BasesParaCompatibilidad.DataBussinesParameter
   Private m_fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_archivo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_proveedor As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_numero= New BasesParaCompatibilidad.DataBussinesParameter("@numero","numero")
       m_fecha= New BasesParaCompatibilidad.DataBussinesParameter("@fecha","fecha")
       m_archivo= New BasesParaCompatibilidad.DataBussinesParameter("@archivo","archivo")
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

   Public Property numero() As Int32
       Get
           Return if(isdbnull(m_numero.value), Nothing, m_numero.value)
       End Get
       Set(ByVal value As Int32)
           m_numero.value = value
       End Set
   End Property

    Public Property fecha() As Date
        Get
            Return If(IsDBNull(m_fecha.value), Today.Date, m_fecha.value)
        End Get
        Set(ByVal value As Date)
            m_fecha.value = value
        End Set
    End Property

   Public Property archivo() As String
       Get
           Return if(isdbnull(m_archivo.value), String.empty, m_archivo.value)
       End Get
       Set(ByVal value As String)
           m_archivo.value = value
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
       MyBase.atributos.Add(m_numero, m_numero.sqlName)
       MyBase.atributos.Add(m_fecha, m_fecha.sqlName)
       MyBase.atributos.Add(m_archivo, m_archivo.sqlName)
       MyBase.atributos.Add(m_id_proveedor, m_id_proveedor.sqlName)
   End Sub
End Class
