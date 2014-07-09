Public Class DBO_Movimientos1


   Private m_MovimientoID As Int32
    Private m_Fecha As Nullable(Of Date)
   Private m_Observaciones As String
    Private m_Cantidad As String
   Private m_ProcesoID As Int32
   Private m_EntraDepositoID As Nullable(Of Int32)
   Private m_SaleDepositoID As Nullable(Of Int32)
   Private m_LoteID As Nullable(Of Int32)
   Private m_FiltroID As Nullable(Of Int32)
   Private m_Suma As Nullable(Of Boolean)
   Private m_NuevoLote As Nullable(Of Boolean)
   Private m_FechaModificacion As Date
   Private m_UsuarioModificacion As Int32


   Public Sub New()

   End Sub


   Public Property MovimientoID() As Int32
       Get
           Return m_MovimientoID
       End Get
       Set(ByVal value As Int32)
           m_MovimientoID = value
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

   Public Property Observaciones() As String
       Get
           Return m_Observaciones
       End Get
       Set(ByVal value As String)
           m_Observaciones = value
       End Set
   End Property

    Public Property Cantidad() As String
        Get
            Return m_Cantidad
        End Get
        Set(ByVal value As String)
            m_Cantidad = value
        End Set
    End Property

   Public Property ProcesoID() As Int32
       Get
           Return m_ProcesoID
       End Get
       Set(ByVal value As Int32)
           m_ProcesoID = value
       End Set
   End Property

   Public Property EntraDepositoID() As Nullable(Of Int32)
       Get
           Return m_EntraDepositoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_EntraDepositoID = value
       End Set
   End Property

   Public Property SaleDepositoID() As Nullable(Of Int32)
       Get
           Return m_SaleDepositoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_SaleDepositoID = value
       End Set
   End Property

   Public Property LoteID() As Nullable(Of Int32)
       Get
           Return m_LoteID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_LoteID = value
       End Set
   End Property

   Public Property FiltroID() As Nullable(Of Int32)
       Get
           Return m_FiltroID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_FiltroID = value
       End Set
   End Property

   Public Property Suma() As Nullable(Of Boolean)
       Get
           Return m_Suma
       End Get
       Set(ByVal value As Nullable(Of Boolean))
           m_Suma = value
       End Set
   End Property

   Public Property NuevoLote() As Nullable(Of Boolean)
       Get
           Return m_NuevoLote
       End Get
       Set(ByVal value As Nullable(Of Boolean))
           m_NuevoLote = value
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
