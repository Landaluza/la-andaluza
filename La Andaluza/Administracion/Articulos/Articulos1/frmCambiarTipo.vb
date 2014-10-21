Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmCambiarTipo
    Private id As Integer
    Public Sub New(ByVal articuloid As Integer)

        InitializeComponent()

        Me.id = articuloid
        Me.cboTipo.mam_DataSource("Articulos1_ArticulosTiposCbo", False)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.EmpezarTransaccion()
        Try
            dtb.PrepararConsulta("DeleteArticulos1Detalles @tipo")
            dtb.AñadirParametroConsulta("@tipo", cboTipo.SelectedValue.ToString)
            If Not dtb.Consultar(True) Then
                dtb.CancelarTransaccion()
                MessageBox.Show("No se pudo completar la operación. Error borrando detalles del articulo.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                dtb.PrepararConsulta("update articulos1 set ArticuloTpoID= @tipo where articuloid= @art")
                dtb.AñadirParametroConsulta("@tipo", cboTipo.SelectedValue.ToString)
                dtb.AñadirParametroConsulta("@art", id)

                If Not dtb.Consultar(True) Then
                    dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo completar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Else
                    dtb.TerminarTransaccion()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("No se pudo completar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try

        Me.Close()
    End Sub
End Class