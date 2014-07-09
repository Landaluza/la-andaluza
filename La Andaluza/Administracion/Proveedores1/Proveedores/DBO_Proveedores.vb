Public Class DBO_Proveedores
inherits BasesParaCompatibilidad.DataBussines

    Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Nombre As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Alias As BasesParaCompatibilidad.DataBussinesParameter
    Private m_NIF As BasesParaCompatibilidad.DataBussinesParameter
    Private m_RSI As BasesParaCompatibilidad.DataBussinesParameter
    Private m_QS As BasesParaCompatibilidad.DataBussinesParameter
    Private m_n_trabajadores As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Id_poblacion As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Cp As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Direccion As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Id_poblacion2 As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Cp2 As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Direccion2 As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Ruta As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Activo As BasesParaCompatibilidad.DataBussinesParameter
    Private m_Informacion As BasesParaCompatibilidad.DataBussinesParameter
    Public proveedorCero As DBO_ProveedoresCero


    Public Sub New()
        MyBase.New()
        Me.proveedorCero = New DBO_ProveedoresCero
        m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@ProveedorID", "ProveedorID")
        m_Nombre = New BasesParaCompatibilidad.DataBussinesParameter("@Nombre", "Nombre")
        m_Alias = New BasesParaCompatibilidad.DataBussinesParameter("@Alias", "Alias")
        m_NIF = New BasesParaCompatibilidad.DataBussinesParameter("@NIF", "NIF")
        m_RSI = New BasesParaCompatibilidad.DataBussinesParameter("@RSI", "RSI")
        m_QS = New BasesParaCompatibilidad.DataBussinesParameter("@QS", "QS")
        m_n_trabajadores = New BasesParaCompatibilidad.DataBussinesParameter("@n_trabajadores", "n_trabajadores")
        m_Id_poblacion = New BasesParaCompatibilidad.DataBussinesParameter("@Id_poblacion", "Id_poblacion")
        m_Cp = New BasesParaCompatibilidad.DataBussinesParameter("@Cp", "Cp")
        m_Direccion = New BasesParaCompatibilidad.DataBussinesParameter("@Direccion", "Direccion")
        m_Id_poblacion2 = New BasesParaCompatibilidad.DataBussinesParameter("@Id_poblacion2", "Id_poblacion2")
        m_Cp2 = New BasesParaCompatibilidad.DataBussinesParameter("@Cp2", "Cp2")
        m_Direccion2 = New BasesParaCompatibilidad.DataBussinesParameter("@Direccion2", "Direccion2")
        m_Ruta = New BasesParaCompatibilidad.DataBussinesParameter("@Ruta", "Ruta")
        m_Activo = New BasesParaCompatibilidad.DataBussinesParameter("@Activo", "Activo")
        m_informacion = New BasesParaCompatibilidad.DataBussinesParameter("@InformacionGeneral", "InformacionGeneral")
        MyBase.primaryKey = m_Id
        añadirParametros()
    End Sub


   Public Property ProveedorID() As Int32
       Get
            Return if(IsDBNull(m_Id.value), Nothing, m_Id.value)
       End Get
       Set(ByVal value As Int32)
           Me.primaryKey.value = value
            m_Id.value = value
       End Set
   End Property

   Public Property Nombre() As String
       Get
           Return if(isdbnull(m_Nombre.value), String.empty, m_Nombre.value)
       End Get
       Set(ByVal value As String)
           m_Nombre.value = value
       End Set
   End Property

    Public Property Nick() As String
        Get
            Return if(isdbnull(m_Alias.value), String.empty, m_Alias.value)
        End Get
        Set(ByVal value As String)
            m_Alias.value = value
        End Set
    End Property

    Public Property NIF() As String
        Get
            Return if(IsDBNull(m_NIF.value), String.Empty, m_NIF.value)
        End Get
        Set(ByVal value As String)
            m_NIF.value = value
        End Set
    End Property

    Public Property RSI() As String
        Get
            Return if(IsDBNull(m_RSI.value), String.Empty, m_RSI.value)
        End Get
        Set(ByVal value As String)
            m_RSI.value = value
        End Set
    End Property

    Public Property QS() As Int32
        Get
            Return if(IsDBNull(m_QS.value), Nothing, m_QS.value)
        End Get
        Set(ByVal value As Int32)
            m_QS.value = value
        End Set
    End Property

    Public Property n_trabajadores() As Int32
        Get
            Return if(IsDBNull(m_n_trabajadores.value), Nothing, m_n_trabajadores.value)
        End Get
        Set(ByVal value As Int32)
            m_n_trabajadores.value = value
        End Set
    End Property

    Public Property Id_poblacion() As Int32
        Get
            Return if(IsDBNull(m_Id_poblacion.value), Nothing, m_Id_poblacion.value)
        End Get
        Set(ByVal value As Int32)
            m_Id_poblacion.value = value
        End Set
    End Property

    Public Property Cp() As String
        Get
            Return if(IsDBNull(m_Cp.value), String.Empty, m_Cp.value)
        End Get
        Set(ByVal value As String)
            m_Cp.value = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return if(IsDBNull(m_Direccion.value), String.Empty, m_Direccion.value)
        End Get
        Set(ByVal value As String)
            m_Direccion.value = value
        End Set
    End Property

    Public Property Id_poblacion2() As Int32
        Get
            Return if(IsDBNull(m_Id_poblacion2.value), Nothing, m_Id_poblacion2.value)
        End Get
        Set(ByVal value As Int32)
            m_Id_poblacion2.value = value
        End Set
    End Property

    Public Property Cp2() As String
        Get
            Return if(IsDBNull(m_Cp2.value), String.Empty, m_Cp2.value)
        End Get
        Set(ByVal value As String)
            m_Cp2.value = value
        End Set
    End Property

    Public Property Direccion2() As String
        Get
            Return if(IsDBNull(m_Direccion2.value), String.Empty, m_Direccion2.value)
        End Get
        Set(ByVal value As String)
            m_Direccion2.value = value
        End Set
    End Property

    Public Property Ruta() As String
        Get
            Return if(IsDBNull(m_Ruta.value), String.Empty, m_Ruta.value)
        End Get
        Set(ByVal value As String)
            m_Ruta.value = value
        End Set
    End Property

    Public Property InformacionGeneral() As String
        Get
            Return if(IsDBNull(m_Informacion.value), String.Empty, m_Informacion.value)
        End Get
        Set(ByVal value As String)
            m_Informacion.value = value
        End Set
    End Property

    Public Property Activo() As Boolean
        Get
            Return if(IsDBNull(m_Activo.value), True, m_Activo.value)
        End Get
        Set(ByVal value As Boolean)
            m_Activo.value = value
        End Set
    End Property
    

    Private Sub añadirParametros()
        MyBase.atributos.Add(m_Id, m_Id.sqlName)
        MyBase.atributos.Add(m_Nombre, m_Nombre.sqlName)
        MyBase.atributos.Add(m_Alias, m_Alias.sqlName)
        MyBase.atributos.Add(m_NIF, m_NIF.sqlName)
        MyBase.atributos.Add(m_RSI, m_RSI.sqlName)
        MyBase.atributos.Add(m_QS, m_QS.sqlName)
        MyBase.atributos.Add(m_n_trabajadores, m_n_trabajadores.sqlName)
        MyBase.atributos.Add(m_Id_poblacion, m_Id_poblacion.sqlName)
        MyBase.atributos.Add(m_Cp, m_Cp.sqlName)
        MyBase.atributos.Add(m_Direccion, m_Direccion.sqlName)
        MyBase.atributos.Add(m_Id_poblacion2, m_Id_poblacion2.sqlName)
        MyBase.atributos.Add(m_Cp2, m_Cp2.sqlName)
        MyBase.atributos.Add(m_Direccion2, m_Direccion2.sqlName)
        MyBase.atributos.Add(m_Ruta, m_Ruta.sqlName)
        MyBase.atributos.Add(m_Activo, m_Activo.sqlName)
        MyBase.atributos.Add(m_Informacion, m_Informacion.sqlName)
    End Sub
End Class
