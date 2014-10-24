Public Class frmEntPoblaciones
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Poblaciones As DBO_Poblaciones

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPoblaciones = Nothing, Optional ByRef v_dbo As DBO_Poblaciones = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spPoblaciones, v_sp)
        m_DBO_Poblaciones = if(v_dbo Is Nothing, New DBO_Poblaciones, v_dbo)
        dbo = m_DBO_Poblaciones
    End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntPoblaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spProvincias

        If Me.m_DBO_Poblaciones.Id_provincia = Nothing Then
            s.cargar_ComboBox(cboId_provincia, 0, dtb)
        Else
            s.cargar_ComboBox(cboId_provincia, s.Select_Record(Me.m_DBO_Poblaciones.Id_provincia, dtb).Id_pais, dtb)
        End If

        
        ' Me.cboId_provincia.mam_DataSource("Poblaciones_ProvinciasCbo"), False)
        If Not Me.ModoDeApertura = VISION Then
            
            Me.cboId_provincia.Visible = False
            Me.lblId_provincia.Visible = False
            Me.butAddId_provincia.Visible = False
            Me.butVerId_provincia.Visible = False
        End If

    End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_Poblaciones = new dbo_Poblaciones
       Else
       Me.m_DBO_Poblaciones = dbo
       End If

           cboId_provincia.SelectedValue = m_DBO_Poblaciones.Id_provincia
           txtNombre.Text = m_DBO_Poblaciones.Nombre

   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

       If cboId_provincia.SelectedValue is Nothing then
           If errores = "" Then cboId_provincia.Focus()
           errores = errores & "No seleccionó un valor para Id_provincia." & Environment.NewLine
       Else
       m_DBO_Poblaciones.Id_provincia = System.Convert.ToInt32(cboId_provincia.SelectedValue)
       End If
       m_DBO_Poblaciones.Nombre = txtNombre.Text

       If errores = String.empty then
         Dbo = m_DBO_Poblaciones
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub butVerId_provincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_provincia.Click
       Dim frmEnt As New frmProvincias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProvincias
        s.cargar_ComboBox(cboId_provincia, s.Select_Record(Me.cboId_provincia.SelectedValue, dtb).Id_pais, dtb)
    End Sub

    Private Sub butAddId_provincia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_provincia.Click
        Dim DBO_Provincias As New DBO_Provincias
        Dim frmEnt As New frmEntProvincias(frmProvincias.ACCION_INSERTAR, New spProvincias, DBO_Provincias)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProvincias

        s.cargar_ComboBox(cboId_provincia, s.Select_Record(Me.cboId_provincia.SelectedValue, dtb).Id_pais, dtb)
    End Sub

End Class
