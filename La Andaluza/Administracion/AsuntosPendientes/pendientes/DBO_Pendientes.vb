Public Class DBO_Pendientes
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Terminada As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoPendiente As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Proveedor As BasesParaCompatibilidad.DataBussinesParameter
   Private m_NumeroDocumento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaDocumento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RutaDocumento As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ResponsableID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PendienteID","PendienteID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_Terminada= New BasesParaCompatibilidad.DataBussinesParameter("@Terminada","Terminada")
       m_TipoPendiente= New BasesParaCompatibilidad.DataBussinesParameter("@TipoPendiente","TipoPendiente")
       m_Proveedor= New BasesParaCompatibilidad.DataBussinesParameter("@Proveedor","Proveedor")
       m_NumeroDocumento= New BasesParaCompatibilidad.DataBussinesParameter("@NumeroDocumento","NumeroDocumento")
       m_FechaDocumento= New BasesParaCompatibilidad.DataBussinesParameter("@FechaDocumento","FechaDocumento")
       m_RutaDocumento= New BasesParaCompatibilidad.DataBussinesParameter("@RutaDocumento","RutaDocumento")
       m_ResponsableID= New BasesParaCompatibilidad.DataBussinesParameter("@ResponsableID","ResponsableID")
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

   Public Property Descripcion() As String
       Get
           if m_Descripcion.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Descripcion.value,string)
       End Get
       Set(ByVal value As String)
           m_Descripcion.value = value
       End Set
   End Property

    Public Property Fecha() As Date
        Get
            If m_Fecha.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_Fecha.value, Date)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property

   Public Property Terminada() As Boolean
       Get
           if m_Terminada.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Terminada.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Terminada.value = value
       End Set
   End Property

   Public Property TipoPendiente() As Int32
       Get
           if m_TipoPendiente.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_TipoPendiente.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_TipoPendiente.value = value
       End Set
   End Property

   Public Property Proveedor() As Int32
       Get
           if m_Proveedor.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Proveedor.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Proveedor.value = value
       End Set
   End Property

   Public Property NumeroDocumento() As String
       Get
           if m_NumeroDocumento.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_NumeroDocumento.value,string)
       End Get
       Set(ByVal value As String)
           m_NumeroDocumento.value = value
       End Set
   End Property

    Public Property FechaDocumento() As Date
        Get
            If m_FechaDocumento.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_FechaDocumento.value, Date)
        End Get
        Set(ByVal value As Date)
            m_FechaDocumento.value = value
        End Set
    End Property

   Public Property RutaDocumento() As String
       Get
           if m_RutaDocumento.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_RutaDocumento.value,string)
       End Get
       Set(ByVal value As String)
           m_RutaDocumento.value = value
       End Set
   End Property

   Public Property ResponsableID() As Int32
       Get
           if m_ResponsableID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_ResponsableID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_ResponsableID.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_Terminada, m_Terminada.sqlName)
       MyBase.atributos.Add(m_TipoPendiente, m_TipoPendiente.sqlName)
       MyBase.atributos.Add(m_Proveedor, m_Proveedor.sqlName)
       MyBase.atributos.Add(m_NumeroDocumento, m_NumeroDocumento.sqlName)
       MyBase.atributos.Add(m_FechaDocumento, m_FechaDocumento.sqlName)
       MyBase.atributos.Add(m_RutaDocumento, m_RutaDocumento.sqlName)
       MyBase.atributos.Add(m_ResponsableID, m_ResponsableID.sqlName)
   End Sub
End Class
