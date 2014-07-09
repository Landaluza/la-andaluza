Public Class DBO_Maquinas_Lineas
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MaquinaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_LineaID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_MaquinaID= New BasesParaCompatibilidad.DataBussinesParameter("@MaquinaID","MaquinaID")
       m_LineaID= New BasesParaCompatibilidad.DataBussinesParameter("@LineaID","LineaID")
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

   Public Property MaquinaID() As Int32
       Get
           Return if(isdbnull(m_MaquinaID.value), Nothing, m_MaquinaID.value)
       End Get
       Set(ByVal value As Int32)
           m_MaquinaID.value = value
       End Set
   End Property

   Public Property LineaID() As Int32
       Get
           Return if(isdbnull(m_LineaID.value), Nothing, m_LineaID.value)
       End Get
       Set(ByVal value As Int32)
           m_LineaID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_MaquinaID, m_MaquinaID.sqlName)
       MyBase.atributos.Add(m_LineaID, m_LineaID.sqlName)
   End Sub
End Class
