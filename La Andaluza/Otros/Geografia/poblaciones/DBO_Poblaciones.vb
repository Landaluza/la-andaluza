Public Class DBO_Poblaciones
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_provincia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_provincia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_provincia","Id_provincia")
       m_Nombre= New BasesParaCompatibilidad.DataBussinesParameter("@Nombre","Nombre")
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

   Public Property Id_provincia() As Int32
       Get
           Return if(isdbnull(m_Id_provincia.value), Nothing, m_Id_provincia.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_provincia.value = value
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



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_provincia, m_Id_provincia.sqlName)
       MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
   End Sub
End Class
