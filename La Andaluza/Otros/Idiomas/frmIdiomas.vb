Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIdiomas
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboIdiomas As DBO_Idiomas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spIdiomas, MaestroID)
        InitializeComponent()

        dboIdiomas = New DBO_Idiomas


        MyBase.newRegForm = CType(New frmEntIdiomas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub frmIdiomas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = True
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboIdiomas, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboIdiomas = CType(sp, spIdiomas).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboIdiomas Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboIdiomas, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
