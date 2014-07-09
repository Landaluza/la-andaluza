Public Class DBO_ArticulosTipos
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_ResponsableID As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Descripcion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Utilizacion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Codificacion As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ArticuloTipoID","ArticuloTipoID")
       m_ResponsableID= New BasesParaCompatibilidad.DataBussinesParameter("@ResponsableID","ResponsableID")
       m_Descripcion= New BasesParaCompatibilidad.DataBussinesParameter("@Descripcion","Descripcion")
       m_Utilizacion= New BasesParaCompatibilidad.DataBussinesParameter("@Utilizacion","Utilizacion")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_Codificacion= New BasesParaCompatibilidad.DataBussinesParameter("@Codificacion","Codificacion")
       MyBase.primaryKey = m_Id
       añadirParametros()
   End Sub


   Public Property ID() As Int32
       Get
            Return If(isdbnull(m_id.value), Nothing, m_id.value)
        End Get
        Set(ByVal value As Int32)
            Me.primaryKey.value = value
            m_id.value = value
        End Set
    End Property

    Public Property ResponsableID() As Int32
        Get
            Return If(IsDBNull(m_ResponsableID.value), Nothing, m_ResponsableID.value)
        End Get
        Set(ByVal value As Int32)
            m_ResponsableID.value = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return If(isdbnull(m_Descripcion.value), String.empty, m_Descripcion.value)
        End Get
        Set(ByVal value As String)
            m_Descripcion.value = value
        End Set
    End Property

    Public Property Utilizacion() As String
        Get
            Return If(isdbnull(m_Utilizacion.value), String.empty, m_Utilizacion.value)
        End Get
        Set(ByVal value As String)
            m_Utilizacion.value = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return If(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
        End Get
        Set(ByVal value As String)
            m_Observaciones.value = value
        End Set
    End Property

    Public Property Codificacion() As String
        Get
            Return If(isdbnull(m_Codificacion.value), String.empty, m_Codificacion.value)
        End Get
        Set(ByVal value As String)
            m_Codificacion.value = value
        End Set
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_ResponsableID, m_ResponsableID.sqlName)
       MyBase.atributos.Add(m_Descripcion, m_Descripcion.sqlName)
       MyBase.atributos.Add(m_Utilizacion, m_Utilizacion.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_Codificacion, m_Codificacion.sqlName)
   End Sub
End Class
