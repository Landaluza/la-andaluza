Public Class DBO_IncidenciasCalidad
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Lote As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RutaDocumento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProveedorID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoMaterialID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_IncidenciaID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@IncidenciaCalidadID","IncidenciaCalidadID")
       m_Lote= New BasesParaCompatibilidad.DataBussinesParameter("@Lote","Lote")
       m_RutaDocumento= New BasesParaCompatibilidad.DataBussinesParameter("@RutaDocumento","RutaDocumento")
       m_ProveedorID= New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorID","ProveedorID")
       m_TipoMaterialID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoMaterialID","TipoMaterialID")
       m_IncidenciaID= New BasesParaCompatibilidad.DataBussinesParameter("@IncidenciaID","IncidenciaID")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
           Return if(isdbnull(m_id.value), Nothing, m_id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Lote() As String
       Get
           Return if(isdbnull(m_Lote.value), String.empty, m_Lote.value)
       End Get
       Set(ByVal value As String)
           m_Lote.value = value
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

   Public Property ProveedorID() As Int32
       Get
           Return if(isdbnull(m_ProveedorID.value), Nothing, m_ProveedorID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID.value = value
       End Set
   End Property

   Public Property TipoMaterialID() As Int32
       Get
           Return if(isdbnull(m_TipoMaterialID.value), Nothing, m_TipoMaterialID.value)
       End Get
       Set(ByVal value As Int32)
           m_TipoMaterialID.value = value
       End Set
   End Property

   Public Property IncidenciaID() As Int32
       Get
           Return if(isdbnull(m_IncidenciaID.value), Nothing, m_IncidenciaID.value)
       End Get
       Set(ByVal value As Int32)
           m_IncidenciaID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Lote, m_Lote.sqlName)
       MyBase.atributos.Add(m_RutaDocumento, m_RutaDocumento.sqlName)
       MyBase.atributos.Add(m_ProveedorID, m_ProveedorID.sqlName)
       MyBase.atributos.Add(m_TipoMaterialID, m_TipoMaterialID.sqlName)
       MyBase.atributos.Add(m_IncidenciaID, m_IncidenciaID.sqlName)
   End Sub
End Class
