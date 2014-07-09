Public Class DBO_GestionesPendientes
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PersonaContactada As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MedioContacto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PendienteID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@GestionPendienteID","GestionPendienteID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_PersonaContactada= New BasesParaCompatibilidad.DataBussinesParameter("@PersonaContactada","PersonaContactada")
       m_MedioContacto= New BasesParaCompatibilidad.DataBussinesParameter("@MedioContacto","MedioContacto")
       m_PendienteID= New BasesParaCompatibilidad.DataBussinesParameter("@PendienteID","PendienteID")
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

    Public Property Fecha() As Date
        Get
            If m_Fecha.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_Fecha.value, Date)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property

   Public Property PersonaContactada() As String
       Get
           if m_PersonaContactada.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_PersonaContactada.value,string)
       End Get
       Set(ByVal value As String)
           m_PersonaContactada.value = value
       End Set
   End Property

   Public Property MedioContacto() As String
       Get
           if m_MedioContacto.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_MedioContacto.value,string)
       End Get
       Set(ByVal value As String)
           m_MedioContacto.value = value
       End Set
   End Property

   Public Property PendienteID() As Int32
       Get
           if m_PendienteID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_PendienteID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_PendienteID.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_PersonaContactada, m_PersonaContactada.sqlName)
       MyBase.atributos.Add(m_MedioContacto, m_MedioContacto.sqlName)
       MyBase.atributos.Add(m_PendienteID, m_PendienteID.sqlName)
   End Sub
End Class
