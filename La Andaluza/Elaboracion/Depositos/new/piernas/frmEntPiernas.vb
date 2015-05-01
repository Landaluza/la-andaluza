Public Class frmEntPiernas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Piernas As DBO_Piernas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPiernas = Nothing, Optional ByRef v_dbo As DBO_Piernas = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spPiernas, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Piernas = if(v_dbo Is Nothing, New DBO_Piernas, v_dbo)
        dbo = m_DBO_Piernas
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spPiernas, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Piernas, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntPiernas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spNaves
        s0.cargar_Naves(Me.cboNave, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboNave.enabled = False
            Me.lblNaveID.enabled = False
        End If
        If Config.UserType <> 4 AndAlso Config.UserType <> 9 Then
            butAddNaveID.Enabled = False
            butVerNaveID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Piernas = New dbo_Piernas
        Else
            Me.m_DBO_Piernas = CType(dbo, DBO_Piernas)
        End If

        txtDescripcion.Text = m_DBO_Piernas.Descripcion
        cboNave.SelectedValue = m_DBO_Piernas.NaveID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Piernas.Descripcion = txtDescripcion.Text
        End If



        If cboNave.SelectedValue is Nothing Then
            If errores = "" Then cboNave.Focus()
            errores = errores & "No seleccionó un valor para NaveID." & Environment.NewLine()
        Else
            m_DBO_Piernas.NaveID = System.Convert.ToInt32(cboNave.SelectedValue)
        End If

        If errores = String.empty Then
            Dbo = CType(m_DBO_Piernas, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerNaveID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerNaveID.Click
        Dim frmEnt As New frmNaves()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddNaveID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddNaveID.Click
        Dim DBO_Naves As New DBO_Naves
        Dim frmEnt As New frmEntNaves(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spNaves, DBO_Naves)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spNaves
        s.cargar_Naves(Me.cboNave, dtb)
    End Sub

    Private Sub frmEntPiernas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
