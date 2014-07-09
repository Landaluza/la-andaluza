Public Class DBO_ArticulosEnvasesSecundarios
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ArticuloID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProductoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CajaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Separadores As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CajasPalet As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Genericas As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Particulares As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Peso As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_articuloPrimario As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@EnvaseSecundarioID","EnvaseSecundarioID")
       m_ArticuloID= New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloID","ArticuloID")
       m_ProductoID= New BasesParaCompatibilidad.DataBussinesParameter("@ProductoID","ProductoID")
       m_CajaID= New BasesParaCompatibilidad.DataBussinesParameter("@CajaID","CajaID")
       m_Separadores= New BasesParaCompatibilidad.DataBussinesParameter("@Separadores","Separadores")
       m_CajasPalet= New BasesParaCompatibilidad.DataBussinesParameter("@CajasPalet","CajasPalet")
       m_Genericas= New BasesParaCompatibilidad.DataBussinesParameter("@Genericas","Genericas")
       m_Particulares= New BasesParaCompatibilidad.DataBussinesParameter("@Particulares","Particulares")
       m_Peso= New BasesParaCompatibilidad.DataBussinesParameter("@Peso","Peso")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_id_articuloPrimario= New BasesParaCompatibilidad.DataBussinesParameter("@id_articuloPrimario","id_articuloPrimario")
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

   Public Property CajaID() As Int32
       Get
           if m_CajaID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CajaID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_CajaID.value = value
       End Set
   End Property

   Public Property Separadores() As Int32
       Get
           if m_Separadores.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Separadores.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Separadores.value = value
       End Set
   End Property

   Public Property CajasPalet() As Int32
       Get
           if m_CajasPalet.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CajasPalet.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_CajasPalet.value = value
       End Set
   End Property

   Public Property Genericas() As String
       Get
           if m_Genericas.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Genericas.value,string)
       End Get
       Set(ByVal value As String)
           m_Genericas.value = value
       End Set
   End Property

   Public Property Particulares() As String
       Get
           if m_Particulares.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Particulares.value,string)
       End Get
       Set(ByVal value As String)
           m_Particulares.value = value
       End Set
   End Property

    Public Property Peso() As Double
        Get
            If m_Peso.value Is convert.dbnull Then
                Return 0
            End If
            Return CType(m_Peso.value, Double)
        End Get
        Set(ByVal value As Double)
            m_Peso.value = value
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

   Public Property id_articuloPrimario() As Int32
       Get
           if m_id_articuloPrimario.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_articuloPrimario.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_articuloPrimario.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ArticuloID, m_ArticuloID.sqlName)
       MyBase.atributos.Add(m_ProductoID, m_ProductoID.sqlName)
       MyBase.atributos.Add(m_CajaID, m_CajaID.sqlName)
       MyBase.atributos.Add(m_Separadores, m_Separadores.sqlName)
       MyBase.atributos.Add(m_CajasPalet, m_CajasPalet.sqlName)
       MyBase.atributos.Add(m_Genericas, m_Genericas.sqlName)
       MyBase.atributos.Add(m_Particulares, m_Particulares.sqlName)
       MyBase.atributos.Add(m_Peso, m_Peso.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_id_articuloPrimario, m_id_articuloPrimario.sqlName)
   End Sub
End Class
