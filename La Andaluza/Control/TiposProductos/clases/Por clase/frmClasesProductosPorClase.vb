Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmClasesProductosPorClase
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboTiposProductos_ClasesProductos As DBO_TiposProductos_ClasesProductos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.new(New spTiposProductos_ClasesProductos(), MaestroID.ToString)
        InitializeComponent()
        dboTiposProductos_ClasesProductos = New DBO_TiposProductos_ClasesProductos
        MyBase.newRegForm = CType(New frmEntClasesProductosPorClase(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(sp, spTiposProductos_ClasesProductos)), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        MyBase.newRegForm = CType(New frmEntClasesProductosPorClase(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dboTiposProductos_ClasesProductos.Id_ClaseProducto = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboTiposProductos_ClasesProductos, BasesParaCompatibilidad.databussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboTiposProductos_ClasesProductos = CType(sp, spTiposProductos_ClasesProductos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboTiposProductos_ClasesProductos Is Nothing Then
            MyBase.newRegForm = CType(New frmEntClasesProductosPorClase(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboTiposProductos_ClasesProductos, BasesParaCompatibilidad.databussines))
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
                .FormatoColumna("TipoProductoID", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
