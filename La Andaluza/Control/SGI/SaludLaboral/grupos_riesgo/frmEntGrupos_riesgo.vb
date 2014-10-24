Public Class frmEntGrupos_riesgo
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Grupos_riesgo As DBO_Grupos_riesgo

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spGrupos_riesgo = Nothing, Optional ByRef v_dbo As DBO_Grupos_riesgo = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spGrupos_riesgo, v_sp)
       m_DBO_Grupos_riesgo = if(v_dbo Is Nothing, New DBO_Grupos_riesgo, v_dbo)
       dbo = m_DBO_Grupos_riesgo
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntGrupos_riesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_Grupos_riesgo = new dbo_Grupos_riesgo
       Else
       Me.m_DBO_Grupos_riesgo = dbo
       End If

           txtnombre.Text = m_DBO_Grupos_riesgo.nombre
           txtdescripcion.Text = m_DBO_Grupos_riesgo.descripcion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

        If Me.txtnombre.Text = "" Then
            errores &= "El nombre no puede estar vacío" & Environment.NewLine
        Else
            Me.m_DBO_Grupos_riesgo.nombre = txtnombre.Text
        End If

        Me.m_DBO_Grupos_riesgo.descripcion = Me.txtdescripcion.Text

       If errores = String.empty then
         Dbo = m_DBO_Grupos_riesgo
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

End Class
