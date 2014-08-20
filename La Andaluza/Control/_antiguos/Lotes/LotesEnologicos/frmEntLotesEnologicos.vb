Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntLotesEnologicos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private dtsLot As dtsLotes.LotesDataTable
    Private ctlLot As ctlLotes
    Private ctlTipLot As spTiposLotes
    Private ctlTipPro As spTiposProductos
    Private spTiposPRoductos As spTiposProductos
    Private spMedidas As spMedidasProductos
    Private ctlPro As spProveedores 'ctlProveedores
    Private OldLib As OldLib
    Dim spproveedores As spProveedores
    Public Sub New()

        InitializeComponent()

        dtsLot = New dtsLotes.LotesDataTable
        ctlLot = New ctlLotes
        ctlTipLot = New spTiposLotes
        spTiposPRoductos = New spTiposProductos
        ctlPro = New spProveedores
        OldLib = New OldLib
        spproveedores = New spProveedores
        ctlTipPro = New spTiposProductos
        spMedidas = New spMedidasProductos
        Me.dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntLotesEnologicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        If Me.Text.Substring(0, 3) = "Ver" Then
            ctlLot.mostrarTodosLotesEnologicos(dtsLot)
            GeneralBindingSource.DataSource = dtsLot
            GeneralBindingSource.Position = Posicion
        End If
        If Me.Text.Substring(0, 3) = "Mod" Then
            CantidadRestanteCuadroDeTexto.ReadOnly = True
        Else
            CantidadRestanteCuadroDeTexto.ReadOnly = False
        End If
        cbMedidas.Text = Medida
        VerMedidas()
    End Sub

    Public Sub CargarDatos(ByVal Pos As Integer, _
                           ByVal LoteID As Integer, _
                           ByVal Descripcion As String, _
                           ByVal Fecha As DateTime, _
                           ByVal CantidadRestante As Double, _
                           ByVal TipoLoteID As String, _
                           ByVal TipoProductoID As String, _
                           ByVal ProveedorID As String, _
                           ByVal CodigoLote As String, _
                           ByVal LoteProveedor As String)

        Posicion = Pos
        ctlLot.setLoteID(LoteID)
        DescripcionCuadroDeTexto.Text = Descripcion
        dtpFecha.Value = Fecha
        CantidadRestanteCuadroDeTexto.Text = CantidadRestante
        txtLoteProveedor.Text = LoteProveedor
        CodigoLoteCuadroDeTexto.EsUnicoID = LoteID
        CodigoLoteCuadroDeTexto.Text = CodigoLote

        Dim spTiposLotes As New spTiposLotes
        spTiposLotes.cargar_TiposLotes(TipoLoteIDComboMAM)
        'OldLib.RellenarComboBox(TipoLoteIDComboMAM, ctlTipLot.devolverTiposLotesPorDescripcion, False)
        Me.spTiposPRoductos.cargar_ComboBox_Enologicos(TipoProductoIDComboMAM)
        'OldLib.RellenarComboBox(TipoProductoIDComboMAM, ctlTipPro.devolverTiposProductosPorDescripcionEnologicos, False)


        spproveedores.cargar_Proveedores_Enologicos(ProveedorIDCombo)
        ' OldLib.RellenarComboBox(ProveedorIDCombo, ctlPro.devolverProveedoresEnlogicosPorNombre, False)
        'OldLib.RellenarComboBox(cbMedidas, ctlTipPro.DevolverMedidasProductos, False)
        spMedidas.cargar_MedidasProductos(cbMedidas)

        TipoLoteIDComboMAM.Text = TipoLoteID
        TipoProductoIDComboMAM.Text = TipoProductoID
        ProveedorIDCombo.Text = ProveedorID

    End Sub

    Overrides Sub Guardar()
        Dim strCantidadRestante As String = ""
        Try
            If cbMedidas.Text <> Medida Then
                If cbMedidas.Text = "Litros" Then
                    strCantidadRestante = Convert.ToString(If((CantidadRestanteCuadroDeTexto.Text * txtDensidad.Text) = "" Or IsDBNull((CantidadRestanteCuadroDeTexto.Text * txtDensidad.Text)), 0, (CantidadRestanteCuadroDeTexto.Text * txtDensidad.Text)))
                ElseIf cbMedidas.Text = "Kilogramos" Then
                    strCantidadRestante = Convert.ToString(If(CantidadRestanteCuadroDeTexto.Text / txtDensidad.Text = "" Or IsDBNull(CantidadRestanteCuadroDeTexto.Text / txtDensidad.Text), 0, CantidadRestanteCuadroDeTexto.Text / txtDensidad.Text))
                End If
            Else
                strCantidadRestante = CantidadRestanteCuadroDeTexto.Text
            End If

            ctlLot.GuardarLoteEnologico(DescripcionCuadroDeTexto.Text, _
                                        dtpFecha.Value, _
                                        strCantidadRestante, _
                                        TipoLoteIDComboMAM.SelectedValue, _
                                        TipoProductoIDComboMAM.SelectedValue, _
                                        ProveedorIDCombo.SelectedValue, _
                                        CodigoLoteCuadroDeTexto.Text, _
                                        txtLoteProveedor.Text)

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CodigoLoteCuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodigoLoteCuadroDeTexto.TextChanged
        If Me.Text.Substring(0, 3) <> "Ver" Then
            Dim CodigoLote As New CodigoLote
            CodigoLote.validarCodigoLote(CodigoLoteCuadroDeTexto.EsUnicoCampo, CodigoLoteCuadroDeTexto.EsUnicoCampoID, _
                                         CodigoLoteCuadroDeTexto.EsUnicoTabla, CodigoLoteCuadroDeTexto.EsUnicoID, CodigoLoteCuadroDeTexto.Text)
            'CodigoLoteCuadroDeTexto.validarCodigoLote()
        End If
    End Sub

    Dim Medida As String = ""

    Private Sub TipoProductoIDComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoProductoIDComboMAM.SelectedValueChanged
        GenerarCodigoLote()
        Try
            'Medida = ctlTipPro.DevolverMedida(TipoProductoIDComboMAM.SelectedValue)
            Medida = ctlTipPro.Select_Record(TipoProductoIDComboMAM.SelectedValue).MedidaID
            cbMedidas.SelectedValue = Medida
        Catch ex As Exception

        End Try
    End Sub

    Sub GenerarCodigoLote()
        Try
            Dim dia, mes As String
            If dtpFecha.Value.Day < 10 Then
                dia = "0" & dtpFecha.Value.Day
            Else
                dia = dtpFecha.Value.Day
            End If
            If dtpFecha.Value.Month < 10 Then
                mes = "0" & dtpFecha.Value.Month
            Else
                mes = dtpFecha.Value.Month
            End If
            CodigoLoteCuadroDeTexto.Text = dtpFecha.Value.Year & mes & dia & ctlTipPro.Select_Record(TipoProductoIDComboMAM.SelectedValue).Abreviatura & ctlTipLot.Select_Record(TipoLoteIDComboMAM.SelectedValue).Abreviatura & "1"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TipoLoteIDComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoLoteIDComboMAM.SelectedValueChanged
        GenerarCodigoLote()
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        GenerarCodigoLote()
    End Sub

    Sub VerMedidas()
        If cbMedidas.Text <> Medida Then
            lblValorTransformar.Visible = True
            txtDensidad.Visible = True
        Else
            lblValorTransformar.Visible = False
            txtDensidad.Visible = False
        End If
    End Sub

    Private Sub cbMedidas_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMedidas.SelectedValueChanged
        VerMedidas()
    End Sub




End Class
