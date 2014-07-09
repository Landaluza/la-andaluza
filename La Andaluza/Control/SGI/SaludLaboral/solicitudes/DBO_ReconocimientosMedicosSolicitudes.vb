Public Class DBO_ReconocimientosMedicosSolicitudes
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaSolicitud As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ReconocimientoMedicoTipoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaDeseadaInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProveedorID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoSolicitudID","ReconocimientoMedicoSolicitudID")
       m_FechaSolicitud= New BasesParaCompatibilidad.DataBussinesParameter("@FechaSolicitud","FechaSolicitud")
       m_ReconocimientoMedicoTipoID= New BasesParaCompatibilidad.DataBussinesParameter("@ReconocimientoMedicoTipoID","ReconocimientoMedicoTipoID")
       m_FechaDeseadaInicio= New BasesParaCompatibilidad.DataBussinesParameter("@FechaDeseadaInicio","FechaDeseadaInicio")
       m_ProveedorID= New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorID","ProveedorID")
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

    Public Property FechaSolicitud() As Date
        Get
            Return If(IsDBNull(m_FechaSolicitud.value), Today.Date, m_FechaSolicitud.value)
        End Get
        Set(ByVal value As Date)
            m_FechaSolicitud.value = value
        End Set
    End Property

   Public Property ReconocimientoMedicoTipoID() As Int32
       Get
           Return if(isdbnull(m_ReconocimientoMedicoTipoID.value), Nothing, m_ReconocimientoMedicoTipoID.value)
       End Get
       Set(ByVal value As Int32)
           m_ReconocimientoMedicoTipoID.value = value
       End Set
   End Property

    Public Property FechaDeseadaInicio() As Date
        Get
            Return If(IsDBNull(m_FechaDeseadaInicio.value), Today.Date, m_FechaDeseadaInicio.value)
        End Get
        Set(ByVal value As Date)
            m_FechaDeseadaInicio.value = value
        End Set
    End Property

   Public Property ProveedorID() As Int32
       Get
           Return if(isdbnull(m_ProveedorID.value), Nothing, m_ProveedorID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_FechaSolicitud, m_FechaSolicitud.sqlName)
       MyBase.atributos.Add(m_ReconocimientoMedicoTipoID, m_ReconocimientoMedicoTipoID.sqlName)
       MyBase.atributos.Add(m_FechaDeseadaInicio, m_FechaDeseadaInicio.sqlName)
       MyBase.atributos.Add(m_ProveedorID, m_ProveedorID.sqlName)
   End Sub
End Class
