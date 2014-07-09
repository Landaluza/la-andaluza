Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIncidenciasEmpleados
    Private frmEntIncidenciasEmpleados As frmEntIncidenciasEmpleados
    Private maestroID As Integer
    Private sp As spIncidenciasEmpleados

    Public WriteOnly Property Incidencia As Integer
        Set(value As Integer)
            Me.maestroID = value
        End Set
    End Property

    Public Sub New(Optional ByVal maestro As Integer = Nothing)

        InitializeComponent()
        Me.maestroID = maestro
        sp = New spIncidenciasEmpleados
    End Sub

    Private Sub butañadir_Click(sender As System.Object, e As System.EventArgs) Handles butañadir.Click
        Me.frmEntIncidenciasEmpleados = New frmEntIncidenciasEmpleados(Me.maestroID)
        frmEntIncidenciasEmpleados.ShowDialog()

        If maestroID = Nothing Then
            If frmEntIncidenciasEmpleados.DialogResult = Windows.Forms.DialogResult.OK Then
                Dim dgvRow As New DataGridViewRow
                Dim dgvCell As DataGridViewCell

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = frmEntIncidenciasEmpleados.Empleado_nombre
                dgvRow.Cells.Add(dgvCell)

                dgvCell = New DataGridViewTextBoxCell()
                dgvCell.Value = frmEntIncidenciasEmpleados.Empleado_ID
                dgvRow.Cells.Add(dgvCell)

                dgv.Rows.Add(dgvRow)
            End If
        Else
            dgvFill()
        End If
    End Sub

    Private Sub butEliminar_Click(sender As System.Object, e As System.EventArgs) Handles butEliminar.Click
        If Me.maestroID = Nothing Then
            Me.dgv.Rows.Remove(Me.dgv.CurrentRow)
        Else
            sp.Eliminar(Me.dgv.CurrentRow.Cells("Id").Value)
            dgvFill()
        End If
    End Sub

    Private Sub dgvFill()
        Dim dt As DataTable = sp.cargar_grilla(Me.maestroID)

        If Not dt Is Nothing Then
            Me.dgv.DataSource = dt
            Me.dgv.Columns("Id").Visible = False
            Me.dgv.FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
        End If

    End Sub

    Private Sub frmIncidenciasEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.maestroID <> Nothing Then
            Me.dgv.Columns.Clear()
            dgvFill()
        End If
    End Sub

    Public Function guardar(ByRef transaction As SqlClient.SqlTransaction) As Boolean
        Dim spIncidencias As New spIncidencias
        Dim spempleados_formatosEnvasados As New spempleados_formatosEnvasados
        Dim spPartesEnvasados_CausasPartesEnvasado As New spPartesEnvasados_CausasPartesEnvasado
        'Dim spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad As New spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad

        Dim DBO_Incidencias As DBO_Incidencias = spIncidencias.Select_Record(Me.maestroID, transaction)
        Dim DBO_empleados_formatosEnvasados As New DBO_empleados_formatosEnvasados

        DBO_empleados_formatosEnvasados.Inicio = DBO_Incidencias.HoraInicio
        DBO_empleados_formatosEnvasados.Fin = DBO_Incidencias.HoraFin
        DBO_empleados_formatosEnvasados.id_formatoEnvasado = DBO_Incidencias.FormatoEnvasadoID

        Dim spIncidenciasEmpleados As New spIncidenciasEmpleados

        For Each row As DataGridViewRow In Me.dgv.Rows
            DBO_empleados_formatosEnvasados.id_empleado = row.Cells("Id").Value
            spIncidenciasEmpleados.Guardar(maestroID, DBO_empleados_formatosEnvasados, transaction)

            'DBO_empleados_formatosEnvasados.id_empleado = row.Cells("Id").Value
            'spempleados_formatosEnvasados.Grabar(DBO_empleados_formatosEnvasados, transaction)

            'Dim DBO_PartesEnvasados_CausasPartesEnvasado As New DBO_PartesEnvasados_CausasPartesEnvasado
            'DBO_PartesEnvasados_CausasPartesEnvasado.Id_ParteEnvasado = spempleados_formatosEnvasados.seleccionarUltimoRegistro(BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
            'DBO_PartesEnvasados_CausasPartesEnvasado.Id_CausaParteEnvasado = 2 'incidencia

            'spPartesEnvasados_CausasPartesEnvasado.Grabar(DBO_PartesEnvasados_CausasPartesEnvasado, transaction)

            'Dim DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad As New DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
            'DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad.Id_ParteEnvasado_causaParteEnvasado = spPartesEnvasados_CausasPartesEnvasado.seleccionarUltimoRegistro(BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
            'DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad.Id_Incidencia = maestroID

            'spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad.Grabar(DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad, transaction)
        Next

        Return True
    End Function

End Class