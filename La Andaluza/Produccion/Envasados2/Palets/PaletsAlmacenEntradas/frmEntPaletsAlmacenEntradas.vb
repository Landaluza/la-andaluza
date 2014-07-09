Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPaletsAlmacenEntradas
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld
    Private m_DBO_PaletsAlmacenEntrada As DBO_PaletsAlmacenEntradas
    Private spPaletsAlmacenEntradas As spPaletsAlmacenEntradas

    Public Sub New(ByRef PaletsAlmacenEntrada As DBO_PaletsAlmacenEntradas)
        InitializeComponent()
        spPaletsAlmacenEntradas = New spPaletsAlmacenEntradas
        m_DBO_PaletsAlmacenEntrada = PaletsAlmacenEntrada
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntPaletsAlmacenEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text.Substring(0, 3) = "Ver" Then
            OcultarBotonGrabar(True)
        Else
            OcultarBotonGrabar(False)
        End If

        SetValores()
    End Sub

    Overrides Sub SetValores()

        txtPaletAlmacenEntradaID.Text = m_DBO_PaletsAlmacenEntrada.PaletAlmacenEntradaID
        txtSSCC.Text = m_DBO_PaletsAlmacenEntrada.SSCC
        dtpFecha.Text = m_DBO_PaletsAlmacenEntrada.Fecha
        txtArticulo.Text = m_DBO_PaletsAlmacenEntrada.Articulo
        txtCajas.Text = If(m_DBO_PaletsAlmacenEntrada.Cajas.HasValue, Convert.ToString(m_DBO_PaletsAlmacenEntrada.Cajas), "")
        txtComentariosCarga.Text = m_DBO_PaletsAlmacenEntrada.ComentariosCarga
        txtObservaciones.Text = m_DBO_PaletsAlmacenEntrada.Observaciones
        chbVigente.Checked = m_DBO_PaletsAlmacenEntrada.Vigente

    End Sub

    Private Sub GetValores()

        m_DBO_PaletsAlmacenEntrada.SSCC = If(txtSSCC.Text = "", String.Empty, txtSSCC.Text)
        m_DBO_PaletsAlmacenEntrada.Fecha = dtpFecha.Value.Date
        m_DBO_PaletsAlmacenEntrada.Articulo = If(txtArticulo.Text = "", String.Empty, txtArticulo.Text)
        m_DBO_PaletsAlmacenEntrada.Cajas = System.Convert.ToInt32(If(txtCajas.Text = "", Nothing, txtCajas.Text))
        m_DBO_PaletsAlmacenEntrada.ComentariosCarga = If(txtComentariosCarga.Text = "", String.Empty, txtComentariosCarga.Text)
        m_DBO_PaletsAlmacenEntrada.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_PaletsAlmacenEntrada.Vigente = System.Convert.ToBoolean(chbVigente.Checked)

    End Sub

    Overrides Sub Guardar()
        GetValores()
        spPaletsAlmacenEntradas.GrabarPaletsAlmacenEntradas(m_DBO_PaletsAlmacenEntrada)
        Me.Close()
    End Sub

End Class
