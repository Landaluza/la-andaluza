Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsEstados
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable


    Private dboPaletsEstados As DBO_PaletsEstados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPaletsEstados, MaestroID)
        InitializeComponent()

        dboPaletsEstados = New DBO_PaletsEstados


        MyBase.newRegForm = CType(New frmEntPaletsEstados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub frmPaletsEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = True
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboPaletsEstados, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPaletsEstados = CType(sp, spPaletsEstados).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboPaletsEstados Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboPaletsEstados, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        End If

    End Sub

End Class
