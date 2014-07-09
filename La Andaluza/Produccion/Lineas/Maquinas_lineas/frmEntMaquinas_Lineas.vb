Public Class frmEntMaquinas_Lineas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Maquinas_Lineas As DBO_Maquinas_Lineas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spMaquinas_Lineas = Nothing, Optional ByRef v_dbo As DBO_Maquinas_Lineas = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spMaquinas_Lineas, v_sp)
        m_DBO_Maquinas_Lineas = if(v_dbo Is Nothing, New DBO_Maquinas_Lineas, v_dbo)
        dbo = m_DBO_Maquinas_Lineas
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntMaquinas_Lineas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spMaquinas
        s.cargar_Maquinas(Me.cboMaquina)

        Dim s2 As New spLineasEnvasado
        s2.cargar_LineasEnvasado(Me.cboLinea)
        If Me.mododeapertura = VISION Then
            Me.cboLinea.enabled = False
            Me.lblLineaID.enabled = False
            Me.cboMaquina.Enabled = False
            Me.lblMaquinaID.Enabled = False

        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_Maquinas_Lineas = dbo


        cboMaquina.SelectedValue = m_DBO_Maquinas_Lineas.MaquinaID
        cboLinea.SelectedValue = m_DBO_Maquinas_Lineas.LineaID
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty

        If cboMaquina.SelectedValue is Nothing Then
            If errores = "" Then cboMaquina.Focus()
            errores = errores & "No seleccionó un valor para MaquinaID." & Environment.NewLine
        Else
            m_DBO_Maquinas_Lineas.MaquinaID = System.Convert.ToInt32(cboMaquina.SelectedValue)
        End If
        If cboLinea.SelectedValue is Nothing Then
            If errores = "" Then cboLinea.Focus()
            errores = errores & "No seleccionó un valor para LineaID." & Environment.NewLine
        Else
            m_DBO_Maquinas_Lineas.LineaID = System.Convert.ToInt32(cboLinea.SelectedValue)
        End If

        If errores = String.empty Then
            Dbo = m_DBO_Maquinas_Lineas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerMaquinaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerMaquinaID.Click
        Dim frmEnt As New frmMaquinas()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddMaquinaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddMaquinaID.Click
        Dim DBO_Maquinas As New DBO_Maquinas
        Dim frmEnt As New frmEntMaquinas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spMaquinas, DBO_Maquinas)
        frmEnt.ShowDialog()
        Dim s As New spMaquinas
        s.cargar_Maquinas(Me.cboMaquina)
    End Sub

    Private Sub butVerLineaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmLineasEnvasado()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddLineaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_LineasEnvasado As New DBO_LineasEnvasado
        Dim frmEnt As New frmEntLineasEnvasado(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spLineasEnvasado, DBO_LineasEnvasado)
        frmEnt.ShowDialog()
        Dim s As New spLineasEnvasado
        s.cargar_LineasEnvasado(Me.cboLinea)
    End Sub

End Class
