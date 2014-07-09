Public Class frmEntEnvasados
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Envasados As DBO_Envasados

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spEnvasados = Nothing, Optional ByRef v_dbo As DBO_Envasados = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spEnvasados, v_sp)
       m_DBO_Envasados = if(v_dbo Is Nothing, New DBO_Envasados, v_dbo)
       dbo = m_DBO_Envasados
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntEnvasados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_Envasados = new dbo_Envasados
       Else
       Me.m_DBO_Envasados = dbo
       End If

           dtpFecha.Text = m_DBO_Envasados.Fecha.toString
           txtEfectividad.Text = m_DBO_Envasados.Efectividad
           txtObservacionesEnvasado.Text = m_DBO_Envasados.ObservacionesEnvasado
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


        m_DBO_Envasados.Fecha = dtpFecha.Value.Date


        m_DBO_Envasados.Efectividad = System.Convert.ToDouble(txtEfectividad.Text)


       m_DBO_Envasados.ObservacionesEnvasado = txtObservacionesEnvasado.Text


       If errores = String.empty then
         Dbo = m_DBO_Envasados
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
