Public Class DBO_Envasados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Efectividad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ObservacionesEnvasado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@EnvasadoID","EnvasadoID")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_Efectividad= New BasesParaCompatibilidad.DataBussinesParameter("@Efectividad","Efectividad")
       m_ObservacionesEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@ObservacionesEnvasado","ObservacionesEnvasado")
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

    Public Property Fecha() As Date
        Get
            Return If(IsDBNull(m_Fecha.value), Today.Date, m_Fecha.value)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property

   Public Property Efectividad() As String
       Get
           Return if(isdbnull(m_Efectividad.value), Nothing, m_Efectividad.value)
       End Get
       Set(ByVal value As String)
           m_Efectividad.value = value
       End Set
   End Property

   Public Property ObservacionesEnvasado() As String
       Get
           Return if(isdbnull(m_ObservacionesEnvasado.value), String.empty, m_ObservacionesEnvasado.value)
       End Get
       Set(ByVal value As String)
           m_ObservacionesEnvasado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_Efectividad, m_Efectividad.sqlName)
       MyBase.atributos.Add(m_ObservacionesEnvasado, m_ObservacionesEnvasado.sqlName)
   End Sub
End Class
