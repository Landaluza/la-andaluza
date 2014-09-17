Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposDEpositoPorDeposito
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboDepositos_TiposDepositos As DBO_Depositos_TiposDepositos

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spDepositos_TiposDepositos(), MaestroID.ToString)
        InitializeComponent()
        dboDepositos_TiposDepositos = New DBO_Depositos_TiposDepositos
        MyBase.newRegForm = CType(New frmEntTiposDEpositoPorDEposito(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spDepositos_TiposDepositos)), BasesParaCompatibilidad.DetailedSimpleForm)

        Me.sp.DataGridViewStoredProcedure = New spDepositos_TiposDepositos().SelectDgvByDeposito & " " & MaestroID
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        MyBase.newRegForm = CType(New frmEntTiposDEpositoPorDEposito(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dboDepositos_TiposDepositos.Id_Deposito = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboDepositos_TiposDepositos, BasesParaCompatibilidad.DataBussines))
        AddHandler newRegForm.afterSave, AddressOf dgvFill
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboDepositos_TiposDepositos = CType(sp, spDepositos_TiposDepositos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboDepositos_TiposDepositos Is Nothing Then
            MyBase.newRegForm = CType(New frmEntTiposDEpositoPorDEposito(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboDepositos_TiposDepositos, BasesParaCompatibilidad.DataBussines))
            AddHandler newRegForm.afterSave, AddressOf dgvFill
        Else
            MyBase.EventHandeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spDepositos_TiposDepositos.DataGridViewStoredProcedure)

        If Not datasource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("DepositoID", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
