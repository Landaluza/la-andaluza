Public Class FrmInicio
    'Private ctrSes As New ctlUsuarios
    'Public Const CAMBIO_SESION As Integer = 0
    'Public Const acceso As Integer = 1    
    Private Gform As GUIstandar
    Private Calendar As BasesParaCompatibilidad.Calendar
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        Calendar = New BasesParaCompatibilidad.Calendar
        BasesParaCompatibilidad.Calendar.testDateTime = False
        Me.Gform = New GUIstandar(Me)
        AddHandler Gform.FormClosed, AddressOf Me.Close
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        iniciar()
    End Sub

    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub iniciar()

        If My.Computer.Name = "MAM1" Or My.Computer.Name = "GERENTE1" Or My.Computer.Name = "MAM2-PC" Or My.Computer.Name = "MAMVAIO" Then
            If txtLogin.Text.Length = 0 AndAlso txtPassword.Text.Length = 0 Then
                txtLogin.Text = "mam"
                txtPassword.Text = "trucha0121"
            End If
        End If

        If txtLogin.Text = "mamdev" Then
            txtLogin.Text = txtLogin.Text.Replace("mamdev", "mam")
        End If

        If comprobarCampos() Then
            Me.Enabled = False
            If Not Me.BackgroundWorker1.IsBusy Then
                Me.BackgroundWorker1.RunWorkerAsync()
            End If
        Else
            MessageBox.Show("Error. Los datos no son correctos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Function comprobarCampos() As Boolean

        Dim respuesta As Boolean = True
        If txtLogin.Text.Contains("'") Then
            If Not Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = True
            If respuesta Then respuesta = False
        Else
            If Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = False
        End If
        If txtLogin.Text = "" Then
            If Not Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = True
            If respuesta Then respuesta = False
        Else
            If Me.LblLoginIssue.Visible Then Me.LblLoginIssue.Visible = False
        End If
        If txtPassword.Text = "" Then
            If Not Me.lblPasswordIssue.Visible Then Me.lblPasswordIssue.Visible = True
            If respuesta Then respuesta = False
        Else
            If Me.lblPasswordIssue.Visible Then Me.lblPasswordIssue.Visible = False
        End If

        Return respuesta
    End Function

    Private Sub FrmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setValores()
    End Sub

    Private Sub setValores()
        Me.Text = Config.Version_seriada
    End Sub

    Private Sub FrmInicio_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = 13 Then
            iniciar()
        End If
    End Sub

    Private Sub FrmInicio_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       

         
        Me.txtLogin.Text = ""
        Me.txtPassword.Text = ""
        Me.BringToFront()
    End Sub

    Private Sub btnPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPass.Click
        recuperarContraseña(dtb)
    End Sub

    Private Sub lPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lPass.Click
        recuperarContraseña(dtb)
    End Sub

    Private Sub recuperarContraseña(ByRef dtb As BasesParaCompatibilidad.DataBase)
        Dim longitud As Integer
        Dim semilla As Integer = DateTime.Now.Millisecond
        Dim rnd As Random

        rnd = New Random(semilla)
        longitud = 6

        Dim s As New System.Text.StringBuilder(longitud)
        For i As Integer = 1 To longitud
            Dim c As Char = ChrW(rnd.Next(97, 123))

            s.Append(c)
        Next

        Dim spUsuarios As New spUsuarios
        dtb.EmpezarTransaccion()

        Try
            Dim dbo_usuarios As DBO_Usuarios = spUsuarios.select_record_by_usuario(Me.txtLogin.Text, dtb)

            If dbo_usuarios.email IsNot String.Empty Then

                Dim frm As New BasesParaCompatibilidad.frmEntrada("Introduzca su dirección de correo", "La dirección debe coincidir con la que introdujo para su usuario")
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

                If frm.Result = dbo_usuarios.email Then
                    dbo_usuarios.cryptedPassword = s.ToString
                    spUsuarios.Grabar(dbo_usuarios, dtb)

                    Dim cuerpo As String = "Su nueva contraseña es: " & dbo_usuarios.cryptedPassword

                    If Mail.notificarUsuario(s.ToString, Me.txtLogin.Text, dtb) Then
                        dtb.TerminarTransaccion()
                        MessageBox.Show("Recuperación de contraseñas completada, revise su correo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        dtb.CancelarTransaccion()
                        MessageBox.Show("no se pudo recuperar la contraseñas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                Else
                    dtb.CancelarTransaccion()
                    MessageBox.Show("Los datos no coinciden. Vuelva a intetarlo o pongase en contacto con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                dtb.CancelarTransaccion()
                MessageBox.Show("EL usuario no contiene información sobre su correo. Pongase en contacto con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("Error recuperando la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub FrmInicio_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Me.Gform Is Nothing Then Me.Gform.stopGUI()
        Environment.Exit(0)
    End Sub

    Private Sub txtLogin_Enter(sender As System.Object, e As System.EventArgs) Handles txtLogin.Enter
        Me.txtLogin.SelectAll()
    End Sub

    Private Sub txtPassword_Enter(sender As System.Object, e As System.EventArgs) Handles txtPassword.Enter
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub txtLogin_Click(sender As System.Object, e As System.EventArgs) Handles txtLogin.Click
        Me.txtLogin.SelectAll()
    End Sub

    Private Sub txtPassword_Click(sender As System.Object, e As System.EventArgs) Handles txtPassword.Click
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim spUsuarios As New spUsuarios

        If Not Calendar.TestDate() Then
            BasesParaCompatibilidad.Config.User = -1
        Else
            If Not spUsuarios.autentificar(txtLogin.Text, txtPassword.Text, dtb) Then
                BasesParaCompatibilidad.Config.User = 0
            End If
        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If BasesParaCompatibilidad.Config.User = 0 Then
            MessageBox.Show("Error en datos", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Enabled = True
        Else
            If BasesParaCompatibilidad.Config.User = -1 Then
                MessageBox.Show("No se pudo conectar a la base de datos, vuelva a intentarlo en unos minutos. Si el problema persiste contacte con su administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Enabled = True
            Else
                Me.Hide()
                SplashScreen1.show_loading()

                Gform.terminarDeIniciar("LA", Config.ServerName, Me.txtLogin.Text, txtLogin.Text)


                Me.Enabled = True
                Me.DialogResult = Windows.Forms.DialogResult.OK
                SplashScreen1.hide_loading()
                Gform.Show()
            End If
        End If
    End Sub
End Class
