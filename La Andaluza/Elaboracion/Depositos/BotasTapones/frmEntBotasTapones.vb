Public Class frmEntBotasTapones
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private dtsBot As New dtsBotasTapones.BotasTaponesDataTable
    Private ctlBot As New ctlBotasTapones
    Public Sub New()
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()
        dtsBot = New dtsBotasTapones.BotasTaponesDataTable
        ctlBot = New ctlBotasTapones
    End Sub
    Overrides Sub Guardar()
        Try
            ctlBot.GuardarBotaTapon(dtb, DescripcionCuadroDeTexto.Text)
        Catch ex As Exception
            messageBox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmEntBotasTapones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlBot.mostrarTodosBotasTapones(dtb, dtsBot)
            GeneralBindingSource.DataSource = dtsBot
            GeneralBindingSource.Position = Posicion
        End If
    End Sub

    Public Sub CargarDatos(ByVal Pos As Integer, ByVal BotaTaponID As Integer, _
               ByVal Descripcion As String)
        Posicion = pos
        ctlBot.SetBotaTaponID(BotaTaponID)
        DescripcionCuadroDeTexto.text = Descripcion
        DescripcionCuadroDeTexto.EsUnicoID = BotaTaponID
    End Sub


End Class
