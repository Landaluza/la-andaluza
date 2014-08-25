

Public Class clsLotesAnaliticas

#Region "Atributos"
    Private CodigoLote As String
    Private TipoLote As String
    Private TipoProducto As String
    Private Acidez As String
    Private AlcoholResidual As String
    Private Extracto As String
    Private ExtractoGrado As String
    Private AzucarTotal As String
    Private Sulfuroso As String
    Private Densidad As String
    Private dtb as BasesParaCompatibilidad.Database
#End Region

  

#Region "Propiedades"
    Public Property _CodigoLote() As String
        Get
            Return CodigoLote
        End Get

        Set(ByVal value As String)
            CodigoLote = value
        End Set
    End Property

    Public Property _TipoLote() As String
        Get
            Return TipoLote
        End Get

        Set(ByVal value As String)
            TipoLote = value
        End Set
    End Property

    Public Property _TipoProducto() As String
        Get
            Return TipoProducto
        End Get

        Set(ByVal value As String)
            TipoProducto = value
        End Set
    End Property

    Public Property _Acidez() As String
        Get
            Return Acidez
        End Get

        Set(ByVal value As String)
            Acidez = value
        End Set
    End Property

    Public Property _AlcoholResidual() As String
        Get
            Return AlcoholResidual
        End Get

        Set(ByVal value As String)
            AlcoholResidual = value
        End Set
    End Property

    Public Property _Extracto() As String
        Get
            Return Extracto
        End Get

        Set(ByVal value As String)
            Extracto = value
        End Set
    End Property

    Public Property _ExtractoGrado() As String
        Get
            Return ExtractoGrado
        End Get

        Set(ByVal value As String)
            ExtractoGrado = value
        End Set
    End Property

    Public Property _AzucarTotal() As String
        Get
            Return AzucarTotal
        End Get

        Set(ByVal value As String)
            AzucarTotal = value
        End Set
    End Property

    Public Property _Sulfuroso() As String
        Get
            Return Sulfuroso
        End Get

        Set(ByVal value As String)
            Sulfuroso = value
        End Set
    End Property

    Public Property _Densidad() As String
        Get
            Return Densidad
        End Get

        Set(ByVal value As String)
            Densidad = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Sub New(ByVal CodigoLote As String, _
                   ByVal TipoLote As String, _
                   ByVal TipoProducto As String, _
                   ByVal Acidez As String, _
                   ByVal Extracto As String, _
                   ByVal ExtractoGrado As String, _
                   ByVal AzucarTotal As String, _
                   ByVal Sulfuroso As String, _
                   ByVal Densidad As String)

        _CodigoLote = CodigoLote
        _TipoLote = TipoLote
        _TipoProducto = TipoProducto
        _Acidez = Acidez
        _Extracto = Extracto
        _ExtractoGrado = ExtractoGrado
        _AzucarTotal = AzucarTotal
        _Sulfuroso = Sulfuroso
        _Densidad = Densidad
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)

    End Sub

    Public Sub New(ByVal NuevaCls As clsLotesAnaliticas)
        _CodigoLote = NuevaCls.CodigoLote
        _TipoLote = NuevaCls.TipoLote
        _TipoProducto = NuevaCls.TipoProducto
        _Acidez = NuevaCls.Acidez
        _Extracto = NuevaCls.Extracto
        _ExtractoGrado = NuevaCls.ExtractoGrado
        _AzucarTotal = NuevaCls.AzucarTotal
        _Sulfuroso = NuevaCls.Sulfuroso
        _Densidad = NuevaCls.Densidad
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)

    End Sub

    Public Sub New()
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)

    End Sub
#End Region

#Region "Funciones"
    Public Function comprobar_disponibilidad_boletin_envasado(ByVal m_CodigoLote As String) As Boolean
        'Dim tab As System.Data.DataTable = DataTableFill("LotesSelectByCodigoLoteTerminado '" & m_CodigoLote & "'")
        '        Dim tab As System.Data.DataTable = dtb.Consultar("LotesAnalizadosByCodigoLote '" & m_CodigoLote & "'")
        dtb.PrepararConsulta("LotesAnalizadosByCodigoLote @cod")
        dtb.AñadirParametroConsulta("@cod", m_CodigoLote)
        Dim tab As System.Data.DataTable = dtb.Consultar()

        Return tab.Rows.Count > 0
    End Function
#End Region
End Class
