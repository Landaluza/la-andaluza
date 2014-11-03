Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmdetallePorFamilia
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dbodetallePorFamilia As DBO_FamliaProductos_TiposProductos

    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New(New spFamliaProductos_TiposProductos(), MaestroID.ToString)
        InitializeComponent()
        dbodetallePorFamilia = New DBO_FamliaProductos_TiposProductos
        MyBase.newRegForm = CType(New frmEntDetallePorFamilia(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spFamliaProductos_TiposProductos)), BasesParaCompatibilidad.DetailedSimpleForm)

        Me.sp.DataGridViewStoredProcedure = New spFamliaProductos_TiposProductos().SelectDgvByFamilia & " " & MaestroID
        Me.dgvGeneral.ColumnHeadersVisible = False
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dbodetallePorFamilia = New DBO_FamliaProductos_TiposProductos
        MyBase.newRegForm = CType(New frmEntDetallePorFamilia(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dbodetallePorFamilia.Id_FamiliaProducto = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dbodetallePorFamilia, BasesParaCompatibilidad.DataBussines))
        AddHandler newRegForm.afterSave, AddressOf dgvFill
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dbodetallePorFamilia = CType(sp, spFamliaProductos_TiposProductos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dbodetallePorFamilia Is Nothing Then
            MyBase.newRegForm = CType(New frmEntdetallePorFamilia(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dbodetallePorFamilia, BasesParaCompatibilidad.DataBussines))
            AddHandler newRegForm.afterSave, AddressOf dgvFill
        Else
            MyBase.EventHandeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spdetallePorFamilia.DataGridViewStoredProcedure)

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
