Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulosMinMax
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ArticulosMinMax As DBO_ArticulosMinMax

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spArticulosMinMax = Nothing, Optional ByRef v_dbo As DBO_ArticulosMinMax = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spArticulosMinMax, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_ArticulosMinMax = If(v_dbo Is Nothing, New DBO_ArticulosMinMax, v_dbo)
        dbo = m_DBO_ArticulosMinMax
        dtpFechaFinal.activarFoco()
        dtpFechaFinal.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(New spArticulosMinMax, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_ArticulosMinMax, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        dtpFechaFinal.activarFoco()
        dtpFechaFinal.activarFoco()
    End Sub


    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_ArticulosMinMax = New DBO_ArticulosMinMax
        Else
            Me.m_DBO_ArticulosMinMax = CType(dbo, DBO_ArticulosMinMax)
        End If

        cboArticulo.SelectedValue = m_DBO_ArticulosMinMax.ArticuloID
        txtMinimoJR.Text = m_DBO_ArticulosMinMax.MinimoJR
        txtMaximoJR.Text = m_DBO_ArticulosMinMax.MaximoJR
        txtMinimoLA.Text = m_DBO_ArticulosMinMax.MinimoLA
        txtMaximoLA.Text = m_DBO_ArticulosMinMax.MaximoLA
        txtMinimoProveedor.Text = m_DBO_ArticulosMinMax.MinimoProveedor
        txtMaximoProveedor.Text = m_DBO_ArticulosMinMax.MaximoProveedor
        dtpFechaInicio.Value = m_DBO_ArticulosMinMax.FechaInicio
        dtpFechaFinal.Value = m_DBO_ArticulosMinMax.FechaFinal
        chbVigente.Checked = m_DBO_ArticulosMinMax.Vigente
        txtObservaciones.Text = m_DBO_ArticulosMinMax.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If cboArticulo.SelectedValue Is Nothing Then
            If errores = "" Then cboArticulo.Focus()
            errores = errores & "No seleccionó un valor para ArticuloID." & Environment.NewLine()
        Else
            m_DBO_ArticulosMinMax.ArticuloID = System.Convert.ToInt32(cboArticulo.SelectedValue)
        End If
        m_DBO_ArticulosMinMax.MinimoJR = System.Convert.ToInt32(txtMinimoJR.Text)


        m_DBO_ArticulosMinMax.MaximoJR = System.Convert.ToInt32(txtMaximoJR.Text)


        m_DBO_ArticulosMinMax.MinimoLA = System.Convert.ToInt32(txtMinimoLA.Text)


        m_DBO_ArticulosMinMax.MaximoLA = System.Convert.ToInt32(txtMaximoLA.Text)


        m_DBO_ArticulosMinMax.MinimoProveedor = System.Convert.ToInt32(txtMinimoProveedor.Text)


        m_DBO_ArticulosMinMax.MaximoProveedor = System.Convert.ToInt32(txtMaximoProveedor.Text)


        m_DBO_ArticulosMinMax.FechaInicio = dtpFechaInicio.Value


        m_DBO_ArticulosMinMax.FechaFinal = dtpFechaFinal.Value


        m_DBO_ArticulosMinMax.Vigente = chbVigente.Checked

        m_DBO_ArticulosMinMax.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = CType(m_DBO_ArticulosMinMax, BasesParaCompatibilidad.DataBussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub frmEntArticulosMinMax_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim spa As New spArticulosEnvasadosHistoricos
        spa.cargar_articulos_Envasados_secundarios(Me.cboArticulo, dtb)
    End Sub
End Class
