Public Class DBO_articulosGranelesCompuestoPor
    Private m_articuloPrincipal As DBO_Articulos1
    Private m_articuloComponente As DBO_Articulos1
    Private m_cantidad As Double
    Private m_fase As Integer
    Private m_orden As Integer
    Private m_old_orden As Integer
    Private m_old_cantidad As Double
    Private spArticulos1 As spArticulos1
    Public Sub New()
        Me.m_articuloPrincipal = New DBO_Articulos1
        Me.m_articuloComponente = New DBO_Articulos1
        spArticulos1 = New spArticulos1
    End Sub

    Public Property ArticuloPrincipal As Integer
        Get
            Return Me.m_articuloPrincipal.ID
        End Get
        Set(value As Integer)
            Me.m_articuloPrincipal = spArticulos1.Select_Record(value)
        End Set
    End Property

    Public Property Fase As Integer
        Get
            Return Me.m_fase
        End Get
        Set(value As Integer)
            Me.m_fase = value
        End Set
    End Property

    Public Property Orden As Integer
        Get
            Return Me.m_orden
        End Get
        Set(value As Integer)
            Me.m_orden = value
        End Set
    End Property

    Public Property Old_Orden As Integer
        Get
            Return Me.m_old_orden
        End Get
        Set(value As Integer)
            Me.m_old_orden = value
        End Set
    End Property

    Public Property ArticuloComponente As Integer
        Get
            Return Me.m_articuloComponente.ID
        End Get
        Set(value As Integer)
            Me.m_articuloComponente = spArticulos1.Select_Record(value)
        End Set
    End Property

    Public Property Cantidad As Double
        Get
            Return Me.m_cantidad
        End Get
        Set(value As Double)
            Me.m_cantidad = value
        End Set
    End Property

    Public Property Old_Cantidad As Double
        Get
            Return Me.m_old_cantidad
        End Get
        Set(value As Double)
            Me.m_old_cantidad = value
        End Set
    End Property
End Class
