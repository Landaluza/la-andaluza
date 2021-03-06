Public Class clsTransicubas

#Region "Atributos"
    Private TransicubaID As Integer
    Private Descripcion As String
    Private Estado As Boolean
#End Region

#Region "Propiedades"
    Public Property _TransicubaID() As Integer
        Get
            Return TransicubaID
        End Get

        Set(ByVal value As Integer)
            TransicubaID = value
        End Set
    End Property

    Public Property _Descripcion() As String
        Get
            Return Descripcion
        End Get

        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property _Estado() As Boolean
        Get
            Return Estado
        End Get

        Set(ByVal value As Boolean)
            Estado = value
        End Set
    End Property

#End Region

#Region "Metodos"
  

    Public Sub Cargar(ByRef dtb As BasesParaCompatibilidad.DataBase)
        Try
            Dim tabla As New DataTable
            dtb.PrepararConsulta("select Transicubas.Descripcion,Transicubas.Estado from Transicubas where TransicubaID= @tra")
            dtb.AņadirParametroConsulta("@tra", transicubaID)
            tabla = dtb.Consultar()

            If Convert.IsDBNull(tabla.Rows(0).Item(0)) Then
                Descripcion = ""
            Else
                Descripcion = tabla.Rows(0).Item(0)
            End If
            Estado = tabla.Rows(0).Item(1)
        Catch ex As Exception
            Descripcion = ""
            Estado = False
        End Try
    End Sub



    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.PrepararConsulta("update Transicubas set Descripcion= @des ,Estado= @est where TransicubaID= @id")

            dtb.AņadirParametroConsulta("@des", Descripcion)
            dtb.AņadirParametroConsulta("@est", Estado)
            dtb.AņadirParametroConsulta("@id", TransicubaID)

            If dtb.Execute Then Return 1
            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.PrepararConsulta("insert into transicubas values( @desc, @est , @fecha, @user )")
            dtb.AņadirParametroConsulta("@desc", Descripcion)
            dtb.AņadirParametroConsulta("@est", Estado)
            dtb.AņadirParametroConsulta("@fecha", BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)))
            dtb.AņadirParametroConsulta("@user", BasesParaCompatibilidad.Config.User)

            If Not dtb.Execute Then Throw New Exception("Error al guardar")

            dtb.PrepararConsulta("select max(TransicubaID) from Transicubas")
            TransicubaID = dtb.Consultar().Rows(0).Item(0)
            Return TransicubaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        Try
            dtb.PrepararConsulta("delete from Transicubas where TransicubaID = @id")
            dtb.AņadirParametroConsulta("@id", TransicubaID)
            If dtb.Execute Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar Transicuba, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return 0
            End If
            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("Transicubas", "TransicubaID = " & Convert.ToString(TransicubaID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar Transicuba, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            'TransicubaID = 0
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
