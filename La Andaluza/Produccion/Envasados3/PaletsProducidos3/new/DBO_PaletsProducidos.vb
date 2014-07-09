Public Class DBO_PaletsProducidos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_SCC As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FormatoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ObservacionesPalets As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Terminado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_EnAlmacen As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_Estado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Multilote As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@PaletProducidoID","PaletProducidoID")
       m_SCC= New BasesParaCompatibilidad.DataBussinesParameter("@SCC","SCC")
       m_FormatoID= New BasesParaCompatibilidad.DataBussinesParameter("@FormatoID","FormatoID")
       m_ObservacionesPalets= New BasesParaCompatibilidad.DataBussinesParameter("@ObservacionesPalets","ObservacionesPalets")
       m_Terminado= New BasesParaCompatibilidad.DataBussinesParameter("@Terminado","Terminado")
       m_EnAlmacen= New BasesParaCompatibilidad.DataBussinesParameter("@EnAlmacen","EnAlmacen")
       m_Id_Estado= New BasesParaCompatibilidad.DataBussinesParameter("@Id_Estado","Id_Estado")
       m_Multilote= New BasesParaCompatibilidad.DataBussinesParameter("@Multilote","Multilote")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return if(Convert.IsDBNull(m_id.value), Nothing, m_id.value)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property SCC() As Int32
        Get
            Return if(Convert.IsDBNull(m_SCC.value), Nothing, m_SCC.value)
        End Get
        Set(ByVal value As Int32)
            m_SCC.value = value
        End Set
    End Property

    Public Property FormatoID() As Int32
        Get
            Return if(Convert.IsDBNull(m_FormatoID.value), Nothing, m_FormatoID.value)
        End Get
        Set(ByVal value As Int32)
            m_FormatoID.value = value
        End Set
    End Property

    Public Property ObservacionesPalets() As String
        Get
            Return if(Convert.IsDBNull(m_ObservacionesPalets.value), String.empty, m_ObservacionesPalets.value)
        End Get
        Set(ByVal value As String)
            m_ObservacionesPalets.value = value
        End Set
    End Property

    Public Property Terminado() As Boolean
        Get
            Return if(Convert.IsDBNull(m_Terminado.value), False, m_Terminado.value)
        End Get
        Set(ByVal value As Boolean)
            m_Terminado.value = value
        End Set
    End Property

    Public Property EnAlmacen() As Boolean
        Get
            Return if(Convert.IsDBNull(m_EnAlmacen.value), False, m_EnAlmacen.value)
        End Get
        Set(ByVal value As Boolean)
            m_EnAlmacen.value = value
        End Set
    End Property

    Public Property Id_Estado() As Int32
        Get
            Return if(Convert.IsDBNull(m_Id_Estado.value), Nothing, m_Id_Estado.value)
        End Get
        Set(ByVal value As Int32)
            m_Id_Estado.value = value
        End Set
    End Property

    Public Property Multilote() As Boolean
        Get
            Return if(Convert.IsDBNull(m_Multilote.value), False, m_Multilote.value)
        End Get
        Set(ByVal value As Boolean)
            m_Multilote.value = value
        End Set
    End Property

'<Tag=[Two][End]> -- please do not remove this line

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_SCC, m_SCC.sqlName)
       MyBase.atributos.Add(m_FormatoID, m_FormatoID.sqlName)
       MyBase.atributos.Add(m_ObservacionesPalets, m_ObservacionesPalets.sqlName)
       MyBase.atributos.Add(m_Terminado, m_Terminado.sqlName)
       MyBase.atributos.Add(m_EnAlmacen, m_EnAlmacen.sqlName)
       MyBase.atributos.Add(m_Id_Estado, m_Id_Estado.sqlName)
       MyBase.atributos.Add(m_Multilote, m_Multilote.sqlName)
   End Sub
End Class
