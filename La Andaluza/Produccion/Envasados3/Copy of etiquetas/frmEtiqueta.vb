

Public Class frmEtiqueta0
    Private dbo_etiquetasPalet As DBO_EtiquetasPalets
    'Private Const CODIGO_EMPRESA As String = "08411831"
    'Private LONGITUD_BARCODE_2 As Integer = 18
    Private edicion As Boolean
    Private barCode As CodigoBarra
    Private EtiquetadoraPalets As Etiquetador
    Private Const PREFIJO_MATRICULA As String = "08411831"
    Private barc As BarcodeLib.Barcode
    Private loteador As Loteado
    Private dtb As BasesParaCompatibilidad.DataBase
    Private Con_Control As Boolean

    Public Sub New(ByVal paletId As Integer, ByVal edicion As Boolean, ByVal control As Boolean)

        InitializeComponent()

        Con_Control = control
        dtb = New BasesParaCompatibilidad.DataBase
        barc = New BarcodeLib.Barcode
        Me.EtiquetadoraPalets = New Etiquetador
        Me.loteador = New Loteado
        Me.edicion = edicion
        Me.barCode = New CodigoBarra
        dbo_etiquetasPalet = New DBO_EtiquetasPalets
        dbo_etiquetasPalet.PaletID = paletId
        setValores()
        If Not edicion Then panBotones.Visible = False
    End Sub


    Private Sub setValores()
        Dim sp As New spEtiquetasPalets
        Me.EtiquetadoraPalets.setup()

        Try
            If Me.dbo_etiquetasPalet.PaletID = 0 Then
                Return
            End If
            Me.dbo_etiquetasPalet = sp.Select_Record(Me.dbo_etiquetasPalet.PaletID, dtb)
        Catch ex As Exception
        End Try

        If Not dbo_etiquetasPalet Is Nothing Then

            Me.lMarca.Text = Me.dbo_etiquetasPalet.Marca
            Me.lProducto.Text = Me.dbo_etiquetasPalet.Producto
            Me.lCajasBotellas.Text = Me.dbo_etiquetasPalet.Botellas
            Me.lPalet.Text = Me.dbo_etiquetasPalet.Palet
            Me.lnCajas.Text = Me.dbo_etiquetasPalet.Cajas
            Me.lnBotellas.Text = Me.dbo_etiquetasPalet.Cantidad_botellas
            Me.lean13.Text = Me.dbo_etiquetasPalet.EAN13
            Me.lean14.Text = Me.dbo_etiquetasPalet.EAN14

            If Me.dbo_etiquetasPalet.Tipo_Loteado = Loteado.STANDAR Then
                Me.llote.Text = loteador.Loteado_standar(Me.dbo_etiquetasPalet.Lote)
            Else
                Me.llote.Text = loteador.Loteado_cubos(Convert.ToDateTime(Me.dbo_etiquetasPalet.Lote).AddYears(dbo_etiquetasPalet.Anos_caducidad))
            End If

            If Con_Control Then
                Me.lscc.Text = Me.barCode.ajustarSCC_Con_Digito_Control(Me.dbo_etiquetasPalet.SCC, Me.dbo_etiquetasPalet.EAN13)
            Else
                Me.lscc.Text = Me.barCode.ajustarSCC(Me.dbo_etiquetasPalet.SCC, Me.dbo_etiquetasPalet.EAN13)
            End If

            Me.dbo_etiquetasPalet.SCC = Me.lscc.Text


            If dbo_etiquetasPalet.Cabecera = "" Then
                Me.panCabecera.Visible = False
            Else
                Me.txtCabecera.Text = dbo_etiquetasPalet.Cabecera
            End If

            If dbo_etiquetasPalet.Anos_caducidad = "" Then
                ltCaducidad.Visible = False
            Else
                lCaducidad.Text = Convert.ToDateTime(Me.dbo_etiquetasPalet.Lote).AddYears(dbo_etiquetasPalet.Anos_caducidad).ToString("yyMMdd")
                ltCaducidad.Text = ltCaducidad.Text & "  " & Convert.ToDateTime(Me.dbo_etiquetasPalet.Lote).AddYears(dbo_etiquetasPalet.Anos_caducidad).ToString("yyMMdd")
            End If

            If Me.dbo_etiquetasPalet.Tipo_palet = 94 Then
                Me.Barcode1.Visible = False

            Else

                

                If Me.dbo_etiquetasPalet.EAN13 = "" And Me.dbo_etiquetasPalet.EAN14 = "" Then
                    Me.Barcode1.Visible = False
                Else
                    If Me.dbo_etiquetasPalet.EAN13 = "" Then
                        'Me.BarCodes1D1.Visible = False
                        Me.Barcode1.Visible = False                        'calcular_codigoBarras2()
                    End If

                    If Me.dbo_etiquetasPalet.EAN14 = "" Then
                        'Me.BarCodes1D2.Visible = False
                        Me.Barcode2.Visible = False
                    End If
                End If
            End If


        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnImprimir.Click
        'lean14_TextChanged(Nothing, Nothing)
        Me.panBotones.Visible = False
        Try
            Dim scc As String = Me.lscc.Text
            Dim pc As String = My.Computer.Name
            Dim usuario As String = Environment.UserName
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim ip As String = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()

            dtb.ConsultaAlteraciones("insert into tempInfo(scc, pc, ip, usuario) values('" & scc & "', '" & pc & "', '" & ip & "', '" & usuario & "')")
            

        Catch ex As Exception

        End Try
        EtiquetadoraPalets.printPanel(Me.Panel1)
        EtiquetadoraPalets.printPanel(Me.Panel1)
        ' Me.panBotones.Visible = False
    End Sub

    'Public Function check_code() As Boolean
    '    'Dim ctrl As New BarCodes.EAN13Encoder()
    '    ' revisar las opciones de usar el control apra generar el ean 14
    '    Return True
    'End Function

    Public Sub calcular_codigoBarras1()
        'Dim texto As String = Me.barCode.calcular_codigo_barras_1(Me.lean14.Text, llote.Text)  '"(01)" & Me.lean14.Text & "(10)" & llote.Text
        Dim gs As GS1 = Me.barCode.calcular_codigo_barras_1(Me.lean14.Text, llote.Text)
        Dim texto As String = gs.Empresa
        
        Dim temp As New Bitmap(1, 1)
        temp.SetPixel(0, 0, Me.BackColor)
        Barcode1.Image = temp

        barc.Alignment = BarcodeLib.AlignmentPositions.LEFT
        barc.IncludeLabel = True
        barc.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT        
        '        Barcode1.Image = barc.Encode(BarcodeLib.TYPE.CODE128, texto, Color.Black, Color.White, 350, 120)
        Barcode1.Image = barc.Encode(BarcodeLib.TYPE.SSCC, texto, Color.Black, Color.White, 600, 160)



        Barcode1.Width = 350 'Barcode1.Image.Width
        Barcode1.Height = Barcode1.Image.Height
    End Sub

    Public Sub calcular_codigoBarras1_c()
        'Dim texto As String = Me.barCode.calcular_codigo_barras_1(Me.lean14.Text, llote.Text)  '"(01)" & Me.lean14.Text & "(10)" & llote.Text
        Dim gs As GS1 = Me.barCode.calcular_codigo_barras_1(Me.lean14.Text, llote.Text)
        Dim texto As String = gs.Empresa_DOBLE_CODIFICACION

        Dim temp As New Bitmap(1, 1)
        temp.SetPixel(0, 0, Me.BackColor)
        Barcode1.Image = temp

        barc.Alignment = BarcodeLib.AlignmentPositions.LEFT
        barc.IncludeLabel = True
        barc.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT
        '        Barcode1.Image = barc.Encode(BarcodeLib.TYPE.CODE128, texto, Color.Black, Color.White, 350, 120)
        Barcode1.Image = barc.Encode(BarcodeLib.TYPE.LOTE, texto, Color.Black, Color.White, 700, 160)



        Barcode1.Width = 350 'Barcode1.Image.Width
        Barcode1.Height = Barcode1.Image.Height
    End Sub

    Public Sub calcular_codigoBarras2()
        Dim gs As GS1 = Me.barCode.calcular_codigoBarras2(lscc.Text, Me.lCaducidad.Text)
        Dim texto As String = gs.SSCC


        Dim temp As New Bitmap(1, 1)
        temp.SetPixel(0, 0, Me.BackColor)
        Barcode2.Image = temp

        barc.Alignment = BarcodeLib.AlignmentPositions.LEFT
        barc.IncludeLabel = True
        barc.LabelPosition = BarcodeLib.LabelPositions.BOTTOMLEFT
        '        Barcode2.Image = barc.Encode(BarcodeLib.TYPE.CODE128, texto, Color.Black, Color.White, Me.Width - 20, 120)
        Barcode2.Image = barc.Encode(BarcodeLib.TYPE.SSCC, texto, Color.Black, Color.White, 650, 200)

        Barcode2.Width = Barcode2.Image.Width
        Barcode2.Height = Barcode2.Image.Height
    End Sub

    Private Sub butCalculateCod_Click(sender As System.Object, e As System.EventArgs) Handles butCalculateCod.Click
        If Me.Barcode1.Visible Then calcular_codigoBarras1()
        If Me.Barcode2.Visible Then calcular_codigoBarras2()
    End Sub

    Private Sub lean14_TextChanged(sender As System.Object, e As System.EventArgs) Handles lean14.TextChanged
        Try
            If Me.Visible Then
                If Me.Barcode1.Visible Then calcular_codigoBarras1_c()
                If Me.Barcode2.Visible Then calcular_codigoBarras2()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmEtiqueta_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        lean14_TextChanged(Nothing, Nothing)

        If Not Me.edicion Then
            Me.Cursor = Cursors.WaitCursor
            Me.Timer1.Enabled = True
            Me.Timer1.Start()
        End If
    End Sub



    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Timer1.Enabled = False
        Button1_Click(Nothing, Nothing)
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

 
    Private Sub btExp_Click(sender As Object, e As EventArgs) Handles btExp.Click
        If panBotones.Width = 182 Then
            panBotones.Width = 14
        Else
            panBotones.Width = 182
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.Barcode1.Visible Then calcular_codigoBarras1_c()
        If Me.Barcode2.Visible Then calcular_codigoBarras2()
    End Sub
End Class