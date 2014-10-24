Public Class frmEntProtocolosMedicosPuestosTrabajos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ProtocolosMedicosPuestosTrabajos As DBO_ProtocolosMedicosPuestosTrabajos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProtocolosMedicosPuestosTrabajos = Nothing, Optional ByRef v_dbo As DBO_ProtocolosMedicosPuestosTrabajos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spProtocolosMedicosPuestosTrabajos, v_sp)
       m_DBO_ProtocolosMedicosPuestosTrabajos = if(v_dbo Is Nothing, New DBO_ProtocolosMedicosPuestosTrabajos, v_dbo)
       dbo = m_DBO_ProtocolosMedicosPuestosTrabajos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntProtocolosMedicosPuestosTrabajos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spPuestosTrabajos
        s.cargar_PuestosTrabajos(Me.cboPuestoTrabajo, dtb)
       
        Dim s2 As New spProtocolosMedicos
        s2.cargar_ProtocolosMedicos(Me.cboProtocoloMedico, dtb)
     
        Dim s3 As New spProgramasActividadesPreventivas
        s3.cargar_ProgramasActividadesPreventivas(Me.cboProgramaActividadPreventiva, dtb)

       If me.mododeapertura = VISION Then
           Me.cboProgramaActividadPreventiva.enabled = False
           Me.lblProgramaActividadPreventivaID.enabled = False
            Me.cboPuestoTrabajo.Enabled = False
            Me.lblPuestoTrabajoID.Enabled = False
            Me.cboProtocoloMedico.Enabled = False
            Me.lblProtocoloMedicoID.Enabled = False
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ProtocolosMedicosPuestosTrabajos = new dbo_ProtocolosMedicosPuestosTrabajos
       Else
       Me.m_DBO_ProtocolosMedicosPuestosTrabajos = dbo
       End If

           cboPuestoTrabajo.SelectedValue = m_DBO_ProtocolosMedicosPuestosTrabajos.PuestoTrabajoID
           cboProtocoloMedico.SelectedValue = m_DBO_ProtocolosMedicosPuestosTrabajos.ProtocoloMedicoID
           cboProgramaActividadPreventiva.SelectedValue = m_DBO_ProtocolosMedicosPuestosTrabajos.ProgramaActividadPreventivaID
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

        Me.m_DBO_ProtocolosMedicosPuestosTrabajos.ProgramaActividadPreventivaID = Me.cboProgramaActividadPreventiva.SelectedValue
        Me.m_DBO_ProtocolosMedicosPuestosTrabajos.ProtocoloMedicoID = Me.cboProtocoloMedico.SelectedValue
        Me.m_DBO_ProtocolosMedicosPuestosTrabajos.PuestoTrabajoID = Me.cboPuestoTrabajo.SelectedValue        

       If errores = String.empty then
         Dbo = m_DBO_ProtocolosMedicosPuestosTrabajos
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub butVerPuestoTrabajoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerPuestoTrabajoID.Click
       Dim frmEnt As New frmPuestosTrabajos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spPuestosTrabajos
        s.cargar_PuestosTrabajos(Me.cboPuestoTrabajo, dtb)
    End Sub

    Private Sub butAddPuestoTrabajoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddPuestoTrabajoID.Click
        'Dim DBO_PuestosTrabajos As New DBO_PuestosTrabajos
        'Dim frmEnt As New frmEntPuestosTrabajos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spPuestosTrabajos,DBO_PuestosTrabajos)
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        'dim s as new spPuestosTrabajos
        's.cargar_PuestosTrabajos(Me.cboPuestoTrabajo)
    End Sub

    Private Sub butVerProtocoloMedicoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProtocoloMedicoID.Click
        Dim frmEnt As New frmProtocolosMedicos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProtocolosMedicos
        s.cargar_ProtocolosMedicos(Me.cboProtocoloMedico, dtb)
    End Sub

    Private Sub butAddProtocoloMedicoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProtocoloMedicoID.Click
        Dim DBO_ProtocolosMedicos As New DBO_ProtocolosMedicos
        Dim frmEnt As New frmEntProtocolosMedicos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProtocolosMedicos, DBO_ProtocolosMedicos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProtocolosMedicos
        s.cargar_ProtocolosMedicos(Me.cboProtocoloMedico, dtb)
    End Sub

    Private Sub butVerProgramaActividadPreventivaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProgramaActividadPreventivaID.Click
        Dim frmEnt As New frmProgramasActividadesPreventivas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProgramasActividadesPreventivas
        s.cargar_ProgramasActividadesPreventivas(Me.cboProgramaActividadPreventiva, dtb)
    End Sub

    Private Sub butAddProgramaActividadPreventivaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProgramaActividadPreventivaID.Click
        Dim DBO_ProgramasActividadesPreventivas As New DBO_ProgramasActividadesPreventivas
        Dim frmEnt As New frmEntProgramasActividadesPreventivas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProgramasActividadesPreventivas, DBO_ProgramasActividadesPreventivas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProgramasActividadesPreventivas
        s.cargar_ProgramasActividadesPreventivas(Me.cboProgramaActividadPreventiva, dtb)
    End Sub

End Class
