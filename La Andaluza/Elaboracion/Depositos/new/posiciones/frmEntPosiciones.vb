Public Class frmEntPosiciones
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Posiciones As DBO_Posiciones

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPosiciones = Nothing, Optional ByRef v_dbo As DBO_Posiciones = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spPosiciones, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Posiciones = if(v_dbo Is Nothing, New DBO_Posiciones, v_dbo)
        dbo = m_DBO_Posiciones
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spPosiciones, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Posiciones, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntPosiciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spAlturas
        s0.cargar_Alturas(Me.cboAltura)
        If Me.mododeapertura = VISION Then
            Me.cboAltura.enabled = False
            Me.lblAlturaID.enabled = False

        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddAlturaID.enabled = False
            butVerAlturaID.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Posiciones = New dbo_Posiciones
        Else
            Me.m_DBO_Posiciones = CType(dbo, DBO_Posiciones)
        End If

        txtDescripcion.Text = m_DBO_Posiciones.Descripcion
        cboAltura.SelectedValue = m_DBO_Posiciones.AlturaID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Posiciones.Descripcion = txtDescripcion.Text
        End If



        If cboAltura.SelectedValue is Nothing Then
            If errores = "" Then cboAltura.Focus()
            errores = errores & "No seleccionó un valor para AlturaID." & Environment.NewLine()
        Else
            m_DBO_Posiciones.AlturaID = System.Convert.ToInt32(cboAltura.SelectedValue)
        End If

        If errores = String.empty Then
            Dbo = CType(m_DBO_Posiciones, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerAlturaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerAlturaID.Click
        Dim frmEnt As New frmAlturas()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddAlturaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddAlturaID.Click
        Dim DBO_Alturas As New DBO_Alturas
        Dim frmEnt As New frmEntAlturas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spAlturas, DBO_Alturas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spAlturas
        s.cargar_Alturas(Me.cboAltura)
    End Sub

    Private Sub frmEntPosiciones_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
