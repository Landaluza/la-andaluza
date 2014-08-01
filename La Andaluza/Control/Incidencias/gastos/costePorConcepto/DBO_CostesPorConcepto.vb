Public Class DBO_CostesPorConcepto
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_ConceptosGastosIncidencias As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Coste As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_ConceptosGastosIncidencias= New BasesParaCompatibilidad.DataBussinesParameter("@Id_ConceptosGastosIncidencias","Id_ConceptosGastosIncidencias")
       m_Coste= New BasesParaCompatibilidad.DataBussinesParameter("@Coste","Coste")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Integer
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,integer)
       End Get
       Set(ByVal value As Integer)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property Id_ConceptosGastosIncidencias() As Integer
       Get
           if m_Id_ConceptosGastosIncidencias.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_ConceptosGastosIncidencias.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_ConceptosGastosIncidencias.value = value
       End Set
   End Property

    Public Property Coste() As Double
        Get
            If m_Coste.value Is Convert.DBNull Then
                Return 0
            End If
            Return m_Coste.value
        End Get
        Set(ByVal value As Double)
            m_Coste.value = value
        End Set
    End Property

   Public Property Fecha() As DateTime
       Get
           if m_Fecha.value is convert.dbnull then
                Return Now.Date
            End If
            Return m_Fecha.value
       End Get
       Set(ByVal value As DateTime)
           m_Fecha.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_ConceptosGastosIncidencias, m_Id_ConceptosGastosIncidencias.sqlName)
       MyBase.atributos.Add(m_Coste, m_Coste.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
   End Sub
End Class
