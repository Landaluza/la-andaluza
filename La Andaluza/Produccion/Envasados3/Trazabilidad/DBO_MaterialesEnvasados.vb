Public Class DBO_MaterialesEnvasados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraFin As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Lote As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Cantidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoMaterialID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ProveedorID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FormatoEnvasadoID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@MaterialEnvasadoID","MaterialEnvasadoID")
       m_HoraInicio= New BasesParaCompatibilidad.DataBussinesParameter("@HoraInicio","HoraInicio")
       m_HoraFin= New BasesParaCompatibilidad.DataBussinesParameter("@HoraFin","HoraFin")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_Lote= New BasesParaCompatibilidad.DataBussinesParameter("@Lote","Lote")
       m_Cantidad= New BasesParaCompatibilidad.DataBussinesParameter("@Cantidad","Cantidad")
       m_TipoMaterialID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoMaterialID","TipoMaterialID")
       m_ProveedorID= New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorID","ProveedorID")
       m_FormatoEnvasadoID= New BasesParaCompatibilidad.DataBussinesParameter("@FormatoEnvasadoID","FormatoEnvasadoID")
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

    Public Property HoraInicio() As TimeSpan
        Get
            Return If(IsDBNull(m_HoraInicio.value), Today.Date, m_HoraInicio.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio.value = value
        End Set
    End Property

    Public Property HoraFin() As TimeSpan
        Get
            Return If(IsDBNull(m_HoraFin.value), Today.Date, m_HoraFin.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFin.value = value
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

   Public Property Lote() As String
       Get
           Return if(isdbnull(m_Lote.value), String.empty, m_Lote.value)
       End Get
       Set(ByVal value As String)
           m_Lote.value = value
       End Set
   End Property

   Public Property Cantidad() As Int32
       Get
           Return if(isdbnull(m_Cantidad.value), Nothing, m_Cantidad.value)
       End Get
       Set(ByVal value As Int32)
           m_Cantidad.value = value
       End Set
   End Property

   Public Property TipoMaterialID() As Int32
       Get
           Return if(isdbnull(m_TipoMaterialID.value), Nothing, m_TipoMaterialID.value)
       End Get
       Set(ByVal value As Int32)
           m_TipoMaterialID.value = value
       End Set
   End Property

   Public Property ProveedorID() As Int32
       Get
           Return if(isdbnull(m_ProveedorID.value), Nothing, m_ProveedorID.value)
       End Get
       Set(ByVal value As Int32)
           m_ProveedorID.value = value
       End Set
   End Property

   Public Property FormatoEnvasadoID() As Int32
       Get
           Return if(isdbnull(m_FormatoEnvasadoID.value), Nothing, m_FormatoEnvasadoID.value)
       End Get
       Set(ByVal value As Int32)
           m_FormatoEnvasadoID.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_HoraInicio, m_HoraInicio.sqlName)
       MyBase.atributos.Add(m_HoraFin, m_HoraFin.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_Lote, m_Lote.sqlName)
       MyBase.atributos.Add(m_Cantidad, m_Cantidad.sqlName)
       MyBase.atributos.Add(m_TipoMaterialID, m_TipoMaterialID.sqlName)
       MyBase.atributos.Add(m_ProveedorID, m_ProveedorID.sqlName)
       MyBase.atributos.Add(m_FormatoEnvasadoID, m_FormatoEnvasadoID.sqlName)
   End Sub
End Class
