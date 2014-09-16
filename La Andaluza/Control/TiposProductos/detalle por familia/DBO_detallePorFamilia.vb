Public Class DBO_detallePorFamilia
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Integer
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,integer)
       End Get
       Set(ByVal value As Integer)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
   End Sub
End Class
