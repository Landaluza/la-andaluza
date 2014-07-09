Public Class DBO_empleados_formatosEnvasados
inherits BasesParaCompatibilidad.DataBussines

   Private m_Id As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_formatoEnvasado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_id_empleado As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Inicio As BasesParaCompatibilidad.DataBussinesParameter
   Private m_Fin As BasesParaCompatibilidad.DataBussinesParameter

   Public Sub New()
       MyBase.New()
       m_Id = New BasesParaCompatibilidad.DataBussinesParameter("@id","id")
       m_id_formatoEnvasado= New BasesParaCompatibilidad.DataBussinesParameter("@id_formatoEnvasado","id_formatoEnvasado")
       m_id_empleado= New BasesParaCompatibilidad.DataBussinesParameter("@id_empleado","id_empleado")
       m_Inicio= New BasesParaCompatibilidad.DataBussinesParameter("@Inicio","Inicio")
       m_Fin= New BasesParaCompatibilidad.DataBussinesParameter("@Fin","Fin")
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

   Public Property id_formatoEnvasado() As Int32
       Get
           Return if(isdbnull(m_id_formatoEnvasado.value), Nothing, m_id_formatoEnvasado.value)
       End Get
       Set(ByVal value As Int32)
           m_id_formatoEnvasado.value = value
       End Set
   End Property

   Public Property id_empleado() As Int32
       Get
           Return if(isdbnull(m_id_empleado.value), Nothing, m_id_empleado.value)
       End Get
       Set(ByVal value As Int32)
           m_id_empleado.value = value
       End Set
   End Property

    Public Property Inicio() As TimeSpan
        Get
            Return If(IsDBNull(m_Inicio.value), Today.TimeOfDay, m_Inicio.value)
        End Get
        Set(ByVal value As TimeSpan)
            m_Inicio.value = value
        End Set
    End Property

    Public Property Fin() As Nullable(Of TimeSpan)
        Get
            If Convert.IsDBNull(m_Fin.value) Then
                Return Today.TimeOfDay
            End If

            If m_Fin.value Is Nothing Then
                Return Today.TimeOfDay
            End If

            Return m_Fin.value
        End Get
        Set(ByVal value As Nullable(Of TimeSpan))
            m_Fin.value = value
        End Set
    End Property

    Public readonly Property is_null_Fin() As Boolean
        Get
            Return if(m_Fin.value = Nothing, True, False)
        End Get        
    End Property



   Private Sub añadirParametros()
       MyBase.atributos.Add(m_Id, m_Id.sqlName)
       MyBase.atributos.Add(m_id_formatoEnvasado, m_id_formatoEnvasado.sqlName)
       MyBase.atributos.Add(m_id_empleado, m_id_empleado.sqlName)
       MyBase.atributos.Add(m_Inicio, m_Inicio.sqlName)
       MyBase.atributos.Add(m_Fin, m_Fin.sqlName)
   End Sub
End Class
