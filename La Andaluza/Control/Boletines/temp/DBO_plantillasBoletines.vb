Public Class DBO_plantillasBoletines
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_nombre As BasesParaCompatibilidad.DataBussinesParameter
   Private m_pie1 As BasesParaCompatibilidad.DataBussinesParameter
   Private m_pie2 As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_empresa As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Cabecera As BasesParaCompatibilidad.DataBussinesParameter
    Private m_parametros As Collection

   Public Sub New()
        MyBase.New()
        m_parametros = New Collection
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_nombre= New BasesParaCompatibilidad.DataBussinesParameter("@nombre","nombre")
       m_pie1= New BasesParaCompatibilidad.DataBussinesParameter("@pie1","pie1")
       m_pie2= New BasesParaCompatibilidad.DataBussinesParameter("@pie2","pie2")
       m_id_empresa= New BasesParaCompatibilidad.DataBussinesParameter("@id_empresa","id_empresa")
       m_Cabecera= New BasesParaCompatibilidad.DataBussinesParameter("@Cabecera","Cabecera")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property id() As Int32
       Get
           Return if(isdbnull(m_id.value), Nothing, m_id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
           m_id.value = value
       End Set
   End Property

   Public Property nombre() As String
       Get
           Return if(isdbnull(m_nombre.value), String.empty, m_nombre.value)
       End Get
       Set(ByVal value As String)
           m_nombre.value = value
       End Set
   End Property

   Public Property pie1() As String
       Get
           Return if(isdbnull(m_pie1.value), String.empty, m_pie1.value)
       End Get
       Set(ByVal value As String)
           m_pie1.value = value
       End Set
   End Property

   Public Property pie2() As String
       Get
           Return if(isdbnull(m_pie2.value), String.empty, m_pie2.value)
       End Get
       Set(ByVal value As String)
           m_pie2.value = value
       End Set
   End Property

   Public Property id_empresa() As Int32
       Get
           Return if(isdbnull(m_id_empresa.value), Nothing, m_id_empresa.value)
       End Get
       Set(ByVal value As Int32)
           m_id_empresa.value = value
       End Set
   End Property

   Public Property Cabecera() As String
       Get
           Return if(isdbnull(m_Cabecera.value), String.empty, m_Cabecera.value)
       End Get
       Set(ByVal value As String)
           m_Cabecera.value = value
       End Set
   End Property

    Public Property Parametros() As Collection
        Get
            Return m_parametros
        End Get
        Set(ByVal value As Collection)
            m_parametros = value
        End Set
    End Property
    

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_nombre, m_nombre.sqlName)
        MyBase.atributos.Add(m_pie1, m_pie1.sqlName)
        MyBase.atributos.Add(m_pie2, m_pie2.sqlName)
        MyBase.atributos.Add(m_id_empresa, m_id_empresa.sqlName)
        MyBase.atributos.Add(m_Cabecera, m_Cabecera.sqlName)
    End Sub
End Class
