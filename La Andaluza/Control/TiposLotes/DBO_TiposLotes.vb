Public Class DBO_TiposLotes
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Abreviatura As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Orden As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@TipoLoteID","TipoLoteID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Abreviatura= New BasesParaCompatibilidad.DataBussinesParameter("@Abreviatura","Abreviatura")
       m_Orden= New BasesParaCompatibilidad.DataBussinesParameter("@Orden","Orden")
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

   Public Property Abreviatura() As String
       Get
           Return if(isdbnull(m_Abreviatura.value), String.empty, m_Abreviatura.value)
       End Get
       Set(ByVal value As String)
           m_Abreviatura.value = value
       End Set
   End Property

   Public Property Orden() As Int32
       Get
           Return if(isdbnull(m_Orden.value), Nothing, m_Orden.value)
       End Get
       Set(ByVal value As Int32)
           m_Orden.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Abreviatura, m_Abreviatura.sqlName)
       MyBase.atributos.Add(m_Orden, m_Orden.sqlName)
   End Sub
End Class
