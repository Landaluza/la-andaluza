Public Class DBO_TiposProveedoresCero
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
       MyBase.primaryKey = m_Id
       a�adirParametros()
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

   Public Property Nombre() As String
       Get
           Return if(isdbnull(m_Nombre.value), String.empty, m_Nombre.value)
       End Get
       Set(ByVal value As String)
           m_Nombre.value = value
       End Set
   End Property



   Private Sub a�adirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
   End Sub
End Class
