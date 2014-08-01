Public Class DBO_GastosIncidencias
Inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_controlIncidencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Cantidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_concepto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_costeConcepto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_proveedor As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_cliente As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_controlIncidencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_controlIncidencia","Id_controlIncidencia")
       m_Cantidad= New BasesParaCompatibilidad.DataBussinesParameter("@Cantidad","Cantidad")
       m_Id_concepto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_concepto","Id_concepto")
       m_Id_costeConcepto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_costeConcepto","Id_costeConcepto")
       m_Id_proveedor= New BasesParaCompatibilidad.DataBussinesParameter("@Id_proveedor","Id_proveedor")
       m_Id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_empleado","Id_empleado")
       m_Id_cliente= New BasesParaCompatibilidad.DataBussinesParameter("@Id_cliente","Id_cliente")
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

   Public Property Id_controlIncidencia() As Integer
       Get
           if m_Id_controlIncidencia.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_controlIncidencia.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_controlIncidencia.value = value
       End Set
   End Property

    Public Property Cantidad() As Double
        Get
            If m_Cantidad.value Is Convert.DBNull Then
                Return 0
            End If
            Return m_Cantidad.value
        End Get
        Set(ByVal value As Double)
            m_Cantidad.value = value
        End Set
    End Property

   Public Property Id_concepto() As Integer
       Get
           if m_Id_concepto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_concepto.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_concepto.value = value
       End Set
   End Property

   Public Property Id_costeConcepto() As Integer
       Get
           if m_Id_costeConcepto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_costeConcepto.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_costeConcepto.value = value
       End Set
   End Property

   Public Property Id_proveedor() As Integer
       Get
           if m_Id_proveedor.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_proveedor.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_proveedor.value = value
       End Set
   End Property

   Public Property Id_empleado() As Integer
       Get
           if m_Id_empleado.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_empleado.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_empleado.value = value
       End Set
   End Property

   Public Property Id_cliente() As Integer
       Get
           if m_Id_cliente.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_cliente.value,integer)
       End Get
       Set(ByVal value As Integer)
           m_Id_cliente.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_controlIncidencia, m_Id_controlIncidencia.sqlName)
       MyBase.atributos.Add(m_Cantidad, m_Cantidad.sqlName)
       MyBase.atributos.Add(m_Id_concepto, m_Id_concepto.sqlName)
       MyBase.atributos.Add(m_Id_costeConcepto, m_Id_costeConcepto.sqlName)
       MyBase.atributos.Add(m_Id_proveedor, m_Id_proveedor.sqlName)
       MyBase.atributos.Add(m_Id_empleado, m_Id_empleado.sqlName)
       MyBase.atributos.Add(m_Id_cliente, m_Id_cliente.sqlName)
   End Sub
End Class
