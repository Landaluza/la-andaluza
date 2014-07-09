Public Class frmEntPaletsTipos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_PaletsTipos As DBO_PaletsTipos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPaletsTipos = Nothing, Optional ByRef v_dbo As DBO_PaletsTipos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spPaletsTipos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_PaletsTipos = if(v_dbo Is Nothing, New DBO_PaletsTipos, v_dbo)
       dbo = m_DBO_PaletsTipos
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spPaletsTipos,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_PaletsTipos,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_PaletsTipos = new dbo_PaletsTipos
       Else
       Me.m_DBO_PaletsTipos = ctype(dbo, DBO_PaletsTipos)
       End If

           txtDescripcion.Text = m_DBO_PaletsTipos.Descripcion
           txtCodigoQS.Text = m_DBO_PaletsTipos.CodigoQS
           txtLargo.Text = m_DBO_PaletsTipos.Largo
           txtAncho.Text = m_DBO_PaletsTipos.Ancho
           txtAlto.Text = m_DBO_PaletsTipos.Alto
           txtPeso.Text = m_DBO_PaletsTipos.Peso
           txtMaterial.Text = m_DBO_PaletsTipos.Material
           chbTratado.Checked = m_DBO_PaletsTipos.Tratado
        txtAlias.Text = m_DBO_PaletsTipos.Aliass
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_PaletsTipos.Descripcion = txtDescripcion.Text
       End If



       If not isNumeric(txtCodigoQS.Text) then
           If errores = "" Then txtCodigoQS.Focus()
           errores = errores & "El campo CodigoQS debe ser numérico." & Environment.NewLine()
       Else
       m_DBO_PaletsTipos.CodigoQS = System.Convert.ToInt32(txtCodigoQS.Text)
       End If


       If txtLargo.Text= "" then
           If errores = "" Then txtLargo.Focus()
           errores = errores & "El campo Largo no puede estar vacío." & Environment.NewLine()
       Else
            m_DBO_PaletsTipos.Largo = System.Convert.ToDouble(txtLargo.Text)
        End If


        If txtAncho.Text = "" Then
            If errores = "" Then txtAncho.Focus()
            errores = errores & "El campo Ancho no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_PaletsTipos.Ancho = System.Convert.ToDouble(txtAncho.Text)
        End If


        If txtAlto.Text = "" Then
            If errores = "" Then txtAlto.Focus()
            errores = errores & "El campo Alto no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_PaletsTipos.Alto = System.Convert.ToDouble(txtAlto.Text)
        End If


        If txtPeso.Text = "" Then
            If errores = "" Then txtPeso.Focus()
            errores = errores & "El campo Peso no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_PaletsTipos.Peso = System.Convert.ToDouble(txtPeso.Text)
        End If


       If txtMaterial.Text= "" then
           If errores = "" Then txtMaterial.Focus()
           errores = errores & "El campo Material no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_PaletsTipos.Material = txtMaterial.Text
       End If



       m_DBO_PaletsTipos.Tratado = chbTratado.Checked

        m_DBO_PaletsTipos.Aliass = txtAlias.Text


       If errores = String.empty Then
         Dbo = ctype(m_DBO_PaletsTipos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntPaletsTipos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
