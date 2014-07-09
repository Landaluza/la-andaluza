Public Class DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_Incidencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ParteEnvasado_causaParteEnvasado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_Incidencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_Incidencia","Id_Incidencia")
       m_Id_ParteEnvasado_causaParteEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ParteEnvasado_causaParteEnvasado","Id_ParteEnvasado_causaParteEnvasado")
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

   Public Property Id_Incidencia() As Int32
       Get
           Return if(isdbnull(m_Id_Incidencia.value), Nothing, m_Id_Incidencia.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_Incidencia.value = value
       End Set
   End Property

   Public Property Id_ParteEnvasado_causaParteEnvasado() As Int32
       Get
           Return if(isdbnull(m_Id_ParteEnvasado_causaParteEnvasado.value), Nothing, m_Id_ParteEnvasado_causaParteEnvasado.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_ParteEnvasado_causaParteEnvasado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_Incidencia, m_Id_Incidencia.sqlName)
       MyBase.atributos.Add(m_Id_ParteEnvasado_causaParteEnvasado, m_Id_ParteEnvasado_causaParteEnvasado.sqlName)
   End Sub
End Class
