Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmModDetExtras
    Private ArticuloTipo As Integer
    Private ArticuloId As Integer
    Private frmArticulosFichasTecnicas As frmArticulosFichasTecnicas
    Private frmArticulosFichasCondiciones3 As frmArticulosFichasCondiciones3
    Private frmArticulosDocumentos As frmArticulosDocumentos
    'Private frmProveedores As frmProveedores
    Private frmProveedores_Articulos As frmProveedores_Articulos
    Private frmComposicion As frmArticulos1CompuestoPor
    Private frmComposicionGraneles As frmArticulosGranelescompuestoPor
    Public Event actualizarDatos()
    Public Event CambioPestaña(nombre As String, indice As Integer)
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal articuloId As Integer, ByVal articulotipo As Integer)
        InitializeComponent()

        Me.ArticuloId = articuloId
        Me.ArticuloTipo = articulotipo
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)

        crearPestañas()
        administrarPestañas()
    End Sub

    Private Sub DatosActualizados()
        RaiseEvent actualizarDatos()
    End Sub

    Public Sub refrescar()
        crearPestañas()
    End Sub

    Private Sub VerIngredientes()
        Me.frmComposicion = New frmArticulos1CompuestoPor(ArticuloId)
        AddHandler frmComposicion.actualizarDatos, AddressOf DatosActualizados
        Engine_LA.FormEnPestaña(frmComposicion, panComposicion)
        frmComposicion.Dock = DockStyle.Fill

        Me.TimerAutorizacion.Enabled = True
        Me.TimerAutorizacion.Start()
    End Sub

    Private Sub VerIngredientesGraneles()
        Me.frmComposicionGraneles = New frmArticulosGranelescompuestoPor(ArticuloId)
        Engine_LA.FormEnPestaña(frmComposicionGraneles, panComposicion)
        frmComposicionGraneles.Dock = DockStyle.Fill

        Me.TimerAutorizacion.Enabled = True
        Me.TimerAutorizacion.Start()
    End Sub

    Private Sub AbortarVerIngredientes()
        panComposicion.Visible = False
    End Sub

    Private Sub crearPestañas()
        Dim frm As frmAutorizacion = Nothing

        For Each us As Integer In Config.UsuariosProductos
            If us = BasesParaCompatibilidad.Config.User Then
                frm = New frmAutorizacion

                If Not ArticuloTipo = 4 Then ' graneles
                    AddHandler frm.verificado, AddressOf VerIngredientes
                    AddHandler frm.cancelado, AddressOf AbortarVerIngredientes
                Else
                    AddHandler frm.verificado, AddressOf VerIngredientesGraneles
                    AddHandler frm.cancelado, AddressOf AbortarVerIngredientes
                End If

                Engine_LA.FormEnPestaña(frm, panComposicion)

            End If
        Next

        If frm Is Nothing Then
            AbortarVerIngredientes()
        End If

        Me.frmArticulosFichasTecnicas = New frmArticulosFichasTecnicas(ArticuloId)
        frmArticulosFichasTecnicas.Embebido = True
        Engine_LA.FormEnPestaña(frmArticulosFichasTecnicas, tbpFichasTecnicas)
        frmArticulosFichasTecnicas.Dock = DockStyle.Fill

        Me.frmArticulosFichasCondiciones3 = New frmArticulosFichasCondiciones3(ArticuloId)
        frmArticulosFichasCondiciones3.Embebido = True
        Engine_LA.FormEnPestaña(frmArticulosFichasCondiciones3, tbpFichasCondiciones)
        frmArticulosFichasCondiciones3.Dock = DockStyle.Fill

        Me.frmArticulosDocumentos = New frmArticulosDocumentos(ArticuloId)
        Engine_LA.FormEnPestaña(frmArticulosDocumentos, tbpDocumentacion)
        frmArticulosDocumentos.Embebido = True
        frmArticulosDocumentos.Dock = DockStyle.Fill

        Me.frmProveedores_Articulos = New frmProveedores_Articulos(0, ArticuloId)
        Engine_LA.FormEnPestaña(Me.frmProveedores_Articulos, tbpProveedores)
        dtb.PrepararConsulta("PedidosProveedoresDetallesSelectByArticuloID @id")
        dtb.AñadirParametroConsulta("@id", ArticuloId)
        Dim dt As DataTable = dtb.Consultar

        If Not dt Is Nothing Then
            With dgvPedidos
                .Width = 1048
                .Visible = True
                .DataSource = dt
                .Columns("PedidoProveedorMaestroID").Visible = False
                .FormatoColumna("Numero", "Num", BasesParaCompatibilidad.TiposColumna.Miles, 36)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Proveedor, 250)
                .FormatoColumna("FechaEmision", "Emision", BasesParaCompatibilidad.TiposColumna.FechaCorta, 70)
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 70)
                .FormatoColumna("Medida", BasesParaCompatibilidad.TiposColumna.Izquierda, 90)
                .FormatoColumna("Estado", BasesParaCompatibilidad.TiposColumna.Izquierda, 90)
                .FormatoColumna("Recibido", BasesParaCompatibilidad.TiposColumna.Miles, 70)
                .FormatoColumna("Pendiente", BasesParaCompatibilidad.TiposColumna.Miles, 70)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 460)
                .FormatoGeneral()
                .MoveLast()
            End With
        End If
    End Sub

    Private Sub administrarPestañas()
        Select Case Me.ArticuloTipo
            Case Is = 1 'Materias primas               

            Case Is = 4 'Graneles                
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))
                'TabControl1.TabPages("tbpImagen").Hide() NO FUNCIONA

            Case Is = 6 'Ingredientes
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))

            Case Is = 57 'IngredientesIDI
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))

            Case Is = 7 'Plantas
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpfichasTecnicas"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasCondiciones"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasSeguridad"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpProveedores"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpPedidos"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpDocumentacion"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpLegislacion"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpProductos"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpRetenidos"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpEvolucionPrecios"))
                'TabControl1.Controls.Remove(TabControl1.TabPages("tbpGestionesCompra"))

            Case Is = 9 'Envases secundarios (cajas)
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpfichasTecnicas"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasCondiciones"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasSeguridad"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpProveedores"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpPedidos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpLegislacion"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpProductos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpEvolucionPrecios"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpGestionesCompra"))

            Case Is = 10 'Envases terciarios (palets)
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpfichasTecnicas"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasCondiciones"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasSeguridad"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpProveedores"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpPedidos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpLegislacion"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpProductos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpNoConformidades"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpRetenidos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpEvolucionPrecios"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpGestionesCompra"))

            Case Is = 11 'Repuestos

            Case Is = 12 'Laboratorio

            Case Is = 13 'Desinfeccion, desissectacion y desratizacion

            Case Is = 14 'Limpieza

            Case Is = 15 'Vestuario

            Case Is = 16 'Material oficina

            Case Is = 17 'Pinturas

            Case Is = 18 'servicios

            Case Is = 19 'Lubricantes

            Case Is = 20 'Auxiliares almacen

            Case Is = 21 'Herramientas

            Case Is = 22 'EPIs

            Case Is = 23 'Envasados sin etiquetar

            Case Is = 24 'componentes instalaciones

            Case Is = 25 'Equipos o maquinas

            Case Is = 26 'Etiquetas         

            Case Is = 28 'Cajas B1

            Case Is = 30 'Fims enfajadora

            Case Is = 31 'Envases subprimarios

            Case Is = 32 'Palets

            Case Is = 33 'Material informatica

            Case Is = 34 'tintas y disolventes marcadores

            Case Is = 35 'Transfer marcadores

            Case Is = 36 'Cierres

            Case Is = 37 'botellas cristal

            Case Is = 38 'botes plastico

            Case Is = 39 'Capsulas retractiles

            Case Is = 40 'Placas filtro

            Case Is = 41 'analiticas externas

            Case Is = 42 'Pack-Master

            Case Is = 43 'Films monodosis

            Case Is = 44 'Separadores cajas

            Case Is = 45 'Colas

            Case Is = 46 'Precintos adhesivos

            Case Is = 47 'Envases graneles

            Case Is = 48 'Reparaciones

            Case Is = 49 'Planchas etqieutas

            Case Is = 50 'Coadyuvante tecnologico

            Case Is = 51 'Transporte
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpfichasTecnicas"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasSeguridad"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpPedidos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpStocks"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpDocumentacion"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpLegislacion"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpProductos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpNoConformidades"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpRetenidos"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpEvolucionPrecios"))
                TabControl1.Controls.Remove(TabControl1.TabPages("tbpGestionesCompra"))

            Case Is = 52 'Auxiliares elaboracion

            Case Is = 53 'Cuotas periodicas Organismos Oficiales

            Case Is = 56 'ETT

        End Select
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        RaiseEvent CambioPestaña(TabControl1.SelectedTab.Name.ToString, TabControl1.SelectedIndex)
    End Sub

    Private Sub TimerAutorizacion_Tick(sender As System.Object, e As System.EventArgs) Handles TimerAutorizacion.Tick
        Me.panComposicion.Visible = True
        Dim frm As New frmAutorizacion
        Engine_LA.FormEnPestaña(frm, panComposicion)

        If Not ArticuloTipo = 4 Then ' graneles
            AddHandler frm.verificado, AddressOf VerIngredientes
            AddHandler frm.cancelado, AddressOf AbortarVerIngredientes
        Else
            AddHandler frm.verificado, AddressOf VerIngredientesGraneles
            AddHandler frm.cancelado, AddressOf AbortarVerIngredientes
        End If

        Me.TimerAutorizacion.Stop()
        Me.TimerAutorizacion.Enabled = False
    End Sub


End Class