
Public Class MenuDispatcher
    Private frmArticulos1 As frmArticulos1
    Private frmInformesAlmacen As frmInformesAlmacen
    Private frmListaParametros As frmListaParametros
    Private frmTiposLotes As frmTiposLotes
    Private frmMaquinas As frmMaquinas
    Private frmDepositos As frmDepositos
    Private frmLotesEnologico As frmLotesEnologico
    Private frmMaterialConstruccion As frmMaterialConstruccion
    Private frmProcesos As frmProcesos
    Private LisDepResumen As LisDepResumen
    Private LisDepPorTipos As LisDepPorTipos
    Private frmUnidadesMedidas As frmUnidadesMedidas
    Private frmTiposFormatosLineas As frmTiposFormatosLineas
    Private frmOrdenesEnvasado2 As frmOrdenesEnvasado2
    Private frmTiposMateriales As frmTiposMateriales
    Private frmMedidasProductos As frmMedidasProductos
    Private frmTiposProductos As frmTiposProductos
    Private frmMuestrasCantidades As frmMuestrasCantidades
    Private frmMuestrasMedidas As frmMuestrasMedidas
    Private frmMnLotes As FrmLotesEnologicos
    Private frmDepositosMain As frmDepositosMain
    Private frmVisitasMain As frmVisitasMain
    Private frmProveedoresMain As frmProveedoresMain
    Private frmExistenciasPorDepositoFecha As InformesDepositos.frmExistenciasPorDepositoFecha
    Private frmPaletsProducidos3 As frmPaletsProducidos3

    Private frmAlbaranesCargaMaestro As frmAlbaranesCargaMaestro
    Private frmExistenciasTodas As frmExistenciasTodas
    Private frmPaletsMovimientoEntrePalets As frmPaletsMovimientoEntrePalets
    Private frmPaletsMovimientoSubTipo As frmPaletsMovimientoSubTipo
    Private InformeMovimientos As InformeMovimientos
    Private frmPedidosClientesMaestros2 As frmPedidosClientesMaestros2
    Private frmPedidosProveedoresMaestros As frmPedidosProveedoresMaestros
    Private lstPedidosProveedoresPendientes As lstPedidosProveedoresPendientes
    Private frmPaletsTipos As frmPaletsTipos
    Private frmClientes As frmClientes
    Private frmStock As frmStock
    Private frmArticulosEtiquetasTipos As frmArticulosEtiquetasTipos
    Private frmEnvasados2 As frmEnvasados2
    Private PaletNoAlmacenNoTerminado As PaletNoAlmacenNoTerminado
    Private frmPedidosClientesNecesidades As frmPedidosClientesNecesidades
    Private frmOrdenesCargaInforme As frmOrdenesCargaInforme
    Private frmGeneradorBoletines As frmGeneradorBoletines
    Private frmLisEnvPorArticuloPrimario As frmLisEnvPorArticuloPrimario
    Private frmInformePedidos As frmInformePedidos
    Private frmStock2 As frmStock2
    Private frmCargaNecesidadesJRMaestro As frmCargaNecesidadesJRMaestro
    Private frmCamiones As frmCamiones
    Private frmAgenciasTransportes As frmAgenciasTransportes
    Private frmCamionesTipos As frmCamionesTipos
    Private frmConductores As frmConductores
    Private frmPaletsIncompletos As frmPaletsIncompletos
    Private frmLisEnvPorReferencia As frmLisEnvPorReferencia
    Private frmArticulosMinMax As frmArticulosMinMax
    Private frmLisAlbaranesCarga As frmLisAlbaranesCarga
    Private frmMetodosAnalisis As frmMetodosAnalisis
    Private frmEspecificaciones As frmEspecificaciones
    Private frmRecipientesSalidas As frmRecipientesSalidas
    Private frmCorredores As frmCorredores
    Private frmPendientes As frmPendientes
    Private frmCom As frmCom
    Private frmtiposEnvases As frmtiposEnvases
    Private frmcabecerasEtiquetas As frmcabecerasEtiquetas
    Private frmTiposControlesLotesPlantilla As frmTiposControlesLotesPlantilla
    Private InformesVinagreJerez1 As InformesVinagreJerez.Form1
    Private frmPartesTrabajosDiariosMaestros As frmPartesTrabajosDiariosMaestros
    Private frmRecuentoMaterialesAuxiliares As frmRecuentoMaterialesAuxiliares
    Private frmSituacionPersonal As frmSituacionPersonal
    Private checks As checks
    Private frmIncidenciasCalidadMain As frmIncidenciasCalidadMain
    Private frmempresas As frmempresas
    Private frmplantillasBoletines As frmplantillasBoletines
    Private frmParametrosTipos As frmParametrosTipos
    Private frmIncidenciasRecuento As frmIncidenciasRecuento
    Private frmImportarExcel As frmImportarExcel
    Private frmmarcas As frmmarcas
    Private frmEspecificacionesLegales As frmEspecificacionesLegales
    Private frmSaludLaboral As frmSaludLaboral
    Private frmOrganizacion As frmOrganizacion
    Private frmIdiomas As frmIdiomas
    Private frmTurnosTrabajo As frmTurnosTrabajo
    Private frmPedidosProveedoresEstados As frmPedidosProveedoresEstados
    Private frmLugaresEntregas As frmLugaresEntregas
    Private frmArticulosFichasCondiciones3 As frmArticulosFichasCondiciones3
    Private frmArticulosFichasPaletizados1 As frmArticulosFichasPaletizados1
    Private frmArticulosTipos As frmArticulosTipos
    Private frmArticulosMateriasPrimasTipos As frmArticulosMateriasPrimasTipos
    Private frmArticulosIngredientesTipos As frmArticulosIngredientesTipos
    Private PlanesGeneralesHigiene As PlanesGeneralesHigiene
    Private frmOrdenesCarga As frmOrdenesCarga

    Private mfile As BasesParaCompatibilidad.File
    Public Event cambio_sesion()

    Public Sub New()

        InitializeComponent()

        Me.mfile = New BasesParaCompatibilidad.File()
    End Sub
    Public Function get_menu() As MenuStrip

        Select Case Config.UserType
            Case 1
                System.Threading.Tasks.Parallel.Invoke()
                Me.frmArticulos1 = New frmArticulos1
                Return Me.MSAdministrador
            Case 4
                Me.frmMnLotes = New FrmLotesEnologicos
                Return Me.MSCalidad
            Case 9
                Me.frmMnLotes = New FrmLotesEnologicos
                Return Me.MSControl
            Case 5
                Me.frmArticulos1 = New frmArticulos1
                frmAlbaranesCargaMaestro = New frmAlbaranesCargaMaestro

                Return Me.MSAdministracion
            Case 6
                Return Me.MSMantenimiento
            Case 7
                Return Me.MSAlmacen
            Case 10
                Return Me.MSElaboracion
            Case 3
                EnvasadoToolStripMenuItem_Click(Nothing, Nothing)
                Return Me.MSEnvasado
            Case Else
                Return Nothing
        End Select

    End Function

    Private Sub tsmCambiarSesionBBDD_Click(sender As System.Object, e As System.EventArgs) Handles tsmCambiarSesionBBDD.Click, ToolStripMenuItem497.Click, ToolStripMenuItem839.Click, ToolStripMenuItem1181.Click, ToolStripMenuItem155.Click, ToolStripMenuItem326.Click, ToolStripMenuItem2.Click, ToolStripMenuItem1010.Click
        RaiseEvent cambio_sesion()
    End Sub

    Private Sub InformesAlmacenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InformesAlmacenToolStripMenuItem.Click, ToolStripMenuItem828.Click, ToolStripMenuItem486.Click, ToolStripMenuItem1170.Click, ToolStripMenuItem42.Click
        frmInformesAlmacen = New frmInformesAlmacen
        GUImain.añadirPestaña(frmInformesAlmacen)
    End Sub

    Private Sub tsmMantenimientoBBDDparametros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmParametrosBBDD.Click, ToolStripMenuItem901.Click, ToolStripMenuItem730.Click
        frmListaParametros = New frmListaParametros
        GUImain.añadirPestaña(frmListaParametros)
    End Sub

    Private Sub tsmManTiposLotesBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmManTiposLotesBBDD.Click, ToolStripMenuItem904.Click, ToolStripMenuItem733.Click
        frmTiposLotes = New frmTiposLotes
        GUImain.añadirPestaña(frmTiposLotes)
    End Sub

    Private Sub tsmTiposDeMaquinas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmTiposDeMaquinasBBDD.Click, ToolStripMenuItem742.Click, ToolStripMenuItem571.Click
        frmMaquinas = New frmMaquinas
        GUImain.añadirPestaña(frmMaquinas)
    End Sub

    Private Sub DepositosMantenimientoBBDDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem916.Click, ToolStripMenuItem745.Click, ToolStripMenuItem232.Click
        frmDepositos = New frmDepositos
        GUImain.añadirPestaña(frmDepositos)
    End Sub

    Private Sub MantenimientoBDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem938.Click, ToolStripMenuItem767.Click, LotesEnologicosToolStripMenuItem.Click
        frmLotesEnologico = New frmLotesEnologico
        GUImain.añadirPestaña(frmLotesEnologico)
    End Sub

    Private Sub MaterialConstruccionMantenimientoBBDDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem917.Click, ToolStripMenuItem746.Click, ToolStripMenuItem233.Click
        frmMaterialConstruccion = New frmMaterialConstruccion
        GUImain.añadirPestaña(frmMaterialConstruccion)
    End Sub

    Private Sub ProcesosMantenimientoBBDDToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmProcesos = New frmProcesos
        GUImain.añadirPestaña(frmProcesos)
    End Sub

    Private Sub ExistenciasPorDepositoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem920.Click, ToolStripMenuItem749.Click, ToolStripMenuItem236.Click, ToolStripMenuItem19.Click
        LisDepResumen = New LisDepResumen
        GUImain.añadirPestaña(LisDepResumen)
    End Sub

    Private Sub ExistenciasPorTipoVinagreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem921.Click, ToolStripMenuItem750.Click, ToolStripMenuItem237.Click, ToolStripMenuItem20.Click
        LisDepPorTipos = New LisDepPorTipos
        GUImain.añadirPestaña(LisDepPorTipos)
    End Sub

    Private Sub tsmUnidadesMedidasBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmUnidadesMedidasBBDD.Click, ToolStripMenuItem903.Click, ToolStripMenuItem732.Click
        frmUnidadesMedidas = New frmUnidadesMedidas
        GUImain.añadirPestaña(frmUnidadesMedidas)
    End Sub



    Private Sub tsmFomatosDeEnvasadosPorLineasBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFomatosDeEnvasadosPorLineasBBDD.Click, ToolStripMenuItem961.Click, ToolStripMenuItem790.Click
        frmTiposFormatosLineas = New frmTiposFormatosLineas
        GUImain.añadirPestaña(frmTiposFormatosLineas)
    End Sub


    Private Sub tsmOrdenesEnvasadoBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOrdenesEnvasadoBBDD.Click, ToolStripMenuItem860.Click, ToolStripMenuItem14.Click
        frmOrdenesEnvasado2 = New frmOrdenesEnvasado2
        GUImain.añadirPestaña(frmOrdenesEnvasado2)
    End Sub

    Private Sub tsmTiposDeMaterialesBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmTiposDeMaterialesBBDD.Click, ToolStripMenuItem798.Click, ToolStripMenuItem627.Click
        frmTiposMateriales = New frmTiposMateriales
        GUImain.añadirPestaña(frmTiposMateriales)
    End Sub

    Private Sub tsmMedidasProductosBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMedidasProductosBBDD.Click, ToolStripMenuItem906.Click, ToolStripMenuItem735.Click
        frmMedidasProductos = New frmMedidasProductos
        GUImain.añadirPestaña(frmMedidasProductos)
    End Sub

    Private Sub tsmTiposProductosBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmTiposProductosBBDD.Click, ToolStripMenuItem905.Click, ToolStripMenuItem734.Click
        frmTiposProductos = New frmTiposProductos
        GUImain.añadirPestaña(frmTiposProductos)
    End Sub

    Private Sub tsmMuestrasCantidadesBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMuestrasCantidadesBBDD.Click, ToolStripMenuItem907.Click, ToolStripMenuItem736.Click
        frmMuestrasCantidades = New frmMuestrasCantidades
        GUImain.añadirPestaña(frmMuestrasCantidades)
    End Sub

    Private Sub tsmMuestrasMedidasBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMuestrasMedidasBBDD.Click, ToolStripMenuItem908.Click, ToolStripMenuItem737.Click
        frmMuestrasMedidas = New frmMuestrasMedidas
        GUImain.añadirPestaña(frmMuestrasMedidas)
    End Sub

    Private Sub tsmLotesBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLotesBBDD.Click, ToolStripMenuItem900.Click, ToolStripMenuItem729.Click, ToolStripMenuItem1071.Click
        If frmMnLotes Is Nothing Then
            frmMnLotes = New FrmLotesEnologicos
        Else
            If frmMnLotes.IsDisposed Then
                frmMnLotes = New FrmLotesEnologicos
            End If
        End If
        
        GUImain.añadirPestaña(frmMnLotes)
    End Sub

    Private Sub tsmPaletsProducidosBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPaletsProducidosBBDD.Click, ToolStripMenuItem973.Click, ToolStripMenuItem802.Click, ToolStripMenuItem631.Click, ArticulosTerciariosPaletsToolStripMenuItem.Click
        frmPaletsProducidos3 = New frmPaletsProducidos3(0)
        GUImain.añadirPestaña(frmPaletsProducidos3)
    End Sub


    Private Sub tsmAlbaranDeCargaMaestroBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAlbaranDeCargaMaestroBBDD.Click, ToolStripMenuItem818.Click, ToolStripMenuItem476.Click, ToolStripMenuItem1160.Click, ToolStripMenuItem32.Click
        If frmAlbaranesCargaMaestro Is Nothing Then
            frmAlbaranesCargaMaestro = New frmAlbaranesCargaMaestro
        End If
        GUImain.añadirPestaña(frmAlbaranesCargaMaestro)
    End Sub

    Private Sub ExistenciasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciasToolStripMenuItem.Click, ToolStripMenuItem808.Click, ToolStripMenuItem466.Click, ToolStripMenuItem6.Click, ToolStripMenuItem22.Click
        frmExistenciasTodas = New frmExistenciasTodas
        GUImain.añadirPestaña(frmExistenciasTodas)
    End Sub

    Private Sub tsmAlmacenMovimientosBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAlmacenMovimientosBBDD.Click
        frmPaletsMovimientoEntrePalets = New frmPaletsMovimientoEntrePalets
        GUImain.añadirPestaña(frmPaletsMovimientoEntrePalets)
    End Sub

    Private Sub tsmSubTiposAlmacenMovimientosBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem472.Click
        frmPaletsMovimientoSubTipo = New frmPaletsMovimientoSubTipo()
        GUImain.añadirPestaña(frmPaletsMovimientoSubTipo)
    End Sub

    Private Sub tsmInformePaletBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmInformePaletBBDD.Click, ToolStripMenuItem819.Click, ToolStripMenuItem477.Click, ToolStripMenuItem1161.Click, ToolStripMenuItem33.Click
        InformeMovimientos = New InformeMovimientos
        GUImain.añadirPestaña(InformeMovimientos)
    End Sub

    Private Sub tsmPedidosClientesMaestrosBBDD_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPedidosClientesMaestrosBBDD.Click, ToolStripMenuItem949.Click, ToolStripMenuItem778.Click, ToolStripMenuItem436.Click, ToolStripMenuItem1120.Click
        frmPedidosClientesMaestros2 = New frmPedidosClientesMaestros2()
        GUImain.añadirPestaña(frmPedidosClientesMaestros2)
    End Sub

    Private Sub Pedidos1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pedidos1ToolStripMenuItem.Click, ToolStripMenuItem942.Click, ToolStripMenuItem771.Click, ToolStripMenuItem429.Click, ToolStripMenuItem1113.Click, PedidosToolStripMenuItem.Click
        frmPedidosProveedoresMaestros = New frmPedidosProveedoresMaestros()
        GUImain.añadirPestaña(frmPedidosProveedoresMaestros)
    End Sub

    Private Sub ListadoPedidosPendientesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoPedidosPendientesToolStripMenuItem1.Click, ToolStripMenuItem943.Click, ToolStripMenuItem772.Click, ToolStripMenuItem430.Click, ToolStripMenuItem1114.Click
        lstPedidosProveedoresPendientes = New lstPedidosProveedoresPendientes
        lstPedidosProveedoresPendientes.GenerarListado()
    End Sub

    Private Sub tsmPaletsTiposBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem473.Click
        frmPaletsTipos = New frmPaletsTipos
        GUImain.añadirPestaña(frmPaletsTipos)
    End Sub

    Private Sub tsmClientesBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmClientesBBDD.Click, ToolStripMenuItem948.Click, ToolStripMenuItem777.Click, ToolStripMenuItem1119.Click
        frmClientes = New frmClientes
        GUImain.añadirPestaña(frmClientes)
    End Sub

    Private Sub MovimientosEntreFechasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosEntreFechasToolStripMenuItem.Click
        frmStock = New frmStock
        GUImain.añadirPestaña(frmStock)
    End Sub

    Private Sub InformePedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformePedidosToolStripMenuItem.Click, ToolStripMenuItem950.Click, ToolStripMenuItem779.Click, ToolStripMenuItem437.Click, ToolStripMenuItem1121.Click
        frmInformePedidos = New frmInformePedidos
        GUImain.añadirPestaña(frmInformePedidos)
    End Sub
    Private Sub MovimientosEntreRecuentosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientosEntreRecuentosToolStripMenuItem.Click
        frmStock2 = New frmStock2
        GUImain.añadirPestaña(frmStock2)
    End Sub

    Private Sub tsmNecesidadesJRBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNecesidadesJRBBDD.Click, ToolStripMenuItem951.Click, ToolStripMenuItem780.Click, ToolStripMenuItem1122.Click
        frmCargaNecesidadesJRMaestro = New frmCargaNecesidadesJRMaestro
        GUImain.añadirPestaña(frmCargaNecesidadesJRMaestro)
    End Sub

    Private Sub tsmCamionesBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCamionesBBDD.Click, ToolStripMenuItem1002.Click, ToolStripMenuItem831.Click, ToolStripMenuItem489.Click
        frmCamiones = New frmCamiones
        GUImain.añadirPestaña(frmCamiones)
    End Sub

    Private Sub tsmAgenciasTranportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmAgenciasTranportes.Click, ToolStripMenuItem1003.Click, ToolStripMenuItem832.Click, ToolStripMenuItem490.Click
        frmAgenciasTransportes = New frmAgenciasTransportes
        GUImain.añadirPestaña(frmAgenciasTransportes)
    End Sub

    Private Sub tsmCamionesTipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCamionesTipos.Click, ToolStripMenuItem1004.Click, ToolStripMenuItem833.Click, ToolStripMenuItem491.Click
        frmCamionesTipos = New frmCamionesTipos
        GUImain.añadirPestaña(frmCamionesTipos)
    End Sub

    Private Sub tsmConductores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmConductores.Click, ToolStripMenuItem1176.Click, ToolStripMenuItem1005.Click, ToolStripMenuItem834.Click, ToolStripMenuItem492.Click
        frmConductores = New frmConductores
        GUImain.añadirPestaña(frmConductores)
    End Sub

    Private Sub ListadoPaletsIncompletosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoPaletsIncompletosToolStripMenuItem.Click, ToolStripMenuItem822.Click, ToolStripMenuItem480.Click, ToolStripMenuItem36.Click
        frmPaletsIncompletos = New frmPaletsIncompletos
        GUImain.añadirPestaña(frmPaletsIncompletos)
    End Sub

    Private Sub ListadoEntreFechasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoEntreFechasToolStripMenuItem.Click, ToolStripMenuItem972.Click, ToolStripMenuItem801.Click, ToolStripMenuItem630.Click
        frmLisEnvPorReferencia = New frmLisEnvPorReferencia
        GUImain.añadirPestaña(frmLisEnvPorReferencia)
    End Sub

    Private Sub tsmArticulosStocksBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmArticulosStocksBBDD.Click, ToolStripMenuItem969.Click
        frmArticulosMinMax = New frmArticulosMinMax
        GUImain.añadirPestaña(frmArticulosMinMax)
    End Sub

    Private Sub tsmLisAlbCarga_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoAlbaranesCargaToolStripMenuItem.Click, ToolStripMenuItem823.Click, ToolStripMenuItem481.Click, ToolStripMenuItem1165.Click, ToolStripMenuItem38.Click, ToolStripMenuItem37.Click
        frmLisAlbaranesCarga = New frmLisAlbaranesCarga
        GUImain.añadirPestaña(frmLisAlbaranesCarga)
    End Sub

    Private Sub tsmMetodosAnalisisBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmMetodosAnalisisBBDD.Click, ToolStripMenuItem894.Click, ToolStripMenuItem723.Click
        frmMetodosAnalisis = New frmMetodosAnalisis
        GUImain.añadirPestaña(frmMetodosAnalisis)
    End Sub

    Private Sub tsmEspecificacionesBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEspecificacionesBBDD.Click, ToolStripMenuItem892.Click, ToolStripMenuItem721.Click
        frmEspecificaciones = New frmEspecificaciones
        GUImain.añadirPestaña(frmEspecificaciones)
    End Sub

    Private Sub tsmRecipientasSalidasBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmRecipientasSalidasBBDD.Click, ToolStripMenuItem928.Click, ToolStripMenuItem757.Click, ToolStripMenuItem244.Click
        frmRecipientesSalidas = New frmRecipientesSalidas
        GUImain.añadirPestaña(frmRecipientesSalidas)
    End Sub

    Private Sub tsmCorredoresBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCorredoresBBDD.Click, ToolStripMenuItem937.Click, ToolStripMenuItem766.Click
        frmCorredores = New frmCorredores
        GUImain.añadirPestaña(frmCorredores)
    End Sub

    Private Sub tsmObjetivosMantBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmObjetivosMantBBDD.Click
        'Dim frm As New frmObjetivos
        'GUImain.añadirPestaña(frm)   
        MessageBox.Show("Pendiente de nueva generación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub tsmPendientesMantBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPendientesMantBBDD.Click, ToolStripMenuItem868.Click, ToolStripMenuItem697.Click
        frmPendientes = New frmPendientes
        GUImain.añadirPestaña(frmPendientes)
    End Sub

    Private Sub tsmSeguridadLaboralBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmSeguridadLaboralBBDD.Click, ToolStripMenuItem718.Click, ToolStripMenuItem1059.Click
        frmSaludLaboral = New frmSaludLaboral
        GUImain.añadirPestaña(frmSaludLaboral)
    End Sub

    Private Sub tsmOrganizacionBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmOrganizacionBBDD.Click, ToolStripMenuItem875.Click, ToolStripMenuItem704.Click, ToolStripMenuItem1046.Click
        frmOrganizacion = New frmOrganizacion
        GUImain.añadirPestaña(frmOrganizacion)
    End Sub

    Private Sub stmIdiomasBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stmIdiomasBBDD.Click, ToolStripMenuItem876.Click, ToolStripMenuItem705.Click
        frmIdiomas = New frmIdiomas
        GUImain.añadirPestaña(frmIdiomas)
    End Sub

    Private Sub tsmTurnosTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmTurnosTrabajo.Click
        frmTurnosTrabajo = New frmTurnosTrabajo
        GUImain.añadirPestaña(frmTurnosTrabajo)
    End Sub

    Private Sub tsmPedidosProveedoresEstadosBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click, ToolStripMenuItem4.Click, ToolStripMenuItem1.Click, EstadosDePedidosToolStripMenuItem.Click
        frmPedidosProveedoresEstados = New frmPedidosProveedoresEstados
        GUImain.añadirPestaña(frmPedidosProveedoresEstados)
    End Sub

    Private Sub tsmLugaresEntregaBBDD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmLugaresEntregaBBDD.Click, ToolStripMenuItem952.Click, ToolStripMenuItem781.Click, ToolStripMenuItem1123.Click
        frmLugaresEntregas = New frmLugaresEntregas
        GUImain.añadirPestaña(frmLugaresEntregas)
    End Sub

    Private Sub FichasCondicionesCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichasCondicionesCompraToolStripMenuItem.Click, ToolStripMenuItem946.Click, ToolStripMenuItem775.Click, ToolStripMenuItem1117.Click
        frmArticulosFichasCondiciones3 = New frmArticulosFichasCondiciones3
        GUImain.añadirPestaña(frmArticulosFichasCondiciones3)
    End Sub
    
    Private Sub FichasPaletizadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FichasPaletizadosToolStripMenuItem.Click, ToolStripMenuItem974.Click, ToolStripMenuItem803.Click, ToolStripMenuItem632.Click
        frmArticulosFichasPaletizados1 = New frmArticulosFichasPaletizados1
        GUImain.añadirPestaña(frmArticulosFichasPaletizados1)
    End Sub

    Private Sub TiposArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposArticulosToolStripMenuItem.Click, ToolStripMenuItem877.Click, ToolStripMenuItem706.Click, ToolStripMenuItem1048.Click
        frmArticulosTipos = New frmArticulosTipos
        GUImain.añadirPestaña(frmArticulosTipos)
    End Sub

    Private Sub ArticulosMateriasPrimasTiposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosMateriasPrimasTiposToolStripMenuItem.Click
        frmArticulosMateriasPrimasTipos = New frmArticulosMateriasPrimasTipos
        GUImain.añadirPestaña(frmArticulosMateriasPrimasTipos)
    End Sub

    Private Sub ArticulosIngredientesTiposToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArticulosIngredientesTiposToolStripMenuItem.Click
        frmArticulosIngredientesTipos = New frmArticulosIngredientesTipos
        GUImain.añadirPestaña(frmArticulosIngredientesTipos)
    End Sub

    Private Sub PlanesGeneralesHigieneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlanesGeneralesHigieneToolStripMenuItem.Click, ToolStripMenuItem719.Click, ToolStripMenuItem1061.Click
        PlanesGeneralesHigiene = New PlanesGeneralesHigiene
        GUImain.añadirPestaña(PlanesGeneralesHigiene)
    End Sub

    Private Sub mnuOrdenesCarga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOrdenesCarga.Click, ToolStripMenuItem825.Click, ToolStripMenuItem483.Click, ToolStripMenuItem39.Click
        frmOrdenesCarga = New frmOrdenesCarga
        GUImain.añadirPestaña(frmOrdenesCarga)
    End Sub

    Private Sub tsmArticulos1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmArticulos1.Click, ToolStripMenuItem536.Click, ToolStripMenuItem878.Click, ToolStripMenuItem707.Click, ToolStripMenuItem1049.Click
        If frmArticulos1 Is Nothing Then
            frmArticulos1 = New frmArticulos1
        Else
            If frmArticulos1.IsDisposed Then
                frmArticulos1 = New frmArticulos1
            End If
        End If
        GUImain.añadirPestaña(frmArticulos1)
    End Sub

    Private Sub tsmArticulosEtiquetasTipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmArticulosEtiquetasTipos.Click
        frmArticulosEtiquetasTipos = New frmArticulosEtiquetasTipos
        GUImain.añadirPestaña(frmArticulosEtiquetasTipos)
    End Sub

    Private Sub tsmEntradaMovimientosEntrePalets_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEntradaMovimientosEntrePalets.Click, ToolStripMenuItem816.Click, ToolStripMenuItem474.Click, ToolStripMenuItem30.Click
        frmPaletsMovimientoEntrePalets = New frmPaletsMovimientoEntrePalets
        GUImain.añadirPestaña(frmPaletsMovimientoEntrePalets)
    End Sub

    Private Sub EnvasadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnvasadoToolStripMenuItem.Click, ToolStripMenuItem1129.Click, ToolStripMenuItem103.Click, ToolStripMenuItem958.Click, ToolStripMenuItem787.Click, ToolStripMenuItem616.Click, EnvasadoDiarioToolStripMenuItem.Click
        frmEnvasados2 = New frmEnvasados2
        GUImain.añadirPestaña(frmEnvasados2)
    End Sub

    Private Sub tsmPaletsNoAlmacenNoTerminadoBBDD_Click(sender As System.Object, e As System.EventArgs) Handles tsmPaletsNoAlmacenNoTerminadoBBDD.Click, ToolStripMenuItem824.Click, ToolStripMenuItem482.Click
        PaletNoAlmacenNoTerminado = New PaletNoAlmacenNoTerminado
        GUImain.añadirPestaña(PaletNoAlmacenNoTerminado)
    End Sub

    Private Sub tsmNecesidadesMaterialesBBDD_Click(sender As System.Object, e As System.EventArgs) Handles tsmNecesidadesMaterialesBBDD.Click, ToolStripMenuItem953.Click, ToolStripMenuItem782.Click, ToolStripMenuItem440.Click, ToolStripMenuItem1124.Click
        frmPedidosClientesNecesidades = New frmPedidosClientesNecesidades
        GUImain.añadirPestaña(frmPedidosClientesNecesidades)
    End Sub

    Private Sub tsmOrdenesCargaLA_Click(sender As System.Object, e As System.EventArgs) Handles tsmOrdenesCargaLA.Click, ToolStripMenuItem807.Click, ToolStripMenuItem465.Click, ToolStripMenuItem21.Click
        frmOrdenesCargaInforme = New frmOrdenesCargaInforme
        GUImain.añadirPestaña(frmOrdenesCargaInforme)
    End Sub

    Private Sub BoletinesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoletinesToolStripMenuItem.Click, ToolStripMenuItem909.Click, ToolStripMenuItem738.Click
        frmGeneradorBoletines = New frmGeneradorBoletines
        GUImain.añadirPestaña(frmGeneradorBoletines)
    End Sub

    Private Sub tsmArticulosPrimariosEntreFechas_Click(sender As System.Object, e As System.EventArgs) Handles tsmArticulosPrimariosEntreFechas.Click, ToolStripMenuItem971.Click, ToolStripMenuItem800.Click, ToolStripMenuItem629.Click
        frmLisEnvPorArticuloPrimario = New frmLisEnvPorArticuloPrimario
        GUImain.añadirPestaña(frmLisEnvPorArticuloPrimario)
    End Sub

    Private Sub tsmExcelVentas_Click(sender As System.Object, e As System.EventArgs) Handles tsmExcelVentas.Click, ToolStripMenuItem954.Click, ToolStripMenuItem783.Click, ToolStripMenuItem1125.Click

        mfile.open("Z:\Comercial\Estadisticas\Ventas 2002 a la actualidad.xls")
    End Sub

    Private Sub tsmResumenFacturasMensuales_Click(sender As System.Object, e As System.EventArgs) Handles tsmResumenFacturasMensuales.Click, ToolStripMenuItem886.Click, ToolStripMenuItem715.Click

        mfile.open("Z:\Compras\Proveedores\Control facturas periódicas.xls")
    End Sub

    Private Sub tsmVacacionesPersonal_Click(sender As System.Object, e As System.EventArgs) Handles tsmVacacionesPersonal.Click, ToolStripMenuItem887.Click, ToolStripMenuItem716.Click, ToolStripMenuItem1058.Click

        Dim agno As Integer = Now.Date.Year
        agno = (Convert.ToDouble(agno / 100) - Convert.ToInt32(agno / 100)) * 100
        mfile.open("Z:\Recursos Humanos\Vacaciones\2.0" & agno & "\Vacaciones 20" & agno & ".xls")
    End Sub

    Private Sub TiposDeParametrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeParametrosToolStripMenuItem.Click, ToolStripMenuItem731.Click
        frmParametrosTipos = New frmParametrosTipos
        GUImain.añadirPestaña(frmParametrosTipos)
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresasToolStripMenuItem.Click, ToolStripMenuItem910.Click, ToolStripMenuItem739.Click
        frmempresas = New frmempresas
        GUImain.añadirPestaña(frmempresas)
    End Sub

    Private Sub MantenimientoBoletinesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MantenimientoBoletinesToolStripMenuItem.Click, ToolStripMenuItem911.Click, ToolStripMenuItem740.Click
        frmplantillasBoletines = New frmplantillasBoletines
        GUImain.añadirPestaña(frmplantillasBoletines)
    End Sub

    Private Sub ImportarVentasMensualesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarVentasMensualesToolStripMenuItem.Click, ToolStripMenuItem955.Click, ToolStripMenuItem784.Click, ToolStripMenuItem1126.Click
        frmImportarExcel = New frmImportarExcel
        GUImain.añadirPestaña(frmImportarExcel)
    End Sub

    Private Sub LegislacionProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LegislacionProductosToolStripMenuItem.Click, ToolStripMenuItem893.Click, ToolStripMenuItem722.Click
        frmEspecificacionesLegales = New frmEspecificacionesLegales
        GUImain.añadirPestaña(frmEspecificacionesLegales)
    End Sub

    Private Sub MarcasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasToolStripMenuItem.Click, ToolStripMenuItem956.Click, ToolStripMenuItem785.Click, ToolStripMenuItem1127.Click
        frmmarcas = New frmmarcas
        GUImain.añadirPestaña(frmmarcas)
    End Sub

    Private Sub IncidenciasDeRecuentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncidenciasDeRecuentoToolStripMenuItem.Click, ToolStripMenuItem975.Click, ToolStripMenuItem804.Click, ToolStripMenuItem633.Click
        frmIncidenciasRecuento = New frmIncidenciasRecuento
        GUImain.añadirPestaña(frmIncidenciasRecuento)
    End Sub

    Private Sub IncidenciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IncidenciasToolStripMenuItem.Click, IncidenciasToolStripMenuItem3.Click, IncidenciasToolStripMenuItem2.Click
        frmIncidenciasCalidadMain = New frmIncidenciasCalidadMain
        GUImain.añadirPestaña(frmIncidenciasCalidadMain)
    End Sub



    Private Sub ChequeoProducciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChequeoProducciónToolStripMenuItem.Click, ChequeoProducciónToolStripMenuItem1.Click, ChequeoProducciónToolStripMenuItem2.Click
        checks = New checks
        GUImain.añadirPestaña(checks)
    End Sub

    Private Sub RecuentosExistenciaMaterialToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecuentosExistenciaMaterialToolStripMenuItem.Click, RecuentoMaterialAuxiliarToolStripMenuItem.Click, ToolStripMenuItem43.Click
        frmRecuentoMaterialesAuxiliares = New frmRecuentoMaterialesAuxiliares
        GUImain.añadirPestaña(frmRecuentoMaterialesAuxiliares)
    End Sub

    Private Sub SituacionActualPersonalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SituacionActualPersonalToolStripMenuItem.Click
        frmSituacionPersonal = New frmSituacionPersonal
        GUImain.añadirPestaña(frmSituacionPersonal)
    End Sub

    Private Sub TareasDiariasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TareasDiariasToolStripMenuItem.Click, TareasDiariasToolStripMenuItem2.Click, TareasDiariasToolStripMenuItem1.Click
        frmPartesTrabajosDiariosMaestros = New frmPartesTrabajosDiariosMaestros
        GUImain.añadirPestaña(frmPartesTrabajosDiariosMaestros)
    End Sub

    Private Sub InformeEntreFechasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InformeEntreFechasToolStripMenuItem.Click, InformeEntreFechasToolStripMenuItem1.Click, InformeEnterFechasToolStripMenuItem.Click
        Dim esp As New BasesParaCompatibilidad.frmEspera("Generando informe. Espere unso segundos")
        esp.Show()

        Try
            InformesVinagreJerez1 = New InformesVinagreJerez.Form1(BasesParaCompatibilidad.Config.connectionString)
            InformesVinagreJerez1.Text = "Informe vinagre entre fechas"
            GUImain.añadirPestaña(InformesVinagreJerez1)
        Catch ex As Exception
        Finally
            esp.Close()
        End Try
    End Sub

    Private Sub ControlesLotesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ControlesLotesToolStripMenuItem.Click, ControlesLotesToolStripMenuItem2.Click, ControlesLotesToolStripMenuItem1.Click
        frmTiposControlesLotesPlantilla = New frmTiposControlesLotesPlantilla
        GUImain.añadirPestaña(frmTiposControlesLotesPlantilla)
    End Sub

    Private Sub ToolStripMenuItem15_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripMenuItem15.Click
        frmcabecerasEtiquetas = New frmcabecerasEtiquetas
        GUImain.añadirPestaña(frmcabecerasEtiquetas)
    End Sub

    Private Sub TiposEnvasasesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TiposEnvasasesToolStripMenuItem.Click
        frmtiposEnvases = New frmtiposEnvases
        GUImain.añadirPestaña(frmtiposEnvases)
    End Sub
   
    Private Sub ComunicacionesInternasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComunicacionesInternasToolStripMenuItem.Click, ComunicacionesInternasToolStripMenuItem1.Click, ComunicacionesInternasToolStripMenuItem2.Click
        frmCom = New frmCom
        GUImain.añadirPestaña(frmCom)
    End Sub

    Private Sub ListadoPorFechaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        frmExistenciasPorDepositoFecha = New InformesDepositos.frmExistenciasPorDepositoFecha(BasesParaCompatibilidad.Config.connectionString)
        GUImain.añadirPestaña(frmExistenciasPorDepositoFecha)
    End Sub

    Private Sub tsmProveedores_Click(sender As Object, e As EventArgs) Handles tsmProveedores.Click, ToolStripMenuItem930.Click, ToolStripMenuItem759.Click, ToolStripMenuItem1101.Click
        frmProveedoresMain = New frmProveedoresMain
        GUImain.añadirPestaña(frmProveedoresMain)
    End Sub

    Private Sub VisitasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitasToolStripMenuItem.Click, ToolStripMenuItem879.Click, ToolStripMenuItem708.Click, ToolStripMenuItem1050.Click
        frmVisitasMain = New frmVisitasMain
        GUImain.añadirPestaña(frmVisitasMain)
    End Sub
  
    Private Sub DepositosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DepositosToolStripMenuItem1.Click
        frmDepositosMain = New frmDepositosMain
        GUImain.añadirPestaña(frmDepositosMain)
    End Sub




    Private Sub InformeResumenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeResumenToolStripMenuItem.Click, InformeResumenToolStripMenuItem2.Click, InformeResumenToolStripMenuItem1.Click
        Dim frm As New InformeResumenVinagre.SelectorFecha(BasesParaCompatibilidad.Config.connectionString)
        frm.ShowDialog()
    End Sub
End Class