Public Class frmConfiguracionUsuario
    Private dbobject As DBO_Usuarios

    'Dim dt As DataTable = RealizarConsulta("Select email from usuarios where usuarioid = " & clsUsu._UsuarioID)
    '            If IsDBNull(dt.Rows(0).Item(0)) Then
    'Dim strInput As String

    '                strInput = InputBox("Parece que la base de datos aun no contiene su correo." & Environment.NewLine & "Por favor, introduzca su direccion de correo interno (@andaluza.es):")

    '                If strInput <> "" Then
    '                    deprecated.realizarConsultaAlteraciones("update usuarios set email = '" & strInput & "' where usuarioID = " & clsUsu._UsuarioID)
    '                End If
    '            Else
    '                dt = RealizarConsulta("Select pass from usuarios where usuarioid = " & clsUsu._UsuarioID)
    '                If IsDBNull(dt.Rows(0).Item(0)) Then
    'Dim strInput As String

    '                    strInput = InputBox("Parece que la base de datos aun no contiene la contraseña de su correo." & Environment.NewLine & "Por favor, introduzca la contraseña de se direccion de correo interno (@andaluza.es):" & _
    '                                        Environment.NewLine & "(Deje el campo en blanco si no la recuerda ahora mismo)")

    '                    If strInput <> "" Then
    '                        deprecated.realizarConsultaAlteraciones("update usuarios set pass = '" & strInput & "' where usuarioID = " & clsUsu._UsuarioID)
    '                    End If
    '                End If
    '            End If

    Private Sub frmConfiguracionUsuario_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.Panel2, Me)
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        dbobject.pass = Me.txtCorreoPass.Text
        dbobject.email = Me.txtCorreo.Text

        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        dtb.EmpezarTransaccion()

        Try
            Dim sp_Usuarios As New spUsuarios

            If sp_Usuarios.Grabar(dbobject) Then   'update(dbobject) Then

                If Me.cbPass.Checked Then
                    If sp_Usuarios.CambiarContraseña(BasesParaCompatibilidad.Config.User, Me.txtoldPass.Text, Me.txtNewPass.Text) Then
                        dtb.TerminarTransaccion()
                        Me.Close()
                    Else
                        dtb.CancelarTransaccion()
                        messagebox.show("No se pudo actualizar la contraseña.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    dtb.TerminarTransaccion()
                    Me.Close()
                End If
            Else
                dtb.CancelarTransaccion()
                messagebox.show("No se pudo actualizar los datos de usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        Catch ex As Exception
            dtb.CancelarTransaccion()
            messagebox.show("Error al guardar los datos. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub cbPass_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbPass.CheckedChanged
        Me.PanContraseña.Enabled = cbPass.Checked
    End Sub

    Private Sub frmConfiguracionUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sp_Usuarios As New spUsuarios()
        Me.dbobject = sp_Usuarios.select_record(BasesParaCompatibilidad.Config.User)

        Me.txtCorreo.Text = Me.dbobject.email
        Me.txtCorreoPass.Text = Me.dbobject.pass
    End Sub
End Class