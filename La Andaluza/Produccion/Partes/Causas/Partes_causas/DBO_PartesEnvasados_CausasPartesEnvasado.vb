Public Class DBO_PartesEnvasados_CausasPartesEnvasado
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ParteEnvasado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_CausaParteEnvasado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_ParteEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ParteEnvasado","Id_ParteEnvasado")
       m_Id_CausaParteEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_CausaParteEnvasado","Id_CausaParteEnvasado")
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

   Public Property Id_ParteEnvasado() As Int32
       Get
           Return if(isdbnull(m_Id_ParteEnvasado.value), Nothing, m_Id_ParteEnvasado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_ParteEnvasado.value = value
       End Set
   End Property

   Public Property Id_CausaParteEnvasado() As Int32
       Get
           Return if(isdbnull(m_Id_CausaParteEnvasado.value), Nothing, m_Id_CausaParteEnvasado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_CausaParteEnvasado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_ParteEnvasado, m_Id_ParteEnvasado.sqlName)
       MyBase.atributos.Add(m_Id_CausaParteEnvasado, m_Id_CausaParteEnvasado.sqlName)
   End Sub
End Class
