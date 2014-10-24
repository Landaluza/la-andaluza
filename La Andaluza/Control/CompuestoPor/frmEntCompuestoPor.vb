Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmEntCompuestoPor
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld
    Private m_DBO_CompuestoPor As DBO_CompuestoPor
    Private spCompuestoPor As spCompuestoPor

    Public Sub New(ByRef CompuestoPor As DBO_CompuestoPor)
        InitializeComponent()
        spCompuestoPor = New spCompuestoPor
        m_DBO_CompuestoPor = CompuestoPor
    End Sub

    Private Sub frmEntCompuestoPor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboLoteFinal.mam_DataSource("CompuestoPor_LotesCbo", False, dtb)

        Me.cboLoteFinal.Visible = False
        Me.lblLoteFinal.Visible = False

        Me.cboLotePartida.mam_DataSource("CompuestoPor_LotesCbo", False, dtb)
        Me.cboLotePartida.Visible = False
        Me.lblLotePartida.Visible = False

        Me.cboMovimientoID.mam_DataSource("CompuestoPor_MovimientosCbo", False, dtb)
        Me.cboMovimientoID.Visible = False
        Me.lblMovimientoID.Visible = False

        If Me.Text.Substring(0, 3) = "Ver" Then
            OcultarBotonGrabar(True)
        Else
            OcultarBotonGrabar(False)
        End If

        SetValores()
    End Sub

    Overrides Sub SetValores()

        cboLoteFinal.SelectedValue = If(m_DBO_CompuestoPor.LoteFinal <> Nothing, m_DBO_CompuestoPor.LoteFinal, -1)
        cboLotePartida.SelectedValue = If(m_DBO_CompuestoPor.LotePartida <> Nothing, m_DBO_CompuestoPor.LotePartida, -1)
        cboMovimientoID.SelectedValue = If(m_DBO_CompuestoPor.MovimientoID <> Nothing, m_DBO_CompuestoPor.MovimientoID, -1)
        'txtCantidad.Text = if(m_DBO_CompuestoPor.Cantidad.HasValue, m_DBO_CompuestoPor.Cantidad, Nothing)

    End Sub

    Private Sub GetValores()

        m_DBO_CompuestoPor.LoteFinal = System.Convert.ToInt32(cboLoteFinal.SelectedValue)
        m_DBO_CompuestoPor.LotePartida = System.Convert.ToInt32(cboLotePartida.SelectedValue)
        m_DBO_CompuestoPor.MovimientoID = System.Convert.ToInt32(cboMovimientoID.SelectedValue)
        m_DBO_CompuestoPor.Cantidad = System.Convert.ToDouble(If(txtCantidad.Text = "", String.Empty, txtCantidad.Text))

    End Sub

    Overrides Sub Guardar()
        GetValores()
        spCompuestoPor.GrabarCompuestoPor(m_DBO_CompuestoPor, dtb)
        Me.Close()
    End Sub

End Class
