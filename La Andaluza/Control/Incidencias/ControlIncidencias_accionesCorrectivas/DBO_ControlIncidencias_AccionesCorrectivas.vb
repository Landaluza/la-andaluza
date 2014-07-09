Public Class DBO_ControlIncidencias_AccionesCorrectivas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_control_incidencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_AccionCorrectiva As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaPrevista As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Resultados As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Realizado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_control_incidencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_control_incidencia","Id_control_incidencia")
       m_Id_AccionCorrectiva= New BasesParaCompatibilidad.DataBussinesParameter("@Id_AccionCorrectiva","Id_AccionCorrectiva")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@id_empleado","id_empleado")
       m_FechaPrevista= New BasesParaCompatibilidad.DataBussinesParameter("@FechaPrevista","FechaPrevista")
       m_Resultados= New BasesParaCompatibilidad.DataBussinesParameter("@Resultados","Resultados")
       m_Realizado= New BasesParaCompatibilidad.DataBussinesParameter("@Realizado","Realizado")
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

   Public Property Id_control_incidencia() As Int32
       Get
           Return if(isdbnull(m_Id_control_incidencia.value), Nothing, m_Id_control_incidencia.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_control_incidencia.value = value
       End Set
   End Property

   Public Property Id_AccionCorrectiva() As Int32
       Get
           Return if(isdbnull(m_Id_AccionCorrectiva.value), Nothing, m_Id_AccionCorrectiva.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_AccionCorrectiva.value = value
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

   Public Property id_empleado() As Int32
       Get
           Return if(isdbnull(m_id_empleado.value), Nothing, m_id_empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_id_empleado.value = value
       End Set
   End Property

    Public Property FechaPrevista() As Date
        Get
            Return If(IsDBNull(m_FechaPrevista.value), Today.Date, m_FechaPrevista.value)
        End Get
        Set(ByVal value As Date)
            m_FechaPrevista.value = value
        End Set
    End Property

   Public Property Resultados() As String
       Get
           Return if(isdbnull(m_Resultados.value), String.empty, m_Resultados.value)
       End Get
       Set(ByVal value As String)
           m_Resultados.value = value
       End Set
   End Property

   Public Property Realizado() As Boolean
       Get
           Return if(isdbnull(m_Realizado.value), false, m_Realizado.value)
       End Get
       Set(ByVal value As Boolean)
           m_Realizado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_control_incidencia, m_Id_control_incidencia.sqlName)
       MyBase.atributos.Add(m_Id_AccionCorrectiva, m_Id_AccionCorrectiva.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_id_empleado, m_id_empleado.sqlName)
       MyBase.atributos.Add(m_FechaPrevista, m_FechaPrevista.sqlName)
       MyBase.atributos.Add(m_Resultados, m_Resultados.sqlName)
       MyBase.atributos.Add(m_Realizado, m_Realizado.sqlName)
   End Sub
End Class
