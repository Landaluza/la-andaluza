Public Class DBO_Procesos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoProductoParaLote As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoMovimiento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoLoteID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ConMuestra As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ProcesoID","ProcesoID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_TipoProductoParaLote= New BasesParaCompatibilidad.DataBussinesParameter("@TipoProductoParaLote","TipoProductoParaLote")
       m_TipoMovimiento= New BasesParaCompatibilidad.DataBussinesParameter("@TipoMovimiento","TipoMovimiento")
       m_TipoLoteID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoLoteID","TipoLoteID")
       m_ConMuestra= New BasesParaCompatibilidad.DataBussinesParameter("@ConMuestra","ConMuestra")
       MyBase.primaryKey = m_Id
       a�adirParametros()
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

   Public Property TipoProductoParaLote() As String
       Get
           if m_TipoProductoParaLote.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_TipoProductoParaLote.value,string)
       End Get
       Set(ByVal value As String)
           m_TipoProductoParaLote.value = value
       End Set
   End Property

   Public Property TipoMovimiento() As String
       Get
           if m_TipoMovimiento.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_TipoMovimiento.value,string)
       End Get
       Set(ByVal value As String)
           m_TipoMovimiento.value = value
       End Set
   End Property

   Public Property TipoLoteID() As Int32
       Get
           if m_TipoLoteID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_TipoLoteID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_TipoLoteID.value = value
       End Set
   End Property

   Public Property ConMuestra() As Boolean
       Get
           if m_ConMuestra.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_ConMuestra.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_ConMuestra.value = value
       End Set
   End Property

   Private Sub a�adirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_TipoProductoParaLote, m_TipoProductoParaLote.sqlName)
       MyBase.atributos.Add(m_TipoMovimiento, m_TipoMovimiento.sqlName)
       MyBase.atributos.Add(m_TipoLoteID, m_TipoLoteID.sqlName)
       MyBase.atributos.Add(m_ConMuestra, m_ConMuestra.sqlName)
   End Sub
End Class
