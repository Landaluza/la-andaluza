Public Class DBO_Articulos_AlmacenNoConforme_seguimiento
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_Articulos_AlmacenNoConforme As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter
   Private m_observaciones As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Id_Articulos_AlmacenNoConforme= New BasesParaCompatibilidad.DataBussinesParameter("@Id_Articulos_AlmacenNoConforme","Id_Articulos_AlmacenNoConforme")
       m_Fecha= New BasesParaCompatibilidad.DataBussinesParameter("@Fecha","Fecha")
       m_observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@observaciones","observaciones")
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

   Public Property Id_Articulos_AlmacenNoConforme() As Int32
       Get
           Return if(isdbnull(m_Id_Articulos_AlmacenNoConforme.value), Nothing, m_Id_Articulos_AlmacenNoConforme.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_Articulos_AlmacenNoConforme.value = value
       End Set
   End Property

    Public Property Fecha() As Date
        Get
            Return If(IsDBNull(m_Fecha.value), Today.Date, m_Fecha.value)
        End Get
        Set(ByVal value As Date)
            m_Fecha.value = value
        End Set
    End Property

   Public Property observaciones() As String
       Get
           Return if(isdbnull(m_observaciones.value), String.empty, m_observaciones.value)
       End Get
       Set(ByVal value As String)
           m_observaciones.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Id_Articulos_AlmacenNoConforme, m_Id_Articulos_AlmacenNoConforme.sqlName)
       MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
       MyBase.atributos.Add(m_observaciones, m_observaciones.sqlName)
   End Sub
End Class
