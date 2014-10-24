Public Class frmEntTiposControlesLotesPlantilla2
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_TiposControlesLotesPlantilla2 As DBO_TiposControlesLotesPlantilla2

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposControlesLotesPlantilla2 = Nothing, Optional ByRef v_dbo As DBO_TiposControlesLotesPlantilla2 = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposControlesLotesPlantilla2,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposControlesLotesPlantilla2 = if(v_dbo Is Nothing, New DBO_TiposControlesLotesPlantilla2, v_dbo)
       dbo = m_DBO_TiposControlesLotesPlantilla2
   End Sub

   Private Sub frmEntTiposControlesLotesPlantilla2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spTiposControlesLotes
        s0.cargar_TiposControlesLotes(Me.cboTipoControl, dtb)
       dim s1 as new spTiposLotes
        s1.cargar_TiposLotes(Me.cboTipoLote, dtb)
       dim s2 as new spTiposProductos
        s2.cargar_ComboBox(Me.cboTipoProducto, dtb)
       dim s3 as new spFrecuenciasTiposControlesLotes
        s3.cargar_FrecuenciasTiposControlesLotes(Me.cbofrecuencia, dtb)
       dim s4 as new spProcedimientos
        s4.cargar_Procedimientos(Me.cboprocedimiento, dtb)
       If Me.mododeapertura = VISION Then
           Me.cboTipoControl.enabled = False
           Me.lblId_TipoControl.enabled = False
           
           Me.cboTipoLote.enabled = False
           Me.lblId_TipoLote.enabled = False
           
           Me.cboTipoProducto.enabled = False
           Me.lblId_TipoProducto.enabled = False
           
           Me.cbofrecuencia.enabled = False
           Me.lblId_frecuencia.enabled = False
           
           Me.cboprocedimiento.enabled = False
           Me.lblId_procedimiento.enabled = False
           
       End If
       If Config.UserType <> 4 and Config.UserType <> 9 Then
   butAddId_TipoControl.enabled = false
   butVerId_TipoControl.enabled = false
   butAddId_TipoLote.enabled = false
   butVerId_TipoLote.enabled = false
   butAddId_TipoProducto.enabled = false
   butVerId_TipoProducto.enabled = false
   butAddId_frecuencia.enabled = false
   butVerId_frecuencia.enabled = false
   butAddId_procedimiento.enabled = false
   butVerId_procedimiento.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       Me.m_DBO_TiposControlesLotesPlantilla2 = ctype(dbo, DBO_TiposControlesLotesPlantilla2)

           cboTipoControl.SelectedValue = m_DBO_TiposControlesLotesPlantilla2.Id_TipoControl
           cboTipoLote.SelectedValue = m_DBO_TiposControlesLotesPlantilla2.Id_TipoLote
           cboTipoProducto.SelectedValue = m_DBO_TiposControlesLotesPlantilla2.Id_TipoProducto
           cbofrecuencia.SelectedValue = m_DBO_TiposControlesLotesPlantilla2.Id_frecuencia
           chbCritico.Checked = m_DBO_TiposControlesLotesPlantilla2.Critico
           cboprocedimiento.SelectedValue = m_DBO_TiposControlesLotesPlantilla2.Id_procedimiento
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If cboTipoControl.SelectedValue is Nothing then
           If errores = "" Then cboTipoControl.Focus()
           errores = errores & "No seleccionó un valor para Id_TipoControl." & Environment.NewLine()
       Else
       m_DBO_TiposControlesLotesPlantilla2.Id_TipoControl = System.Convert.ToInt32(cboTipoControl.SelectedValue)
       End If
       If cboTipoLote.SelectedValue is Nothing then
           If errores = "" Then cboTipoLote.Focus()
           errores = errores & "No seleccionó un valor para Id_TipoLote." & Environment.NewLine()
       Else
       m_DBO_TiposControlesLotesPlantilla2.Id_TipoLote = System.Convert.ToInt32(cboTipoLote.SelectedValue)
       End If
       m_DBO_TiposControlesLotesPlantilla2.Critico = chbCritico.Checked

       If errores = String.empty Then
         Dbo = ctype(m_DBO_TiposControlesLotesPlantilla2, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub butVerId_TipoControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoControl.Click
       Dim frmEnt As New frmTiposControlesLotes()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_TipoControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoControl.Click
       Dim DBO_TiposControlesLotes As New DBO_TiposControlesLotes
       Dim frmEnt As New frmEntTiposControlesLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spTiposControlesLotes,DBO_TiposControlesLotes)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposControlesLotes
        s.cargar_TiposControlesLotes(Me.cboTipoControl, dtb)
    End Sub

    Private Sub butVerId_TipoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoLote.Click
        Dim frmEnt As New frmTiposLotes()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_TipoLote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoLote.Click
        Dim DBO_TiposLotes As New DBO_TiposLotes
        Dim frmEnt As New frmEntTiposLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposLotes, DBO_TiposLotes)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposLotes
        s.cargar_TiposLotes(Me.cboTipoLote, dtb)
    End Sub

    Private Sub butVerId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoProducto.Click
        Dim frmEnt As New frmTiposProductos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoProducto.Click
        Dim DBO_TiposProductos As New DBO_TiposProductos
        Dim frmEnt As New frmEntTiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposProductos, DBO_TiposProductos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposProductos
        s.cargar_ComboBox(Me.cboTipoProducto, dtb)
    End Sub

    Private Sub butVerId_frecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_frecuencia.Click
        Dim frmEnt As New frmFrecuenciasTiposControlesLotes()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_frecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_frecuencia.Click
        Dim DBO_FrecuenciasTiposControlesLotes As New DBO_FrecuenciasTiposControlesLotes
        Dim frmEnt As New frmEntFrecuenciasTiposControlesLotes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spFrecuenciasTiposControlesLotes, DBO_FrecuenciasTiposControlesLotes)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spFrecuenciasTiposControlesLotes
        s.cargar_FrecuenciasTiposControlesLotes(Me.cbofrecuencia, dtb)
    End Sub

    Private Sub butVerId_procedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_procedimiento.Click
        Dim frmEnt As New frmProcedimientos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_procedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_procedimiento.Click
        Dim DBO_Procedimientos As New DBO_Procedimientos
        Dim frmEnt As New frmEntProcedimientos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProcedimientos, DBO_Procedimientos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProcedimientos
        s.cargar_Procedimientos(Me.cboprocedimiento, dtb)
    End Sub

   Private Sub frmEntTiposControlesLotesPlantilla2_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
