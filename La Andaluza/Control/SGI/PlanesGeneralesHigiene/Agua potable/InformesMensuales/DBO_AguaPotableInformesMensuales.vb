Public Class DBO_AguaPotableInformesMensuales
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CreadorID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_VerificadorID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Periodo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Ruta As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@InformeMensualID","InformeMensualID")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_CreadorID= New BasesParaCompatibilidad.DataBussinesParameter("@CreadorID","CreadorID")
       m_VerificadorID= New BasesParaCompatibilidad.DataBussinesParameter("@VerificadorID","VerificadorID")
       m_Periodo= New BasesParaCompatibilidad.DataBussinesParameter("@Periodo","Periodo")
       m_Ruta= New BasesParaCompatibilidad.DataBussinesParameter("@Ruta","Ruta")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
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

   Public Property CreadorID() As Int32
       Get
           Return if(isdbnull(m_CreadorID.value), Nothing, m_CreadorID.value)
       End Get
       Set(ByVal value As Int32)
           m_CreadorID.value = value
       End Set
   End Property

   Public Property VerificadorID() As Int32
       Get
           Return if(isdbnull(m_VerificadorID.value), Nothing, m_VerificadorID.value)
       End Get
       Set(ByVal value As Int32)
           m_VerificadorID.value = value
       End Set
   End Property

   Public Property Periodo() As String
       Get
           Return if(isdbnull(m_Periodo.value), String.empty, m_Periodo.value)
       End Get
       Set(ByVal value As String)
           m_Periodo.value = value
       End Set
   End Property

   Public Property Ruta() As String
       Get
           Return if(isdbnull(m_Ruta.value), String.empty, m_Ruta.value)
       End Get
       Set(ByVal value As String)
           m_Ruta.value = value
       End Set
   End Property

   Public Property Observaciones() As String
       Get
           Return if(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_CreadorID, m_CreadorID.sqlName)
       MyBase.atributos.Add(m_VerificadorID, m_VerificadorID.sqlName)
       MyBase.atributos.Add(m_Periodo, m_Periodo.sqlName)
       MyBase.atributos.Add(m_Ruta, m_Ruta.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
