Public Class DBO_Lotes1


   Private m_LoteID As Int32
   Private m_Referencia As Nullable(Of Int32)
   Private m_Descripcion As String
    Private m_Fecha As Nullable(Of Date)
    Private m_CantidadRestante As String
   Private m_Observacion As String
   Private m_LoteProveedor As String
   Private m_Botellas As String
   Private m_CantidadID As Nullable(Of Int32)
   Private m_MedidaID As Nullable(Of Int32)
   Private m_EspecificacionID As Nullable(Of Int32)
   Private m_TipoLoteID As Nullable(Of Int32)
   Private m_TipoProductoID As Nullable(Of Int32)
   Private m_CorredorID As Nullable(Of Int32)
   Private m_ProveedorID As Nullable(Of Int32)
   Private m_LoteConjuntoCompraID As Nullable(Of Int32)
   Private m_SinEspecificacion As Nullable(Of Boolean)
   Private m_CodigoLote As String
   Private m_DepositoID As Nullable(Of Int32)
   Private m_DepositoPrevioID As Nullable(Of Int32)
   Private m_Revisar As Nullable(Of Boolean)
   Private m_RecipienteSalidaID As Nullable(Of Int32)
   Private m_FechaModificacion As Date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property LoteID() As Int32
       Get
           Return m_LoteID
       End Get
       Set(ByVal value As Int32)
           m_LoteID = value
       End Set
   End Property

   Public Property Referencia() As Nullable(Of Int32)
       Get
           Return m_Referencia
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_Referencia = value
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

    Public Property Fecha() As Nullable(Of Date)
        Get
            Return m_Fecha
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_Fecha = value
        End Set
    End Property

    Public Property CantidadRestante() As String
        Get
            Return m_CantidadRestante
        End Get
        Set(ByVal value As String)
            m_CantidadRestante = value
        End Set
    End Property

   Public Property Observacion() As String
       Get
           Return m_Observacion
       End Get
       Set(ByVal value As String)
           m_Observacion = value
       End Set
   End Property

   Public Property LoteProveedor() As String
       Get
           Return m_LoteProveedor
       End Get
       Set(ByVal value As String)
           m_LoteProveedor = value
       End Set
   End Property

   Public Property Botellas() As String
       Get
           Return m_Botellas
       End Get
       Set(ByVal value As String)
           m_Botellas = value
       End Set
   End Property

   Public Property CantidadID() As Nullable(Of Int32)
       Get
           Return m_CantidadID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_CantidadID = value
       End Set
   End Property

   Public Property MedidaID() As Nullable(Of Int32)
       Get
           Return m_MedidaID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_MedidaID = value
       End Set
   End Property

   Public Property EspecificacionID() As Nullable(Of Int32)
       Get
           Return m_EspecificacionID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_EspecificacionID = value
       End Set
   End Property

   Public Property TipoLoteID() As Nullable(Of Int32)
       Get
           Return m_TipoLoteID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_TipoLoteID = value
       End Set
   End Property

   Public Property TipoProductoID() As Nullable(Of Int32)
       Get
           Return m_TipoProductoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_TipoProductoID = value
       End Set
   End Property

   Public Property CorredorID() As Nullable(Of Int32)
       Get
           Return m_CorredorID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_CorredorID = value
       End Set
   End Property

   Public Property ProveedorID() As Nullable(Of Int32)
       Get
           Return m_ProveedorID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_ProveedorID = value
       End Set
   End Property

   Public Property LoteConjuntoCompraID() As Nullable(Of Int32)
       Get
           Return m_LoteConjuntoCompraID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_LoteConjuntoCompraID = value
       End Set
   End Property

   Public Property SinEspecificacion() As Nullable(Of Boolean)
       Get
           Return m_SinEspecificacion
       End Get
       Set(ByVal value As Nullable(Of Boolean))
           m_SinEspecificacion = value
       End Set
   End Property

   Public Property CodigoLote() As String
       Get
           Return m_CodigoLote
       End Get
       Set(ByVal value As String)
           m_CodigoLote = value
       End Set
   End Property

   Public Property DepositoID() As Nullable(Of Int32)
       Get
           Return m_DepositoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_DepositoID = value
       End Set
   End Property

   Public Property DepositoPrevioID() As Nullable(Of Int32)
       Get
           Return m_DepositoPrevioID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_DepositoPrevioID = value
       End Set
   End Property

   Public Property Revisar() As Nullable(Of Boolean)
       Get
           Return m_Revisar
       End Get
       Set(ByVal value As Nullable(Of Boolean))
           m_Revisar = value
       End Set
   End Property

   Public Property RecipienteSalidaID() As Nullable(Of Int32)
       Get
           Return m_RecipienteSalidaID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_RecipienteSalidaID = value
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
