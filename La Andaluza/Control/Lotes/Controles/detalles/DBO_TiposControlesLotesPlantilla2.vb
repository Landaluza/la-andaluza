Public Class DBO_TiposControlesLotesPlantilla2
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoControl As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoLote As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoProducto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_frecuencia As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Critico As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_procedimiento As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_TipoControl= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoControl","Id_TipoControl")
       m_Id_TipoLote= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoLote","Id_TipoLote")
       m_Id_TipoProducto= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoProducto","Id_TipoProducto")
       m_Id_frecuencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_frecuencia","Id_frecuencia")
       m_Critico= New BasesParaCompatibilidad.DataBussinesParameter("@Critico","Critico")
       m_Id_procedimiento= New BasesParaCompatibilidad.DataBussinesParameter("@Id_procedimiento","Id_procedimiento")
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

   Public Property Id_TipoControl() As Int32
       Get
           if m_Id_TipoControl.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_TipoControl.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_TipoControl.value = value
       End Set
   End Property

   Public Property Id_TipoLote() As Int32
       Get
           if m_Id_TipoLote.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_TipoLote.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_TipoLote.value = value
       End Set
   End Property

   Public Property Id_TipoProducto() As Int32
       Get
           if m_Id_TipoProducto.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_TipoProducto.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_TipoProducto.value = value
       End Set
   End Property

   Public Property Id_frecuencia() As Int32
       Get
           if m_Id_frecuencia.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_frecuencia.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_frecuencia.value = value
       End Set
   End Property

   Public Property Critico() As Boolean
       Get
           if m_Critico.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Critico.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Critico.value = value
       End Set
   End Property

   Public Property Id_procedimiento() As Int32
       Get
           if m_Id_procedimiento.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Id_procedimiento.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Id_procedimiento.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_TipoControl, m_Id_TipoControl.sqlName)
       MyBase.atributos.Add(m_Id_TipoLote, m_Id_TipoLote.sqlName)
       MyBase.atributos.Add(m_Id_TipoProducto, m_Id_TipoProducto.sqlName)
       MyBase.atributos.Add(m_Id_frecuencia, m_Id_frecuencia.sqlName)
       MyBase.atributos.Add(m_Critico, m_Critico.sqlName)
       MyBase.atributos.Add(m_Id_procedimiento, m_Id_procedimiento.sqlName)
   End Sub
End Class
