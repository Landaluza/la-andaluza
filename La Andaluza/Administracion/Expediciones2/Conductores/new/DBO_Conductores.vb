Public Class DBO_Conductores
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Apellido1 As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Apellido2 As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Apodo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_DNI As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Movil As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ConductorID","ConductorID")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_Apellido1= New BasesParaCompatibilidad.DataBussinesParameter("@Apellido1","Apellido1")
       m_Apellido2= New BasesParaCompatibilidad.DataBussinesParameter("@Apellido2","Apellido2")
       m_Apodo= New BasesParaCompatibilidad.DataBussinesParameter("@Apodo","Apodo")
       m_DNI= New BasesParaCompatibilidad.DataBussinesParameter("@DNI","DNI")
       m_Movil= New BasesParaCompatibilidad.DataBussinesParameter("@Movil","Movil")
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

   Public Property Apellido1() As String
       Get
           if m_Apellido1.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Apellido1.value,string)
       End Get
       Set(ByVal value As String)
           m_Apellido1.value = value
       End Set
   End Property

   Public Property Apellido2() As String
       Get
           if m_Apellido2.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Apellido2.value,string)
       End Get
       Set(ByVal value As String)
           m_Apellido2.value = value
       End Set
   End Property

   Public Property Apodo() As String
       Get
           if m_Apodo.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Apodo.value,string)
       End Get
       Set(ByVal value As String)
           m_Apodo.value = value
       End Set
   End Property

   Public Property DNI() As String
       Get
           if m_DNI.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_DNI.value,string)
       End Get
       Set(ByVal value As String)
           m_DNI.value = value
       End Set
   End Property

   Public Property Movil() As String
       Get
           if m_Movil.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Movil.value,string)
       End Get
       Set(ByVal value As String)
           m_Movil.value = value
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
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
       MyBase.atributos.Add(m_Apellido1, m_Apellido1.sqlName)
       MyBase.atributos.Add(m_Apellido2, m_Apellido2.sqlName)
       MyBase.atributos.Add(m_Apodo, m_Apodo.sqlName)
       MyBase.atributos.Add(m_DNI, m_DNI.sqlName)
       MyBase.atributos.Add(m_Movil, m_Movil.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
