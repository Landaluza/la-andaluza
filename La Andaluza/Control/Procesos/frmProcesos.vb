Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProcesos
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboProcesos As DBO_Procesos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProcesos, MaestroID)
        InitializeComponent()

        dboProcesos = New DBO_Procesos


        MyBase.newRegForm = CType(New frmEntProcesos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub

    Private Sub frmProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = True
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboProcesos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboProcesos = CType(sp, spProcesos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboProcesos Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboProcesos, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("TipoProductoParaLote", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("TipoMovimiento", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("TipoLote", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
        End If

    End Sub

End Class
