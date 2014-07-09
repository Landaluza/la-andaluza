﻿Public Class Config
    'Public Const SOCKET_PORT As Integer = 8090
    'Public Const SOCKET_SERVER_IP As String = "192.168.1.47"

    Public Shared ServerName As String
    Public Shared QS_Sesion As String

    Public Shared UserType As Integer
    'Public Shared Property UserPermission As Integer
    Public Shared Worker As Integer
    Public Shared UserName As String

    Public Shared dataFillNotificaction As Boolean
    Public Shared MailClientHost As String
    Public Shared MailAddress As String
    Public Shared MailPass As String
    Public Shared MailReportAddress As String
    Public Shared MailReportPass As String
    Public Shared HelpUrl As String
    Public Shared UsuariosProductos As Integer() = {2, 3, 21}

    Private Shared ventasPath As String
    Private Shared ventaslocalPath As String
    Private Shared versionApp As String


    Public Shared Sub Cargar_Ajustes_Predeterminados()
        BasesParaCompatibilidad.Config.Server = BasesParaCompatibilidad.DataBase.LOCAL
        BasesParaCompatibilidad.DataBase.buildConnectionString(BasesParaCompatibilidad.Config.Server)
        Config.MailReportPass = "Administracion2008"
        Config.HelpUrl = "http://192.168.1.106/AyudaLA/index.php"
        Config.ventasPath = "Z:\Informatica\La Andaluza app\ExcelFile\Book1.xlsx"
        Config.MailReportAddress = "administracion@landaluza.es"
        Config.MailClientHost = "smtp.1and1.es"
        Config.QS_Sesion = "Sesión A - [24 x 80]"
        'Config.QS_Sesion = "Sesión A"

        Select Case BasesParaCompatibilidad.Config.Server
            Case BasesParaCompatibilidad.DataBase.SERVIDOR
                Config.ServerName = "Produccion"
            Case BasesParaCompatibilidad.DataBase.LOCAL
                Config.ServerName = "Local"
            Case Else
                Config.ServerName = "Otro"
        End Select
    End Sub

    Public Shared ReadOnly Property Version_seriada As String
        Get
            Return versionApp
        End Get
    End Property

    Public Shared ReadOnly Property RutaVentasServidor As String
        Get
            Return ventasPath
        End Get
    End Property

    Public Shared ReadOnly Property RutaVentasLocal As String
        Get
            Return ventaslocalPath
        End Get
    End Property

    'Public Function CargarMenuPersonal() As Collection
    '    Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "menu.obj"
    '    Dim f As New File
    '    Dim obj As Collection = f.loadObject(mydocpath)
    '    Return obj
    'End Function

    Public Function checkFiles() As Boolean
        Try
            If System.IO.File.Exists(ventasPath) Then
                ventaslocalPath = Application.StartupPath & "\ExcelFile\Book1.xlsx"

                If System.IO.File.Exists(ventaslocalPath) Then
                    'Dim sourceFile As New System.IO.FileInfo(ventasPath)
                    'Dim destFile As New System.IO.FileInfo(ventaslocalPath)

                    'If destFile.LastWriteTime >= sourceFile.LastWriteTime Then
                    System.IO.File.Delete(ventaslocalPath)
                    System.IO.File.Copy(ventasPath, ventaslocalPath)
                    'End If

                Else
                    System.IO.File.Copy(ventasPath, ventaslocalPath)
                End If

            End If
            Return True
        Catch ex As Exception
            ventaslocalPath = ventasPath
            Return False
        End Try
    End Function

    Public Function NumeroVersion() As String
        ' •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
        ' | if running the deployed application, you can get the version from the ApplicationDeployment information. If you try |
        ' | to access this when you are running in Visual Studio, it will not work.                                             |
        ' •————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————•
        Dim ourVersion As String
        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            ourVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        Else
            ourVersion = My.Application.Info.Version.ToString 'Si estamos en Visual Basic se muestra el numero <Assembly: AssemblyFileVersion("1.0.0.19")> del fichero AssemblyInfo.vb
        End If

        Return ourVersion
    End Function

    Public Sub calcular_version()
        Select Case Convert.ToString(My.Application.Info.Version).Length
            Case Is > 11
                Config.versionApp = "LA " & Convert.ToString(My.Application.Info.Version).Substring(0, 10) '& " -- " & String.Format("Version {0}", NumeroVersion())
            Case Is = 11
                Config.versionApp = "LA " & Convert.ToString(My.Application.Info.Version).Substring(0, 9) '& " -- " & String.Format("Version {0}", NumeroVersion())
            Case Is = 10
                Config.versionApp = "LA " & Convert.ToString(My.Application.Info.Version).Substring(0, 8) '& " -- " & String.Format("Version {0}", NumeroVersion())
            Case Else
                Config.versionApp = "LA " & Convert.ToString(My.Application.Info.Version).Substring(0, 7) '& " -- " & String.Format("Version {0}", NumeroVersion())
        End Select
    End Sub
End Class
