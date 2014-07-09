





Class cSettings
    Private _sFilepath As String
    Private _dsConfig As dsSettings

    Public Sub New(ByVal sFilepath As String)
        _sFilepath = sFilepath

        ReadXML()
    End Sub

    Private Sub ReadXML()
        _dsConfig = New dsSettings()
        Try
            _dsConfig.ReadXml(_sFilepath)
        Catch
            'write new config file
            _dsConfig.WriteXml(_sFilepath)
        End Try

    End Sub

    Public Function GetServers() As DataTable
        Return _dsConfig.dtSettings
    End Function

    Public Function GetServerPassword(ByVal sServername As String) As String
        Return GetSettingsRow(sServername).Password
    End Function

    Public Function GetServerDefaultDatadir(ByVal sServername As String) As String
        Return GetSettingsRow(sServername).DefaultDataDir
    End Function

    Public Function GetServerDefaultBackupdir(ByVal sServername As String) As String
        Return GetSettingsRow(sServername).DefaultBackupDir
    End Function

    Public Function GetServerDefaultLogdir(ByVal sServername As String) As String
        Return GetSettingsRow(sServername).DefaultLogDir
    End Function

    Public Function GetServerUsername(ByVal sServername As String) As String
        Return GetSettingsRow(sServername).Username
    End Function

    Public Function GetServerIntegratedSecurity(ByVal sServername As String) As Boolean
        Return GetSettingsRow(sServername).UseIntegrated
    End Function

    Public Function ServerHasAllSettings(ByVal sServername As String) As Boolean
        If GetServerDefaultBackupdir(sServername) = "" Then
            Return False
        End If

        If GetServerDefaultDatadir(sServername) = "" Then
            Return False
        End If

        If GetServerDefaultLogdir(sServername) = "" Then
            Return False
        End If

        If GetServerIntegratedSecurity(sServername) OrElse (GetServerUsername(sServername) <> "" OrElse GetServerPassword(sServername) <> "") Then
            Return True
        End If

        'else return false;
        Return False
    End Function

    Public Sub SaveServer(ByVal sServername As String, ByVal sUsername As String, ByVal sPassword As String, ByVal bUseIntegrated As Boolean, ByVal sDatadir As String, ByVal sBackupdir As String, _
     ByVal sLogdir As String)
        Dim row As dsSettings.dtSettingsRow
        row = DirectCast(_dsConfig.dtSettings.[Select]("Servername='" & sServername & "'")(0), dsSettings.dtSettingsRow)
        row.Username = sUsername
        row.Password = sPassword
        row.UseIntegrated = bUseIntegrated
        row.DefaultDataDir = sDatadir
        row.DefaultBackupDir = sBackupdir
        row.DefaultLogDir = sLogdir

        'check dirs
        If Not cHelper.CheckFilePathRegex(sDatadir) Then
            Throw New Exception("You can't use this datadir: " & sDatadir & ". No UNC paths...and don't forget the trailing slash!")
        End If

        If Not cHelper.CheckFilePathRegex(sBackupdir) Then
            Throw New Exception("You can't use this backupdir: " & sBackupdir & ". No UNC paths...and don't forget the trailing slash!")
        End If

        If Not cHelper.CheckFilePathRegex(sLogdir) Then
            Throw New Exception("You can't use this logdir: " & sBackupdir & ". No UNC paths...and don't forget the trailing slash!")
        End If

        'check login info
        If (sUsername = "" OrElse sPassword = "") AndAlso Not (bUseIntegrated = True) Then
            Throw New Exception("Please specify a username and passwort or choose integrated security.")
        End If

        If cHelper.CheckFilePathRegex(sBackupdir) AndAlso cHelper.CheckFilePathRegex(sDatadir) AndAlso Not ((sUsername = "" OrElse sPassword = "") AndAlso Not (bUseIntegrated = True)) Then
            WriteXML()
        End If
    End Sub

    Private Function GetSettingsRow(ByVal sServername As String) As dsSettings.dtSettingsRow
        Return DirectCast(_dsConfig.dtSettings.[Select]("Servername='" & sServername & "'")(0), dsSettings.dtSettingsRow)
    End Function

    Private Sub WriteXML()
        ' Create the FileStream to write with.
        Dim myFileStream As New System.IO.FileStream(_sFilepath, System.IO.FileMode.Create)

        ' Create an XmlTextWriter with the fileStream.
        Dim myXmlWriter As New System.Xml.XmlTextWriter(myFileStream, System.Text.Encoding.Unicode)

        ' Write to the file with the WriteXml method.
        _dsConfig.WriteXml(myXmlWriter)
        myXmlWriter.Close()
    End Sub

    Public Sub AddServer(ByVal sServername As String)
        Dim row As DataRow = _dsConfig.dtSettings.NewRow()

        row("Servername") = sServername
        row("Username") = ""
        row("Password") = ""
        row("UseIntegrated") = "false"
        row("DefaultDataDir") = ""
        row("DefaultBackupDir") = ""
        row("DefaultLogDir") = ""

        _dsConfig.dtSettings.Rows.Add(row)
        WriteXML()
    End Sub

    Public Sub RemoveServer(ByVal sServername As String)
        Dim row As dsSettings.dtSettingsRow
        row = DirectCast(_dsConfig.dtSettings.[Select]("Servername='" & sServername & "'")(0), dsSettings.dtSettingsRow)
        row.Delete()
        WriteXML()
    End Sub
End Class
