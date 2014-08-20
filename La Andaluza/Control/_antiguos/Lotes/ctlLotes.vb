Public Class ctlLotes
    Private clsLot As New clsLotes
    Private clsEsp As New clsValoresespecificaciones
    Private clsAnaVal As New clsAnaliticasValores
    Private clsAnaReq As New clsAnaliticasRequerimientos
    Private clsObs As New clsObservaciones
    Private clsMueObs As New clsMuestrasObservaciones
    Private clsAna As New clsAnaliticas
    Private clsAnaExt As New clsAnaliticasExternas

    Public Sub New()
        clsLot = New clsLotes
        clsEsp = New clsValoresespecificaciones
        clsAnaVal = New clsAnaliticasValores
        clsAnaReq = New clsAnaliticasRequerimientos
        clsObs = New clsObservaciones
        clsMueObs = New clsMuestrasObservaciones
        clsAna = New clsAnaliticas
        clsAnaExt = New clsAnaliticasExternas
    End Sub

    Public Function CantidadDeMaceraciones() As Integer
        Return clsLot.CantidadDeMaceraciones()
    End Function

    Public Function DevolverMuestrasAnaliticas() As DataTable
        Return clsLot.DevolverMuestrasAnaliticas()
    End Function

    Public Sub setLoteID(ByVal LoteID As Integer)
        clsLot._LoteID = LoteID
    End Sub

    '---------------------------------------------------ENOLOGICOS-----------------------------------------------------------
    Public Function devolverLotesEnologicos() As DataTable
        Return clsLot.DevolverEnologicos()
    End Function

    Public Sub mostrarTodosLotesEnologicos(ByRef dts As dtsLotes.LotesDataTable)
        Dim tabla As New DataTable
        tabla = clsLot.DevolverEnologicos()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsLotes.LotesRow
        While i < tabla.Rows.Count
            reg = dts.NewLotesRow
            reg.LoteID = tabla.Rows(i).Item("LoteID")
            If IsDBNull(tabla.Rows(i).Item("Descripcion")) Then
                reg.Descripcion = ""
            Else
                reg.Descripcion = tabla.Rows(i).Item("Descripcion")
            End If

            reg.Fecha = tabla.Rows(i).Item("Fecha")
            reg.Fecha = reg.Fecha.Date
            reg.CantidadRestante = tabla.Rows(i).Item("CantidadRestante")
            If IsDBNull(tabla.Rows(i).Item("TiposLote")) Then
                reg.TipoLote = 0
            Else
                reg.TipoLote = tabla.Rows(i).Item("TiposLote")
            End If
            If IsDBNull(tabla.Rows(i).Item("TiposProductos")) Then
                reg.TipoProducto = 0
            Else
                reg.TipoProducto = tabla.Rows(i).Item("TiposProductos")
            End If
            If IsDBNull(tabla.Rows(i).Item("Nombre")) Then
                reg.Proveedor = 0
            Else
                reg.Proveedor = tabla.Rows(i).Item("Nombre")
            End If

            reg.CodigoLote = tabla.Rows(i).Item("CodigoLote")

            If IsDBNull(tabla.Rows(i).Item("LoteProveedor")) Then
                reg.LoteProveedor = ""
            Else
                reg.LoteProveedor = tabla.Rows(i).Item("LoteProveedor")
            End If
            dts.AddLotesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub GuardarLoteEnologico(ByVal Descripcion As String, _
                                    ByVal Fecha As DateTime, _
                                    ByVal CantidadRestante As Double, _
                                    ByVal TipoLoteID As Integer, _
                                    ByVal TipoProductoID As Integer, _
                                    ByVal ProveedorID As Integer, _
                                    ByVal CodigoLote As String, _
                                    ByVal LoteProveedor As String)

        clsLot.Limpiar()
        clsLot._Descripcion = Descripcion
        clsLot._Fecha = Fecha
        clsLot._CantidadRestante = CantidadRestante
        clsLot._TipoLoteID = TipoLoteID
        clsLot._TipoProductoID = TipoProductoID
        clsLot._ProveedorID = ProveedorID
        clsLot._CodigoLote = CodigoLote
        clsLot._LoteProveedor = LoteProveedor
        If clsLot._LoteID = 0 Then
            clsLot.Insertar()
        Else
            clsLot.ModificarLoteEnologico()
        End If
    End Sub


    '---------------------------------------------------MOVIMIENTOS----------------------------------------------------------

    Public Function devolverReferencia() As Integer
        clsLot.devolverReferencia()
        Return clsLot._Referencia
    End Function

    Public Sub mostrarLotesComponentes(ByRef dts As dtsLotesComponentes.LotesComponentesDataTable)
        Dim tabla As New DataTable
        tabla = clsLot.DevolverLotesComponentes()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsLotesComponentes.LotesComponentesRow
        While i < tabla.Rows.Count
            reg = dts.NewLotesComponentesRow
            reg.LoteId = tabla.Rows(i).Item(0)
            reg.CodigoLote = tabla.Rows(i).Item(1)
            reg.Cantidad = tabla.Rows(i).Item(2)
            If IsDBNull(tabla.Rows(i).Item(3)) Then
                reg.Observaciones = 0
            Else
                reg.Observaciones = tabla.Rows(i).Item(3)
            End If
            dts.AddLotesComponentesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Public Sub mostrarLotesQueCompone(ByRef dts As dtsLotesComponentes.LotesComponentesDataTable)
        Dim tabla As New DataTable
        tabla = clsLot.DevolverLotesQueCompone()
        Dim i As Integer
        dts.Clear()
        Dim reg As dtsLotesComponentes.LotesComponentesRow
        While i < tabla.Rows.Count
            reg = dts.NewLotesComponentesRow
            reg.LoteId = tabla.Rows(i).Item(0)
            reg.CodigoLote = tabla.Rows(i).Item(1)
            reg.Cantidad = tabla.Rows(i).Item(2)
            If IsDBNull(tabla.Rows(i).Item(3)) Then
                reg.Observaciones = ""
            Else
                reg.Observaciones = tabla.Rows(i).Item(3)
            End If
            dts.AddLotesComponentesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    '-----------------------------------------------------LOTES-----------------------------------------------------------------
    Public Sub mostrarTrazabilidadLote(ByRef dts As dtsLotesTrazabilidad.LotesTrazabilidadDataTable, ByVal Lote As Integer)
        Dim tabla As New DataTable
        tabla = clsLot.DevolverLotesTrazabilidad(Lote)
        Dim i As Integer
        Dim reg As dtsLotesTrazabilidad.LotesTrazabilidadRow
        While i < tabla.Rows.Count
            reg = dts.NewLotesTrazabilidadRow
            reg.ComponeA = tabla.Rows(i).Item(0)
            reg.LoteId = tabla.Rows(i).Item(1)
            reg.CodigoLote = tabla.Rows(i).Item(2)
            reg.Fecha = tabla.Rows(i).Item(3)
            reg.Fecha = reg.Fecha.Date
            reg.Proceso = tabla.Rows(i).Item(4)
            reg.Cantidad = tabla.Rows(i).Item(5)
            If IsDBNull(tabla.Rows(i).Item(6)) Then
                reg.Proveedor = ""
            Else
                reg.Proveedor = tabla.Rows(i).Item(6)
            End If

            dts.AddLotesTrazabilidadRow(reg)
            mostrarTrazabilidadLote(dts, reg.LoteId)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Private Sub CargarDatos(ByRef txt As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chb As CheckBox, ByVal ID As Integer, ByVal minimo As Double, ByVal maximo As Double, ByVal obligatorio As Boolean)
        txt.ParametroID = ID
        txt.ValorMinimo = minimo
        txt.ValorMaximo = maximo
        If obligatorio Then
            chb.Checked = True
            chb.Enabled = False
            txt.Obligatorio = True
        Else
            chb.Checked = False
            chb.Enabled = True
            txt.Obligatorio = False
        End If
        txt.validarTextBox()
    End Sub

    Private Sub LimpiarDatos(ByRef txt As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chb As CheckBox)
        txt.ValorMinimo = 0
        txt.ValorMaximo = 0
        chb.Checked = False
        chb.Enabled = True
        txt.Obligatorio = False
        txt.validarTextBox()
    End Sub

    Public Function NuevaAnalitica(ByVal Nombre As String, ByVal LoteID As Integer, ByVal AnalistaID As Integer, ByVal CatadorID As Integer) As Integer
        clsAna._LoteID = LoteID
        clsAna._Nombre = Nombre
        clsAna._AnalistaID = AnalistaID
        clsAna._CatadorID = CatadorID
        Return clsAna.Insertar()
    End Function

    Function mostrarTodasAnaliticasPorMuestra(ByVal LoteID As Integer) As DataTable
        clsAna._LoteID = LoteID
        Return clsAna.DevolverPorMuestra()
    End Function

    Public Sub CargarAnalitica(ByVal AnaliticaID As Integer, ByRef analista As Integer, ByRef catador As Integer)
        clsAna._AnaliticaID = AnaliticaID
        clsAna.cargar()
        analista = clsAna._AnalistaID
        catador = clsAna._CatadorID
    End Sub

    Public Function CargarAnaliticaExterna(ByVal AnaliticaID As Integer, ByRef RutaAnalisis As String, ByRef FechaAnaliticaExterna As Date, ByRef ProveedorID As Integer) As Integer
        clsAnaExt._AnaliticaID = AnaliticaID
        clsAnaExt.cargar()
        RutaAnalisis = clsAnaExt._RutaAnalisis
        FechaAnaliticaExterna = clsAnaExt._Fecha
        ProveedorID = clsAnaExt._ProveedorID
        Return clsAnaExt._AnaliticaExternaID
    End Function

    Sub MostrarObservacionesAnalitica(ByRef txtobservacion As BasesParaCompatibilidad.CuadroDeTextoMuestra)
        If MostrarAnaliticas Then
            txtobservacion.Modificado = True
        End If
        clsMueObs._ObservacionID = txtobservacion.ParametroID
        txtobservacion.Text = clsMueObs.cargar()
    End Sub

    Private Sub MostrarValoresAnalitica(ByRef txtParametro As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Requerido As Boolean)
        If MostrarAnaliticas Then
            txtParametro.Modificado = True
        End If
        clsAnaVal._ParametroID = txtParametro.ParametroID
        txtParametro.Text = clsAnaVal.cargar()

        clsAnaReq._ParametroID = txtParametro.ParametroID
        If clsAnaReq.existe Then
            Requerido = True
        Else
            Requerido = False
        End If
    End Sub

    Public Function mostrarPosicionPAraTrazabilidadLotes(ByVal LoteID As Integer, ByRef enologicos As Boolean) As Integer
        Dim tabla As New DataTable

        'Este procedimiento esta mal
        clsLot._LoteID = LoteID
        'enologicos = clsLot.LoteEsEnologico

        'Dim a As Boolean
        'a = FuncionUnParametro("GetEsEnologicoByLoteID", "@LoteID", LoteID)
        'If a Then
        '    messagebox.show("Es enologico")
        'Else
        '    messagebox.show("NO es enologico")
        'End If

        'If enologicos  Then
        tabla = clsLot.devolverTodosNoEnologicos(False)
        'Else
        'tabla = clsLot.devolverTodosNoEnologicos()
        'End If

        Dim i As Integer
        While i < tabla.Rows.Count
            If tabla.Rows(i).Item(0) = LoteID Then
                Return i
            End If
            i = i + 1
        End While
        Return 0
    End Function

    Private MostrarAnaliticas As Boolean
    Public Sub MostrarParametrosAnalitica(ByVal analiticaID As Integer, _
    ByRef txtAcidez As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Acidez As Boolean, ByRef txtAlcohol As BasesParaCompatibilidad.CuadroDeTextoMuestra, _
    ByRef Alcohol As Boolean, ByRef txtExtracto As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Extracto As Boolean, ByRef txtExtractoGrado As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtCenizas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Cenizas As Boolean, _
    ByRef txtMetanol As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Metanol As String, ByRef txtHg As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Hg As String, ByRef txtAs As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef As_ As Boolean, _
    ByRef txtPb As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Pb As Boolean, ByRef txtSulfatos As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Sulfatos As Boolean, ByRef txtCloruros As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Cloruros As Boolean, _
    ByRef txtSulfuroso As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Sulfuroso As Boolean, ByRef txtC14 As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef C14 As Boolean, ByRef txtAcetato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Acetato As Boolean, _
    ByRef txtDensidad As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Densidad As Boolean, ByRef txtTurbidez As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Turbidez As Boolean, ByRef txtIC As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef IC As Boolean, ByRef txtPh As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Ph As Boolean, _
    ByRef txtColor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Color As Boolean, ByRef txtMedidaColor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtFe As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Fe As Boolean, ByRef txtCu As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Cu As Boolean, _
    ByRef txtZn As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Zn As Boolean, ByRef txtAcetoina As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Acetoina As Boolean, ByRef txtPardeamiento As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Pardeamiento As Boolean, ByRef txtNitrogeno As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Nitrogeno As Boolean, _
    ByRef txtPolifenoles As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Polifenoles As Boolean, ByRef txtAcidezFija As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef AcidezFija As Boolean, ByRef txtAcidezVolatil As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef AcidezVolatil As Boolean, ByRef txtAzucarTotal As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef AzucarTotal As Boolean, _
    ByRef txtBaume As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Baume As Boolean, ByRef txtBrix As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Brix As Boolean, ByRef txtSorbitol As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Sorbitol As Boolean, _
    ByRef txtRecuentoTotal As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef RecuentoTotal As Boolean, ByRef txtBacterias As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Bacterias As Boolean, ByRef txtLevaduras As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Levaduras As Boolean, _
    ByRef txtHongos As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Hongos As Boolean, ByRef txtXilenium As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Xilenium As Boolean, ByRef txtAnguilulas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Anguilulas As Boolean, _
    ByRef txtOlfato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Olfato As Boolean, ByRef txtSabor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Sabor As Boolean, ByRef txtVista As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef Vista As Boolean, _
    ByRef txtEstableFrio As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef EstableFrio As Boolean, ByRef txtEstableCalor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef EstableCalor As Boolean, ByRef txtEstableProteinas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef EstableProteinas As Boolean, _
    ByRef txtObservacionesOlfato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtObservacionesSabor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtObservacionesVista As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal MostrarAnaliticasMuestra As Boolean)

        MostrarAnaliticas = MostrarAnaliticasMuestra
        clsAnaVal._AnaliticaID = analiticaID
        clsAnaReq._AnaliticaID = analiticaID
        clsMueObs._AnaliticaID = analiticaID

        '----------------- PARAMETROS LEGALES ----------------
        MostrarValoresAnalitica(txtAcidez, Acidez)
        MostrarValoresAnalitica(txtAlcohol, Alcohol)
        MostrarValoresAnalitica(txtExtracto, Extracto)
        MostrarValoresAnalitica(txtExtractoGrado, False)
        MostrarValoresAnalitica(txtCenizas, Cenizas)
        MostrarValoresAnalitica(txtMetanol, Metanol)
        MostrarValoresAnalitica(txtHg, Hg)
        MostrarValoresAnalitica(txtAs, As_)
        MostrarValoresAnalitica(txtPb, Pb)
        MostrarValoresAnalitica(txtSulfatos, Sulfatos)
        MostrarValoresAnalitica(txtCloruros, Cloruros)
        MostrarValoresAnalitica(txtSulfuroso, Sulfuroso)
        MostrarValoresAnalitica(txtC14, C14)

        '----------------- CONTROL ANALITICO ----------------
        MostrarValoresAnalitica(txtAcetato, Acetato)
        MostrarValoresAnalitica(txtDensidad, Densidad)
        MostrarValoresAnalitica(txtTurbidez, Turbidez)
        MostrarValoresAnalitica(txtIC, IC)
        MostrarValoresAnalitica(txtPh, Ph)
        MostrarValoresAnalitica(txtColor, Color)
        'MostrarValoresAnalitica(txtMedidaColor, False)
        MostrarValoresAnalitica(txtFe, Fe)
        MostrarValoresAnalitica(txtCu, Cu)
        MostrarValoresAnalitica(txtZn, Zn)
        MostrarValoresAnalitica(txtAcetoina, Acetoina)
        MostrarValoresAnalitica(txtPardeamiento, Pardeamiento)
        MostrarValoresAnalitica(txtNitrogeno, Nitrogeno)
        MostrarValoresAnalitica(txtPolifenoles, Polifenoles)
        MostrarValoresAnalitica(txtAcidezFija, AcidezFija)
        MostrarValoresAnalitica(txtAcidezVolatil, AcidezVolatil)
        MostrarValoresAnalitica(txtAzucarTotal, AzucarTotal)
        MostrarValoresAnalitica(txtBaume, Baume)
        MostrarValoresAnalitica(txtBrix, Brix)
        MostrarValoresAnalitica(txtSorbitol, Sorbitol)

        '----------------- CONTROL MICROBIOLOGICO ----------------
        MostrarValoresAnalitica(txtRecuentoTotal, RecuentoTotal)
        MostrarValoresAnalitica(txtBacterias, Bacterias)
        MostrarValoresAnalitica(txtLevaduras, Levaduras)
        MostrarValoresAnalitica(txtHongos, Hongos)
        MostrarValoresAnalitica(txtXilenium, Xilenium)
        MostrarValoresAnalitica(txtAnguilulas, Anguilulas)

        '----------------- CATA Y CONTROL ESTABILIDAD ----------------
        MostrarValoresAnalitica(txtOlfato, Olfato)
        MostrarValoresAnalitica(txtSabor, Sabor)
        MostrarValoresAnalitica(txtVista, Vista)
        MostrarValoresAnalitica(txtEstableFrio, EstableFrio)
        MostrarValoresAnalitica(txtEstableCalor, EstableCalor)
        MostrarValoresAnalitica(txtEstableProteinas, EstableProteinas)

        '----------------- OBSERVACIONES ----------------       
        MostrarObservacionesAnalitica(txtMedidaColor)
        MostrarObservacionesAnalitica(txtObservacionesOlfato)
        MostrarObservacionesAnalitica(txtObservacionesSabor)
        MostrarObservacionesAnalitica(txtObservacionesVista)


    End Sub

    Sub CargarObservacionesID(ByRef txtMedidaColor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtObservacionesOlfato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtObservacionesSabor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtObservacionesVista As BasesParaCompatibilidad.CuadroDeTextoMuestra)
        Dim tabla As New DataTable
        tabla = clsObs.devolver()
        Dim i As Integer
        Dim Contador As Integer = 7
        Dim NombreObservacion As String

        Dim Olfato, Sabor, Vista, MedidaColor As String
        Olfato = "Olfato, "
        Sabor = "Sabor, "
        Vista = "Vista, "
        MedidaColor = "Medida Color, "

        While i < tabla.Rows.Count
            NombreObservacion = tabla.Rows(i).Item(1).ToString.ToUpper.Replace(" ", "").Trim

            Select Case NombreObservacion
                Case "OLFATO"
                    Olfato = ""
                    txtObservacionesOlfato.ParametroID = tabla.Rows(i).Item(0)
                Case "SABOR"
                    Sabor = ""
                    txtObservacionesSabor.ParametroID = tabla.Rows(i).Item(0)
                Case "VISTA"
                    Vista = ""
                    txtObservacionesVista.ParametroID = tabla.Rows(i).Item(0)
                Case "MEDIDACOLOR"
                    MedidaColor = ""
                    txtMedidaColor.ParametroID = tabla.Rows(i).Item(0)
            End Select
            i = i + 1
        End While

        Dim faltan As String = Olfato & Sabor & Vista & MedidaColor
        If faltan.Trim <> "" Then
            messagebox.show("Faltan algunas observaciones por favor revisar la tabla Observaciones, son los sgtes: " & faltan, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Public Sub cargarParametrosMuestra(ByVal EspecificacionID As Integer, ByRef txtAcidez As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAcidez As CheckBox, ByRef txtAlcohol As BasesParaCompatibilidad.CuadroDeTextoMuestra, _
    ByRef chbAlcohol As CheckBox, ByRef txtExtracto As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbExtracto As CheckBox, ByRef txtExtractoGrador As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef txtCenizas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbCenizas As CheckBox, _
    ByRef txtMetanol As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbMetanol As CheckBox, ByRef txtHg As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbHg As CheckBox, ByRef txtAs As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAs As CheckBox, _
    ByRef txtPb As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbPb As CheckBox, ByRef txtSulfatos As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbSulfatos As CheckBox, ByRef txtCloruros As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbCloruros As CheckBox, _
    ByRef txtSulfuroso As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbSulfuroso As CheckBox, ByRef txtC14 As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbC14 As CheckBox, ByRef txtAcetato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAcetato As CheckBox, _
    ByRef txtDensidad As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbDensidad As CheckBox, ByRef txtTurbidez As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbTurbidez As CheckBox, ByRef txtIC As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbIC As CheckBox, ByRef txtPh As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbPh As CheckBox, _
    ByRef txtColor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbColor As CheckBox, ByRef txtFe As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbFe As CheckBox, ByRef txtCu As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbCu As CheckBox, _
    ByRef txtZn As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbZn As CheckBox, ByRef txtAcetoina As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAcetoina As CheckBox, ByRef txtPardeamiento As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbPardeamiento As CheckBox, ByRef txtNitrogeno As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbNitrogeno As CheckBox, _
    ByRef txtPolifenoles As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbPolifenoles As CheckBox, ByRef txtAcidezFija As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAcidezFija As CheckBox, ByRef txtAcidezVolatil As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAcidezVolatil As CheckBox, ByRef txtAzucarTotal As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAzucarTotal As CheckBox, _
    ByRef txtBaume As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbBaume As CheckBox, ByRef txtBrix As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbBrix As CheckBox, ByRef txtSorbitol As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbSorbitol As CheckBox, _
    ByRef txtRecuentoTotal As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbRecuentoTotal As CheckBox, ByRef txtBacterias As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbBacterias As CheckBox, ByRef txtLevaduras As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbLevaduras As CheckBox, _
    ByRef txtHongos As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbHongos As CheckBox, ByRef txtXilenium As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbXilenium As CheckBox, ByRef txtAnguilulas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbAnguilulas As CheckBox, _
    ByRef txtOlfato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbOlfato As CheckBox, ByRef txtSabor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbSabor As CheckBox, ByRef txtVista As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbVista As CheckBox, _
    ByRef txtEstableFrio As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbEstableFrio As CheckBox, ByRef txtEstableCalor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbEstableCalor As CheckBox, ByRef txtEstableProteinas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByRef chbEstableProteinas As CheckBox)


        Dim vacio As New CheckBox

        If EspecificacionID = 0 Then
            LimpiarDatos(txtAcidez, chbAcidez)
            LimpiarDatos(txtAlcohol, chbAlcohol)
            LimpiarDatos(txtExtracto, chbExtracto)
            LimpiarDatos(txtExtractoGrador, vacio)
            LimpiarDatos(txtCenizas, chbCenizas)
            LimpiarDatos(txtMetanol, chbMetanol)
            LimpiarDatos(txtHg, chbHg)
            LimpiarDatos(txtAs, chbAs)
            LimpiarDatos(txtPb, chbPb)
            LimpiarDatos(txtSulfatos, chbSulfatos)
            LimpiarDatos(txtCloruros, chbCloruros)
            LimpiarDatos(txtSulfuroso, chbSulfuroso)
            LimpiarDatos(txtC14, chbC14)

            '*------------------------------------------ CONTROL ANALITICO ------------------------------------------------------------------------
            LimpiarDatos(txtAcetato, chbAcetato)
            LimpiarDatos(txtDensidad, chbDensidad)
            LimpiarDatos(txtTurbidez, chbTurbidez)
            LimpiarDatos(txtIC, chbIC)
            LimpiarDatos(txtPh, chbPh)
            LimpiarDatos(txtColor, chbColor)
            'LimpiarDatos(txtMedidaColor, vacio)
            LimpiarDatos(txtFe, chbFe)
            LimpiarDatos(txtCu, chbCu)
            LimpiarDatos(txtZn, chbZn)
            LimpiarDatos(txtAcetoina, chbAcetoina)
            LimpiarDatos(txtPardeamiento, chbPardeamiento)
            LimpiarDatos(txtNitrogeno, chbNitrogeno)
            LimpiarDatos(txtPolifenoles, chbPolifenoles)
            LimpiarDatos(txtAcidezFija, chbAcidezFija)
            LimpiarDatos(txtAcidezVolatil, chbAcidezVolatil)
            LimpiarDatos(txtAzucarTotal, chbAzucarTotal)
            LimpiarDatos(txtBaume, chbBaume)
            LimpiarDatos(txtBrix, chbBrix)
            LimpiarDatos(txtSorbitol, chbSorbitol)

            '*------------------------------------------ CONTROL MICROBIOLOGICO ------------------------------------------------------------------------
            LimpiarDatos(txtRecuentoTotal, chbRecuentoTotal)
            LimpiarDatos(txtBacterias, chbBacterias)
            LimpiarDatos(txtLevaduras, chbLevaduras)
            LimpiarDatos(txtHongos, chbHongos)
            LimpiarDatos(txtXilenium, chbXilenium)
            LimpiarDatos(txtAnguilulas, chbAnguilulas)

            '*------------------------------------------  CATA Y CONTROL ESTABILIDAD ------------------------------------------------------------------------
            LimpiarDatos(txtOlfato, chbOlfato)
            LimpiarDatos(txtSabor, chbSabor)
            LimpiarDatos(txtVista, chbVista)
            LimpiarDatos(txtEstableFrio, chbEstableFrio)
            LimpiarDatos(txtEstableCalor, chbEstableCalor)
            LimpiarDatos(txtEstableProteinas, chbEstableProteinas)
            Return
        End If

        clsEsp._EspecificacionID = EspecificacionID
        Dim tabla As New DataTable
        tabla = clsEsp.devolverPorEspecificacion()
        Dim i As Integer

        Dim NombreParametro As String

        '----------------- PARAMETROS LEGALES ----------------
        Dim Acidez, Alcohol, Extracto, ExtractoGrado, Cenizas, Metanol, Hg, AS_, Pb, Sulfatos, Cloruros, Sulfuroso, C14 As String
        Acidez = "Acidez, "
        Alcohol = "Alcohol, "
        Extracto = "Extracto, "
        ExtractoGrado = "ExtractoGrado, "
        Cenizas = "Cenizas, "
        Metanol = "Metanol, "
        Hg = "Extracto Neto, "
        AS_ = "AS, "
        Pb = "Pb, "
        Sulfatos = "Sulfatos, "
        Cloruros = "Cloruros, "
        Sulfuroso = "Sulfuroso, "
        C14 = "Grados Viscosidad, "

        '----------------- CONTROL ANALITICO ----------------
        Dim Acetato, Densidad, Turbidez, IC, Ph, Color, Fe, Cu, Zn, Acetoina, Pardeamiento, Nitrogeno, Polifenoles, AcidezFija, AcidezVolatil, AzucarTotal, Baume, Brix, Sorbitol As String
        Acetato = "Acetato, "
        Densidad = "Densidad, "
        Turbidez = "Turbidez, "
        IC = "IC, "
        Ph = "Ph, "
        Color = "Color, "
        'MedidaColor = "MedidaColor, "
        Fe = "Fe, "
        Cu = "Cu, "
        Zn = "Zn, "
        Acetoina = "Acetoina, "
        Pardeamiento = "Pardeamiento, "
        Nitrogeno = "Nitrogeno, "
        Polifenoles = "Polifenoles, "
        AcidezFija = "AcidezFija, "
        AcidezVolatil = "AcidezVolatil, "
        AzucarTotal = "AzucarTotal, "
        Baume = "Baume, "
        Brix = "Brix, "
        Sorbitol = "Viscosidad, "

        '----------------- CONTROL MICROBIOLOGICO ----------------
        Dim RecuentoTotal, Bacterias, Levaduras, Hongos, Xilenium, Anguilulas As String
        RecuentoTotal = "RecuentoTotal, "
        Bacterias = "Bacterias, "
        Levaduras = "Levaduras, "
        Hongos = "Hongos, "
        Xilenium = "Xilenium, "
        Anguilulas = "Anguilulas, "

        '----------------- CATA Y CONTROL ESTABILIDAD ----------------
        Dim Olfato, Sabor, Vista, EstableFrio, EstableCalor, EstableProteinas As String
        Olfato = "Olfato, "
        Sabor = "Sabor, "
        Vista = "Vista, "
        EstableFrio = "EstableFrio, "
        EstableCalor = "EstableCalor, "
        EstableProteinas = "EstableProteinas, "


        While i < tabla.Rows.Count
            NombreParametro = tabla.Rows(i).Item(1).ToString.ToUpper.Replace(" ", "").Trim
            If IsDBNull(tabla.Rows(i).Item(2)) Then
                tabla.Rows(i).Item(2) = 0
            End If
            If IsDBNull(tabla.Rows(i).Item(3)) Then
                tabla.Rows(i).Item(3) = 0
            End If
            If IsDBNull(tabla.Rows(i).Item(4)) Then
                tabla.Rows(i).Item(4) = "false"
            End If

            Select Case NombreParametro
                '*------------------------------------------ PARAMETROS LEGALES ------------------------------------------------------------------------
                Case "ACIDEZ"
                    Acidez = ""
                    CargarDatos(txtAcidez, chbAcidez, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ALCOHOL"
                    Alcohol = ""
                    CargarDatos(txtAlcohol, chbAlcohol, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "EXTRACTO"
                    Extracto = ""
                    CargarDatos(txtExtracto, chbExtracto, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "EXTRACTOGRADO"
                    ExtractoGrado = ""
                    CargarDatos(txtExtractoGrador, vacio, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "CENIZAS"
                    Cenizas = ""
                    CargarDatos(txtCenizas, chbCenizas, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "METANOL"
                    Metanol = ""
                    CargarDatos(txtMetanol, chbMetanol, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "EXTRACTONETO"
                    Hg = ""
                    CargarDatos(txtHg, chbHg, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "AS"
                    AS_ = ""
                    CargarDatos(txtAs, chbAs, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "PB"
                    Pb = ""
                    CargarDatos(txtPb, chbPb, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "SULFATOS"
                    Sulfatos = ""
                    CargarDatos(txtSulfatos, chbSulfatos, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "CLORUROS"
                    Cloruros = ""
                    CargarDatos(txtCloruros, chbCloruros, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "SULFUROSO"
                    Sulfuroso = ""
                    CargarDatos(txtSulfuroso, chbSulfuroso, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "GRADOSVISCOSIDAD"
                    C14 = ""
                    CargarDatos(txtC14, chbC14, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))

                    '*------------------------------------------ CONTROL ANALITICO ------------------------------------------------------------------------
                Case "ACETATO"
                    Acetato = ""
                    CargarDatos(txtAcetato, chbAcetato, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "DENSIDAD"
                    Densidad = ""
                    CargarDatos(txtDensidad, chbDensidad, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "TURBIDEZ"
                    Turbidez = ""
                    CargarDatos(txtTurbidez, chbTurbidez, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "IC"
                    IC = ""
                    CargarDatos(txtIC, chbIC, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "PH"
                    Ph = ""
                    CargarDatos(txtPh, chbPh, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "COLOR"
                    Color = ""
                    CargarDatos(txtColor, chbColor, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                    'Case "MEDIDACOLOR"
                    '    MedidaColor = ""
                    '    CargarDatos(txtMedidaColor, vacio, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "FE"
                    Fe = ""
                    CargarDatos(txtFe, chbFe, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "CU"
                    Cu = ""
                    CargarDatos(txtCu, chbCu, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ZN"
                    Zn = ""
                    CargarDatos(txtZn, chbZn, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ACETOINA"
                    Acetoina = ""
                    CargarDatos(txtAcetoina, chbAcetoina, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "PARDEAMIENTO"
                    Pardeamiento = ""
                    CargarDatos(txtPardeamiento, chbPardeamiento, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "NITROGENO"
                    Nitrogeno = ""
                    CargarDatos(txtNitrogeno, chbNitrogeno, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "POLIFENOLES"
                    Polifenoles = ""
                    CargarDatos(txtPolifenoles, chbPolifenoles, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ACIDEZFIJA"
                    AcidezFija = ""
                    CargarDatos(txtAcidezFija, chbAcidezFija, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ACIDEZVOLATIL"
                    AcidezVolatil = ""
                    CargarDatos(txtAcidezVolatil, chbAcidezVolatil, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "AZUCARTOTAL"
                    AzucarTotal = ""
                    CargarDatos(txtAzucarTotal, chbAzucarTotal, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "BAUME"
                    Baume = ""
                    CargarDatos(txtBaume, chbBaume, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "BRIX"
                    Brix = ""
                    CargarDatos(txtBrix, chbBrix, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "VISCOSIDAD"
                    Sorbitol = ""
                    CargarDatos(txtSorbitol, chbSorbitol, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))

                    '*------------------------------------------ CONTROL MICROBIOLOGICO ------------------------------------------------------------------------
                Case "RECUENTOTOTAL"
                    RecuentoTotal = ""
                    CargarDatos(txtRecuentoTotal, chbRecuentoTotal, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "BACTERIAS"
                    Bacterias = ""
                    CargarDatos(txtBacterias, chbBacterias, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "LEVADURAS"
                    Levaduras = ""
                    CargarDatos(txtLevaduras, chbLevaduras, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "HONGOS"
                    Hongos = ""
                    CargarDatos(txtHongos, chbHongos, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "XILENIUM"
                    Xilenium = ""
                    CargarDatos(txtXilenium, chbXilenium, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ANGUILULAS"
                    Anguilulas = ""
                    CargarDatos(txtAnguilulas, chbAnguilulas, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))


                    '*------------------------------------------  CATA Y CONTROL ESTABILIDAD ------------------------------------------------------------------------
                Case "OLFATO"
                    Olfato = ""
                    CargarDatos(txtOlfato, chbOlfato, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "SABOR"
                    Sabor = ""
                    CargarDatos(txtSabor, chbSabor, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "VISTA"
                    Vista = ""
                    CargarDatos(txtVista, chbVista, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ESTABLEFRIO"
                    EstableFrio = ""
                    CargarDatos(txtEstableFrio, chbEstableFrio, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ESTABLECALOR"
                    EstableCalor = ""
                    CargarDatos(txtEstableCalor, chbEstableCalor, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case "ESTABLEPROTEINAS"
                    EstableProteinas = ""
                    CargarDatos(txtEstableProteinas, chbEstableProteinas, tabla.Rows(i).Item(0), tabla.Rows(i).Item(2), tabla.Rows(i).Item(3), tabla.Rows(i).Item(4))
                Case Else
            End Select
            i = i + 1
        End While

        Dim faltan As String = Acidez & Alcohol & Extracto & ExtractoGrado & Cenizas & Metanol & Hg & AS_ & Pb & Sulfatos & Cloruros & Sulfuroso & C14 & Acetato & Densidad & Turbidez & IC & Ph & Color & Fe & Cu & Zn & Acetoina & Pardeamiento & Nitrogeno & Polifenoles & AcidezFija & AcidezVolatil & AzucarTotal & Baume & Brix & Sorbitol & RecuentoTotal & Bacterias & Levaduras & Hongos & Xilenium & Anguilulas & Olfato & Sabor & Vista & EstableFrio & EstableCalor & EstableProteinas
        If faltan.Trim <> "" Then
            messagebox.show("Faltan algunos parametros porfavor revisar la tabla Parametros, son los sgtes: " & faltan, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

   
    Public Function mostrarTodosLotesPorTipoLoteoProducto(ByVal TipoLoteId As Integer, ByVal tipoProductoID As Integer, ByVal enologicos As Boolean, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim tabla As New DataTable
        clsLot._TipoLoteID = TipoLoteId
        clsLot._TipoProductoID = tipoProductoID

        If TipoLoteId = 0 And tipoProductoID = 0 Then
            If enologicos Then
                tabla = clsLot.devolverTodosEnologicos2(top100, id)
            Else
                tabla = clsLot.devolverTodosNoEnologicos2(top100, id)
            End If
        ElseIf TipoLoteId > 0 And tipoProductoID = 0 Then
            tabla = clsLot.devolverPorTipoLoteID2(top100, id)
        ElseIf TipoLoteId = 0 And tipoProductoID > 0 Then
            tabla = clsLot.devolverPorTipoProductoID2(top100, id)
        Else
            tabla = clsLot.devolverPorTipoProductoIDyTipoLoteID2(top100, id)
        End If

        Return tabla
    End Function

    Public Sub mostrarTodosLotesPorTipoLoteoProducto(ByVal TipoLoteId As Integer, ByVal tipoProductoID As Integer, ByRef dtsMue As dtsLotes.LotesDataTable, ByVal enologicos As Boolean, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing)
        Dim tabla As New DataTable
        clsLot._TipoLoteID = TipoLoteId
        clsLot._TipoProductoID = tipoProductoID

        If TipoLoteId = 0 And tipoProductoID = 0 Then
            If enologicos Then
                tabla = clsLot.devolverTodosEnologicos(top100, id)
            Else
                tabla = clsLot.devolverTodosNoEnologicos(top100, id)
            End If
        ElseIf TipoLoteId > 0 And tipoProductoID = 0 Then
            tabla = clsLot.devolverPorTipoLoteID(top100, id)
        ElseIf TipoLoteId = 0 And tipoProductoID > 0 Then
            tabla = clsLot.devolverPorTipoProductoID(top100, id)
        Else
            tabla = clsLot.devolverPorTipoProductoIDyTipoLoteID(top100, id)
        End If


        Dim i As Integer
        Dim reg As dtsLotes.LotesRow
        dtsMue.Clear()
        While i < tabla.Rows.Count
            reg = dtsMue.NewLotesRow
            reg.LoteID = tabla.Rows(i).Item(0)

            If IsDBNull(tabla.Rows(i).Item(1)) Then
                reg.Descripcion = ""
            Else
                reg.Descripcion = tabla.Rows(i).Item(1)
            End If
            reg.Fecha = tabla.Rows(i).Item(2)
            reg.Fecha = reg.Fecha.Date
            If IsDBNull(tabla.Rows(i).Item(3)) Then
                reg.CantidadRestante = 0
            Else
                reg.CantidadRestante = tabla.Rows(i).Item(3)
            End If

            If IsDBNull(tabla.Rows(i).Item(4)) Then
                reg.Observacion = ""
            Else
                reg.Observacion = tabla.Rows(i).Item(4)
            End If

            If IsDBNull(tabla.Rows(i).Item(5)) Then
                reg.LoteProveedor = ""
            Else
                reg.LoteProveedor = tabla.Rows(i).Item(5)
            End If

            If IsDBNull(tabla.Rows(i).Item(6)) Then
                reg.Botellas = ""
            Else
                reg.Botellas = tabla.Rows(i).Item(6)
            End If


            If IsDBNull(tabla.Rows(i).Item(7)) Then
                reg.Cantidad = 0
            Else
                reg.Cantidad = tabla.Rows(i).Item(7)
            End If

            If IsDBNull(tabla.Rows(i).Item(8)) Then
                reg.Medida = 0
            Else
                reg.Medida = tabla.Rows(i).Item(8)
            End If

            If IsDBNull(tabla.Rows(i).Item(9)) Then
                reg.Corredor = ""
            Else
                reg.Corredor = tabla.Rows(i).Item(9)
            End If
            If IsDBNull(tabla.Rows(i).Item(10)) Then
                reg.TipoLote = 0
            Else
                reg.TipoLote = tabla.Rows(i).Item(10)
            End If

            If IsDBNull(tabla.Rows(i).Item(11)) Then
                reg.TipoProducto = 0
            Else
                reg.TipoProducto = tabla.Rows(i).Item(11)
            End If

            If IsDBNull(tabla.Rows(i).Item(12)) Then
                reg.Proveedor = ""
            Else
                reg.Proveedor = tabla.Rows(i).Item(12)
            End If
            If IsDBNull(tabla.Rows(i).Item(13)) Then
                reg.LoteConjuntoCompra = ""
            Else
                reg.LoteConjuntoCompra = tabla.Rows(i).Item(13)
            End If
            If IsDBNull(tabla.Rows(i).Item(14)) Then
                reg.Especificacion = ""
            Else
                reg.Especificacion = tabla.Rows(i).Item(14)
            End If

            reg.CodigoLote = tabla.Rows(i).Item(15)

            If IsDBNull(tabla.Rows(i).Item(16)) Then
                reg.DepositoID = ""
            Else
                reg.DepositoID = tabla.Rows(i).Item(16)
            End If
            If IsDBNull(tabla.Rows(i).Item(17)) Then
                reg.Referencia = "0"
            Else
                reg.Referencia = tabla.Rows(i).Item(17)
            End If

            If IsDBNull(tabla.Rows(i).Item(18)) Then
                reg.DepositoPrevio = ""
            Else
                reg.DepositoPrevio = tabla.Rows(i).Item(18)
            End If
            If IsDBNull(tabla.Rows(i).Item(19)) Then
                reg.RecipienteSalidaID = ""
            Else
                reg.RecipienteSalidaID = tabla.Rows(i).Item(19)
            End If
            dtsMue.AddLotesRow(reg)
            reg = Nothing
            i = i + 1
        End While
    End Sub

    Private Sub guardarObservacionesLotes(ByVal txtobservacion As BasesParaCompatibilidad.CuadroDeTextoMuestra)
        If txtobservacion.Modificado Then
            clsMueObs._ObservacionID = txtobservacion.ParametroID

            If txtobservacion.Text.Trim = "" Then
                clsMueObs.Eliminar()
            Else
                clsMueObs._Descripcion = txtobservacion.Text
                If clsMueObs.existe Then
                    clsMueObs.Modificar()
                Else
                    clsMueObs.Insertar()
                End If
            End If
        End If
    End Sub

    Private Sub guardarValoresLotes(ByVal txtParametro As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Requerido As Boolean)
        If txtParametro.Modificado Then
            clsAnaVal._ParametroID = txtParametro.ParametroID


            If txtParametro.Text.Trim = "" Or txtParametro.Text = "0" Then
                clsAnaVal.Eliminar()
            Else
                clsAnaVal._Valor = txtParametro.Text
                If clsAnaVal.existe Then
                    clsAnaVal.Modificar()
                Else
                    clsAnaVal.Insertar()
                End If
            End If
        End If
        clsAnaReq._ParametroID = txtParametro.ParametroID
        If clsAnaReq.existe Then
            If Not Requerido Then
                clsAnaReq.Eliminar()
            End If
        Else
            If Requerido Then
                clsAnaReq.Insertar()
            End If
        End If
    End Sub

    Public Sub GuardarAnaliticaExterna(ByVal AnaliticaID As Integer, ByVal AnaliticaExternaID As Integer, ByVal RutaAnalisis As String, ByVal FechaAnaliticaExterna As Date, ByVal ProveedorID As Integer)
        clsAnaExt._AnaliticaExternaID = AnaliticaExternaID
        clsAnaExt._AnaliticaID = AnaliticaID
        clsAnaExt._RutaAnalisis = RutaAnalisis
        clsAnaExt._Fecha = FechaAnaliticaExterna
        clsAnaExt._ProveedorID = ProveedorID

        If AnaliticaExternaID = 0 Then
            clsAnaExt.Insertar()
        Else
            clsAnaExt.Modificar()
        End If
    End Sub

    Public Sub GuardarLote(ByRef LoteID As Integer, ByVal ref As Integer, ByVal AnalistaID As Integer, ByVal CantidadRestante As Double, ByVal CatadorID As Integer, ByVal CodigoLote As String, ByVal TipoLote As Integer, ByVal TipoProducto As Integer, ByVal SinEspecificacion As Boolean, ByVal Descripcion As String, ByVal fecha As Date, _
    ByVal Especificacion As Integer, ByVal Observacion As String, ByVal Botellas As String, ByVal Cantidad As Integer, ByVal Medida As Integer, ByVal Corredor As Integer, ByVal Proveedor As Integer, ByVal analiticaID As Integer, _
    ByVal txtAcidez As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Acidez As Boolean, ByVal txtAlcohol As BasesParaCompatibilidad.CuadroDeTextoMuestra, _
    ByVal Alcohol As Boolean, ByVal txtExtracto As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Extracto As Boolean, ByVal txtExtractoGrado As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal txtCenizas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Cenizas As Boolean, _
    ByVal txtMetanol As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Metanol As String, ByVal txtHg As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Hg As String, ByVal txtAs As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal As_ As Boolean, _
    ByVal txtPb As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Pb As Boolean, ByVal txtSulfatos As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Sulfatos As Boolean, ByVal txtCloruros As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Cloruros As Boolean, _
    ByVal txtSulfuroso As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Sulfuroso As Boolean, ByVal txtC14 As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal C14 As Boolean, ByVal txtAcetato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Acetato As Boolean, _
    ByVal txtDensidad As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Densidad As Boolean, ByVal txtTurbidez As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Turbidez As Boolean, ByVal txtIC As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal IC As Boolean, ByVal txtPh As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Ph As Boolean, _
    ByVal txtColor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Color As Boolean, ByVal txtMedidaColor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal txtFe As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Fe As Boolean, ByVal txtCu As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Cu As Boolean, _
    ByVal txtZn As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Zn As Boolean, ByVal txtAcetoina As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Acetoina As Boolean, ByVal txtPardeamiento As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Pardeamiento As Boolean, ByVal txtNitrogeno As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Nitrogeno As Boolean, _
    ByVal txtPolifenoles As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Polifenoles As Boolean, ByVal txtAcidezFija As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal AcidezFija As Boolean, ByVal txtAcidezVolatil As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal AcidezVolatil As Boolean, ByVal txtAzucarTotal As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal AzucarTotal As Boolean, _
    ByVal txtBaume As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Baume As Boolean, ByVal txtBrix As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Brix As Boolean, ByVal txtSorbitol As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Sorbitol As Boolean, _
    ByVal txtRecuentoTotal As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal RecuentoTotal As Boolean, ByVal txtBacterias As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Bacterias As Boolean, ByVal txtLevaduras As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Levaduras As Boolean, _
    ByVal txtHongos As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Hongos As Boolean, ByVal txtXilenium As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Xilenium As Boolean, ByVal txtAnguilulas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Anguilulas As Boolean, _
    ByVal txtOlfato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Olfato As Boolean, ByVal txtSabor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Sabor As Boolean, ByVal txtVista As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal Vista As Boolean, _
    ByVal txtEstableFrio As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal EstableFrio As Boolean, ByVal txtEstableCalor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal EstableCalor As Boolean, ByVal txtEstableProteinas As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal EstableProteinas As Boolean, _
    ByVal txtObservacionesOlfato As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal txtObservacionesSabor As BasesParaCompatibilidad.CuadroDeTextoMuestra, ByVal txtObservacionesVista As BasesParaCompatibilidad.CuadroDeTextoMuestra)



        clsLot._LoteID = LoteID
        clsLot._Referencia = ref
        clsLot._CodigoLote = CodigoLote
        clsLot._TipoLoteID = TipoLote
        clsLot._TipoProductoID = TipoProducto
        clsLot._Descripcion = Descripcion
        clsLot._Fecha = fecha
        clsLot._CantidadRestante = CantidadRestante
        If Especificacion = -1 Then
            clsLot._EspecificacionID = 0
        Else
            clsLot._EspecificacionID = Especificacion
        End If

        clsLot._Observacion = Observacion.Trim
        Dim aux As Double
        Try
            aux = Botellas
        Catch ex As Exception
            Botellas = 0
        End Try
        If Botellas = "" Then
            clsLot._Botellas = 0
        Else
            clsLot._Botellas = Botellas
        End If

        clsLot._CantidadID = Cantidad
        clsLot._MedidaID = Medida
        clsLot._CorredorID = Corredor
        clsLot._ProveedorID = Proveedor
        clsLot._LoteConjuntoCompraID = 0

        If LoteID = 0 Then
            LoteID = clsLot.Insertar()
        Else
            If Not clsLot.Modificar() Then
                messagebox.show("no guardo cambios", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        End If

        If analiticaID = 0 Then
            clsAna._LoteID = LoteID
            clsAna._AnalistaID = AnalistaID
            clsAna._CatadorID = CatadorID
            clsAna._Nombre = "La Andaluza"

            analiticaID = clsAna.Insertar()
        Else
            clsAna._LoteID = LoteID
            clsAna._AnalistaID = AnalistaID
            clsAna._CatadorID = CatadorID
            clsAna.Modificar()
        End If



        clsAnaVal._AnaliticaID = analiticaID
        clsAnaReq._AnaliticaID = analiticaID
        clsMueObs._AnaliticaID = analiticaID

        '----------------- PARAMETROS LEGALES ----------------
        guardarValoresLotes(txtAcidez, Acidez)
        guardarValoresLotes(txtAlcohol, Alcohol)
        guardarValoresLotes(txtExtracto, Extracto)
        guardarValoresLotes(txtExtractoGrado, False)
        guardarValoresLotes(txtCenizas, Cenizas)
        guardarValoresLotes(txtMetanol, Metanol)
        guardarValoresLotes(txtHg, Hg)
        guardarValoresLotes(txtAs, As_)
        guardarValoresLotes(txtPb, Pb)
        guardarValoresLotes(txtSulfatos, Sulfatos)
        guardarValoresLotes(txtCloruros, Cloruros)
        guardarValoresLotes(txtSulfuroso, Sulfuroso)
        guardarValoresLotes(txtC14, C14)

        '----------------- CONTROL ANALITICO ----------------
        guardarValoresLotes(txtAcetato, Acetato)
        guardarValoresLotes(txtDensidad, Densidad)
        guardarValoresLotes(txtTurbidez, Turbidez)
        guardarValoresLotes(txtIC, IC)
        guardarValoresLotes(txtPh, Ph)
        guardarValoresLotes(txtColor, Color)
        'guardarValoresLotes(txtMedidaColor, False)
        guardarValoresLotes(txtFe, Fe)
        guardarValoresLotes(txtCu, Cu)
        guardarValoresLotes(txtZn, Zn)
        guardarValoresLotes(txtAcetoina, Acetoina)
        guardarValoresLotes(txtPardeamiento, Pardeamiento)
        guardarValoresLotes(txtNitrogeno, Nitrogeno)
        guardarValoresLotes(txtPolifenoles, Polifenoles)
        guardarValoresLotes(txtAcidezFija, AcidezFija)
        guardarValoresLotes(txtAcidezVolatil, AcidezVolatil)
        guardarValoresLotes(txtAzucarTotal, AzucarTotal)
        guardarValoresLotes(txtBaume, Baume)
        guardarValoresLotes(txtBrix, Brix)
        guardarValoresLotes(txtSorbitol, Sorbitol)

        '----------------- CONTROL MICROBIOLOGICO ----------------
        guardarValoresLotes(txtRecuentoTotal, RecuentoTotal)
        guardarValoresLotes(txtBacterias, Bacterias)
        guardarValoresLotes(txtLevaduras, Levaduras)
        guardarValoresLotes(txtHongos, Hongos)
        guardarValoresLotes(txtXilenium, Xilenium)
        guardarValoresLotes(txtAnguilulas, Anguilulas)

        '----------------- CATA Y CONTROL ESTABILIDAD ----------------
        guardarValoresLotes(txtOlfato, Olfato)
        guardarValoresLotes(txtSabor, Sabor)
        guardarValoresLotes(txtVista, Vista)
        guardarValoresLotes(txtEstableFrio, EstableFrio)
        guardarValoresLotes(txtEstableCalor, EstableCalor)
        guardarValoresLotes(txtEstableProteinas, EstableProteinas)

        '----------------- OBSERVACIONES ----------------       
        guardarObservacionesLotes(txtMedidaColor)
        guardarObservacionesLotes(txtObservacionesOlfato)
        guardarObservacionesLotes(txtObservacionesSabor)
        guardarObservacionesLotes(txtObservacionesVista)

    End Sub

    Public Function EliminarLote(ByVal ID As Integer) As Boolean

        clsAna._LoteID = ID

        Dim tabla As DataTable = clsAna.DevolverPorMuestra()
        Dim i As Integer
        While i < tabla.Rows.Count
            'eliminar analitica Valores
            clsAnaVal._AnaliticaID = tabla.Rows(i).Item(0)
            If Not clsAnaVal.EliminarPorAnalitica() Then Return False

            'eliminar analitica Requerimientos
            clsAnaReq._AnaliticaID = tabla.Rows(i).Item(0)
            If Not clsAnaReq.EliminarPorAnalitica() Then Return False

            'eliminar analitica Muestra Observacion
            clsMueObs._AnaliticaID = tabla.Rows(i).Item(0)
            If Not clsMueObs.EliminarPorAnalitica() Then Return False

            'eliminar analitica externa
            clsAnaExt._AnaliticaID = tabla.Rows(i).Item(0)
            If Not clsAnaExt.EliminarPorAnalitica() Then Return False

            'eliminar analitica
            clsAna._AnaliticaID = tabla.Rows(i).Item(0)
            If Not clsAna.Eliminar() Then Return False
            i = i + 1

        End While

        'eliminar muestra
        clsLot._LoteID = ID
        If Not clsLot.Eliminar() Then Return False

        Return True
    End Function




End Class
