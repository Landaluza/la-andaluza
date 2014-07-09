Public Class DBO_ArticulosFichasCondiciones3

   Private m_ArticuloFichaCondicionID As Int32
   Private m_ArticuloID As Nullable(Of Int32)
   Private m_ProveedorID As Nullable(Of Int32)
   Private m_FormaPagoID As Nullable(Of Int32)
   Private m_PlazoPagoID As Nullable(Of Int32)
   Private m_UnidadID As Nullable(Of Int32)
   Private m_Descripcion As String
    Private m_EurosUnidad As Double
    Private m_CantidadMinima As Nullable(Of Double)
    Private m_PrecioAnterior As Nullable(Of Double)
    Private m_Incremento As Nullable(Of Double)
    Private m_Ruta As String
    Private m_FechaInicio As Nullable(Of Date)
    Private m_FechaFinal As Nullable(Of Date)
    Private m_Vigente As String
    Private m_CosteTransporte As Nullable(Of Double)
    Private m_CosteEmbalaje As Nullable(Of Double)
    Private m_CosteDevolucionEmbalaje As Nullable(Of Double)
    Private m_AbonoDevolucionEmbalaje As Nullable(Of Double)
    Private m_CosteMolde As Nullable(Of Double)
    Private m_CosteAmortizacionMoldeUnidad As Nullable(Of Double)
    Private m_Observaciones As String
    Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32

    Public Sub New()

    End Sub

    Public Property ArticuloFichaCondicionID() As Int32
        Get
            Return m_ArticuloFichaCondicionID
        End Get
        Set(ByVal value As Int32)
            m_ArticuloFichaCondicionID = value
        End Set
    End Property

    Public Property ArticuloID() As Nullable(Of Int32)
        Get
            Return m_ArticuloID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_ArticuloID = value
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

    Public Property FormaPagoID() As Nullable(Of Int32)
        Get
            Return m_FormaPagoID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_FormaPagoID = value
        End Set
    End Property

    Public Property PlazoPagoID() As Nullable(Of Int32)
        Get
            Return m_PlazoPagoID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_PlazoPagoID = value
        End Set
    End Property

    Public Property UnidadID() As Nullable(Of Int32)
        Get
            Return m_UnidadID
        End Get
        Set(ByVal value As Nullable(Of Int32))
            m_UnidadID = value
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

    Public Property EurosUnidad() As Double
        Get
            Return m_EurosUnidad
        End Get
        Set(ByVal value As Double)
            m_EurosUnidad = value
        End Set
    End Property

    Public Property CantidadMinima() As Nullable(Of Double)
        Get
            Return m_CantidadMinima
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_CantidadMinima = value
        End Set
    End Property

    Public Property PrecioAnterior() As Nullable(Of Double)
        Get
            Return m_PrecioAnterior
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_PrecioAnterior = value
        End Set
    End Property

    Public Property Incremento() As Nullable(Of Double)
        Get
            Return m_Incremento
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_Incremento = value
        End Set
    End Property

    Public Property Ruta() As String
        Get
            Return m_Ruta
        End Get
        Set(ByVal value As String)
            m_Ruta = value
        End Set
    End Property

    Public Property FechaInicio() As Nullable(Of Date)
        Get
            Return m_FechaInicio
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaInicio = value
        End Set
    End Property

    Public Property FechaFinal() As Nullable(Of Date)
        Get
            Return m_FechaFinal
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_FechaFinal = value
        End Set
    End Property

    Public Property Vigente() As String
        Get
            Return m_Vigente
        End Get
        Set(ByVal value As String)
            m_Vigente = value
        End Set
    End Property

    Public Property CosteTransporte() As Nullable(Of Double)
        Get
            Return m_CosteTransporte
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_CosteTransporte = value
        End Set
    End Property

    Public Property CosteEmbalaje() As Nullable(Of Double)
        Get
            Return m_CosteEmbalaje
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_CosteEmbalaje = value
        End Set
    End Property

    Public Property CosteDevolucionEmbalaje() As Nullable(Of Double)
        Get
            Return m_CosteDevolucionEmbalaje
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_CosteDevolucionEmbalaje = value
        End Set
    End Property

    Public Property AbonoDevolucionEmbalaje() As Nullable(Of Double)
        Get
            Return m_AbonoDevolucionEmbalaje
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_AbonoDevolucionEmbalaje = value
        End Set
    End Property

    Public Property CosteMolde() As Nullable(Of Double)
        Get
            Return m_CosteMolde
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_CosteMolde = value
        End Set
    End Property

    Public Property CosteAmortizacionMoldeUnidad() As Nullable(Of Double)
        Get
            Return m_CosteAmortizacionMoldeUnidad
        End Get
        Set(ByVal value As Nullable(Of Double))
            m_CosteAmortizacionMoldeUnidad = value
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
