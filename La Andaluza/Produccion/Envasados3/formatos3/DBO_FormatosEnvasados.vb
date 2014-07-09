Public Class DBO_FormatosEnvasados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoFormatoEnvasadoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoFormatoLineaID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EnvasadoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_inicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_fin As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@FormatoEnvasadoID","FormatoEnvasadoID")
       m_TipoFormatoEnvasadoID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoFormatoEnvasadoID","TipoFormatoEnvasadoID")
       m_TipoFormatoLineaID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoFormatoLineaID","TipoFormatoLineaID")
       m_EnvasadoID= New BasesParaCompatibilidad.DataBussinesParameter("@EnvasadoID","EnvasadoID")
       m_inicio= New BasesParaCompatibilidad.DataBussinesParameter("@inicio","inicio")
       m_fin= New BasesParaCompatibilidad.DataBussinesParameter("@fin","fin")
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

   Public Property TipoFormatoEnvasadoID() As Int32
       Get
           Return if(isdbnull(m_TipoFormatoEnvasadoID.value), Nothing, m_TipoFormatoEnvasadoID.value)
       End Get
       Set(ByVal value As Int32)
           m_TipoFormatoEnvasadoID.value = value
       End Set
   End Property

   Public Property TipoFormatoLineaID() As Int32
       Get
           Return if(isdbnull(m_TipoFormatoLineaID.value), Nothing, m_TipoFormatoLineaID.value)
       End Get
       Set(ByVal value As Int32)
           m_TipoFormatoLineaID.value = value
       End Set
   End Property

   Public Property EnvasadoID() As Int32
       Get
            Return if(IsDBNull(m_EnvasadoID.value), Nothing, m_EnvasadoID.value)
       End Get
       Set(ByVal value As Int32)
           m_EnvasadoID.value = value
       End Set
   End Property

    Public Property inicio() As TimeSpan
        Get
            Return If(IsDBNull(m_inicio.value), DateTime.Now.TimeOfDay, m_inicio.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_inicio.value = value
        End Set
    End Property

    Public Property fin() As TimeSpan
        Get
            Return If(IsDBNull(m_fin.value), DateTime.Now.TimeOfDay, m_fin.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_fin.value = value
        End Set
    End Property

    Public ReadOnly Property fin_is_null() As Boolean
        Get
            Return if(IsDBNull(m_fin.value), True, False)
        End Get
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_TipoFormatoEnvasadoID, m_TipoFormatoEnvasadoID.sqlName)
       MyBase.atributos.Add(m_TipoFormatoLineaID, m_TipoFormatoLineaID.sqlName)
       MyBase.atributos.Add(m_EnvasadoID, m_EnvasadoID.sqlName)
       MyBase.atributos.Add(m_inicio, m_inicio.sqlName)
       MyBase.atributos.Add(m_fin, m_fin.sqlName)
   End Sub
End Class
