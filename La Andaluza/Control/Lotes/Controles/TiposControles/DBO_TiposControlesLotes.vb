Public Class DBO_TiposControlesLotes
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RutaControles As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_procedimiento As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_RutaControles= New BasesParaCompatibilidad.DataBussinesParameter("@RutaControles","RutaControles")
       m_Id_procedimiento= New BasesParaCompatibilidad.DataBussinesParameter("@Id_procedimiento","Id_procedimiento")
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

   Public Property Descripcion() As String
       Get
           if m_Descripcion.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Descripcion.value,string)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
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

   Public Property RutaControles() As String
       Get
           if m_RutaControles.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_RutaControles.value,string)
       End Get
       Set(ByVal value As String)
           m_RutaControles.value = value
       End Set
   End Property

   Public Property Id_procedimiento() As Int32
       Get
           if m_Id_procedimiento.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_procedimiento.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_procedimiento.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_RutaControles, m_RutaControles.sqlName)
       MyBase.atributos.Add(m_Id_procedimiento, m_Id_procedimiento.sqlName)
   End Sub
End Class
