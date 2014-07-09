Public Class DBO_Monodosis
    Private id_articuloPrimario As Integer
    Private id_tipoFormato As Integer
    Private id_marca As Integer
    Private id_paletNC As Integer
    Private id_producto As Integer
    Private id_caja As Integer
    Private ean As String
    Private cantidad As Integer

    Public Property Ean13 As String
        Get
            Return Me.ean
        End Get
        Set(value As String)
            Me.ean = value
        End Set
    End Property

    Public Property ProductoId As Integer
        Get
            Return Me.id_producto
        End Get
        Set(value As Integer)
            Me.id_producto = value
        End Set
    End Property

    Public Property CantidadPorMatricula As Integer
        Get
            Return Me.cantidad
        End Get
        Set(value As Integer)
            Me.cantidad = value
        End Set
    End Property

    Public Property CajaId As Integer
        Get
            Return Me.id_caja
        End Get
        Set(value As Integer)
            Me.id_caja = value
        End Set
    End Property

    Public Property MarcaId As Integer
        Get
            Return Me.id_marca
        End Get
        Set(value As Integer)
            Me.id_marca = value
        End Set
    End Property

    Public Property ArticuloId As Integer
        Get
            Return Me.id_articuloPrimario
        End Get
        Set(value As Integer)
            Me.id_articuloPrimario = value
        End Set
    End Property

    Public Property TipoFormatoId As Integer
        Get
            Return Me.id_tipoFormato
        End Get
        Set(value As Integer)
            Me.id_tipoFormato = value
        End Set
    End Property

    Public Property Palet_NO_Conforme_ID As Integer
        Get
            Return Me.id_paletNC
        End Get
        Set(value As Integer)
            Me.id_paletNC = value
        End Set
    End Property
End Class
