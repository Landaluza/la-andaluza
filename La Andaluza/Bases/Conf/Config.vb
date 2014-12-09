Public Class Config
    'Public Const SOCKET_PORT As Integer = 8090
    'Public Const SOCKET_SERVER_IP As String = "192.168.10.47"

    Public Shared ServerName As String
    Public Shared QS_Sesion As String

    Public Shared UserType As Integer
    'Public Shared Property UserPermission As Integer
    Public Shared Worker As Integer
    'Public Shared UserName As String

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
    Private Shared InformeListadoDepositos As String
    Private Shared InformeListadoDepositosTipos As String
    Private Shared InformeListadoPedidosPendientes As String
    Private Shared InformeListadoPedidosPendientesPorFecha As String
    Private Shared InformeListadoPedidosPendientesPorProveedores As String
    Private Shared InformeListadoPedidosPendientesUnaFecha As String
    Private Shared InformeListadoPedidosPendientesUnProveedor As String
    Private Shared InformeListadoPedidosPendientesIncumplidos As String
    Private Shared ruta_servidor As String
    Private Shared versionApp As String

    Public Shared Sub Cargar_Ajustes_Predeterminados()
        ruta_servidor = "\\192.168.10.200\datos\informatica\La Andaluza app\"



        BasesParaCompatibilidad.Config.Server = BasesParaCompatibilidad.DataBase.LOCAL
        BasesParaCompatibilidad.DataBase.buildConnectionString(BasesParaCompatibilidad.Config.Server)

        Config.HelpUrl = "http://192.168.10.106/AyudaLA/index.php"
        'Config.ventasPath = "Z:\Informatica\La Andaluza app\ExcelFile\Book1.xlsx"
        Config.ventasPath = "ExcelFile\Book1.xlsx"
        Config.InformeListadoDepositos = "Depositos.frx"
        Config.InformeListadoDepositosTipos = "ListadoDepositosPorTipos.frx"
        Config.InformeListadoPedidosPendientes = "report1.frx"
        Config.InformeListadoPedidosPendientesPorFecha = "listadoPedidosPendientesFecha.frx"
        Config.InformeListadoPedidosPendientesPorProveedores = "listadoPedidosPendientesProveedor.frx"
        Config.InformeListadoPedidosPendientesUnaFecha = "listadoPedidosPendientesDia.frx"
        Config.InformeListadoPedidosPendientesUnProveedor = "listadoPedidosPendientesunProveedor.frx"
        Config.InformeListadoPedidosPendientesIncumplidos = "listadoPedidosPendientesIncumplida.frx"
        Config.MailReportPass = "Administracion2008"
        Config.MailReportAddress = "administracion@landaluza.es"
        Config.MailClientHost = "smtp.1and1.es"
        Envasado.Config.MailReportPass = "Administracion2008"
        Envasado.Config.MailReportAddress = "administracion@landaluza.es"
        Envasado.Config.MailClientHost = "smtp.1and1.es"

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

        Config.load()
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

    Public Shared ReadOnly Property ListadoDepositos As String
        Get
            Return InformeListadoDepositos
        End Get
    End Property

    Public Shared ReadOnly Property ListadoDepositosTipos As String
        Get
            Return InformeListadoDepositosTipos
        End Get
    End Property

    Public Shared ReadOnly Property PedidosPendientes As String
        Get
            Return InformeListadoPedidosPendientes
        End Get
    End Property

    Public Shared ReadOnly Property PedidosPendientesPorFecha As String
        Get
            Return InformeListadoPedidosPendientesPorFecha
        End Get
    End Property

    Public Shared ReadOnly Property PedidosPendientesUnaFecha As String
        Get
            Return InformeListadoPedidosPendientesUnaFecha
        End Get
    End Property
    Public Shared ReadOnly Property PedidosPendientesPorProveedores As String
        Get
            Return InformeListadoPedidosPendientesPorProveedores
        End Get
    End Property

    Public Shared ReadOnly Property PedidosPendientesUnProveedor As String
        Get
            Return InformeListadoPedidosPendientesUnProveedor
        End Get
    End Property

    Public Shared ReadOnly Property PedidosPendientesIncumplidos As String
        Get
            Return InformeListadoPedidosPendientesIncumplidos
        End Get
    End Property

    'Public Function CargarMenuPersonal() As Collection
    '    Dim mydocpath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "menu.obj"
    '    Dim f As New File
    '    Dim obj As Collection = f.loadObject(mydocpath)
    '    Return obj
    'End Function

    Public Function checkFiles() As Boolean
        Dim retorno As Boolean = True

        If Config.InformeListadoDepositos.Contains(Config.ruta_servidor) Or Config.InformeListadoDepositos.Contains(Application.StartupPath) Then
            Return retorno
        End If

        Dim tempPath As String
        Dim ruta_servidor_ventas As String = Config.ruta_servidor & Config.ventasPath
        Dim ruta_servidor_depositos As String = Config.ruta_servidor & Config.InformeListadoDepositos
        Dim ruta_servidor_depositos_tipos As String = Config.ruta_servidor & Config.InformeListadoDepositosTipos
        Dim ruta_servidor_pedidos As String = Config.ruta_servidor & Config.InformeListadoPedidosPendientes
        Dim ruta_servidor_pedidos_fecha As String = Config.ruta_servidor & Config.InformeListadoPedidosPendientesPorFecha
        Dim ruta_servidor_pedidos_proveedores As String = Config.ruta_servidor & Config.InformeListadoPedidosPendientesPorProveedores
        Dim ruta_servidor_pedidos_una_fecha As String = Config.ruta_servidor & Config.InformeListadoPedidosPendientesUnaFecha
        Dim ruta_servidor_pedidos_un_proveedor As String = Config.ruta_servidor & Config.InformeListadoPedidosPendientesUnProveedor
        Dim ruta_servidor_pedidos_incumplidos As String = Config.ruta_servidor & Config.InformeListadoPedidosPendientesIncumplidos

        Try
            If System.IO.File.Exists(ruta_servidor_ventas) Then
                ventaslocalPath = Application.StartupPath & "\ExcelFile\Book1.xlsx"

                If System.IO.File.Exists(ventaslocalPath) Then
                    'Dim sourceFile As New System.IO.FileInfo(ventasPath)
                    'Dim destFile As New System.IO.FileInfo(ventaslocalPath)

                    'If destFile.LastWriteTime >= sourceFile.LastWriteTime Then
                    System.IO.File.Delete(ventaslocalPath)
                    System.IO.File.Copy(ruta_servidor_ventas, ventaslocalPath)
                    'End If

                Else
                    System.IO.File.Copy(ruta_servidor_ventas, ventaslocalPath)
                End If

            End If
        Catch ex As Exception
            ventaslocalPath = ruta_servidor_ventas
            retorno = False
        End Try

        Try
            tempPath = Application.StartupPath & InformeListadoDepositos

            If System.IO.File.Exists(ruta_servidor_depositos) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_depositos, tempPath)
                    Config.InformeListadoDepositos = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_depositos, tempPath)
                    Config.InformeListadoDepositos = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoDepositos = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoDepositos = ruta_servidor_depositos
            retorno = False
        End Try

        Try
            tempPath = Application.StartupPath & InformeListadoDepositosTipos

            If System.IO.File.Exists(ruta_servidor_depositos_tipos) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_depositos_tipos, tempPath)
                    Config.InformeListadoDepositosTipos = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_depositos_tipos, tempPath)
                    Config.InformeListadoDepositosTipos = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoDepositosTipos = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoDepositosTipos = ruta_servidor_depositos_tipos
            retorno = False
        End Try

        Try
            tempPath = Application.StartupPath & InformeListadoPedidosPendientes

            If System.IO.File.Exists(ruta_servidor_pedidos) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_pedidos, tempPath)
                    Config.InformeListadoPedidosPendientes = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_pedidos, tempPath)
                    Config.InformeListadoPedidosPendientes = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoPedidosPendientes = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoPedidosPendientes = ruta_servidor_pedidos
            retorno = False
        End Try

        Try
            tempPath = Application.StartupPath & InformeListadoPedidosPendientesPorFecha

            If System.IO.File.Exists(ruta_servidor_pedidos_fecha) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_pedidos_fecha, tempPath)
                    Config.InformeListadoPedidosPendientesPorFecha = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_pedidos_fecha, tempPath)
                    Config.InformeListadoPedidosPendientesPorFecha = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoPedidosPendientesPorFecha = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoPedidosPendientesPorFecha = ruta_servidor_pedidos_fecha
            retorno = False
        End Try

        Try
            tempPath = Application.StartupPath & InformeListadoPedidosPendientesPorProveedores

            If System.IO.File.Exists(ruta_servidor_pedidos_proveedores) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_pedidos_proveedores, tempPath)
                    Config.InformeListadoPedidosPendientesPorProveedores = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_pedidos_proveedores, tempPath)
                    Config.InformeListadoPedidosPendientesPorProveedores = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoPedidosPendientesPorProveedores = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoPedidosPendientesPorProveedores = ruta_servidor_pedidos_proveedores
            retorno = False
        End Try

        Try
            tempPath = Application.StartupPath & InformeListadoPedidosPendientesIncumplidos

            If System.IO.File.Exists(ruta_servidor_pedidos_incumplidos) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_pedidos_incumplidos, tempPath)
                    Config.InformeListadoPedidosPendientesIncumplidos = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_pedidos_incumplidos, tempPath)
                    Config.InformeListadoPedidosPendientesIncumplidos = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoPedidosPendientesIncumplidos = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoPedidosPendientesIncumplidos = ruta_servidor_pedidos_incumplidos
            retorno = False
        End Try


        Try
            tempPath = Application.StartupPath & InformeListadoPedidosPendientesUnaFecha

            If System.IO.File.Exists(ruta_servidor_pedidos_una_fecha) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_pedidos_una_fecha, tempPath)
                    Config.InformeListadoPedidosPendientesUnaFecha = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_pedidos_una_fecha, tempPath)
                    Config.InformeListadoPedidosPendientesUnaFecha = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoPedidosPendientesUnaFecha = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoPedidosPendientesUnaFecha = ruta_servidor_pedidos_una_fecha
            retorno = False
        End Try


        Try
            tempPath = Application.StartupPath & InformeListadoPedidosPendientesUnProveedor

            If System.IO.File.Exists(ruta_servidor_pedidos_un_proveedor) Then

                If System.IO.File.Exists(tempPath) Then
                    System.IO.File.Delete(tempPath)
                    System.IO.File.Copy(ruta_servidor_pedidos_un_proveedor, tempPath)
                    Config.InformeListadoPedidosPendientesUnProveedor = tempPath
                Else
                    System.IO.File.Copy(ruta_servidor_pedidos_un_proveedor, tempPath)
                    Config.InformeListadoPedidosPendientesUnProveedor = tempPath
                End If
            Else
                If System.IO.File.Exists(tempPath) Then
                    Config.InformeListadoPedidosPendientesUnProveedor = tempPath
                End If
            End If
        Catch ex As Exception
            Config.InformeListadoPedidosPendientesUnProveedor = ruta_servidor_pedidos_un_proveedor
            retorno = False
        End Try

        Return retorno
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

    Public Shared Sub save()
        Dim options As New UserOptions
        Dim fil As New BasesParaCompatibilidad.File

        options.Screen = BasesParaCompatibilidad.Config.activeScreen
        Try
            fil.saveObject(options, Environment.SpecialFolder.MyDocuments & "options.opt")
        Catch ex As Exception

        End Try
    End Sub

    Public Shared Sub load()
        Dim fil As New BasesParaCompatibilidad.File
        Dim opt As UserOptions

        Try
            opt = fil.loadObject(Environment.SpecialFolder.MyDocuments & "options.opt")
            BasesParaCompatibilidad.Config.activeScreen = opt.Screen
        Catch ex As Exception
            BasesParaCompatibilidad.Config.activeScreen = 0
        End Try
    End Sub
End Class
