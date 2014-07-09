Public Class DBO_ControlIncidencias_AccionesPreventivas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ControlIncidencias As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_AccionesPreventivas As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaPrevista As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Resultados As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Realizado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_ControlIncidencias= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ControlIncidencias","Id_ControlIncidencias")
       m_Id_AccionesPreventivas= New BasesParaCompatibilidad.DataBussinesParameter("@Id_AccionesPreventivas","Id_AccionesPreventivas")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
       m_FechaPrevista= New BasesParaCompatibilidad.DataBussinesParameter("@FechaPrevista","FechaPrevista")
       m_FechaInicio= New BasesParaCompatibilidad.DataBussinesParameter("@FechaInicio","FechaInicio")
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

   Public Property Id_ControlIncidencias() As Int32
       Get
           Return if(isdbnull(m_Id_ControlIncidencias.value), Nothing, m_Id_ControlIncidencias.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_ControlIncidencias.value = value
       End Set
   End Property

   Public Property Id_AccionesPreventivas() As Int32
       Get
           Return if(isdbnull(m_Id_AccionesPreventivas.value), Nothing, m_Id_AccionesPreventivas.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_AccionesPreventivas.value = value
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

   Public Property Id_empleado() As Int32
       Get
           Return if(isdbnull(m_Id_empleado.value), Nothing, m_Id_empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_empleado.value = value
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

    Public Property FechaInicio() As Date
        Get
            Return If(IsDBNull(m_FechaInicio.value), Today.Date, m_FechaInicio.value)
        End Get
        Set(ByVal value As Date)
            m_FechaInicio.value = value
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
       MyBase.atributos.Add(m_Id_ControlIncidencias, m_Id_ControlIncidencias.sqlName)
       MyBase.atributos.Add(m_Id_AccionesPreventivas, m_Id_AccionesPreventivas.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
       MyBase.atributos.Add(m_FechaPrevista, m_FechaPrevista.sqlName)
       MyBase.atributos.Add(m_FechaInicio, m_FechaInicio.sqlName)
       MyBase.atributos.Add(m_Resultados, m_Resultados.sqlName)
       MyBase.atributos.Add(m_Realizado, m_Realizado.sqlName)
   End Sub
End Class
