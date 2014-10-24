Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProtocolosMedicosPuestosTrabajos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboProtocolosMedicosPuestosTrabajos As DBO_ProtocolosMedicosPuestosTrabajos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProtocolosMedicosPuestosTrabajos, MaestroID)
        InitializeComponent()

        dboProtocolosMedicosPuestosTrabajos = New DBO_ProtocolosMedicosPuestosTrabajos


        MyBase.newRegForm = New frmEntProtocolosMedicosPuestosTrabajos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboProtocolosMedicosPuestosTrabajos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboProtocolosMedicosPuestosTrabajos = CType(sp, spProtocolosMedicosPuestosTrabajos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboProtocolosMedicosPuestosTrabajos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboProtocolosMedicosPuestosTrabajos)
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
                .FormatoColumna("Puesto", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Actividad", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Referencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
