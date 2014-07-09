Public Class DBO_EnvasadosProductosArticulos


   Private m_EnvasadoProductoArticuloID As Int32
   Private m_FormatoEnvasadoID As Nullable(Of Int32)
   Private m_LoteTerminadoID As Nullable(Of Int32)
   Private m_CantidadAsignada As Nullable(Of Int32)
   Private m_Observaciones As String
   Private m_FechaModificacion As Date
    Private m_UsuarioModificacion As Int32
    Private m_merma As Int32


   Public Sub New()

   End Sub


   Public Property EnvasadoProductoArticuloID() As Int32
       Get
           Return m_EnvasadoProductoArticuloID
       End Get
       Set(ByVal value As Int32)
           m_EnvasadoProductoArticuloID = value
       End Set
   End Property

    Public Property Merma() As Int32
        Get
            Return m_merma
        End Get
        Set(ByVal value As Int32)
            m_merma = value
        End Set
    End Property

   Public Property FormatoEnvasadoID() As Nullable(Of Int32)
       Get
           Return m_FormatoEnvasadoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_FormatoEnvasadoID = value
       End Set
   End Property

   Public Property LoteTerminadoID() As Nullable(Of Int32)
       Get
           Return m_LoteTerminadoID
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_LoteTerminadoID = value
       End Set
   End Property

   Public Property CantidadAsignada() As Nullable(Of Int32)
       Get
           Return m_CantidadAsignada
       End Get
       Set(ByVal value As Nullable(Of Int32))
           m_CantidadAsignada = value
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
