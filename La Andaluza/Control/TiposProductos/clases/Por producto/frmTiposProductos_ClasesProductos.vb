Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposProductos_ClasesProductos
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboTiposProductos_ClasesProductos As DBO_TiposProductos_ClasesProductos

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spTiposProductos_ClasesProductos(), MaestroID.ToString)
        InitializeComponent()
        dboTiposProductos_ClasesProductos = New DBO_TiposProductos_ClasesProductos
        MyBase.newRegForm = CType(New frmEntTiposProductos_ClasesProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spTiposProductos_ClasesProductos)), BasesParaCompatibilidad.DetailedSimpleForm)

        Me.sp.DataGridViewStoredProcedure = New spTiposProductos_ClasesProductos().SelectDgvByProducto & " " & MaestroID
        Me.dgvGeneral.ColumnHeadersVisible = False
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        MyBase.newRegForm = CType(New frmEntTiposProductos_ClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dboTiposProductos_ClasesProductos.Id_TipoProducto = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposProductos_ClasesProductos, BasesParaCompatibilidad.DataBussines))
        AddHandler newRegForm.afterSave, AddressOf dgvFill
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposProductos_ClasesProductos = CType(sp, spTiposProductos_ClasesProductos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboTiposProductos_ClasesProductos Is Nothing Then
            MyBase.newRegForm = CType(New frmEntTiposProductos_ClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboTiposProductos_ClasesProductos, BasesParaCompatibilidad.DataBussines))
            AddHandler newRegForm.afterSave, AddressOf dgvFill
        Else
            MyBase.EventHandeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spTiposProductos_ClasesProductos.DataGridViewStoredProcedure)

        If Not datasource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
