Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmGastosIncidencias
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboGastosIncidencias As DBO_GastosIncidencias

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.new(New spGastosIncidencias(), MaestroID.ToString)
        InitializeComponent()
        dboGastosIncidencias = New DBO_GastosIncidencias
        MyBase.newRegForm = CType(New frmEntGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(sp, spGastosIncidencias)), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        MyBase.newRegForm = CType(New frmEntGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR), BasesParaCompatibilidad.DetailedSimpleForm)
        dboGastosIncidencias.Id_controlIncidencia = m_MaestroID
        newRegForm.SetDataBussinesObject(CType(Me.dboGastosIncidencias, BasesParaCompatibilidad.databussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboGastosIncidencias = CType(sp, spGastosIncidencias).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboGastosIncidencias Is Nothing Then
            MyBase.newRegForm = CType(New frmEntGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR), BasesParaCompatibilidad.DetailedSimpleForm)
            newRegForm.SetDataBussinesObject(CType(Me.dboGastosIncidencias, BasesParaCompatibilidad.databussines))
        Else
            MyBase.EventHandeld = True
            Messagebox.show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        'dim dt as datatable = DataTableFill(Me.spGastosIncidencias.DataGridViewStoredProcedure)

        If Not datasource Is Nothing Then
            GeneralBindingSource.DataSource = datasource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Coste", BasesParaCompatibilidad.TiposColumna.Double2, True)
                .FormatoColumna("Causante", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
