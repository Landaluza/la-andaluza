Public Class DBO_Depositos_TiposDepositos
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_Deposito As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoDeposito As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_Deposito= New BasesParaCompatibilidad.DataBussinesParameter("@Id_Deposito","Id_Deposito")
       m_Id_TipoDeposito= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoDeposito","Id_TipoDeposito")
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

   Public Property Id_Deposito() As Integer
       Get
           if m_Id_Deposito.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_Deposito.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_Deposito.value = value
       End Set
   End Property

   Public Property Id_TipoDeposito() As Integer
       Get
           if m_Id_TipoDeposito.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_TipoDeposito.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_TipoDeposito.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_Deposito, m_Id_Deposito.sqlName)
       MyBase.atributos.Add(m_Id_TipoDeposito, m_Id_TipoDeposito.sqlName)
   End Sub
End Class
