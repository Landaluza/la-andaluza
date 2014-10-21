Public Class frmBotasTapones
    inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlBot As ctlBotasTapones
    Private dtsBot As dtsBotasTapones.BotasTaponesDataTable

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctlBot = New ctlBotasTapones
        dtsBot = New dtsBotasTapones.BotasTaponesDataTable
    End Sub

    Protected Overrides Sub cargar_datos()
        ctlBot.mostrarTodosBotasTapones(dtb, dtsBot)
    End Sub
    Protected Overrides Sub BindDataSource()

        GeneralBindingSource.DataMember = "BotasTapones"
        GeneralBindingSource.DataSource = dtsBot
        dgvGeneral.DataSource = GeneralBindingSource
        dgvGeneral.Columns(0).Visible = False
        dgvGeneral.Columns(1).ReadOnly = True
    End Sub

#Region "Sobrecargas BindingNavigator"

    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntBotasTapones
        FrmEnt.Text = "Insertar Botas Tapones"
        FrmEnt.CargarDatos(0, 0, "")
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        ctlBot.mostrarTodosBotasTapones(dtb, dtsBot)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntBotasTapones
            FrmEnt.Text = "Modificar Botas Tapones"
            FrmEnt.CargarDatos(Posicion, _
                                (dgvGeneral.Rows(Posicion).Cells(0).Value), _
                                Convert.ToString(dgvGeneral.Rows(Posicion).Cells(1).Value))
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
            ctlBot.mostrarTodosBotasTapones(dtb, dtsBot)
            GeneralBindingSource.Position = 1
            GeneralBindingSource.Position = Posicion
        Else
            messageBox.show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntBotasTapones
            FrmEnt.Text = "Ver Botas Tapones"
            FrmEnt.CargarDatos(Posicion, _
                        (dgvGeneral.Rows(Posicion).Cells(0).Value), _
                      Convert.ToString(dgvGeneral.Rows(Posicion).Cells(1).Value))
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Else
            messageBox.show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Eliminar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim response As DialogResult
            response = messageBox.show(" ¿Realmente desea eliminar este registro? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If response = DialogResult.Yes Then
                ctlBot.SetBotaTaponID((dgvGeneral.Rows(Posicion).Cells(0).Value))
                ctlBot.EliminarBotaTapon()
                ctlBot.mostrarTodosBotasTapones(dtb, dtsBot)
                If Posicion > 0 Then
                    GeneralBindingSource.Position = Posicion - 1
                Else
                    GeneralBindingSource.Position = 0
                End If
            End If
        Else
            messageBox.show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

  
End Class
