Public Class DBO_TiposFormatos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CodigoQS As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Separadores As BasesParaCompatibilidad.DataBussinesParameter
   Private m_CajasPalet As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Genericas As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Particulares As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoProductoID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_TipoCajaID As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@TipoFormatoID","TipoFormatoID")
       m_CodigoQS= New BasesParaCompatibilidad.DataBussinesParameter("@CodigoQS","CodigoQS")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Separadores= New BasesParaCompatibilidad.DataBussinesParameter("@Separadores","Separadores")
       m_CajasPalet= New BasesParaCompatibilidad.DataBussinesParameter("@CajasPalet","CajasPalet")
       m_Genericas= New BasesParaCompatibilidad.DataBussinesParameter("@Genericas","Genericas")
       m_Particulares= New BasesParaCompatibilidad.DataBussinesParameter("@Particulares","Particulares")
       m_TipoProductoID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoProductoID","TipoProductoID")
       m_TipoCajaID= New BasesParaCompatibilidad.DataBussinesParameter("@TipoCajaID","TipoCajaID")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return iif(Convert.IsDBNull(m_Id.value), Nothing, m_Id.value)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property CodigoQS() As Int32
        Get
            Return iif(Convert.IsDBNull(m_CodigoQS.value), Nothing, m_CodigoQS.value)
        End Get
        Set(ByVal value As Int32)
            m_CodigoQS.value = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return iif(Convert.IsDBNull(m_Descripcion.value), String.empty, m_Descripcion.value)
        End Get
        Set(ByVal value As String)
            m_Descripcion.value = value
        End Set
    End Property

    Public Property Separadores() As Int32
        Get
            Return iif(Convert.IsDBNull(m_Separadores.value), Nothing, m_Separadores.value)
        End Get
        Set(ByVal value As Int32)
            m_Separadores.value = value
        End Set
    End Property

    Public Property CajasPalet() As Int32
        Get
            Return iif(Convert.IsDBNull(m_CajasPalet.value), Nothing, m_CajasPalet.value)
        End Get
        Set(ByVal value As Int32)
            m_CajasPalet.value = value
        End Set
    End Property

    Public Property Genericas() As String
        Get
            Return iif(Convert.IsDBNull(m_Genericas.value), String.empty, m_Genericas.value)
        End Get
        Set(ByVal value As String)
            m_Genericas.value = value
        End Set
    End Property

    Public Property Particulares() As String
        Get
            Return iif(Convert.IsDBNull(m_Particulares.value), String.empty, m_Particulares.value)
        End Get
        Set(ByVal value As String)
            m_Particulares.value = value
        End Set
    End Property

    Public Property TipoProductoID() As Int32
        Get
            Return iif(Convert.IsDBNull(m_TipoProductoID.value), Nothing, m_TipoProductoID.value)
        End Get
        Set(ByVal value As Int32)
            m_TipoProductoID.value = value
        End Set
    End Property

    Public Property TipoCajaID() As Int32
        Get
            Return iif(Convert.IsDBNull(m_TipoCajaID.value), Nothing, m_TipoCajaID.value)
        End Get
        Set(ByVal value As Int32)
            m_TipoCajaID.value = value
        End Set
    End Property

'<Tag=[Two][End]> -- please do not remove this line

   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_CodigoQS, m_CodigoQS.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Separadores, m_Separadores.sqlName)
       MyBase.atributos.Add(m_CajasPalet, m_CajasPalet.sqlName)
       MyBase.atributos.Add(m_Genericas, m_Genericas.sqlName)
       MyBase.atributos.Add(m_Particulares, m_Particulares.sqlName)
       MyBase.atributos.Add(m_TipoProductoID, m_TipoProductoID.sqlName)
       MyBase.atributos.Add(m_TipoCajaID, m_TipoCajaID.sqlName)
   End Sub
End Class
