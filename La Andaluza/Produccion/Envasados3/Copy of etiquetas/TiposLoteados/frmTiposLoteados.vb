Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposLoteados
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboTiposLoteados As DBO_TiposLoteados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposLoteados(), MaestroID)
        InitializeComponent()
        dboTiposLoteados = New DBO_TiposLoteados
        MyBase.newRegForm = CType(New frmEntTiposLoteados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spTiposLoteados)), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub frmTiposLoteados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = True
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposLoteados, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposLoteados = CType(sp, spTiposLoteados).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboTiposLoteados Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboTiposLoteados, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spTiposLoteados.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
