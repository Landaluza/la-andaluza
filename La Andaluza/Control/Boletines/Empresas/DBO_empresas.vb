Public Class DBO_empresas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ruta_logo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_fax As BasesParaCompatibilidad.DataBussinesParameter
   Private m_tlf As BasesParaCompatibilidad.DataBussinesParameter
   Private m_email As BasesParaCompatibilidad.DataBussinesParameter
   Private m_web As BasesParaCompatibilidad.DataBussinesParameter
   Private m_direccion As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_nombre= New BasesParaCompatibilidad.DataBussinesParameter("@nombre","nombre")
       m_ruta_logo= New BasesParaCompatibilidad.DataBussinesParameter("@ruta_logo","ruta_logo")
       m_fax= New BasesParaCompatibilidad.DataBussinesParameter("@fax","fax")
       m_tlf= New BasesParaCompatibilidad.DataBussinesParameter("@tlf","tlf")
       m_email= New BasesParaCompatibilidad.DataBussinesParameter("@email","email")
       m_web= New BasesParaCompatibilidad.DataBussinesParameter("@web","web")
       m_direccion= New BasesParaCompatibilidad.DataBussinesParameter("@direccion","direccion")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property id() As Int32
       Get
           Return if(isdbnull(m_id.value), Nothing, m_id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property nombre() As String
       Get
           Return if(isdbnull(m_nombre.value), String.empty, m_nombre.value)
       End Get
       Set(ByVal value As String)
           m_nombre.value = value
       End Set
   End Property

   Public Property ruta_logo() As String
       Get
           Return if(isdbnull(m_ruta_logo.value), String.empty, m_ruta_logo.value)
       End Get
       Set(ByVal value As String)
           m_ruta_logo.value = value
       End Set
   End Property

   Public Property fax() As String
       Get
           Return if(isdbnull(m_fax.value), String.empty, m_fax.value)
       End Get
       Set(ByVal value As String)
           m_fax.value = value
       End Set
   End Property

   Public Property tlf() As String
       Get
           Return if(isdbnull(m_tlf.value), String.empty, m_tlf.value)
       End Get
       Set(ByVal value As String)
           m_tlf.value = value
       End Set
   End Property

   Public Property email() As String
       Get
           Return if(isdbnull(m_email.value), String.empty, m_email.value)
       End Get
       Set(ByVal value As String)
           m_email.value = value
       End Set
   End Property

   Public Property web() As String
       Get
           Return if(isdbnull(m_web.value), String.empty, m_web.value)
       End Get
       Set(ByVal value As String)
           m_web.value = value
       End Set
   End Property

   Public Property direccion() As String
       Get
           Return if(isdbnull(m_direccion.value), String.empty, m_direccion.value)
       End Get
       Set(ByVal value As String)
           m_direccion.value = value
       End Set
   End Property


   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_nombre, m_nombre.sqlName)
       MyBase.atributos.Add(m_ruta_logo, m_ruta_logo.sqlName)
       MyBase.atributos.Add(m_fax, m_fax.sqlName)
       MyBase.atributos.Add(m_tlf, m_tlf.sqlName)
       MyBase.atributos.Add(m_email, m_email.sqlName)
       MyBase.atributos.Add(m_web, m_web.sqlName)
       MyBase.atributos.Add(m_direccion, m_direccion.sqlName)
   End Sub
End Class
