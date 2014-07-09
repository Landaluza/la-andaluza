Public Class frmEntBotasTapones
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Dim dtsBot As New dtsBotasTapones.BotasTaponesDataTable
    Dim ctlBot As New ctlBotasTapones

    Overrides Sub Guardar()
        Try
            ctlBot.GuardarBotaTapon(DescripcionCuadroDeTexto.Text)
        Catch ex As Exception
            messageBox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmEntBotasTapones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlBot.mostrarTodosBotasTapones(dtsBot)
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
