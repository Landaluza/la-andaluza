Public Class frmSaludLaboral
    Private frmReconocimientosMedicosSolicitudes As frmReconocimientosMedicosSolicitudes
    Private frmReconocimientosMedicosSolicitudesEmpleados As frmReconocimientosMedicosSolicitudesEmpleados
    Private frmReconocimientosMedicos As frmReconocimientosMedicos
    Private frmReconocimientosMedicosTipos As frmReconocimientosMedicosTipos

    Private frmProgramasActividadesPreventivas As frmProgramasActividadesPreventivas
    Private frmProtocolosMedicos As frmProtocolosMedicos
    Private frmProtocolosMedicosPuestosTrabajos As frmProtocolosMedicosPuestosTrabajos
    Private frmReconocimientosMedicosProtocolos As frmReconocimientosMedicosProtocolos

    Public Sub New()
        InitializeComponent()
        frmReconocimientosMedicosSolicitudes = New frmReconocimientosMedicosSolicitudes
        frmReconocimientosMedicosSolicitudesEmpleados = New frmReconocimientosMedicosSolicitudesEmpleados
        frmReconocimientosMedicos = New frmReconocimientosMedicos
        frmReconocimientosMedicosTipos = New frmReconocimientosMedicosTipos

        frmProgramasActividadesPreventivas = New frmProgramasActividadesPreventivas
        frmProtocolosMedicos = New frmProtocolosMedicos
        frmProtocolosMedicosPuestosTrabajos = New frmProtocolosMedicosPuestosTrabajos
        frmReconocimientosMedicosProtocolos = New frmReconocimientosMedicosProtocolos
    End Sub

  
    Private Sub frmSaludLaboral_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(Me.frmReconocimientosMedicosSolicitudes, Me.tpSolicitudes)
        Engine_LA.FormEnPestaña(Me.frmReconocimientosMedicosSolicitudesEmpleados, tpSolicitudesEmpleados)
        Engine_LA.FormEnPestaña(frmReconocimientosMedicos, tpRealizados)
        Engine_LA.FormEnPestaña(frmReconocimientosMedicosTipos, Me.tpTipos)

        Engine_LA.FormEnPestaña(frmProgramasActividadesPreventivas, Me.tpActividadesPreventivas)
        Engine_LA.FormEnPestaña(frmProtocolosMedicos, Me.tpProtocolos)
        Engine_LA.FormEnPestaña(frmProtocolosMedicosPuestosTrabajos, Me.tpProtocolosAsignadosaPuestos)
        Engine_LA.FormEnPestaña(frmReconocimientosMedicosProtocolos, Me.tpprotocolosRealizadosReconocimientos)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        Dim frm As New frmEmpleados
        GUImain.añadirPestaña(frm)
    End Sub

    Private Sub btnPuestos_Click(sender As Object, e As EventArgs) Handles btnPuestos.Click
        Dim frm As New frmPuestosTrabajos
        GUImain.añadirPestaña(frm)
    End Sub

    Private Sub btnMedicos_Click_1(sender As Object, e As EventArgs) Handles btnMedicos.Click
        Dim frm As New frmMedicos
        GUImain.añadirPestaña(frm)
    End Sub

    Private Sub btnGrupos_Click(sender As Object, e As EventArgs) Handles btnGrupos.Click
        Dim frm As New frmGrupos_riesgo
        GUImain.añadirPestaña(frm)
    End Sub

End Class