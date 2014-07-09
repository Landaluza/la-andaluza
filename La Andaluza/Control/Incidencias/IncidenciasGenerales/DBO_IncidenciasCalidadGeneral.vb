Public Class DBO_IncidenciasCalidadGeneral
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaApertura As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ArticuloTipo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_procesoCalidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CriterioFrecuenciaBaja As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CriterioFrecuenciaMedia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CriterioFrecuenciaAlta As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CriterioGravedadLeve As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CriterioGravedadModerada As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CriterioGravedadGrave As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Calidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MedioAmbiente As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PRL As BasesParaCompatibilidad.DataBussinesParameter
   Private m_InocuidadAlimentos As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Formacion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Estrategicos As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Detalles As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Visible As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_FechaApertura= New BasesParaCompatibilidad.DataBussinesParameter("@FechaApertura","FechaApertura")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Id_ArticuloTipo= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ArticuloTipo","Id_ArticuloTipo")
       m_Id_procesoCalidad= New BasesParaCompatibilidad.DataBussinesParameter("@Id_procesoCalidad","Id_procesoCalidad")
       m_CriterioFrecuenciaBaja= New BasesParaCompatibilidad.DataBussinesParameter("@CriterioFrecuenciaBaja","CriterioFrecuenciaBaja")
       m_CriterioFrecuenciaMedia= New BasesParaCompatibilidad.DataBussinesParameter("@CriterioFrecuenciaMedia","CriterioFrecuenciaMedia")
       m_CriterioFrecuenciaAlta= New BasesParaCompatibilidad.DataBussinesParameter("@CriterioFrecuenciaAlta","CriterioFrecuenciaAlta")
       m_CriterioGravedadLeve= New BasesParaCompatibilidad.DataBussinesParameter("@CriterioGravedadLeve","CriterioGravedadLeve")
       m_CriterioGravedadModerada= New BasesParaCompatibilidad.DataBussinesParameter("@CriterioGravedadModerada","CriterioGravedadModerada")
       m_CriterioGravedadGrave= New BasesParaCompatibilidad.DataBussinesParameter("@CriterioGravedadGrave","CriterioGravedadGrave")
       m_Calidad= New BasesParaCompatibilidad.DataBussinesParameter("@Calidad","Calidad")
       m_MedioAmbiente= New BasesParaCompatibilidad.DataBussinesParameter("@MedioAmbiente","MedioAmbiente")
       m_PRL= New BasesParaCompatibilidad.DataBussinesParameter("@PRL","PRL")
       m_InocuidadAlimentos= New BasesParaCompatibilidad.DataBussinesParameter("@InocuidadAlimentos","InocuidadAlimentos")
       m_Formacion= New BasesParaCompatibilidad.DataBussinesParameter("@Formacion","Formacion")
       m_Estrategicos= New BasesParaCompatibilidad.DataBussinesParameter("@Estrategicos","Estrategicos")
       m_Detalles= New BasesParaCompatibilidad.DataBussinesParameter("@Detalles","Detalles")
       m_Visible= New BasesParaCompatibilidad.DataBussinesParameter("@Visible","Visible")
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

    Public Property FechaApertura() As Date
        Get
            Return If(IsDBNull(m_FechaApertura.value), Today.Date, m_FechaApertura.value)
        End Get
        Set(ByVal value As Date)
            m_FechaApertura.value = value
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

   Public Property Descripcion() As String
       Get
           Return if(isdbnull(m_Descripcion.value), String.empty, m_Descripcion.value)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property Id_ArticuloTipo() As Int32
       Get
           Return if(isdbnull(m_Id_ArticuloTipo.value), Nothing, m_Id_ArticuloTipo.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_ArticuloTipo.value = value
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

   Public Property CriterioFrecuenciaBaja() As String
       Get
           Return if(isdbnull(m_CriterioFrecuenciaBaja.value), String.empty, m_CriterioFrecuenciaBaja.value)
       End Get
       Set(ByVal value As String)
           m_CriterioFrecuenciaBaja.value = value
       End Set
   End Property

   Public Property CriterioFrecuenciaMedia() As String
       Get
           Return if(isdbnull(m_CriterioFrecuenciaMedia.value), String.empty, m_CriterioFrecuenciaMedia.value)
       End Get
       Set(ByVal value As String)
           m_CriterioFrecuenciaMedia.value = value
       End Set
   End Property

   Public Property CriterioFrecuenciaAlta() As String
       Get
           Return if(isdbnull(m_CriterioFrecuenciaAlta.value), String.empty, m_CriterioFrecuenciaAlta.value)
       End Get
       Set(ByVal value As String)
           m_CriterioFrecuenciaAlta.value = value
       End Set
   End Property

   Public Property CriterioGravedadLeve() As String
       Get
           Return if(isdbnull(m_CriterioGravedadLeve.value), String.empty, m_CriterioGravedadLeve.value)
       End Get
       Set(ByVal value As String)
           m_CriterioGravedadLeve.value = value
       End Set
   End Property

   Public Property CriterioGravedadModerada() As String
       Get
           Return if(isdbnull(m_CriterioGravedadModerada.value), String.empty, m_CriterioGravedadModerada.value)
       End Get
       Set(ByVal value As String)
           m_CriterioGravedadModerada.value = value
       End Set
   End Property

   Public Property CriterioGravedadGrave() As String
       Get
           Return if(isdbnull(m_CriterioGravedadGrave.value), String.empty, m_CriterioGravedadGrave.value)
       End Get
       Set(ByVal value As String)
           m_CriterioGravedadGrave.value = value
       End Set
   End Property

   Public Property Calidad() As Boolean
       Get
           Return if(isdbnull(m_Calidad.value), false, m_Calidad.value)
       End Get
       Set(ByVal value As Boolean)
           m_Calidad.value = value
       End Set
   End Property

   Public Property MedioAmbiente() As Boolean
       Get
           Return if(isdbnull(m_MedioAmbiente.value), false, m_MedioAmbiente.value)
       End Get
       Set(ByVal value As Boolean)
           m_MedioAmbiente.value = value
       End Set
   End Property

   Public Property PRL() As Boolean
       Get
           Return if(isdbnull(m_PRL.value), false, m_PRL.value)
       End Get
       Set(ByVal value As Boolean)
           m_PRL.value = value
       End Set
   End Property

   Public Property InocuidadAlimentos() As Boolean
       Get
           Return if(isdbnull(m_InocuidadAlimentos.value), false, m_InocuidadAlimentos.value)
       End Get
       Set(ByVal value As Boolean)
           m_InocuidadAlimentos.value = value
       End Set
   End Property

   Public Property Formacion() As Boolean
       Get
           Return if(isdbnull(m_Formacion.value), false, m_Formacion.value)
       End Get
       Set(ByVal value As Boolean)
           m_Formacion.value = value
       End Set
   End Property

   Public Property Estrategicos() As Boolean
       Get
           Return if(isdbnull(m_Estrategicos.value), false, m_Estrategicos.value)
       End Get
       Set(ByVal value As Boolean)
           m_Estrategicos.value = value
       End Set
   End Property

   Public Property Detalles() As String
       Get
           Return if(isdbnull(m_Detalles.value), String.empty, m_Detalles.value)
       End Get
       Set(ByVal value As String)
           m_Detalles.value = value
       End Set
   End Property

   Public Property Visible() As Boolean
       Get
           Return if(isdbnull(m_Visible.value), false, m_Visible.value)
       End Get
       Set(ByVal value As Boolean)
           m_Visible.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_FechaApertura, m_FechaApertura.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Id_ArticuloTipo, m_Id_ArticuloTipo.sqlName)
       MyBase.atributos.Add(m_Id_procesoCalidad, m_Id_procesoCalidad.sqlName)
       MyBase.atributos.Add(m_CriterioFrecuenciaBaja, m_CriterioFrecuenciaBaja.sqlName)
       MyBase.atributos.Add(m_CriterioFrecuenciaMedia, m_CriterioFrecuenciaMedia.sqlName)
       MyBase.atributos.Add(m_CriterioFrecuenciaAlta, m_CriterioFrecuenciaAlta.sqlName)
       MyBase.atributos.Add(m_CriterioGravedadLeve, m_CriterioGravedadLeve.sqlName)
       MyBase.atributos.Add(m_CriterioGravedadModerada, m_CriterioGravedadModerada.sqlName)
       MyBase.atributos.Add(m_CriterioGravedadGrave, m_CriterioGravedadGrave.sqlName)
       MyBase.atributos.Add(m_Calidad, m_Calidad.sqlName)
       MyBase.atributos.Add(m_MedioAmbiente, m_MedioAmbiente.sqlName)
       MyBase.atributos.Add(m_PRL, m_PRL.sqlName)
       MyBase.atributos.Add(m_InocuidadAlimentos, m_InocuidadAlimentos.sqlName)
       MyBase.atributos.Add(m_Formacion, m_Formacion.sqlName)
       MyBase.atributos.Add(m_Estrategicos, m_Estrategicos.sqlName)
       MyBase.atributos.Add(m_Detalles, m_Detalles.sqlName)
       MyBase.atributos.Add(m_Visible, m_Visible.sqlName)
   End Sub
End Class
