Public Class DBO_ProtocolosMedicosPuestosTrabajos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PuestoTrabajoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProtocoloMedicoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProgramaActividadPreventivaID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ProtocoloMedicoPuestoTrabajoID","ProtocoloMedicoPuestoTrabajoID")
       m_PuestoTrabajoID= New BasesParaCompatibilidad.DataBussinesParameter("@PuestoTrabajoID","PuestoTrabajoID")
       m_ProtocoloMedicoID= New BasesParaCompatibilidad.DataBussinesParameter("@ProtocoloMedicoID","ProtocoloMedicoID")
       m_ProgramaActividadPreventivaID= New BasesParaCompatibilidad.DataBussinesParameter("@ProgramaActividadPreventivaID","ProgramaActividadPreventivaID")
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

   Public Property PuestoTrabajoID() As Int32
       Get
           Return if(isdbnull(m_PuestoTrabajoID.value), Nothing, m_PuestoTrabajoID.value)
       End Get
       Set(ByVal value As Int32)
           m_PuestoTrabajoID.value = value
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

   Public Property ProgramaActividadPreventivaID() As Int32
       Get
           Return if(isdbnull(m_ProgramaActividadPreventivaID.value), Nothing, m_ProgramaActividadPreventivaID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProgramaActividadPreventivaID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_PuestoTrabajoID, m_PuestoTrabajoID.sqlName)
       MyBase.atributos.Add(m_ProtocoloMedicoID, m_ProtocoloMedicoID.sqlName)
       MyBase.atributos.Add(m_ProgramaActividadPreventivaID, m_ProgramaActividadPreventivaID.sqlName)
   End Sub
End Class
