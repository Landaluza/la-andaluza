Public Class DBO_ArticulosLoteados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ArticuloID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_tipoLoteado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloEnvaseTerciarioID","ArticuloEnvaseTerciarioID")
       m_ArticuloID= New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloID","ArticuloID")
       m_id_tipoLoteado= New BasesParaCompatibilidad.DataBussinesParameter("@id_tipoLoteado","id_tipoLoteado")
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

   Public Property ArticuloID() As Int32
       Get
           if m_ArticuloID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_ArticuloID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_ArticuloID.value = value
       End Set
   End Property

   Public Property id_tipoLoteado() As Int32
       Get
           if m_id_tipoLoteado.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_tipoLoteado.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_tipoLoteado.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ArticuloID, m_ArticuloID.sqlName)
       MyBase.atributos.Add(m_id_tipoLoteado, m_id_tipoLoteado.sqlName)
   End Sub
End Class
