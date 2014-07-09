Public Class DBO_empleados_contratos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_fecha_inicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_fecha_final As BasesParaCompatibilidad.DataBussinesParameter
   Private m_fecha_baja As BasesParaCompatibilidad.DataBussinesParameter
   Private m_referencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ruta_documentacion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_tipoContrato As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_puestoTrabajo As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_fecha_inicio= New BasesParaCompatibilidad.DataBussinesParameter("@fecha_inicio","fecha_inicio")
       m_fecha_final= New BasesParaCompatibilidad.DataBussinesParameter("@fecha_final","fecha_final")
       m_fecha_baja= New BasesParaCompatibilidad.DataBussinesParameter("@fecha_baja","fecha_baja")
       m_referencia= New BasesParaCompatibilidad.DataBussinesParameter("@referencia","referencia")
       m_observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@observaciones","observaciones")
       m_ruta_documentacion= New BasesParaCompatibilidad.DataBussinesParameter("@ruta_documentacion","ruta_documentacion")
       m_id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@id_empleado","id_empleado")
       m_id_tipoContrato= New BasesParaCompatibilidad.DataBussinesParameter("@id_tipoContrato","id_tipoContrato")
       m_id_puestoTrabajo= New BasesParaCompatibilidad.DataBussinesParameter("@id_puestoTrabajo","id_puestoTrabajo")
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

    Public Property fecha_inicio() As Date
        Get
            Return If(IsDBNull(m_fecha_inicio.value), Today.Date, m_fecha_inicio.value)
        End Get
        Set(ByVal value As Date)
            m_fecha_inicio.value = value
        End Set
    End Property

    Public Property fecha_final() As Date
        Get
            Return If(IsDBNull(m_fecha_final.value), Today.Date, m_fecha_final.value)
        End Get
        Set(ByVal value As Date)
            m_fecha_final.value = value
        End Set
    End Property

    Public Property fecha_baja() As Date
        Get
            Return If(IsDBNull(m_fecha_baja.value), Today.Date, m_fecha_baja.value)
        End Get
        Set(ByVal value As Date)
            m_fecha_baja.value = value
        End Set
    End Property

   Public Property referencia() As String
       Get
           Return if(isdbnull(m_referencia.value), String.empty, m_referencia.value)
       End Get
       Set(ByVal value As String)
           m_referencia.value = value
       End Set
   End Property

   Public Property observaciones() As String
       Get
           Return if(isdbnull(m_observaciones.value), String.empty, m_observaciones.value)
       End Get
       Set(ByVal value As String)
           m_observaciones.value = value
       End Set
   End Property

   Public Property ruta_documentacion() As String
       Get
           Return if(isdbnull(m_ruta_documentacion.value), String.empty, m_ruta_documentacion.value)
       End Get
       Set(ByVal value As String)
           m_ruta_documentacion.value = value
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

   Public Property id_tipoContrato() As Int32
       Get
           Return if(isdbnull(m_id_tipoContrato.value), Nothing, m_id_tipoContrato.value)
       End Get
       Set(ByVal value As Int32)
           m_id_tipoContrato.value = value
       End Set
   End Property

   Public Property id_puestoTrabajo() As Int32
       Get
           Return if(isdbnull(m_id_puestoTrabajo.value), Nothing, m_id_puestoTrabajo.value)
       End Get
       Set(ByVal value As Int32)
           m_id_puestoTrabajo.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_fecha_inicio, m_fecha_inicio.sqlName)
       MyBase.atributos.Add(m_fecha_final, m_fecha_final.sqlName)
       MyBase.atributos.Add(m_fecha_baja, m_fecha_baja.sqlName)
       MyBase.atributos.Add(m_referencia, m_referencia.sqlName)
       MyBase.atributos.Add(m_observaciones, m_observaciones.sqlName)
       MyBase.atributos.Add(m_ruta_documentacion, m_ruta_documentacion.sqlName)
       MyBase.atributos.Add(m_id_empleado, m_id_empleado.sqlName)
       MyBase.atributos.Add(m_id_tipoContrato, m_id_tipoContrato.sqlName)
       MyBase.atributos.Add(m_id_puestoTrabajo, m_id_puestoTrabajo.sqlName)
   End Sub
End Class
