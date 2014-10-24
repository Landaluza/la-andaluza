Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPersonalEnvasadoFin
    Private dbo As DBO_empleados_formatosEnvasados
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New(ByVal formatoEnvasadoId As Integer)

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.dbo = New DBO_empleados_formatosEnvasados
        dbo.id_formatoEnvasado = formatoEnvasadoId
        dtpFin.activarFoco()
    End Sub

    Private Sub setValores()
        Dim spEmlpeados As New spEmpleados
        Dim dtEmpleados As DataTable

        dtEmpleados = spEmlpeados.devolver_Empleados_actuales_del_formato(Me.dbo.id_formatoEnvasado, dtb)


        If dtEmpleados Is Nothing Then
            MessageBox.Show("No se pudo recuperar los datos. Vuelva a intentarlo en unos minutos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End If

        For Each row As DataRow In dtEmpleados.Rows
            dgvEnLinea.Rows.Add(New String() {row(0), row(1), row(2)})
        Next

        Dim sp As New spFormatosEnvasados
        Dim d As DBO_FormatosEnvasados = sp.Select_Record(Me.dbo.id_formatoEnvasado, dtb)

        If d.fin_is_null Then
            Me.dtpFin.Value = DateTime.Now.Date.Add(d.inicio)
        Else
            Me.dtpFin.Value = DateTime.Now.Date.Add(d.fin)
        End If
    End Sub

    Private Sub btnALinea_Click(sender As System.Object, e As System.EventArgs) Handles btnALinea.Click
        If Not Me.dgvEnLinea.CurrentRow Is Nothing Then
            Me.DgvDisponibles.Rows.Add(New String() {Me.dgvEnLinea.CurrentRow.Cells(0).Value, Me.dgvEnLinea.CurrentRow.Cells(1).Value, Me.dgvEnLinea.CurrentRow.Cells(2).Value})
            Me.dgvEnLinea.Rows.Remove(Me.dgvEnLinea.CurrentRow)
        End If
    End Sub

    Private Sub btnfueraLinea_Click(sender As System.Object, e As System.EventArgs) Handles btnfueraLinea.Click
        If Not Me.DgvDisponibles.CurrentRow Is Nothing Then
            Me.dgvEnLinea.Rows.Add(New String() {Me.DgvDisponibles.CurrentRow.Cells(0).Value, Me.DgvDisponibles.CurrentRow.Cells(1).Value, Me.DgvDisponibles.CurrentRow.Cells(2).Value})
            Me.DgvDisponibles.Rows.Remove(Me.DgvDisponibles.CurrentRow)
        End If
    End Sub

    Private Sub frmEntPersonalEnvasadoFin_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        setValores()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        Dim sp As New spempleados_formatosEnvasados

        dtb.EmpezarTransaccion()
        Try
            dbo.Fin = New TimeSpan(Me.dtpFin.Value.Hour, Me.dtpFin.Value.Minute, 0)
            For Each row As DataGridViewRow In Me.DgvDisponibles.Rows
                Me.dbo.id_empleado = row.Cells(0).Value
                If Not sp.actualizar_hora_fin(dbo, dtb) Then
                    dtb.CancelarTransaccion()
                    MessageBox.Show("Error al realizar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Next

            dtb.TerminarTransaccion()
            Me.Close()
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("Error al realizar la operacion. Detalles" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub frmEntPersonalEnvasadoFin_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me)
    End Sub
End Class