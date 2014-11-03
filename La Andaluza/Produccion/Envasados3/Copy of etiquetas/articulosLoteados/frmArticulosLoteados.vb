Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosLoteados
    Inherits BasesParaCompatibilidad.gridsimpleform
    Implements BasesParaCompatibilidad.Queriable

    Private dboArticulosLoteados As DBO_ArticulosLoteados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spArticulosLoteados(), MaestroID)
        InitializeComponent()
        dboArticulosLoteados = New DBO_ArticulosLoteados
        MyBase.newRegForm = CType(New frmEntArticulosLoteados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(sp, spArticulosLoteados)), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        EventHandeld = True
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboArticulosLoteados = CType(sp, spArticulosLoteados).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboArticulosLoteados Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboArticulosLoteados, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .Columns("ArticuloID").Visible = False
                .Columns("TipoLoteado").Visible = False
                .FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Loteado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If

    End Sub

End Class
