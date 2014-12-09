Public Class DBO_Incidencias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraFin As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoIncidenciaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FormatoEnvasadoID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@IncidenciaID","IncidenciaID")
       m_HoraInicio= New BasesParaCompatibilidad.DataBussinesParameter("@HoraInicio","HoraInicio")
       m_HoraFin= New BasesParaCompatibilidad.DataBussinesParameter("@HoraFin","HoraFin")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_TipoIncidenciaID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoIncidenciaID","TipoIncidenciaID")
       m_FormatoEnvasadoID= New BasesParaCompatibilidad.DataBussinesParameter("@FormatoEnvasadoID","FormatoEnvasadoID")
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

    Public Property HoraInicio() As timespan
        Get
            Return If(isdbnull(m_HoraInicio.value), today.date, m_HoraInicio.value)
        End Get
        Set(ByVal value As timespan)
            m_HoraInicio.value = value
        End Set
    End Property

    Public Property HoraFin() As TimeSpan
        Get
            Return If(IsDBNull(m_HoraFin.value), Today.Date, m_HoraFin.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFin.value = value
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

   Public Property TipoIncidenciaID() As Int32
       Get
           Return if(isdbnull(m_TipoIncidenciaID.value), Nothing, m_TipoIncidenciaID.value)
       End Get
       Set(ByVal value As Int32)
           m_TipoIncidenciaID.value = value
       End Set
   End Property

   Public Property FormatoEnvasadoID() As Int32
       Get
           Return if(isdbnull(m_FormatoEnvasadoID.value), Nothing, m_FormatoEnvasadoID.value)
       End Get
       Set(ByVal value As Int32)
           m_FormatoEnvasadoID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_HoraInicio, m_HoraInicio.sqlName)
       MyBase.atributos.Add(m_HoraFin, m_HoraFin.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_TipoIncidenciaID, m_TipoIncidenciaID.sqlName)
       MyBase.atributos.Add(m_FormatoEnvasadoID, m_FormatoEnvasadoID.sqlName)
   End Sub
End Class
