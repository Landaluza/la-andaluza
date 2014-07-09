Public Class frmEntDDDPersonasAutorizadas
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_DDDPersonasAutorizadas As DBO_DDDPersonasAutorizadas

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDDDPersonasAutorizadas = Nothing, Optional ByRef v_dbo As DBO_DDDPersonasAutorizadas = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spDDDPersonasAutorizadas, v_sp)
       m_DBO_DDDPersonasAutorizadas = if(v_dbo Is Nothing, New DBO_DDDPersonasAutorizadas, v_dbo)
       dbo = m_DBO_DDDPersonasAutorizadas
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntDDDPersonasAutorizadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s as new spProveedores
        s.cargar_ComboBox(Me.cboProveedor)
       If me.mododeapertura = VISION Then
           Me.cboProveedor.enabled = False
           Me.lblProveedorID.enabled = False
           
       End If

       butVer.Visible = True
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_DDDPersonasAutorizadas = new dbo_DDDPersonasAutorizadas
       Else
       Me.m_DBO_DDDPersonasAutorizadas = dbo
       End If

           cboProveedor.SelectedValue = m_DBO_DDDPersonasAutorizadas.ProveedorID
           txtNombre.Text = m_DBO_DDDPersonasAutorizadas.Nombre
           txtRutaCarnetManipulador.Text = m_DBO_DDDPersonasAutorizadas.RutaCarnetManipulador
           txtObservaciones.Text = m_DBO_DDDPersonasAutorizadas.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

        If Me.cboProveedor.SelectedValue Is Nothing Then
            errores = "No seleccionó un proveedor" & Environment.NewLine
        Else
            m_DBO_DDDPersonasAutorizadas.ProveedorID = Me.cboProveedor.SelectedValue
        End If

       m_DBO_DDDPersonasAutorizadas.Nombre = txtNombre.Text


       m_DBO_DDDPersonasAutorizadas.RutaCarnetManipulador = txtRutaCarnetManipulador.Text


       m_DBO_DDDPersonasAutorizadas.Observaciones = txtObservaciones.Text


       If errores = String.empty then
         Dbo = m_DBO_DDDPersonasAutorizadas
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

   Private Sub butRutaCarnetManipulador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaCarnetManipulador.Click
       Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRutaCarnetManipulador.Text, "", "Z:\")
       If Me.Text.Substring(0, 3) <> "Ver" Then
           txtRutaCarnetManipulador.Text = arch
       End If 
   End Sub

   Public Overrides Sub Ver()
       Try
           Dim psi As New ProcessStartInfo()
           psi.UseShellExecute = True
           psi.FileName = txtRutaCarnetManipulador.Text
           Process.Start(psi)
       Catch ex As Exception
           messagebox.show(ex.Message)
       End Try
   End Sub

   Private Sub butVerProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProveedorID.Click
       Dim frmEnt As New frmProveedores()
       frmEnt.ShowDialog()
   End Sub

   Private Sub butAddProveedorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProveedorID.Click
       Dim DBO_Proveedores As New DBO_Proveedores
       Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spProveedores,DBO_Proveedores)
       frmEnt.ShowDialog()
       dim s as new spProveedores
        s.cargar_ComboBox(Me.cboProveedor)
   End Sub

End Class
