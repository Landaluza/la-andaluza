Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntIncidencias_SU
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_Incidencias As DBO_Incidencias
    Private frmIncidenciasCalidad As frmEntIncidenciasCalidad
    Private frmIncidenciasEmpleados As frmIncidenciasEmpleados
    Private linea As Integer
    Private spTiposIncidencias As spTiposIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spIncidencias = Nothing, Optional ByRef v_dbo As DBO_Incidencias = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spIncidencias, v_sp)
        m_DBO_Incidencias = If(v_dbo Is Nothing, New DBO_Incidencias, v_dbo)
        dbo = m_DBO_Incidencias

        spTiposIncidencias = New spTiposIncidencias
        dtpHoraFin.activarFoco()
        dtpHoraInicio.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spIncidencias, New DBO_Incidencias)
        InitializeComponent()
        spTiposIncidencias = New spTiposIncidencias
        dtpHoraFin.activarFoco()
        dtpHoraInicio.activarFoco()
    End Sub

    Private Sub frmEntIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Config.UserType = 3 Then
            Me.butAddTipoIncidenciaID.Enabled = False
            Me.butVerTipoIncidenciaID.Enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_Incidencias = dbo

        spTiposIncidencias.cargar_TiposIncidencias(Me.cboTipoIncidencia, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboTipoIncidencia.Enabled = False
            Me.lblTipoIncidenciaID.Enabled = False
        End If

        Dim s3 As New spMaquinas
        If Me.m_DBO_Incidencias.FormatoEnvasadoID <> Nothing Then
            Dim sformato As New spFormatosEnvasados
            Dim linea As Integer = sformato.select_lineaPorformato(Me.m_DBO_Incidencias.FormatoEnvasadoID, dtb)
            s3.cargar_MaquinasporLinea(Me.cboMaquina, linea, dtb)
            Me.linea = linea
        Else
            s3.cargar_Maquinas(Me.cboMaquina, dtb)
        End If

        Dim s2 As New spCategoriaIncidencias

        If Me.ModoDeApertura = MODIFICACION Then
            If Config.UserType = 4 Then
                Me.cboClase.Enabled = True
                s2.cargar_CategoriaIncidencias(Me.cboClase, dtb)
            Else
                Me.cboClase.Enabled = False
                s2.cargar_CategoriaIncidencias_con_retroCompatibilidad(Me.cboClase, dtb)
            End If

            Dim mTipo As DBO_TiposIncidencias = Me.spTiposIncidencias.Select_Record(m_DBO_Incidencias.TipoIncidenciaID, dtb)
            Me.cboClase.SelectedValue = mTipo.CategoriaIncidenciaID



            If cboClase.SelectedValue = 1 Or cboClase.SelectedValue = 8 Then
                Me.cboMaquina.SelectedValue = mTipo.MaquinaID
            End If

            dtpHoraInicio.Value = DateTime.Now.Date.Add(Me.m_DBO_Incidencias.HoraInicio)
            dtpHoraFin.Value = DateTime.Now.Date.Add(Me.m_DBO_Incidencias.HoraFin)
        Else
            s2.cargar_CategoriaIncidencias(Me.cboClase, dtb)
            Me.cboClase.Enabled = True

            If Me.ModoDeApertura = INSERCION Then
                Dim spFormatosEnvasados As New spFormatosEnvasados
                Dim spEnvasados2 As New spEnvasados2
                Dim dboFormato As DBO_FormatosEnvasados = spFormatosEnvasados.Select_Record(m_DBO_Incidencias.FormatoEnvasadoID, dtb)
                Dim dboEnvasado As DBO_Envasados3 = spEnvasados2.Select_Record(dboFormato.EnvasadoID, dtb, True)

                'dtpHoraInicio.Text = New DateTime(dboEnvasado.Fecha.Year, dboEnvasado.Fecha.Month, dboEnvasado.Fecha.Day)
                'dtpHoraFin.Text = New DateTime(dboEnvasado.Fecha.Year, dboEnvasado.Fecha.Month, dboEnvasado.Fecha.Day)
                dtpHoraInicio.Value = New DateTime(dboEnvasado.Fecha.Year, dboEnvasado.Fecha.Month, dboEnvasado.Fecha.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0)
                dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(15)

                'If cboClase.SelectedValue = 3 Or cboClase.SelectedValue = 7 Then
                '    Dim hora As Integer = CType(DateTime.Now.Hour.ToString.Substring(0, if(DateTime.Now.Hour.ToString.Length > 1, 2, 1)), Integer)
                '    Dim minutos As Integer = CType(DateTime.Now.Minute.ToString.Substring(0, if(DateTime.Now.Minute.ToString.Length > 1, 2, 1)), Integer)

                '    If (hora >= 7 And hora < 15) Or (hora = 6 And minutos >= 54) Then
                '        dtpHoraInicio.Value = New DateTime(dboEnvasado.Fecha.Year, dboEnvasado.Fecha.Month, dboEnvasado.Fecha.Day, 10, 0, 0)
                '        dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(20)
                '    Else
                '        dtpHoraInicio.Value = New DateTime(dboEnvasado.Fecha.Year, dboEnvasado.Fecha.Month, dboEnvasado.Fecha.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0)
                '        dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
                '    End If
                'Else
                '    dtpHoraInicio.Value = New DateTime(dboEnvasado.Fecha.Year, dboEnvasado.Fecha.Month, dboEnvasado.Fecha.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0)
                '    dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
                'End If

                If m_DBO_Incidencias.TipoIncidenciaID <> Nothing Then
                    Me.cboClase.SelectedValue = m_DBO_Incidencias.TipoIncidenciaID
                End If
            End If
        End If

        txtObservaciones.Text = m_DBO_Incidencias.Observaciones
        cboTipoIncidencia.SelectedValue = m_DBO_Incidencias.TipoIncidenciaID

        Dim spformato As New spFormatosEnvasados
        Me.linea = spformato.select_lineaPorformato(Me.m_DBO_Incidencias.FormatoEnvasadoID, dtb)
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty
        Dim ini As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0, 0)
        Dim fin As DateTime = New DateTime(Now.Year, Now.Month, Now.Day, dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0, 0)


        If ini >= fin Then
            If errores = "" Then dtpHoraFin.Focus()
            errores = errores & "La hora de fin no puede ser menor o igual a la de inicio." & Environment.NewLine
        End If

        m_DBO_Incidencias.HoraInicio = New TimeSpan(ini.Hour, ini.Minute, 0)
        m_DBO_Incidencias.HoraFin = New TimeSpan(fin.Hour, fin.Minute, 0)
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

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        'MyBase.Guardar(me.dtb)
        If Me.GetValores Then
            If Not Me.SplitContainer1.Panel2Collapsed Then
                If Not Me.frmIncidenciasCalidad.Comprobar Then
                    Return
                End If
            End If

            dtb.EmpezarTransaccion()
            Try
                If sp.Grabar(dbo, dtb) Then
                    Me.evitarCerrarSinGuardar = False
                    Dim s As New spIncidencias
                    Dim incidenciaId As Integer = s.selecccionar_ultima_incidencia(dtb)
                    frmIncidenciasEmpleados.Incidencia = incidenciaId

                    If Not Me.SplitContainer1.Panel2Collapsed Then
                        If Me.ModoDeApertura = INSERCION Then

                            frmIncidenciasCalidad.Incidencia = incidenciaId

                        End If

                        Me.frmIncidenciasCalidad.Guardar(dtb)

                    End If

                    Me.frmIncidenciasEmpleados.guardar(dtb)

                    dtb.TerminarTransaccion()
                    MyBase.saved()
                    Me.Close()
                Else
                    dtb.CancelarTransaccion()
                    MessageBox.Show("No se pudo guardar el registro. Asegurese de tener conexion a la red.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                dtb.CancelarTransaccion()
                MessageBox.Show("No se pudo guardar el registro. Detalles:" & Environment.NewLine & Environment.NewLine, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub butVerTipoIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTipoIncidenciaID.Click
        Dim frmEnt As New frmTiposIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddTipoIncidenciaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTipoIncidenciaID.Click
        Dim DBO_TiposIncidencias As New DBO_TiposIncidencias
        Dim frmEnt As New frmEntTiposIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, spTiposIncidencias, DBO_TiposIncidencias)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        Me.spTiposIncidencias.cargar_TiposIncidencias(Me.cboTipoIncidencia, dtb)
    End Sub

    Private Sub cboClase_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboClase.SelectedIndexChanged
        Try
            spTiposIncidencias.cargar_TiposIncidenciasporCategoria(Me.cboTipoIncidencia, Me.cboClase.SelectedValue, dtb)

            If Me.ModoDeApertura = INSERCION Then
                If Me.cboClase.SelectedValue = 3 Or Me.cboClase.SelectedValue = 12 Then
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

            If cboClase.SelectedValue = 1 Or cboClase.SelectedValue = 8 Then 'mecanicas
                Me.lblMaquinas.Visible = True
                Me.cboMaquina.Visible = True
                Me.cboMaquina.Enabled = True
                deshabilitarCalidad()
                cboMaquina_SelectedIndexChanged(Nothing, Nothing)
            Else
                Me.lblMaquinas.Visible = False
                Me.cboMaquina.Visible = False
                'If Me.cboMaquina.Enabled Then Me.cboMaquina.Enabled = False

                If cboClase.SelectedValue = 4 Or cboClase.SelectedValue = 7 Then
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
            End If

            Me.cboTipoIncidencia.SelectedValue = spTiposIncidencias.Select_Mas_Usado_Por_Categoria_Y_Linea(Me.cboClase.SelectedValue, linea, dtb)
        Catch ex As Exception
        End Try

        Me.frmIncidenciasEmpleados = New frmIncidenciasEmpleados(Me.m_DBO_Incidencias.ID)
        Engine_LA.FormEnPestaña(Me.frmIncidenciasEmpleados, Me.SplitContainer2.Panel2)
    End Sub

    Private Sub cboMaquina_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMaquina.SelectedIndexChanged
        Try
            If Me.cboMaquina.Enabled Then
                Me.spTiposIncidencias.cargar_TiposIncidenciasporMaquina(Me.cboTipoIncidencia, Me.cboMaquina.SelectedValue, dtb)

                Me.cboTipoIncidencia.SelectedValue = spTiposIncidencias.Select_Mas_Usado_Por_Maquina_Y_Linea(Me.cboMaquina.SelectedValue, linea, dtb)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmEntIncidencias_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        center()
    End Sub

    Private Sub center()
        BasesParaCompatibilidad.pantalla.centerIn(Me.pancontenido, Me.SplitContainer1.Panel1)
        If Not Me.frmIncidenciasCalidad Is Nothing Then
            BasesParaCompatibilidad.pantalla.centerIn(Me.frmIncidenciasCalidad, Me.SplitContainer1.Panel2)
        End If

        Me.CenterToParent()
    End Sub

    Private Sub habilitarCalidad()
        Me.Width = 1150
        Me.Height = 735
        Me.SplitContainer1.Panel2Collapsed = False
        'Me.SplitContainer2.Panel2Collapsed = False
        center()
    End Sub

    Private Sub deshabilitarCalidad()
        Me.SplitContainer1.Panel2Collapsed = True
        'Me.SplitContainer2.Panel2Collapsed = True
        Me.Width = 540
        Me.Height = 600
        center()
    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        GUImain.OpenHelp("incidencias")
    End Sub

    'Private Sub dtpHoraInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHoraInicio.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    'Private Sub dtpHoraFin_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpHoraFin.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

End Class
