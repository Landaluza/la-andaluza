Public Class frmConfiguracionUsuario
    Private dbobject As DBO_Usuarios
    Private dtb As BasesParaCompatibilidad.DataBase


    Private Sub frmConfiguracionUsuario_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.Panel2, Me)
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        dbobject.pass = Me.txtCorreoPass.Text
        dbobject.email = Me.txtCorreo.Text

        dtb.EmpezarTransaccion()

        Try
            Dim sp_Usuarios As New spUsuarios

            If sp_Usuarios.Grabar(dbobject, dtb) Then   'update(dbobject) Then

                If Me.cbPass.Checked Then
                    If sp_Usuarios.CambiarContraseña(BasesParaCompatibilidad.Config.User, Me.txtoldPass.Text, Me.txtNewPass.Text, dtb) Then
                        dtb.TerminarTransaccion()
                        Me.Close()
                    Else
                        dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo actualizar la contraseña.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    dtb.TerminarTransaccion()
                    Me.Close()
                End If
            Else
                dtb.CancelarTransaccion()
                MessageBox.Show("No se pudo actualizar los datos de usuario.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        Me.dbobject = sp_Usuarios.Select_Record(BasesParaCompatibilidad.Config.User, dtb)

        Me.txtCorreo.Text = Me.dbobject.email
        Me.txtCorreoPass.Text = Me.dbobject.pass
    End Sub

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()

    End Sub
End Class