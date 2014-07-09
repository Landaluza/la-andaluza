Public Class AguaPotable
    ''Private m_DBO_AguaPotablePuntosMuestreo As New DBO_AguaPotablePuntosMuestreos
    Private frmAguaPotableAnaliticasOrganolepticas As frmAguaPotableAnaliticasOrganolepticas
    Private frmAguaPotableAnaliticasAnuales As frmAguaPotableAnaliticasAnuales
    Private frmAguaPotableInformesMensuales As frmAguaPotableInformesMensuales
    Private frmAguaPotablePuntosMuestreos As frmAguaPotablePuntosMuestreos
    Private frmAguaPotableConsumos As frmAguaPotableConsumos
    Private frmAguaPotableAnaliticasCloro As frmAguaPotableAnaliticasCloro


    Public Sub New()
        InitializeComponent()
        frmAguaPotableAnaliticasOrganolepticas = New frmAguaPotableAnaliticasOrganolepticas
        frmAguaPotableAnaliticasAnuales = New frmAguaPotableAnaliticasAnuales
        frmAguaPotableInformesMensuales = New frmAguaPotableInformesMensuales
        frmAguaPotablePuntosMuestreos = New frmAguaPotablePuntosMuestreos
        frmAguaPotableConsumos = New frmAguaPotableConsumos
        frmAguaPotableAnaliticasCloro = New frmAguaPotableAnaliticasCloro
    End Sub

 

    Private Sub AguaPotable_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(frmAguaPotableAnaliticasCloro, tbpAnaliticasCloro)
        Engine_LA.FormEnPestaña(frmAguaPotableAnaliticasOrganolepticas, tbpAnaliticasOrganolepticas)
        Engine_LA.FormEnPestaña(frmAguaPotableAnaliticasAnuales, tbpAnaliticasAnuales)
        Engine_LA.FormEnPestaña(frmAguaPotableInformesMensuales, tbpInformesMensuales)
        Engine_LA.FormEnPestaña(frmAguaPotablePuntosMuestreos, tbpPuntosMuestreo)
        Engine_LA.FormEnPestaña(frmAguaPotableConsumos, tbpConsumos)
    End Sub

    Private Sub btnAnaliticasCloro_Click(sender As Object, e As EventArgs) Handles btnAnaliticasCloro.Click
        Dim frm As New frmGenerarAnaliticasCloro
        frm.ShowDialog()
    End Sub
End Class