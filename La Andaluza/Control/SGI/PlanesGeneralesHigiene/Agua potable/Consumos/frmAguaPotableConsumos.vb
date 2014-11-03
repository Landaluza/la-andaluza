Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAguaPotableConsumos
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboAguaPotableConsumos As DBO_AguaPotableConsumos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAguaPotableConsumos, MaestroID)
        InitializeComponent()

        dboAguaPotableConsumos = New DBO_AguaPotableConsumos


        MyBase.newRegForm = New frmEntAguaPotableConsumos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAguaPotableConsumos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboAguaPotableConsumos = CType(sp, spAguaPotableConsumos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAguaPotableConsumos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAguaPotableConsumos)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Periodo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Litros", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("numero", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
