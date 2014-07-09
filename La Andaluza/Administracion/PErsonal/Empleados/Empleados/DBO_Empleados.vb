Public Class DBO_Empleados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PrimerApellido As BasesParaCompatibilidad.DataBussinesParameter
   Private m_SegundoApellido As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaNacimiento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_DireccionDomicilio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CodigoPostal As BasesParaCompatibilidad.DataBussinesParameter
   Private m_NIF As BasesParaCompatibilidad.DataBussinesParameter
   Private m_NSS As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TelefonoFijo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TelefonoMovil As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TelefonoUrgencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PersonaContactoUrgencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Email As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ContratoVigente As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_poblacion_nacimiento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_poblacion_domicilio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_usuario As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ruta_foto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MovilEmpresa As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EmailEmpresa As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Extension As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_PrimerApellido= New BasesParaCompatibilidad.DataBussinesParameter("@PrimerApellido","PrimerApellido")
       m_SegundoApellido= New BasesParaCompatibilidad.DataBussinesParameter("@SegundoApellido","SegundoApellido")
       m_FechaNacimiento= New BasesParaCompatibilidad.DataBussinesParameter("@FechaNacimiento","FechaNacimiento")
       m_DireccionDomicilio= New BasesParaCompatibilidad.DataBussinesParameter("@DireccionDomicilio","DireccionDomicilio")
       m_CodigoPostal= New BasesParaCompatibilidad.DataBussinesParameter("@CodigoPostal","CodigoPostal")
       m_NIF= New BasesParaCompatibilidad.DataBussinesParameter("@NIF","NIF")
       m_NSS= New BasesParaCompatibilidad.DataBussinesParameter("@NSS","NSS")
       m_TelefonoFijo= New BasesParaCompatibilidad.DataBussinesParameter("@TelefonoFijo","TelefonoFijo")
       m_TelefonoMovil= New BasesParaCompatibilidad.DataBussinesParameter("@TelefonoMovil","TelefonoMovil")
       m_TelefonoUrgencia= New BasesParaCompatibilidad.DataBussinesParameter("@TelefonoUrgencia","TelefonoUrgencia")
       m_PersonaContactoUrgencia= New BasesParaCompatibilidad.DataBussinesParameter("@PersonaContactoUrgencia","PersonaContactoUrgencia")
       m_Email= New BasesParaCompatibilidad.DataBussinesParameter("@Email","Email")
       m_ContratoVigente= New BasesParaCompatibilidad.DataBussinesParameter("@ContratoVigente","ContratoVigente")
       m_id_poblacion_nacimiento= New BasesParaCompatibilidad.DataBussinesParameter("@id_poblacion_nacimiento","id_poblacion_nacimiento")
       m_id_poblacion_domicilio= New BasesParaCompatibilidad.DataBussinesParameter("@id_poblacion_domicilio","id_poblacion_domicilio")
       m_id_usuario= New BasesParaCompatibilidad.DataBussinesParameter("@id_usuario","id_usuario")
       m_ruta_foto= New BasesParaCompatibilidad.DataBussinesParameter("@ruta_foto","ruta_foto")
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

    Public Property FechaNacimiento() As Date
        Get
            If m_FechaNacimiento.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_FechaNacimiento.value, Date)
        End Get
        Set(ByVal value As Date)
            m_FechaNacimiento.value = value
        End Set
    End Property

   Public Property DireccionDomicilio() As String
       Get
           if m_DireccionDomicilio.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_DireccionDomicilio.value,string)
       End Get
       Set(ByVal value As String)
           m_DireccionDomicilio.value = value
       End Set
   End Property

   Public Property CodigoPostal() As String
       Get
           if m_CodigoPostal.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_CodigoPostal.value,string)
       End Get
       Set(ByVal value As String)
           m_CodigoPostal.value = value
       End Set
   End Property

   Public Property NIF() As String
       Get
           if m_NIF.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_NIF.value,string)
       End Get
       Set(ByVal value As String)
           m_NIF.value = value
       End Set
   End Property

   Public Property NSS() As String
       Get
           if m_NSS.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_NSS.value,string)
       End Get
       Set(ByVal value As String)
           m_NSS.value = value
       End Set
   End Property

   Public Property TelefonoFijo() As String
       Get
           if m_TelefonoFijo.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_TelefonoFijo.value,string)
       End Get
       Set(ByVal value As String)
           m_TelefonoFijo.value = value
       End Set
   End Property

   Public Property TelefonoMovil() As String
       Get
           if m_TelefonoMovil.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_TelefonoMovil.value,string)
       End Get
       Set(ByVal value As String)
           m_TelefonoMovil.value = value
       End Set
   End Property

   Public Property TelefonoUrgencia() As String
       Get
           if m_TelefonoUrgencia.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_TelefonoUrgencia.value,string)
       End Get
       Set(ByVal value As String)
           m_TelefonoUrgencia.value = value
       End Set
   End Property

   Public Property PersonaContactoUrgencia() As String
       Get
           if m_PersonaContactoUrgencia.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_PersonaContactoUrgencia.value,string)
       End Get
       Set(ByVal value As String)
           m_PersonaContactoUrgencia.value = value
       End Set
   End Property

   Public Property Email() As String
       Get
           if m_Email.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Email.value,string)
       End Get
       Set(ByVal value As String)
           m_Email.value = value
       End Set
   End Property

   Public Property ContratoVigente() As Boolean
       Get
           if m_ContratoVigente.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_ContratoVigente.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_ContratoVigente.value = value
       End Set
   End Property

   Public Property id_poblacion_nacimiento() As Int32
       Get
           if m_id_poblacion_nacimiento.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_poblacion_nacimiento.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_poblacion_nacimiento.value = value
       End Set
   End Property

   Public Property id_poblacion_domicilio() As Int32
       Get
           if m_id_poblacion_domicilio.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_poblacion_domicilio.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_poblacion_domicilio.value = value
       End Set
   End Property

   Public Property id_usuario() As Int32
       Get
           if m_id_usuario.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_usuario.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_usuario.value = value
       End Set
   End Property

   Public Property ruta_foto() As String
       Get
           if m_ruta_foto.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_ruta_foto.value,string)
       End Get
       Set(ByVal value As String)
           m_ruta_foto.value = value
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
       MyBase.atributos.Add(m_FechaNacimiento, m_FechaNacimiento.sqlName)
       MyBase.atributos.Add(m_DireccionDomicilio, m_DireccionDomicilio.sqlName)
       MyBase.atributos.Add(m_CodigoPostal, m_CodigoPostal.sqlName)
       MyBase.atributos.Add(m_NIF, m_NIF.sqlName)
       MyBase.atributos.Add(m_NSS, m_NSS.sqlName)
       MyBase.atributos.Add(m_TelefonoFijo, m_TelefonoFijo.sqlName)
       MyBase.atributos.Add(m_TelefonoMovil, m_TelefonoMovil.sqlName)
       MyBase.atributos.Add(m_TelefonoUrgencia, m_TelefonoUrgencia.sqlName)
       MyBase.atributos.Add(m_PersonaContactoUrgencia, m_PersonaContactoUrgencia.sqlName)
       MyBase.atributos.Add(m_Email, m_Email.sqlName)
       MyBase.atributos.Add(m_ContratoVigente, m_ContratoVigente.sqlName)
       MyBase.atributos.Add(m_id_poblacion_nacimiento, m_id_poblacion_nacimiento.sqlName)
       MyBase.atributos.Add(m_id_poblacion_domicilio, m_id_poblacion_domicilio.sqlName)
       MyBase.atributos.Add(m_id_usuario, m_id_usuario.sqlName)
       MyBase.atributos.Add(m_ruta_foto, m_ruta_foto.sqlName)
       MyBase.atributos.Add(m_MovilEmpresa, m_MovilEmpresa.sqlName)
       MyBase.atributos.Add(m_EmailEmpresa, m_EmailEmpresa.sqlName)
       MyBase.atributos.Add(m_Extension, m_Extension.sqlName)
   End Sub
End Class
