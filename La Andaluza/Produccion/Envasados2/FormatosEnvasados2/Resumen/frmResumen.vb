Imports BasesParaCompatibilidad.dtpExtension
Public Class frmResumen
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private m_DBO_Resumen As DBO_ResumenFormatosEnvasados
    Private padre As frmEntFormatosEnvasados2

    Public Sub New(ByRef padre As frmEntFormatosEnvasados2, Optional embebido As Boolean = False)
        MyBase.New(New spResumen, 0)
        InitializeComponent()
        Me.Embebido = embebido
        Me.padre = padre

        Me.m_DBO_Resumen = New DBO_ResumenFormatosEnvasados
        Me.m_DBO_Resumen.FormatoEnvasadoID = Me.padre.m_DBO_FormatoEnvasado.ID
        Me.dgvGeneral.Visible = False
        dtpHoraFin.activarFoco()
        dtpHoraInicio.activarFoco()
    End Sub

    Public Sub setValores()
        'Me.recargarMedias()
        Me.recargarIncidencias()
        'Me.recargarTiempos()
        'Me.recargarTotales()
    End Sub

    Private Sub recargarMedias()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        CType(sp, spResumen).MediasEnvasado(Me.m_DBO_Resumen, dtb)

        Me.lblTiempoMedioProduccion.Text = Me.m_DBO_Resumen.MediasEnvasado_MinutosPorPalet
        Me.lblMediaBotellasHoras.Text = Me.m_DBO_Resumen.MediasEnvasado_Velocidad
        Me.lblEfectividad.Text = Me.m_DBO_Resumen.MediasEnvasado_Efectividad
    End Sub

    Private Sub recargarTotales()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        CType(sp, spResumen).TotalesEnvasado(Me.m_DBO_Resumen, dtb)

        Me.lblTotalBotellas.Text = Me.m_DBO_Resumen.TotalesIncidencias_CalidadNumero
        Me.lblTotalCajasCompletadas.Text = Me.m_DBO_Resumen.TotalesIncidencias_CalidadMinutos
        Me.lblTotalCajasSueltas.Text = Me.m_DBO_Resumen.TotalesIncidencias_RecuperablesNumero
        Me.lblTotalLitros.Text = Me.m_DBO_Resumen.TotalesIncidencias_RecuperablesMinutos
        Me.lblTotalNroCajas.Text = Me.m_DBO_Resumen.TotalesIncidencias_IntrinsicasNumero
        Me.lblTotalPalets.Text = Me.m_DBO_Resumen.TotalesIncidencias_IntrinsicasMinutos
    End Sub

    Private Sub recargarIncidencias()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        CType(sp, spResumen).DetallesIncidencias(Me.m_DBO_Resumen, dtb)

        Me.lblIncCalNumero.Text = Me.m_DBO_Resumen.TotalesIncidencias_CalidadNumero
        Me.lblIncCalTiempo.Text = Me.m_DBO_Resumen.TotalesIncidencias_CalidadMinutos
        Me.lblIncRecNumero.Text = Me.m_DBO_Resumen.TotalesIncidencias_RecuperablesNumero
        Me.lblIncRecTiempo.Text = Me.m_DBO_Resumen.TotalesIncidencias_RecuperablesMinutos
        Me.lblIncIntNumero.Text = Me.m_DBO_Resumen.TotalesIncidencias_IntrinsicasNumero
        Me.lblIncIntTiempo.Text = Me.m_DBO_Resumen.TotalesIncidencias_IntrinsicasMinutos
        Me.lblIncMecNumero.Text = Me.m_DBO_Resumen.TotalesIncidencias_MaquinaNumero
        Me.lblIncMecTiempo.Text = Me.m_DBO_Resumen.TotalesIncidencias_MaquinaMinutos
        Me.lblIncOtrNumero.Text = Me.m_DBO_Resumen.TotalesIncidencias_OtrosNumero
        Me.lblIncOtrTiempo.Text = Me.m_DBO_Resumen.TotalesIncidencias_OtrosMinutos
        Me.lblMinutos.Text = Me.m_DBO_Resumen.TotalesIncidencias_TotalMinutos
    End Sub

    Private Sub recargarTiempos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        CType(sp, spResumen).TotalesTiempo(Me.m_DBO_Resumen, dtb)

        Me.lblTiemposAsignado.Text = Me.m_DBO_Resumen.TotalesIncidencias_CalidadNumero
        Me.lblTiemposIncidenciasEvitables.Text = Me.m_DBO_Resumen.TotalesIncidencias_CalidadMinutos
        Me.lblTiemposIncidenciasNoEvitables.Text = Me.m_DBO_Resumen.TotalesIncidencias_RecuperablesNumero
        Me.lblTiemposNoJustificados.Text = Me.m_DBO_Resumen.TotalesIncidencias_RecuperablesMinutos
        Me.lblTiemposTotalIncidencias.Text = Me.m_DBO_Resumen.TotalesIncidencias_IntrinsicasNumero
        Me.dtpHoraFin.Value = Me.m_DBO_Resumen.TiemposTotales_HoraFin
        Me.dtpHoraInicio.Value = Me.m_DBO_Resumen.TiemposTotales_HoraInicio
    End Sub

    Private Sub frmResumen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Embebido Then
            Me.bdnGeneral.Enabled = False
            Me.bdnGeneral.Visible = False
        End If
    End Sub
End Class