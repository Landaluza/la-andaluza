Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAguaPotableAnaliticasOrganolepticas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAguaPotableAnaliticasOrganolepticas As DBO_AguaPotableAnaliticasOrganolepticas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAguaPotableAnaliticasOrganolepticas, MaestroID)
        InitializeComponent()

        dboAguaPotableAnaliticasOrganolepticas = New DBO_AguaPotableAnaliticasOrganolepticas


        MyBase.newRegForm = New frmEntAguaPotableAnaliticasOrganolepticas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAguaPotableAnaliticasOrganolepticas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAguaPotableAnaliticasOrganolepticas = CType(sp, spAguaPotableAnaliticasOrganolepticas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAguaPotableAnaliticasOrganolepticas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAguaPotableAnaliticasOrganolepticas)
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
                .FormatoColumna("Analista", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Verificador", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
