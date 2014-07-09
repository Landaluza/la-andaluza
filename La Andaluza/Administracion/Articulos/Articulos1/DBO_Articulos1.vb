Public Class DBO_Articulos1
inherits BasesParaCompatibilidad.DataBussines

    Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
    Private m_ArticuloTpoID As BasesParaCompatibilidad.DataBussinesParameter
    Private m_CodigoTARIC As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Utilizacion As BasesParaCompatibilidad.DataBussinesParameter
    Private m_CodigoLA As BasesParaCompatibilidad.DataBussinesParameter
    Private m_DescripcionLA As BasesParaCompatibilidad.DataBussinesParameter
    Private m_CodigoQS As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
    Private m_TienePedidos As BasesParaCompatibilidad.DataBussinesParameter
    Private m_InformacionGeneral As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Activo As BasesParaCompatibilidad.DataBussinesParameter
    Private m_EvolucionPrecio As BasesParaCompatibilidad.DataBussinesParameter

    Public Sub New()
        MyBase.New()
        m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloID", "ArticuloID")
        m_ArticuloTpoID = New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloTpoID", "ArticuloTpoID")
        m_CodigoTARIC = New BasesParaCompatibilidad.DataBussinesParameter("@CodigoTARIC", "CodigoTARIC")
        m_Utilizacion = New BasesParaCompatibilidad.DataBussinesParameter("@Utilizacion", "Utilizacion")
        m_CodigoLA = New BasesParaCompatibilidad.DataBussinesParameter("@CodigoLA", "CodigoLA")
        m_DescripcionLA = New BasesParaCompatibilidad.DataBussinesParameter("@DescripcionLA", "DescripcionLA")
        m_CodigoQS = New BasesParaCompatibilidad.DataBussinesParameter("@CodigoQS", "CodigoQS")
        m_Observaciones = New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones", "Observaciones")
        m_TienePedidos = New BasesParaCompatibilidad.DataBussinesParameter("@TienePedidos", "TienePedidos")
        m_InformacionGeneral = New BasesParaCompatibilidad.DataBussinesParameter("@InformacionGeneral", "InformacionGeneral")
        m_Activo = New BasesParaCompatibilidad.DataBussinesParameter("@Activo", "Activo")
        m_EvolucionPrecio = New BasesParaCompatibilidad.DataBussinesParameter("@EvolucionPrecios", "EvolucionPrecios")

        MyBase.primaryKey = m_Id
        añadirParametros()
    End Sub

    Public Property ID() As Int32
        Get
            If m_id.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_id.value, int32)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property ArticuloTpoID() As Int32
        Get
            If m_ArticuloTpoID.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_ArticuloTpoID.value, int32)
        End Get
        Set(ByVal value As Int32)
            m_ArticuloTpoID.value = value
        End Set
    End Property

    Public Property CodigoTARIC() As String
        Get
            If m_CodigoTARIC.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_CodigoTARIC.value, String)
        End Get
        Set(ByVal value As String)
            m_CodigoTARIC.value = value
        End Set
    End Property

    Public Property Utilizacion() As String
        Get
            If m_Utilizacion.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_Utilizacion.value, String)
        End Get
        Set(ByVal value As String)
            m_Utilizacion.value = value
        End Set
    End Property

    Public Property CodigoLA() As Int32
        Get
            If m_CodigoLA.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_CodigoLA.value, int32)
        End Get
        Set(ByVal value As Int32)
            m_CodigoLA.value = value
        End Set
    End Property

    Public Property DescripcionLA() As String
        Get
            If m_DescripcionLA.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_DescripcionLA.value, String)
        End Get
        Set(ByVal value As String)
            m_DescripcionLA.value = value
        End Set
    End Property

    Public Property CodigoQS() As Int32
        Get
            If m_CodigoQS.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_CodigoQS.value, int32)
        End Get
        Set(ByVal value As Int32)
            m_CodigoQS.value = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            If m_Observaciones.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_Observaciones.value, String)
        End Get
        Set(ByVal value As String)
            m_Observaciones.value = value
        End Set
    End Property

    Public Property TienePedidos() As Boolean
        Get
            If m_TienePedidos.value Is convert.dbnull Then
                Return False
            End If
            Return CType(m_TienePedidos.value, Boolean)
        End Get
        Set(ByVal value As Boolean)
            m_TienePedidos.value = value
        End Set
    End Property

    Public Property InformacionGeneral() As String
        Get
            If m_InformacionGeneral.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_InformacionGeneral.value, String)
        End Get
        Set(ByVal value As String)
            m_InformacionGeneral.value = value
        End Set
    End Property

    Public Property EvolucionPrecio() As String
        Get
            If m_EvolucionPrecio.value Is Convert.DBNull Then
                Return String.Empty
            End If
            Return CType(m_EvolucionPrecio.value, String)
        End Get
        Set(ByVal value As String)
            m_EvolucionPrecio.value = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            If m_Activo.value Is convert.dbnull Then
                Return False
            End If
            Return CType(m_Activo.value, Boolean)
        End Get
        Set(ByVal value As Boolean)
            m_Activo.value = value
        End Set
    End Property

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_ArticuloTpoID, m_ArticuloTpoID.sqlName)
        MyBase.atributos.Add(m_CodigoTARIC, m_CodigoTARIC.sqlName)
        MyBase.atributos.Add(m_Utilizacion, m_Utilizacion.sqlName)
        MyBase.atributos.Add(m_CodigoLA, m_CodigoLA.sqlName)
        MyBase.atributos.Add(m_DescripcionLA, m_DescripcionLA.sqlName)
        MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
        MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
        MyBase.atributos.Add(m_TienePedidos, m_TienePedidos.sqlName)
        MyBase.atributos.Add(m_InformacionGeneral, m_InformacionGeneral.sqlName)
        MyBase.atributos.Add(m_Activo, m_Activo.sqlName)
        MyBase.atributos.Add(m_EvolucionPrecio, m_EvolucionPrecio.sqlName)
    End Sub
End Class
