Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIncidenciasEnvasadosAsignables
    Private m_maestroId As Integer
    Private sp As spIncidenciasEnvasadosAsignadas
    Private fechaEnvasado As DateTime
    Private id_ControlIncidencia As Integer
    Private id_incidenciaCalidadTipo As Integer

    Public Sub New(ByVal maestro As Integer, ByVal id_incidenciaCalidadTipo As Integer, Optional ByVal fecha As DateTime = Nothing)

        InitializeComponent()
        sp = New spIncidenciasEnvasadosAsignadas
        Me.id_ControlIncidencia = maestro
        Me.id_incidenciaCalidadTipo = id_incidenciaCalidadTipo
        Me.fechaEnvasado = If(fecha = Nothing, Now.Date, fecha)
    End Sub

    Private Sub btnAnadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAnadir.Click
        Try
            If sp.asignar_incidencia_envasado(Me.dgvAsignables.CurrentRow.Cells("Id").Value, id_ControlIncidencia) Then
                recargar(Me.fechaEnvasado, Me.id_ControlIncidencia, Me.id_incidenciaCalidadTipo)
            Else
                MessageBox.Show("No se pudo realizar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        Try
            If sp.eliminar_incidencia_envasado(Me.dgvAsignadas.CurrentRow.Cells("Id").Value) Then
                recargar(Me.fechaEnvasado, Me.id_ControlIncidencia, Me.id_incidenciaCalidadTipo)
            Else
                MessageBox.Show("No se pudo realizar la operación", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MessageBox.Show("Error. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmIncidenciasEnvasadosAsignables_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        recargar(Me.fechaEnvasado, Me.id_ControlIncidencia, Me.id_incidenciaCalidadTipo)
    End Sub

    Public Sub recargar(ByVal fecha As Date, ByVal id_controlIncidencia As Integer, ByVal tipoIncidencia As Integer)
        Me.fechaEnvasado = fecha
        Me.id_ControlIncidencia = id_controlIncidencia
        Me.id_incidenciaCalidadTipo = tipoIncidencia

        cargar_disponibles(Me.fechaEnvasado, Me.id_incidenciaCalidadTipo)
        cargar_asignados(Me.id_ControlIncidencia)
    End Sub

    Private Sub cargar_asignados(ByVal id_controlIncidencia As Integer)
        Dim dtAsignados As DataTable = sp.asignados(id_controlIncidencia)

        If Not dtAsignados Is Nothing Then
            With dgvAsignadas
                .DataSource = dtAsignados
                .Columns("Id").Visible = False
                .FormatoColumna("HoraInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("HoraFin", "Fin", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Categoria", BasesParaCompatibilidad.TiposColumna.Izquierda, 120)
                .FormatoColumna("Otro", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If
    End Sub

    Private Sub cargar_disponibles(ByVal fecha As Date, ByVal tipoIncidencia As Integer)
        Dim dtAsignables As DataTable = sp.asignables(fecha, tipoIncidencia)

        If Not dtAsignables Is Nothing Then
            With dgvAsignables
                .DataSource = dtAsignables
                .Columns("Id").Visible = False
                .FormatoColumna("HoraInicio", "Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("HoraFin", "Fin", BasesParaCompatibilidad.TiposColumna.Hora, 80)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Categoria", BasesParaCompatibilidad.TiposColumna.Izquierda, 120)
                .FormatoColumna("Otro", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If
    End Sub

    Private Sub frmIncidenciasEnvasadosAsignables_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.ToolStrip1, Me.PanBotonera)
        BasesParaCompatibilidad.pantalla.centerIn(Me.titulo1, Me.PanTitulo)
        BasesParaCompatibilidad.pantalla.centerIn(Me.titulo2, Me.panTitulo2)
    End Sub


End Class