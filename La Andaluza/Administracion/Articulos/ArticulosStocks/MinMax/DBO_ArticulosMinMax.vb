Public Class DBO_ArticulosMinMax
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ArticuloID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MinimoJR As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MaximoJR As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MinimoLA As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MaximoLA As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MinimoProveedor As BasesParaCompatibilidad.DataBussinesParameter
   Private m_MaximoProveedor As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaFinal As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Vigente As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloMinMaxID","ArticuloMinMaxID")
       m_ArticuloID= New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloID","ArticuloID")
       m_MinimoJR= New BasesParaCompatibilidad.DataBussinesParameter("@MinimoJR","MinimoJR")
       m_MaximoJR= New BasesParaCompatibilidad.DataBussinesParameter("@MaximoJR","MaximoJR")
       m_MinimoLA= New BasesParaCompatibilidad.DataBussinesParameter("@MinimoLA","MinimoLA")
       m_MaximoLA= New BasesParaCompatibilidad.DataBussinesParameter("@MaximoLA","MaximoLA")
       m_MinimoProveedor= New BasesParaCompatibilidad.DataBussinesParameter("@MinimoProveedor","MinimoProveedor")
       m_MaximoProveedor= New BasesParaCompatibilidad.DataBussinesParameter("@MaximoProveedor","MaximoProveedor")
       m_FechaInicio= New BasesParaCompatibilidad.DataBussinesParameter("@FechaInicio","FechaInicio")
       m_FechaFinal= New BasesParaCompatibilidad.DataBussinesParameter("@FechaFinal","FechaFinal")
       m_Vigente= New BasesParaCompatibilidad.DataBussinesParameter("@Vigente","Vigente")
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

   Public Property ArticuloID() As Int32
       Get
           if m_ArticuloID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_ArticuloID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_ArticuloID.value = value
       End Set
   End Property

   Public Property MinimoJR() As Int32
       Get
           if m_MinimoJR.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MinimoJR.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_MinimoJR.value = value
       End Set
   End Property

   Public Property MaximoJR() As Int32
       Get
           if m_MaximoJR.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MaximoJR.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_MaximoJR.value = value
       End Set
   End Property

   Public Property MinimoLA() As Int32
       Get
           if m_MinimoLA.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MinimoLA.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_MinimoLA.value = value
       End Set
   End Property

   Public Property MaximoLA() As Int32
       Get
           if m_MaximoLA.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MaximoLA.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_MaximoLA.value = value
       End Set
   End Property

   Public Property MinimoProveedor() As Int32
       Get
           if m_MinimoProveedor.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MinimoProveedor.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_MinimoProveedor.value = value
       End Set
   End Property

   Public Property MaximoProveedor() As Int32
       Get
           if m_MaximoProveedor.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_MaximoProveedor.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_MaximoProveedor.value = value
       End Set
   End Property

    Public Property FechaInicio() As Date
        Get
            If m_FechaInicio.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_FechaInicio.value, Date)
        End Get
        Set(ByVal value As Date)
            m_FechaInicio.value = value
        End Set
    End Property

    Public Property FechaFinal() As Date
        Get
            If m_FechaFinal.value Is Convert.DBNull Then
                Return Today.Date
            End If
            Return CType(m_FechaFinal.value, Date)
        End Get
        Set(ByVal value As Date)
            m_FechaFinal.value = value
        End Set
    End Property

   Public Property Vigente() As Boolean
       Get
           if m_Vigente.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Vigente.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Vigente.value = value
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
       MyBase.atributos.Add(m_ArticuloID, m_ArticuloID.sqlName)
       MyBase.atributos.Add(m_MinimoJR, m_MinimoJR.sqlName)
       MyBase.atributos.Add(m_MaximoJR, m_MaximoJR.sqlName)
       MyBase.atributos.Add(m_MinimoLA, m_MinimoLA.sqlName)
       MyBase.atributos.Add(m_MaximoLA, m_MaximoLA.sqlName)
       MyBase.atributos.Add(m_MinimoProveedor, m_MinimoProveedor.sqlName)
       MyBase.atributos.Add(m_MaximoProveedor, m_MaximoProveedor.sqlName)
       MyBase.atributos.Add(m_FechaInicio, m_FechaInicio.sqlName)
       MyBase.atributos.Add(m_FechaFinal, m_FechaFinal.sqlName)
       MyBase.atributos.Add(m_Vigente, m_Vigente.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
