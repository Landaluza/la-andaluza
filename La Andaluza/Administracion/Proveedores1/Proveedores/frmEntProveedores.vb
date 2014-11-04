Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEntProveedores
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Proveedores As DBO_Proveedores
    Private spProveedoresCero As spProveedoresCero
    ' Private widthStandar As Integer
    Private Const PathCarpetaBase As String = "Z:\Compras\Proveedores\"
    Protected frmProveedores_Articulos As frmProveedores_Articulos
    Private frmProveedoresMailsPedidos As frmProveedoresMailsPedidos
    Private frmProveedoresDocumentos As frmProveedoresDocumentos
    Private frmReuniones As frmReuniones
    Private frHijo As BasesParaCompatibilidad.FrmAheredarOld
    Private spPaises As spPaises
    Private sptiposProveedoresCero As spTiposProveedoresCero
    Private spProvincias As spProvincias
    Private spPoblaciones As spPoblaciones
    Private frmTiposMateriales_Provedores As frmTiposMateriales_Provedores
    Private spProveedores_ProveedoresTipos As spProveedores_ProveedoresTipos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProveedores = Nothing, Optional ByRef v_dbo As DBO_Proveedores = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spProveedores, v_sp)
        m_DBO_Proveedores = If(v_dbo Is Nothing, New DBO_Proveedores, v_dbo)
        dbo = m_DBO_Proveedores

        dtb = New BasesParaCompatibilidad.DataBase()
        Me.spProveedoresCero = New spProveedoresCero()
        spProveedores_ProveedoresTipos = New spProveedores_ProveedoresTipos
        Me.spPaises = New spPaises
        Me.sptiposProveedoresCero = New spTiposProveedoresCero()
        Me.spProvincias = New spProvincias
        Me.spPoblaciones = New spPoblaciones

        frmProveedores_Articulos = New frmProveedores_Articulos(Me.m_DBO_Proveedores.ProveedorID)
        frmProveedoresMailsPedidos = New frmProveedoresMailsPedidos(m_DBO_Proveedores.ProveedorID)
        frmProveedoresDocumentos = New frmProveedoresDocumentos(m_DBO_Proveedores.ProveedorID, Me.txtCarpeta.Text)
        frmReuniones = New frmReuniones(Me.m_DBO_Proveedores.ProveedorID, Me.txtCarpeta.Text)
        frmTiposMateriales_Provedores = New frmTiposMateriales_Provedores(Me.m_DBO_Proveedores.ProveedorID, True)
        Engine_LA.FormEnPestaña(frmProveedores_Articulos, tbpArticulos)
        Engine_LA.FormEnPestaña(frmProveedoresMailsPedidos, tbpContactos)
        Engine_LA.FormEnPestaña(frmProveedoresDocumentos, tbpDocumentos)
        Engine_LA.FormEnPestaña(frmReuniones, tpReuniones)
        Engine_LA.FormEnPestaña(frmTiposMateriales_Provedores, tpMateriales)
    End Sub

    Private Sub frmEntProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        spPaises.cargar_ComboBox(Me.cbPais, dtb)

        sptiposProveedoresCero.cargar_ComboBox(Me.cboTipoProveedorCero, dtb)
    End Sub

    'Private Sub rellenarPestañas()



    '    'Me.frhijo = frmProveedores_Articulos
    'End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_Proveedores = New DBO_Proveedores
        Else
            Me.m_DBO_Proveedores = dbo
        End If

        txtNombre.Text = m_DBO_Proveedores.Nombre
        txtAlias.Text = m_DBO_Proveedores.Nick
        txtNIF.Text = m_DBO_Proveedores.NIF
        txtRSI.Text = m_DBO_Proveedores.RSI
        txtQS.Text = m_DBO_Proveedores.QS
        txtNTrabajadores.Text = m_DBO_Proveedores.n_trabajadores
        txtCp.Text = m_DBO_Proveedores.Cp
        txtDireccion.Text = m_DBO_Proveedores.Direccion
        txtCp2.Text = m_DBO_Proveedores.Cp2
        txtDireccion2.Text = m_DBO_Proveedores.Direccion2
        txtCarpeta.Text = m_DBO_Proveedores.Ruta
        txtInformacion.Text = m_DBO_Proveedores.InformacionGeneral
        cbProveedorActivo.Checked = m_DBO_Proveedores.Activo

        If Me.ModoDeApertura = INSERCION Then
            cbPais.SelectedValue = 198
            Me.TabControl1.Enabled = False
        Else
            Me.TabControl1.Enabled = True
            If m_DBO_Proveedores.Id_poblacion = Nothing Then
                cbPais.SelectedValue = 198
            Else
                Try
                    dtb.PrepararConsulta("Select id_pais, id_provincia from provincias, poblaciones where poblaciones.id_provincia = provincias.id and poblaciones.id = @id")
                    dtb.AñadirParametroConsulta("@id", m_DBO_Proveedores.Id_poblacion)
                    Dim dt As DataTable = dtb.Consultar()
                    cbPais.SelectedValue = dt.Rows(0).Item(0)
                    cbProvincia.SelectedValue = dt.Rows(0).Item(1)

                    dtb.PrepararConsulta("Select id_pais, id_provincia from provincias, poblaciones where poblaciones.id_provincia = provincias.id and poblaciones.id = @id")
                    dtb.AñadirParametroConsulta("@id", m_DBO_Proveedores.Id_poblacion2)
                    dt = dtb.Consultar()
                    cbPais2.SelectedValue = dt.Rows(0).Item(0)
                    cbProvincia2.SelectedValue = dt.Rows(0).Item(1)
                Catch ex As Exception
                End Try

                cbPoblacion.SelectedValue = m_DBO_Proveedores.Id_poblacion
                cbPoblacion2.SelectedValue = m_DBO_Proveedores.Id_poblacion2
            End If

            If cbPoblacion2.SelectedValue <> Nothing Or txtDireccion2.Text <> "" Or txtCp2.Text <> "" Then
                Me.cbSegundaDireccion.Checked = True
                Me.PanelDireccion2.Enabled = True
            End If
        End If

        'm_DBO_Proveedores.proveedorCero = New DBO_ProveedoresCero
        m_DBO_Proveedores.proveedorCero = Me.spProveedoresCero.Select_Record(Me.m_DBO_Proveedores.ProveedorID, dtb)
        If Not m_DBO_Proveedores.proveedorCero Is Nothing Then
            If m_DBO_Proveedores.proveedorCero.Id <> Nothing Then
                Me.cbProveedorCero.Checked = True
                Me.txtCapacidadProductiva.Text = m_DBO_Proveedores.proveedorCero.CapacidadProductivaTotal
                Me.rbResultadoFinancieroPositivo.Checked = m_DBO_Proveedores.proveedorCero.ResultadoFinacieroUltimos3Años
                Me.rbResultadoFinacieroNegativo.Checked = Not m_DBO_Proveedores.proveedorCero.ResultadoFinacieroUltimos3Años
                Me.txtconsumo.Text = m_DBO_Proveedores.proveedorCero.ConsumoParaMercadona
                Me.cbCompromisocalidad.Checked = m_DBO_Proveedores.proveedorCero.CompromisoCalidad
                Me.txtEmpleadosSectorPrimario.Text = m_DBO_Proveedores.proveedorCero.EmpleadosSectorPrimario
            Else
                Me.cbProveedorCero.Checked = False
                m_DBO_Proveedores.proveedorCero = New DBO_ProveedoresCero
            End If
        Else
            Me.cbProveedorCero.Checked = False
            m_DBO_Proveedores.proveedorCero = New DBO_ProveedoresCero
        End If
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If txtNombre.Text = "" Then
            If errores = "" Then txtNombre.Focus()
            errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_Proveedores.Nombre = txtNombre.Text
        End If

        m_DBO_Proveedores.Nick = txtAlias.Text
        m_DBO_Proveedores.NIF = txtNIF.Text
        m_DBO_Proveedores.RSI = txtRSI.Text
        m_DBO_Proveedores.Ruta = txtCarpeta.Text
        m_DBO_Proveedores.InformacionGeneral = txtInformacion.Text
        m_DBO_Proveedores.Activo = Me.cbProveedorActivo.Checked

        If Not IsNumeric(txtQS.Text) Then

            If errores = "" Then txtQS.Focus()
            errores = errores & "El campo QS debe ser numérico y distinto de 0." & Environment.NewLine

        Else
            If txtQS.Text = 0 Then
                If errores = "" Then txtQS.Focus()
                errores = errores & "El campo QS debe ser numérico y distinto de 0." & Environment.NewLine
            End If
            m_DBO_Proveedores.QS = System.Convert.ToInt32(txtQS.Text)
        End If

        m_DBO_Proveedores.n_trabajadores = System.Convert.ToInt32(txtNTrabajadores.Text)

        If cbPoblacion.SelectedValue Is Nothing Then
            If errores = "" Then cbPoblacion.Focus()
            errores = errores & "No seleccionó un valor para población." & Environment.NewLine
        Else
            m_DBO_Proveedores.Id_poblacion = System.Convert.ToInt32(cbPoblacion.SelectedValue)
        End If

        If txtCp.Text <> "" Then
            If IsNumeric(txtCp.Text) And txtCp.Text.Length = 5 Then
                m_DBO_Proveedores.Cp = txtCp.Text
            Else
                errores = errores & "El campo 'Código postal' no tiene el formato correcto." & Environment.NewLine
            End If
        End If
        m_DBO_Proveedores.Direccion = txtDireccion.Text

        If Me.cbSegundaDireccion.Checked Then
            If cbPoblacion2.SelectedValue <> Nothing Then
                m_DBO_Proveedores.Id_poblacion2 = System.Convert.ToInt32(cbPoblacion2.SelectedValue)
            End If

            If txtCp2.Text <> "" Then
                If IsNumeric(txtCp2.Text) And txtCp2.Text.Length = 5 Then
                    m_DBO_Proveedores.Cp2 = txtCp2.Text
                Else
                    errores = errores & "El campo 'Código postal2' no tiene el formato correcto." & Environment.NewLine
                End If
            End If
            m_DBO_Proveedores.Direccion2 = txtDireccion2.Text
        Else
            m_DBO_Proveedores.Direccion2 = String.Empty
            m_DBO_Proveedores.Cp2 = String.Empty
            m_DBO_Proveedores.Id_poblacion2 = Nothing
        End If

        If Me.cbProveedorCero.Checked Then

            If Me.txtCapacidadProductiva.Text = "" Or Not IsNumeric(Me.txtCapacidadProductiva.Text) Then
                errores = errores & "El valor 'Capacidad productiva total' debe ser numérico." & Environment.NewLine
            Else
                Me.m_DBO_Proveedores.proveedorCero.CapacidadProductivaTotal = Me.txtCapacidadProductiva.Text
            End If

            If Me.txtconsumo.Text = "" Or Not IsNumeric(Me.txtconsumo.Text) Then
                errores = errores & "El valor 'Consumo de JR/VLA para Mercadona' debe ser numérico." & Environment.NewLine
            Else
                Me.m_DBO_Proveedores.proveedorCero.ConsumoParaMercadona = Me.txtconsumo.Text
            End If

            Me.m_DBO_Proveedores.proveedorCero.ResultadoFinacieroUltimos3Años = Me.rbResultadoFinancieroPositivo.Checked

            If Me.txtEmpleadosSectorPrimario.Text = "" Or Not IsNumeric(Me.txtEmpleadosSectorPrimario.Text) Then
                errores = errores & "El valor 'Empleados sector primario' debe ser numérico." & Environment.NewLine
            Else
                Me.m_DBO_Proveedores.proveedorCero.EmpleadosSectorPrimario = Me.txtEmpleadosSectorPrimario.Text
            End If

            Me.m_DBO_Proveedores.proveedorCero.CompromisoCalidad = Me.cbCompromisocalidad.Checked

            If cboTipoProveedorCero.SelectedValue <> Nothing Then
                Me.m_DBO_Proveedores.proveedorCero.Id_tipoProveedorCero = cboTipoProveedorCero.SelectedValue
            Else
                errores = errores & "No seleccionó un valor para el campo 'tipo de proveedor cero'." & Environment.NewLine
            End If
        End If

        If Me.txtCarpeta.Text <> "" Then
            If Me.ModoDeApertura = INSERCION Then
                If Not System.IO.Directory.Exists(Me.txtCarpeta.Text) Then
                    System.IO.Directory.CreateDirectory(Me.txtCarpeta.Text)
                    If Not IO.File.Exists(Me.txtCarpeta.Text) Then
                        errores = errores & "No se pudo crear la carpeta." & Environment.NewLine
                    End If
                End If
            Else
                If Not System.IO.Directory.Exists(Me.txtCarpeta.Text) Then
                    errores = errores & "La carpeta no existe." & Environment.NewLine
                End If
            End If
        End If

        If errores = String.Empty Then
            dbo = m_DBO_Proveedores
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado los siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        If Me.GetValores Then
            Dim terminar As Boolean
            If Not dtb Is Nothing Then
                Me.dtb = dtb
                terminar = False
            Else
                terminar = True
            End If

            If terminar Then Me.dtb.EmpezarTransaccion()

            Try

                If sp.Grabar(dbo, Me.dtb) Then

                    If Me.ModoDeApertura = INSERCION Then
                        dtb.PrepararConsulta("select max(proveedorid) from proveedores")
                        Me.m_DBO_Proveedores.ProveedorID = Me.dtb.Consultar().Rows(0).Item(0)
                    End If

                    If Me.grabarProveedoresTipos(Me.dtb) Then

                        If Me.cbProveedorCero.Checked Then
                            Me.m_DBO_Proveedores.proveedorCero.Id_proveedor = Me.m_DBO_Proveedores.ProveedorID

                            If Me.spProveedoresCero.Grabar(Me.m_DBO_Proveedores.proveedorCero, Me.dtb) Then

                                If terminar Then Me.dtb.TerminarTransaccion()
                                RaiseEvent afterSave(Me, Nothing)
                                Me.Close()
                            Else
                                If terminar Then
                                    Me.dtb.CancelarTransaccion()
                                    MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    Throw New Exception("No se pudo guardar los datos de proveedor")
                                End If
                            End If
                        Else
                            If Not Me.spProveedoresCero.Delete(Me.m_DBO_Proveedores.ProveedorID, Me.dtb) And Me.ModoDeApertura = MODIFICACION Then
                                If terminar Then
                                    Me.dtb.CancelarTransaccion()
                                    MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Else
                                    Throw New Exception("Error guardanbdo los datos de proveedor cero")
                                End If
                            Else
                                If terminar Then Me.dtb.TerminarTransaccion()
                                RaiseEvent afterSave(Me, Nothing)
                                Me.Close()
                            End If

                            'Me.spProveedoresCero.Delete(Me.m_DBO_Proveedores.ProveedorID,dtb)
                        End If
                    Else

                        If terminar Then
                            Me.dtb.CancelarTransaccion()
                            MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Else
                            Throw New Exception("Error 1 al gaurdar el registro")
                        End If
                    End If
                Else
                    If terminar Then
                        Me.dtb.CancelarTransaccion()
                        MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Throw New Exception("Error 2 al guardar el registro")
                    End If
                End If
            Catch ex As Exception
                If terminar Then
                    Me.dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine & Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Throw New Exception("Error 3 al guardar el registro")
                End If

            End Try
        End If
    End Sub

    Public Function grabarProveedoresTipos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim retorno As Boolean = True
        Dim m_Proveedor_ProveedorTipo As New DBO_Proveedores_ProveedoresTipos
        'Dim i As Integer = 0
        dgvProveedores.EndEdit()

        retorno = retorno And spProveedores_ProveedoresTipos.Proveedores_ProveedoresTiposDeleteByProveedorID(Me.m_DBO_Proveedores.ProveedorID, dtb)

        For Each row As DataGridViewRow In dgvProveedores.Rows
            If row.Cells(2).Value Then
                m_Proveedor_ProveedorTipo.ProveedorID = Me.m_DBO_Proveedores.ProveedorID
                m_Proveedor_ProveedorTipo.ProveedorTipoID = row.Cells(0).Value.ToString
                m_Proveedor_ProveedorTipo.FechaModificacion = System.DateTime.Now.Date
                m_Proveedor_ProveedorTipo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
                retorno = retorno And spProveedores_ProveedoresTipos.GrabarProveedores_ProveedoresTiposSinTransaccion(m_Proveedor_ProveedorTipo, dtb)
            End If


            'If dgvProveedores.Rows(i).Cells(2).Value Then
            '    m_Proveedor_ProveedorTipo.ProveedorID = Me.m_DBO_Proveedores.ProveedorID
            '    m_Proveedor_ProveedorTipo.ProveedorTipoID = dgvProveedores.Rows(i).Cells(0).Value.ToString
            '    m_Proveedor_ProveedorTipo.FechaModificacion = System.DateTime.Now.date
            '    m_Proveedor_ProveedorTipo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
            '    retorno = retorno And spProveedores_ProveedoresTipos.GrabarProveedores_ProveedoresTiposSinTransaccion(m_Proveedor_ProveedorTipo, mytrans)
            'End If
            'i = i + 1
        Next

        If Not retorno Then dgvProveedores.BeginEdit(True)
        Return retorno
    End Function

    Private Sub SplitContainer1_Panel2_Resize(sender As System.Object, e As System.EventArgs) Handles SplitContainer1.Panel2.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.gbProveedorCero, SplitContainer1.Panel2)
    End Sub

    Private Sub cbPais_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbPais.SelectedValueChanged
        Try
            Me.spProvincias.cargar_ComboBox(cbProvincia, Me.cbPais.SelectedValue, dtb)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbPais2_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbPais2.SelectedValueChanged
        Try
            Me.spProvincias.cargar_ComboBox(cbProvincia2, Me.cbPais2.SelectedValue, dtb)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbProvincia_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProvincia.SelectedValueChanged
        Try
            Me.spPoblaciones.cargar_ComboBox(Me.cbPoblacion, Me.cbProvincia.SelectedValue, dtb)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbProvincia2_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cbProvincia2.SelectedValueChanged
        Try
            Me.spPoblaciones.cargar_ComboBox(Me.cbPoblacion2, Me.cbProvincia2.SelectedValue, dtb)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbProveedorCero_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbProveedorCero.CheckedChanged
        PanelProveedorCero()
    End Sub

    Private Sub PanelProveedorCero()
        Me.SplitContainer1.Panel2Collapsed = Not Me.cbProveedorCero.Checked
    End Sub

    Private Sub AntesDemostrar() Handles MyBase.afterShown
        'Dim h As Integer
        'If Me.ModoDeApertura <> BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION Then
        '    h = Me.SplitContainer2.Panel1.Height
        '    'Me.SplitContainer2.Panel2Collapsed = True
        '    Me.Height = Me.Height - h
        '    'Else
        '    '    rellenarPestañas()
        'End If

        'Me.widthStandar = Me.SplitContainer1.Panel2.Width
        If Me.cbProveedorCero.Checked Then
            Me.SplitContainer1.Panel2Collapsed = False
        Else
            Me.SplitContainer1.Panel2Collapsed = True
        End If

        dtb.PrepararConsulta("Proveedores_ProveedoresTiposSelectByProveedorID @id")
        dtb.AñadirParametroConsulta("@id", Me.m_DBO_Proveedores.ProveedorID)

        With dgvProveedores
            .DataSource = dtb.Consultar()
            .Columns(0).Visible = False
            .Columns(2).Width = 30
            .FormatoColumna("ProveedorTipo", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            .RowHeadersWidth = 14
        End With
    End Sub

    Private Sub btnTipoProveedorCeroAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnTipoProveedorCeroAdd.Click
        Dim frm As New frmEntTiposProveedoresCero(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposProveedoresCero, New DBO_TiposProveedoresCero)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        sptiposProveedoresCero.cargar_ComboBox(Me.cboTipoProveedorCero, dtb)
    End Sub

    Private Sub butCarpeta_Click(sender As System.Object, e As System.EventArgs) Handles butCarpeta.Click
        Dim FolderBrowserDialog1 As New FolderBrowserDialog

        With FolderBrowserDialog1
            .RootFolder = Environment.SpecialFolder.MyComputer
            '.SelectedPath = "Z:\Compras\Proveedores\1&1 Internet España\"
            .SelectedPath = "Z:\Compras\Proveedores\"
            .Description = "Selecciona la carpeta del proveedor"
            .ShowNewFolderButton = True

            If .ShowDialog = DialogResult.OK Then
                Me.txtCarpeta.Text = .SelectedPath
            End If
        End With
    End Sub

    Private Sub cbSegundaDireccion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbSegundaDireccion.CheckedChanged
        Me.PanelDireccion2.Enabled = Me.cbSegundaDireccion.Checked
    End Sub

    Private Sub txtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNombre.TextChanged
        Me.txtCarpeta.Text = PathCarpetaBase + Me.txtNombre.Text
    End Sub

    Private Sub btnInformacion_Click(sender As System.Object, e As System.EventArgs) Handles btnInformacion.Click
        Dim fc As New OpenFileDialog
        fc.InitialDirectory = Me.txtCarpeta.Text
        fc.ShowDialog()

        Try
            Me.txtInformacion.Text = fc.FileName
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddPoblacion_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPoblacion.Click, btnAddPoblacion2.Click
        Dim dboPoblacion As New DBO_Poblaciones

        If sender Is Me.btnAddPoblacion2 Then
            dboPoblacion.Id_provincia = Me.cbProvincia.SelectedValue
        Else
            dboPoblacion.Id_provincia = Me.cbProvincia.SelectedValue
        End If

        Dim frm As New frmEntPoblaciones(BasesParaCompatibilidad.DetailedSimpleForm.VISION, New spPoblaciones, dboPoblacion)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

        Try
            Me.spPoblaciones.cargar_ComboBox(Me.cbPoblacion, Me.cbProvincia2.SelectedValue, dtb)
        Catch ex As Exception
        End Try
        Try
            Me.spPoblaciones.cargar_ComboBox(Me.cbPoblacion2, Me.cbProvincia2.SelectedValue, dtb)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddPais_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPais.Click, btnAddPais2.Click
        Dim frm As New frmEntPaises
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        spPaises.cargar_ComboBox(Me.cbPais, dtb)
        spPaises.cargar_ComboBox(Me.cbPais2, dtb)
    End Sub

    Private Sub btnAddProvincia_Click(sender As System.Object, e As System.EventArgs) Handles btnAddProvincia.Click, btnAddProvincia2.Click
        Dim dboProvincia As New DBO_Provincias
        If sender Is Me.btnAddProvincia2 Then
            dboProvincia.Id_pais = cbPais.SelectedValue
        Else
            dboProvincia.Id_pais = cbPais2.SelectedValue
        End If

        Dim frm As New frmEntProvincias(BasesParaCompatibilidad.DetailedSimpleForm.VISION, New spProvincias, dboProvincia)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Try
            Me.spProvincias.cargar_ComboBox(cbProvincia, Me.cbPais.SelectedValue, dtb)
        Catch ex As Exception
        End Try
        Try
            Me.spProvincias.cargar_ComboBox(cbProvincia2, Me.cbPais2.SelectedValue, dtb)
        Catch ex As Exception
        End Try
    End Sub

End Class
