Public Class Dbo_PaletsMovimiento

    Private m_ID As Int32
    Private m_Tipo As Int32
    Private m_Tipo_IsDBNull As Boolean
    Private m_SubTipo As Int32
    Private m_SubTipo_IsDBNull As Boolean
    Private m_PaletID As Int32
    Private m_PaletID_IsDBNull As Boolean
    Private m_Cajas As Int32
    Private m_Cajas_IsDBNull As Boolean
    Private m_DocumentoID As Int32
    Private m_DocumentoID_IsDBNull As Boolean
    Private m_Comentarios As String
    Private m_Comentarios_IsDBNull As Boolean
    Private m_AutorizadoPor As Int32
    Private m_AutorizadoPor_IsDBNull As Boolean
    Private m_Receptor As Int32
    Private m_Receptor_IsDBNull As Boolean
    Private m_Motivo As String
    Private m_Motivo_IsDBNull As Boolean
    Private m_Solicitante As String
    Private m_Solicitante_IsDBNull As Boolean
    Private m_Cliente As String
    Private m_Cliente_IsDBNull As Boolean
    Private m_Inicial As String
    Private m_Inicial_IsDBNull As Boolean
    Private m_Final As String
    Private m_Final_IsDBNull As Boolean
    Private m_Fecha As Date
    Private m_Fecha_IsDBNull As Boolean
    Private m_FechaModificacion As String
    Private m_FechaModificacion_IsDBNull As Boolean
    Private m_UsuarioModificacion As Int32
    Private m_UsuarioModificacion_IsDBNull As Boolean
    Private m_idPaletDestino As Integer
    Private m_id_movimientoEntrePalet As Integer
    Private m_hora As TimeSpan
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

    Public Property Hora As TimeSpan
        Get
            If m_hora = Nothing Then
                Return New TimeSpan(Now.Hour, Now.Minute, Now.Second)
            End If
            Return m_hora
        End Get
        Set(value As TimeSpan)
            m_hora = value
        End Set
    End Property
    Public Property Tipo() As Int32
        Get
            Return m_Tipo
        End Get
        Set(ByVal value As Int32)
            m_Tipo = value
        End Set
    End Property

    Public Property ContenidoDestinoID() As Int32
        Get
            Return m_idPaletDestino
        End Get
        Set(ByVal value As Int32)
            m_idPaletDestino = value
        End Set
    End Property

    Public Property MovimientoEntrePaletsID() As Int32
        Get
            Return m_id_movimientoEntrePalet
        End Get
        Set(ByVal value As Int32)
            m_id_movimientoEntrePalet = value
        End Set
    End Property

    Public Property Tipo_IsDBNull() As Boolean
        Get
            Return m_Tipo_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Tipo_IsDBNull = value
        End Set
    End Property

    Public Property SubTipo() As Int32
        Get
            Return m_SubTipo
        End Get
        Set(ByVal value As Int32)
            m_SubTipo = value
        End Set
    End Property

    Public Property SubTipo_IsDBNull() As Boolean
        Get
            Return m_SubTipo_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_SubTipo_IsDBNull = value
        End Set
    End Property

    Public Property PaletID() As Int32
        Get
            Return m_PaletID
        End Get
        Set(ByVal value As Int32)
            m_PaletID = value
        End Set
    End Property

    Public Property PaletID_IsDBNull() As Boolean
        Get
            Return m_PaletID_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_PaletID_IsDBNull = value
        End Set
    End Property

    Public Property Cajas() As Int32
        Get
            Return m_Cajas
        End Get
        Set(ByVal value As Int32)
            m_Cajas = value
        End Set
    End Property

    Public Property Cajas_IsDBNull() As Boolean
        Get
            Return m_Cajas_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Cajas_IsDBNull = value
        End Set
    End Property

    Public Property DocumentoID() As Int32
        Get
            Return m_DocumentoID
        End Get
        Set(ByVal value As Int32)
            m_DocumentoID = value
        End Set
    End Property

    Public Property DocumentoID_IsDBNull() As Boolean
        Get
            Return m_DocumentoID_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_DocumentoID_IsDBNull = value
        End Set
    End Property

    Public Property Comentarios() As String
        Get
            Return m_Comentarios
        End Get
        Set(ByVal value As String)
            m_Comentarios = value
        End Set
    End Property

    Public Property Comentarios_IsDBNull() As Boolean
        Get
            Return m_Comentarios_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Comentarios_IsDBNull = value
        End Set
    End Property

    Public Property AutorizadoPor() As Int32
        Get
            Return m_AutorizadoPor
        End Get
        Set(ByVal value As Int32)
            m_AutorizadoPor = value
        End Set
    End Property

    Public Property AutorizadoPor_IsDBNull() As Boolean
        Get
            Return m_AutorizadoPor_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_AutorizadoPor_IsDBNull = value
        End Set
    End Property

    Public Property Receptor() As Int32
        Get
            Return m_Receptor
        End Get
        Set(ByVal value As Int32)
            m_Receptor = value
        End Set
    End Property

    Public Property Receptor_IsDBNull() As Boolean
        Get
            Return m_Receptor_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Receptor_IsDBNull = value
        End Set
    End Property

    Public Property Motivo() As String
        Get
            Return m_Motivo
        End Get
        Set(ByVal value As String)
            m_Motivo = value
        End Set
    End Property

    Public Property Motivo_IsDBNull() As Boolean
        Get
            Return m_Motivo_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Motivo_IsDBNull = value
        End Set
    End Property

    Public Property Solicitante() As String
        Get
            Return m_Solicitante
        End Get
        Set(ByVal value As String)
            m_Solicitante = value
        End Set
    End Property

    Public Property Solicitante_IsDBNull() As Boolean
        Get
            Return m_Solicitante_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Solicitante_IsDBNull = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return m_Cliente
        End Get
        Set(ByVal value As String)
            m_Cliente = value
        End Set
    End Property

    Public Property Cliente_IsDBNull() As Boolean
        Get
            Return m_Cliente_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Cliente_IsDBNull = value
        End Set
    End Property

    Public Property Inicial() As String
        Get
            Return m_Inicial
        End Get
        Set(ByVal value As String)
            m_Inicial = value
        End Set
    End Property

    Public Property Inicial_IsDBNull() As Boolean
        Get
            Return m_Inicial_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Inicial_IsDBNull = value
        End Set
    End Property

    Public Property Final() As String
        Get
            Return m_Final
        End Get
        Set(ByVal value As String)
            m_Final = value
        End Set
    End Property

    Public Property Final_IsDBNull() As Boolean
        Get
            Return m_Final_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Final_IsDBNull = value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return m_Fecha
        End Get
        Set(ByVal value As Date)
            m_Fecha = value
        End Set
    End Property

    Public Property Fecha_IsDBNull() As Boolean
        Get
            Return m_Fecha_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_Fecha_IsDBNull = value
        End Set
    End Property

    Public Property FechaModificacion() As String
        Get
            Return m_FechaModificacion
        End Get
        Set(ByVal value As String)
            m_FechaModificacion = value
        End Set
    End Property

    Public Property FechaModificacion_IsDBNull() As Boolean
        Get
            Return m_FechaModificacion_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_FechaModificacion_IsDBNull = value
        End Set
    End Property

    Public Property UsuarioModificacion() As Int32
        Get
            Return m_UsuarioModificacion
        End Get
        Set(ByVal value As Int32)
            m_UsuarioModificacion = value
        End Set
    End Property

    Public Property UsuarioModificacion_IsDBNull() As Boolean
        Get
            Return m_UsuarioModificacion_IsDBNull
        End Get
        Set(ByVal value As Boolean)
            m_UsuarioModificacion_IsDBNull = value
        End Set
    End Property

End Class
