Public Class clsToneles

#Region "Atributos"
    Private TonelID As Integer
    Private Descripcion As String
    Private ContenidoHabitual As String
#End Region

#Region "Propiedades"
    Public Property _TonelID() As Integer
        Get
            Return TonelID
        End Get

        Set(ByVal value As Integer)
            TonelID = value
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

    Public Property _ContenidoHabitual() As String
        Get
            Return ContenidoHabitual
        End Get

        Set(ByVal value As String)
            ContenidoHabitual = value
        End Set
    End Property
#End Region

#Region "Metodos"


    Public Sub Cargar(ByRef dtb As BasesParaCompatibilidad.DataBase)

        Dim tabla As New DataTable
        dtb.PrepararConsulta("select Toneles.Descripcion, ContenidoHabitual from Toneles where TonelID= @ton")
        dtb.AņadirParametroConsulta("@ton", TonelID)
        tabla = dtb.Consultar()
        Try
            Descripcion = tabla.Rows(0).Item(0)
            ContenidoHabitual = tabla.Rows(0).Item(1)
        Catch ex As Exception
            Descripcion = ""
            ContenidoHabitual = ""
        End Try
    End Sub

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.PrepararConsulta("update Toneles set Descripcion= @des, ContenidoHabitual= @con  where TonelID= @id")
            dtb.AņadirParametroConsulta("@des", Descripcion)
            dtb.AņadirParametroConsulta("@con", ContenidoHabitual)
            dtb.AņadirParametroConsulta("@id", TonelID)

            If dtb.Execute Then Return 1

            Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        Try
            dtb.PrepararConsulta("insert into Toneles values(@desc , @cont , @fecha , @user )")
            dtb.AņadirParametroConsulta("@desc", Descripcion)
            dtb.AņadirParametroConsulta("@cont", ContenidoHabitual)
            dtb.AņadirParametroConsulta("@fecha", BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)))
            dtb.AņadirParametroConsulta("@user", BasesParaCompatibilidad.Config.User)

            If Not dtb.Execute Then Throw New Exception("Error al guardar")

            dtb.PrepararConsulta("select max(TonelID) from Toneles")
            TonelID = dtb.Consultar.Rows(0).Item(0)
            Return TonelID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        Try

            dtb.PrepararConsulta("delete from Toneles where TonelID = @id")
            dtb.AņadirParametroConsulta("@id", TonelID)
            If dtb.Execute Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar Tonel, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Return 0
            End If

            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("Toneles", "TonelID = " & Convert.ToString(TonelID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar Tonel, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            'TonelID = 0
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
