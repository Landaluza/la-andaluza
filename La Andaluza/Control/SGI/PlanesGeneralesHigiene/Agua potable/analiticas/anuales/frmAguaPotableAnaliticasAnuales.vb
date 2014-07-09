Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAguaPotableAnaliticasAnuales
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAguaPotableAnaliticasAnuales As DBO_AguaPotableAnaliticasAnuales

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAguaPotableAnaliticasAnuales, MaestroID)
        InitializeComponent()

        dboAguaPotableAnaliticasAnuales = New DBO_AguaPotableAnaliticasAnuales


        MyBase.newRegForm = New frmEntAguaPotableAnaliticasAnuales(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAguaPotableAnaliticasAnuales)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAguaPotableAnaliticasAnuales = CType(sp, spAguaPotableAnaliticasAnuales).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboAguaPotableAnaliticasAnuales Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAguaPotableAnaliticasAnuales)
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
                .FormatoColumna("Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
