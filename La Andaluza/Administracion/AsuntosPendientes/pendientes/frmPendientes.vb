Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPendientes
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboPendientes As DBO_Pendientes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPendientes, MaestroID)
        InitializeComponent()

        dboPendientes = New DBO_Pendientes
        MyBase.newRegForm = CType(New frmEntPendientes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub
    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboPendientes, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPendientes = CType(sp, spPendientes).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboPendientes Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboPendientes, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        'Me. dataSource = dtb.Consultar(Me.sp.DataGridViewStoredProcedure)

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("NumeroDocumento", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("FechaDocumento", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("RutaDocumento", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub


End Class
