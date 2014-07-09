Public Class DBO_EtiquetasPalets
    inherits BasesParaCompatibilidad.DataBussines

    Private m_SCC As BasesParaCompatibilidad.DataBussinesParameter
    Private m_lote As BasesParaCompatibilidad.DataBussinesParameter
    Private m_ean13 As BasesParaCompatibilidad.DataBussinesParameter
    Private m_ean14 As BasesParaCompatibilidad.DataBussinesParameter
    Private m_marca As BasesParaCompatibilidad.DataBussinesParameter
    Private m_botellas As BasesParaCompatibilidad.DataBussinesParameter
    Private m_palet As BasesParaCompatibilidad.DataBussinesParameter
    Private m_cajas As BasesParaCompatibilidad.DataBussinesParameter
    Private m_cantidadBotellas As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Producto As BasesParaCompatibilidad.DataBussinesParameter
    Private m_PaletId As BasesParaCompatibilidad.DataBussinesParameter
    Private m_cabecera As BasesParaCompatibilidad.DataBussinesParameter
    Private m_caducidad As BasesParaCompatibilidad.DataBussinesParameter
    Private m_tipopalet As BasesParaCompatibilidad.DataBussinesParameter
    Private m_tipoloteado As BasesParaCompatibilidad.DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_PaletId = New BasesParaCompatibilidad.DataBussinesParameter("@paletproducidoid", "paletproducidoid")
        m_SCC = New BasesParaCompatibilidad.DataBussinesParameter("@SCC", "SCC")
        m_lote = New BasesParaCompatibilidad.DataBussinesParameter("@lote", "lote")
        m_ean13 = New BasesParaCompatibilidad.DataBussinesParameter("@ean13", "ean13")
        m_ean14 = New BasesParaCompatibilidad.DataBussinesParameter("@ean14", "ean14")
        m_marca = New BasesParaCompatibilidad.DataBussinesParameter("@marca", "marca")
        m_botellas = New BasesParaCompatibilidad.DataBussinesParameter("@botellas", "botellas")
        m_palet = New BasesParaCompatibilidad.DataBussinesParameter("@palet", "palet")
        m_cajas = New BasesParaCompatibilidad.DataBussinesParameter("@cajas", "cajas")
        m_Producto = New BasesParaCompatibilidad.DataBussinesParameter("@producto", "producto")
        m_cantidadBotellas = New BasesParaCompatibilidad.DataBussinesParameter("@cantidadBotellas", "cantidadBotellas")
        m_cabecera = New BasesParaCompatibilidad.DataBussinesParameter("@cabecera", "cabecera")
        m_caducidad = New BasesParaCompatibilidad.DataBussinesParameter("@anoscaducidad", "anoscaducidad")
        m_tipopalet = New BasesParaCompatibilidad.DataBussinesParameter("@tipopalet", "tipopalet")
        m_tipoloteado = New BasesParaCompatibilidad.DataBussinesParameter("@TipoLoteado", "TipoLoteado")
        MyBase.primaryKey = m_SCC
        añadirParametros()
    End Sub

    Public Property PaletID() As String
        Get
            Return if(IsDBNull(m_PaletId.value), String.Empty, m_PaletId.value)
        End Get
        Set(ByVal value As String)
            m_PaletId.value = value
        End Set
    End Property

    Public Property SCC() As String
        Get
            Return if(IsDBNull(m_SCC.value), String.empty, m_SCC.value)
        End Get
        Set(ByVal value As String)
            m_SCC.value = value
        End Set
    End Property

    Public Property Producto() As String
        Get
            Return if(IsDBNull(m_Producto.value), String.Empty, m_Producto.value)
        End Get
        Set(ByVal value As String)
            m_Producto.value = value
        End Set
    End Property

    Public Property Lote() As String
        Get
            Return if(IsDBNull(m_lote.value), String.empty, m_lote.value)
        End Get
        Set(ByVal value As String)
            m_lote.value = value
        End Set
    End Property

    Public Property EAN13() As String
        Get
            Return if(IsDBNull(m_ean13.value), String.empty, m_ean13.value)
        End Get
        Set(ByVal value As String)
            m_ean13.value = value
        End Set
    End Property

    Public Property EAN14() As String
        Get
            Return if(IsDBNull(m_ean14.value), String.empty, m_ean14.value)
        End Get
        Set(ByVal value As String)
            m_ean14.value = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return if(IsDBNull(m_marca.value), String.Empty, m_marca.value)
        End Get
        Set(ByVal value As String)
            m_marca.value = value
        End Set
    End Property

    Public Property Botellas() As String
        Get
            Return if(IsDBNull(m_botellas.value), String.Empty, m_botellas.value)
        End Get
        Set(ByVal value As String)
            m_botellas.value = value
        End Set
    End Property

    Public Property Palet() As String
        Get
            Return if(IsDBNull(m_palet.value), String.empty, m_palet.value)
        End Get
        Set(ByVal value As String)
            m_palet.value = value
        End Set
    End Property
    
    Public Property Cajas() As String
        Get
            Return if(IsDBNull(m_cajas.value), String.empty, m_cajas.value)
        End Get
        Set(ByVal value As String)
            m_cajas.value = value
        End Set
    End Property

    Public Property Cantidad_botellas() As String
        Get
            Return if(IsDBNull(m_cantidadBotellas.value), String.empty, m_cantidadBotellas.value)
        End Get
        Set(ByVal value As String)
            m_cantidadBotellas.value = value
        End Set
    End Property

    Public Property Cabecera() As String
        Get
            Return if(IsDBNull(m_cabecera.value), String.Empty, m_cabecera.value)
        End Get
        Set(ByVal value As String)
            m_cabecera.value = value
        End Set
    End Property

    Public Property Anos_caducidad() As String
        Get
            Return if(IsDBNull(m_caducidad.value), String.Empty, m_caducidad.value)
        End Get
        Set(ByVal value As String)
            m_caducidad.value = value
        End Set
    End Property

    Public Property Tipo_palet As Integer
        Get
            Return m_tipopalet.value
        End Get
        Set(value As Integer)
            m_tipopalet.value = value
        End Set
    End Property

    Public Property Tipo_Loteado As Integer
        Get
            Return m_tipoloteado.value
        End Get
        Set(value As Integer)
            m_tipoloteado.value = value
        End Set
    End Property

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_SCC, m_SCC.sqlName)
        MyBase.atributos.Add(m_lote, m_lote.sqlName)
        MyBase.atributos.Add(m_ean13, m_ean13.sqlName)
        MyBase.atributos.Add(m_ean14, m_ean14.sqlName)
        MyBase.atributos.Add(m_marca, m_marca.sqlName)
        MyBase.atributos.Add(m_botellas, m_botellas.sqlName)
        MyBase.atributos.Add(m_cajas, m_cajas.sqlName)
        MyBase.atributos.Add(m_cantidadBotellas, m_cantidadBotellas.sqlName)
        MyBase.atributos.Add(m_palet, m_palet.sqlName)
        MyBase.atributos.Add(m_Producto, m_Producto.sqlName)
        MyBase.atributos.Add(m_PaletId, m_PaletId.sqlName)
        MyBase.atributos.Add(m_cabecera, m_cabecera.sqlName)
        MyBase.atributos.Add(m_caducidad, m_caducidad.sqlName)
        MyBase.atributos.Add(m_tipopalet, m_tipopalet.sqlName)
        MyBase.atributos.Add(m_tipoloteado, m_tipoloteado.sqlName)
    End Sub

End Class
