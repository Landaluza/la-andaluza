Public Class DBO_marcas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CodigoQS As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Vigente As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_CodigoQS= New BasesParaCompatibilidad.DataBussinesParameter("@CodigoQS","CodigoQS")
       m_Vigente= New BasesParaCompatibilidad.DataBussinesParameter("@Vigente","Vigente")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       MyBase.primaryKey = m_Id
       aņadirParametros()
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

   Public Property CodigoQS() As String
       Get
           if m_CodigoQS.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_CodigoQS.value,string)
       End Get
       Set(ByVal value As String)
           m_CodigoQS.value = value
       End Set
   End Property

   Public Property Vigente() As Boolean
       Get
           if m_Vigente.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Vigente.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Vigente.value = value
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

   Private Sub aņadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
       MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
       MyBase.atributos.Add(m_Vigente, m_Vigente.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
