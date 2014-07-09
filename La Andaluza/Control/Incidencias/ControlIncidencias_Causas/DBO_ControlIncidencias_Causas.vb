Public Class DBO_ControlIncidencias_Causas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_causa As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_control_incidencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_causa= New BasesParaCompatibilidad.DataBussinesParameter("@Id_causa","Id_causa")
       m_Id_control_incidencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_control_incidencia","Id_control_incidencia")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
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

   Public Property Id_causa() As Int32
       Get
           Return if(isdbnull(m_Id_causa.value), Nothing, m_Id_causa.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_causa.value = value
       End Set
   End Property

   Public Property Id_control_incidencia() As Int32
       Get
           Return if(isdbnull(m_Id_control_incidencia.value), Nothing, m_Id_control_incidencia.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_control_incidencia.value = value
       End Set
   End Property

   Public Property Id_empleado() As Int32
       Get
           Return if(isdbnull(m_Id_empleado.value), Nothing, m_Id_empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_empleado.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
            Return If(IsDBNull(m_Observaciones.value), String.Empty, Convert.ToString(m_Observaciones.value))
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
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



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_causa, m_Id_causa.sqlName)
       MyBase.atributos.Add(m_Id_control_incidencia, m_Id_control_incidencia.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
   End Sub
End Class
