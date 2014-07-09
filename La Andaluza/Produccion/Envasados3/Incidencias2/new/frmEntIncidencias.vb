Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntIncidencias
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Incidencias As DBO_Incidencias
    Private frmIncidenciasCalidad As frmEntIncidenciasCalidad
    Private frmIncidenciasEmpleados As frmIncidenciasEmpleados
    Private linea As Integer
    Private spTiposIncidencias As spTiposIncidencias
    Private clase As Integer

    Public WriteOnly Property ClaseIncidencia As Integer
        Set(value As Integer)
            Me.clase = value
        End Set
    End Property

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spIncidencias = Nothing, Optional ByRef v_dbo As DBO_Incidencias = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spIncidencias, v_sp)
        m_DBO_Incidencias = If(v_dbo Is Nothing, New DBO_Incidencias, v_dbo)
        dbo = m_DBO_Incidencias
        spTiposIncidencias = New spTiposIncidencias
        dtpHoraInicio.activarFoco()
        dtpHoraFin.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spIncidencias, New DBO_Incidencias)
        InitializeComponent()
        spTiposIncidencias = New spTiposIncidencias
    End Sub

    Private Sub frmEntIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Config.UserType = 3 Then
            Me.butAddTipoIncidenciaID.Enabled = False
            Me.butVerTipoIncidenciaID.Enabled = False
        Else
            If Me.ModoDeApertura = VISION Then
                Me.cboTipoIncidencia.Enabled = False
                Me.lblTipoIncidenciaID.Enabled = False
            End If
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.clase = Nothing Then
            MessageBox.Show("Error en la carga, no se especifico la clase de la incidencia", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Dispose()
        End If

        Me.m_DBO_Incidencias = dbo
        cboClase_SelectedIndexChanged()
        txtObservaciones.Text = m_DBO_Incidencias.Observaciones

        Dim s3 As New spMaquinas
        If Me.m_DBO_Incidencias.FormatoEnvasadoID <> Nothing Then
            Dim sformato As New spFormatosEnvasados
            Dim linea As Integer = sformato.select_lineaPorformato(Me.m_DBO_Incidencias.FormatoEnvasadoID)
            s3.cargar_MaquinasporLinea(Me.cboMaquina, linea)
            Me.linea = linea
        Else
            s3.cargar_Maquinas(Me.cboMaquina)
        End If

        Dim s2 As New spCategoriaIncidencias
        If Me.ModoDeApertura = MODIFICACION Then
            Dim mTipo As DBO_TiposIncidencias = Me.spTiposIncidencias.Select_Record(m_DBO_Incidencias.TipoIncidenciaID)

            If Me.clase = 1 Or Me.clase = 8 Then
                Me.cboMaquina.SelectedValue = mTipo.MaquinaID
            End If

            dtpHoraInicio.Value = DateTime.Now.Date.Add(Me.m_DBO_Incidencias.HoraInicio)
            dtpHoraFin.Value = DateTime.Now.Date.Add(Me.m_DBO_Incidencias.HoraFin)
            cboTipoIncidencia.SelectedValue = Me.m_DBO_Incidencias.TipoIncidenciaID
        Else

            If Me.ModoDeApertura = INSERCION Then
                Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
                Dim spFormatosEnvasados As New spFormatosEnvasados
                Dim spEnvasados2 As New spEnvasados2
                Dim dboFormato As DBO_FormatosEnvasados = spFormatosEnvasados.Select_Record(m_DBO_Incidencias.FormatoEnvasadoID)
                Dim dboEnvasado As DBO_Envasados3 = spEnvasados2.Select_Record(dboFormato.EnvasadoID, dtb)

                If Not dboEnvasado Is Nothing Then
                    dtpHoraInicio.Value = New DateTime(dboEnvasado.Fecha.Year, dboEnvasado.Fecha.Month, dboEnvasado.Fecha.Day, Now.Hour, Now.Minute, 0)
                Else
                    dtpHoraInicio.Value = Now.Date
                End If

                dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(15)

            End If
        End If

        Dim spInc As New spCategoriaIncidencias
        lblClaseIncidencia.Text = UCase(spInc.Select_Record(Me.clase).Descripcion)

        Dim spformato As New spFormatosEnvasados
        Me.linea = spformato.select_lineaPorformato(Me.m_DBO_Incidencias.FormatoEnvasadoID)

    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If dtpHoraInicio.Value >= dtpHoraFin.Value Then
            If errores = "" Then dtpHoraFin.Focus()
            errores = errores & "La hora de fin no puede ser menor o igual a la de inicio." & Environment.NewLine
        End If

        m_DBO_Incidencias.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_Incidencias.HoraFin = New TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)
        m_DBO_Incidencias.Observaciones = txtObservaciones.Text

        If cboTipoIncidencia.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoIncidencia.Focus()
            errores = errores & "No seleccionó un valor para TipoIncidenciaID." & Environment.NewLine
        Else
            m_DBO_Incidencias.TipoIncidenciaID = System.Convert.ToInt32(cboTipoIncidencia.SelectedValue)
        End If

        If errores = String.Empty Then
            dbo = m_DBO_Incidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        'MyBase.Guardar(trans)
        If Me.GetValores Then
            If Not Me.SplitContainer1.Panel2Collapsed Then
                If Not Me.frmIncidenciasCalidad.Comprobar Then
                    Return
                End If
            End If

            BasesParaCompatibilidad.BD.EmpezarTransaccion()
            Try
                If sp.Grabar(dbo, BasesParaCompatibilidad.BD.transaction) Then
                    Me.evitarCerrarSinGuardar = False

                    If Not Me.SplitContainer1.Panel2Collapsed Then
                        If Me.ModoDeApertura = INSERCION Then
                            Dim s As New spIncidencias
                            Dim incidenciaId As Integer = s.selecccionar_ultima_incidencia(BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
                            frmIncidenciasCalidad.Incidencia = incidenciaId
                            frmIncidenciasEmpleados.Incidencia = incidenciaId

                            Me.frmIncidenciasEmpleados.guardar(BasesParaCompatibilidad.BD.transaction)
                        End If

                        Me.frmIncidenciasCalidad.Guardar(BasesParaCompatibilidad.BD.transaction)

                    End If

                    BasesParaCompatibilidad.BD.TerminarTransaccion()
                    MyBase.saved()
                    Me.Close()
                Else
                    BasesParaCompatibilidad.BD.CancelarTransaccion()
                    MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                BasesParaCompatibilidad.BD.CancelarTransaccion()
                MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine & Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub butVerTipoIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoIncidenciaID.Click
        Dim frmEnt As New frmTiposIncidencias()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddTipoIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoIncidenciaID.Click
        Dim DBO_TiposIncidencias As New DBO_TiposIncidencias
        Dim frmEnt As New frmEntTiposIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, spTiposIncidencias, DBO_TiposIncidencias)
        frmEnt.ShowDialog()

        Me.spTiposIncidencias.cargar_TiposIncidencias(Me.cboTipoIncidencia)
    End Sub

    Private Sub cboClase_SelectedIndexChanged()
        Try
            If Me.ModoDeApertura = INSERCION Then
                If Me.clase = 12 Then 'Recuperables
                    Dim hora As Integer = CType(DateTime.Now.Hour.ToString.Substring(0, If(DateTime.Now.Hour.ToString.Length > 1, 2, 1)), Integer)
                    Dim minutos As Integer = CType(DateTime.Now.Minute.ToString.Substring(0, If(DateTime.Now.Minute.ToString.Length > 1, 2, 1)), Integer)

                    If (hora >= 7 And hora < 15) Or (hora = 6 And minutos >= 54) Then
                        Me.dtpHoraInicio.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0)
                        Me.dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(20)
                    Else
                        dtpHoraInicio.Value = DateTime.Now
                        dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
                    End If

                End If
            End If

            If Me.clase = 8 Then 'Mecanicas
                Me.lblMaquina.Visible = True
                Me.cboMaquina.Visible = True
                deshabilitarCalidad()
            Else
                Me.lblMaquina.Visible = False
                Me.cboMaquina.Visible = False

                If Me.clase = 7 Then 'Calidad

                    If Me.ModoDeApertura <> INSERCION Then
                        Dim dcalidad As New DBO_IncidenciasCalidad
                        dcalidad.IncidenciaID = Me.m_DBO_Incidencias.ID
                        Me.frmIncidenciasCalidad = New frmEntIncidenciasCalidad(BasesParaCompatibilidad.gridsimpleform.ACCION_MODIFICAR, New spIncidenciasCalidad, dcalidad)
                    Else
                        frmIncidenciasCalidad = New frmEntIncidenciasCalidad()
                    End If

                    Me.frmIncidenciasCalidad.Linea = Me.linea
                    Engine_LA.FormEnPestaña(frmIncidenciasCalidad, Me.SplitContainer1.Panel2)
                    habilitarCalidad()
                Else
                    deshabilitarCalidad()
                End If

                spTiposIncidencias.cargar_TiposIncidenciasporCategoria(Me.cboTipoIncidencia, Me.clase)
                Dim aux As Integer = spTiposIncidencias.Select_Mas_Usado_Por_Categoria_Y_Linea(Me.m_DBO_Incidencias.TipoIncidenciaID, linea)
                If aux <> 0 Then
                    Me.cboTipoIncidencia.SelectedValue = aux
                End If

                If Me.ModoDeApertura = INSERCION Then Me.cboTipoIncidencia.DroppedDown = True
            End If
        Catch ex As Exception
        End Try

        Me.frmIncidenciasEmpleados = New frmIncidenciasEmpleados(Me.m_DBO_Incidencias.ID)
        Engine_LA.FormEnPestaña(Me.frmIncidenciasEmpleados, Me.SplitContainer2.Panel2)


    End Sub

    Private Sub cboMaquina_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaquina.SelectedIndexChanged
        Try
            If cboMaquina.Visible Then
                Me.spTiposIncidencias.cargar_TiposIncidenciasporMaquina(Me.cboTipoIncidencia, Me.cboMaquina.SelectedValue)

                Dim aux As Integer = spTiposIncidencias.Select_Mas_Usado_Por_Maquina_Y_Linea(Me.cboMaquina.SelectedValue, linea)
                If aux <> 0 Then
                    Me.cboTipoIncidencia.SelectedValue = aux
                End If
                Me.cboTipoIncidencia.Focus()
                If Me.ModoDeApertura = INSERCION Then Me.cboTipoIncidencia.DroppedDown = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmEntIncidencias_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        center()
    End Sub

    Private Sub center()
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.pancontenido, Me.SplitContainer1.Panel1)
        If Not Me.frmIncidenciasCalidad Is Nothing Then
            BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.frmIncidenciasCalidad, Me.SplitContainer1.Panel2)
        End If

        Me.CenterToParent()
    End Sub

    Private Sub habilitarCalidad()
        Me.Width = 973 '1650
        Me.SplitContainer1.Panel2Collapsed = False
        center()
    End Sub

    Private Sub deshabilitarCalidad()
        Me.SplitContainer1.Panel2Collapsed = True
        Me.Width = 453 '1100
        center()
    End Sub

    'Private Sub dtpHoraInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHoraInicio.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    'Private Sub dtpHoraFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHoraFin.ValueChanged
    '    If dtpHoraFin.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    Private Sub numMinutos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpnumMinutos.LostFocus
        dtpHoraFin.Value = dtpHoraInicio.Value.AddMinutes(dtpnumMinutos.Value)
    End Sub

    Private Sub ObsMinutos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtObservaciones.LostFocus
        If Me.clase = 8 Then
            Me.cboMaquina.Focus()
            If Me.ModoDeApertura = INSERCION Then Me.cboMaquina.DroppedDown = True
        Else
            Me.cboTipoIncidencia.Focus()
            If Me.ModoDeApertura = INSERCION Then Me.cboTipoIncidencia.DroppedDown = True
        End If
    End Sub

    Private Sub cboTipoIncidencia_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoIncidencia.SelectedValueChanged
        Try
            If Convert.ToString(Me.cboTipoIncidencia.SelectedValue) <> "System.Data.DataRowView" Then
                If Me.cboTipoIncidencia.SelectedValue <> Nothing Then
                    'recuperar los valores del datatable del combobox
                    'Me.lDato1.text = Me.cboTipoIncidencia.SelectedItem(0)
                    'Me.lDato2.text = Me.cboTipoIncidencia.SelectedItem(1)
                    'Me.lDato3.text = Me.cboTipoIncidencia.SelectedItem(2)
                    Me.lDato3.Text = Me.cboTipoIncidencia.SelectedItem(1)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub




End Class
