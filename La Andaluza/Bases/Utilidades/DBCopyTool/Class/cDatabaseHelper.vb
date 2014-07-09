Imports System.Data


Public Delegate Sub ProgressEventHandler(ByVal sender As Object, ByVal e As ProgressEventArgs)

Class cDatabaseHelper

    Public Event Progress As ProgressEventHandler

    Private _con As System.Data.SqlClient.SqlConnection
    Private _sDatabaseName As String

    Private _internalError As String = ""

    ''' <summary>
    ''' Constructor for cDatabasehelper
    ''' </summary>
    ''' <param name="sServername">Name/IP of the server to connect to</param>
    ''' <param name="bUseIntegratedSecurity">Use integrated security</param>
    ''' <param name="sUsername">Server Username</param>
    ''' <param name="sPassword">Server Password</param>
    ''' <param name="sDatabaseName">Initial Database</param>
    Public Sub New(ByVal sServername As String, ByVal bUseIntegratedSecurity As Boolean, ByVal sUsername As String, ByVal sPassword As String, ByVal sDatabaseName As String)
        _con = New System.Data.SqlClient.SqlConnection()
        _con.ConnectionString = BuildConnectionString(sServername, bUseIntegratedSecurity, sUsername, sPassword, sDatabaseName)
        AddHandler _con.InfoMessage, New System.Data.SqlClient.SqlInfoMessageEventHandler(AddressOf _con_InfoMessage)

        _sDatabaseName = sDatabaseName
    End Sub

    ''' <summary>
    ''' Fired by connection on sql server infomessage.
    ''' Used to report the progress of a backup or restore operation
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _con_InfoMessage(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs)
        'the progress information is a PRINT information with error.class = 0
        'if a REAL error occurs, then the program has to save this error because it's not
        'possible to throw an exception to the db-call :-(
        If e.Errors.Count > 0 Then
            If e.Errors(0).[Class] > 0 Then
                'save error for use
                _internalError += e.Message & " "
            End If
        End If

        'prepare progress information and raise event for caller
        Dim myMsg As String = e.Message
        Dim sProgress As String
        Dim iProgress As Integer
        'get the first three characters from message
        sProgress = e.Message.Substring(0, 3)

        Try
            'if we can convert the first three characters to an int then it's ok
            'for example the message "51 percent completed" will result in 51
            iProgress = Convert.ToInt32(sProgress)

            'fire progress event
            RaiseEvent Progress(Me, New ProgressEventArgs(iProgress))
            'nothing to catch here, if we can't convert...who cares?                     
        Catch
        End Try

    End Sub

    ''' <summary>
    ''' Gets all user databases for this connection
    ''' </summary>
    ''' <returns>Table with all database names</returns>
    Public Function GetDatabases() As DataTable
        Dim cmd As New System.Data.SqlClient.SqlCommand()
        cmd.Connection = _con

        'get all user databases ordered by name
        cmd.CommandText = "select name from sys.databases where name not in ('master', 'model', 'msdb', 'tempdb') order by name"

        Dim reader As System.Data.SqlClient.SqlDataReader
        Dim dt As New DataTable()

        'get data
        Try
            Connect()
            reader = cmd.ExecuteReader()
            dt.Load(reader)
            DisconnectDB()
        Catch ex As Exception
            Throw New Exception("Error getting the databases. " & ex.Message)
        End Try

        Return dt
    End Function

    ''' <summary>
    ''' Tests the connection to the server
    ''' </summary>
    ''' <returns>true if suceeded</returns>
    Public Function TestConnection() As Boolean
        Try
            Connect()
            Return True
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Gets the default backup dir of the sql server
    ''' </summary>
    ''' <returns>default backup dir</returns>
    Public Function GetDefaultBackupdir() As String
        Dim sBackupDir As String
        Dim cmd As New System.Data.SqlClient.SqlCommand()
        cmd.Connection = _con

        cmd.CommandText = "declare @path nvarchar(1000);" & " EXEC master.dbo.xp_instance_regread N'hkey_local_machine',N'software\microsoft\mssqlserver\mssqlserver',N'backupdirectory', @path output, 'no_output' " & " SELECT @path + '\' BackupPath;"

        Try
            Connect()
            sBackupDir = cmd.ExecuteScalar().ToString()
            DisconnectDB()
        Catch ex As Exception
            Throw New Exception("Error getting the default backup directory. " & ex.Message)
        End Try

        Return sBackupDir
    End Function

    ''' <summary>
    ''' Gets the default data dir of the sql server
    ''' </summary>
    ''' <returns>default data dir</returns>
    Public Function GetDefaultDatadir() As String
        Dim sDatadir As String
        Dim cmd As New System.Data.SqlClient.SqlCommand()
        cmd.Connection = _con

        cmd.CommandText = "declare @path nvarchar(1000); " & "exec master.dbo.xp_instance_regread N'hkey_local_machine',N'software\microsoft\mssqlserver\setup',N'sqldataroot', @path output, 'no_output' " & "SELECT @path + '\Data\' DataPath;"

        Try
            Connect()
            sDatadir = cmd.ExecuteScalar().ToString()
            DisconnectDB()
        Catch ex As Exception
            Throw New Exception("Error getting the default data directory. " & ex.Message)
        End Try

        Return sDatadir
    End Function

    ''' <summary>
    ''' Gets the default log dir of the sql server
    ''' </summary>
    ''' <returns>default data dir</returns>
    Public Function GetDefaultLogdir() As String
        Dim sDatadir As String
        Dim cmd As New System.Data.SqlClient.SqlCommand()
        cmd.Connection = _con


        cmd.CommandText = "declare @path nvarchar(1000); " & "  exec master.dbo.xp_instance_regread N'hkey_local_machine',N'software\microsoft\mssqlserver\mssqlserver',N'defaultlog', @path output, 'no_output'" & "  if @path IS NOT NULL" & "      BEGIN" & "          select @path + '\'" & "      END" & "      ELSE" & "      BEGIN" & "          exec master.dbo.xp_instance_regread N'hkey_local_machine',N'software\microsoft\mssqlserver\setup',N'sqldataroot', @path output, 'no_output' " & "          SELECT @path + '\Data\' DataPath" & "      END"

        Try
            Connect()
            sDatadir = cmd.ExecuteScalar().ToString()
            DisconnectDB()
        Catch ex As Exception
            Throw New Exception("Error getting the default log directory. " & ex.Message)
        End Try

        Return sDatadir
    End Function

    ''' <summary>
    ''' Build the connection string
    ''' </summary>
    ''' <param name="sServername"></param>
    ''' <param name="bUseIntegratedSecurity"></param>
    ''' <param name="sUsername"></param>
    ''' <param name="sPassword"></param>
    ''' <param name="sDatabaseName"></param>
    ''' <returns></returns>
    Private Function BuildConnectionString(ByVal sServername As String, ByVal bUseIntegratedSecurity As Boolean, ByVal sUsername As String, ByVal sPassword As String, ByVal sDatabaseName As String) As String
        Dim conString As String

        conString = "Data Source="
        conString += sServername & ";"
        conString += "Initial Catalog="
        conString += sDatabaseName & ";"

        If Not bUseIntegratedSecurity Then
            conString += "User Id=" & sUsername & ";Password=" & sPassword & ";"
        Else
            conString += "Trusted_Connection=True;"
        End If

        Return conString
    End Function

    Private Sub DisconnectDB()
        Try
            _con.Close()
        Catch ex As Exception
            Throw New Exception("Error closing connection to BasesParaCompatibilidad.DataBase. " & ex.Message)
        End Try
    End Sub

    Private Sub Connect()
        Try
            _con.Open()
        Catch ex As Exception
            Throw New Exception("Error connecting to BasesParaCompatibilidad.DataBase. " & ex.Message)
        End Try
    End Sub

    Public Sub BackupDatabase(ByVal sDestinationFile As String)
        'Fire infomessageevent on every message
        'needed for progress information
        _con.FireInfoMessageEventOnUserErrors = True

        'prepare command text
        Dim cmdText As String
        cmdText = "BACKUP DATABASE [@@DbName@@] TO DISK = N'@@DestinationFile@@' WITH NOFORMAT, NOINIT, NAME=N'AutoBackupFromDBCopier',SKIP,NOREWIND,NOUNLOAD,STATS=10"
        cmdText = cmdText.Replace("@@DbName@@", _sDatabaseName)
        cmdText = cmdText.Replace("@@DestinationFile@@", sDestinationFile)

        Dim cmd As New System.Data.SqlClient.SqlCommand(cmdText, _con)
        'no timeout (large database => long backup)
        cmd.CommandTimeout = 0

        Try
            Connect()
            cmd.ExecuteNonQuery()
            DisconnectDB()

            'if we had an error (we don't get it in the surrounding try catch because of FireInfoMessageEventOnUserErrors = true)
            If _internalError <> "" Then
                'throw this error
                Throw New Exception(_internalError)
            End If
        Catch ex As Exception
            Throw New Exception("Error backing up the BasesParaCompatibilidad.DataBase. " & ex.Message)
        Finally
            DisconnectDB()
        End Try
    End Sub

    Public Sub RestoreDatabase(ByVal sDestinationDatabaseName As String, ByVal sBackupFilename As String, ByVal sDestinationDataFolder As String, ByVal sDestinationLogFolder As String)
        Dim cmd As New System.Data.SqlClient.SqlCommand()

        'no timeout (large backup...)
        cmd.CommandTimeout = 0

        Dim sRestoreCommand As String
        cmd.Connection = _con

        'Get filenames of database files
        cmd.CommandText = "RESTORE FILELISTONLY FROM  DISK = N'" & sBackupFilename & "';"

        'Prepare restore command
        sRestoreCommand = "RESTORE DATABASE [" & sDestinationDatabaseName & "] FROM DISK = N'" & sBackupFilename & "' WITH FILE=1 "

        'connect to server
        Connect()

        Dim reader As System.Data.SqlClient.SqlDataReader

        Try
            reader = cmd.ExecuteReader()

            'add filenames for restore
            Dim iDataFiles As Integer = 0
            Dim iLogFiles As Integer = 0
            While reader.Read()
                sRestoreCommand += ",MOVE N'" & Convert.ToString(reader(0)) & "' TO N'"



                If reader(2).ToString() = "D" Then
                    sRestoreCommand += sDestinationDataFolder
                    sRestoreCommand += sDestinationDatabaseName
                    If iDataFiles > 0 Then
                        sRestoreCommand += "_" & iDataFiles
                    End If

                    sRestoreCommand += ".mdf'"
                    iDataFiles += 1
                End If

                If reader(2).ToString() = "L" Then
                    sRestoreCommand += sDestinationLogFolder
                    sRestoreCommand += sDestinationDatabaseName
                    If iLogFiles > 0 Then
                        sRestoreCommand += "_" & iLogFiles
                    End If
                    sRestoreCommand += "_Log.ldf'"
                    iLogFiles += 1
                End If
            End While
            sRestoreCommand += ", NOUNLOAD, REPLACE, STATS = 10"

            reader.Close()

            'Fire infomessageevent on every message
            'needed for progress information
            _con.FireInfoMessageEventOnUserErrors = True

            'execute restore
            cmd.CommandText = sRestoreCommand
            cmd.ExecuteNonQuery()

            'if we had an error (we don't get it in the surrounding try catch because of FireInfoMessageEventOnUserErrors = true)
            If _internalError <> "" Then
                'throw this error
                Throw New Exception(_internalError)
            End If
        Catch ex As Exception
            Throw New Exception("Error restoring the BasesParaCompatibilidad.DataBase. " & ex.Message)
        End Try

        'disconnect
        DisconnectDB()

    End Sub
End Class
