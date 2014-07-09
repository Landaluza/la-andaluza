Public Class DBO_Comunicaciones
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PrimerApellido As BasesParaCompatibilidad.DataBussinesParameter
   Private m_SegundoApellido As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MovilEmpresa As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EmailEmpresa As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Extension As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_PrimerApellido= New BasesParaCompatibilidad.DataBussinesParameter("@PrimerApellido","PrimerApellido")
       m_SegundoApellido= New BasesParaCompatibilidad.DataBussinesParameter("@SegundoApellido","SegundoApellido")
       m_MovilEmpresa= New BasesParaCompatibilidad.DataBussinesParameter("@MovilEmpresa","MovilEmpresa")
       m_EmailEmpresa= New BasesParaCompatibilidad.DataBussinesParameter("@EmailEmpresa","EmailEmpresa")
       m_Extension= New BasesParaCompatibilidad.DataBussinesParameter("@Extension","Extension")
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

   Public Property PrimerApellido() As String
       Get
           if m_PrimerApellido.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_PrimerApellido.value,string)
       End Get
       Set(ByVal value As String)
           m_PrimerApellido.value = value
       End Set
   End Property

   Public Property SegundoApellido() As String
       Get
           if m_SegundoApellido.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_SegundoApellido.value,string)
       End Get
       Set(ByVal value As String)
           m_SegundoApellido.value = value
       End Set
   End Property

   Public Property MovilEmpresa() As String
       Get
           if m_MovilEmpresa.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_MovilEmpresa.value,string)
       End Get
       Set(ByVal value As String)
           m_MovilEmpresa.value = value
       End Set
   End Property

   Public Property EmailEmpresa() As String
       Get
           if m_EmailEmpresa.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_EmailEmpresa.value,string)
       End Get
       Set(ByVal value As String)
           m_EmailEmpresa.value = value
       End Set
   End Property

   Public Property Extension() As String
       Get
           if m_Extension.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Extension.value,string)
       End Get
       Set(ByVal value As String)
           m_Extension.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
       MyBase.atributos.Add(m_PrimerApellido, m_PrimerApellido.sqlName)
       MyBase.atributos.Add(m_SegundoApellido, m_SegundoApellido.sqlName)
       MyBase.atributos.Add(m_MovilEmpresa, m_MovilEmpresa.sqlName)
       MyBase.atributos.Add(m_EmailEmpresa, m_EmailEmpresa.sqlName)
       MyBase.atributos.Add(m_Extension, m_Extension.sqlName)
   End Sub
End Class
