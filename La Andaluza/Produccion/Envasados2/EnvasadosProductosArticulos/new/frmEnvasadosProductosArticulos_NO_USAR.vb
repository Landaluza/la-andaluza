Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEnvasadosProductosArticulos_NO_USAR
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Private m_Producto As Integer
    Private m_Descripcion As String
    Private m_CantidadEnvasada As Integer
    Private m_TotalCantidadAsignada As Integer = 0
    Private m_DBO_Envasado As DBO_Envasados2
    Private m_DBO_LoteTerminado As DBO_Lotes1
    Private m_DBO_LoteEnvasado As New DBO_Lotes1
    Private m_DBO_CompuestoPor As New DBO_CompuestoPor
    Private padre As frmEntFormatosEnvasados2
    Private m_dbo_diferencias As DBO_Lotes1
    Private spTiposProductos As New spTiposProductos
    Private spLotes1 As spLotes1
    Private spMovimientos1 As spMovimientos1
    Private spCompuestoPor As spCompuestoPor
    Private spEnvasados2 As spEnvasados2
    'Dim ctlTipPro As New ctlTiposProductos
    Private frmEnt As frmEntEnvasadosProductosArticulos

    Public Sub New(ByVal MaestroID As Integer, ByVal Producto As Integer, ByVal Descripcion As String, ByVal CantidadEnvasada As Integer, Optional ByVal embebido As Boolean = False, Optional ByVal padre As frmEntFormatosEnvasados2 = Nothing)
        MyBase.New(New spEnvasadosProductosArticulos, MaestroID)
        InitializeComponent()
        Me.Embebido = embebido
        Me.padre = padre
        spSelectDgv = "EnvasadosProductosArticulosSelectDgvByFormatoEnvasadoID '" & MaestroID & "'"
        spLotes1 = New spLotes1
        spMovimientos1 = New spMovimientos1
        spCompuestoPor = New spCompuestoPor
        spEnvasados2 = New spEnvasados2

        m_Producto = Producto
        m_Descripcion = Descripcion
        m_CantidadEnvasada = CantidadEnvasada
        m_DBO_Envasado = DBO_Envasados2.Instance
        m_dbo_diferencias = New DBO_Lotes1
        Me.butModificar.Visible = False
        Me.butModificar.Enabled = False
        dgvGeneral.Visible = False
    End Sub

    Private Sub frmEnvasadosProductosArticulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.m_Descripcion Is Nothing Then

            butExcel.Visible = True
            txtCantidadEnvasada.Text = m_CantidadEnvasada

            'Hay que saber si se trata de monodosis
            If m_Descripcion.StartsWith("DoyPack") Then
                gpbMonodosis.Visible = True
                butNuevo.Visible = False
                gpbCantidades.Visible = False
            End If

            filterManager = New DgvFilterPopup.DgvFilterManager(dgvGrilla)
            ''''dgvFill()
        End If
    End Sub

    Overrides Sub Eliminar()
        If Me.dgvGrilla.RowCount > 0 Then
            If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If CType(sp, spEnvasadosProductosArticulos).EnvasadosProductosArticulosDelete(dgvGrilla.CurrentRow.Cells("EnvasadoProductoArticuloID").Value) Then
                    dgvFill()
                Else
                    MessageBox.Show("No se pudo eliminar el registro", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Overrides Sub ToExcel()
        Dim mse As New BasesParaCompatibilidad.MicrosoftOfficeExporter
        mse.ExportToExcel("Many", Me.Text, dgvGrilla)
    End Sub

    Overrides Sub ToWord()
        Dim mse As New BasesParaCompatibilidad.MicrosoftOfficeExporter
        mse.ExportToWord("Many", Me.Text, dgvGrilla)
    End Sub

    Overrides Sub Action(ByVal TipoAction As String)
        If TipoAction <> ACCION_MODIFICAR Then
            If Me.txtCantidadRestante.Text = 0 Then
                MessageBox.Show("No queda cantidad restante", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If spLotes1.CountLotesTerminadosPorTipoProducto(m_Producto) = 0 Then
                MessageBox.Show("No hay lotes terminados para envasar", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim m_DBO_EnvasadoProductoArticulo As New DBO_EnvasadosProductosArticulos

            If m_MaestroID <> 0 Then m_DBO_EnvasadoProductoArticulo.FormatoEnvasadoID = m_MaestroID


            'Pasar la fecha y la cantidad para poder hacer el movimiento de envasado.
            frmEnt = New frmEntEnvasadosProductosArticulos(TipoAction, m_DBO_EnvasadoProductoArticulo, m_Producto, m_CantidadEnvasada, m_TotalCantidadAsignada)
            'frmEnt.Text = String.Format("{0} {1}", TipoAction, Titulo)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)


            dgvFill()

        End If
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        Me.Cursor = Cursors.WaitCursor
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            'If keepReg Then Me.dgvGrilla.guardarColumnaSeleccionada()
            GeneralBindingSource.DataSource = dtb.Consultar(spSelectDgv, True)


            With dgvGrilla
                .DataSource = GeneralBindingSource

                .Columns("EnvasadoProductoArticuloID").Visible = False
                .Columns("LoteID").Visible = False
                .Columns("FormatoEnvasadoID").Visible = False
                .FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Lote, 100)
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, 70)
                .FormatoColumna("Merma", BasesParaCompatibilidad.TiposColumna.Miles, 70)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral()
            End With
            dgvGrilla.Refresh()

            BindingNavigatorCortoActualizar(dgvGrilla.RowCount)
            butSalir.Visible = False
            butImprimir.Visible = If(dgvGrilla.RowCount > 0, True, False)
            butGenerarTrasiegos.Visible = If(dgvGrilla.RowCount > 0, True, False)

            If dgvGrilla.RowCount > 0 Then
                butGenerarTrasiegos.Visible = True
            Else
                butGenerarTrasiegos.Visible = False
            End If

            m_TotalCantidadAsignada = 0

            For Each row As DataGridViewRow In dgvGrilla.Rows
                m_TotalCantidadAsignada += (row.Cells("Cantidad").Value)
            Next
            txtCantidadAsignada.Text = m_TotalCantidadAsignada
            txtCantidadRestante.Text = m_CantidadEnvasada - m_TotalCantidadAsignada

            If Convert.ToInt32(txtCantidadRestante.Text) < 1 Then
                butGenerarTrasiegos.Visible = True
            Else
                butGenerarTrasiegos.Visible = False
            End If
        End If
        'If keepReg Then Me.dgvGrilla.recuperarColumnaSeleccionada()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub dgvGrilla_RowStateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles dgvGrilla.RowStateChanged
        dgvGrilla.FormatoGeneral()
    End Sub

    Private Sub butGenerarTrasiegos_Click(sender As System.Object, e As System.EventArgs) Handles butGenerarTrasiegos.Click
        Dim Respuesta As DialogResult
        Dim guardado As Boolean = True
        Dim contador As Integer = 1

        Respuesta = MessageBox.Show("¿Estas seguro de que quieres generar los movimientos y lotes? ", _
                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Respuesta = DialogResult.Yes Then
            dtb.EmpezarTransaccion()
            BasesParaCompatibilidad.BD.Cnx = dtb.Conexion
            BasesParaCompatibilidad.transaction = dtb.Transaccion

            Try
                Dim calendar As New BasesParaCompatibilidad.Calendar

                For Each row As DataGridViewRow In dgvGrilla.Rows
                    m_DBO_LoteTerminado = spLotes1.Select_Record(row.Cells("LoteID").Value, dtb.Transaccion) 'dgvGrilla.CurrentRow.Cells("LoteID").Value, BasesParaCompatibilidad.BD.transaction)

                    'Grabar movimiento
                    Dim m_DBO_Movimientos1 As New DBO_Movimientos1
                    m_DBO_Movimientos1.Fecha = Today 'm_DBO_Envasado.Fecha
                    m_DBO_Movimientos1.Observaciones = row.Cells("Observaciones").Value
                    m_DBO_Movimientos1.Cantidad = row.Cells("Cantidad").Value
                    m_DBO_Movimientos1.ProcesoID = 4 'Envasado
                    m_DBO_Movimientos1.EntraDepositoID = vbNull 'tiene que ser un deposito que exista para que no error de Constraints
                    m_DBO_Movimientos1.SaleDepositoID = vbNull
                    m_DBO_Movimientos1.LoteID = System.Convert.ToInt32(m_DBO_LoteTerminado.LoteID)
                    m_DBO_Movimientos1.FiltroID = vbNull
                    m_DBO_Movimientos1.Suma = 1
                    m_DBO_Movimientos1.NuevoLote = 1 'Si generamos nuevo Lote.
                    guardado = guardado And spMovimientos1.GrabarMovimientos1(m_DBO_Movimientos1, dtb.Transaccion)

                    'Crear Lote envasado para que luego podamos sumar sumar todos los componentes del Lote terminado y asi saber la cantidad inicial preparada.
                    m_DBO_LoteEnvasado.Descripcion = "L-" & calendar.DevuelveFechaJuliana(m_DBO_Envasado.Fecha) 'RECUPERAR JULIANO
                    m_DBO_LoteEnvasado.Fecha = m_DBO_Envasado.Fecha 'Tienen que ser la del envasado 
                    m_DBO_LoteEnvasado.CantidadRestante = 0 'Se envasa todo
                    m_DBO_LoteEnvasado.Observacion = String.Empty
                    m_DBO_LoteEnvasado.LoteProveedor = String.Empty
                    m_DBO_LoteEnvasado.Botellas = String.Empty
                    m_DBO_LoteEnvasado.EspecificacionID = 2 ' Pongo el 2 porque es la primera que existe. Con vbNull da error
                    m_DBO_LoteEnvasado.TipoLoteID = 15
                    m_DBO_LoteEnvasado.TipoProductoID = m_Producto
                    m_DBO_LoteEnvasado.SinEspecificacion = False

                    'Generar codigo de Lote
                    'Hay que controlar que sea el 1, 2 etc
                    Dim dia, mes As String
                    If m_DBO_Envasado.Fecha.Day < 10 Then
                        dia = "0" & m_DBO_Envasado.Fecha.Day
                    Else
                        dia = m_DBO_Envasado.Fecha.Day
                    End If
                    If m_DBO_Envasado.Fecha.Month < 10 Then
                        mes = "0" & m_DBO_Envasado.Fecha.Month
                    Else
                        mes = m_DBO_Envasado.Fecha.Month
                    End If
                    m_DBO_LoteEnvasado.CodigoLote = m_DBO_Envasado.Fecha.Year & mes & dia & spTiposProductos.Select_Record(m_Producto, dtb.Transaccion).Abreviatura & "Env"
                    m_DBO_LoteEnvasado.CodigoLote = spLotes1.devolverproximocodigoLote(m_DBO_LoteEnvasado.CodigoLote, BasesParaCompatibilidad.BD.transaction)

                    m_DBO_LoteEnvasado.Revisar = False
                    guardado = guardado And spLotes1.GrabarLotes1(m_DBO_LoteEnvasado, dtb.Transaccion)

                    'Guardar Lote creado en tabla CompuestoPor asignado al Lote envasado creado

                    ' El LoteID del ultimo lote creado 
                    dtb.PrepararConsulta("select max(LoteID) from Lotes")
                    m_DBO_CompuestoPor.LoteFinal = dtb.Consultar.Rows(0).Item(0)
                    m_DBO_CompuestoPor.LotePartida = row.Cells("LoteID").Value
                    'Comprobar que necesitamos el MovimientoID para poder borrar, editar, etc.
                    dtb.PrepararConsulta("select max(MovimientoID) from Movimientos")
                    m_DBO_CompuestoPor.MovimientoID = dtb.Consultar().Rows(0).Item(0)
                    m_DBO_CompuestoPor.Cantidad = row.Cells("Cantidad").Value
                    guardado = guardado And spCompuestoPor.CompuestoPorInsert(m_DBO_CompuestoPor, dtb.Transaccion)


                    'Descontar los litros del lote terminado
                    Dim m_CantidadRestante As Integer = System.Convert.ToInt32(m_DBO_LoteTerminado.CantidadRestante) - row.Cells("Cantidad").Value

                    guardado = guardado And spLotes1.Lotes1UpdateCantidadRestante(m_DBO_LoteTerminado.LoteID, m_CantidadRestante, dtb.Transaccion)

                    If Not row.Cells("Merma").Value Is Nothing And row.Cells("Merma").Value <> 0 Then ''añadir al mdbo el campo merma, que es el que se guardara en el frment
                        Dim spFormato As New spFormatosEnvasados
                        Dim m_dbo_FormatosEnvasados As DBO_FormatosEnvasados = spFormato.Select_Record(row.Cells("FormatoEnvasadoID").Value, dtb.Transaccion)
                        Dim m_dbo_Envasado As DBO_Envasados2 = spEnvasados2.Select_Record(m_dbo_FormatosEnvasados.EnvasadoID, dtb.Transaccion)

                        m_dbo_diferencias.CantidadRestante = row.Cells("Merma").Value
                        m_dbo_diferencias.CodigoLote = row.Cells("Lote").Value
                        m_dbo_diferencias.Fecha = m_dbo_Envasado.Fecha.Date 'New Date(m_dbo_Envasado.Fecha.Year, m_dbo_Envasado.Fecha.Month, m_dbo_Envasado.Fecha.Day).Date  'm_dbo_Envasado.Fecha
                        m_dbo_diferencias.LoteID = row.Cells("LoteID").Value 'le pasamos un valor tipo para recuperar datos en la insercion                                
                        guardado = guardado And spLotes1.GuardarLoteDiferencias(Me.m_dbo_diferencias, dtb)
                    End If

                    contador += 1
                Next


                If guardado Then
                    dtb.TerminarTransaccion()
                    butGenerarTrasiegos.Visible = False
                    Me.butGuardar.Enabled = False
                    Me.lTrasiegos.Visible = True
                Else
                    dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudieron generar los movimientos, vuelva a intentarlo", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If

            Catch ex As Exception
                dtb.CancelarTransaccion()
                MessageBox.Show(ex.Message, "Error al generar trasiegos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub frmEnvasadosProductosArticulos_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        If Me.comprobarTrasiegos Then
            Me.butGenerarTrasiegos.Visible = False
            butGuardar.Enabled = False
            Me.lTrasiegos.Visible = True
        End If
    End Sub

    Private Function comprobarTrasiegos() As Boolean
        If Me.dgvGrilla.RowCount > 0 Then
            m_DBO_LoteTerminado = spLotes1.Select_Record(dgvGrilla.CurrentRow.Cells("LoteID").Value, BasesParaCompatibilidad.BD.transaction)
            If CType(sp, spEnvasadosProductosArticulos).ExistenTrasiegos(m_DBO_LoteTerminado.LoteID) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function
End Class
