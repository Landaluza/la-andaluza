Namespace Proveedores


    Public Class DBO_AvisosPedidos_articulos
        Inherits BasesParaCompatibilidad.DataBussines

        Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
        Private m_Id_proveedor As BasesParaCompatibilidad.DataBussinesParameter
        Private m_Id_articulo As BasesParaCompatibilidad.DataBussinesParameter
        Private m_Leido As BasesParaCompatibilidad.DataBussinesParameter
        Private m_Cabecera As BasesParaCompatibilidad.DataBussinesParameter
        Private m_Detalle As BasesParaCompatibilidad.DataBussinesParameter
        Private m_Fecha As BasesParaCompatibilidad.DataBussinesParameter

        Public Sub New()
            MyBase.New()
            m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@Id", "Id")
            m_Id_proveedor = New BasesParaCompatibilidad.DataBussinesParameter("@Id_proveedor", "Id_proveedor")
            m_Id_articulo = New BasesParaCompatibilidad.DataBussinesParameter("@Id_articulo", "Id_articulo")
            m_Leido = New BasesParaCompatibilidad.DataBussinesParameter("@Leido", "Leido")
            m_Cabecera = New BasesParaCompatibilidad.DataBussinesParameter("@Cabecera", "Cabecera")
            m_Detalle = New BasesParaCompatibilidad.DataBussinesParameter("@Detalle", "Detalle")
            m_Fecha = New BasesParaCompatibilidad.DataBussinesParameter("@Fecha", "Fecha")
            MyBase.primaryKey = m_Id
            añadirParametros()
        End Sub

        Public Property ID() As Integer
            Get
                If m_Id.value Is Convert.DBNull Then
                    Return 0
                End If
                Return CType(m_Id.value, Integer)
            End Get
            Set(ByVal value As Integer)
                Me.primaryKey.value = value
                m_Id.value = value
            End Set
        End Property

        Public Property Id_proveedor() As Integer
            Get
                If m_Id_proveedor.value Is Convert.DBNull Then
                    Return 0
                End If
                Return CType(m_Id_proveedor.value, Integer)
            End Get
            Set(ByVal value As Integer)
                m_Id_proveedor.value = value
            End Set
        End Property

        Public Property Id_articulo() As Integer
            Get
                If m_Id_articulo.value Is Convert.DBNull Then
                    Return 0
                End If
                Return CType(m_Id_articulo.value, Integer)
            End Get
            Set(ByVal value As Integer)
                m_Id_articulo.value = value
            End Set
        End Property

        Public Property Leido() As Boolean
            Get
                If m_Leido.value Is Convert.DBNull Then
                    Return False
                End If
                Return CType(m_Leido.value, Boolean)
            End Get
            Set(ByVal value As Boolean)
                m_Leido.value = value
            End Set
        End Property

        Public Property Cabecera() As String
            Get
                If m_Cabecera.value Is Convert.DBNull Then
                    Return String.Empty
                End If
                Return CType(m_Cabecera.value, String)
            End Get
            Set(ByVal value As String)
                m_Cabecera.value = value
            End Set
        End Property

        Public Property Detalle() As String
            Get
                If m_Detalle.value Is Convert.DBNull Then
                    Return String.Empty
                End If
                Return CType(m_Detalle.value, String)
            End Get
            Set(ByVal value As String)
                m_Detalle.value = value
            End Set
        End Property

        Public Property Fecha() As Date
            Get
                If m_Fecha.value Is Convert.DBNull Then
                    Return Now.Date
                End If
                Return CType(m_Fecha.value, Date)
            End Get
            Set(ByVal value As Date)
                m_Fecha.value = value
            End Set
        End Property
        Private Sub añadirParametros()
            MyBase.atributos.Add(m_Id, m_Id.sqlName)
            MyBase.atributos.Add(m_Id_proveedor, m_Id_proveedor.sqlName)
            MyBase.atributos.Add(m_Id_articulo, m_Id_articulo.sqlName)
            MyBase.atributos.Add(m_Leido, m_Leido.sqlName)
            MyBase.atributos.Add(m_Cabecera, m_Cabecera.sqlName)
            MyBase.atributos.Add(m_Detalle, m_Detalle.sqlName)
            MyBase.atributos.Add(m_Fecha, m_Fecha.sqlName)
        End Sub
    End Class

End Namespace