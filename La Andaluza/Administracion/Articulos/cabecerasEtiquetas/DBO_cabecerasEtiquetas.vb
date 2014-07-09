Public Class DBO_cabecerasEtiquetas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_texto As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_texto= New BasesParaCompatibilidad.DataBussinesParameter("@texto","texto")
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

   Public Property texto() As String
       Get
           if m_texto.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_texto.value,string)
       End Get
       Set(ByVal value As String)
           m_texto.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_texto, m_texto.sqlName)
   End Sub
End Class
