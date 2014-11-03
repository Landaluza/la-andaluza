Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposPendientes
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboTiposPendientes As DBO_TiposPendientes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposPendientes, MaestroID)
        InitializeComponent()

        dboTiposPendientes = New DBO_TiposPendientes

        MyBase.newRegForm = CType(New frmEntTiposPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposPendientes, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboTiposPendientes = CType(sp, spTiposPendientes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboTiposPendientes Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboTiposPendientes, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        'Me. dataSource = dtb.Consultar(Me.sp.DataGridViewStoredProcedure)

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
