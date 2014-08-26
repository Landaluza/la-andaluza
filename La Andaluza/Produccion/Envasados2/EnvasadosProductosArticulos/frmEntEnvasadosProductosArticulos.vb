Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEntEnvasadosProductosArticulos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_DBO_EnvasadosProductosArticulo As DBO_EnvasadosProductosArticulos
    Private m_DBO_lote As DBO_Lotes1
    Private m_Producto As Integer
    Private m_CantidadEnvasada As Integer
    Private m_TotalCantidadAsignada As Integer
    Private m_TotalCantidadRestante As Integer
    Private m_CantidadLote As Integer
    Private m_CodigoLote As String
    Private m_LoteID As Integer
    Private m_Articulo As String
    Private spLotes1 As spLotes1
    Private spEnvasadosProductosArticulos As spEnvasadosProductosArticulos

    Public Sub New(modo As String, ByRef EnvasadosProductosArticulo As DBO_EnvasadosProductosArticulos)
        MyBase.New(modo)
        spEnvasadosProductosArticulos = New spEnvasadosProductosArticulos
        InitializeComponent()
        m_DBO_EnvasadosProductosArticulo = EnvasadosProductosArticulo
        spLotes1 = New spLotes1
    End Sub

    Public Sub New(modo As String, ByRef EnvasadosProductosArticulo As DBO_EnvasadosProductosArticulos, Producto As Integer, CantidadEnvasada As Integer, TotalCantidadAsignada As Integer)
        Me.New(modo, EnvasadosProductosArticulo)
        spEnvasadosProductosArticulos = New spEnvasadosProductosArticulos
        m_Producto = Producto
        m_CantidadEnvasada = CantidadEnvasada
        m_TotalCantidadAsignada = TotalCantidadAsignada
    End Sub

    Private Sub frmEntEnvasadosProductosArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCantidadAsiganadaPrevia.Text = m_TotalCantidadAsignada
        OcultarBotonSinRegistros()
        SetValores()

        Dim tsVer As ToolStripButton
        tsVer = Me.bdnGeneral.Items.Add("Mostrar lote terminado")
        tsVer.DisplayStyle = ToolStripItemDisplayStyle.Image
        tsVer.TextDirection = ToolStripTextDirection.Horizontal
        tsVer.TextAlign = ContentAlignment.MiddleRight
        tsVer.Image = My.Resources.view_16
        AddHandler tsVer.Click, AddressOf butVerLoteTerminadoID_Click
        Me.butVerLoteTerminadoID.Visible = False

        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Overrides Sub SetValores()

        With dgvLotes
            .DataSource = spLotes1.DgvFillLotesTerminadosPorTipoProductoYLote(m_Producto, If(Me.ModoDeApertura = MODIFICACION, m_DBO_EnvasadosProductosArticulo.LoteTerminadoID, 0))

            .Columns("LoteID").Visible = False
            .FormatoColumna("CodigoLote", "Lote", BasesParaCompatibilidad.TiposColumna.Lote, 100)
            .FormatoColumna("Codigo", "Deposito", BasesParaCompatibilidad.TiposColumna.Lote, 50)
            .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta)
            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            .FormatoColumna("Observacion", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
            .FormatoColumna("Inicial", BasesParaCompatibilidad.TiposColumna.Miles)
            .FormatoColumna("Usada", BasesParaCompatibilidad.TiposColumna.Miles)
            .FormatoColumna("Actual", BasesParaCompatibilidad.TiposColumna.Miles)
            .FormatoGeneral()
        End With

        txtCantidadAsignada.Text = 0

        If dgvLotes.RowCount > 0 Then
            dgvLotes.CurrentCell = dgvLotes.Rows(0).Cells("CodigoLote")
            dgvLotes.Rows(0).Selected = True
        End If

        txtEnvasadoProductoArticuloID.Text = m_DBO_EnvasadosProductosArticulo.EnvasadoProductoArticuloID
        txtFormatoEnvasadoID.Text = If(m_DBO_EnvasadosProductosArticulo.FormatoEnvasadoID.HasValue, Convert.ToString(m_DBO_EnvasadosProductosArticulo.FormatoEnvasadoID), "")
        txtObservaciones.Text = m_DBO_EnvasadosProductosArticulo.Observaciones
    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservaciones.Focus()
        Dim errores As String = ""
        Dim topeRestante As Integer
        Dim auxAsignada As Integer
        Dim auxCantidadLote As Integer

        m_DBO_EnvasadosProductosArticulo.FormatoEnvasadoID = System.Convert.ToInt32(If(txtFormatoEnvasadoID.Text = "", Nothing, txtFormatoEnvasadoID.Text))
        m_DBO_EnvasadosProductosArticulo.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        auxAsignada = System.Convert.ToInt32(If(txtCantidadAsignada.Text = "", Nothing, txtCantidadAsignada.Text.Replace(".", "")))
        auxCantidadLote = Convert.ToInt32(If(txtCantidadLote.Text = "", Nothing, txtCantidadLote.Text.Replace(".", "")))

        If Not IsNumeric(auxAsignada) Then
            errores &= "La cantidad asignada debe ser un valor numerico" & Environment.NewLine
        Else

            topeRestante = If(Me.txtCantidadRestante.Text = "", 0, Convert.ToInt32(Me.txtCantidadRestante.Text))

            If auxCantidadLote >= auxAsignada Then
                If topeRestante < auxAsignada Then
                    errores &= "La cantidad asignada es mayor que la restante" & Environment.NewLine
                Else
                    m_DBO_EnvasadosProductosArticulo.CantidadAsignada = auxAsignada
                End If
            Else
                If Not Me.cbMermaPositiva.Checked Then
                    Dim Respuesta As DialogResult
                    Respuesta = MessageBox.Show(" La cantidad asignada es mayor que la del lote. ¿Aplicamos una merma positiva?", _
                                       "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If Respuesta = DialogResult.Yes Then
                        Me.cbMermaPositiva.Checked = True
                        m_DBO_EnvasadosProductosArticulo.CantidadAsignada = auxAsignada
                    Else
                        errores &= "La cantidad asignada es mayor que la del lote." & Environment.NewLine
                    End If
                Else
                    m_DBO_EnvasadosProductosArticulo.CantidadAsignada = auxAsignada
                End If
            End If
        End If

        If Not (Me.cbMerma.Checked Or Me.cbMermaPositiva.Checked) Then
            m_DBO_EnvasadosProductosArticulo.Merma = Nothing
        Else
            If Me.cbMermaPositiva.Checked Then
                If auxCantidadLote >= auxAsignada Then
                    errores &= "No se produce merma positiva" & Environment.NewLine
                End If
            End If

            If Me.cbMerma.Checked Then
                If auxCantidadLote <= auxAsignada Then
                    errores &= "No se produce merma" & Environment.NewLine
                End If
            End If
        End If

        If dgvLotes.RowCount = 0 Then
            errores &= "No existen lotes terminados"
        Else
            m_DBO_EnvasadosProductosArticulo.LoteTerminadoID = System.Convert.ToInt32(dgvLotes.CurrentRow.Cells("LoteID").Value)
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
            Try
                If spEnvasadosProductosArticulos.GrabarEnvasadosProductosArticulos(m_DBO_EnvasadosProductosArticulo) Then Me.Close()
            Catch ex As Exception
                MessageBox.Show("Error al guardar el registro. Detalles" & Environment.NewLine & Environment.NewLine & ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub butVerLoteTerminadoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerLoteTerminadoID.Click

    End Sub

    Private Sub calcularDatosLote()
        m_CodigoLote = dgvLotes.CurrentRow.Cells("CodigoLote").Value
        m_CantidadLote = dgvLotes.CurrentRow.Cells("Actual").Value
        m_LoteID = dgvLotes.CurrentRow.Cells("LoteId").Value

        'En el caso de crema balsamica hay que tener en cuenta la densidad.
        'El dato de envasado se da en kilos
        'El lote tiene la cantidad en litros
        'Hay que dividir los kilos envasados entre la densidad del lote para tener los litros envasados.
        'Parametros estan en la tabla ListaParametros
        'Densidad ParametroID = 5

        Dim m_Densidad As Double

        If m_CodigoLote.Substring(8, 3) = "Crb" Then
            m_Densidad = spLotes1.calcularDensidad(m_LoteID)

            If m_Densidad = 0 Then
                MessageBox.Show("Densidad no analizada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                m_CantidadEnvasada = m_CantidadEnvasada / m_Densidad
            End If

            lblLitros.Visible = True
            txtDensidad.Visible = True
            txtDensidad.Text = m_Densidad.ToString
        End If

        txtCantidadEnvasada.Text = m_CantidadEnvasada
        txtCantidadLote.Text = m_CantidadLote
        m_TotalCantidadRestante = m_CantidadEnvasada - m_TotalCantidadAsignada

        If m_TotalCantidadRestante <= m_CantidadLote Then
            txtCantidadAsignada.Text = m_TotalCantidadRestante
        Else
            txtCantidadAsignada.Text = m_CantidadLote
        End If

        m_TotalCantidadRestante = m_CantidadEnvasada - m_TotalCantidadAsignada
        txtCantidadRestante.Text = m_TotalCantidadRestante
        txtCantidadResta.Text = m_TotalCantidadRestante - txtCantidadAsignada.Text

        If m_CodigoLote.Substring(8, 3) = "Crb" And txtCantidadResta.Text = 0 Then
            gpbMermas.Visible = True
            txtCantidadMermas.Text = m_CantidadLote - txtCantidadAsignada.Text
            txtPorcentajeMermas.Text = (100 * (m_CantidadLote - txtCantidadAsignada.Text) / m_CantidadEnvasada)
        End If

        txtCantidadRestaLote.Text = m_CantidadLote - txtCantidadAsignada.Text
    End Sub



    Private Sub dgvLotes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvLotes.SelectionChanged
        calcularDatosLote()
    End Sub

    Private Sub calcularMermas()
        Try
            Dim m_CantidadInicial As Integer = 0
            Dim m_CantidadEnvasadaAnterior As Integer = 0
            Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
            dtb.PrepararConsulta("CompuestoPorSelectByLoteFinal @lote")
            dtb.AñadirParametroConsulta("@lote", m_LoteID)
            m_CantidadInicial = dtb.Consultar().Rows(0).Item(0)
            'm_CantidadInicial = dtb.Consultar("exec CompuestoPorSelectByLoteFinal " & m_LoteID).Rows(0).Item(0)

            m_CantidadEnvasadaAnterior = dgvLotes.CurrentRow.Cells("Usada").Value

            txtCantidadEnvasadaAnterior.Text = m_CantidadEnvasadaAnterior
            txtCantidadPreparada.Text = m_CantidadInicial
            txtCantidadEnvasadaTotal.Text = m_CantidadEnvasadaAnterior + txtCantidadAsignada.Text

            txtCantidadMermas.Text = m_CantidadInicial - txtCantidadEnvasadaTotal.Text
            If txtCantidadMermas.Text = 0 Then
                txtPorcentajeMermas.Text = 0
            Else
                txtPorcentajeMermas.Text = Format(100 * (m_CantidadInicial / txtCantidadMermas.Text), "0#.#0")
            End If

            If txtCantidadRestaLote.Text < 0 Then
                Me.txtCantidadMermas.Text = txtCantidadRestaLote.Text
                Me.txtPorcentajeMermas.Text = txtCantidadMermas.Text / txtCantidadPreparada.Text
            End If

            Me.m_DBO_EnvasadosProductosArticulo.Merma = Me.txtCantidadMermas.Text
        Catch ex As Exception
            txtCantidadMermas.Text = 0
        End Try
    End Sub

    Private Sub frmEntEnvasadosProductosArticulos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        calcularDatosLote()
    End Sub

    Private Sub cbMerma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMerma.CheckedChanged
        Me.gpbMermas.Visible = Me.cbMerma.Checked
        If Me.cbMerma.Checked Then
            Me.cbMermaPositiva.Checked = Not Me.cbMerma.Checked
            calcularMermas()
        End If

    End Sub

    Private Sub cbMermaPositiva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMermaPositiva.CheckedChanged
        Me.gpbMermas.Visible = Me.cbMermaPositiva.Checked
        If Me.cbMermaPositiva.Checked Then
            Me.cbMerma.Checked = Not Me.cbMermaPositiva.Checked
            calcularMermas()
        End If
    End Sub

    Private Sub txtCantidadAsignada_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCantidadAsignada.TextChanged
        Try
            m_TotalCantidadRestante = m_CantidadEnvasada - m_TotalCantidadAsignada
            txtCantidadRestante.Text = m_TotalCantidadRestante
            txtCantidadResta.Text = m_TotalCantidadRestante - txtCantidadAsignada.Text
            txtCantidadRestaLote.Text = m_CantidadLote - txtCantidadAsignada.Text

            If m_CodigoLote.Substring(8, 3) = "Crb" And txtCantidadResta.Text = 0 Then
                txtCantidadMermas.Text = m_CantidadLote - txtCantidadAsignada.Text
                txtPorcentajeMermas.Text = (100 * (m_CantidadLote - txtCantidadAsignada.Text) / m_CantidadEnvasada)
            End If

            calcularMermas()
        Catch ex As Exception
        End Try
    End Sub
End Class
