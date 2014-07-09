Public Class DBO_PaletsTipos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CodigoQS As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Largo As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Ancho As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Alto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Peso As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Material As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Tratado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Alias As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PaletTipoID","PaletTipoID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_CodigoQS= New BasesParaCompatibilidad.DataBussinesParameter("@CodigoQS","CodigoQS")
       m_Largo= New BasesParaCompatibilidad.DataBussinesParameter("@Largo","Largo")
       m_Ancho= New BasesParaCompatibilidad.DataBussinesParameter("@Ancho","Ancho")
       m_Alto= New BasesParaCompatibilidad.DataBussinesParameter("@Alto","Alto")
       m_Peso= New BasesParaCompatibilidad.DataBussinesParameter("@Peso","Peso")
       m_Material= New BasesParaCompatibilidad.DataBussinesParameter("@Material","Material")
       m_Tratado= New BasesParaCompatibilidad.DataBussinesParameter("@Tratado","Tratado")
       m_Alias= New BasesParaCompatibilidad.DataBussinesParameter("@Alias","Alias")
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

   Public Property CodigoQS() As Int32
       Get
           if m_CodigoQS.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CodigoQS.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_CodigoQS.value = value
       End Set
   End Property

   Public Property Largo() As String
       Get
           if m_Largo.value is convert.dbnull then
             Return 0
           End if
            Return CType(m_Largo.value, Double)
        End Get
        Set(ByVal value As String)
            m_Largo.value = value
        End Set
    End Property

    Public Property Ancho() As String
        Get
            If m_Ancho.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_Ancho.value, Double)
        End Get
        Set(ByVal value As String)
            m_Ancho.value = value
        End Set
    End Property

    Public Property Alto() As String
        Get
            If m_Alto.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_Alto.value, Double)
        End Get
        Set(ByVal value As String)
            m_Alto.value = value
        End Set
    End Property

    Public Property Peso() As String
        Get
            If m_Peso.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_Peso.value, Double)
        End Get
        Set(ByVal value As String)
            m_Peso.value = value
        End Set
    End Property

   Public Property Material() As String
       Get
           if m_Material.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Material.value,string)
       End Get
       Set(ByVal value As String)
           m_Material.value = value
       End Set
   End Property

   Public Property Tratado() As Boolean
       Get
           if m_Tratado.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_Tratado.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_Tratado.value = value
       End Set
   End Property

    Public Property Aliass() As String
        Get
            If m_Alias.value Is convert.dbnull Then
                Return String.empty
            End If
            Return CType(m_Alias.value, String)
        End Get
        Set(ByVal value As String)
            m_Alias.value = value
        End Set
    End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
       MyBase.atributos.Add(m_Largo, m_Largo.sqlName)
       MyBase.atributos.Add(m_Ancho, m_Ancho.sqlName)
       MyBase.atributos.Add(m_Alto, m_Alto.sqlName)
       MyBase.atributos.Add(m_Peso, m_Peso.sqlName)
       MyBase.atributos.Add(m_Material, m_Material.sqlName)
       MyBase.atributos.Add(m_Tratado, m_Tratado.sqlName)
       MyBase.atributos.Add(m_Alias, m_Alias.sqlName)
   End Sub
End Class
