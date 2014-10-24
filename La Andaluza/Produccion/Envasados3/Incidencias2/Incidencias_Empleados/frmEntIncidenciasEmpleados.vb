Public Class frmEntIncidenciasEmpleados
    Private id As Integer
    Private nombre As String
    Private maestroid As Integer
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(Optional ByVal maestro As Integer = Nothing)

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        Me.maestroid = maestro
        Dim sp As New spEmpleados
        sp.cargar_empleados_envasados(Me.cboEmpleado, dtb)
    End Sub

    Public ReadOnly Property Empleado_ID As Integer
        Get
            Return Me.id
        End Get
    End Property

    Public ReadOnly Property Empleado_nombre As String
        Get
            Return Me.nombre
        End Get
    End Property


    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
            Me.id = Nothing
            Me.nombre = String.Empty
            Me.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If Me.maestroid = Nothing Then
            Me.id = Me.cboEmpleado.SelectedValue
            Me.nombre = Me.cboEmpleado.SelectedItem(1)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Try
                Dim sp As New spIncidenciasEmpleados
                Dim spIncidencias As New spIncidencias
                Dim DBO_Incidencias As DBO_Incidencias = spIncidencias.Select_Record(Me.maestroid, dtb)
                Dim DBO_empleados_formatosEnvasados As New DBO_empleados_formatosEnvasados

                DBO_empleados_formatosEnvasados.Inicio = DBO_Incidencias.HoraInicio
                DBO_empleados_formatosEnvasados.Fin = DBO_Incidencias.HoraFin
                DBO_empleados_formatosEnvasados.id_formatoEnvasado = DBO_Incidencias.FormatoEnvasadoID
                DBO_empleados_formatosEnvasados.id_empleado = Me.cboEmpleado.SelectedValue

                If sp.Guardar(Me.maestroid, DBO_empleados_formatosEnvasados, Nothing) Then
                    Me.Close()
                Else
                    messagebox.show("No se pudo completar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al realizar la operación. Detalles" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Public Sub guardar()

    End Sub
End Class