Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmEntEnvasadosProductosAnaliticas2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_EnvasadosProductosAnalitica As DBO_EnvasadosProductosAnaliticas2
    Private m_VerID As Boolean = False
    Private spEnvasadosProductosAnaliticas2 As spEnvasadosProductosAnaliticas2

    Public Sub New(modo As String, ByRef EnvasadosProductosAnalitica As DBO_EnvasadosProductosAnaliticas2, ByVal Pos As Integer, ByVal VerID As Boolean)
        MyBase.New(modo)
        spEnvasadosProductosAnaliticas2 = New spEnvasadosProductosAnaliticas2
        InitializeComponent()
        m_DBO_EnvasadosProductosAnalitica = EnvasadosProductosAnalitica
        m_Pos = Pos
        m_VerID = VerID
    End Sub

    Private Sub frmEntEnvasadosProductosAnaliticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboParametroID.mam_DataSource("ListaParametrosEnvasadosCbo", False, dtb)

        Me.cboAnalistaID.mam_DataSource("EmpleadosAnalistasSelectCbo", False, dtb)


        SetValores(m_DBO_EnvasadosProductosAnalitica.EnvasadoProductoAnaliticaID, False)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        If Me.ModoDeApertura = INSERCION Then
            cboParametroID.Text = ""
            cboAnalistaID.Text = ""
            dtpHora.Value = DateTime.Now
        Else
            cboParametroID.SelectedValue = If(m_DBO_EnvasadosProductosAnalitica.ParametroID.HasValue, m_DBO_EnvasadosProductosAnalitica.ParametroID, -1)
            cboAnalistaID.SelectedValue = If(m_DBO_EnvasadosProductosAnalitica.AnalistaID.HasValue, m_DBO_EnvasadosProductosAnalitica.AnalistaID, -1)
            dtpHora.Value = DateTime.Now.Date.Add(m_DBO_EnvasadosProductosAnalitica.Hora)
        End If
        txtEnvasadoProductoAnaliticaID.Text = m_DBO_EnvasadosProductosAnalitica.EnvasadoProductoAnaliticaID
        txtEnvasadoProductoID.Text = If(m_DBO_EnvasadosProductosAnalitica.EnvasadoProductoID.HasValue, Convert.ToString(m_DBO_EnvasadosProductosAnalitica.EnvasadoProductoID), "")
        txtValor.Text = If(m_DBO_EnvasadosProductosAnalitica.Valor.HasValue, Convert.ToString(m_DBO_EnvasadosProductosAnalitica.Valor), "")
        txtObservaciones.Text = m_DBO_EnvasadosProductosAnalitica.Observaciones

    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservaciones.Focus()
        Dim errores As String = ""

        m_DBO_EnvasadosProductosAnalitica.EnvasadoProductoID = System.Convert.ToInt32(If(txtEnvasadoProductoID.Text = "", Nothing, txtEnvasadoProductoID.Text))
        m_DBO_EnvasadosProductosAnalitica.Hora = New TimeSpan(dtpHora.Value.Hour, dtpHora.Value.Minute, 0)
        m_DBO_EnvasadosProductosAnalitica.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)


        If cboParametroID.SelectedValue Is Nothing Then
            cboParametroID.Focus()
            errores = errores & "No eligio un valor en Parametro." & Environment.NewLine
        Else
            m_DBO_EnvasadosProductosAnalitica.ParametroID = System.Convert.ToInt32(cboParametroID.SelectedValue)
        End If

        If cboAnalistaID.SelectedValue Is Nothing Then
            If errores = "" Then cboAnalistaID.Focus()
            errores = errores & "No eligio un valor en Analista." & Environment.NewLine
        Else
            m_DBO_EnvasadosProductosAnalitica.AnalistaID = System.Convert.ToInt32(cboAnalistaID.SelectedValue)
        End If

        If txtValor.Text = "" Then
            If errores = "" Then txtValor.Focus()
            errores = errores & "No introdujo un valor en Valor." & Environment.NewLine
        Else
            If Not IsNumeric(txtValor.Text) Then
                If errores = "" Then txtValor.Focus()
                errores = errores & "El campo Valor debe de ser numerico." & Environment.NewLine
            Else
                m_DBO_EnvasadosProductosAnalitica.Valor = System.Convert.ToDouble(If(txtValor.Text = "", String.Empty, txtValor.Text))
            End If
        End If



        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spEnvasadosProductosAnaliticas2.GrabarEnvasadosProductosAnaliticas(m_DBO_EnvasadosProductosAnalitica, dtb) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub butVerParametroID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerParametroID.Click
        'Using frmEnt As New frmListaParametros()
        '    BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        'End Using
    End Sub

    Private Sub butAddParametroID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddParametroID.Click
        'Dim DBO_ListaParametros As New DBO_ListaParametros
        'frmEnt = New frmEntArticulosDocumentosListaParametros(DBO_ListaParametros, 1, False)
        '    frmEnt.Text = "Insertar
        '    BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        'End Using
        'Me.cboParametroID.mam_DataSource("EnvasadosProductosAnaliticas_ListaParametrosCbo", False)
    End Sub

    Private Sub butVerAnalistaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerAnalistaID.Click
        Using frmEnt As New frmEmpleados()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        End Using
    End Sub

    Private Sub dtpHora_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHora.ValueChanged
        If dtpHora.Value.ToString("hh").Length = 2 Then
            SendKeys.SendWait("{Right}")
        End If
    End Sub
End Class
