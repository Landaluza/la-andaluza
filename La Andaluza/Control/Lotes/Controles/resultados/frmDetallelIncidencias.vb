Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDetallelIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboControlIncidencias As DBO_ControlIncidencias
    Public Event SeleccionHecha()

    Public ReadOnly Property SelectedItem As Integer
        Get
            Return dgvGeneral.CurrentRow.Cells("Id").Value
        End Get
    End Property

    Public Sub New()
        MyBase.New(New spControlIncidencias, Nothing)
        InitializeComponent()

        dboControlIncidencias = New DBO_ControlIncidencias

        MyBase.newRegForm = New frmEntControlIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)


        Me.butSalir.Visible = False
        RemoveHandler Me.dgvGeneral.CellDoubleClick, AddressOf dgvGeneral_CellDoubleClick
        AddHandler Me.dgvGeneral.CellDoubleClick, AddressOf terminar
    End Sub

    Private Sub terminar()
        RaiseEvent SeleccionHecha()
        Me.Close()
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboControlIncidencias = New DBO_ControlIncidencias
        newRegForm.SetDataBussinesObject(CType(Me.dboControlIncidencias, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboControlIncidencias = CType(sp, spControlIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboControlIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboControlIncidencias, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Fecha").Visible = False
                .Columns("NecesitaSeguimiento").Visible = False
                .Columns("Descripcion").Visible = False

                .Columns("Articulo").Visible = False
                .FormatoColumna("Incidencia", BasesParaCompatibilidad.TiposColumna.Izquierda, 250)
                .FormatoColumna("Estado", BasesParaCompatibilidad.TiposColumna.Izquierda, 120)

                .Columns("Empleado").Visible = False
                .Columns("Gravedad").Visible = False
                .Columns("Frecuencia").Visible = False
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If
    End Sub

End Class
