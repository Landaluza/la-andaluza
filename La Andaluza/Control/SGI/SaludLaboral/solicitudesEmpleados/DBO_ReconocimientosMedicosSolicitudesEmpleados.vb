Public Class DBO_ReconocimientosMedicosSolicitudesEmpleados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ReconocimientoMedicoSolicitudID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EmpleadoID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoSolicitudEmpleadoID","ReconocimientoMedicoSolicitudEmpleadoID")
       m_ReconocimientoMedicoSolicitudID= New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoSolicitudID","ReconocimientoMedicoSolicitudID")
       m_EmpleadoID= New BasesParaCompatibilidad.DataBussinesParameter("@EmpleadoID","EmpleadoID")
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

   Public Property ReconocimientoMedicoSolicitudID() As Int32
       Get
           Return if(isdbnull(m_ReconocimientoMedicoSolicitudID.value), Nothing, m_ReconocimientoMedicoSolicitudID.value)
       End Get
       Set(ByVal value As Int32)
           m_ReconocimientoMedicoSolicitudID.value = value
       End Set
   End Property

   Public Property EmpleadoID() As Int32
       Get
           Return if(isdbnull(m_EmpleadoID.value), Nothing, m_EmpleadoID.value)
       End Get
       Set(ByVal value As Int32)
           m_EmpleadoID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ReconocimientoMedicoSolicitudID, m_ReconocimientoMedicoSolicitudID.sqlName)
       MyBase.atributos.Add(m_EmpleadoID, m_EmpleadoID.sqlName)
   End Sub
End Class
