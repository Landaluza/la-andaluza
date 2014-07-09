Public Class frmEntUnidadesMedidas
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Private m_DBO_UnidadesMedidas As DBO_UnidadesMedidas
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spUnidadesMedidas = Nothing, Optional ByRef v_dbo As DBO_UnidadesMedidas = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spUnidadesMedidas, v_sp)
       m_DBO_UnidadesMedidas = if(v_dbo Is Nothing, New DBO_UnidadesMedidas, v_dbo)
       dbo = m_DBO_UnidadesMedidas
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntUnidadesMedidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_UnidadesMedidas = new dbo_UnidadesMedidas
       Else
       Me.m_DBO_UnidadesMedidas = dbo
       End If

           txtDescripcion.Text = m_DBO_UnidadesMedidas.Descripcion
           txtAbreviatura.Text = m_DBO_UnidadesMedidas.Abreviatura
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_UnidadesMedidas.Descripcion = txtDescripcion.Text
       End If



       If txtAbreviatura.Text= "" then
           If errores = "" Then txtAbreviatura.Focus()
           errores = errores & "El campo Abreviatura no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_UnidadesMedidas.Abreviatura = txtAbreviatura.Text
       End If



       If errores = String.empty then
         Dbo = m_DBO_UnidadesMedidas
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
