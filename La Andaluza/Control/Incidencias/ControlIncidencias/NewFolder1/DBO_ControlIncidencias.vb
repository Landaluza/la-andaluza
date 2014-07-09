Public Class DBO_ControlIncidencias
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_procesoCalidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_articulo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_incidenciaCalidadGeneral As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_PuntosGravedad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_PuntosFrecuencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_NecesitaSeguimiento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EstadosControlesIncidencias As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_Id_procesoCalidad= New BasesParaCompatibilidad.DataBussinesParameter("@Id_procesoCalidad","Id_procesoCalidad")
       m_Id_articulo= New BasesParaCompatibilidad.DataBussinesParameter("@Id_articulo","Id_articulo")
       m_Id_incidenciaCalidadGeneral= New BasesParaCompatibilidad.DataBussinesParameter("@Id_incidenciaCalidadGeneral","Id_incidenciaCalidadGeneral")
       m_id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@id_empleado","id_empleado")
       m_Id_PuntosGravedad= New BasesParaCompatibilidad.DataBussinesParameter("@Id_PuntosGravedad","Id_PuntosGravedad")
       m_Id_PuntosFrecuencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_PuntosFrecuencia","Id_PuntosFrecuencia")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_NecesitaSeguimiento= New BasesParaCompatibilidad.DataBussinesParameter("@NecesitaSeguimiento","NecesitaSeguimiento")
       m_EstadosControlesIncidencias= New BasesParaCompatibilidad.DataBussinesParameter("@EstadosControlesIncidencias","EstadosControlesIncidencias")
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

    Public Property Fecha() As Date
        Get
            Return If(IsDBNull(m_Fecha.value), Today.Date, m_Fecha.value)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property

   Public Property Id_procesoCalidad() As Int32
       Get
           Return if(isdbnull(m_Id_procesoCalidad.value), Nothing, m_Id_procesoCalidad.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_procesoCalidad.value = value
       End Set
   End Property

   Public Property Id_articulo() As Int32
       Get
           Return if(isdbnull(m_Id_articulo.value), Nothing, m_Id_articulo.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_articulo.value = value
       End Set
   End Property

   Public Property Id_incidenciaCalidadGeneral() As Int32
       Get
           Return if(isdbnull(m_Id_incidenciaCalidadGeneral.value), Nothing, m_Id_incidenciaCalidadGeneral.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_incidenciaCalidadGeneral.value = value
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

   Public Property Id_PuntosGravedad() As Int32
       Get
           Return if(isdbnull(m_Id_PuntosGravedad.value), Nothing, m_Id_PuntosGravedad.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_PuntosGravedad.value = value
       End Set
   End Property

   Public Property Id_PuntosFrecuencia() As Int32
       Get
           Return if(isdbnull(m_Id_PuntosFrecuencia.value), Nothing, m_Id_PuntosFrecuencia.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_PuntosFrecuencia.value = value
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

   Public Property NecesitaSeguimiento() As Boolean
       Get
           Return if(isdbnull(m_NecesitaSeguimiento.value), false, m_NecesitaSeguimiento.value)
       End Get
       Set(ByVal value As Boolean)
           m_NecesitaSeguimiento.value = value
       End Set
   End Property

   Public Property EstadosControlesIncidencias() As Int32
       Get
           Return if(isdbnull(m_EstadosControlesIncidencias.value), Nothing, m_EstadosControlesIncidencias.value)
       End Get
       Set(ByVal value As Int32)
           m_EstadosControlesIncidencias.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_Id_procesoCalidad, m_Id_procesoCalidad.sqlName)
       MyBase.atributos.Add(m_Id_articulo, m_Id_articulo.sqlName)
       MyBase.atributos.Add(m_Id_incidenciaCalidadGeneral, m_Id_incidenciaCalidadGeneral.sqlName)
       MyBase.atributos.Add(m_id_empleado, m_id_empleado.sqlName)
       MyBase.atributos.Add(m_Id_PuntosGravedad, m_Id_PuntosGravedad.sqlName)
       MyBase.atributos.Add(m_Id_PuntosFrecuencia, m_Id_PuntosFrecuencia.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_NecesitaSeguimiento, m_NecesitaSeguimiento.sqlName)
       MyBase.atributos.Add(m_EstadosControlesIncidencias, m_EstadosControlesIncidencias.sqlName)
   End Sub
End Class
