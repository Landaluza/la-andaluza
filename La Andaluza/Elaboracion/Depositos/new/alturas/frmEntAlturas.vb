Public Class frmEntAlturas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Alturas As DBO_Alturas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAlturas = Nothing, Optional ByRef v_dbo As DBO_Alturas = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spAlturas, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Alturas = If(v_dbo Is Nothing, New DBO_Alturas, v_dbo)
        dbo = m_DBO_Alturas
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spAlturas, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Alturas, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntAlturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spPiernas
        s0.cargar_Piernas(Me.cboPierna, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboPierna.enabled = False
            Me.lblPiernaID.enabled = False
        End If
        If Config.UserType <> 4 AndAlso Config.UserType <> 9 Then
            butAddPiernaID.Enabled = False
            butVerPiernaID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Alturas = New dbo_Alturas
        Else
            Me.m_DBO_Alturas = CType(dbo, DBO_Alturas)
        End If

        txtDescripcion.Text = m_DBO_Alturas.Descripcion
        cboPierna.SelectedValue = m_DBO_Alturas.PiernaID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_Alturas.Descripcion = txtDescripcion.Text
        End If



        If cboPierna.SelectedValue Is Nothing Then
            If errores = "" Then cboPierna.Focus()
            errores = errores & "No seleccionó un valor para PiernaID." & Environment.NewLine()
        Else
            m_DBO_Alturas.PiernaID = System.Convert.ToInt32(cboPierna.SelectedValue)
        End If
        If errores = String.empty Then
            Dbo = CType(m_DBO_Alturas, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerPiernaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerPiernaID.Click
        Dim frmEnt As New frmPiernas()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddPiernaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddPiernaID.Click
        Dim DBO_Piernas As New DBO_Piernas
        Dim frmEnt As New frmEntPiernas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPiernas, DBO_Piernas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spPiernas
        s.cargar_Piernas(Me.cboPierna, dtb)
    End Sub

    Private Sub frmEntAlturas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
