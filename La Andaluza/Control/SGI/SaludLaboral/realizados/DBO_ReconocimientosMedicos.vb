Public Class DBO_ReconocimientosMedicos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ReconocimientoMedicoSolicitudEmpleadoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaRealizado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Apto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_grupo_riesgo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_medico As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoID","ReconocimientoMedicoID")
       m_ReconocimientoMedicoSolicitudEmpleadoID= New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoSolicitudEmpleadoID","ReconocimientoMedicoSolicitudEmpleadoID")
       m_FechaRealizado= New BasesParaCompatibilidad.DataBussinesParameter("@FechaRealizado","FechaRealizado")
       m_Apto= New BasesParaCompatibilidad.DataBussinesParameter("@Apto","Apto")
       m_id_grupo_riesgo= New BasesParaCompatibilidad.DataBussinesParameter("@id_grupo_riesgo","id_grupo_riesgo")
       m_id_medico= New BasesParaCompatibilidad.DataBussinesParameter("@id_medico","id_medico")
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

   Public Property ReconocimientoMedicoSolicitudEmpleadoID() As Int32
       Get
           Return if(isdbnull(m_ReconocimientoMedicoSolicitudEmpleadoID.value), Nothing, m_ReconocimientoMedicoSolicitudEmpleadoID.value)
       End Get
       Set(ByVal value As Int32)
           m_ReconocimientoMedicoSolicitudEmpleadoID.value = value
       End Set
   End Property

    Public Property FechaRealizado() As Date
        Get
            Return If(IsDBNull(m_FechaRealizado.value), Today.Date, m_FechaRealizado.value)
        End Get
        Set(ByVal value As Date)
            m_FechaRealizado.value = value
        End Set
    End Property

   Public Property Apto() As Boolean
       Get
           Return if(isdbnull(m_Apto.value), false, m_Apto.value)
       End Get
       Set(ByVal value As Boolean)
           m_Apto.value = value
       End Set
   End Property

   Public Property id_grupo_riesgo() As Int32
       Get
           Return if(isdbnull(m_id_grupo_riesgo.value), Nothing, m_id_grupo_riesgo.value)
       End Get
       Set(ByVal value As Int32)
           m_id_grupo_riesgo.value = value
       End Set
   End Property

   Public Property id_medico() As Int32
       Get
           Return if(isdbnull(m_id_medico.value), Nothing, m_id_medico.value)
       End Get
       Set(ByVal value As Int32)
           m_id_medico.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ReconocimientoMedicoSolicitudEmpleadoID, m_ReconocimientoMedicoSolicitudEmpleadoID.sqlName)
       MyBase.atributos.Add(m_FechaRealizado, m_FechaRealizado.sqlName)
       MyBase.atributos.Add(m_Apto, m_Apto.sqlName)
       MyBase.atributos.Add(m_id_grupo_riesgo, m_id_grupo_riesgo.sqlName)
       MyBase.atributos.Add(m_id_medico, m_id_medico.sqlName)
   End Sub
End Class
