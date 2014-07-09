Public Class DBO_TiposFormatosLineas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_LineaEnvasadoID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@TipoFormatoLineaID","TipoFormatoLineaID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_LineaEnvasadoID= New BasesParaCompatibilidad.DataBussinesParameter("@LineaEnvasadoID","LineaEnvasadoID")
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

   Public Property LineaEnvasadoID() As Int32
       Get
           Return if(isdbnull(m_LineaEnvasadoID.value), Nothing, m_LineaEnvasadoID.value)
       End Get
       Set(ByVal value As Int32)
           m_LineaEnvasadoID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_LineaEnvasadoID, m_LineaEnvasadoID.sqlName)
   End Sub
End Class
