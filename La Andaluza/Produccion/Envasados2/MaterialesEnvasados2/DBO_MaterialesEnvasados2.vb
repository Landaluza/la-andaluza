Public Class DBO_MaterialesEnvasados2

   Private m_MaterialEnvasadoID As Int32
    Private m_HoraInicio As timespan
   Private m_HoraInicio_IsDBNull As Boolean
    Private m_HoraFin As TimeSpan
   Private m_HoraFin_IsDBNull As Boolean
   Private m_Observaciones As String
   Private m_Observaciones_IsDBNull As Boolean
   Private m_Lote As String
   Private m_Lote_IsDBNull As Boolean
   Private m_Cantidad As Int32
   Private m_Cantidad_IsDBNull As Boolean
   Private m_TipoMaterialID As Int32
   Private m_TipoMaterialID_IsDBNull As Boolean
   Private m_ProveedorID As Int32
   Private m_ProveedorID_IsDBNull As Boolean
   Private m_FormatoEnvasadoID As Int32
   Private m_FormatoEnvasadoID_IsDBNull As Boolean
   Private m_FechaModificacion As date
   Private m_UsuarioModificacion As Int32

   Public Sub New()

   End Sub

   Public Property MaterialEnvasadoID() As Int32
       Get
           Return m_MaterialEnvasadoID
       End Get
       Set(ByVal value As Int32)
           m_MaterialEnvasadoID = value
       End Set
   End Property

    Public Property HoraInicio() As TimeSpan
        Get
            Return m_HoraInicio
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio = value
        End Set
    End Property

   Public Property HoraInicio_IsDBNull() As Boolean
       Get
           Return m_HoraInicio_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_HoraInicio_IsDBNull = value
       End Set
   End Property

    Public Property HoraFin() As TimeSpan
        Get
            Return m_HoraFin
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFin = value
        End Set
    End Property

   Public Property HoraFin_IsDBNull() As Boolean
       Get
           Return m_HoraFin_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_HoraFin_IsDBNull = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           Return m_Observaciones
       End Get
       Set(ByVal value As String)
           m_Observaciones = value
       End Set
   End Property

   Public Property Observaciones_IsDBNull() As Boolean
       Get
           Return m_Observaciones_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Observaciones_IsDBNull = value
       End Set
   End Property

   Public Property Lote() As String
       Get
           Return m_Lote
       End Get
       Set(ByVal value As String)
           m_Lote = value
       End Set
   End Property

   Public Property Lote_IsDBNull() As Boolean
       Get
           Return m_Lote_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Lote_IsDBNull = value
       End Set
   End Property

   Public Property Cantidad() As Int32
       Get
           Return m_Cantidad
       End Get
       Set(ByVal value As Int32)
           m_Cantidad = value
       End Set
   End Property

   Public Property Cantidad_IsDBNull() As Boolean
       Get
           Return m_Cantidad_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_Cantidad_IsDBNull = value
       End Set
   End Property

   Public Property TipoMaterialID() As Int32
       Get
           Return m_TipoMaterialID
       End Get
       Set(ByVal value As Int32)
           m_TipoMaterialID = value
       End Set
   End Property

   Public Property TipoMaterialID_IsDBNull() As Boolean
       Get
           Return m_TipoMaterialID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_TipoMaterialID_IsDBNull = value
       End Set
   End Property

   Public Property ProveedorID() As Int32
       Get
           Return m_ProveedorID
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID = value
       End Set
   End Property

   Public Property ProveedorID_IsDBNull() As Boolean
       Get
           Return m_ProveedorID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_ProveedorID_IsDBNull = value
       End Set
   End Property

   Public Property FormatoEnvasadoID() As Int32
       Get
           Return m_FormatoEnvasadoID
       End Get
       Set(ByVal value As Int32)
           m_FormatoEnvasadoID = value
       End Set
   End Property

   Public Property FormatoEnvasadoID_IsDBNull() As Boolean
       Get
           Return m_FormatoEnvasadoID_IsDBNull
       End Get
       Set(ByVal value As Boolean)
           m_FormatoEnvasadoID_IsDBNull = value
       End Set
   End Property

   Public Property FechaModificacion() As Date
       Get
           Return m_FechaModificacion
       End Get
        Set(ByVal value As Date)
            m_FechaModificacion = value
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

End Class
