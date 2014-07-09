Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntDepositos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private dtsDep As New dtsDepositos.DepositosDataTable
    Private ctlDep As New ctlDepositos
    Private ctlMatCon As New spMaterialConstruccion 'ctlMaterialConstruccion
    Private ctlBotTap As New ctlBotasTapones
    Private ctlBotPos As New ctlBotasPosiciones
    Private OldLib As New OldLib

    Private spnaves As New spNaves

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        FechaCreacionDateTimePicker.activarFoco()
    End Sub

    Private Sub frmEntDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlDep.mostrarTodosDepositos(dtsDep)
            GeneralBindingSource.DataSource = dtsDep
            GeneralBindingSource.Position = Posicion
        End If
    End Sub

    Overrides Sub Guardar()
        Try
            If rbTonel.Checked Then
                If ctlDep.GetBotaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarBota()
                End If
                If ctlDep.GetTransicubaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarTransicuba()
                End If
                If ctlDep.GetBotasPiernaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarBotaPierna()
                End If
                ctlDep.GuardarTonel(cdDescripcionTonel.Text, txtContenidoHabitual.Text)
            ElseIf rbBota.Checked Then
                If ctlDep.GetTonelID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarTonel()
                End If
                If ctlDep.GetTransicubaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarTransicuba()
                End If
                If ctlDep.GetBotasPiernaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarBotaPierna()
                End If
                ctlDep.GuardarBota(BotaTaponIDComboMAM.SelectedValue, PosicionComboMAM.SelectedValue)
            ElseIf rbPiernas.Checked Then
                If ctlDep.GetTonelID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarTonel()
                End If
                If ctlDep.GetTransicubaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarTransicuba()
                End If
                If ctlDep.GetTransicubaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarTransicuba()
                End If
                ctlDep.GuardarBotaPierna(txtPiernasDescripcion.Text, txtPiernasContenido.Text)
            ElseIf rbTransicuba.Checked Then
                If ctlDep.GetBotaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarBota()
                End If
                If ctlDep.GetTonelID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarTonel()
                End If
                If ctlDep.GetBotasPiernaID > 0 Then
                    ctlDep.LimpiarDeposito()
                    ctlDep.EliminarBotaPierna()
                End If
                ctlDep.GuardarTransicuba(cdDescripcionTransicuba.Text, cbEstadoTransicuba.Checked)
            End If

            If Not rbTonel.Checked And Not rbBota.Checked And Not rbPiernas.Checked And Not rbTransicuba.Checked Then
                MessageBox.Show("Debes seleccionar un tipo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                ctlDep.GuardarDeposito(cdCodigo.Text, FechaCreacionDateTimePicker.Value, If(CapacidadCuadroDeTexto.Text = "" Or Convert.IsDBNull(CapacidadCuadroDeTexto.Text), "0", CapacidadCuadroDeTexto.Text), DoctoUbicacionfisicaCuadroDeTexto.Text, MaterialConstruccionIDComboMAM.SelectedValue, ListadoCheckBox.Checked)
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CargarDatos(ByVal Pos As Integer, _
                           ByVal DepositoID As Integer, _
                           ByVal Codigo As Integer, _
                           ByVal FechaCreacion As DateTime, _
                           ByVal Capacidad As Double, _
                           ByVal DoctoUbicacionFisica As String, _
                           ByVal TonelID As String, _
                           ByVal TransicubaID As String, _
                           ByVal BotaID As String, _
                           ByVal BotaPiernas As String, _
                           ByVal material As String, _
                           ByVal listado As Boolean)

        ctlDep.SetDepositoID(DepositoID)

        CapacidadCuadroDeTexto.Text = Capacidad
        cdCodigo.Text = Codigo
        DoctoUbicacionfisicaCuadroDeTexto.Text = DoctoUbicacionFisica


        BotaTaponIDComboMAM.DataSource = OldLib.HacerTablasObligatorias(ctlBotTap.devolverBotasTaponesPorDescripcion())
        BotaTaponIDComboMAM.ValueMember = "ID"
        BotaTaponIDComboMAM.DisplayMember = "Display"

        Me.spnaves.cargar_Naves(NaveComboMAM)
        'NaveComboMAM.DataSource = OldLib.HacerTablasObligatorias(ctlBotPos.devolverNaves())
        'NaveComboMAM.ValueMember = "ID"
        'NaveComboMAM.DisplayMember = "Display"

        Posicion = Pos
        FechaCreacionDateTimePicker.Value = FechaCreacion
        DepositoIDCuadroDeTexto.Text = DepositoID

        ctlMatCon.cargar_MaterialConstruccion(MaterialConstruccionIDComboMAM)
        'MaterialConstruccionIDComboMAM.DataSource = OldLib.HacerTablasNoObligatorias(ctlMatCon.devolverMaterialConstruccionPorDescripcion())
        'MaterialConstruccionIDComboMAM.ValueMember = "ID"
        'MaterialConstruccionIDComboMAM.DisplayMember = "Display"
        MaterialConstruccionIDComboMAM.Text = material
        ListadoCheckBox.Checked = listado
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, DoctoUbicacionfisicaCuadroDeTexto.Text, "")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            DoctoUbicacionfisicaCuadroDeTexto.Text = arch
        End If
    End Sub

    Private Sub rbTonel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTonel.CheckedChanged
        If rbTonel.Checked Then
            gbBota.Visible = False
            gbTonel.Visible = True
            gbTransicuba.Visible = False
            gbPiernas.Visible = False
        End If
    End Sub

    Private Sub rbTransicuba_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTransicuba.CheckedChanged
        If rbTransicuba.Checked Then
            gbBota.Visible = False
            gbTonel.Visible = False
            gbTransicuba.Visible = True
            gbPiernas.Visible = False
        End If
    End Sub

    Private Sub rbBota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBota.CheckedChanged
        If rbBota.Checked Then
            gbBota.Visible = True
            gbTonel.Visible = False
            gbTransicuba.Visible = False
            gbPiernas.Visible = False
        End If
    End Sub

    Private Sub NaveComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NaveComboMAM.SelectedValueChanged
        Try
            If NaveComboMAM.SelectedValue > 0 Then
                'ctlBotPos.SetNaveID(NaveComboMAM.SelectedValue)
                'piernas or naves
                ctlBotPos.SetNaveID(NaveComboMAM.SelectedValue)
                PiernaComboMAM.DataSource = Nothing
                Dim spPiernas As New spPiernas
                spPiernas.cargar_PiernasPorNave(PiernaComboMAM, NaveComboMAM.SelectedValue)
                ' PiernaComboMAM.DataSource = OldLib.HacerTablasObligatorias(ctlBotPos.devolverPiernasPorNaves(NaveComboMAM.SelectedValue))
                'PiernaComboMAM.ValueMember = "ID"
                'PiernaComboMAM.DisplayMember = "Display"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PiernaComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PiernaComboMAM.SelectedValueChanged
        Try
            If PiernaComboMAM.SelectedValue > 0 Then
                ctlBotPos.SetPiernaID(PiernaComboMAM.SelectedValue)
                AlturaComboMAM.DataSource = Nothing
                AlturaComboMAM.DataSource = OldLib.HacerTablasObligatorias(ctlBotPos.devolverAlturasPorPiernas(PiernaComboMAM.SelectedValue))
                AlturaComboMAM.ValueMember = "ID"
                AlturaComboMAM.DisplayMember = "Display"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AlturaComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlturaComboMAM.SelectedValueChanged
        Try
            If AlturaComboMAM.SelectedValue > 0 Then
                ctlBotPos.SetAlturaID(AlturaComboMAM.SelectedValue)
                PosicionComboMAM.DataSource = Nothing
                PosicionComboMAM.DataSource = OldLib.HacerTablasObligatorias(ctlBotPos.devolverPosicionesPorAlturas())
                PosicionComboMAM.ValueMember = "ID"
                PosicionComboMAM.DisplayMember = "Display"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PosicionComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PosicionComboMAM.SelectedValueChanged
        If rbBota.Checked Then
            Try
                If PosicionComboMAM.SelectedValue > 0 Then
                    cdCodigo.Text = NaveComboMAM.Text & PiernaComboMAM.Text & AlturaComboMAM.Text & PosicionComboMAM.Text
                Else
                    cdCodigo.Text = ""
                End If
                cdCodigo.Text = Convert.ToInt32(cdCodigo.Text)
            Catch ex As Exception
                cdCodigo.Text = "1010101"
            End Try
        End If
    End Sub

    Private Sub DepositoIDCuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepositoIDCuadroDeTexto.TextChanged
        Dim DepositoID As Integer
        DepositoID = DepositoIDCuadroDeTexto.Text
        ctlDep.SetDepositoID(DepositoID)

        Dim posi As Integer
        Dim codbot As String = ""
        If DepositoID > 0 Then
            ctlDep.CargarDepositos()
            ctlDep.DevolverDatosDepositos(CapacidadCuadroDeTexto.Text, DoctoUbicacionfisicaCuadroDeTexto.Text)

            If ctlDep.GetTonelID > 0 Then
                rbTonel.Checked = True
                ctlDep.CargarTonel()
                ctlDep.DevolverDatosTonel(cdDescripcionTonel.Text, txtContenidoHabitual.Text)
            ElseIf ctlDep.GetTransicubaID > 0 Then
                rbTransicuba.Checked = True
                ctlDep.CargarTransicuba()
                ctlDep.DevolverDatosTransicuba(cdDescripcionTransicuba.Text, cbEstadoTransicuba.Checked)
            ElseIf ctlDep.GetBotasPiernaID > 0 Then
                rbPiernas.Checked = True
                ctlDep.CargarBotaPierna()
                ctlDep.DevolverDatosBotaPierna(txtPiernasDescripcion.Text, txtPiernasContenido.Text)
            ElseIf ctlDep.GetBotaID > 0 Then
                rbBota.Checked = True
                ctlDep.CargarBota()
                ctlDep.DevolverDatosBota(BotaTaponIDComboMAM.SelectedValue, posi)
                'ctlBotPos.SetPosicionID()
                'ctlBotPos.CargarPorPosicion()

                NaveComboMAM.SelectedValue = ctlBotPos.GetNaveID
                PiernaComboMAM.SelectedValue = ctlBotPos.GetPiernaID
                AlturaComboMAM.SelectedValue = ctlBotPos.GetAlturaID
                PosicionComboMAM.SelectedValue = posi
                cdCodigo.Text = codbot
            End If
        End If
    End Sub

    Private Sub cdCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cdCodigo.EsUnicoID = ctlDep.GetBotaID()
        cdCodigo.validarCodigoBota()
    End Sub

    Private Sub gbBota_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbBota.VisibleChanged
        If rbBota.Checked Then
            Try
                If PosicionComboMAM.SelectedValue > 0 Then
                    cdCodigo.Text = NaveComboMAM.Text & PiernaComboMAM.Text & AlturaComboMAM.Text & PosicionComboMAM.Text
                Else
                    cdCodigo.Text = ""
                End If
                cdCodigo.Text = Convert.ToInt32(cdCodigo.Text)
            Catch ex As Exception
                cdCodigo.Text = "1010101"
            End Try
        End If
    End Sub

    Private Sub rbPiernas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPiernas.CheckedChanged
        If rbPiernas.Checked Then
            gbPiernas.Visible = True
            gbBota.Visible = False
            gbTonel.Visible = False
            gbTransicuba.Visible = False
        End If
    End Sub
End Class