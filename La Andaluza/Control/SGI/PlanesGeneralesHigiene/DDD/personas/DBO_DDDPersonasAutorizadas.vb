Public Class DBO_DDDPersonasAutorizadas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProveedorID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RutaCarnetManipulador As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PersonaAutorizadaID","PersonaAutorizadaID")
       m_ProveedorID= New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorID","ProveedorID")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       m_RutaCarnetManipulador= New BasesParaCompatibilidad.DataBussinesParameter("@RutaCarnetManipulador","RutaCarnetManipulador")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
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

   Public Property ProveedorID() As Int32
       Get
           Return if(isdbnull(m_ProveedorID.value), Nothing, m_ProveedorID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID.value = value
       End Set
   End Property

   Public Property Nombre() As String
       Get
           Return if(isdbnull(m_Nombre.value), String.empty, m_Nombre.value)
       End Get
       Set(ByVal value As String)
           m_Nombre.value = value
       End Set
   End Property

   Public Property RutaCarnetManipulador() As String
       Get
           Return if(isdbnull(m_RutaCarnetManipulador.value), String.empty, m_RutaCarnetManipulador.value)
       End Get
       Set(ByVal value As String)
           m_RutaCarnetManipulador.value = value
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



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ProveedorID, m_ProveedorID.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
       MyBase.atributos.Add(m_RutaCarnetManipulador, m_RutaCarnetManipulador.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
