Public Class DBO_PaletsContenidos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraInicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_HoraFin As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CantidadCajas As BasesParaCompatibilidad.DataBussinesParameter
   Private m_PaletProducidoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_formatoEnvasado As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PaletContenidoID","PaletContenidoID")
       m_HoraInicio= New BasesParaCompatibilidad.DataBussinesParameter("@HoraInicio","HoraInicio")
       m_HoraFin= New BasesParaCompatibilidad.DataBussinesParameter("@HoraFin","HoraFin")
       m_CantidadCajas= New BasesParaCompatibilidad.DataBussinesParameter("@CantidadCajas","CantidadCajas")
       m_PaletProducidoID= New BasesParaCompatibilidad.DataBussinesParameter("@PaletProducidoID","PaletProducidoID")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_id_formatoEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@id_formatoEnvasado","id_formatoEnvasado")
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
            Return If(IsDBNull(m_HoraInicio.value), Today.TimeOfDay, m_HoraInicio.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraInicio.value = value
        End Set
    End Property

    Public Property HoraFin() As TimeSpan
        Get
            Return If(IsDBNull(m_HoraFin.value), Today.TimeOfDay, m_HoraFin.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_HoraFin.value = value
        End Set
    End Property

   Public Property CantidadCajas() As Int32
       Get
           Return if(isdbnull(m_CantidadCajas.value), Nothing, m_CantidadCajas.value)
       End Get
       Set(ByVal value As Int32)
           m_CantidadCajas.value = value
       End Set
   End Property

   Public Property PaletProducidoID() As Int32
       Get
           Return if(isdbnull(m_PaletProducidoID.value), Nothing, m_PaletProducidoID.value)
       End Get
       Set(ByVal value As Int32)
           m_PaletProducidoID.value = value
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

   Public Property id_formatoEnvasado() As Int32
       Get
           Return if(isdbnull(m_id_formatoEnvasado.value), Nothing, m_id_formatoEnvasado.value)
       End Get
       Set(ByVal value As Int32)
           m_id_formatoEnvasado.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_HoraInicio, m_HoraInicio.sqlName)
       MyBase.atributos.Add(m_HoraFin, m_HoraFin.sqlName)
       MyBase.atributos.Add(m_CantidadCajas, m_CantidadCajas.sqlName)
       MyBase.atributos.Add(m_PaletProducidoID, m_PaletProducidoID.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_id_formatoEnvasado, m_id_formatoEnvasado.sqlName)
   End Sub
End Class
