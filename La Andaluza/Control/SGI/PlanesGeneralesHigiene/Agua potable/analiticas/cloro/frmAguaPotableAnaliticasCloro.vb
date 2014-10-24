Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAguaPotableAnaliticasCloro
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAguaPotableAnaliticasCloro As DBO_AguaPotableAnaliticasCloro

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAguaPotableAnaliticasCloro, MaestroID)
        InitializeComponent()

        dboAguaPotableAnaliticasCloro = New DBO_AguaPotableAnaliticasCloro


        MyBase.newRegForm = New frmEntAguaPotableAnaliticasCloro(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAguaPotableAnaliticasCloro)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAguaPotableAnaliticasCloro = CType(sp, spAguaPotableAnaliticasCloro).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAguaPotableAnaliticasCloro Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAguaPotableAnaliticasCloro)
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
                .FormatoColumna("Referencia", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Analista", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Verificador", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Valor", BasesParaCompatibilidad.TiposColumna.Double2, 50)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
