Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmModCompuestoPorMAM
    Private m_dbo As DBO_Articulos1CompuestoPor
    Private sp As spArticulos1CompuestoPor
    Private modo_apertura As Byte
    Private frmComposicionTerciario As frmArticulos1CompuestoPorMAM
    Private frmComposicionSecundario As frmArticulos1CompuestoPorMAM
    Private frmComposicionPrimario As frmArticulos1CompuestoPorMAM
    Private spdoypack As spdoypack
    Private spMonodosis As spMonodosis

    Public Sub New(ByVal id As Integer, Optional ByVal idCompuesto As Integer = 0)
        InitializeComponent()

        sp = New spArticulos1CompuestoPor
        spdoypack = New spdoypack
        spMonodosis = New spMonodosis
        m_dbo = New DBO_Articulos1CompuestoPor
        m_dbo.ArticuloPrincipal = id

        'Me.cboArticuloSecundario.mam_DataSource(sp.CargarCombo(id), False)
        Me.cboArticuloSecundario.mam_DataSource(sp.CargarCombo1(9), False)
        Me.cboPalet.mam_DataSource(sp.CargarCombo1(32), False)
        Me.cboFilm.mam_DataSource(sp.CargarCombo1(30), False)
        Me.cboEtiquetaPalet.mam_DataSource(sp.CargarCombo1(74), False)
        Me.cboTransfer.mam_DataSource(sp.CargarCombo1(35), False)

        Me.frmComposicionTerciario = New frmArticulos1CompuestoPorMAM(id)
        Engine_LA.FormEnPestaña(frmComposicionTerciario, panAdicionalesTerciario)
        frmComposicionTerciario.Dock = DockStyle.Fill

        Me.frmComposicionSecundario = New frmArticulos1CompuestoPorMAM(id)
        Engine_LA.FormEnPestaña(frmComposicionSecundario, PanAdicionalesSecundario)
        frmComposicionSecundario.Dock = DockStyle.Fill

        Me.frmComposicionPrimario = New frmArticulos1CompuestoPorMAM(id)
        Engine_LA.FormEnPestaña(frmComposicionPrimario, panAdicionalesPrimario)
        frmComposicionPrimario.Dock = DockStyle.Fill

        If idCompuesto <> 0 Then
            Me.cboArticuloSecundario.Enabled = False
            m_dbo.ArticuloComponente = idCompuesto
        End If
    End Sub

    Private Sub frmModCompuestoPor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cboArticuloSecundario.SelectedValue = If(m_dbo.ArticuloComponente = Nothing, 0, m_dbo.ArticuloComponente)
        Me.modo_apertura = If(m_dbo.ArticuloComponente = Nothing, 1, 0)
    End Sub

    Private Function getValores() As Boolean
        Dim errores As String = ""

        If Me.modo_apertura = 1 Then
            If Me.cboArticuloSecundario.SelectedValue Is Nothing Then
                errores &= "Seleccione un articulo en el desplegable. " & Environment.NewLine
            Else
                Me.m_dbo.ArticuloComponente = Me.cboArticuloSecundario.SelectedValue
            End If
        End If

        If Not IsNumeric(Me.txtcantidad.Text) Then
            errores &= "La cantidad debe ser numérica. " & Environment.NewLine
        Else
            Me.m_dbo.Cantidad = Convert.ToDouble(Me.txtcantidad.Text)
        End If

        If errores = "" Then
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario. Se han encontrado los siguientes errores:" & Environment.NewLine & errores, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If getValores() Then

            If Me.cboArticuloSecundario.Enabled Then
                Dim formato As Integer
                If spdoypack.esDoypack(Me.m_dbo.ArticuloPrincipal) And spMonodosis.esMonodosis(Me.m_dbo.ArticuloComponente) Then
                    formato = spdoypack.FormatoPorArticulo(Me.m_dbo.ArticuloPrincipal)

                    If formato = Nothing Then
                        Dim frm As New frmDoyPackInfoExtra
                        frm.ShowDialog()
                        formato = frm.result

                        If formato = Nothing Then
                            MessageBox.Show("Debe elegir un formato para el envasado de doypack. Se cancelará el guardado.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Return
                        End If
                    End If
                End If

                If Me.sp.Insertar(Me.m_dbo.ArticuloPrincipal, Me.m_dbo.ArticuloComponente, Me.m_dbo.Cantidad, formato) Then
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If Me.sp.Actualizar(Me.m_dbo.ArticuloPrincipal, Me.m_dbo.ArticuloComponente, Me.m_dbo.Cantidad) Then
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo guardar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class