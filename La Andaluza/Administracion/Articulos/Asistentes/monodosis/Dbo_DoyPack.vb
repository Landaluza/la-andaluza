Public Class Dbo_DoyPack

    Private m_id As Integer
    Private id_primario As Integer
    Private id_monodosis As Integer
    Private id_tipoFormato As Integer
    Private m_cantidad As Integer
    Private id_marca As Integer
    Private id_paletNC As Integer
    Private id_producto As Integer
    Private id_caja As Integer
    Private ean As String

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

    Public Property ArticuloPrimarioID As Integer
        Get
            Return id_primario
        End Get
        Set(value As Integer)
            id_primario = value
        End Set
    End Property

    Public Property MonodosisID As Integer
        Get
            Return id_monodosis
        End Get
        Set(value As Integer)
            id_monodosis = value
        End Set
    End Property

    Public Property TipoFormatoID As Integer
        Get
            Return id_tipoFormato
        End Get
        Set(value As Integer)
            id_tipoFormato = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return m_cantidad
        End Get
        Set(value As Integer)
            m_cantidad = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return m_id
        End Get
        Set(value As Integer)
            m_id = value
        End Set
    End Property

    Public Property Palet_NO_Conforme_ID As Integer
        Get
            Return id_paletNC
        End Get
        Set(value As Integer)
            id_paletNC = value
        End Set
    End Property
End Class
