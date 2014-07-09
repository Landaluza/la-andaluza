Public Class DBO_Usuarios
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Usuario As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoUsuarioID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_email As BasesParaCompatibilidad.DataBussinesParameter
   Private m_pass As BasesParaCompatibilidad.DataBussinesParameter
   Private m_servidorDeCorreo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_cryptedPassword As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@UsuarioID","UsuarioID")
       m_Usuario= New BasesParaCompatibilidad.DataBussinesParameter("@Usuario","Usuario")
       m_TipoUsuarioID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoUsuarioID","TipoUsuarioID")
       m_email= New BasesParaCompatibilidad.DataBussinesParameter("@email","email")
       m_pass= New BasesParaCompatibilidad.DataBussinesParameter("@pass","pass")
       m_servidorDeCorreo= New BasesParaCompatibilidad.DataBussinesParameter("@servidorDeCorreo","servidorDeCorreo")
       m_cryptedPassword= New BasesParaCompatibilidad.DataBussinesParameter("@cryptedPassword","cryptedPassword")
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

   Public Property Usuario() As String
       Get
           Return if(isdbnull(m_Usuario.value), String.empty, m_Usuario.value)
       End Get
       Set(ByVal value As String)
           m_Usuario.value = value
       End Set
   End Property

   Public Property TipoUsuarioID() As Int32
       Get
           Return if(isdbnull(m_TipoUsuarioID.value), Nothing, m_TipoUsuarioID.value)
       End Get
       Set(ByVal value As Int32)
           m_TipoUsuarioID.value = value
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

   Public Property pass() As String
       Get
           Return if(isdbnull(m_pass.value), String.empty, m_pass.value)
       End Get
       Set(ByVal value As String)
           m_pass.value = value
       End Set
   End Property

   Public Property servidorDeCorreo() As String
       Get
           Return if(isdbnull(m_servidorDeCorreo.value), String.empty, m_servidorDeCorreo.value)
       End Get
       Set(ByVal value As String)
           m_servidorDeCorreo.value = value
       End Set
   End Property

   Public Property cryptedPassword() As String
       Get
           Return if(isdbnull(m_cryptedPassword.value), String.empty, m_cryptedPassword.value)
       End Get
       Set(ByVal value As String)
           m_cryptedPassword.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Usuario, m_Usuario.sqlName)
       MyBase.atributos.Add(m_TipoUsuarioID, m_TipoUsuarioID.sqlName)
       MyBase.atributos.Add(m_email, m_email.sqlName)
       MyBase.atributos.Add(m_pass, m_pass.sqlName)
       MyBase.atributos.Add(m_servidorDeCorreo, m_servidorDeCorreo.sqlName)
       MyBase.atributos.Add(m_cryptedPassword, m_cryptedPassword.sqlName)
   End Sub
End Class
