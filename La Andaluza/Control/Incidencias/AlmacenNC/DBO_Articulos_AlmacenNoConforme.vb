Public Class DBO_Articulos_AlmacenNoConforme
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Observaciones As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaEntrada As BasesParaCompatibilidad.DataBussinesParameter
   Private m_FechaSalida As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_TipoAccion As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Cantidad As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_MedidaProducto As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Id_Controlincidencia As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id","Id")
       m_Observaciones= New BasesParaCompatibilidad.DataBussinesParameter("@Observaciones","Observaciones")
       m_FechaEntrada= New BasesParaCompatibilidad.DataBussinesParameter("@FechaEntrada","FechaEntrada")
       m_FechaSalida= New BasesParaCompatibilidad.DataBussinesParameter("@FechaSalida","FechaSalida")
       m_Id_TipoAccion= New BasesParaCompatibilidad.DataBussinesParameter("@Id_TipoAccion","Id_TipoAccion")
       m_Cantidad= New BasesParaCompatibilidad.DataBussinesParameter("@Cantidad","Cantidad")
       m_id_MedidaProducto= New BasesParaCompatibilidad.DataBussinesParameter("@id_MedidaProducto","id_MedidaProducto")
       m_Id_Controlincidencia= New BasesParaCompatibilidad.DataBussinesParameter("@Id_Controlincidencia","Id_Controlincidencia")
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

   Public Property Observaciones() As String
       Get
           Return if(isdbnull(m_Observaciones.value), String.empty, m_Observaciones.value)
       End Get
       Set(ByVal value As String)
           m_Observaciones.value = value
       End Set
   End Property

    Public Property FechaEntrada() As Date
        Get
            Return If(IsDBNull(m_FechaEntrada.value), Today.Date, m_FechaEntrada.value)
        End Get
        Set(ByVal value As Date)
            m_FechaEntrada.value = value
        End Set
    End Property

    Public Property FechaSalida() As Date
        Get
            Return If(IsDBNull(m_FechaSalida.value), Today.Date, m_FechaSalida.value)
        End Get
        Set(ByVal value As Date)
            m_FechaSalida.value = value
        End Set
    End Property

   Public Property Id_TipoAccion() As Int32
       Get
           Return if(isdbnull(m_Id_TipoAccion.value), Nothing, m_Id_TipoAccion.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_TipoAccion.value = value
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

   Public Property id_MedidaProducto() As Int32
       Get
           Return if(isdbnull(m_id_MedidaProducto.value), Nothing, m_id_MedidaProducto.value)
       End Get
       Set(ByVal value As Int32)
           m_id_MedidaProducto.value = value
       End Set
   End Property

   Public Property Id_Controlincidencia() As Int32
       Get
           Return if(isdbnull(m_Id_Controlincidencia.value), Nothing, m_Id_Controlincidencia.value)
       End Get
       Set(ByVal value As Int32)
           m_Id_Controlincidencia.value = value
       End Set
   End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_Observaciones, m_Observaciones.sqlName)
       MyBase.atributos.Add(m_FechaEntrada, m_FechaEntrada.sqlName)
       MyBase.atributos.Add(m_FechaSalida, m_FechaSalida.sqlName)
       MyBase.atributos.Add(m_Id_TipoAccion, m_Id_TipoAccion.sqlName)
       MyBase.atributos.Add(m_Cantidad, m_Cantidad.sqlName)
       MyBase.atributos.Add(m_id_MedidaProducto, m_id_MedidaProducto.sqlName)
       MyBase.atributos.Add(m_Id_Controlincidencia, m_Id_Controlincidencia.sqlName)
   End Sub
End Class
