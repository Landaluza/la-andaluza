Public Class frmEntArticulosLoteados
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ArticulosLoteados As DBO_ArticulosLoteados

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spArticulosLoteados = Nothing, Optional ByRef v_dbo As DBO_ArticulosLoteados = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spArticulosLoteados, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_ArticulosLoteados = IIf(v_dbo Is Nothing, New DBO_ArticulosLoteados, v_dbo)
        dbo = m_DBO_ArticulosLoteados
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spArticulosLoteados, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_ArticulosLoteados, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntArticulosLoteados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
        Dim s1 As New spTiposLoteados
        s1.cargar_TiposLoteados(Me.cboid_tipoLoteado)

        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddid_tipoLoteado.enabled = False
            butVerid_tipoLoteado.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_ArticulosLoteados = CType(dbo, DBO_ArticulosLoteados)

        cboid_tipoLoteado.SelectedValue = m_DBO_ArticulosLoteados.id_tipoLoteado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty

        m_DBO_ArticulosLoteados.id_tipoLoteado = cboid_tipoLoteado.SelectedValue

        If (errores = String.empty) Then
            Dbo = CType(m_DBO_ArticulosLoteados, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerid_tipoLoteado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_tipoLoteado.Click
        Dim frmEnt As New frmTiposLoteados()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddid_tipoLoteado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_tipoLoteado.Click
        Dim DBO_TiposLoteados As New DBO_TiposLoteados
        Dim frmEnt As New frmEntTiposLoteados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposLoteados, DBO_TiposLoteados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposLoteados
        s.cargar_TiposLoteados(Me.cboid_tipoLoteado)
    End Sub

    Private Sub frmEntArticulosLoteados_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
