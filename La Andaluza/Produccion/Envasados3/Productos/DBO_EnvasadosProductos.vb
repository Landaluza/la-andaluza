Public Class DBO_EnvasadosProductos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EnvasadoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProductoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraFinal As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@EnvasadoProductoID","EnvasadoProductoID")
       m_EnvasadoID= New BasesParaCompatibilidad.DataBussinesParameter("@EnvasadoID","EnvasadoID")
       m_ProductoID= New BasesParaCompatibilidad.DataBussinesParameter("@ProductoID","ProductoID")
       m_HoraInicio= New BasesParaCompatibilidad.DataBussinesParameter("@HoraInicio","HoraInicio")
       m_HoraFinal= New BasesParaCompatibilidad.DataBussinesParameter("@HoraFinal","HoraFinal")
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

   Public Property EnvasadoID() As Int32
       Get
           if m_EnvasadoID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_EnvasadoID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_EnvasadoID.value = value
       End Set
   End Property

   Public Property ProductoID() As Int32
       Get
           if m_ProductoID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_ProductoID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_ProductoID.value = value
       End Set
   End Property

    Public Property HoraInicio() As TimeSpan
        Get
            If m_HoraInicio.value Is Convert.DBNull Then
                Return Today.TimeOfDay
            End If
            Return CType(m_HoraInicio.value, TimeSpan)
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio.value = value
        End Set
    End Property

    Public Property HoraFinal() As TimeSpan
        Get
            If m_HoraFinal.value Is Convert.DBNull Then
                Return Today.TimeOfDay
            End If
            Return CType(m_HoraFinal.value, TimeSpan)
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFinal.value = value
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
       MyBase.atributos.Add(m_EnvasadoID, m_EnvasadoID.sqlName)
       MyBase.atributos.Add(m_ProductoID, m_ProductoID.sqlName)
       MyBase.atributos.Add(m_HoraInicio, m_HoraInicio.sqlName)
       MyBase.atributos.Add(m_HoraFinal, m_HoraFinal.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
