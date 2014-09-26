Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmSelectorAsistente

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        iniciar()
    End Sub

    Private Sub iniciar()
        Select Case Me.cboArticulo.SelectedValue
            Case Is = 1 'Materias primas
                Dim frm As New frmAsistenteMateriasPrimas
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

            Case Is = 4 'Graneles
                Dim frm As New frmAsistenteGraneles
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

            Case Is = 6 'Ingredientes
                Dim frm As New frmAsistenteIngredientes
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)


            Case Is = 57 'IngredientesIDI
                Dim frm As New frmAsistenteIngredientes(True)
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)


                'Case Is = 7 'Plantas
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpfichasTecnicas"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasCondiciones"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpFichasSeguridad"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpImagen"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpProveedores"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpPedidos"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpDocumentacion"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpLegislacion"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpProductos"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpNoConformidades"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpEvolucionPrecios"))
                '    '''TabControl1.Controls.Remove(TabControl1.TabPages("tbpGestionesCompra"))

                '    '''Dim m_TablaAux As New DBO_ArticulosIngredientes
                '    '''m_TablaAux = spArticulosIngredientes.Select_RecordByArticuloID(m_DBO_Articulos1.ArticuloID)
                '    ''m_FormAux = New frmArtPlantasInicial
                '    ''RellenarFormAuxiliar(m_FormAux)
                '    ''formPlantas = m_FormAux
                '    ''Me.lDatosAux.Text = "Rellenar datos de Plantas"


            Case Is = 8
                Dim frm As New frmAsistenteMonodosis(Me.cboArticulo.SelectedValue)
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

            Case Is = 9 'Envases secundarios (cajas)
                Dim frm As New frmAsistenteArticulosEnvasados()
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

            Case Is = 10 'Envases terciarios (palets)
                Dim frm As New frmAsistenteArticulosEnvasados()
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

                'Case Is = 26 'Etiquetas
                '    Dim frm As New frmAsistenteEtiquetas()
                '    BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                '    '''Dim m_TablaAux As New DBO_ArticulosIngredientes
                '    '''m_TablaAux = spArticulosIngredientes.Select_RecordByArticuloID(m_DBO_Articulos1.ArticuloID)
                '    ''m_FormAux = New frmArtEtiquetasInicial
                '    ''RellenarFormAuxiliar(m_FormAux)
                '    ''formEtiquetas = m_FormAux
            Case Else
                Dim frm As New frmAsistenteArticuloSimple(Me.cboArticulo.SelectedValue)
                BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
                'Case Is = 8 'Envases primarios (botellas o botes)
                'Case Is = 11 'Repuestos
                'Case Is = 12 'Laboratorio
                'Case Is = 13 'Desinfeccion, desissectacion y desratizacion
                'Case Is = 14 'Limpieza
                'Case Is = 15 'Vestuario
                'Case Is = 16 'Material oficina
                'Case Is = 17 'Pinturas
                'Case Is = 18 'servicios
                'Case Is = 19 'Lubricantes
                'Case Is = 20 'Auxiliares almacen
                'Case Is = 21 'Herramientas
                'Case Is = 22 'EPIs
                'Case Is = 23 'Envasados sin etiquetar
                'Case Is = 24 'componentes instalaciones
                'Case Is = 25 'Equipos o maquinas            
                'Case Is = 28 'Cajas B1
                'Case Is = 30 'Fims enfajadora
                'Case Is = 31 'Envases subprimarios
                'Case Is = 32 'Palets
                'Case Is = 33 'Material informatica
                'Case Is = 34 'tintas y disolventes marcadores
                'Case Is = 35 'Transfer marcadores
                'Case Is = 36 'Cierres
                'Case Is = 37 'botellas cristal
                'Case Is = 38 'botes plastico
                'Case Is = 39 'Capsulas retractiles
                'Case Is = 40 'Placas filtro
                'Case Is = 41 'analiticas externas
                'Case Is = 42 'Pack-Master
                'Case Is = 43 'Films monodosis
                'Case Is = 44 'Separadores cajas
                'Case Is = 45 'Colas
                'Case Is = 46 'Precintos adhesivos
                'Case Is = 47 'Envases graneles
                'Case Is = 48 'Reparaciones
                'Case Is = 49 'Planchas etqieutas
                'Case Is = 50 'Coadyuvante tecnologico
                'Case Is = 51 'Transporte               
                'Case Is = 52 'Auxiliares elaboracion
                'Case Is = 53 'Cuotas periodicas Organismos Oficiales
                'Case Is = 56 'ETT

        End Select
    End Sub

    Private Sub frmSelectorAsistente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.cboArticulo.mam_DataSource("Articulos1_ArticulosTiposCbo", False)
    End Sub

    Private Sub frmSelectorAsistente_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = 13 Then
            Me.btnNext.Focus()
            iniciar()
        ElseIf e.KeyCode = 27 Then
            Me.Close()
        End If
    End Sub


End Class