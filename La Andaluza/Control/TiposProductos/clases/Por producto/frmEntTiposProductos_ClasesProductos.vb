Public Class frmEntTiposProductos_ClasesProductos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_TiposProductos_ClasesProductos As DBO_TiposProductos_ClasesProductos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposProductos_ClasesProductos = Nothing, Optional ByRef v_dbo As DBO_TiposProductos_ClasesProductos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposProductos_ClasesProductos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposProductos_ClasesProductos = If(v_dbo Is Nothing, New DBO_TiposProductos_ClasesProductos, v_dbo)
       dbo = m_DBO_TiposProductos_ClasesProductos
   End Sub

   Private Sub frmEntTiposProductos_ClasesProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s1 as new spClasesProductos
        s1.cargar_ClasesProductos(Me.cboClaseProducto, dtb)
       If (me.mododeapertura = VISION) Then
           Me.cboClaseProducto.enabled = False
           Me.lblId_ClaseProducto.enabled = False
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddId_ClaseProducto.enabled = false
   butVerId_ClaseProducto.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_TiposProductos_ClasesProductos = ctype(dbo, DBO_TiposProductos_ClasesProductos)

           cboClaseProducto.SelectedValue = m_DBO_TiposProductos_ClasesProductos.Id_ClaseProducto
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty

        If cboClaseProducto.SelectedValue = Nothing Then
            If errores = "" Then cboClaseProducto.Focus()
            errores = errores & "No seleccionó un valor para Id_ClaseProducto." & Environment.NewLine()
        Else
            m_DBO_TiposProductos_ClasesProductos.Id_ClaseProducto = System.Convert.ToInt32(cboClaseProducto.SelectedValue)
        End If

       If (errores = String.empty) then
         Dbo = ctype(m_DBO_TiposProductos_ClasesProductos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmTiposProductos()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_TiposProductos As New DBO_TiposProductos
        Dim frmEnt As New frmEntTiposProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposProductos, DBO_TiposProductos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butVerId_ClaseProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_ClaseProducto.Click
        Dim frmEnt As New frmClasesProductos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_ClaseProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_ClaseProducto.Click
        Dim DBO_ClasesProductos As New DBO_ClasesProductos
        Dim frmEnt As New frmEntClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spClasesProductos, DBO_ClasesProductos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spClasesProductos
        s.cargar_ClasesProductos(Me.cboClaseProducto, dtb)
    End Sub

   Private Sub frmEntTiposProductos_ClasesProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
