Public Class DBO_Reuniones
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_proveedor As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoReunion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RutaDocumento As BasesParaCompatibilidad.DataBussinesParameter
    Private m_ruta As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_proveedor= New BasesParaCompatibilidad.DataBussinesParameter("@Id_proveedor","Id_proveedor")
       m_Id_TipoReunion= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoReunion","Id_TipoReunion")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
        m_RutaDocumento = New BasesParaCompatibilidad.DataBussinesParameter("@RutaDocumento", "RutaDocumento")
        m_ruta = New BasesParaCompatibilidad.DataBussinesParameter("RutaDefecto", "RutaDefecto")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property Id() As Int32
       Get
           Return if(isdbnull(m_Id.value), Nothing, m_Id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_Id.value = value
       End Set
   End Property

   Public Property Id_proveedor() As Int32
       Get
           Return if(isdbnull(m_Id_proveedor.value), Nothing, m_Id_proveedor.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_proveedor.value = value
       End Set
   End Property

   Public Property Id_TipoReunion() As Int32
       Get
           Return if(isdbnull(m_Id_TipoReunion.value), Nothing, m_Id_TipoReunion.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_TipoReunion.value = value
       End Set
   End Property

    Public Property Fecha() As Date
        Get
            Return If(IsDBNull(m_Fecha.value), Today.Date, m_Fecha.value)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property

   Public Property Observaciones() As String
       Get
           Return if(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property

   Public Property RutaDocumento() As String
       Get
           Return if(isdbnull(m_RutaDocumento.value), String.empty, m_RutaDocumento.value)
       End Get
       Set(ByVal value As String)
           m_RutaDocumento.value = value
       End Set
   End Property

    Public Property RutaDefecto() As String
        Get
            Return if(IsDBNull(m_ruta.value), String.Empty, m_ruta.value)
        End Get
        Set(ByVal value As String)
            m_ruta.value = value
        End Set
    End Property


   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_proveedor, m_Id_proveedor.sqlName)
       MyBase.atributos.Add(m_Id_TipoReunion, m_Id_TipoReunion.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_RutaDocumento, m_RutaDocumento.sqlName)
   End Sub
End Class
