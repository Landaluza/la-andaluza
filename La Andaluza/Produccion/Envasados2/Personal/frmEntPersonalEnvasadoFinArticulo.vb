Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPersonalEnvasadoFinArticulo
    Private m_resultado As DialogResult
    Private envasado As Integer
    Private linea As Integer
    Private dtb As BasesParaCompatibilidad.DataBase

    Public ReadOnly Property resultado As DialogResult
        Get
            Return Me.m_resultado
        End Get
    End Property

    Public Sub New(ByVal envasadoId As Integer, ByVal lineaId As Integer)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.envasado = envasadoId
        Me.linea = lineaId
        Me.m_resultado = Windows.Forms.DialogResult.No
        dtpFin.activarFoco()
    End Sub

    Private Sub setValores()
        Dim spEmlpeados As New spempleados_formatosEnvasados
        Dim dtEmpleados As DataTable

        dtEmpleados = spEmlpeados.empleados_pendientes(Me.envasado, Me.linea, dtb)

        If dtEmpleados Is Nothing Then
            MessageBox.Show("No se pudo recuperar los datos. Vuelva a intentarlo en unos minutos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.m_resultado = Windows.Forms.DialogResult.No
            Me.Close()
        End If

        For Each row As DataRow In dtEmpleados.Rows
            dgvEnLinea.Rows.Add(New String() {row(0), row(1), row(2), row(3)})
        Next

        Dim sp As New spFormatosEnvasados
        Dim d As DBO_FormatosEnvasados = sp.Select_Record(dgvEnLinea.Rows(0).Cells(3).Value, dtb)
        Dim spFormato As New spArticulosEnvasadosHistoricos
        lArticulo.Text = spFormato.Select_Record(d.TipoFormatoEnvasadoID, dtb).Descripcion

        Dim spEnvasados As New spEnvasados
        Dim denvasado As DBO_Envasados = spEnvasados.Select_Record(Me.envasado, dtb)
        lEnvasado.Text = denvasado.Fecha.ToShortDateString

        If d.fin_is_null Then
            Me.dtpFin.Value = DateTime.Now.Date.Add(d.inicio)
        Else
            Me.dtpFin.Value = DateTime.Now.Date.Add(d.fin)
        End If
    End Sub

    Private Sub frmEntPersonalEnvasadoFinArticulo_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        setValores()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim sp As New spempleados_formatosEnvasados
        Dim dbo As New DBO_empleados_formatosEnvasados

        dtb.EmpezarTransaccion()
        Try
            dbo.Fin = New TimeSpan(Me.dtpFin.Value.Hour, Me.dtpFin.Value.Minute, 0)
            For Each row As DataGridViewRow In Me.dgvEnLinea.Rows
                dbo.id_empleado = row.Cells(0).Value
                dbo.id_formatoEnvasado = row.Cells(3).Value
                If Not sp.actualizar_hora_fin(dbo, dtb) Then
                    dtb.CancelarTransaccion()
                    MessageBox.Show("Error al realizar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next

            dtb.TerminarTransaccion()
            Me.m_resultado = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("Error al realizar la operacion. Detalles" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub frmEntPersonalEnvasadoFinArticulo_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me)
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class