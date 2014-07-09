Public Class DBO_Articulos_AlmacenNoConforme_PaletsProducidos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_paletProduccido As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_Articulos_AlmacenNoConforme As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_paletProduccido= New BasesParaCompatibilidad.DataBussinesParameter("@Id_paletProduccido","Id_paletProduccido")
       m_Id_Articulos_AlmacenNoConforme= New BasesParaCompatibilidad.DataBussinesParameter("@Id_Articulos_AlmacenNoConforme","Id_Articulos_AlmacenNoConforme")
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

   Public Property Id_paletProduccido() As Int32
       Get
           Return if(isdbnull(m_Id_paletProduccido.value), Nothing, m_Id_paletProduccido.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_paletProduccido.value = value
       End Set
   End Property

   Public Property Id_Articulos_AlmacenNoConforme() As Int32
       Get
           Return if(isdbnull(m_Id_Articulos_AlmacenNoConforme.value), Nothing, m_Id_Articulos_AlmacenNoConforme.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_Articulos_AlmacenNoConforme.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_paletProduccido, m_Id_paletProduccido.sqlName)
       MyBase.atributos.Add(m_Id_Articulos_AlmacenNoConforme, m_Id_Articulos_AlmacenNoConforme.sqlName)
   End Sub
End Class
