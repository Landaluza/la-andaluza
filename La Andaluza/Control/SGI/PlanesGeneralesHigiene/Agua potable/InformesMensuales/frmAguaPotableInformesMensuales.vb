Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAguaPotableInformesMensuales
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAguaPotableInformesMensuales As DBO_AguaPotableInformesMensuales

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAguaPotableInformesMensuales, MaestroID)
        InitializeComponent()

        dboAguaPotableInformesMensuales = New DBO_AguaPotableInformesMensuales


        MyBase.newRegForm = New frmEntAguaPotableInformesMensuales(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAguaPotableInformesMensuales)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAguaPotableInformesMensuales = CType(sp, spAguaPotableInformesMensuales).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAguaPotableInformesMensuales Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAguaPotableInformesMensuales)
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
                .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Id", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Periodo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
