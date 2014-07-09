Public Class Dbo_Movimiento_Dbo_Movimientotipo

    Private m_ID As Int32
    Private m_Descripcion As String

    Public Sub New()

    End Sub

    Public Property ID() As Int32
        Get
            Return m_ID
        End Get
        Set(ByVal value As Int32)
            m_ID = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return m_Descripcion
        End Get
        Set(ByVal value As String)
            m_Descripcion = value
        End Set
    End Property

End Class
