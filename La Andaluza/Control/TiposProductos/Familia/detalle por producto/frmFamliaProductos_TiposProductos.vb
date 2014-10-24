Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmFamliaProductos_TiposProductos
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboFamliaProductos_TiposProductos As DBO_FamliaProductos_TiposProductos

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spFamliaProductos_TiposProductos(), MaestroID.ToString)
        InitializeComponent()
        dboFamliaProductos_TiposProductos = New DBO_FamliaProductos_TiposProductos
        MyBase.newRegForm = CType(New frmEntDetallePorProducto(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spFamliaProductos_TiposProductos)), BasesParaCompatibilidad.DetailedSimpleForm)
        Me.dgvGeneral.ColumnHeadersVisible = False
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboFamliaProductos_TiposProductos = New DBO_FamliaProductos_TiposProductos
        MyBase.newRegForm = CType(New frmEntDetallePorProducto(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dboFamliaProductos_TiposProductos.Id_TipoProducto = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboFamliaProductos_TiposProductos, BasesParaCompatibilidad.DataBussines))
        AddHandler newRegForm.afterSave, AddressOf dgvFill
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboFamliaProductos_TiposProductos = CType(sp, spFamliaProductos_TiposProductos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)

        If Not dboFamliaProductos_TiposProductos Is Nothing Then
            MyBase.newRegForm = CType(New frmEntDetallePorProducto(BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboFamliaProductos_TiposProductos, BasesParaCompatibilidad.DataBussines))
            AddHandler newRegForm.afterSave, AddressOf dgvFill
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
