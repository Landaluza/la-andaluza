



Public Class frmDBTools
    Private mySettings As cSettings

#Region "Initialization"

    ''' <summary>
    ''' Toolstripbutton to close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub beendenToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles beendenToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Copy database tab"

    Private Function GetDatabaseNames(ByVal sServer As String, ByVal bIntegrated As Boolean, ByVal sUsername As String, ByVal sPassword As String) As DataTable
        Dim db As New cDatabaseHelper(sServer, bIntegrated, sUsername, sPassword, "master")
        Return db.GetDatabases()
    End Function

    Private Sub cmbFromDatabase_DropDown(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFromDatabase.DropDown
        'Load possible Databases                        
        cmbFromDatabase.ValueMember = "name"
        cmbFromDatabase.DisplayMember = "name"
        Try
            cmbFromDatabase.DataSource = GetDatabaseNames(cmbFromServer.Text, chkFromServerIntegrated.Checked, txtFromServerUser.Text, txtFromServerPassword.Text)
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub cmbToDatabase_DropDown(ByVal sender As Object, ByVal e As EventArgs) Handles cmbToDatabase.DropDown
        'Load possible Databases
        cmbToDataBase.ValueMember = "name"
        cmbToDataBase.DisplayMember = "name"
        Try
            cmbToDataBase.DataSource = GetDatabaseNames(cmbToServer.Text, chkToServerIntegrated.Checked, txtToServerUser.Text, txtToServerPassword.Text)
        Catch ex As Exception
            MessageBox.Show("Fehler: " & ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub chkFromServerIntegrated_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkFromServerIntegrated.CheckedChanged
        If chkFromServerIntegrated.Checked Then
            txtFromServerUser.Enabled = False
            txtFromServerPassword.Enabled = False
        Else
            txtFromServerUser.Enabled = True
            txtFromServerPassword.Enabled = True
        End If
    End Sub

    Private Sub chkToServerIntegrated_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkToServerIntegrated.CheckedChanged
        If chkToServerIntegrated.Checked Then
            txtToServerUser.Enabled = False
            txtToServerPassword.Enabled = False
        Else
            txtToServerUser.Enabled = True
            txtToServerPassword.Enabled = True
        End If
    End Sub

    Private Sub LoadSettings()
        mySettings = New cSettings(Application.StartupPath & "\config.xml")

        For Each row As DataRow In mySettings.GetServers().Rows
            lbServers.Items.Add(row(0).ToString())
            cmbFromServer.Items.Add(row(0).ToString())
            cmbToServer.Items.Add(row(0).ToString())
        Next
    End Sub

    Private Sub frmDBTools_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        LoadSettings()
    End Sub

    Private Sub cmbFromServer_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFromServer.SelectedIndexChanged
        txtFromServerUser.Text = mySettings.GetServerUsername(cmbFromServer.Text)
        txtFromServerPassword.Text = mySettings.GetServerPassword(cmbFromServer.Text)
        chkFromServerIntegrated.Checked = Convert.ToBoolean(mySettings.GetServerIntegratedSecurity(cmbFromServer.Text))
        txtSourceDir.Text = mySettings.GetServerDefaultBackupdir(cmbFromServer.Text)
    End Sub

    Private Sub cmbToServer_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbToServer.SelectedIndexChanged
        txtToServerUser.Text = mySettings.GetServerUsername(cmbToServer.Text)
        txtToServerPassword.Text = mySettings.GetServerPassword(cmbToServer.Text)
        chkToServerIntegrated.Checked = Convert.ToBoolean(mySettings.GetServerIntegratedSecurity(cmbToServer.Text))
        txtDestDir.Text = mySettings.GetServerDefaultDatadir(cmbToServer.Text)
        txtDestBackupDir.Text = mySettings.GetServerDefaultBackupdir(cmbToServer.Text)
        txtDestLogDir.Text = mySettings.GetServerDefaultLogdir(cmbToServer.Text)
    End Sub

#End Region

#Region "Actions"
    ''' <summary>
    ''' Set the progressbar
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OperationProgress(ByVal sender As Object, ByVal e As ProgressEventArgs)
        pbCopy.Value = e.Progress
        Application.DoEvents()
    End Sub

    ''' <summary>
    ''' Sets the progress indicator which step has been reached
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub StepChanged(ByVal sender As Object, ByVal e As StepsEventArgs)
        If e.[Step] = Steps.BACKUP Then
            tsStatus.Text = "Creating Backup..."
            Me.Refresh()
        End If

        If e.[Step] = Steps.COPY Then
            'Copy backupfile to dest
            tsStatus.Text = "Copiing file..."
            pbCopy.Value = 0
            Me.Refresh()
        End If

        If e.[Step] = Steps.RESTORE Then
            tsStatus.Text = "Restoring BasesParaCompatibilidad.DataBase..."
            pbCopy.Value = 0
            Me.Refresh()
        End If

        If e.[Step] = Steps.IDLE Then
            tsStatus.Text = "Idle."
            pbCopy.Value = 0
            Me.Refresh()
            MessageBox.Show("Sucessfully copied BasesParaCompatibilidad.DataBase..", "Wohooo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ''' <summary>
    ''' Checks if everything is filled out.
    ''' </summary>
    ''' <returns>true if everything is filled out</returns>
    Private Function PreCheckSettings() As Boolean
        'check servers
        If cmbFromServer.Text = "" OrElse cmbToServer.Text = "" Then
            MessageBox.Show("Please choose a source and a destination server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        'check databases
        If cmbFromDatabase.Text = "" OrElse cmbToDataBase.Text = "" Then
            MessageBox.Show("Please choose a source and a destination BasesParaCompatibilidad.DataBase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        'check login information from server
        If (txtFromServerUser.Text = "" OrElse txtFromServerPassword.Text = "") AndAlso Not chkFromServerIntegrated.Checked Then
            MessageBox.Show("Please provide login information for the source server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        'check login information to server
        If (txtToServerUser.Text = "" OrElse txtToServerPassword.Text = "") AndAlso Not chkToServerIntegrated.Checked Then
            MessageBox.Show("Please provide login information for the destination server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        'check directories (source)
        If Not cHelper.CheckFilePathRegex(txtSourceDir.Text) Then
            MessageBox.Show("You can't use this source directory. No UNC Paths and don't forget the trailing slash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        'check directories (dest bacup)
        If Not cHelper.CheckFilePathRegex(txtDestBackupDir.Text) Then
            MessageBox.Show("You can't use this destination backup directory. No UNC Paths and don't forget the trailing slash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        'check directories (dest data)
        If Not cHelper.CheckFilePathRegex(txtDestDir.Text) Then
            MessageBox.Show("You can't use this destination data directory. No UNC Paths And don't forget the trailing slash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        'check directories (dest log)
        If Not cHelper.CheckFilePathRegex(txtDestLogDir.Text) Then
            MessageBox.Show("You can't use this destination log directory. No UNC Paths And don't forget the trailing slash.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If

        Return True
    End Function


    ''' <summary>
    ''' Copy the database
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCopy.Click
        Dim dbc As New cDatabaseCopy()

        'dbc.Progress += New ProgressEventHandler(AddressOf OperationProgress)
        'dbc.StepChanged += New StepsEventHandler(AddressOf StepChanged)

        If PreCheckSettings() Then
            Try
                dbc.CopyDatabase(txtSourceDir.Text, cmbFromDatabase.Text, cmbToDataBase.Text, txtDestDir.Text, txtDestBackupDir.Text, txtDestLogDir.Text, _
                 cmbFromServer.Text, cmbToServer.Text, txtFromServerUser.Text, txtFromServerPassword.Text, chkFromServerIntegrated.Checked, txtToServerUser.Text, _
                 txtToServerPassword.Text, chkToServerIntegrated.Checked)
            Catch ex As Exception
                'reset status information
                tsStatus.Text = "Error."
                pbCopy.Value = 0
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End Try
        End If
    End Sub
#End Region

#Region "Servers Tab"
    Private Sub AddServer(ByVal sServername As String)
        lbServers.Items.Add(sServername)
        cmbFromServer.Items.Add(sServername)
        cmbToServer.Items.Add(sServername)
        mySettings.AddServer(sServername)
    End Sub

    Private Sub RemoveServer(ByVal sServername As String)
        lbServers.Items.Remove(sServername)
        mySettings.RemoveServer(sServername)
        cmbFromServer.Items.Remove(sServername)
        cmbToServer.Items.Remove(sServername)
    End Sub

    Private Sub btnAddServer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddServer.Click
        'string sNewServer;
        'sNewServer = Interaction.InputBox("Servername/Server-IP?", "Add server", "", this.Location.X + 50, this.Location.Y + 50);
        'AddServer(sNewServer);           
        Dim frm As New frmAddServer()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

        If frm.DialogResult = DialogResult.OK Then
            If lbServers.Items.Contains(frm.Servername) Then
                MessageBox.Show("You already added that server.", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                AddServer(frm.Servername)
            End If
        End If
    End Sub

    Private Sub btnRemoveSelected_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRemoveSelected.Click
        If lbServers.SelectedIndex > -1 Then
            RemoveServer(lbServers.SelectedItem.ToString())
        Else
            MessageBox.Show("No server selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub btnAddServersFromNetwork_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddServersFromNetwork.Click
        Dim dtInstances As DataTable
        dtInstances = cHelper.GetServersFromNetwork()

        If dtInstances Is Nothing Then
            MessageBox.Show("No sql server instances found")
        Else
            For Each row As DataRow In dtInstances.Rows
                'Add server if it doesn't exist
                Dim bExists As Boolean = False
                For Each s As String In lbServers.Items
                    If s = row(0).ToString() Then
                        bExists = True
                    End If
                Next

                If Not bExists Then
                    AddServer(row(0).ToString())

                End If
            Next
        End If
    End Sub

    Private Sub btnGetDefaultBackupdir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetDefaultBackupdir.Click
        If lbServers.SelectedIndex = -1 Then
            MessageBox.Show("No server selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Try
                Dim db As New cDatabaseHelper(lbServers.SelectedItem.ToString(), chkServerUseIntegratedSecurity.Checked, txtServerUser.Text, txtServerPassword.Text, "master")
                txtDefaultbackupDir.Text = db.GetDefaultBackupdir()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnGetDefaultDatadir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetDefaultDatadir.Click
        If lbServers.SelectedIndex = -1 Then
            MessageBox.Show("No server selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Try
                Dim db As New cDatabaseHelper(lbServers.SelectedItem.ToString(), chkServerUseIntegratedSecurity.Checked, txtServerUser.Text, txtServerPassword.Text, "master")
                txtDefaultDatadir.Text = db.GetDefaultDatadir()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnGetDefaultLogDir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetDefaultLogDir.Click
        If lbServers.SelectedIndex = -1 Then
            MessageBox.Show("No server selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            Try
                Dim db As New cDatabaseHelper(lbServers.SelectedItem.ToString(), chkServerUseIntegratedSecurity.Checked, txtServerUser.Text, txtServerPassword.Text, "master")
                txtDefaultLogDir.Text = db.GetDefaultLogdir()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnTestConnection_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTestConnection.Click
        Dim db As New cDatabaseHelper(lbServers.SelectedItem.ToString(), chkServerUseIntegratedSecurity.Checked, txtServerUser.Text, txtServerPassword.Text, "master")

        If db.TestConnection() Then
            btnTestConnection.Text = "Connection OK"
            btnTestConnection.ForeColor = Color.Green
        Else
            btnTestConnection.Text = "no connection"
            btnTestConnection.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ToggleEnabled(ByVal enabled As Boolean)
        txtDefaultbackupDir.Enabled = enabled
        txtDefaultDatadir.Enabled = enabled
        txtDefaultLogDir.Enabled = enabled
        txtServerUser.Enabled = enabled
        txtServerPassword.Enabled = enabled
        chkServerUseIntegratedSecurity.Enabled = enabled

        btnTestConnection.Enabled = enabled
        btnGetDefaultBackupdir.Enabled = enabled
        btnGetDefaultDatadir.Enabled = enabled
        btnGetDefaultLogDir.Enabled = enabled
        btnSaveChanges.Enabled = enabled
        btnRemoveSelected.Enabled = enabled
    End Sub

    Private Sub lbServers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbServers.SelectedIndexChanged
        If lbServers.SelectedIndex <> -1 Then
            lblServer.Text = lbServers.SelectedItem.ToString()

            txtDefaultbackupDir.Text = mySettings.GetServerDefaultBackupdir(lbServers.SelectedItem.ToString())
            txtDefaultDatadir.Text = mySettings.GetServerDefaultDatadir(lbServers.SelectedItem.ToString())
            txtDefaultLogDir.Text = mySettings.GetServerDefaultLogdir(lbServers.SelectedItem.ToString())
            txtServerUser.Text = mySettings.GetServerUsername(lbServers.SelectedItem.ToString())
            txtServerPassword.Text = mySettings.GetServerPassword(lbServers.SelectedItem.ToString())
            chkServerUseIntegratedSecurity.Checked = Convert.ToBoolean(mySettings.GetServerIntegratedSecurity(lbServers.SelectedItem.ToString()))

            btnTestConnection.Text = "Test it"
            btnTestConnection.ForeColor = Color.Black

            ToggleEnabled(True)
        Else
            ToggleEnabled(False)

            lblServer.Text = "No server selected"
        End If
    End Sub

    Private Sub btnSaveChanges_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveChanges.Click
        Try
            mySettings.SaveServer(lbServers.SelectedItem.ToString(), txtServerUser.Text, txtServerPassword.Text, chkServerUseIntegratedSecurity.Checked, txtDefaultDatadir.Text, txtDefaultbackupDir.Text, txtDefaultLogDir.Text)
            MessageBox.Show("Server saved...", "Server saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Server not saved. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub chkServerUseIntegratedSecurity_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkServerUseIntegratedSecurity.CheckedChanged
        If chkServerUseIntegratedSecurity.Checked Then
            txtServerUser.Enabled = False
            txtServerPassword.Enabled = False
        Else
            txtServerUser.Enabled = True
            txtServerPassword.Enabled = True
        End If
    End Sub
#End Region

End Class