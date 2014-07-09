Public Class frmGeneradorBoletines
    Private boletin As frmEntplantillasBoletines
    Private spBoletines As spplantillasBoletines

    Private Sub cboTipoProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoProducto.SelectedValueChanged
        Try
            spBoletines.cargarCboLotesPorTipoProducto(Me.cboLote, Me.cboTipoProducto.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbLote_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLote.SelectedValueChanged
        Try
            spBoletines.cargarCboPlantillasPorlotesCompatibles(Me.cboPlantilla, Me.cboLote.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboPlantilla_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPlantilla.SelectedValueChanged
        mostrarPlantilla()
    End Sub

    Private Sub frmBoletines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.spBoletines = New spplantillasBoletines
        Me.ToolTip1.SetToolTip(Me.btnAgnadir, "Pulsa para crear una nueva plantilla")
        Try
            spBoletines.cargarCboTiposProducto(Me.cboTipoProducto)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub mostrarPlantilla()
        Try
            Dim aux As System.Data.DataRowView = Me.cboLote.SelectedItem

            'boletin = New LisBoletinesParametros(aux.Row.Item(1), Me.cboPlantilla.SelectedValue, Me)
            boletin = New frmEntplantillasBoletines(aux.Row.Item(1), Me.cboPlantilla.SelectedValue, Me)
            Engine_LA.FormEnPestaña(boletin, panBoletin)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub habilitarFormulario()
        cboLote.Enabled = True
        cboTipoProducto.Enabled = True
        cboPlantilla.Enabled = True
        Try
            spBoletines.cargarCboTiposProducto(Me.cboTipoProducto)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAgnadir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgnadir.Click
        Me.Cursor = Cursors.WaitCursor
        Me.panBoletin.Visible = False
        boletin = New frmEntplantillasBoletines(Me)
        Me.boletin.nuevo()
        Engine_LA.FormEnPestaña(boletin, panBoletin)

        Me.cboLote.Enabled = False
        Me.cboTipoProducto.Enabled = False
        Me.cboPlantilla.Enabled = False
        Me.panBoletin.Visible = True
        Me.Cursor = Cursors.Default
    End Sub
End Class