Public Class frmEntProvincias
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Provincias As DBO_Provincias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProvincias = Nothing, Optional ByRef v_dbo As DBO_Provincias = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spProvincias, v_sp)
        m_DBO_Provincias = if(v_dbo Is Nothing, New DBO_Provincias, v_dbo)
        dbo = m_DBO_Provincias
    End Sub

   Private Sub frmEntProvincias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spPaises
        s.cargar_ComboBox(cboId_pais, dtb)
        If Not Me.ModoDeApertura = VISION Then
            
            Me.cboId_pais.Visible = False
            Me.lblId_pais.Visible = False
            Me.butAddId_pais.Visible = False
            Me.butVerId_pais.Visible = False
        End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Provincias = New DBO_Provincias
       Else
            Me.m_DBO_Provincias = dbo
       End If
        cboId_pais.SelectedValue = m_DBO_Provincias.Id_pais
           txtNombre.Text = m_DBO_Provincias.Nombre
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty
       If cboId_pais.SelectedValue is Nothing then
           If errores = "" Then cboId_pais.Focus()
           errores = errores & "No seleccionó un valor para Id_pais." & Environment.NewLine
       Else
            m_DBO_Provincias.Id_pais = System.Convert.ToInt32(cboId_pais.SelectedValue)
       End If
       m_DBO_Provincias.Nombre = txtNombre.Text
       If errores = String.empty then
         Dbo = m_DBO_Provincias
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub butVerId_pais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_pais.Click
       Dim frmEnt As New frmPaises()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spPaises
        s.cargar_ComboBox(cboId_pais, dtb)
    End Sub

    Private Sub butAddId_pais_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_pais.Click
        Dim DBO_Paises As New DBO_Paises
        Dim frmEnt As New frmEntPaises(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPaises, DBO_Paises)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        Dim s As New spPaises
        s.cargar_ComboBox(cboId_pais, dtb)
    End Sub

End Class
