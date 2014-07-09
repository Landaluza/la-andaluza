Public Class DBO_CostesAnuales_Empleados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
    Private m_FechaInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Normal As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Extra As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Festivo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Turno As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nocturnidad As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
        m_FechaInicio = New BasesParaCompatibilidad.DataBussinesParameter("@FechaInicio", "FechaInicio")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
       m_Normal= New BasesParaCompatibilidad.DataBussinesParameter("@Normal","Normal")
       m_Extra= New BasesParaCompatibilidad.DataBussinesParameter("@Extra","Extra")
       m_Festivo= New BasesParaCompatibilidad.DataBussinesParameter("@Festivo","Festivo")
       m_Turno= New BasesParaCompatibilidad.DataBussinesParameter("@Turno","Turno")
       m_Nocturnidad= New BasesParaCompatibilidad.DataBussinesParameter("@Nocturnidad","Nocturnidad")
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

    Public Property Fecha_Inicio() As Date
        Get
            Return If(IsDBNull(m_FechaInicio.value), Nothing, m_FechaInicio.value)
        End Get
        Set(ByVal value As Date)
            m_FechaInicio.value = value
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

    Public Property Normal() As Double
        Get
            Return If(isdbnull(m_Normal.value), Nothing, m_Normal.value)
        End Get
        Set(ByVal value As Double)
            m_Normal.value = value
        End Set
    End Property

    Public Property Extra() As Double
        Get
            Return If(isdbnull(m_Extra.value), Nothing, m_Extra.value)
        End Get
        Set(ByVal value As Double)
            m_Extra.value = value
        End Set
    End Property

    Public Property Festivo() As Double
        Get
            Return If(isdbnull(m_Festivo.value), Nothing, m_Festivo.value)
        End Get
        Set(ByVal value As Double)
            m_Festivo.value = value
        End Set
    End Property

    Public Property Turno() As Double
        Get
            Return If(isdbnull(m_Turno.value), Nothing, m_Turno.value)
        End Get
        Set(ByVal value As Double)
            m_Turno.value = value
        End Set
    End Property

    Public Property Nocturnidad() As Double
        Get
            Return If(isdbnull(m_Nocturnidad.value), Nothing, m_Nocturnidad.value)
        End Get
        Set(ByVal value As Double)
            m_Nocturnidad.value = value
        End Set
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_FechaInicio, m_FechaInicio.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
       MyBase.atributos.Add(m_Normal, m_Normal.sqlName)
       MyBase.atributos.Add(m_Extra, m_Extra.sqlName)
       MyBase.atributos.Add(m_Festivo, m_Festivo.sqlName)
       MyBase.atributos.Add(m_Turno, m_Turno.sqlName)
       MyBase.atributos.Add(m_Nocturnidad, m_Nocturnidad.sqlName)
   End Sub
End Class
