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
        dtb.AñadirParametroConsulta("@ton", TonelID)
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
            dtb.ConsultaAlteraciones("update Toneles set " & _
                               "Descripcion='" & Descripcion & "', ContenidoHabitual='" & ContenidoHabitual & "'" & _
                               " where TonelID=" & Convert.ToString(TonelID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer

        Try
            dtb.ConsultaAlteraciones("insert into Toneles values(" & _
                              "'" & Descripcion & "','" & ContenidoHabitual & "','" & _
                             BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)) + "'," + BasesParaCompatibilidad.Config.User.ToString + ")")

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
            dtb.AñadirParametroConsulta("@id", TonelID)
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
