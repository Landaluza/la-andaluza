Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboControlIncidencias As DBO_ControlIncidencias

    Public ReadOnly Property SelectedItem As Integer
        Get
            If Me.dgvGeneral.CurrentRow Is Nothing Then
                Return 0
            Else
                Return Me.dgvGeneral.CurrentRow.Cells("Id").Value
            End If
        End Get
    End Property

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spControlIncidencias, MaestroID)
        InitializeComponent()

        dboControlIncidencias = New DBO_ControlIncidencias


        MyBase.newRegForm = New frmEntControlIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)

    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboControlIncidencias)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboControlIncidencias = CType(sp, spControlIncidencias).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboControlIncidencias Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboControlIncidencias)
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
