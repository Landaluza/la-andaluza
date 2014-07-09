Public Class DBO_PaletsMovimientosTipos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EntrePalets As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Utilizacion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EncajadoMonodosis As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PaletMovimientoTipoID","PaletMovimientoTipoID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_EntrePalets= New BasesParaCompatibilidad.DataBussinesParameter("@EntrePalets","EntrePalets")
       m_Utilizacion= New BasesParaCompatibilidad.DataBussinesParameter("@Utilizacion","Utilizacion")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_EncajadoMonodosis= New BasesParaCompatibilidad.DataBussinesParameter("@EncajadoMonodosis","EncajadoMonodosis")
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

   Public Property Descripcion() As String
       Get
           Return if(isdbnull(m_Descripcion.value), String.empty, m_Descripcion.value)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

   Public Property EntrePalets() As Boolean
       Get
           Return if(isdbnull(m_EntrePalets.value), false, m_EntrePalets.value)
       End Get
       Set(ByVal value As Boolean)
           m_EntrePalets.value = value
       End Set
   End Property

   Public Property Utilizacion() As String
       Get
           Return if(isdbnull(m_Utilizacion.value), String.empty, m_Utilizacion.value)
       End Get
       Set(ByVal value As String)
           m_Utilizacion.value = value
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

   Public Property EncajadoMonodosis() As Boolean
       Get
           Return if(isdbnull(m_EncajadoMonodosis.value), false, m_EncajadoMonodosis.value)
       End Get
       Set(ByVal value As Boolean)
           m_EncajadoMonodosis.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_EntrePalets, m_EntrePalets.sqlName)
       MyBase.atributos.Add(m_Utilizacion, m_Utilizacion.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_EncajadoMonodosis, m_EncajadoMonodosis.sqlName)
   End Sub
End Class
