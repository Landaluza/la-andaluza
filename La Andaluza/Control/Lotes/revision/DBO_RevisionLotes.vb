Public Class DBO_RevisionLotes
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CantidadRestante As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MedidaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CodigoLote As BasesParaCompatibilidad.DataBussinesParameter
   Private m_DepositoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RecipienteSalidaID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@LoteID","LoteID")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_CantidadRestante= New BasesParaCompatibilidad.DataBussinesParameter("@CantidadRestante","CantidadRestante")
       m_MedidaID= New BasesParaCompatibilidad.DataBussinesParameter("@MedidaID","MedidaID")
       m_CodigoLote= New BasesParaCompatibilidad.DataBussinesParameter("@CodigoLote","CodigoLote")
       m_DepositoID= New BasesParaCompatibilidad.DataBussinesParameter("@DepositoID","DepositoID")
       m_RecipienteSalidaID= New BasesParaCompatibilidad.DataBussinesParameter("@RecipienteSalidaID","RecipienteSalidaID")
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

   Public Property Fecha() As DateTime
       Get
           if m_Fecha.value is convert.dbnull then
             Return nothing 
           End if
           Return m_Fecha.value
       End Get
       Set(ByVal value As DateTime)
           m_Fecha.value = value
       End Set
   End Property

   Public Property CantidadRestante() As String
       Get
           if m_CantidadRestante.value is convert.dbnull then
             Return nothing 
           End if
           Return m_CantidadRestante.value
       End Get
       Set(ByVal value As String)
           m_CantidadRestante.value = value
       End Set
   End Property

   Public Property MedidaID() As Integer
       Get
           if m_MedidaID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MedidaID.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_MedidaID.value = value
       End Set
   End Property

   Public Property CodigoLote() As Char
       Get
           if m_CodigoLote.value is convert.dbnull then
             Return nothing 
           End if
           Return m_CodigoLote.value
       End Get
       Set(ByVal value As Char)
           m_CodigoLote.value = value
       End Set
   End Property

   Public Property DepositoID() As Integer
       Get
           if m_DepositoID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_DepositoID.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_DepositoID.value = value
       End Set
   End Property

   Public Property RecipienteSalidaID() As Integer
       Get
           if m_RecipienteSalidaID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_RecipienteSalidaID.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_RecipienteSalidaID.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_CantidadRestante, m_CantidadRestante.sqlName)
       MyBase.atributos.Add(m_MedidaID, m_MedidaID.sqlName)
       MyBase.atributos.Add(m_CodigoLote, m_CodigoLote.sqlName)
       MyBase.atributos.Add(m_DepositoID, m_DepositoID.sqlName)
       MyBase.atributos.Add(m_RecipienteSalidaID, m_RecipienteSalidaID.sqlName)
   End Sub
End Class
