Public Class frmEntPaletsMovimientosTipos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_PaletsMovimientosTipos As DBO_PaletsMovimientosTipos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPaletsMovimientosTipos = Nothing, Optional ByRef v_dbo As DBO_PaletsMovimientosTipos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spPaletsMovimientosTipos, v_sp)
       m_DBO_PaletsMovimientosTipos = if(v_dbo Is Nothing, New DBO_PaletsMovimientosTipos, v_dbo)
       dbo = m_DBO_PaletsMovimientosTipos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntPaletsMovimientosTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_PaletsMovimientosTipos = new dbo_PaletsMovimientosTipos
       Else
       Me.m_DBO_PaletsMovimientosTipos = dbo
       End If

           txtDescripcion.Text = m_DBO_PaletsMovimientosTipos.Descripcion
           chbEntrePalets.Checked = m_DBO_PaletsMovimientosTipos.EntrePalets
           txtUtilizacion.Text = m_DBO_PaletsMovimientosTipos.Utilizacion
           txtObservaciones.Text = m_DBO_PaletsMovimientosTipos.Observaciones
           chbEncajadoMonodosis.Checked = m_DBO_PaletsMovimientosTipos.EncajadoMonodosis
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_PaletsMovimientosTipos.Descripcion = txtDescripcion.Text


       m_DBO_PaletsMovimientosTipos.EntrePalets = chbEntrePalets.Checked

       m_DBO_PaletsMovimientosTipos.Utilizacion = txtUtilizacion.Text


       m_DBO_PaletsMovimientosTipos.Observaciones = txtObservaciones.Text


       m_DBO_PaletsMovimientosTipos.EncajadoMonodosis = chbEncajadoMonodosis.Checked

       If errores = String.empty then
         Dbo = m_DBO_PaletsMovimientosTipos
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub chbEncajadoMonodosis_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbEncajadoMonodosis.CheckedChanged
        If Me.chbEncajadoMonodosis.Checked Then Me.chbEntrePalets.Checked = True
    End Sub
End Class
