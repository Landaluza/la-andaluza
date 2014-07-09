Public Class DBO_elaboraciones_fases
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_articuloGranel As BasesParaCompatibilidad.DataBussinesParameter
   Private m_fase As BasesParaCompatibilidad.DataBussinesParameter
    Private m_analizar As BasesParaCompatibilidad.DataBussinesParameter
    Private m_sobre_terminado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_id_articuloGranel= New BasesParaCompatibilidad.DataBussinesParameter("@id_articuloGranel","id_articuloGranel")
       m_fase= New BasesParaCompatibilidad.DataBussinesParameter("@fase","fase")
        m_analizar = New BasesParaCompatibilidad.DataBussinesParameter("@analizar", "analizar")
        m_sobre_terminado = New BasesParaCompatibilidad.DataBussinesParameter("@sobreTerminado", "sobreTerminado")
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

   Public Property id_articuloGranel() As Int32
       Get
           Return if(isdbnull(m_id_articuloGranel.value), Nothing, m_id_articuloGranel.value)
       End Get
       Set(ByVal value As Int32)
           m_id_articuloGranel.value = value
       End Set
   End Property

   Public Property fase() As Int32
       Get
           Return if(isdbnull(m_fase.value), Nothing, m_fase.value)
       End Get
       Set(ByVal value As Int32)
           m_fase.value = value
       End Set
   End Property

   Public Property analizar() As Boolean
       Get
           Return if(isdbnull(m_analizar.value), false, m_analizar.value)
       End Get
       Set(ByVal value As Boolean)
           m_analizar.value = value
       End Set
    End Property

    Public Property SobreTerminado() As Boolean
        Get
            Return if(IsDBNull(m_sobre_terminado.value), False, m_sobre_terminado.value)
        End Get
        Set(ByVal value As Boolean)
            m_sobre_terminado.value = value
        End Set
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_id_articuloGranel, m_id_articuloGranel.sqlName)
       MyBase.atributos.Add(m_fase, m_fase.sqlName)
        MyBase.atributos.Add(m_analizar, m_analizar.sqlName)
        MyBase.atributos.Add(m_sobre_terminado, m_sobre_terminado.sqlName)
   End Sub
End Class
