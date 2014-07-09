Public Class frmEntTiposFormatosLineas_TiposFormatos
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Event After_Save(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_TiposFormatosLineas_TiposFormatos As DBO_TiposFormatosLineas_TiposFormatos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposFormatosLineas_TiposFormatos = Nothing, Optional ByRef v_dbo As DBO_TiposFormatosLineas_TiposFormatos = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spTiposFormatosLineas_TiposFormatos, v_sp)
        m_DBO_TiposFormatosLineas_TiposFormatos = if(v_dbo Is Nothing, New DBO_TiposFormatosLineas_TiposFormatos, v_dbo)
        dbo = m_DBO_TiposFormatosLineas_TiposFormatos
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntTiposFormatosLineas_TiposFormatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spTiposFormatosLineas
        s.cargar_TiposFormatosLineas(Me.cboTipoFormatoLinea)

        Dim spTiposFormatos1 As New spArticulosEnvasadosHistorico1
        spTiposFormatos1.cargarComboBoxTodosSinLinea(Me.cboTipoFormato)

        If Me.ModoDeApertura = VISION Then
            Me.cboTipoFormato.Enabled = False
            Me.lblTipoFormatoID.Enabled = False
            Me.cboTipoFormatoLinea.Enabled = False
            Me.lblTipoFormatoLineaID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_TiposFormatosLineas_TiposFormatos = dbo

        cboTipoFormatoLinea.SelectedValue = m_DBO_TiposFormatosLineas_TiposFormatos.TipoFormatoLineaID
        cboTipoFormato.SelectedValue = m_DBO_TiposFormatosLineas_TiposFormatos.TipoFormatoID
        txtVelocidad.Text = m_DBO_TiposFormatosLineas_TiposFormatos.Velocidad
        txtPersonalRecomendado.Text = m_DBO_TiposFormatosLineas_TiposFormatos.PersonalRecomendado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.Empty

        'If cboTipoFormatoLinea.SelectedValue is Nothing then
        '    If errores = "" Then cboTipoFormatoLinea.Focus()
        '    errores = errores & "No seleccionó un valor para TipoFormatoLineaID." & Environment.NewLine
        'Else
        'm_DBO_TiposFormatosLineas_TiposFormatos.TipoFormatoLineaID = System.Convert.ToInt32(cboTipoFormatoLinea.SelectedValue)
        'End If
        If cboTipoFormato.SelectedValue is Nothing Then
            If errores = "" Then cboTipoFormato.Focus()
            errores = errores & "No seleccionó un valor para TipoFormatoID." & Environment.NewLine
        Else
            m_DBO_TiposFormatosLineas_TiposFormatos.TipoFormatoID = System.Convert.ToInt32(cboTipoFormato.SelectedValue)
        End If

        If Not IsNumeric(txtVelocidad.Text) Then
            If errores = "" Then txtVelocidad.Focus()
            errores = errores & "El campo Velocidad debe ser numérico." & Environment.NewLine
        Else
            m_DBO_TiposFormatosLineas_TiposFormatos.Velocidad = System.Convert.ToInt32(txtVelocidad.Text)
        End If

        If Not IsNumeric(txtPersonalRecomendado.Text) Then
            If errores = "" Then txtPersonalRecomendado.Focus()
            errores = errores & "El campo 'personal recomendado' debe ser numérico." & Environment.NewLine
        Else
            If Not txtPersonalRecomendado.Text > 0 Then
                If errores = "" Then txtPersonalRecomendado.Focus()
                errores = errores & "El campo 'personal recomendado' debe ser mayor que cero." & Environment.NewLine
            Else
                m_DBO_TiposFormatosLineas_TiposFormatos.PersonalRecomendado = System.Convert.ToInt32(txtPersonalRecomendado.Text)
            End If
        End If

        If errores = String.Empty Then
            dbo = m_DBO_TiposFormatosLineas_TiposFormatos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerTipoFormatoLineaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmTiposFormatosLineas()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddTipoFormatoLineaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_TiposFormatosLineas As New DBO_TiposFormatosLineas
        Dim frmEnt As New frmEntTiposFormatosLineas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spTiposFormatosLineas, DBO_TiposFormatosLineas)
        frmEnt.ShowDialog()
        Dim s As New spTiposFormatosLineas
        s.cargar_TiposFormatosLineas(Me.cboTipoFormatoLinea)
    End Sub



End Class
