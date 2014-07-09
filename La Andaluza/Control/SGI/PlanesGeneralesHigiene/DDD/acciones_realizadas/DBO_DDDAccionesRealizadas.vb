Public Class DBO_DDDAccionesRealizadas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_DDDPlanID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaPlanificada As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaEjecutada As BasesParaCompatibilidad.DataBussinesParameter
   Private m_DDDAccionID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PersonaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProductoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RutaParteTrabajo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@DDDAccionRealizadaID","DDDAccionRealizadaID")
       m_DDDPlanID= New BasesParaCompatibilidad.DataBussinesParameter("@DDDPlanID","DDDPlanID")
       m_FechaPlanificada= New BasesParaCompatibilidad.DataBussinesParameter("@FechaPlanificada","FechaPlanificada")
       m_FechaEjecutada= New BasesParaCompatibilidad.DataBussinesParameter("@FechaEjecutada","FechaEjecutada")
       m_DDDAccionID= New BasesParaCompatibilidad.DataBussinesParameter("@DDDAccionID","DDDAccionID")
       m_PersonaID= New BasesParaCompatibilidad.DataBussinesParameter("@PersonaID","PersonaID")
       m_ProductoID= New BasesParaCompatibilidad.DataBussinesParameter("@ProductoID","ProductoID")
       m_RutaParteTrabajo= New BasesParaCompatibilidad.DataBussinesParameter("@RutaParteTrabajo","RutaParteTrabajo")
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

   Public Property DDDPlanID() As Int32
       Get
           Return if(isdbnull(m_DDDPlanID.value), Nothing, m_DDDPlanID.value)
       End Get
       Set(ByVal value As Int32)
           m_DDDPlanID.value = value
       End Set
   End Property

    Public Property FechaPlanificada() As Date
        Get
            Return If(IsDBNull(m_FechaPlanificada.value), Today.Date, m_FechaPlanificada.value)
        End Get
        Set(ByVal value As Date)
            m_FechaPlanificada.value = value
        End Set
    End Property

    Public Property FechaEjecutada() As Date
        Get
            Return If(IsDBNull(m_FechaEjecutada.value), Today.Date, m_FechaEjecutada.value)
        End Get
        Set(ByVal value As Date)
            m_FechaEjecutada.value = value
        End Set
    End Property

   Public Property DDDAccionID() As Int32
       Get
           Return if(isdbnull(m_DDDAccionID.value), Nothing, m_DDDAccionID.value)
       End Get
       Set(ByVal value As Int32)
           m_DDDAccionID.value = value
       End Set
   End Property

   Public Property PersonaID() As Int32
       Get
           Return if(isdbnull(m_PersonaID.value), Nothing, m_PersonaID.value)
       End Get
       Set(ByVal value As Int32)
           m_PersonaID.value = value
       End Set
   End Property

   Public Property ProductoID() As Int32
       Get
           Return if(isdbnull(m_ProductoID.value), Nothing, m_ProductoID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProductoID.value = value
       End Set
   End Property

   Public Property RutaParteTrabajo() As String
       Get
           Return if(isdbnull(m_RutaParteTrabajo.value), String.empty, m_RutaParteTrabajo.value)
       End Get
       Set(ByVal value As String)
           m_RutaParteTrabajo.value = value
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
       MyBase.atributos.Add(m_DDDPlanID, m_DDDPlanID.sqlName)
       MyBase.atributos.Add(m_FechaPlanificada, m_FechaPlanificada.sqlName)
       MyBase.atributos.Add(m_FechaEjecutada, m_FechaEjecutada.sqlName)
       MyBase.atributos.Add(m_DDDAccionID, m_DDDAccionID.sqlName)
       MyBase.atributos.Add(m_PersonaID, m_PersonaID.sqlName)
       MyBase.atributos.Add(m_ProductoID, m_ProductoID.sqlName)
       MyBase.atributos.Add(m_RutaParteTrabajo, m_RutaParteTrabajo.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
