Public Class frmEntReconocimientosMedicosProtocolos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable

    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ReconocimientosMedicosProtocolos As DBO_ReconocimientosMedicosProtocolos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spReconocimientosMedicosProtocolos = Nothing, Optional ByRef v_dbo As DBO_ReconocimientosMedicosProtocolos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spReconocimientosMedicosProtocolos, v_sp)
       m_DBO_ReconocimientosMedicosProtocolos = if(v_dbo Is Nothing, New DBO_ReconocimientosMedicosProtocolos, v_dbo)
       dbo = m_DBO_ReconocimientosMedicosProtocolos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntReconocimientosMedicosProtocolos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s as new spReconocimientosMedicos
        s.cargar_ReconocimientosMedicos(Me.cboReconocimientoMedico)
       
        Dim s2 As New spProtocolosMedicos
        s2.cargar_ProtocolosMedicos(Me.cboProtocoloMedico)
       If me.mododeapertura = VISION Then
           Me.cboProtocoloMedico.enabled = False
           Me.lblProtocoloMedicoID.enabled = False
            Me.cboReconocimientoMedico.Enabled = False
            Me.lblReconocimientoMedicoID.Enabled = False
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ReconocimientosMedicosProtocolos = new dbo_ReconocimientosMedicosProtocolos
       Else
       Me.m_DBO_ReconocimientosMedicosProtocolos = dbo
       End If

           cboReconocimientoMedico.SelectedValue = m_DBO_ReconocimientosMedicosProtocolos.ReconocimientoMedicoID
           cboProtocoloMedico.SelectedValue = m_DBO_ReconocimientosMedicosProtocolos.ProtocoloMedicoID
           txtObservaciones.Text = m_DBO_ReconocimientosMedicosProtocolos.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


        If cboReconocimientoMedico.SelectedValue is Nothing Then
            If errores = "" Then cboReconocimientoMedico.Focus()
            errores = errores & "No seleccionó un valor para ReconocimientoMedicoID." & Environment.NewLine
        Else
            m_DBO_ReconocimientosMedicosProtocolos.ReconocimientoMedicoID = System.Convert.ToInt32(cboReconocimientoMedico.SelectedValue)
        End If

        If cboProtocoloMedico.SelectedValue is Nothing Then
            If errores = "" Then cboProtocoloMedico.Focus()
            errores = errores & "No seleccionó un valor para ProtocoloMedicoID." & Environment.NewLine
        Else
            m_DBO_ReconocimientosMedicosProtocolos.ProtocoloMedicoID = System.Convert.ToInt32(cboProtocoloMedico.SelectedValue)
        End If

        m_DBO_ReconocimientosMedicosProtocolos.Observaciones = txtObservaciones.Text


       If errores = String.empty then
         Dbo = m_DBO_ReconocimientosMedicosProtocolos
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

   Private Sub butVerReconocimientoMedicoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerReconocimientoMedicoID.Click
       Dim frmEnt As New frmReconocimientosMedicos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spReconocimientosMedicos
        s.cargar_ReconocimientosMedicos(Me.cboReconocimientoMedico)
    End Sub

    Private Sub butAddReconocimientoMedicoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddReconocimientoMedicoID.Click
        Dim DBO_ReconocimientosMedicos As New DBO_ReconocimientosMedicos
        Dim frmEnt As New frmEntReconocimientosMedicos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spReconocimientosMedicos, DBO_ReconocimientosMedicos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spReconocimientosMedicos
        s.cargar_ReconocimientosMedicos(Me.cboReconocimientoMedico)
    End Sub

    Private Sub butVerProtocoloMedicoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProtocoloMedicoID.Click
        Dim frmEnt As New frmProtocolosMedicos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProtocolosMedicos
        s.cargar_ProtocolosMedicos(Me.cboProtocoloMedico)
    End Sub

    Private Sub butAddProtocoloMedicoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProtocoloMedicoID.Click
        Dim DBO_ProtocolosMedicos As New DBO_ProtocolosMedicos
        Dim frmEnt As New frmEntProtocolosMedicos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProtocolosMedicos, DBO_ProtocolosMedicos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProtocolosMedicos
        s.cargar_ProtocolosMedicos(Me.cboProtocoloMedico)
    End Sub

End Class
