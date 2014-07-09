Public Class DBO_ControlesLotes
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_lote As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_plantillaControlLote As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Resultado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Correcto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_RutaControl As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_controlIncidencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ID","ID")
       m_Id_lote= New BasesParaCompatibilidad.DataBussinesParameter("@Id_lote","Id_lote")
       m_Id_plantillaControlLote= New BasesParaCompatibilidad.DataBussinesParameter("@Id_plantillaControlLote","Id_plantillaControlLote")
       m_Resultado= New BasesParaCompatibilidad.DataBussinesParameter("@Resultado","Resultado")
       m_Correcto= New BasesParaCompatibilidad.DataBussinesParameter("@Correcto","Correcto")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_RutaControl= New BasesParaCompatibilidad.DataBussinesParameter("@RutaControl","RutaControl")
       m_Id_controlIncidencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_controlIncidencia","Id_controlIncidencia")
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

   Public Property Id_lote() As Int32
       Get
           if m_Id_lote.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_lote.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_lote.value = value
       End Set
   End Property

   Public Property Id_plantillaControlLote() As Int32
       Get
           if m_Id_plantillaControlLote.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_plantillaControlLote.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_plantillaControlLote.value = value
       End Set
   End Property

   Public Property Resultado() As String
       Get
           if m_Resultado.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Resultado.value,string)
       End Get
       Set(ByVal value As String)
           m_Resultado.value = value
       End Set
   End Property

   Public Property Correcto() As Boolean
       Get
           if m_Correcto.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Correcto.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Correcto.value = value
       End Set
   End Property

   Public Property Id_empleado() As Int32
       Get
           if m_Id_empleado.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_empleado.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_empleado.value = value
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

   Public Property RutaControl() As String
       Get
           if m_RutaControl.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_RutaControl.value,string)
       End Get
       Set(ByVal value As String)
           m_RutaControl.value = value
       End Set
   End Property

   Public Property Id_controlIncidencia() As Int32
       Get
           if m_Id_controlIncidencia.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_controlIncidencia.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_controlIncidencia.value = value
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
       MyBase.atributos.Add(m_Id_lote, m_Id_lote.sqlName)
       MyBase.atributos.Add(m_Id_plantillaControlLote, m_Id_plantillaControlLote.sqlName)
       MyBase.atributos.Add(m_Resultado, m_Resultado.sqlName)
       MyBase.atributos.Add(m_Correcto, m_Correcto.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_RutaControl, m_RutaControl.sqlName)
       MyBase.atributos.Add(m_Id_controlIncidencia, m_Id_controlIncidencia.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
   End Sub
End Class
