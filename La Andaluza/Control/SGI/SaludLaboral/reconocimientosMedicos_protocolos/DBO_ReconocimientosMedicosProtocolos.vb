Public Class DBO_ReconocimientosMedicosProtocolos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ReconocimientoMedicoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProtocoloMedicoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoProtocoloID","ReconocimientoMedicoProtocoloID")
       m_ReconocimientoMedicoID= New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoID","ReconocimientoMedicoID")
       m_ProtocoloMedicoID= New BasesParaCompatibilidad.DataBussinesParameter("@ProtocoloMedicoID","ProtocoloMedicoID")
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

   Public Property ReconocimientoMedicoID() As Int32
       Get
           Return if(isdbnull(m_ReconocimientoMedicoID.value), Nothing, m_ReconocimientoMedicoID.value)
       End Get
       Set(ByVal value As Int32)
           m_ReconocimientoMedicoID.value = value
       End Set
   End Property

   Public Property ProtocoloMedicoID() As Int32
       Get
           Return if(isdbnull(m_ProtocoloMedicoID.value), Nothing, m_ProtocoloMedicoID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProtocoloMedicoID.value = value
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
       MyBase.atributos.Add(m_ReconocimientoMedicoID, m_ReconocimientoMedicoID.sqlName)
       MyBase.atributos.Add(m_ProtocoloMedicoID, m_ProtocoloMedicoID.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
