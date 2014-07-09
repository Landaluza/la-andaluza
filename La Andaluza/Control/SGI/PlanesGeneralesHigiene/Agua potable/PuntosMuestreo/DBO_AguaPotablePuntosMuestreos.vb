Public Class DBO_AguaPotablePuntosMuestreos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ResponsableID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Referencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PuntoMuestreoID","PuntoMuestreoID")
       m_ResponsableID= New BasesParaCompatibilidad.DataBussinesParameter("@ResponsableID","ResponsableID")
       m_Referencia= New BasesParaCompatibilidad.DataBussinesParameter("@Referencia","Referencia")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
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

   Public Property ResponsableID() As Int32
       Get
           Return if(isdbnull(m_ResponsableID.value), Nothing, m_ResponsableID.value)
       End Get
       Set(ByVal value As Int32)
           m_ResponsableID.value = value
       End Set
   End Property

   Public Property Referencia() As String
       Get
           Return if(isdbnull(m_Referencia.value), String.empty, m_Referencia.value)
       End Get
       Set(ByVal value As String)
           m_Referencia.value = value
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

   Public Property Observaciones() As String
       Get
           Return if(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ResponsableID, m_ResponsableID.sqlName)
       MyBase.atributos.Add(m_Referencia, m_Referencia.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
