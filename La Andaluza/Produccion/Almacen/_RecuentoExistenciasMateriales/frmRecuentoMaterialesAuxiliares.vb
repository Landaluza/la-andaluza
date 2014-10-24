Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmRecuentoMaterialesAuxiliares
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboRecuentoMaterialesAuxiliares As DBO_RecuentoMaterialesAuxiliares

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spRecuentoMaterialesAuxiliares, MaestroID)
        InitializeComponent()

        dboRecuentoMaterialesAuxiliares = New DBO_RecuentoMaterialesAuxiliares


        MyBase.newRegForm = New frmEntRecuentoMaterialesAuxiliares(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboRecuentoMaterialesAuxiliares)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboRecuentoMaterialesAuxiliares = CType(sp, spRecuentoMaterialesAuxiliares).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboRecuentoMaterialesAuxiliares Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboRecuentoMaterialesAuxiliares)
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
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With
        End If
    End Sub
End Class
