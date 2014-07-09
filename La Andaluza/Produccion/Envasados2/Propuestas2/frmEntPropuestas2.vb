Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmEntPropuestas2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_DBO_Propuestas2 As DBO_Propuestas2
    Private m_foramtoID As Integer
    Private spPropuestas2 As New spPropuestas2

    Public Sub New(modo As String, ByRef m_formatoid As Integer)
        MyBase.New(modo)
        InitializeComponent()
        m_DBO_Propuestas2 = DBO_Propuestas2.Instance
        Me.m_foramtoID = m_formatoid
    End Sub

    Private Sub frmEntPropuestas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboPropuestaTipoMejoraID.mam_DataSource("Propuestas2_PropuestasTiposMejorasCbo", False)
        Me.cboPropuestaUrgenciaID.mam_DataSource("Propuestas2_PropuestasUrgenciasCbo", False)
        'Me.cboPersonalID.mam_DataSource("Propuestas2_PersonalCbo"), False)
        Dim spEmpleados As New spEmpleados
        spEmpleados.cargar_empleados_envasados(cboPersonalID)

        Me.cboFormatoEnvasadoID.mam_DataSource("Propuestas2_FormatosEnvasadosCbo", False)
        MyBase.ModificarBindingNavigator()
        SetValores(m_DBO_Propuestas2.PropuestaID)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Shadows Sub SetValores(ByVal m_ID As Integer)

        If m_ID > 0 Then
            m_DBO_Propuestas2 = spPropuestas2.Select_Record(m_ID)
        End If

        txtPropuestaID.Text = m_DBO_Propuestas2.PropuestaID
        txtDescripcion.Text = If(m_DBO_Propuestas2.Descripcion_IsDBNull = True, Nothing, m_DBO_Propuestas2.Descripcion)

        cboFormatoEnvasadoID.SelectedValue = Me.m_foramtoID

        If Me.ModoDeApertura = INSERCION Then
            Me.cboPropuestaTipoMejoraID.SelectedIndex = 0
            Me.cboPropuestaUrgenciaID.SelectedIndex = 0
            Me.cboPersonalID.SelectedIndex = 0
        Else
            cboPropuestaTipoMejoraID.SelectedValue = If(m_DBO_Propuestas2.PropuestaTipoMejoraID = Nothing, -1, m_DBO_Propuestas2.PropuestaTipoMejoraID)
            cboPropuestaUrgenciaID.SelectedValue = If(m_DBO_Propuestas2.PropuestaUrgenciaID = Nothing, -1, m_DBO_Propuestas2.PropuestaUrgenciaID)
            cboPersonalID.SelectedValue = If(m_DBO_Propuestas2.PersonalID = Nothing, -1, m_DBO_Propuestas2.PersonalID)
        End If
    End Sub

    Private Function GetValores() As Boolean
        Me.txtDescripcion.Focus()
        Dim errores As String = ""
        m_DBO_Propuestas2.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_Propuestas2.Descripcion_IsDBNull = If(txtDescripcion.Text = "", True, False)
        m_DBO_Propuestas2.PropuestaTipoMejoraID = System.Convert.ToInt32(cboPropuestaTipoMejoraID.SelectedValue)
        m_DBO_Propuestas2.PropuestaUrgenciaID = System.Convert.ToInt32(cboPropuestaUrgenciaID.SelectedValue)
        m_DBO_Propuestas2.PersonalID = System.Convert.ToInt32(cboPersonalID.SelectedValue)
        m_DBO_Propuestas2.FormatoEnvasadoID = System.Convert.ToInt32(cboFormatoEnvasadoID.SelectedValue)
        m_DBO_Propuestas2.FechaModificacion = System.DateTime.Now.Date
        m_DBO_Propuestas2.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If cboPropuestaTipoMejoraID.SelectedValue Is Nothing Then
            cboPropuestaTipoMejoraID.Focus()
            errores = errores & "No selecciono un valor en el campo Tipo Mejora." & Environment.NewLine
        End If
        If cboPropuestaUrgenciaID.SelectedValue Is Nothing Then
            If errores = "" Then cboPropuestaUrgenciaID.Focus()
            errores = errores & "No selecciono un valor en el campo Propuesta Urgencia." & Environment.NewLine
        End If
        If cboPersonalID.SelectedValue Is Nothing Then
            If errores = "" Then cboPersonalID.Focus()
            errores = errores & "No selecciono un valor en el campo Personal." & Environment.NewLine
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
            If spPropuestas2.GrabarPropuestas2(m_DBO_Propuestas2) Then
                Me.Close()
            End If
        End If
    End Sub
End Class
