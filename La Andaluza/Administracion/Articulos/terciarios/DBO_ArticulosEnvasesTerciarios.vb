Public Class DBO_ArticulosEnvasesTerciarios
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ArticuloID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PaletTipoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Cajas As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CajasPorCapa As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Capas As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PesoIncluidoPalet As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CargarDos As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PermiteApilar As BasesParaCompatibilidad.DataBussinesParameter
   Private m_LlevaSCC As BasesParaCompatibilidad.DataBussinesParameter
   Private m_SccEtiquetaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_ArticuloEnvaseSecundario As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_PaletProducidoNoConforme As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_marca As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Ean13 As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ean14 As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_cabeceraEtiqueta As BasesParaCompatibilidad.DataBussinesParameter
   Private m_anosCaducidad As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloEnvaseTerciarioID","ArticuloEnvaseTerciarioID")
       m_ArticuloID= New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloID","ArticuloID")
       m_PaletTipoID= New BasesParaCompatibilidad.DataBussinesParameter("@PaletTipoID","PaletTipoID")
       m_Cajas= New BasesParaCompatibilidad.DataBussinesParameter("@Cajas","Cajas")
       m_CajasPorCapa= New BasesParaCompatibilidad.DataBussinesParameter("@CajasPorCapa","CajasPorCapa")
       m_Capas= New BasesParaCompatibilidad.DataBussinesParameter("@Capas","Capas")
       m_PesoIncluidoPalet= New BasesParaCompatibilidad.DataBussinesParameter("@PesoIncluidoPalet","PesoIncluidoPalet")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_CargarDos= New BasesParaCompatibilidad.DataBussinesParameter("@CargarDos","CargarDos")
       m_PermiteApilar= New BasesParaCompatibilidad.DataBussinesParameter("@PermiteApilar","PermiteApilar")
       m_LlevaSCC= New BasesParaCompatibilidad.DataBussinesParameter("@LlevaSCC","LlevaSCC")
       m_SccEtiquetaID= New BasesParaCompatibilidad.DataBussinesParameter("@SccEtiquetaID","SccEtiquetaID")
       m_id_ArticuloEnvaseSecundario= New BasesParaCompatibilidad.DataBussinesParameter("@id_ArticuloEnvaseSecundario","id_ArticuloEnvaseSecundario")
       m_id_PaletProducidoNoConforme= New BasesParaCompatibilidad.DataBussinesParameter("@id_PaletProducidoNoConforme","id_PaletProducidoNoConforme")
       m_id_marca= New BasesParaCompatibilidad.DataBussinesParameter("@id_marca","id_marca")
       m_Ean13= New BasesParaCompatibilidad.DataBussinesParameter("@Ean13","Ean13")
       m_ean14= New BasesParaCompatibilidad.DataBussinesParameter("@ean14","ean14")
       m_id_cabeceraEtiqueta= New BasesParaCompatibilidad.DataBussinesParameter("@id_cabeceraEtiqueta","id_cabeceraEtiqueta")
       m_anosCaducidad= New BasesParaCompatibilidad.DataBussinesParameter("@anosCaducidad","anosCaducidad")
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

   Public Property PaletTipoID() As Int32
       Get
           if m_PaletTipoID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_PaletTipoID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_PaletTipoID.value = value
       End Set
   End Property

   Public Property Cajas() As Int32
       Get
           if m_Cajas.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Cajas.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Cajas.value = value
       End Set
   End Property

   Public Property CajasPorCapa() As Int32
       Get
           if m_CajasPorCapa.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_CajasPorCapa.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_CajasPorCapa.value = value
       End Set
   End Property

   Public Property Capas() As Int32
       Get
           if m_Capas.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_Capas.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_Capas.value = value
       End Set
   End Property

   Public Property PesoIncluidoPalet() As Int32
       Get
           if m_PesoIncluidoPalet.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_PesoIncluidoPalet.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_PesoIncluidoPalet.value = value
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

   Public Property CargarDos() As Boolean
       Get
           if m_CargarDos.value is convert.dbnull then
             Return false
           End if
           Return ctype(m_CargarDos.value,boolean)
       End Get
       Set(ByVal value As Boolean)
           m_CargarDos.value = value
       End Set
   End Property

   Public Property PermiteApilar() As Int32
       Get
           if m_PermiteApilar.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_PermiteApilar.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_PermiteApilar.value = value
       End Set
   End Property

   Public Property LlevaSCC() As Int32
       Get
           if m_LlevaSCC.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_LlevaSCC.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_LlevaSCC.value = value
       End Set
   End Property

   Public Property SccEtiquetaID() As Int32
       Get
           if m_SccEtiquetaID.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_SccEtiquetaID.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_SccEtiquetaID.value = value
       End Set
   End Property

   Public Property id_ArticuloEnvaseSecundario() As Int32
       Get
           if m_id_ArticuloEnvaseSecundario.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_ArticuloEnvaseSecundario.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_ArticuloEnvaseSecundario.value = value
       End Set
   End Property

   Public Property id_PaletProducidoNoConforme() As Int32
       Get
           if m_id_PaletProducidoNoConforme.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_PaletProducidoNoConforme.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_PaletProducidoNoConforme.value = value
       End Set
   End Property

   Public Property id_marca() As Int32
       Get
           if m_id_marca.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_marca.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_marca.value = value
       End Set
   End Property

   Public Property Ean13() As String
       Get
           if m_Ean13.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_Ean13.value,string)
       End Get
       Set(ByVal value As String)
           m_Ean13.value = value
       End Set
   End Property

   Public Property ean14() As String
       Get
           if m_ean14.value is convert.dbnull then
             Return string.empty
           End if
           Return ctype(m_ean14.value,string)
       End Get
       Set(ByVal value As String)
           m_ean14.value = value
       End Set
   End Property

   Public Property id_cabeceraEtiqueta() As Int32
       Get
           if m_id_cabeceraEtiqueta.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_id_cabeceraEtiqueta.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_id_cabeceraEtiqueta.value = value
       End Set
   End Property

   Public Property anosCaducidad() As Int32
       Get
           if m_anosCaducidad.value is convert.dbnull then
             Return 0
           End if
           Return ctype(m_anosCaducidad.value,int32)
       End Get
       Set(ByVal value As Int32)
           m_anosCaducidad.value = value
       End Set
   End Property

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ArticuloID, m_ArticuloID.sqlName)
       MyBase.atributos.Add(m_PaletTipoID, m_PaletTipoID.sqlName)
       MyBase.atributos.Add(m_Cajas, m_Cajas.sqlName)
       MyBase.atributos.Add(m_CajasPorCapa, m_CajasPorCapa.sqlName)
       MyBase.atributos.Add(m_Capas, m_Capas.sqlName)
       MyBase.atributos.Add(m_PesoIncluidoPalet, m_PesoIncluidoPalet.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_CargarDos, m_CargarDos.sqlName)
       MyBase.atributos.Add(m_PermiteApilar, m_PermiteApilar.sqlName)
       MyBase.atributos.Add(m_LlevaSCC, m_LlevaSCC.sqlName)
       MyBase.atributos.Add(m_SccEtiquetaID, m_SccEtiquetaID.sqlName)
       MyBase.atributos.Add(m_id_ArticuloEnvaseSecundario, m_id_ArticuloEnvaseSecundario.sqlName)
       MyBase.atributos.Add(m_id_PaletProducidoNoConforme, m_id_PaletProducidoNoConforme.sqlName)
       MyBase.atributos.Add(m_id_marca, m_id_marca.sqlName)
       MyBase.atributos.Add(m_Ean13, m_Ean13.sqlName)
       MyBase.atributos.Add(m_ean14, m_ean14.sqlName)
       MyBase.atributos.Add(m_id_cabeceraEtiqueta, m_id_cabeceraEtiqueta.sqlName)
       MyBase.atributos.Add(m_anosCaducidad, m_anosCaducidad.sqlName)
   End Sub
End Class
