Public Class DBO_SegumientosIncidencias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ControlIncidencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_tipoSeguimiento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Responsable As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_ControlIncidencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ControlIncidencia","Id_ControlIncidencia")
       m_Id_tipoSeguimiento= New BasesParaCompatibilidad.DataBussinesParameter("@Id_tipoSeguimiento","Id_tipoSeguimiento")
       m_Responsable= New BasesParaCompatibilidad.DataBussinesParameter("@Responsable","Responsable")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
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

   Public Property Id_ControlIncidencia() As Int32
       Get
           Return if(isdbnull(m_Id_ControlIncidencia.value), Nothing, m_Id_ControlIncidencia.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_ControlIncidencia.value = value
       End Set
   End Property

   Public Property Id_tipoSeguimiento() As Int32
       Get
           Return if(isdbnull(m_Id_tipoSeguimiento.value), Nothing, m_Id_tipoSeguimiento.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_tipoSeguimiento.value = value
       End Set
   End Property

   Public Property Responsable() As Int32
       Get
           Return if(isdbnull(m_Responsable.value), Nothing, m_Responsable.value)
       End Get
       Set(ByVal value As Int32)
           m_Responsable.value = value
       End Set
   End Property

    Public Property Fecha() As Date
        Get
            Return If(IsDBNull(m_Fecha.value), Today.Date, m_Fecha.value)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
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
       MyBase.atributos.Add(m_Id_ControlIncidencia, m_Id_ControlIncidencia.sqlName)
       MyBase.atributos.Add(m_Id_tipoSeguimiento, m_Id_tipoSeguimiento.sqlName)
       MyBase.atributos.Add(m_Responsable, m_Responsable.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
