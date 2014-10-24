Public Class DBO_Articulos1CompuestoPor

    Private m_articuloPrincipal As DBO_Articulos1
    Private m_articuloComponente As DBO_Articulos1
    Private m_cantidad As Double
    Private spArticulos1 As spArticulos1

    Public Sub New()
        Me.m_articuloPrincipal = New DBO_Articulos1
        Me.m_articuloComponente = New DBO_Articulos1
        spArticulos1 = New spArticulos1
    End Sub

    Public ReadOnly Property ArticuloPrincipal As Integer
        Get
            Return Me.m_articuloPrincipal.ID
        End Get
    End Property

    Public Sub Set_ArticuloPrincipal(value As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Me.m_articuloPrincipal = spArticulos1.Select_Record(value, dtb)
    End Sub

    Public ReadOnly Property ArticuloComponente As Integer
        Get
            Return Me.m_articuloComponente.ID
        End Get

    End Property

    Public Sub Set_ArticuloComponente(value As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Me.m_articuloComponente = spArticulos1.Select_Record(value, dtb)
    End Sub

    Public Property Cantidad As Double
        Get
            Return Me.m_cantidad
        End Get
        Set(value As Double)
            Me.m_cantidad = value
        End Set
    End Property
End Class
