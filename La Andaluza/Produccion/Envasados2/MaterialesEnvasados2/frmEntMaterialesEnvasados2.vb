Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntMaterialesEnvasados2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_MaterialesEnvasados2 As DBO_MaterialesEnvasados2
    Private m_VerID As Boolean = False
    Private FormatoId As Integer
    Private linea As Integer
    Private spMaterialesEnvasados2 As spMaterialesEnvasados2
    Private spFormatosEnvasados2 As spFormatosEnvasados2

    Public Sub New(formatoId As Integer, modo As String, ByRef MaterialesEnvasados2 As DBO_MaterialesEnvasados2, ByVal linea As Integer, ByVal Pos As Integer, ByVal VerID As Boolean)
        MyBase.New(modo)
        spFormatosEnvasados2 = New spFormatosEnvasados2
        spMaterialesEnvasados2 = New spMaterialesEnvasados2
        InitializeComponent()
        m_DBO_MaterialesEnvasados2 = MaterialesEnvasados2
        m_Pos = Pos
        m_VerID = VerID
        Me.linea = linea
        Me.FormatoId = formatoId
        dtpHoraInicio.activarFoco()
        dtpHoraFin.activarFoco()
    End Sub

    Private Sub frmEntMaterialesEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboTipoMaterialID.mam_DataSource("MaterialesEnvasados2_TiposMaterialesCbo", False)
        If Not m_VerID Then
            Me.cboTipoMaterialID.Visible = False
            Me.lblTipoMaterialID.Visible = False
            Me.cboProveedorID.Visible = False
            Me.lblProveedorID.Visible = False
            Me.cboFormatoEnvasadoID.Visible = False
            Me.lblFormatoEnvasadoID.Visible = False
        End If
        Me.cboProveedorID.mam_DataSource("MaterialesEnvasados2_ProveedoresCbo", False)

        Me.cboFormatoEnvasadoID.mam_DataSource("MaterialesEnvasados2_FormatosEnvasadosCbo", False)


        SetValores(m_DBO_MaterialesEnvasados2.MaterialEnvasadoID)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Shadows Sub SetValores(ByVal m_ID As Integer)
        If m_ID > 0 Then m_DBO_MaterialesEnvasados2 = spMaterialesEnvasados2.Select_Record(m_ID)

        txtMaterialEnvasadoID.Text = m_DBO_MaterialesEnvasados2.MaterialEnvasadoID
        txtObservaciones.Text = If(m_DBO_MaterialesEnvasados2.Observaciones_IsDBNull = True, "", m_DBO_MaterialesEnvasados2.Observaciones)
        txtLote.Text = If(m_DBO_MaterialesEnvasados2.Lote_IsDBNull = True, "", m_DBO_MaterialesEnvasados2.Lote)
        txtCantidad.Text = If(m_DBO_MaterialesEnvasados2.Cantidad_IsDBNull = True, "0", m_DBO_MaterialesEnvasados2.Cantidad.ToString)
        cboTipoMaterialID.SelectedValue = If(m_DBO_MaterialesEnvasados2.TipoMaterialID = Nothing, -1, m_DBO_MaterialesEnvasados2.TipoMaterialID)
        cboProveedorID.SelectedValue = If(m_DBO_MaterialesEnvasados2.ProveedorID = Nothing, -1, m_DBO_MaterialesEnvasados2.ProveedorID)

        If Me.ModoDeApertura = INSERCION Then
            'Dim m_aux As DBO_FormatosEnvasados2 = DBO_FormatosEnvasados2.Instance
            cboFormatoEnvasadoID.SelectedValue = Me.FormatoId

            dtpHoraFin.Value = DateTime.Now.Date.Add(spFormatosEnvasados2.GetUltimaHoraFinPaletProducido(Me.FormatoId))
            'dtpHoraInicio.Value = dtpHoraFin.Value.AddMinutes(-15)
            dtpHoraInicio.Value = DateTime.Now.Date.Add(spFormatosEnvasados2.GetPrimeraHoraInicioPaletProducido(Me.FormatoId))

            'If dtpHoraFin.Value.Day <> Now().Date.Day Then
            '    dtpHoraFin.Value = New DateTime(Now().Date.Year, Now().Date.Month, Now().Date.Day, 0, 0, 0)
            'End If

            'If dtpHoraInicio.Value.Day <> dtpHoraFin.Value.Day Then
            '    dtpHoraInicio.Value = New DateTime(dtpHoraFin.Value.Year, dtpHoraFin.Value.Month, dtpHoraFin.Value.Day, dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, dtpHoraInicio.Value.Second)
            'End If

            cboTipoMaterialID.SelectedIndex = 0
            cboProveedorID.SelectedIndex = 0
        Else
            dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_MaterialesEnvasados2.HoraInicio)
            dtpHoraFin.Value = DateTime.Now.Date.Add(m_DBO_MaterialesEnvasados2.HoraFin)
            cboTipoMaterialID.SelectedValue = If(m_DBO_MaterialesEnvasados2.TipoMaterialID = Nothing, -1, m_DBO_MaterialesEnvasados2.TipoMaterialID)
            cboProveedorID.SelectedValue = If(m_DBO_MaterialesEnvasados2.ProveedorID = Nothing, -1, m_DBO_MaterialesEnvasados2.ProveedorID)
            cboFormatoEnvasadoID.SelectedValue = If(m_DBO_MaterialesEnvasados2.FormatoEnvasadoID = Nothing, -1, m_DBO_MaterialesEnvasados2.FormatoEnvasadoID)
        End If
    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservaciones.Focus()
        Me.txtObservaciones.Focus()

        Dim errores As String = ""
        m_DBO_MaterialesEnvasados2.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_MaterialesEnvasados2.HoraInicio_IsDBNull = If(dtpHoraInicio.Text = "", True, False)
        m_DBO_MaterialesEnvasados2.HoraFin = New TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)
        m_DBO_MaterialesEnvasados2.HoraFin_IsDBNull = If(dtpHoraFin.Text = "", True, False)
        m_DBO_MaterialesEnvasados2.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_MaterialesEnvasados2.Observaciones_IsDBNull = If(txtObservaciones.Text = "", True, False)

        m_DBO_MaterialesEnvasados2.TipoMaterialID = System.Convert.ToInt32(cboTipoMaterialID.SelectedValue)
        m_DBO_MaterialesEnvasados2.ProveedorID = System.Convert.ToInt32(cboProveedorID.SelectedValue)
        m_DBO_MaterialesEnvasados2.FormatoEnvasadoID = System.Convert.ToInt32(cboFormatoEnvasadoID.SelectedValue)
        m_DBO_MaterialesEnvasados2.FechaModificacion = System.DateTime.Now.Date
        m_DBO_MaterialesEnvasados2.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If dtpHoraInicio.Value >= dtpHoraFin.Value Then
            dtpHoraFin.Focus()
            errores = errores & "La hora de fin no puede ser menor o igual a la de inicio." & Environment.NewLine
        End If
        If cboTipoMaterialID.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoMaterialID.Focus()
            errores = errores & "No selecciono un valor en el campo Material." & Environment.NewLine
        End If
        If txtLote.Text = "" Then
            If errores = "" Then txtLote.Focus()
            errores = errores & "No ha introducido un valor para el campo lote." & Environment.NewLine
        Else
            m_DBO_MaterialesEnvasados2.Lote = If(txtLote.Text = "", String.Empty, txtLote.Text)
            m_DBO_MaterialesEnvasados2.Lote_IsDBNull = If(txtLote.Text = "", True, False)
        End If
        If Not IsNumeric(txtCantidad.Text) Then
            If errores = "" Then txtCantidad.Focus()
            errores = errores & "La cantidad debe ser numerica." & Environment.NewLine
        Else
            m_DBO_MaterialesEnvasados2.Cantidad = System.Convert.ToInt32(If(txtCantidad.Text = "", String.Empty, txtCantidad.Text.Replace(".", "")))

            m_DBO_MaterialesEnvasados2.Cantidad_IsDBNull = If(txtCantidad.Text = "", True, False)
        End If
        If cboProveedorID.SelectedValue Is Nothing Then
            If errores = "" Then cboProveedorID.Focus()
            errores = errores & "No selecciono un valor en el campo Proveedor." & Environment.NewLine
        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spMaterialesEnvasados2.GrabarMaterialesEnvasados2(m_DBO_MaterialesEnvasados2) Then
                Me.Close()
            End If
        End If
    End Sub

    'Private Sub dtpHoraInicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHoraInicio.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    'Private Sub dtpHoraFin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHoraFin.ValueChanged
    '    If dtpHoraFin.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    Private Sub cboTipoMaterialID_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoMaterialID.SelectedValueChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim spAux As New spProveedores
            spAux.cargar_Proveedores_Por_Tipo_Material(Me.cboProveedorID, Me.cboTipoMaterialID.SelectedValue)
            Me.cboProveedorID.SelectedValue = spMaterialesEnvasados2.selectProveedorMasUsado(Me.cboTipoMaterialID.SelectedValue, Me.linea)
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
