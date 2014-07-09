Public Class DBO_ProtocolosMedicos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Referencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaFinal As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Medico As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Vigente As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ProtocoloMedicoID","ProtocoloMedicoID")
       m_Referencia= New BasesParaCompatibilidad.DataBussinesParameter("@Referencia","Referencia")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_FechaInicio= New BasesParaCompatibilidad.DataBussinesParameter("@FechaInicio","FechaInicio")
       m_FechaFinal= New BasesParaCompatibilidad.DataBussinesParameter("@FechaFinal","FechaFinal")
       m_Medico= New BasesParaCompatibilidad.DataBussinesParameter("@Medico","Medico")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_Vigente= New BasesParaCompatibilidad.DataBussinesParameter("@Vigente","Vigente")
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

   Public Property Referencia() As String
       Get
           Return if(isdbnull(m_Referencia.value), String.empty, m_Referencia.value)
       End Get
       Set(ByVal value As String)
           m_Referencia.value = value
       End Set
   End Property

   Public Property Descripcion() As String
       Get
           Return if(isdbnull(m_Descripcion.value), String.empty, m_Descripcion.value)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

    Public Property FechaInicio() As Date
        Get
            Return If(IsDBNull(m_FechaInicio.value), Today.Date, m_FechaInicio.value)
        End Get
        Set(ByVal value As Date)
            m_FechaInicio.value = value
        End Set
    End Property

    Public Property FechaFinal() As Date
        Get
            Return If(IsDBNull(m_FechaFinal.value), Today.Date, m_FechaFinal.value)
        End Get
        Set(ByVal value As Date)
            m_FechaFinal.value = value
        End Set
    End Property

   Public Property Medico() As Int32
       Get
           Return if(isdbnull(m_Medico.value), Nothing, m_Medico.value)
       End Get
       Set(ByVal value As Int32)
           m_Medico.value = value
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

   Public Property Vigente() As Boolean
       Get
           Return if(isdbnull(m_Vigente.value), false, m_Vigente.value)
       End Get
       Set(ByVal value As Boolean)
           m_Vigente.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Referencia, m_Referencia.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_FechaInicio, m_FechaInicio.sqlName)
       MyBase.atributos.Add(m_FechaFinal, m_FechaFinal.sqlName)
       MyBase.atributos.Add(m_Medico, m_Medico.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_Vigente, m_Vigente.sqlName)
   End Sub
End Class
