Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Data

Public Class cProgram
    Private Sub New()
    End Sub
    

    '<DllImport("user32.dll")> _
    Private Shared Function ShowWindow(ByVal hWnd As IntPtr, ByVal nCmdShow As Integer) As Boolean
        Return True
    End Function

    Private Shared _settings As cSettings
    Private Shared _progress As Integer

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Private Shared Sub Main(ByVal args As String())
        Console.Title = "SQL Server Database Copy Tool"

        _settings = New cSettings(Application.StartupPath & "\config.xml")

        'check if we are in commandline with arguments
        If args.Length > 0 Then
            If args.Length = 4 Then
                'do things
                Dim sFromServer As String = args(0)
                Dim sToServer As String = args(1)
                Dim sFromDatabase As String = args(2)
                Dim sToDatabase As String = args(3)

                If Not PreCheckServer(sFromServer) OrElse Not PreCheckServer(sToServer) Then
                    Application.[Exit]()
                Else
                    Dim dbc As New cDatabaseCopy()
                    'dbc.Progress += New ProgressEventHandler(AddressOf OperationProgress)
                    'dbc.StepChanged += New StepsEventHandler(AddressOf StepChanged)

                    Try
                        dbc.CopyDatabase(_settings.GetServerDefaultBackupdir(sFromServer), sFromDatabase, sToDatabase, _settings.GetServerDefaultDatadir(sToServer), _settings.GetServerDefaultBackupdir(sToServer), _settings.GetServerDefaultLogdir(sToServer), _
                         sFromServer, sToServer, _settings.GetServerUsername(sFromServer), _settings.GetServerPassword(sFromServer), _settings.GetServerIntegratedSecurity(sFromServer), _settings.GetServerUsername(sToServer), _
                         _settings.GetServerPassword(sToServer), _settings.GetServerIntegratedSecurity(sToServer))
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                        Console.WriteLine("Exiting...")
                        Application.[Exit]()

                    End Try
                End If
            Else
                Console.WriteLine("No chance...! Use DbCopyTool.exe YOUR_FROM_SERVER YOUR_TO_SERVER YOUR_FROM_DB YOUR_TO_DB")
                Console.WriteLine("Exiting...")
            End If
        Else
            'hide console
            setConsoleWindowVisibility(False, Console.Title)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim main__1 As New frmDBTools()
            Application.Run(main__1)
        End If

        setConsoleWindowVisibility(True, Console.Title)
    End Sub

    Private Shared Sub OperationProgress(ByVal sender As Object, ByVal e As ProgressEventArgs)
        Dim old As Integer = _progress
        _progress = Convert.ToInt32(Math.Truncate(CSng(e.Progress) / 10.0)) * 10
        If _progress > old Then
            Console.WriteLine(_progress & " % ")
        End If

        Application.DoEvents()
    End Sub

    Private Shared Sub StepChanged(ByVal sender As Object, ByVal e As StepsEventArgs)
        If e.[Step] = Steps.BACKUP Then
            Console.WriteLine()
            Console.WriteLine("Creating Backup...")
        End If

        If e.[Step] = Steps.COPY Then
            'Copy backupfile to dest
            Console.WriteLine()
            Console.WriteLine("Copiing file...")
        End If

        If e.[Step] = Steps.RESTORE Then
            Console.WriteLine()
            Console.WriteLine("Restoring BasesParaCompatibilidad.DataBase...")
        End If

        If e.[Step] = Steps.IDLE Then
            Console.WriteLine()
            Console.WriteLine("Sucessfully copied BasesParaCompatibilidad.DataBase...")
        End If
    End Sub

    Private Shared Function PreCheckServer(ByVal sServername As String) As Boolean
        Dim bServerIsOk As Boolean = True

        'check if server exists and has all settings
        If Not _settings.GetServers().Rows.Contains(sServername) Then
            Console.WriteLine("The server {0} does not exist in your configuration. Please start DbCopyTool without parameters and add it...", sServername)
            bServerIsOk = False
        Else
            If Not _settings.ServerHasAllSettings(sServername) Then
                Console.WriteLine("Some settings for your server {0} are missing. Please start DbCopyTool without parameters and add them...", sServername)
                bServerIsOk = False
            End If
        End If
        Return bServerIsOk
    End Function


    Public Shared Sub setConsoleWindowVisibility(ByVal visible As Boolean, ByVal title As String)
        Dim hWnd As IntPtr = BasesParaCompatibilidad.NativeMethods.FindWindow(Nothing, title)

        If hWnd <> IntPtr.Zero Then
            If Not visible Then
                'Hide the window                   
                ShowWindow(hWnd, 0)
            Else
                ' 0 = SW_HIDE               
                'Show window again                   
                ShowWindow(hWnd, 1)
                '1 = SW_SHOWNORMA          
            End If
        End If
    End Sub
End Class
