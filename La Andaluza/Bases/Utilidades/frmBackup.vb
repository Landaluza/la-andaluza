


Public Class frmBackup
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmBackup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.rdbBackup.Checked Then
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim Cnx As System.Data.SqlClient.SqlConnection
        Dim servidor As String = "MAM\SQLEXPRESS"

        Select Case My.Computer.Name
            Case Is = "MAM1"
                servidor = "MAM1\SQLEXPRESS"
            Case Is = "MAM"
                servidor = "Servidor"
            Case Else
                servidor = "Servidor"
        End Select
        Dim ruta As String

        If Me.rdbBackup.Checked Then
            MessageBox.Show(DateTime.Now.ToString("u"), "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'messageBox.show(datetime.now.ToString("s")) '
            'ruta = Me.txtBackup.Text + "\" + datetime.now.ToString("yyyy") + datetime.now.ToString("MM") + datetime.now.ToString("dd") + " " + txtNombre.Text + ".bak"

            ruta = Me.txtBackup.Text + "\" + DateTime.Now.ToString("yyyy-MM-dd HH-mm ") + txtNombre.Text + ".bak"
            Dim sBackup As String = "BACKUP DATABASE " & "LaPruebas" & _
                            " TO DISK = N'" & ruta & _
                            "' WITH NOFORMAT, NOINIT, NAME = N'" & ruta & _
                            "-Full Database Backup',SKIP, STATS = 10"
            Try
                Cnx = New System.Data.SqlClient.SqlConnection
                Cnx.ConnectionString = "workstation id=" & servidor & _
                                       ";packet size=4096" & _
                                       ";integrated security=SSPI" & _
                                       ";data source= " & servidor & _
                                       ";persist security info=False" & _
                                       ";initial catalog=Master"
                Try
                    Cnx.Open()
                Catch ex As Exception
                    MessageBox.Show("Error al conectar" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Dim cmdBackUp As New System.Data.SqlClient.SqlCommand(sBackup, Cnx)
                cmdBackUp.ExecuteNonQuery()
                MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoria", _
                        "Copia de seguridad de base de datos", _
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cnx.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, _
                                "Error al copiar la base de datos", _
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Dim sBackup As String = "RESTORE DATABASE " & Me.txtBackup.Text & _
                                    " FROM DISK = '" & Me.txtNombre.Text & "'" & _
                                    " WITH REPLACE"
            Dim csb As New System.Data.SqlClient.SqlConnectionStringBuilder
            csb.DataSource = servidor
            csb.InitialCatalog = "master"  ' Es mejor abrir la conexión con la base Master
            csb.IntegratedSecurity = True
            Using con As New System.Data.SqlClient.SqlConnection(csb.ConnectionString)
                Try
                    con.Open()
                    Dim cmdBackUp As New System.Data.SqlClient.SqlCommand(sBackup, con)
                    cmdBackUp.ExecuteNonQuery()
                    MessageBox.Show("Se ha restaurado la copia de la base de datos.", _
                                    "Restaurar base de datos", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Information)
                    con.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, _
                                    "Error al restaurar la base de datos", _
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        Dim Directorio As New FolderBrowserDialog
        Dim FicheroRestore As New OpenFileDialog

        If Me.rdbBackup.Checked Then
            If Directorio.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtBackup.Text = Directorio.SelectedPath
            End If
        Else
            FicheroRestore.ShowDialog()
            Me.txtNombre.Text = FicheroRestore.FileName
        End If
    End Sub
End Class