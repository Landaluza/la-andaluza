Public Class DBO_PeriodosServicio
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MotivoCeseServicioID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Desde As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Hasta As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorIDArticuloID","ProveedorIDArticuloID")
       m_MotivoCeseServicioID= New BasesParaCompatibilidad.DataBussinesParameter("@MotivoCeseServicioID","MotivoCeseServicioID")
       m_Desde= New BasesParaCompatibilidad.DataBussinesParameter("@Desde","Desde")
       m_Hasta= New BasesParaCompatibilidad.DataBussinesParameter("@Hasta","Hasta")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub

   Public Property ID() As Int32
       Get
           if m_id.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id.value,int32)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property MotivoCeseServicioID() As Int32
       Get
           if m_MotivoCeseServicioID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MotivoCeseServicioID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_MotivoCeseServicioID.value = value
       End Set
   End Property

    Public Property Desde() As Date
        Get
            If m_Desde.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_Desde.value, Date)
        End Get
        Set(ByVal value As Date)
            m_Desde.value = value
        End Set
    End Property

    Public Property Hasta() As Date
        Get
            If m_Hasta.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_Hasta.value, Date)
        End Get
        Set(ByVal value As Date)
            m_Hasta.value = value
        End Set
    End Property

   Public Property Observaciones() As String
       Get
           if m_Observaciones.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Observaciones.value,string)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_MotivoCeseServicioID, m_MotivoCeseServicioID.sqlName)
       MyBase.atributos.Add(m_Desde, m_Desde.sqlName)
       MyBase.atributos.Add(m_Hasta, m_Hasta.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
