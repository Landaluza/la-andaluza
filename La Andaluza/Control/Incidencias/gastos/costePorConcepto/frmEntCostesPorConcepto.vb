Public Class frmEntCostesPorConcepto
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_CostesPorConcepto As DBO_CostesPorConcepto

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spCostesPorConcepto = Nothing, Optional ByRef v_dbo As DBO_CostesPorConcepto = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spCostesPorConcepto,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_CostesPorConcepto = If(v_dbo Is Nothing, New DBO_CostesPorConcepto, v_dbo)
       dbo = m_DBO_CostesPorConcepto
   End Sub

   Private Sub frmEntCostesPorConcepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spConceptosGastosIncidencias
       s0.cargar_ConceptosGastosIncidencias(Me.cboConceptosGastosIncidencias)
       If (me.mododeapertura = VISION) Then
           Me.cboConceptosGastosIncidencias.enabled = False
           Me.lblId_ConceptosGastosIncidencias.enabled = False
           
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddId_ConceptosGastosIncidencias.enabled = false
   butVerId_ConceptosGastosIncidencias.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_CostesPorConcepto = ctype(dbo, DBO_CostesPorConcepto)

           cboConceptosGastosIncidencias.SelectedValue = m_DBO_CostesPorConcepto.Id_ConceptosGastosIncidencias
           txtCoste.Text = m_DBO_CostesPorConcepto.Coste
           dtpFecha.Value = m_DBO_CostesPorConcepto.Fecha
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If cboConceptosGastosIncidencias.selectedvalue = nothing then
           If errores = "" Then cboConceptosGastosIncidencias.Focus()
           errores = errores & "No seleccionó un valor para Id_ConceptosGastosIncidencias." & Environment.NewLine()
       Else
       m_DBO_CostesPorConcepto.Id_ConceptosGastosIncidencias = System.Convert.ToInt32(cboConceptosGastosIncidencias.SelectedValue)
       End If
       If txtCoste.Text= "" then
           If errores = "" Then txtCoste.Focus()
           errores = errores & "El campo Coste no puede estar vacío." & Environment.NewLine()
       Else
            m_DBO_CostesPorConcepto.Coste = System.Convert.ToDouble(txtCoste.Text.Replace(".", ","))
       End If


       m_DBO_CostesPorConcepto.Fecha = dtpFecha.value


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_CostesPorConcepto, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub butVerId_ConceptosGastosIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_ConceptosGastosIncidencias.Click
       Dim frmEnt As New frmConceptosGastosIncidencias()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_ConceptosGastosIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_ConceptosGastosIncidencias.Click
       Dim DBO_ConceptosGastosIncidencias As New DBO_ConceptosGastosIncidencias
       Dim frmEnt As New frmEntConceptosGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spConceptosGastosIncidencias,DBO_ConceptosGastosIncidencias)
       frmEnt.ShowDialog()
       dim s as new spConceptosGastosIncidencias
       s.cargar_ConceptosGastosIncidencias(Me.cboConceptosGastosIncidencias)
   End Sub

   Private Sub frmEntCostesPorConcepto_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
