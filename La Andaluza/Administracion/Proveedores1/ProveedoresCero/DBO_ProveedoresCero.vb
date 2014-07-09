Public Class DBO_ProveedoresCero
inherits BasesParaCompatibilidad.DataBussines

    Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Id_proveedor As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Id_tipoProveedorCero As BasesParaCompatibilidad.DataBussinesParameter
    Private m_ResultadoFinacieroUltimos3Años As BasesParaCompatibilidad.DataBussinesParameter
    Private m_CapacidadProductivaTotal As BasesParaCompatibilidad.DataBussinesParameter
    Private m_CompromisoCalidad As BasesParaCompatibilidad.DataBussinesParameter
    Private m_ConsumoParaMercadona As BasesParaCompatibilidad.DataBussinesParameter
    Private m_EmpleadosSectorPrimario As BasesParaCompatibilidad.DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id", "Id")
        m_Id_proveedor = New BasesParaCompatibilidad.DataBussinesParameter("@Id_proveedor", "Id_proveedor")
        m_Id_tipoProveedorCero = New BasesParaCompatibilidad.DataBussinesParameter("@Id_tipoProveedorCero", "Id_tipoProveedorCero")
        m_ResultadoFinacieroUltimos3Años = New BasesParaCompatibilidad.DataBussinesParameter("@ResultadoFinacieroUltimos3Años", "ResultadoFinacieroUltimos3Años")
        m_CapacidadProductivaTotal = New BasesParaCompatibilidad.DataBussinesParameter("@CapacidadProductivaTotal", "CapacidadProductivaTotal")
        m_CompromisoCalidad = New BasesParaCompatibilidad.DataBussinesParameter("@CompromisoCalidad", "CompromisoCalidad")
        m_ConsumoParaMercadona = New BasesParaCompatibilidad.DataBussinesParameter("@ConsumoParaMercadona", "ConsumoParaMercadona")
        m_EmpleadosSectorPrimario = New BasesParaCompatibilidad.DataBussinesParameter("@EmpleadosSectorPrimario", "EmpleadosSectorPrimario")
        MyBase.primaryKey = m_Id
        añadirParametros()
    End Sub

    
    Public Property Id() As Int32
        Get
            Return if(isdbnull(m_Id.value), Nothing, m_Id.value)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_Id.value = value
        End Set
    End Property

    Public Property Id_proveedor() As Int32
        Get
            Return if(isdbnull(m_Id_proveedor.value), Nothing, m_Id_proveedor.value)
        End Get
        Set(ByVal value As Int32)
            m_Id_proveedor.value = value
        End Set
    End Property

    Public Property Id_tipoProveedorCero() As Int32
        Get
            Return if(IsDBNull(m_Id_tipoProveedorCero.value), True, m_Id_tipoProveedorCero.value)
        End Get
        Set(ByVal value As Int32)
            m_Id_tipoProveedorCero.value = value
        End Set
    End Property

    Public Property ResultadoFinacieroUltimos3Años() As Boolean
        Get
            Return if(IsDBNull(m_ResultadoFinacieroUltimos3Años.value), Nothing, m_ResultadoFinacieroUltimos3Años.value)
        End Get
        Set(ByVal value As Boolean)
            m_ResultadoFinacieroUltimos3Años.value = value
        End Set
    End Property

    Public Property CapacidadProductivaTotal() As Int32
        Get
            Return if(isdbnull(m_CapacidadProductivaTotal.value), Nothing, m_CapacidadProductivaTotal.value)
        End Get
        Set(ByVal value As Int32)
            m_CapacidadProductivaTotal.value = value
        End Set
    End Property

    Public Property EmpleadosSectorPrimario() As Int32
        Get
            Return if(IsDBNull(m_EmpleadosSectorPrimario.value), Nothing, m_EmpleadosSectorPrimario.value)
        End Get
        Set(ByVal value As Int32)
            m_EmpleadosSectorPrimario.value = value
        End Set
    End Property

    Public Property CompromisoCalidad() As Boolean
        Get
            Return if(isdbnull(m_CompromisoCalidad.value), False, m_CompromisoCalidad.value)
        End Get
        Set(ByVal value As Boolean)
            m_CompromisoCalidad.value = value
        End Set
    End Property

    Public Property ConsumoParaMercadona() As Int32
        Get
            Return if(isdbnull(m_ConsumoParaMercadona.value), Nothing, m_ConsumoParaMercadona.value)
        End Get
        Set(ByVal value As Int32)
            m_ConsumoParaMercadona.value = value
        End Set
    End Property

    

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_Id_proveedor, m_Id_proveedor.sqlName)
        MyBase.atributos.Add(m_Id_tipoProveedorCero, m_Id_tipoProveedorCero.sqlName)
        MyBase.atributos.Add(m_ResultadoFinacieroUltimos3Años, m_ResultadoFinacieroUltimos3Años.sqlName)
        MyBase.atributos.Add(m_CapacidadProductivaTotal, m_CapacidadProductivaTotal.sqlName)
        MyBase.atributos.Add(m_CompromisoCalidad, m_CompromisoCalidad.sqlName)
        MyBase.atributos.Add(m_ConsumoParaMercadona, m_ConsumoParaMercadona.sqlName)
        MyBase.atributos.Add(m_EmpleadosSectorPrimario, m_EmpleadosSectorPrimario.sqlName)
    End Sub
End Class
