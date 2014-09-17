Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmFamliaProductos_TiposProductos
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboFamliaProductos_TiposProductos As DBO_FamliaProductos_TiposProductos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.new(New spFamliaProductos_TiposProductos(), MaestroID.ToString)
        InitializeComponent()
        dboFamliaProductos_TiposProductos = New DBO_FamliaProductos_TiposProductos
        MyBase.newRegForm = CType(New frmEntDetallePorProducto(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(sp, spFamliaProductos_TiposProductos)), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        MyBase.newRegForm = CType(New frmEntDetallePorProducto(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dboFamliaProductos_TiposProductos.Id_FamiliaProducto = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboFamliaProductos_TiposProductos, BasesParaCompatibilidad.databussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboFamliaProductos_TiposProductos = CType(sp, spFamliaProductos_TiposProductos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboFamliaProductos_TiposProductos Is Nothing Then
            MyBase.newRegForm = CType(New frmEntDetallePorProducto(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboFamliaProductos_TiposProductos, BasesParaCompatibilidad.databussines))
        Else
            MyBase.EventHandeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spFamliaProductos_TiposProductos.DataGridViewStoredProcedure)

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
